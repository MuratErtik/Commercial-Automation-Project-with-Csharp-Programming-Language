namespace Commercial_automation_project1
{
    partial class Product_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Product_form));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.Button_Delete = new DevExpress.XtraEditors.SimpleButton();
            this.Button_Update = new DevExpress.XtraEditors.SimpleButton();
            this.Button_Save = new DevExpress.XtraEditors.SimpleButton();
            this.numericNUMBER = new System.Windows.Forms.NumericUpDown();
            this.textDETAILS = new System.Windows.Forms.RichTextBox();
            this.textSALE = new DevExpress.XtraEditors.TextEdit();
            this.textPURCHASE = new DevExpress.XtraEditors.TextEdit();
            this.textMODEL = new DevExpress.XtraEditors.TextEdit();
            this.textBRAND = new DevExpress.XtraEditors.TextEdit();
            this.textNAME = new DevExpress.XtraEditors.TextEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.textYEAR = new System.Windows.Forms.MaskedTextBox();
            this.textID = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericNUMBER)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textSALE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textPURCHASE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textMODEL.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBRAND.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textNAME.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textID.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(12, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1606, 641);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Load += new System.EventHandler(this.gridControl1_Load);
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.simpleButton1);
            this.groupControl1.Controls.Add(this.Button_Delete);
            this.groupControl1.Controls.Add(this.Button_Update);
            this.groupControl1.Controls.Add(this.Button_Save);
            this.groupControl1.Controls.Add(this.numericNUMBER);
            this.groupControl1.Controls.Add(this.textDETAILS);
            this.groupControl1.Controls.Add(this.textSALE);
            this.groupControl1.Controls.Add(this.textPURCHASE);
            this.groupControl1.Controls.Add(this.textMODEL);
            this.groupControl1.Controls.Add(this.textBRAND);
            this.groupControl1.Controls.Add(this.textNAME);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.textYEAR);
            this.groupControl1.Controls.Add(this.textID);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(1617, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(641, 641);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "ÜRÜN BİLGİLERİ";
            // 
            // Button_Delete
            // 
            this.Button_Delete.Appearance.BackColor = System.Drawing.Color.Silver;
            this.Button_Delete.Appearance.Options.UseBackColor = true;
            this.Button_Delete.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Button_Delete.ImageOptions.SvgImage")));
            this.Button_Delete.Location = new System.Drawing.Point(138, 497);
            this.Button_Delete.Name = "Button_Delete";
            this.Button_Delete.Size = new System.Drawing.Size(167, 29);
            this.Button_Delete.TabIndex = 20;
            this.Button_Delete.Text = "SİL";
            this.Button_Delete.Click += new System.EventHandler(this.Button_Delete_Click);
            // 
            // Button_Update
            // 
            this.Button_Update.Appearance.BackColor = System.Drawing.Color.Silver;
            this.Button_Update.Appearance.Options.UseBackColor = true;
            this.Button_Update.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Button_Update.ImageOptions.SvgImage")));
            this.Button_Update.Location = new System.Drawing.Point(138, 532);
            this.Button_Update.Name = "Button_Update";
            this.Button_Update.Size = new System.Drawing.Size(167, 29);
            this.Button_Update.TabIndex = 19;
            this.Button_Update.Text = "GÜNCELLE";
            this.Button_Update.Click += new System.EventHandler(this.Button_Update_Click);
            // 
            // Button_Save
            // 
            this.Button_Save.Appearance.BackColor = System.Drawing.Color.Silver;
            this.Button_Save.Appearance.Options.UseBackColor = true;
            this.Button_Save.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Button_Save.ImageOptions.Image")));
            this.Button_Save.Location = new System.Drawing.Point(138, 462);
            this.Button_Save.Name = "Button_Save";
            this.Button_Save.Size = new System.Drawing.Size(167, 29);
            this.Button_Save.TabIndex = 18;
            this.Button_Save.Text = "KAYDET";
            this.Button_Save.Click += new System.EventHandler(this.Button_Save_Click);
            // 
            // numericNUMBER
            // 
            this.numericNUMBER.Location = new System.Drawing.Point(180, 238);
            this.numericNUMBER.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numericNUMBER.Name = "numericNUMBER";
            this.numericNUMBER.Size = new System.Drawing.Size(125, 23);
            this.numericNUMBER.TabIndex = 5;
            // 
            // textDETAILS
            // 
            this.textDETAILS.Location = new System.Drawing.Point(180, 354);
            this.textDETAILS.Name = "textDETAILS";
            this.textDETAILS.Size = new System.Drawing.Size(125, 96);
            this.textDETAILS.TabIndex = 8;
            this.textDETAILS.Text = "";
            // 
            // textSALE
            // 
            this.textSALE.Location = new System.Drawing.Point(180, 316);
            this.textSALE.Name = "textSALE";
            this.textSALE.Size = new System.Drawing.Size(125, 22);
            this.textSALE.TabIndex = 7;
            // 
            // textPURCHASE
            // 
            this.textPURCHASE.Location = new System.Drawing.Point(180, 276);
            this.textPURCHASE.Name = "textPURCHASE";
            this.textPURCHASE.Size = new System.Drawing.Size(125, 22);
            this.textPURCHASE.TabIndex = 6;
            // 
            // textMODEL
            // 
            this.textMODEL.Location = new System.Drawing.Point(180, 157);
            this.textMODEL.Name = "textMODEL";
            this.textMODEL.Size = new System.Drawing.Size(125, 22);
            this.textMODEL.TabIndex = 3;
            // 
            // textBRAND
            // 
            this.textBRAND.Location = new System.Drawing.Point(180, 115);
            this.textBRAND.Name = "textBRAND";
            this.textBRAND.Size = new System.Drawing.Size(125, 22);
            this.textBRAND.TabIndex = 2;
            // 
            // textNAME
            // 
            this.textNAME.Location = new System.Drawing.Point(180, 77);
            this.textNAME.Name = "textNAME";
            this.textNAME.Size = new System.Drawing.Size(125, 22);
            this.textNAME.TabIndex = 1;
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(112, 354);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(59, 21);
            this.labelControl9.TabIndex = 10;
            this.labelControl9.Text = "DETAY:";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(125, 238);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(49, 21);
            this.labelControl8.TabIndex = 9;
            this.labelControl8.Text = "ADET:";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(77, 275);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(97, 21);
            this.labelControl7.TabIndex = 8;
            this.labelControl7.Text = "ALIŞ FİYATI:";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(113, 156);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(61, 21);
            this.labelControl6.TabIndex = 7;
            this.labelControl6.Text = "MODEL:";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(144, 198);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(30, 21);
            this.labelControl5.TabIndex = 6;
            this.labelControl5.Text = "YIL:";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(112, 114);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(62, 21);
            this.labelControl4.TabIndex = 5;
            this.labelControl4.Text = "MARKA:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(145, 80);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(29, 21);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "AD:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(66, 315);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(108, 21);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "SATIŞ FİYATI:";
            // 
            // textYEAR
            // 
            this.textYEAR.Location = new System.Drawing.Point(180, 199);
            this.textYEAR.Mask = "0000";
            this.textYEAR.Name = "textYEAR";
            this.textYEAR.Size = new System.Drawing.Size(125, 23);
            this.textYEAR.TabIndex = 4;
            this.textYEAR.ValidatingType = typeof(int);
            // 
            // textID
            // 
            this.textID.Location = new System.Drawing.Point(180, 37);
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(125, 22);
            this.textID.TabIndex = 20;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(150, 36);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(24, 21);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "ID:";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.BackColor = System.Drawing.Color.Silver;
            this.simpleButton1.Appearance.Options.UseBackColor = true;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(138, 567);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(167, 29);
            this.simpleButton1.TabIndex = 21;
            this.simpleButton1.Text = "TEMİZLE";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // Product_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gridControl1);
            this.Name = "Product_form";
            this.Text = "ÜRÜNLER";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericNUMBER)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textSALE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textPURCHASE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textMODEL.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBRAND.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textNAME.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textID.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit textID;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.MaskedTextBox textYEAR;
        private System.Windows.Forms.RichTextBox textDETAILS;
        private DevExpress.XtraEditors.TextEdit textSALE;
        private DevExpress.XtraEditors.TextEdit textPURCHASE;
        private DevExpress.XtraEditors.TextEdit textMODEL;
        private DevExpress.XtraEditors.TextEdit textBRAND;
        private DevExpress.XtraEditors.TextEdit textNAME;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton Button_Save;
        private System.Windows.Forms.NumericUpDown numericNUMBER;
        private DevExpress.XtraEditors.SimpleButton Button_Delete;
        private DevExpress.XtraEditors.SimpleButton Button_Update;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}