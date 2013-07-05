﻿namespace InfoPos.Parameter
{
    partial class CRMIssueResolutionType
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.numOrderNo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtName2 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.numResolutionTypeID = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numOrderNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numResolutionTypeID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txtName);
            this.groupControl1.Controls.Add(this.numOrderNo);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.txtName2);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.numResolutionTypeID);
            this.groupControl1.Controls.Add(this.labelControl1);
            // 
            // numOrderNo
            // 
            this.numOrderNo.Location = new System.Drawing.Point(173, 116);
            this.numOrderNo.Name = "numOrderNo";
            this.numOrderNo.Properties.Mask.EditMask = "\\d{0,4}";
            this.numOrderNo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.numOrderNo.Size = new System.Drawing.Size(154, 20);
            this.numOrderNo.TabIndex = 31;
            this.numOrderNo.ToolTipTitle = "Жагсаалтын эрэмбэ оруулна уу";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(24, 119);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(107, 13);
            this.labelControl4.TabIndex = 30;
            this.labelControl4.Text = "Жагсаалтын эрэмбэ :";
            // 
            // txtName2
            // 
            this.txtName2.Location = new System.Drawing.Point(173, 90);
            this.txtName2.Name = "txtName2";
            this.txtName2.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtName2.Properties.MaxLength = 100;
            this.txtName2.Size = new System.Drawing.Size(154, 20);
            this.txtName2.TabIndex = 29;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(24, 93);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(34, 13);
            this.labelControl3.TabIndex = 28;
            this.labelControl3.Text = "Нэр 2 :";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(24, 67);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(25, 13);
            this.labelControl2.TabIndex = 26;
            this.labelControl2.Text = "Нэр :";
            // 
            // numResolutionTypeID
            // 
            this.numResolutionTypeID.Location = new System.Drawing.Point(173, 38);
            this.numResolutionTypeID.Name = "numResolutionTypeID";
            this.numResolutionTypeID.Properties.Mask.EditMask = "\\d{0,4}";
            this.numResolutionTypeID.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.numResolutionTypeID.Size = new System.Drawing.Size(154, 20);
            this.numResolutionTypeID.TabIndex = 25;
            this.numResolutionTypeID.ToolTipTitle = "Төрлийн дугаар оруулна уу";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(24, 41);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(138, 13);
            this.labelControl1.TabIndex = 24;
            this.labelControl1.Text = "Хаагдсан төрлийн дугаар :";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(173, 64);
            this.txtName.Name = "txtName";
            this.txtName.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtName.Properties.MaxLength = 100;
            this.txtName.Size = new System.Drawing.Size(154, 20);
            this.txtName.TabIndex = 32;
            this.txtName.ToolTipTitle = "Нэр оруулна уу";
            // 
            // CRMIssueResolutionType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 379);
            this.KeyPreview = true;
            this.Name = "CRMIssueResolutionType";
            this.Text = "Асуудлын хаагдсан төрөл";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CRMIssueResolutionType_FormClosing);
            this.Load += new System.EventHandler(this.CRMIssueResolutionType_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CRMIssueResolutionType_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numOrderNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numResolutionTypeID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit numOrderNo;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtName2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit numResolutionTypeID;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtName;

    }
}