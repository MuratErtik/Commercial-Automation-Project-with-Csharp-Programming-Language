namespace Commercial_automation_project1
{
    partial class Notes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Notes));
            this.textTitle = new DevExpress.XtraEditors.TextEdit();
            this.textTime = new System.Windows.Forms.MaskedTextBox();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.Button_Clear = new DevExpress.XtraEditors.SimpleButton();
            this.textWrittenBy = new DevExpress.XtraEditors.TextEdit();
            this.textReceivingBy = new DevExpress.XtraEditors.TextEdit();
            this.textDate = new System.Windows.Forms.MaskedTextBox();
            this.Button_Delete = new DevExpress.XtraEditors.SimpleButton();
            this.Button_Update = new DevExpress.XtraEditors.SimpleButton();
            this.Button_Save = new DevExpress.XtraEditors.SimpleButton();
            this.textDetails = new System.Windows.Forms.RichTextBox();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.textID = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.textTitle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textWrittenBy.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textReceivingBy.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textTitle
            // 
            this.textTitle.Location = new System.Drawing.Point(176, 346);
            this.textTitle.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.textTitle.Name = "textTitle";
            this.textTitle.Size = new System.Drawing.Size(230, 22);
            this.textTitle.TabIndex = 24;
            // 
            // textTime
            // 
            this.textTime.Location = new System.Drawing.Point(179, 190);
            this.textTime.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.textTime.Mask = "00:00";
            this.textTime.Name = "textTime";
            this.textTime.Size = new System.Drawing.Size(228, 23);
            this.textTime.TabIndex = 23;
            this.textTime.ValidatingType = typeof(System.DateTime);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.Button_Clear);
            this.groupControl1.Controls.Add(this.textWrittenBy);
            this.groupControl1.Controls.Add(this.textReceivingBy);
            this.groupControl1.Controls.Add(this.textDate);
            this.groupControl1.Controls.Add(this.textTitle);
            this.groupControl1.Controls.Add(this.textTime);
            this.groupControl1.Controls.Add(this.Button_Delete);
            this.groupControl1.Controls.Add(this.Button_Update);
            this.groupControl1.Controls.Add(this.Button_Save);
            this.groupControl1.Controls.Add(this.textDetails);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.textID);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(2018, 1);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(818, 800);
            this.groupControl1.TabIndex = 5;
            this.groupControl1.Text = "NOT BİLGİLERİ";
            // 
            // Button_Clear
            // 
            this.Button_Clear.Appearance.BackColor = System.Drawing.Color.Silver;
            this.Button_Clear.Appearance.Options.UseBackColor = true;
            this.Button_Clear.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Button_Clear.ImageOptions.Image")));
            this.Button_Clear.Location = new System.Drawing.Point(145, 709);
            this.Button_Clear.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Button_Clear.Name = "Button_Clear";
            this.Button_Clear.Size = new System.Drawing.Size(261, 45);
            this.Button_Clear.TabIndex = 29;
            this.Button_Clear.Text = "TEMİZLE";
            this.Button_Clear.Click += new System.EventHandler(this.Button_Clear_Click);
            // 
            // textWrittenBy
            // 
            this.textWrittenBy.Location = new System.Drawing.Point(178, 248);
            this.textWrittenBy.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.textWrittenBy.Name = "textWrittenBy";
            this.textWrittenBy.Size = new System.Drawing.Size(230, 22);
            this.textWrittenBy.TabIndex = 28;
            // 
            // textReceivingBy
            // 
            this.textReceivingBy.Location = new System.Drawing.Point(176, 299);
            this.textReceivingBy.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.textReceivingBy.Name = "textReceivingBy";
            this.textReceivingBy.Size = new System.Drawing.Size(230, 22);
            this.textReceivingBy.TabIndex = 27;
            // 
            // textDate
            // 
            this.textDate.Location = new System.Drawing.Point(179, 132);
            this.textDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.textDate.Mask = "00/00/0000";
            this.textDate.Name = "textDate";
            this.textDate.Size = new System.Drawing.Size(228, 23);
            this.textDate.TabIndex = 25;
            this.textDate.ValidatingType = typeof(System.DateTime);
            // 
            // Button_Delete
            // 
            this.Button_Delete.Appearance.BackColor = System.Drawing.Color.Silver;
            this.Button_Delete.Appearance.Options.UseBackColor = true;
            this.Button_Delete.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Button_Delete.ImageOptions.SvgImage")));
            this.Button_Delete.Location = new System.Drawing.Point(145, 600);
            this.Button_Delete.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Button_Delete.Name = "Button_Delete";
            this.Button_Delete.Size = new System.Drawing.Size(261, 45);
            this.Button_Delete.TabIndex = 20;
            this.Button_Delete.Text = "SİL";
            this.Button_Delete.Click += new System.EventHandler(this.Button_Delete_Click);
            // 
            // Button_Update
            // 
            this.Button_Update.Appearance.BackColor = System.Drawing.Color.Silver;
            this.Button_Update.Appearance.Options.UseBackColor = true;
            this.Button_Update.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Button_Update.ImageOptions.SvgImage")));
            this.Button_Update.Location = new System.Drawing.Point(145, 654);
            this.Button_Update.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Button_Update.Name = "Button_Update";
            this.Button_Update.Size = new System.Drawing.Size(261, 45);
            this.Button_Update.TabIndex = 19;
            this.Button_Update.Text = "GÜNCELLE";
            this.Button_Update.Click += new System.EventHandler(this.Button_Update_Click);
            // 
            // Button_Save
            // 
            this.Button_Save.Appearance.BackColor = System.Drawing.Color.Silver;
            this.Button_Save.Appearance.Options.UseBackColor = true;
            this.Button_Save.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Button_Save.ImageOptions.Image")));
            this.Button_Save.Location = new System.Drawing.Point(145, 545);
            this.Button_Save.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Button_Save.Name = "Button_Save";
            this.Button_Save.Size = new System.Drawing.Size(261, 45);
            this.Button_Save.TabIndex = 18;
            this.Button_Save.Text = "KAYDET";
            this.Button_Save.Click += new System.EventHandler(this.Button_Save_Click);
            // 
            // textDetails
            // 
            this.textDetails.Location = new System.Drawing.Point(176, 384);
            this.textDetails.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.textDetails.Name = "textDetails";
            this.textDetails.Size = new System.Drawing.Size(228, 148);
            this.textDetails.TabIndex = 16;
            this.textDetails.Text = "";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(56, 384);
            this.labelControl9.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(89, 21);
            this.labelControl9.TabIndex = 10;
            this.labelControl9.Text = "DETAYLAR:";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(65, 298);
            this.labelControl8.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(83, 21);
            this.labelControl8.TabIndex = 9;
            this.labelControl8.Text = "NOT KİME:";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(92, 348);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(60, 21);
            this.labelControl6.TabIndex = 7;
            this.labelControl6.Text = "BAŞLIK:";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(32, 246);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(108, 21);
            this.labelControl5.TabIndex = 6;
            this.labelControl5.Text = "NOTU YAZAN:";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(110, 192);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(47, 21);
            this.labelControl4.TabIndex = 5;
            this.labelControl4.Text = "SAAT:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(94, 132);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(60, 21);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = " TARİH:";
            // 
            // textID
            // 
            this.textID.Location = new System.Drawing.Point(178, 81);
            this.textID.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(230, 22);
            this.textID.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(132, 80);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(24, 21);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "ID:";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.gridControl1);
            this.groupControl2.Location = new System.Drawing.Point(0, 0);
            this.groupControl2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(2022, 801);
            this.groupControl2.TabIndex = 6;
            this.groupControl2.Text = "*Notun tamamını görmek için oka çift tıklayın";
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.gridControl1.Location = new System.Drawing.Point(2, 28);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(2018, 771);
            this.gridControl1.TabIndex = 5;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.DoubleClick += new System.EventHandler(this.gridControl1_DoubleClick);
            // 
            // gridView1
            // 
            this.gridView1.DetailHeight = 682;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsEditForm.PopupEditFormWidth = 1562;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // Notes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Name = "Notes";
            this.Text = "NOTLAR";
            this.Load += new System.EventHandler(this.Notes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.textTitle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textWrittenBy.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textReceivingBy.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.TextEdit textTitle;
        private System.Windows.Forms.MaskedTextBox textTime;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton Button_Delete;
        private DevExpress.XtraEditors.SimpleButton Button_Update;
        private DevExpress.XtraEditors.SimpleButton Button_Save;
        private System.Windows.Forms.RichTextBox textDetails;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit textID;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.MaskedTextBox textDate;
        private DevExpress.XtraEditors.SimpleButton Button_Clear;
        private DevExpress.XtraEditors.TextEdit textWrittenBy;
        private DevExpress.XtraEditors.TextEdit textReceivingBy;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}