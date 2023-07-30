namespace Commercial_automation_project1
{
    partial class Staff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Staff));
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.cmb_County = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cmb_Province = new DevExpress.XtraEditors.ComboBoxEdit();
            this.textMAIL = new DevExpress.XtraEditors.TextEdit();
            this.textPHONE_NO = new System.Windows.Forms.MaskedTextBox();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.textPosition = new DevExpress.XtraEditors.TextEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.Button_Delete = new DevExpress.XtraEditors.SimpleButton();
            this.Button_Update = new DevExpress.XtraEditors.SimpleButton();
            this.Button_Save = new DevExpress.XtraEditors.SimpleButton();
            this.textADRESS = new System.Windows.Forms.RichTextBox();
            this.textLastName = new DevExpress.XtraEditors.TextEdit();
            this.textNAME = new DevExpress.XtraEditors.TextEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.textID_NO = new System.Windows.Forms.MaskedTextBox();
            this.textID = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_County.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Province.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textMAIL.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textPosition.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textLastName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textNAME.Properties)).BeginInit();
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
            // cmb_County
            // 
            this.cmb_County.Location = new System.Drawing.Point(126, 260);
            this.cmb_County.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_County.Name = "cmb_County";
            this.cmb_County.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_County.Size = new System.Drawing.Size(184, 22);
            this.cmb_County.TabIndex = 7;
            // 
            // cmb_Province
            // 
            this.cmb_Province.Location = new System.Drawing.Point(126, 230);
            this.cmb_Province.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_Province.Name = "cmb_Province";
            this.cmb_Province.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_Province.Size = new System.Drawing.Size(184, 22);
            this.cmb_Province.TabIndex = 6;
            this.cmb_Province.SelectedIndexChanged += new System.EventHandler(this.cmb_Province_SelectedIndexChanged);
            // 
            // textMAIL
            // 
            this.textMAIL.Location = new System.Drawing.Point(127, 200);
            this.textMAIL.Margin = new System.Windows.Forms.Padding(4);
            this.textMAIL.Name = "textMAIL";
            this.textMAIL.Size = new System.Drawing.Size(184, 22);
            this.textMAIL.TabIndex = 5;
            // 
            // textPHONE_NO
            // 
            this.textPHONE_NO.Location = new System.Drawing.Point(129, 138);
            this.textPHONE_NO.Margin = new System.Windows.Forms.Padding(4);
            this.textPHONE_NO.Mask = "(999) 000-0000";
            this.textPHONE_NO.Name = "textPHONE_NO";
            this.textPHONE_NO.Size = new System.Drawing.Size(183, 23);
            this.textPHONE_NO.TabIndex = 3;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.simpleButton1);
            this.groupControl1.Controls.Add(this.textPosition);
            this.groupControl1.Controls.Add(this.labelControl10);
            this.groupControl1.Controls.Add(this.cmb_County);
            this.groupControl1.Controls.Add(this.cmb_Province);
            this.groupControl1.Controls.Add(this.textMAIL);
            this.groupControl1.Controls.Add(this.textPHONE_NO);
            this.groupControl1.Controls.Add(this.Button_Delete);
            this.groupControl1.Controls.Add(this.Button_Update);
            this.groupControl1.Controls.Add(this.Button_Save);
            this.groupControl1.Controls.Add(this.textADRESS);
            this.groupControl1.Controls.Add(this.textLastName);
            this.groupControl1.Controls.Add(this.textNAME);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.textID_NO);
            this.groupControl1.Controls.Add(this.textID);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(1619, 2);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(4);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(654, 640);
            this.groupControl1.TabIndex = 5;
            this.groupControl1.Text = "PERSONEL BİLGİLERİ";
            // 
            // textPosition
            // 
            this.textPosition.Location = new System.Drawing.Point(124, 417);
            this.textPosition.Margin = new System.Windows.Forms.Padding(4);
            this.textPosition.Name = "textPosition";
            this.textPosition.Size = new System.Drawing.Size(184, 22);
            this.textPosition.TabIndex = 9;
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(32, 418);
            this.labelControl10.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(85, 21);
            this.labelControl10.TabIndex = 27;
            this.labelControl10.Text = "POZİSYON:";
            // 
            // Button_Delete
            // 
            this.Button_Delete.Appearance.BackColor = System.Drawing.Color.Silver;
            this.Button_Delete.Appearance.Options.UseBackColor = true;
            this.Button_Delete.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Button_Delete.ImageOptions.SvgImage")));
            this.Button_Delete.Location = new System.Drawing.Point(83, 494);
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
            this.Button_Update.Location = new System.Drawing.Point(83, 537);
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
            this.Button_Save.Location = new System.Drawing.Point(83, 450);
            this.Button_Save.Margin = new System.Windows.Forms.Padding(4);
            this.Button_Save.Name = "Button_Save";
            this.Button_Save.Size = new System.Drawing.Size(209, 36);
            this.Button_Save.TabIndex = 18;
            this.Button_Save.Text = "KAYDET";
            this.Button_Save.Click += new System.EventHandler(this.Button_Save_Click);
            // 
            // textADRESS
            // 
            this.textADRESS.Location = new System.Drawing.Point(125, 290);
            this.textADRESS.Margin = new System.Windows.Forms.Padding(4);
            this.textADRESS.Name = "textADRESS";
            this.textADRESS.Size = new System.Drawing.Size(183, 119);
            this.textADRESS.TabIndex = 8;
            this.textADRESS.Text = "";
            // 
            // textLastName
            // 
            this.textLastName.Location = new System.Drawing.Point(129, 108);
            this.textLastName.Margin = new System.Windows.Forms.Padding(4);
            this.textLastName.Name = "textLastName";
            this.textLastName.Size = new System.Drawing.Size(184, 22);
            this.textLastName.TabIndex = 2;
            // 
            // textNAME
            // 
            this.textNAME.Location = new System.Drawing.Point(129, 78);
            this.textNAME.Margin = new System.Windows.Forms.Padding(4);
            this.textNAME.Name = "textNAME";
            this.textNAME.Size = new System.Drawing.Size(184, 22);
            this.textNAME.TabIndex = 1;
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(58, 292);
            this.labelControl9.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(59, 21);
            this.labelControl9.TabIndex = 10;
            this.labelControl9.Text = "ADRES:";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(69, 199);
            this.labelControl8.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(44, 21);
            this.labelControl8.TabIndex = 9;
            this.labelControl8.Text = "MAİL:";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(93, 233);
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
            this.labelControl6.Location = new System.Drawing.Point(52, 140);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(62, 21);
            this.labelControl6.TabIndex = 7;
            this.labelControl6.Text = "TEL NO:";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(60, 168);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(54, 21);
            this.labelControl5.TabIndex = 6;
            this.labelControl5.Text = "TC NO:";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(54, 105);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(60, 21);
            this.labelControl4.TabIndex = 5;
            this.labelControl4.Text = "SOYAD:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(85, 76);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(29, 21);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "AD:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(77, 263);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(40, 21);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "İLÇE:";
            // 
            // textID_NO
            // 
            this.textID_NO.Location = new System.Drawing.Point(129, 169);
            this.textID_NO.Margin = new System.Windows.Forms.Padding(4);
            this.textID_NO.Mask = "00000000000";
            this.textID_NO.Name = "textID_NO";
            this.textID_NO.Size = new System.Drawing.Size(183, 23);
            this.textID_NO.TabIndex = 4;
            this.textID_NO.ValidatingType = typeof(int);
            // 
            // textID
            // 
            this.textID.Location = new System.Drawing.Point(130, 48);
            this.textID.Margin = new System.Windows.Forms.Padding(4);
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(184, 22);
            this.textID.TabIndex = 1000;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(93, 47);
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
            this.simpleButton1.Location = new System.Drawing.Point(83, 581);
            this.simpleButton1.Margin = new System.Windows.Forms.Padding(4);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(209, 36);
            this.simpleButton1.TabIndex = 29;
            this.simpleButton1.Text = "TEMİZLE";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // Staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gridControl1);
            this.Name = "Staff";
            this.Text = "PERSONEL";
            this.Load += new System.EventHandler(this.Staff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_County.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Province.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textMAIL.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textPosition.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textLastName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textNAME.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textID.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraEditors.ComboBoxEdit cmb_County;
        private DevExpress.XtraEditors.ComboBoxEdit cmb_Province;
        private DevExpress.XtraEditors.TextEdit textMAIL;
        private System.Windows.Forms.MaskedTextBox textPHONE_NO;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton Button_Delete;
        private DevExpress.XtraEditors.SimpleButton Button_Update;
        private DevExpress.XtraEditors.SimpleButton Button_Save;
        private System.Windows.Forms.RichTextBox textADRESS;
        private DevExpress.XtraEditors.TextEdit textLastName;
        private DevExpress.XtraEditors.TextEdit textNAME;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.MaskedTextBox textID_NO;
        private DevExpress.XtraEditors.TextEdit textID;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit textPosition;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}