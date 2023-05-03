using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautyControl.Utils
{
    public class EmailToSend
    {
        private string remetente;
        private string destinatario;
        private string senhaRemetente;
        private string assunto;
        private string corpo;

        public string Remetente
        {
            get
            {
                return remetente;
            }

            set
            {
                remetente = value;
            }
        }

        public string Destinatario
        {
            get
            {
                return destinatario;
            }

            set
            {
                destinatario = value;
            }
        }

        public string SenhaRemetente
        {
            get
            {
                return senhaRemetente;
            }

            set
            {
                senhaRemetente = value;
            }
        }

        public string Assunto
        {
            get
            {
                return assunto;
            }

            set
            {
                assunto = value;
            }
        }

        public string Corpo
        {
            get
            {
                return corpo;
            }

            set
            {
                corpo = value;
            }
        }

        public EmailToSend(string remetente, string senhaRemetente, string destinatario, string assunto, string corpo)
        {
            Remetente = remetente;
            SenhaRemetente = senhaRemetente;
            Destinatario = destinatario;
            Assunto = assunto;
            Corpo = corpo;
        }

        public EmailToSend()
        {

        }

        public void EnviarEmail01()
        {
            // Instacia MailMessage para envir um email
            System.Net.Mail.MailMessage mensagem = new System.Net.Mail.MailMessage();
            // Destinatario
            mensagem.To.Add(Destinatario);
            // Assunto do email
            mensagem.Subject = Assunto;
            // Remetente do email
            mensagem.From = new System.Net.Mail.MailAddress(Remetente);
            // Corpo do email
            mensagem.Body = Corpo;

            System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient("smtp.gmail.com", 587);
            smtp.UseDefaultCredentials = false;
            smtp.EnableSsl = true; // google usa essa propriedade
            System.Net.NetworkCredential cred = new System.Net.NetworkCredential(Remetente, SenhaRemetente); // email e senha do rementente
            smtp.Credentials = cred;

            // Envia o email
            smtp.Send(mensagem);
        }
    }
}
