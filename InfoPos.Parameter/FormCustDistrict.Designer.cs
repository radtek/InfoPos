﻿namespace InfoPos.Parameter
{
    partial class FormCustDistrict
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
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.txtName2 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.cboCityCode = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.numDistCode = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numOrderNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboCityCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDistCode.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.numDistCode);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.txtName2);
            this.groupControl1.Controls.Add(this.txtName);
            this.groupControl1.Controls.Add(this.numOrderNo);
            this.groupControl1.Controls.Add(this.cboCityCode);
            this.groupControl1.Size = new System.Drawing.Size(514, 312);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(12, 334);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(117, 334);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(222, 334);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(327, 334);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(432, 334);
            // 
            // panelControl1
            // 
            this.panelControl1.Size = new System.Drawing.Size(782, 316);
            // 
            // splitterControl1
            // 
            this.splitterControl1.Location = new System.Drawing.Point(259, 0);
            this.splitterControl1.Size = new System.Drawing.Size(5, 316);
            // 
            // panelControl2
            // 
            this.panelControl2.Size = new System.Drawing.Size(259, 316);
            // 
            // panelControl3
            // 
            this.panelControl3.Location = new System.Drawing.Point(264, 0);
            this.panelControl3.Size = new System.Drawing.Size(518, 316);
            // 
            // numOrderNo
            // 
            this.numOrderNo.Location = new System.Drawing.Point(196, 142);
            this.numOrderNo.Name = "numOrderNo";
            this.numOrderNo.Properties.Mask.EditMask = "\\d{0,4}";
            this.numOrderNo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.numOrderNo.Size = new System.Drawing.Size(268, 20);
            this.numOrderNo.TabIndex = 4;
            this.numOrderNo.ToolTipTitle = "Жагсаалтын эрэмбэ оруулна уу";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(196, 90);
            this.txtName.Name = "txtName";
            this.txtName.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtName.Properties.MaxLength = 50;
            this.txtName.Size = new System.Drawing.Size(268, 20);
            this.txtName.TabIndex = 2;
            this.txtName.ToolTipTitle = "Сум дүүрэгийн нэр оруулна уу";
            // 
            // txtName2
            // 
            this.txtName2.Location = new System.Drawing.Point(196, 116);
            this.txtName2.Name = "txtName2";
            this.txtName2.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtName2.Properties.MaxLength = 50;
            this.txtName2.Size = new System.Drawing.Size(268, 20);
            this.txtName2.TabIndex = 3;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(31, 41);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(94, 13);
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "Аймаг хотын код :";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(30, 93);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(100, 13);
            this.labelControl2.TabIndex = 6;
            this.labelControl2.Text = "Сум дүүрэгийн нэр :";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(30, 119);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(106, 13);
            this.labelControl3.TabIndex = 7;
            this.labelControl3.Text = "Сум дүүрэгийн нэр 2:";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(30, 145);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(107, 13);
            this.labelControl5.TabIndex = 9;
            this.labelControl5.Text = "Жагсаалтын эрэмбэ :";
            // 
            // cboCityCode
            // 
            this.cboCityCode.Location = new System.Drawing.Point(196, 38);
            this.cboCityCode.Name = "cboCityCode";
            this.cboCityCode.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboCityCode.Properties.NullText = "";
            this.cboCityCode.Size = new System.Drawing.Size(268, 20);
            this.cboCityCode.TabIndex = 0;
            this.cboCityCode.ToolTipTitle = "Аймаг хотын код оруулна уу";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(30, 67);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(102, 13);
            this.labelControl4.TabIndex = 11;
            this.labelControl4.Text = "Сум дүүрэгийн код :";
            // 
            // numDistCode
            // 
            this.numDistCode.Location = new System.Drawing.Point(196, 64);
            this.numDistCode.Name = "numDistCode";
            this.numDistCode.Properties.Mask.EditMask = "\\d{0,4}";
            this.numDistCode.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.numDistCode.Size = new System.Drawing.Size(268, 20);
            this.numDistCode.TabIndex = 1;
            this.numDistCode.ToolTipTitle = "Сум дүүрэгийн код оруулна уу";
            // 
            // FormCustDistrict
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 367);
            this.KeyPreview = true;
            this.Name = "FormCustDistrict";
            this.Text = "Сум дүүрэгийн бүртгэл";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormCustDistrict_FormClosing);
            this.Load += new System.EventHandler(this.FormCustDistrict_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormCustDistrict_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numOrderNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboCityCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDistCode.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtName2;
        private DevExpress.XtraEditors.TextEdit txtName;
        private DevExpress.XtraEditors.TextEdit numOrderNo;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit numDistCode;
        private DevExpress.XtraEditors.LookUpEdit cboCityCode;
    }
}