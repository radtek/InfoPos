﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using EServ.Shared;

namespace InfoPos.Panels
{
    public partial class ucSaleSearch : UserControl
    {
        #region Properties

        private int _pageno = 0;
        public int PageNo
        {
            get { return _pageno; }
        }
        private int _pagecount = 0;
        public int PageCount
        {
            get { return _pagecount; }
        }
        private int _pagerows = 20;
        public int PageRows
        {
            get { return _pagerows; }
            set
            {
                if (value > 0 && value < 100)
                    _pagerows = value;
            }
        }

        private InfoPos.Core.Core _core = null;
        public InfoPos.Core.Core Core
        {
            get { return _core; }
            set
            {
                if (value != null)
                {
                    _core = value;
                    if (_remote == null) _remote = _core.RemoteObject;
                    if (_resource == null) _resource = _core.Resource;
                }
            }
        }

        private ISM.CUser.Remote _remote = null;
        public ISM.CUser.Remote Remote
        {
            get { return _remote; }
            set { _remote = value; }
        }

        private ISM.Template.Resource _resource = null;
        public ISM.Template.Resource Resource
        {
            get{return _resource;}
            set {_resource = value;}
        }

        private ISM.Touch.TouchKeyboard _touchkeyboard = null;
        public ISM.Touch.TouchKeyboard TouchKeyboard
        {
            get { return _touchkeyboard; }
            set { _touchkeyboard = value; }
        }

        public DataRow CurrentRow
        {
            get { return gridView1.GetFocusedDataRow(); }
        }

        private string _layoutfilename = "";
        public string LayoutFileName
        {
            get { return _layoutfilename; }
        }

        #endregion
        #region Constructors

        public ucSaleSearch()
        {
            InitializeComponent();
            this.ResizeRedraw = true;

            gridView1.OptionsBehavior.ReadOnly = true;
            gridView1.OptionsBehavior.Editable = false;
            gridView1.OptionsCustomization.AllowGroup = false;
            gridView1.OptionsView.AnimationType = DevExpress.XtraGrid.Views.Base.GridAnimationType.NeverAnimate;
            gridView1.OptionsView.ColumnAutoWidth = false;
            //gridView1.OptionsView.ShowAutoFilterRow = false;
            gridView1.OptionsView.ShowGroupPanel = false;
            gridView1.OptionsView.ShowIndicator = false;
            gridView1.OptionsView.RowAutoHeight = true;
            gridView1.Appearance.Row.Font = new Font("Tahoma", 10.0F);

            _layoutfilename = string.Format(@"{0}\Data\Layout_{1}.xml", Static.WorkingFolder, this.GetType().Name);
        }

        #endregion
        #region Control Events

