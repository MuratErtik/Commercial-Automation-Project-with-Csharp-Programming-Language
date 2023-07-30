using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace Commercial_automation_project1
{
    public partial class Mail : Form
    {
        public Mail()
        {
            InitializeComponent();
        }
        public string mail;

        private void Mail_Load(object sender, EventArgs e)
        {
            textMail_Adress.Text = mail;
        }

        private void Button_Send_Click(object sender, EventArgs e)
        {
            MailMessage mssg = new MailMessage();
            SmtpClient smtp = new SmtpClient();
            smtp.Credentials = new System.Net.NetworkCredential("/*MAIL ACCOUNT*/","/*MAIL PASSWORD*/");
            smtp.Port = 587;
            smtp.Host = "smtp.live.com";
            smtp.EnableSsl = true;
            mssg.To.Add(text_Message.Text);
            mssg.From = new MailAddress("/*MAIL ACCOUNT*/");
            mssg.Subject = textSubject.Text;
            mssg.Body = text_Message.Text;
            smtp.Send(mssg);
        }
    }
}
