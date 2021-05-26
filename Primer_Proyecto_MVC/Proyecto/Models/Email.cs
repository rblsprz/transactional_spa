﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using System.Net.Mail;
using System.Configuration;
using System.IO;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto.Models
{
    public class Email
    {
        public void SendEmail(String to, String subject, String body)
        {
            System.Net.Mail.MailMessage mmsg = new System.Net.Mail.MailMessage();
            mmsg.To.Add(to);
            mmsg.Subject = subject;
            mmsg.SubjectEncoding = System.Text.Encoding.UTF8;

            mmsg.Body = CreateBody(body);

            mmsg.BodyEncoding = System.Text.Encoding.UTF8;
            mmsg.IsBodyHtml = true;
            mmsg.From = new System.Net.Mail.MailAddress("businesscomputinglpac@gmail.com");

            System.Net.Mail.SmtpClient client = new System.Net.Mail.SmtpClient();

            client.UseDefaultCredentials = false;
            client.Credentials = new System.Net.NetworkCredential("businesscomputinglpac@gmail.com", "iynbzkdhvowyrtlp");
            client.Port = 587;
            client.EnableSsl = true;
            client.Host = "smtp.gmail.com";


            try
            {
                client.Send(mmsg);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private string CreateBody(String msg)
        {
            string body = string.Empty;
            var server = HttpContext.Current.Server;
            using (StreamReader reader = new StreamReader(server.MapPath("~/EmailTemplate.html")))
            {

                body = reader.ReadToEnd();

            }

            body = body.Replace("{msg}", msg); //replacing Parameters



            return body;

        }
    }
}