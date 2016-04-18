using System;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    class EMail
    {
        private string _usrEmail;
        private string _usrPass;

        public EMail(string email, string pass)
        {
            _usrEmail = email;
            _usrPass = pass;
        }

        public void SendMail(string eMail, string topic, string contents)
        {
            MailMessage mail = new MailMessage(_usrEmail, eMail);
            mail.Subject = topic;
            mail.Body = contents;

            SmtpClient client = new SmtpClient();
            client.Host = "smtp.gmail.com";
            client.Port = 587;
            client.UseDefaultCredentials = false; // domyslnie false
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.EnableSsl = true;
            client.Credentials = new NetworkCredential(_usrEmail, _usrPass);
            try
            {
                client.Send(mail);
                MessageBox.Show(@"Wysłano maila");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
