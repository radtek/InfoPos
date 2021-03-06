﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ISM.Template;
using EServ.Shared;
using DevExpress.XtraCharts;

namespace InfoPos.Issue
{
    public partial class FormProjectEnq : DevExpress.XtraEditors.XtraForm
    {
        #region[ Хувьсагч ]
        InfoPos.Core.Core _core;
        long ProjectID;
        long IssueID = 0;
        DataRow DRProject;
        DataRow DRISSUE;
        object[] OldValue;
        int FileID = 223;
        int RowHandle = 0;
        int SourceRowHandle = 0;
        #endregion
        #region[ Load And Байгууллагч ]
        public FormProjectEnq(InfoPos.Core.Core core, long projectid, long issueid)
        {
            InitializeComponent();
            _core = core;
            ProjectID = projectid;
            IssueID = issueid;
        }
        private void FormIssueTracking_Load(object sender, EventArgs e)
        {
            LoadIssue();

            Result res = _core.RemoteObject.Connection.Call(_core.RemoteObject.User.UserNo, 202, 310070, 310070, new object[] { ProjectID });
            if (res.ResultNo == 0)
            {
                DRProject = res.Data.Tables[0].Rows[0];
            }
            else
            {
                MessageBox.Show(Static.ToStr(res.ResultNo) + " " + res.ResultDesc);
            }
            
            #region[ Set Value ]
            txtIssueProjectNo.EditValue = ProjectID;
            txtIssueProjectName.EditValue = DRProject["Name"].ToString();
            #endregion
            #region[ Image ]

            btnIssueEProject.Image = _core.Resource.GetImage("navigate_refresh");
            btnAddVote.Image = _core.Resource.GetImage("image_like");
            btnEditIssue.Image = _core.Resource.GetImage("navigate_edit");
            btnDeleteIssue.Image = _core.Resource.GetImage("navigate_delete");
            btnAssignee.Image = _core.Resource.GetImage("issue_assign");
            btnLink.Image = _core.Resource.GetImage("issue_link");
            btnComment.Image = _core.Resource.GetImage("menu_txn");
            btnProgress.Image = _core.Resource.GetImage("issue_inprogress");

            IssueImageList.Images.Add(_core.Resource.GetImage("dashboard_user"));
            IssueImageList.Images.Add(_core.Resource.GetImage("gl_ok"));    //9 - Дууссан
            IssueImageList.Images.Add(_core.Resource.GetImage("gl_error")); //1 - Алдаа
            IssueImageList.Images.Add(_core.Resource.GetImage("issue_inprogress"));  //0 - Шинэ


            IssueImageList.Images.Add(_core.Resource.GetImage("issue_image"));
            IssueImageList.Images.Add(_core.Resource.GetImage("issue_document"));
            IssueImageList.Images.Add(_core.Resource.GetImage("issue_other"));
            #endregion
        }
        #endregion
        #region[ Btn And Event ]

        private void btnComment_Click(object sender, EventArgs e)
        {
            FormTxn txnForm = new FormTxn(_core, IssueID, Static.ToInt(DRISSUE["Status"]), Static.ToInt(DRISSUE["ASSIGNEEUSER"]), Static.ToInt(DRISSUE["TRACKID"]));
            txnForm.ShowDialog();
            if (txnForm.ResMain != null)
            {
                if (txnForm.ResMain.ResultNo == 0)
                {
                    LoadIssue();
                }
            }
        }

