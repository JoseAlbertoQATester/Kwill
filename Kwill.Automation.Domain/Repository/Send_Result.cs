using System;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Text;

namespace Kwill.Automation.Domain.Repository
{
    public class Send_Result
    {
        readonly MailMessage mail = new MailMessage(
            "testervisualstudio@gmail.com",
            "josealbertolm13@gmail.com",
            "Test Result",
            "Hello, I send you the test result of the day " + DateTime.Today.ToString());
        readonly SmtpClient client = new SmtpClient("smtp.gmail.com",587);
        public void SendEmail()
        {
             string filename = @"C:\Users\josealbertolagos\source\repos\Kwill\Kwill.Automation.Test\bin\Debug\netcoreapp3.1\Report.pdf";

             Attachment data = new Attachment(filename, MediaTypeNames.Application.Pdf);

            try
            {
                // Use  serverr gmail SMTP  

                client.EnableSsl = true;
                client.Timeout = 10000;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.UseDefaultCredentials = false;

                // LogIn gmail count

                client.Credentials = new NetworkCredential("testervisualstudio@gmail.com", "1234rgH@");

                mail.BodyEncoding = UTF8Encoding.UTF8;
                mail.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
                mail.Attachments.Add(data);
               
                client.Send(mail);
            }
            catch (Exception)
            {
                Console.WriteLine("The email is not Sended");
            }
        }

    }
}
