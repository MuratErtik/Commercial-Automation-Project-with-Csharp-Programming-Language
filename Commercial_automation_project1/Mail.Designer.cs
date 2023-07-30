namespace Commercial_automation_project1
{
    partial class Mail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mail));
            this.label1 = new System.Windows.Forms.Label();
            this.textMail_Adress = new DevExpress.XtraEditors.TextEdit();
            this.textSubject = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.text_Message = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.Button_Send = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.textMail_Adress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textSubject.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(66, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mail Adresi:";
            // 
            // textMail_Adress
            // 
            this.textMail_Adress.Location = new System.Drawing.Point(177, 239);
            this.textMail_Adress.Margin = new System.Windows.Forms.Padding(4);
            this.textMail_Adress.Name = "textMail_Adress";
            this.textMail_Adress.Size = new System.Drawing.Size(251, 22);
            this.textMail_Adress.TabIndex = 1;
            // 
            // textSubject
            // 
            this.textSubject.Location = new System.Drawing.Point(177, 277);
            this.textSubject.Margin = new System.Windows.Forms.Padding(4);
            this.textSubject.Name = "textSubject";
            this.textSubject.Size = new System.Drawing.Size(251, 22);
            this.textSubject.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(112, 277);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Konu:";
            // 
            // text_Message
            // 
            this.text_Message.Location = new System.Drawing.Point(177, 321);
            this.text_Message.Name = "text_Message";
            this.text_Message.Size = new System.Drawing.Size(251, 110);
            this.text_Message.TabIndex = 4;
            this.text_Message.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(112, 321);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mesaj:";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(491, 176);
            this.panel1.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(123, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(251, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "MAİL GÖNDERME SEKMESİ";
            // 
            // Button_Send
            // 
            this.Button_Send.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Button_Send.ImageOptions.SvgImage")));
            this.Button_Send.Location = new System.Drawing.Point(130, 478);
            this.Button_Send.Margin = new System.Windows.Forms.Padding(4);
            this.Button_Send.Name = "Button_Send";
            this.Button_Send.Size = new System.Drawing.Size(251, 36);
            this.Button_Send.TabIndex = 7;
            this.Button_Send.Text = "GÖNDER";
            this.Button_Send.Click += new System.EventHandler(this.Button_Send_Click);
            // 
            // Mail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 537);
            this.Controls.Add(this.Button_Send);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.text_Message);
            this.Controls.Add(this.textSubject);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textMail_Adress);
            this.Controls.Add(this.label1);
            this.Name = "Mail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mail";
            this.Load += new System.EventHandler(this.Mail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.textMail_Adress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textSubject.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit textMail_Adress;
        private DevExpress.XtraEditors.TextEdit textSubject;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox text_Message;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton Button_Send;
        private System.Windows.Forms.Label label4;
    }
}