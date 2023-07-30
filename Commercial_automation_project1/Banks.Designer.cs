namespace Commercial_automation_project1
{
    partial class Banks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Banks));
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.cmbCounty = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cmb_Province = new DevExpress.XtraEditors.ComboBoxEdit();
            this.textAccountNo = new DevExpress.XtraEditors.TextEdit();
            this.textPHONE_NO = new System.Windows.Forms.MaskedTextBox();
            this.textAuthorize_Person = new DevExpress.XtraEditors.TextEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.lookUpCompany = new DevExpress.XtraEditors.LookUpEdit();
            this.textDate = new System.Windows.Forms.MaskedTextBox();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.textAccountType = new DevExpress.XtraEditors.TextEdit();
            this.textIban = new DevExpress.XtraEditors.TextEdit();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.Button_Delete = new DevExpress.XtraEditors.SimpleButton();
            this.Button_Update = new DevExpress.XtraEditors.SimpleButton();
            this.Button_Save = new DevExpress.XtraEditors.SimpleButton();
            this.textBranch = new DevExpress.XtraEditors.TextEdit();
            this.textBankName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.textID = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCounty.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Province.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textAccountNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textAuthorize_Person.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpCompany.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textAccountType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textIban.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBranch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBankName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textID.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridView1
            // 
            this.gridView1.DetailHeight = 437;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsEditForm.PopupEditFormWidth = 1000;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // gridControl1
            // 
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(4);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1618, 641);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // cmbCounty
            // 
            this.cmbCounty.Location = new System.Drawing.Point(131, 134);
            this.cmbCounty.Margin = new System.Windows.Forms.Padding(4);
            this.cmbCounty.Name = "cmbCounty";
            this.cmbCounty.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbCounty.Size = new System.Drawing.Size(184, 22);
            this.cmbCounty.TabIndex = 3;
            // 
            // cmb_Province
            // 
            this.cmb_Province.Location = new System.Drawing.Point(132, 98);
            this.cmb_Province.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_Province.Name = "cmb_Province";
            this.cmb_Province.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_Province.Size = new System.Drawing.Size(184, 22);
            this.cmb_Province.TabIndex = 2;
            this.cmb_Province.SelectedIndexChanged += new System.EventHandler(this.cmb_Province_SelectedIndexChanged);
            // 
            // textAccountNo
            // 
            this.textAccountNo.Location = new System.Drawing.Point(131, 233);
            this.textAccountNo.Margin = new System.Windows.Forms.Padding(4);
            this.textAccountNo.Name = "textAccountNo";
            this.textAccountNo.Size = new System.Drawing.Size(184, 22);
            this.textAccountNo.TabIndex = 6;
            // 
            // textPHONE_NO
            // 
            this.textPHONE_NO.Location = new System.Drawing.Point(132, 313);
            this.textPHONE_NO.Margin = new System.Windows.Forms.Padding(4);
            this.textPHONE_NO.Mask = "(999) 000-0000";
            this.textPHONE_NO.Name = "textPHONE_NO";
            this.textPHONE_NO.Size = new System.Drawing.Size(183, 23);
            this.textPHONE_NO.TabIndex = 8;
            // 
            // textAuthorize_Person
            // 
            this.textAuthorize_Person.Location = new System.Drawing.Point(131, 272);
            this.textAuthorize_Person.Margin = new System.Windows.Forms.Padding(4);
            this.textAuthorize_Person.Name = "textAuthorize_Person";
            this.textAuthorize_Person.Size = new System.Drawing.Size(184, 22);
            this.textAuthorize_Person.TabIndex = 7;
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(58, 271);
            this.labelControl10.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(66, 21);
            this.labelControl10.TabIndex = 21;
            this.labelControl10.Text = "YETKİLİ:";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.simpleButton1);
            this.groupControl1.Controls.Add(this.lookUpCompany);
            this.groupControl1.Controls.Add(this.textDate);
            this.groupControl1.Controls.Add(this.labelControl12);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.textAccountType);
            this.groupControl1.Controls.Add(this.textIban);
            this.groupControl1.Controls.Add(this.labelControl11);
            this.groupControl1.Controls.Add(this.cmbCounty);
            this.groupControl1.Controls.Add(this.cmb_Province);
            this.groupControl1.Controls.Add(this.textAccountNo);
            this.groupControl1.Controls.Add(this.textPHONE_NO);
            this.groupControl1.Controls.Add(this.textAuthorize_Person);
            this.groupControl1.Controls.Add(this.labelControl10);
            this.groupControl1.Controls.Add(this.Button_Delete);
            this.groupControl1.Controls.Add(this.Button_Update);
            this.groupControl1.Controls.Add(this.Button_Save);
            this.groupControl1.Controls.Add(this.textBranch);
            this.groupControl1.Controls.Add(this.textBankName);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.textID);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(1616, 1);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(4);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(654, 640);
            this.groupControl1.TabIndex = 5;
            this.groupControl1.Text = "BANKA BİLGİLERİ";
            // 
            // lookUpCompany
            // 
            this.lookUpCompany.Location = new System.Drawing.Point(131, 413);
            this.lookUpCompany.Name = "lookUpCompany";
            this.lookUpCompany.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lookUpCompany.Properties.Appearance.Options.UseFont = true;
            this.lookUpCompany.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpCompany.Properties.NullText = "Firma seçiniz";
            this.lookUpCompany.Size = new System.Drawing.Size(184, 24);
            this.lookUpCompany.TabIndex = 11;
            // 
            // textDate
            // 
            this.textDate.Location = new System.Drawing.Point(131, 344);
            this.textDate.Margin = new System.Windows.Forms.Padding(4);
            this.textDate.Mask = "00/00/0000";
            this.textDate.Name = "textDate";
            this.textDate.Size = new System.Drawing.Size(184, 23);
            this.textDate.TabIndex = 9;
            this.textDate.ValidatingType = typeof(System.DateTime);
            // 
            // labelControl12
            // 
            this.labelControl12.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl12.Appearance.Options.UseFont = true;
            this.labelControl12.Location = new System.Drawing.Point(70, 416);
            this.labelControl12.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(56, 21);
            this.labelControl12.TabIndex = 32;
            this.labelControl12.Text = "FİRMA:";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(22, 383);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(104, 21);
            this.labelControl5.TabIndex = 30;
            this.labelControl5.Text = "HESAP TÜRÜ:";
            // 
            // textAccountType
            // 
            this.textAccountType.Location = new System.Drawing.Point(131, 384);
            this.textAccountType.Margin = new System.Windows.Forms.Padding(4);
            this.textAccountType.Name = "textAccountType";
            this.textAccountType.Size = new System.Drawing.Size(184, 22);
            this.textAccountType.TabIndex = 10;
            // 
            // textIban
            // 
            this.textIban.Location = new System.Drawing.Point(132, 203);
            this.textIban.Margin = new System.Windows.Forms.Padding(4);
            this.textIban.Name = "textIban";
            this.textIban.Size = new System.Drawing.Size(184, 22);
            this.textIban.TabIndex = 5;
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.Location = new System.Drawing.Point(80, 202);
            this.labelControl11.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(44, 21);
            this.labelControl11.TabIndex = 27;
            this.labelControl11.Text = "IBAN:";
            // 
            // Button_Delete
            // 
            this.Button_Delete.Appearance.BackColor = System.Drawing.Color.Silver;
            this.Button_Delete.Appearance.Options.UseBackColor = true;
            this.Button_Delete.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Button_Delete.ImageOptions.SvgImage")));
            this.Button_Delete.Location = new System.Drawing.Point(107, 492);
            this.Button_Delete.Margin = new System.Windows.Forms.Padding(4);
            this.Button_Delete.Name = "Button_Delete";
            this.Button_Delete.Size = new System.Drawing.Size(209, 36);
            this.Button_Delete.TabIndex = 20;
            this.Button_Delete.Text = "SİL";
            this.Button_Delete.Click += new System.EventHandler(this.Button_Delete_Click);
            // 
            // Button_Update
            // 
            this.Button_Update.Appearance.BackColor = System.Drawing.Color.Silver;
            this.Button_Update.Appearance.Options.UseBackColor = true;
            this.Button_Update.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Button_Update.ImageOptions.SvgImage")));
            this.Button_Update.Location = new System.Drawing.Point(107, 535);
            this.Button_Update.Margin = new System.Windows.Forms.Padding(4);
            this.Button_Update.Name = "Button_Update";
            this.Button_Update.Size = new System.Drawing.Size(209, 36);
            this.Button_Update.TabIndex = 19;
            this.Button_Update.Text = "GÜNCELLE";
            this.Button_Update.Click += new System.EventHandler(this.Button_Update_Click);
            // 
            // Button_Save
            // 
            this.Button_Save.Appearance.BackColor = System.Drawing.Color.Silver;
            this.Button_Save.Appearance.Options.UseBackColor = true;
            this.Button_Save.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Button_Save.ImageOptions.Image")));
            this.Button_Save.Location = new System.Drawing.Point(107, 448);
            this.Button_Save.Margin = new System.Windows.Forms.Padding(4);
            this.Button_Save.Name = "Button_Save";
            this.Button_Save.Size = new System.Drawing.Size(209, 36);
            this.Button_Save.TabIndex = 18;
            this.Button_Save.Text = "KAYDET";
            this.Button_Save.Click += new System.EventHandler(this.Button_Save_Click);
            // 
            // textBranch
            // 
            this.textBranch.Location = new System.Drawing.Point(131, 168);
            this.textBranch.Margin = new System.Windows.Forms.Padding(4);
            this.textBranch.Name = "textBranch";
            this.textBranch.Size = new System.Drawing.Size(184, 22);
            this.textBranch.TabIndex = 4;
            // 
            // textBankName
            // 
            this.textBankName.Location = new System.Drawing.Point(131, 64);
            this.textBankName.Margin = new System.Windows.Forms.Padding(4);
            this.textBankName.Name = "textBankName";
            this.textBankName.Size = new System.Drawing.Size(184, 22);
            this.textBankName.TabIndex = 1;
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(69, 346);
            this.labelControl9.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(55, 21);
            this.labelControl9.TabIndex = 10;
            this.labelControl9.Text = "TARİH:";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(40, 231);
            this.labelControl8.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(84, 21);
            this.labelControl8.TabIndex = 9;
            this.labelControl8.Text = "HESAP NO:";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(101, 97);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(20, 21);
            this.labelControl7.TabIndex = 8;
            this.labelControl7.Text = "İL:";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(62, 315);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(62, 21);
            this.labelControl6.TabIndex = 7;
            this.labelControl6.Text = "TEL NO:";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(78, 167);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(46, 21);
            this.labelControl4.TabIndex = 5;
            this.labelControl4.Text = "ŞUBE:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(37, 63);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(87, 21);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "BANKA AD:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(84, 133);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(40, 21);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "İLÇE:";
            // 
            // textID
            // 
            this.textID.Location = new System.Drawing.Point(132, 32);
            this.textID.Margin = new System.Windows.Forms.Padding(4);
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(184, 22);
            this.textID.TabIndex = 1000;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(97, 33);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
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
            this.simpleButton1.Location = new System.Drawing.Point(107, 579);
            this.simpleButton1.Margin = new System.Windows.Forms.Padding(4);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(209, 36);
            this.simpleButton1.TabIndex = 1001;
            this.simpleButton1.Text = "TEMİZLE";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // Banks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gridControl1);
            this.Name = "Banks";
            this.Text = "BANKA";
            this.Load += new System.EventHandler(this.Banks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCounty.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Province.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textAccountNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textAuthorize_Person.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpCompany.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textAccountType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textIban.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBranch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBankName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textID.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraEditors.ComboBoxEdit cmbCounty;
        private DevExpress.XtraEditors.ComboBoxEdit cmb_Province;
        private DevExpress.XtraEditors.TextEdit textAccountNo;
        private System.Windows.Forms.MaskedTextBox textPHONE_NO;
        private DevExpress.XtraEditors.TextEdit textAuthorize_Person;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton Button_Delete;
        private DevExpress.XtraEditors.SimpleButton Button_Update;
        private DevExpress.XtraEditors.SimpleButton Button_Save;
        private DevExpress.XtraEditors.TextEdit textBranch;
        private DevExpress.XtraEditors.TextEdit textBankName;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit textID;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit textAccountType;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit textIban;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private System.Windows.Forms.MaskedTextBox textDate;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.LookUpEdit lookUpCompany;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}