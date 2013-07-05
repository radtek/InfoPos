﻿namespace InfoPos.sales
{
    partial class frmRefundPayment
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
            this.pnlTop = new DevExpress.XtraEditors.SplitContainerControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.numEdit = new DevExpress.XtraEditors.CalcEdit();
            this.btnRefundSales = new DevExpress.XtraEditors.SimpleButton();
            this.numRemain = new DevExpress.XtraEditors.CalcEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.numVat = new DevExpress.XtraEditors.CalcEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.numPrepaid = new DevExpress.XtraEditors.CalcEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.numRefund = new DevExpress.XtraEditors.CalcEdit();
            this.numSales = new DevExpress.XtraEditors.CalcEdit();
            this.numDiscount = new DevExpress.XtraEditors.CalcEdit();
            this.numTotal = new DevExpress.XtraEditors.CalcEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.txtSalesNo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.pnlTop)).BeginInit();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRemain.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrepaid.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRefund.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSales.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDiscount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTotal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSalesNo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTop.Horizontal = false;
            this.pnlTop.Location = new System.Drawing.Point(294, 3);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Panel1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.pnlTop.Panel1.Controls.Add(this.labelControl6);
            this.pnlTop.Panel1.Controls.Add(this.gridControl1);
            this.pnlTop.Panel1.Controls.Add(this.numEdit);
            this.pnlTop.Panel1.ShowCaption = true;
            this.pnlTop.Panel1.Text = "Төлбөрийн гүйлгээ:";
            this.pnlTop.Panel2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.pnlTop.Panel2.ShowCaption = true;
            this.pnlTop.Panel2.Text = "Дагалдах хэрэгсэл:";
            this.pnlTop.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel1;
            this.pnlTop.Size = new System.Drawing.Size(536, 502);
            this.pnlTop.SplitterPosition = 285;
            this.pnlTop.TabIndex = 7;
            this.pnlTop.Text = "splitContainerControl1";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            this.labelControl6.Location = new System.Drawing.Point(7, 20);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(70, 16);
            this.labelControl6.TabIndex = 35;
            this.labelControl6.Text = "Буцаах дүн:";
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.Location = new System.Drawing.Point(7, 50);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(518, 421);
            this.gridControl1.TabIndex = 6;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsCustomization.AllowColumnMoving = false;
            this.gridView1.OptionsCustomization.AllowGroup = false;
            this.gridView1.OptionsCustomization.AllowSort = false;
            this.gridView1.OptionsFilter.AllowColumnMRUFilterList = false;
            this.gridView1.OptionsFilter.AllowFilterEditor = false;
            this.gridView1.OptionsFilter.AllowMRUFilterList = false;
            this.gridView1.OptionsView.AnimationType = DevExpress.XtraGrid.Views.Base.GridAnimationType.NeverAnimate;
            this.gridView1.OptionsView.ShowDetailButtons = false;
            this.gridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.OptionsView.ShowIndicator = false;
            this.gridView1.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowForFocusedRow;
            // 
            // numEdit
            // 
            this.numEdit.Location = new System.Drawing.Point(83, 13);
            this.numEdit.Name = "numEdit";
            this.numEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numEdit.Properties.Appearance.Options.UseFont = true;
            this.numEdit.Properties.AutoHeight = false;
            this.numEdit.Size = new System.Drawing.Size(182, 28);
            this.numEdit.TabIndex = 34;
            // 
            // btnRefundSales
            // 
            this.btnRefundSales.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefundSales.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefundSales.Appearance.Options.UseFont = true;
            this.btnRefundSales.Location = new System.Drawing.Point(15, 372);
            this.btnRefundSales.Name = "btnRefundSales";
            this.btnRefundSales.Size = new System.Drawing.Size(252, 54);
            this.btnRefundSales.TabIndex = 30;
            this.btnRefundSales.Text = "Буцаалт хийх";
            this.btnRefundSales.Click += new System.EventHandler(this.btnRefundSales_Click);
            // 
            // numRemain
            // 
            this.numRemain.Location = new System.Drawing.Point(134, 227);
            this.numRemain.Name = "numRemain";
            this.numRemain.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numRemain.Properties.Appearance.Options.UseFont = true;
            this.numRemain.Properties.AutoHeight = false;
            this.numRemain.Properties.ReadOnly = true;
            this.numRemain.Size = new System.Drawing.Size(133, 28);
            this.numRemain.TabIndex = 25;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            this.labelControl3.Location = new System.Drawing.Point(15, 170);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(33, 16);
            this.labelControl3.TabIndex = 24;
            this.labelControl3.Text = "Авах:";
            // 
            // numVat
            // 
            this.numVat.Location = new System.Drawing.Point(134, 131);
            this.numVat.Name = "numVat";
            this.numVat.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numVat.Properties.Appearance.Options.UseFont = true;
            this.numVat.Properties.AutoHeight = false;
            this.numVat.Properties.ReadOnly = true;
            this.numVat.Size = new System.Drawing.Size(133, 28);
            this.numVat.TabIndex = 23;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            this.labelControl8.Location = new System.Drawing.Point(15, 138);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(38, 16);
            this.labelControl8.TabIndex = 22;
            this.labelControl8.Text = "НӨАТ:";
            // 
            // numPrepaid
            // 
            this.numPrepaid.Location = new System.Drawing.Point(134, 195);
            this.numPrepaid.Name = "numPrepaid";
            this.numPrepaid.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numPrepaid.Properties.Appearance.Options.UseFont = true;
            this.numPrepaid.Properties.AutoHeight = false;
            this.numPrepaid.Properties.ReadOnly = true;
            this.numPrepaid.Size = new System.Drawing.Size(133, 28);
            this.numPrepaid.TabIndex = 21;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            this.labelControl7.Location = new System.Drawing.Point(15, 202);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(99, 16);
            this.labelControl7.TabIndex = 20;
            this.labelControl7.Text = "Өмнө төлөгдсөн:";
            // 
            // numRefund
            // 
            this.numRefund.Location = new System.Drawing.Point(134, 259);
            this.numRefund.Name = "numRefund";
            this.numRefund.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numRefund.Properties.Appearance.Options.UseFont = true;
            this.numRefund.Properties.AutoHeight = false;
            this.numRefund.Properties.ReadOnly = true;
            this.numRefund.Size = new System.Drawing.Size(133, 28);
            this.numRefund.TabIndex = 18;
            // 
            // numSales
            // 
            this.numSales.Location = new System.Drawing.Point(134, 163);
            this.numSales.Name = "numSales";
            this.numSales.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numSales.Properties.Appearance.Options.UseFont = true;
            this.numSales.Properties.AutoHeight = false;
            this.numSales.Properties.ReadOnly = true;
            this.numSales.Size = new System.Drawing.Size(133, 28);
            this.numSales.TabIndex = 17;
            // 
            // numDiscount
            // 
            this.numDiscount.Location = new System.Drawing.Point(134, 99);
            this.numDiscount.Name = "numDiscount";
            this.numDiscount.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numDiscount.Properties.Appearance.Options.UseFont = true;
            this.numDiscount.Properties.AutoHeight = false;
            this.numDiscount.Properties.ReadOnly = true;
            this.numDiscount.Size = new System.Drawing.Size(133, 28);
            this.numDiscount.TabIndex = 15;
            // 
            // numTotal
            // 
            this.numTotal.Location = new System.Drawing.Point(134, 67);
            this.numTotal.Name = "numTotal";
            this.numTotal.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numTotal.Properties.Appearance.Options.UseFont = true;
            this.numTotal.Properties.AutoHeight = false;
            this.numTotal.Properties.ReadOnly = true;
            this.numTotal.Size = new System.Drawing.Size(133, 28);
            this.numTotal.TabIndex = 14;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            this.labelControl5.Location = new System.Drawing.Point(15, 266);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(70, 16);
            this.labelControl5.TabIndex = 10;
            this.labelControl5.Text = "Буцаах дүн:";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            this.labelControl4.Location = new System.Drawing.Point(15, 234);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(102, 16);
            this.labelControl4.TabIndex = 8;
            this.labelControl4.Text = "Үлдэгдэл төлбөр:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            this.labelControl2.Location = new System.Drawing.Point(15, 106);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(66, 16);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Хөнгөлөлт:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            this.labelControl1.Location = new System.Drawing.Point(15, 74);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(113, 16);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Борлуулалтын дүн:";
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupControl1.Controls.Add(this.btnCancel);
            this.groupControl1.Controls.Add(this.txtSalesNo);
            this.groupControl1.Controls.Add(this.labelControl14);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.numRemain);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.btnRefundSales);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.numVat);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.numPrepaid);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.numTotal);
            this.groupControl1.Controls.Add(this.numDiscount);
            this.groupControl1.Controls.Add(this.numRefund);
            this.groupControl1.Controls.Add(this.numSales);
            this.groupControl1.Location = new System.Drawing.Point(3, 3);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(285, 502);
            this.groupControl1.TabIndex = 8;
            this.groupControl1.Text = "Борлуулалтын мэдээлэл:";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Appearance.Options.UseFont = true;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(15, 432);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(252, 54);
            this.btnCancel.TabIndex = 34;
            this.btnCancel.Text = "Болих";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtSalesNo
            // 
            this.txtSalesNo.Location = new System.Drawing.Point(134, 35);
            this.txtSalesNo.Name = "txtSalesNo";
            this.txtSalesNo.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalesNo.Properties.Appearance.Options.UseFont = true;
            this.txtSalesNo.Properties.AutoHeight = false;
            this.txtSalesNo.Properties.ReadOnly = true;
            this.txtSalesNo.Size = new System.Drawing.Size(133, 28);
            this.txtSalesNo.TabIndex = 33;
            // 
            // labelControl14
            // 
            this.labelControl14.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl14.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            this.labelControl14.Location = new System.Drawing.Point(15, 42);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(92, 16);
            this.labelControl14.TabIndex = 26;
            this.labelControl14.Text = "Борлуулалт №:";
            // 
            // frmRefundPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(833, 508);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.pnlTop);
            this.Name = "frmRefundPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Борлуулалтын төлбөр буцаах";
            this.Load += new System.EventHandler(this.frmPayment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pnlTop)).EndInit();
            this.pnlTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRemain.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrepaid.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRefund.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSales.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDiscount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTotal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSalesNo.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl pnlTop;
        private DevExpress.XtraEditors.CalcEdit numEdit;
        private DevExpress.XtraEditors.SimpleButton btnRefundSales;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.CalcEdit numRemain;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.CalcEdit numVat;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.CalcEdit numPrepaid;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.CalcEdit numRefund;
        private DevExpress.XtraEditors.CalcEdit numSales;
        private DevExpress.XtraEditors.CalcEdit numDiscount;
        private DevExpress.XtraEditors.CalcEdit numTotal;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        public DevExpress.XtraEditors.TextEdit txtSalesNo;
        private DevExpress.XtraEditors.LabelControl labelControl14;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.LabelControl labelControl6;

    }
}