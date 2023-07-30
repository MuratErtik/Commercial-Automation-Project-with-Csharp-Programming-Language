namespace Commercial_automation_project1
{
    partial class NoteDetails
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
            this.textNoteDetails = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // textNoteDetails
            // 
            this.textNoteDetails.BackColor = System.Drawing.SystemColors.Info;
            this.textNoteDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textNoteDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textNoteDetails.Location = new System.Drawing.Point(0, 0);
            this.textNoteDetails.Name = "textNoteDetails";
            this.textNoteDetails.ReadOnly = true;
            this.textNoteDetails.Size = new System.Drawing.Size(800, 450);
            this.textNoteDetails.TabIndex = 0;
            this.textNoteDetails.Text = "";
            // 
            // NoteDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textNoteDetails);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NoteDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Not Detayları";
            this.Load += new System.EventHandler(this.NoteDetails_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox textNoteDetails;
    }
}