using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfConcesionaria_v1
{
    internal class Correo
    {
        string servidor;
        int puerto;
        string usuario;
        string contrasenia;
        bool ssl;

        public string Servidor
        {
            get { return servidor; }
            set { servidor = value; }
        }

        public int Puerto
        {
            get { return puerto; }
            set { puerto = value; }
        }

        public string Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }

        public string Contrasenia
        {
            get { return contrasenia; }
            set { contrasenia = value; }
        }

        public bool SSL
        {
            get { return ssl; }
            set { ssl = value; }
        }

        string de;
        string alias;
        string para;
        string conCopia;
        string asunto;
        string cuerpo;
        string adjunto;

        MailMessage mensaje;

        public string De
        {
            get { return de; }
            set { de = value; mensaje.From = new MailAddress(de, alias); }
        }

        public string Alias
        {
            get { return alias; }
            set { alias = value; }
        }

        public string Para
        {
            get { return para; }
            set
            {
                mensaje.To.Clear();

                para = value;

                string[] correos = para.Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);

                foreach (string i in correos)
                {
                    string ee = i.Trim();
                    if (!string.IsNullOrEmpty(ee))
                    {
                        mensaje.To.Add(ee);
                    }
                }
            }
        }

        public string ConCopia
        {
            get { return conCopia; }
            set
            {
                mensaje.CC.Clear();

                string[] correos = value.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

                foreach (string i in correos)
                {
                    string ee = i.Trim();
                    if (!string.IsNullOrEmpty(ee))
                    {
                        mensaje.CC.Add(new MailAddress(ee));
                    }
                }
            }
        }

        public string Asunto
        {
            get { return asunto; }
            set { asunto = value; mensaje.Subject = asunto; }
        }

        public string Cuerpo
        {
            get { return cuerpo; }
            set { cuerpo = value; mensaje.Body = cuerpo; }
        }

        public string Adjunto
        {
            get { return adjunto; }
            set
            {
                adjunto = value;
                mensaje.Attachments.Clear();
                string[] nombresDeArchivo = value.Split(',');
                foreach (string nombreDeArchivo in nombresDeArchivo)
                {
                    if (!String.IsNullOrEmpty(nombreDeArchivo))
                    {
                        mensaje.Attachments.Add(new Attachment(nombreDeArchivo.Trim()));
                    }
                }
            }
        }

        public Correo()
        {
            mensaje = new MailMessage();
            de = "cmuteq@gmail.com";
            alias = "Carlos Manotoa Prueba";
            servidor = "smtp.gmail.com";
            puerto = 587;
            usuario = "cmuteq@gmail.com";
            contrasenia = "llcejykbstrvvevm";
            ssl = true;
            mensaje.From = new MailAddress(de, alias);
        }

        public Boolean Enviar()
        {
            SmtpClient smtpClient = new SmtpClient(servidor);
            smtpClient.Port = puerto;
            smtpClient.EnableSsl = ssl;
            smtpClient.Credentials = new NetworkCredential(usuario, contrasenia);

            try
            {
                smtpClient.Send(mensaje);
                mensaje = new MailMessage();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                mensaje.Dispose();
                return false;
            }

            return true;
        }
    }
}