        private void SaleSearch_Load(object sender, EventArgs e)
        {
            if (_touchkeyboard != null)
            {
                _touchkeyboard.AddToKeyboard(txtSaleNo);
                _touchkeyboard.AddToKeyboard(txtTagNo);
                _touchkeyboard.AddToKeyboard(txtRegNo);
                _touchkeyboard.AddToKeyboard(txtName1);
                _touchkeyboard.AddToKeyboard(txtName2);
                _touchkeyboard.AddToKeyboard(txtCorp);
            }
            if (Resource != null)
            {
                btnSearch.Image = Resource.GetImage("button_find");
                btnNext.Image = Resource.GetImage("paging_next");
                btnPrev.Image = Resource.GetImage("paging_prev");
                btnChoose.Image = Resource.GetImage("button_ok");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            _pagecount = 0;
            Result res = DataRefresh(1);
            if (res.ResultNo != 0)
                MessageBox.Show(string.Format("{0}: {1}", res.ResultNo, res.ResultDesc));
        }
        private void btnChoose_Click(object sender, EventArgs e)
        {
            OnEventChoose();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (_pageno > 1)
            {
                Result res = DataRefresh(_pageno - 1);
                if (res.ResultNo != 0)
                    MessageBox.Show(string.Format("{0}: {1}", res.ResultNo, res.ResultDesc));
            }
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (_pagecount > _pageno)
            {
                Result res = DataRefresh(_pageno + 1);
                if (res.ResultNo != 0)
                MessageBox.Show(string.Format("{0}: {1}", res.ResultNo, res.ResultDesc));
            }
        }

        #endregion
        #region User Functions

        private void PageSet(int pageno, Result res)
        {
            if (res.ResultNo == 0)
            {
                _pageno = res.ResultPageCount;
                if (pageno <= res.ResultPageCount)
                {
                    bool partial = (res.AffectedRows % _pagerows) != 0;
                    _pagecount = partial ? res.ResultPageCount : res.ResultPageCount + 1;
                }
            }
        }

        public void DataColumnRefresh()
        {
            ISM.Template.FormUtility.Column_SetCaption(ref gridView1, 0, "ББагц");
            ISM.Template.FormUtility.Column_SetCaption(ref gridView1, 1, "Борлуулалт");
            ISM.Template.FormUtility.Column_SetCaption(ref gridView1, 2, "Нэр");
            ISM.Template.FormUtility.Column_SetCaption(ref gridView1, 3, "Овог");
            ISM.Template.FormUtility.Column_SetCaption(ref gridView1, 4, "Регистр");
            ISM.Template.FormUtility.Column_SetCaption(ref gridView1, 5, "Борлуулалтын дүн");
            ISM.Template.FormUtility.Column_SetCaption(ref gridView1, 6, "Огноо");
            ISM.Template.FormUtility.Column_SetCaption(ref gridView1, 7, "Таг");
            ISM.Template.FormUtility.Column_SetCaption(ref gridView1, 8, "Харилцагч №");
            ISM.Template.FormUtility.Column_SetCaption(ref gridView1, 9, "Төлбөрийн №");
            ISM.Template.FormUtility.Column_SetCaption(ref gridView1, 10, "НӨАТ", true);
            gridView1.BestFitColumns();
        }
        public Result DataRefresh(int pageno)
        {
            #region Validation

            if (pageno < 1) pageno = 1;

            #endregion
            #region Prepare parameters

            object[] param = new object[]{
                txtSaleNo.EditValue
                ,txtTagNo.EditValue
                ,txtCustNo.EditValue
                ,txtRegNo.EditValue
                ,txtName1.EditValue
                ,txtName2.EditValue
                ,txtCorp.EditValue
                ,txtBillNo.EditValue
            };

            #endregion
            #region Call server
            Result res = null;
            if (_remote != null)
            {
                res = _remote.Connection.Call(_remote.User.UserNo, 500, 500001, 500001, pageno - 1, _pagerows, param);
                if (res.ResultNo == 0)
                {
                    PageSet(pageno, res);
                    ISM.Template.FormUtility.GridLayoutGet(gridView1, res.Data.Tables[0], _layoutfilename);
                    DataColumnRefresh();

                    if (_pageno < _pagecount)
                        lblPage.Text = string.Format("Хуудас: {0}/{1}+", _pageno, _pagecount);
                    else
                        lblPage.Text = string.Format("Хуудас: {0}/{1}", _pageno, _pagecount);
                }
            }
            else
            {
                res = new Result(1000, "Internal Error: Remote object not set.");
            }
            #endregion

            return res;
        }

        public Result Find(string salesno, string tagno, string custno, string reg, string fname, string lname, string cname)
        {
            Result res = null;

            txtSaleNo.EditValue = salesno;
            txtTagNo.EditValue = tagno;
            txtCustNo.EditValue = custno;
            txtRegNo.EditValue = reg;
            txtName1.EditValue = fname;
            txtName2.EditValue = lname;
            txtCorp.EditValue = cname;

            res = DataRefresh(1);

            return res;
        }
        public void SaveLayout()
        {
            ISM.Template.FormUtility.GridLayoutSave(gridView1, _layoutfilename);
        }
        #endregion
        #region User Events

        public delegate void delegateEventChoose(DataRow currentrow);
        public event delegateEventChoose EventChoose;
        public void OnEventChoose()
        {
            try
            {
                if (EventChoose != null)
                {
                    DataRow row = gridView1.GetFocusedDataRow();
                    EventChoose(row);
                }
            }
            catch
            { }
        }

        #endregion
    }
}