        private void btnEditIssue_Click(object sender, EventArgs e)
        {
            if (lblEStatus.Text!="Closed")
            {
                if (txtIssueProjectNo.EditValue != null)
                {
                    if (IssueID != 0)
                    {
                        FormIssueTrack frm = new FormIssueTrack(_core, IssueID, Static.ToLong(txtIssueProjectNo.EditValue));
                        frm.ShowDialog();
                        if (frm.ResMain != null)
                        {
                            if (frm.ResMain.ResultNo == 0)
                            {
                                LoadIssue();
                            }
                        }
                    }
                }
            }
        }
        private void btnDeleteIssue_Click(object sender, EventArgs e)
        {
            if (lblEStatus.Text == "InProgress")
            {
                MessageBox.Show("Устгах боломжгүй процесс эхэлсэн байна .", "Мэдээлэл", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (IssueID != 0)
            {
                Result res = new Result();
                res = _core.RemoteObject.Connection.Call(_core.RemoteObject.User.UserNo, FileID, 310118, 310118, new object[] { IssueID });

                if (res.ResultNo == 0)
                {
                    if (res.Data != null)
                    {
                        if (res.Data.Tables[0].Rows.Count != 0)
                        {
                            #region[ Main ]
                            int checkDelete = 0;
                            int votes = Static.ToInt(res.Data.Tables[0].Rows[0]["votes"]);
                            if (votes == 0)
                            {
                                checkDelete++;
                            }
                            else
                            {
                                MessageBox.Show("Устгах боломжгүй санал өгөгдсөн байна .", "Мэдээлэл", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }

                            res = _core.RemoteObject.Connection.Call(_core.RemoteObject.User.UserNo, FileID, 310098, 310098, new object[] { IssueID });
                            if (res.ResultNo == 0)
                            {
                                if (res.Data.Tables[0].Rows.Count == 0)
                                {
                                    checkDelete++;
                                }
                                else
                                {
                                    MessageBox.Show("Устгах боломжгүй хавсралт файл оруулсан байна .", "Мэдээлэл", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }
                            }
                            else
                            {
                                MessageBox.Show(res.ResultDesc, "Мэдээлэл", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }


                            res = _core.RemoteObject.Connection.Call(_core.RemoteObject.User.UserNo, FileID, 310105, 310105, new object[] { IssueID });
                            if (res.ResultNo == 0)
                            {
                                if (res.Data.Tables[0].Rows.Count == 0)
                                {
                                    checkDelete++;
                                }
                                else
                                {
                                    MessageBox.Show("Устгах боломжгүй гүйлгээ хийсэн байна .", "Мэдээлэл", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }
                            }
                            else
                            {
                                MessageBox.Show(res.ResultDesc, "Мэдээлэл", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }

                            if (checkDelete == 3)
                            {
                                DeleteIssue(IssueID);
                            }
                            #endregion
                        }
                        else
                        {
                            MessageBox.Show("Устгах боломжгүй байна .", "Мэдээлэл", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Устгах боломжгүй байна .", "Мэдээлэл", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show(Static.ToStr(res.ResultNo) + " " + res.ResultDesc, "Алдаа", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnLink_Click(object sender, EventArgs e)
        {
            FormLink frm = new FormLink(_core, Static.ToLong(DRISSUE["IssueID"]), Static.ToInt(DRISSUE["ASSIGNEEUSER"]), gvwSourceIssue.RowCount);

            frm.ShowDialog();
            if (frm.ResMain != null)
            {
                if (frm.ResMain.ResultNo == 0)
                {
                    LoadIssue();
                }
            }
        }
        private void btnAssignee_Click(object sender, EventArgs e)
        {
            FormAssign txnForm = new FormAssign(_core, IssueID, Static.ToInt(DRISSUE["ASSIGNEEUSER"]));
            txnForm.ShowDialog();
            if (txnForm.ResMain != null)
            {
                if (txnForm.ResMain.ResultNo == 0)
                {
                    LoadIssue();
                }
            }
        }
        private void btnIssueEProject_Click(object sender, EventArgs e)
        {
            Result res = new Result();
            try
            {
                if (ProjectID != 0)
                {
                    object[] objSearch = new object[23];
                    objSearch[0] = ProjectID;

                    res = _core.RemoteObject.Connection.Call(_core.RemoteObject.User.UserNo, 206, 310069, 310069, objSearch);

                    if (res.ResultNo == 0)
                    {
                        object[] obj = new object[2];
                        obj[0] = res.Data.Tables[0].Rows[0];
                        InfoPos.Enquiry.IssueProjectEnquiry frm = new Enquiry.IssueProjectEnquiry(_core, obj);
                        frm.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show(Static.ToStr(res.ResultNo) + " " + res.ResultDesc);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnProgress_Click(object sender, EventArgs e)
        {
            Result res = new Result();
            try
            {
                if (IssueID != 0)
                {
                    if (lblEStatus.Text == "ReOpen")
                    {
                        res = _core.RemoteObject.Connection.Call(_core.RemoteObject.User.UserNo, FileID, 310120, 310120, new object[] { IssueID, 1 });
                        if (res.ResultNo == 0)
                        {
                            return;
                        }
                        else
                        {
                            MessageBox.Show(Static.ToStr(res.ResultNo) + " " + res.ResultDesc);
                        }
                    }
                    if (lblEStatus.Text == "Open")
                    {
                        res = _core.RemoteObject.Connection.Call(_core.RemoteObject.User.UserNo, FileID, 310120, 310120, new object[] { IssueID, 1 });
                        if (res.ResultNo == 0)
                        {
                            return;
                        }
                        else
                        {
                            MessageBox.Show(Static.ToStr(res.ResultNo) + " " + res.ResultDesc);
                        }
                    }
                    if (lblEStatus.Text == "InProgress")
                    {
                        res = _core.RemoteObject.Connection.Call(_core.RemoteObject.User.UserNo, FileID, 310120, 310120, new object[] { IssueID, 0 });
                        if (res.ResultNo == 0)
                        {
                            return;
                        }
                        else
                        {
                            MessageBox.Show(Static.ToStr(res.ResultNo) + " " + res.ResultDesc);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnAddVote_Click(object sender, EventArgs e)
        {
            if (IssueID != 0)
            {
                Result res = new Result();
                res = _core.RemoteObject.Connection.Call(_core.RemoteObject.User.UserNo, FileID, 310118, 310118, new object[] { IssueID });

                if (res.ResultNo == 0)
                {
                    if (res.Data != null)
                    {
                        if (res.Data.Tables[0].Rows.Count != 0)
                        {
                            int votes = Static.ToInt(res.Data.Tables[0].Rows[0]["votes"]);
                            votes++;
                            res = _core.RemoteObject.Connection.Call(_core.RemoteObject.User.UserNo, FileID, 310117, 310117, new object[] { IssueID, votes });
                            if (res.ResultNo == 0)
                            {
                                MessageBox.Show("Санал амжилттай нэмэгдлээ .");
                                lblVote.Text = "Vote(" + votes.ToString() + ")";
                                btnAddVote.Enabled = false;
                            }
                            else
                            {
                                MessageBox.Show(Static.ToStr(res.ResultNo) + " " + res.ResultDesc, "");
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show(Static.ToStr(res.ResultNo) + " " + res.ResultDesc, "Алдаа", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void gvwSourceIssue_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            SourceRowClick();
        }

        #endregion
        #region[ Function ]

        #region[ Issue ]
        public void RefreshDataIssueAttach()
        {
            Result res = new Result();
            System.IO.FileInfo file;
            try
            {

                if (IssueID != 0)
                {
                    res = _core.RemoteObject.Connection.Call(_core.RemoteObject.User.UserNo, FileID, 310098, 310098, new object[] { IssueID });
                    if (res.ResultNo == 0)
                    {
                        DataTable DTxn = new DataTable("Attach");
                        DataColumn DCol;
                        DataRow RW;
                        DCol = new DataColumn();
                        DCol.ColumnName = "ATTACHID";
                        DCol.DataType = System.Type.GetType("System.Int64");
                        DTxn.Columns.Add(DCol);

                        DCol = new DataColumn();
                        DCol.ColumnName = "FILENAME";
                        DCol.DataType = System.Type.GetType("System.String");
                        DTxn.Columns.Add(DCol);

                        DCol = new DataColumn();
                        DCol.ColumnName = "FILETYPE";
                        DCol.DataType = System.Type.GetType("System.Byte[]");
                        DTxn.Columns.Add(DCol);

                        DCol = new DataColumn();
                        DCol.ColumnName = "CREATEDATE";
                        DCol.DataType = System.Type.GetType("System.DateTime");
                        DTxn.Columns.Add(DCol);

                        DCol = new DataColumn();
                        DCol.ColumnName = "DESCRIPTION";
                        DCol.DataType = System.Type.GetType("System.String");
                        DTxn.Columns.Add(DCol);

                        DataTable DT = res.Data.Tables[0];
                        foreach (DataRow rw in DT.Rows)
                        {
                            file = new System.IO.FileInfo(rw["FILENAME"].ToString());
                            RW = DTxn.NewRow();
                            RW["ATTACHID"] = rw["ATTACHID"];
                            RW["FILENAME"] = file.Name;
                            RW["CREATEDATE"] = rw["CREATEDATE"];
                            RW["DESCRIPTION"] = rw["DESCRIPTION"];

                            if (rw["FILETYPE"].ToString().Trim() == "0")
                            {
                                RW["FILETYPE"] = ISM.Lib.Static.PngImageToByte(_core.Resource.GetImage("issue_image"));
                            }
                            if (rw["FILETYPE"].ToString().Trim() == "1")
                            {
                                RW["FILETYPE"] = ISM.Lib.Static.PngImageToByte(_core.Resource.GetImage("issue_document"));
                            }
                            if (rw["FILETYPE"].ToString().Trim() == "2")
                            {
                                RW["FILETYPE"] = ISM.Lib.Static.PngImageToByte(_core.Resource.GetImage("issue_other"));
                            }
                            DTxn.Rows.Add(RW);
                        }
                        grdAttach.DataSource = DTxn;
                    }
                    else
                    {
                        MessageBox.Show(Static.ToStr(res.ResultNo) + " " + res.ResultDesc);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void RefreshDataIssueTxn()
        {
            Result res = new Result();
            try
            {

                if (IssueID != 0)
                {
                    res = _core.RemoteObject.Connection.Call(_core.RemoteObject.User.UserNo, FileID, 310105, 310105, new object[] { IssueID });
                    if (res.ResultNo == 0)
                    {
                        DataTable DT = res.Data.Tables[0];
                        grdTxn.DataSource = DT;
                        ISM.Template.FormUtility.SetFormatGrid(ref gvwTxn, true);
                    }
                    else
                    {
                        MessageBox.Show(Static.ToStr(res.ResultNo) + " " + res.ResultDesc);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void RefreshDataIssueAttachFromData(DataTable DT)
        {
            System.IO.FileInfo file;
            DataTable DTxn = new DataTable("Attach");
            DataColumn DCol;
            DataRow RW;
            DCol = new DataColumn();
            DCol.ColumnName = "ATTACHID";
            DCol.DataType = System.Type.GetType("System.Int64");
            DTxn.Columns.Add(DCol);

            DCol = new DataColumn();
            DCol.ColumnName = "FILENAME";
            DCol.DataType = System.Type.GetType("System.String");
            DTxn.Columns.Add(DCol);

            DCol = new DataColumn();
            DCol.ColumnName = "FILETYPE";
            DCol.DataType = System.Type.GetType("System.Byte[]");
            DTxn.Columns.Add(DCol);

            DCol = new DataColumn();
            DCol.ColumnName = "CREATEDATE";
            DCol.DataType = System.Type.GetType("System.DateTime");
            DTxn.Columns.Add(DCol);

            DCol = new DataColumn();
            DCol.ColumnName = "DESCRIPTION";
            DCol.DataType = System.Type.GetType("System.String");
            DTxn.Columns.Add(DCol);

            foreach (DataRow rw in DT.Rows)
            {
                file = new System.IO.FileInfo(rw["FILENAME"].ToString());
                RW = DTxn.NewRow();
                RW["ATTACHID"] = rw["ATTACHID"];
                RW["FILENAME"] = file.Name;
                RW["CREATEDATE"] = rw["CREATEDATE"];
                RW["DESCRIPTION"] = rw["DESCRIPTION"];

                if (rw["FILETYPE"].ToString().Trim() == "0")
                {
                    RW["FILETYPE"] = ISM.Lib.Static.PngImageToByte(_core.Resource.GetImage("issue_image"));
                }
                if (rw["FILETYPE"].ToString().Trim() == "1")
                {
                    RW["FILETYPE"] = ISM.Lib.Static.PngImageToByte(_core.Resource.GetImage("issue_document"));
                }
                if (rw["FILETYPE"].ToString().Trim() == "2")
                {
                    RW["FILETYPE"] = ISM.Lib.Static.PngImageToByte(_core.Resource.GetImage("issue_other"));
                }
                DTxn.Rows.Add(RW);
            }
            grdAttach.DataSource = DTxn;
        }
        void RefreshDataIssueTxnFromData(DataTable DT)
        {
            grdTxn.DataSource = DT;
            ISM.Template.FormUtility.SetFormatGrid(ref gvwTxn, true);
        }

        void DeleteIssue(long issueid)
        {
            Result res = new Result();

            try
            {
                DialogResult d = MessageBox.Show("Бичлэгийг утсгахдаа итгэлтэй байна уу?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (d == System.Windows.Forms.DialogResult.No) return;
                if (issueid != 0)
                {
                    res = _core.RemoteObject.Connection.Call(_core.RemoteObject.User.UserNo, FileID, 310083, 310083, new object[] { issueid });

                    if (res.ResultNo == 0)
                    {
                        MessageBox.Show("Амжилттай устгагдлаа");
                        LoadIssue();
                    }
                    else
                    {
                        MessageBox.Show(Static.ToStr(res.ResultNo) + " " + res.ResultDesc);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void LoadIssue()
        {
            Result res = _core.RemoteObject.Connection.Call(_core.RemoteObject.User.UserNo, FileID, 310080, 310080, new object[] { IssueID });
            if (res.ResultNo == 0)
            {
                DRISSUE = res.Data.Tables[0].Rows[0];
                FocusRow(DRISSUE);
            }
            else
            {
                MessageBox.Show("Алдаа : " + res.ResultNo.ToString() + " " + res.ResultDesc);
            }
        }
        void FocusRow(DataRow DR)
        {
            if (DR != null)
            {

                lblSubject.Text = DR["ISSUEID"].ToString() + " - " + DR["SUBJECT"].ToString();
                lblECreateDate.Text = DR["CREATEDATE"].ToString();
                lblECreateUserName.Text = DR["CREATEUSER"].ToString() + " - " + DR["CREATEUSERNAME"].ToString();
                mmeDescription.EditValue = DR["DESCRIPTION"].ToString();
                lblEStatus.Text = DR["STATUSNAME"].ToString();
                if (DR["STATUSNAME"].ToString() == "InProgress")
                {
                    btnProgress.Image = _core.Resource.GetImage("gl_wait");
                }
                else
                {
                    btnProgress.Image = _core.Resource.GetImage("issue_inprogress");
                }
                lblETrackID.Text = DR["TRACKNAME"].ToString();
                IssueID = Static.ToLong(DR["ISSUEID"]);
                if (DR["VOTES"].ToString() == "")
                    lblVote.Text = "Vote(0)";
                else
                    lblVote.Text = "Vote(" + DR["VOTES"].ToString() + ")";
                lblAssigneeUserName.Text = DR["ASSIGNEEUSER"].ToString() + " - " + DR["ASSIGNEEUSERNAME"].ToString();
                int ISSUETYPEID = Static.ToInt(DR["ISSUETYPEID"]);
                Result res = new Result();

                res = _core.RemoteObject.Connection.Call(_core.RemoteObject.User.UserNo, FileID, 310006, 310006, new object[] { ISSUETYPEID, IssueID, _core.RemoteObject.User.UserNo });

                if (res.ResultNo == 0)
                {
                    RefreshDataIssueAttachFromData(res.Data.Tables[2]);
                    RefreshDataIssueTxnFromData(res.Data.Tables[3]);
                    grdSourceIssue.DataSource = res.Data.Tables[1];

                    if (res.Data.Tables[0].Rows.Count != 0)
                    {
                        DataRow rw = res.Data.Tables[0].Rows[0];
                        if (Static.ToInt((rw["Vote"])) == 0)
                        {
                            lblVote.Text = "Vote(Санал асуулга байхгүй)";
                            btnAddVote.Enabled = false;
                        }
                        else
                        {
                            if (res.Data.Tables[5].Rows.Count != 0)
                            {
                                lblVote.ToolTip = "";
                                foreach (DataRow dr in res.Data.Tables[5].Rows)
                                {
                                    lblVote.ToolTip = lblVote.ToolTip + dr["userno"].ToString() + " - " + dr["username"].ToString() + "\r\n";
                                }
                            }

                            if (res.Data.Tables[4].Rows.Count != 0)
                            {
                                DataRow rwVoteUser = res.Data.Tables[4].Rows[0];
                                if (Static.ToInt((rwVoteUser["Vote"])) == 0)
                                {
                                    btnAddVote.Enabled = true;
                                }
                                else
                                {
                                    btnAddVote.Enabled = false;
                                }
                            }
                            else
                            {
                                btnAddVote.Enabled = false;
                            }
                        }
                    }
                    else
                    {
                        btnAddVote.Enabled = false;
                    }

                }
                else
                {
                    MessageBox.Show(res.ResultDesc, "Алдаа", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    lblVote.Text = "Vote(Санал өгөх боломжгүй)";
                    btnAddVote.Enabled = false;
                }



                if (btnAddVote.Enabled == false)
                {
                    btnAllEnableTrue();
                    btnAddVote.Enabled = false;
                }
                else
                {
                    btnAllEnableTrue();
                }
            }
        }
        void FocusRowSourceIssue(DataRow DR)
        {
            if (DR != null)
            {

                lblSubject.Text = DR["ISSUEID"].ToString() + " - " + DR["SUBJECT"].ToString();
                lblECreateDate.Text = DR["CREATEDATE"].ToString();
                lblECreateUserName.Text = DR["CREATEUSER"].ToString() + " - " + DR["CREATEUSERNAME"].ToString();
                mmeDescription.EditValue = DR["DESCRIPTION"].ToString();
                lblEStatus.Text = DR["STATUSNAME"].ToString();
                if (DR["STATUSNAME"].ToString() == "InProgress")
                {
                    btnProgress.Image = _core.Resource.GetImage("gl_wait");
                }
                else
                {
                    btnProgress.Image = _core.Resource.GetImage("issue_inprogress");
                }
                lblETrackID.Text = DR["TRACKNAME"].ToString();
                IssueID = Static.ToLong(DR["ISSUEID"]);
                if (DR["VOTES"].ToString() == "")
                    lblVote.Text = "Vote(0)";
                else
                    lblVote.Text = "Vote(" + DR["VOTES"].ToString() + ")";

                int ISSUETYPEID = Static.ToInt(DR["ISSUETYPEID"]);
                Result res = new Result();

                res = _core.RemoteObject.Connection.Call(_core.RemoteObject.User.UserNo, FileID, 310006, 310006, new object[] { ISSUETYPEID, IssueID, _core.RemoteObject.User.UserNo });

                if (res.ResultNo == 0)
                {
                    RefreshDataIssueAttachFromData(res.Data.Tables[2]);
                    RefreshDataIssueTxnFromData(res.Data.Tables[3]);

                    if (res.Data.Tables[0].Rows.Count != 0)
                    {
                        DataRow rw = res.Data.Tables[0].Rows[0];
                        if (Static.ToInt((rw["Vote"])) == 0)
                        {
                            lblVote.Text = "Vote(Санал асуулга байхгүй)";
                            btnAddVote.Enabled = false;
                        }
                        else
                        {
                            if (res.Data.Tables[5].Rows.Count != 0)
                            {
                                lblVote.ToolTip = "";
                                foreach (DataRow dr in res.Data.Tables[5].Rows)
                                {
                                    lblVote.ToolTip = lblVote.ToolTip + dr["userno"].ToString() + " - " + dr["username"].ToString() + "\r\n";
                                }
                            }

                            if (res.Data.Tables[4].Rows.Count != 0)
                            {
                                DataRow rwVoteUser = res.Data.Tables[4].Rows[0];
                                if (Static.ToInt((rwVoteUser["Vote"])) == 0)
                                {
                                    btnAddVote.Enabled = true;
                                }
                                else
                                {
                                    btnAddVote.Enabled = false;
                                }
                            }
                            else
                            {
                                btnAddVote.Enabled = false;
                            }
                        }
                    }
                    else
                    {
                        btnAddVote.Enabled = false;
                    }

                }
                else
                {
                    MessageBox.Show(res.ResultDesc, "Алдаа", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    lblVote.Text = "Vote(Санал өгөх боломжгүй)";
                    btnAddVote.Enabled = false;
                }
                btnAllEnableFalse();
            }

        }
        public Result DownloadFile(ulong attachid)
        {
            Result r = null;
            if (_core != null)
            {
                FolderBrowserDialog dialog = new FolderBrowserDialog();
                dialog.Description = "Хавсралт файлыг байрлуулах хавтасыг зааж өгнө үү";
                dialog.SelectedPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                DialogResult dr = dialog.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    r = AttachUtility.GetFile(_core.RemoteObject, 310106, attachid, dialog.SelectedPath);
                    string s = "";
                    if (r.ResultNo == 0)
                    {
                        string filename = Convert.ToString(r.Param[0]);
                        s = string.Format("Файл амжилттай хадгаллаа.\r\nХавсралт файлын зам: {0}", filename);
                    }
                    else
                    {
                        s = string.Format("{0}: {1}", r.ResultNo, r.ResultDesc);
                    }
                    MessageBox.Show(s, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            return r;
        }
        public void SourceRowClick()
        {
            Result res = new Result();
            try
            {
                if (gvwSourceIssue.GetFocusedDataRow() != null)
                {
                    DataRow DR = gvwSourceIssue.GetFocusedDataRow();
                    SourceRowHandle = gvwSourceIssue.FocusedRowHandle;
                    res = _core.RemoteObject.Connection.Call(_core.RemoteObject.User.UserNo, FileID, 310080, 310080, new object[] { Static.ToLong(DR[0]) });
                    if (res.ResultNo == 0)
                    {
                        if (res.Data.Tables[0].Rows.Count > 0)
                        {
                            FocusRowSourceIssue(res.Data.Tables[0].Rows[0]);
                        }
                    }
                    else
                    {
                        MessageBox.Show(Static.ToStr(res.ResultNo) + " " + res.ResultDesc);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void btnAllEnableFalse()
        {
            btnProgress.Enabled = false;
            btnAddVote.Enabled = false;
            btnLink.Enabled = false;
            btnAssignee.Enabled = false;
            btnComment.Enabled = false;
        }
        void btnAllEnableTrue()
        {
            btnProgress.Enabled = true;
            btnAddVote.Enabled = true;
            btnLink.Enabled = true;
            btnAssignee.Enabled = true;
            btnComment.Enabled = true;
        }
        void chartIssueLoad()
        {
            ChartIssue.BeginInit();
            Series pSeries = ChartIssue.Series[0];
            PieSeriesView view = new PieSeriesView();
            view.RuntimeExploding = true;
            pSeries.View = view;
            pSeries.Points.Clear();
            DataTable _DT = (DataTable)grdTxn.DataSource;
            if (_DT != null)
            {
                int val_CLOSED = 0;
                int val_RESOLVE = 0;
                int val_COMMENT = 0;
                int val_ASSIGNEE = 0;
                int val_REOPEN = 0;
                int val_OTH = 0;

                foreach (DataRow dr in _DT.Rows)
                {
                    if (dr["ACTIONTYPENAME"].ToString() == "RESOLVE")
                    {
                        val_RESOLVE++;
                    }
                    if (dr["ACTIONTYPENAME"].ToString() == "CLOSED")
                    {
                        val_CLOSED++;
                    }
                    if (dr["ACTIONTYPENAME"].ToString() == "COMMENT")
                    {
                        val_COMMENT++;
                    }
                    if (dr["ACTIONTYPENAME"].ToString() == "ASSIGNEE")
                    {
                        val_ASSIGNEE++;
                    }
                    if (dr["ACTIONTYPENAME"].ToString() == "REOPEN")
                    {
                        val_REOPEN++;
                    }
                    if (dr["ACTIONTYPENAME"].ToString().Trim() == "")
                    {
                        val_OTH++;
                    }
                }

                if (val_CLOSED != 0) pSeries.Points.Add(new SeriesPoint("CLOSED", val_CLOSED));
                if (val_RESOLVE != 0) pSeries.Points.Add(new SeriesPoint("RESOLVE", val_RESOLVE));
                if (val_COMMENT != 0) pSeries.Points.Add(new SeriesPoint("COMMENT", val_COMMENT));
                if (val_ASSIGNEE != 0) pSeries.Points.Add(new SeriesPoint("ASSIGNEE", val_ASSIGNEE));
                if (val_REOPEN != 0) pSeries.Points.Add(new SeriesPoint("REOPEN", val_REOPEN));
                if (val_OTH != 0) pSeries.Points.Add(new SeriesPoint("БУСАД", val_OTH));
            }
            ChartIssue.EndInit();
        }
        #endregion

        private void gvwTxn_DoubleClick(object sender, EventArgs e)
        {
            if (gvwTxn.GetFocusedDataRow() != null)
            {
                DataRow rw = gvwTxn.GetFocusedDataRow();
                InfoPos.Enquiry.IssueTxnEnquiry frm = new Enquiry.IssueTxnEnquiry(_core, Static.ToLong(rw["JRNO"]));
                frm.Show();
            }
        }

        #endregion

        private void gvwTxn_DataSourceChanged(object sender, EventArgs e)
        {
            chartIssueLoad();
        }
    }
}