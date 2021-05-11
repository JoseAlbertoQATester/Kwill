using System;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Text;

namespace Kwill.Automation.Domain.Repository
{
    public class Send_Result
    {
        //readonly SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
        //readonly MailAddress from = new MailAddress("testervisualstudio@gmail.com");
        //readonly MailAddress to = new MailAddress("josealbertolm13@gmail.com");
        //readonly MailAddress cc1 = new MailAddress("josealbertolm13@outlook.com");
        //readonly MailAddress cc2 = new MailAddress("JoseAlbertoLagos@socialicity.co.uk");
        //readonly string filename = @"C:\Users\josealbertolagos\source\repos\Kwill\Kwill.Automation.Test\bin\Debug\netcoreapp3.1\ReportKwill.pdf";

        //public void SendEmail()
        //{
        //    MailMessage mail = new MailMessage(from, to);
        //    Attachment data = new Attachment(filename, MediaTypeNames.Application.Pdf);

        //    try
        //    {
        //        // Use  serverr gmail SMTP  

        //        client.EnableSsl = true;
        //        client.Timeout = 10000;
        //        client.DeliveryMethod = SmtpDeliveryMethod.Network;
        //        client.UseDefaultCredentials = false;
        //        client.Credentials = new NetworkCredential("testervisualstudio@gmail.com", "1234rgH@");

        //        mail.Subject = "Test Result";
        //        mail.CC.Add(cc1);
        //        mail.CC.Add(cc2);
        //        mail.Body = "Hello, I send you the test result of the day " + DateTime.Today.ToString();
        //        mail.BodyEncoding = UTF8Encoding.UTF8;
        //        mail.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
        //        mail.Attachments.Add(data);

        //        client.Send(mail);

        //    }
        //    catch (Exception)
        //    {
        //        Console.WriteLine("The email is not Sended");
        //    }
        //}

    }
}
