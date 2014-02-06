using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
namespace WcfLibGrupo.Utils
{
    public class EMailUtil
    {
        public bool EnviaEmail(List<string> destinatarios, string cc, string bcc, string assunto, string menssagem, bool html, MailPriority prioridade, List<FileInfo> anexos)
        {
            try
            {
                SmtpClient smtpC = new SmtpClient();
                MailMessage mailM = new MailMessage();
                smtpC.Host = "mail09.redehost.com.br";
                smtpC.EnableSsl = false;
                smtpC.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtpC.Port = 587;
                smtpC.Timeout = 60000;
                smtpC.UseDefaultCredentials = false;
                smtpC.Credentials = new NetworkCredential("cadore@gplucas.com", "Cadore!001");
                mailM.From = new MailAddress("cadore@gplucas.com", "Teste");                    
                mailM.Subject = assunto;
                mailM.IsBodyHtml = html;
                mailM.Body = menssagem;
                mailM.Priority = prioridade;

                if(!string.IsNullOrEmpty(cc)){
                    mailM.CC.Add(cc);                    
                }

                if (!string.IsNullOrEmpty(bcc))
                {
                    mailM.Bcc.Add(bcc);
                }

                foreach(string destinatario in destinatarios){
                    mailM.To.Add(new MailAddress(destinatario));
                }

                if(anexos != null){
                    foreach (FileInfo anexo in  anexos)
                    {
                        Attachment at = new Attachment(anexo.FullName, MediaTypeNames.Application.Octet);
                        mailM.Attachments.Add(at);
                    }
                }

                smtpC.Send(mailM);
            }catch(SmtpFailedRecipientsException exx){
                throw new Exception(exx.Message);
            }catch(SmtpException ex){
                throw new Exception(ex.Message);
            }catch(Exception ex){
                throw new Exception(ex.InnerException.Message);
            }

            return true;
        }
    }
}
