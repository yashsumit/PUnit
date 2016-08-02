using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net.Mail;
using System.Net;

namespace ParallelTests
{
    [TestClass]
    public partial class ParallelTester
    {
        [TestMethod]
        public void Test01()
        {
            string smtpAddress = "smtp.gmail.com";
            int portNumber = 587;
            bool enableSSL = true;

            string emailFrom = "ewonpushuser@gmail.com";
            //string password = "nzhvoostnazmyoup";
            string emailTo = "sumit.joshi@yash.com";
            string subject = "Hello";
            string body = "Hello, I'm just writing this to say Hi!";

            using (MailMessage mail = new MailMessage())
            {
                
                mail.From = new MailAddress(emailFrom);
                mail.To.Add(emailTo);
                mail.Subject = subject;
                mail.Body = body;
                mail.IsBodyHtml = true;
                // Can set to false, if you are sending pure text.


                using (SmtpClient smtp = new SmtpClient(smtpAddress, portNumber))
                {
                    smtp.Credentials = new NetworkCredential(emailFrom, password);
                    smtp.EnableSsl = enableSSL;
                    smtp.Send(mail);
                }
            }
            Thread.Sleep(50000);
        }
        [TestMethod]
        public void Test02()
        {
            Thread.Sleep(50000);
        }
        [TestMethod]
        public void Test03()
        {
            Thread.Sleep(50000);
        }
        [TestMethod]
        public void Test04()
        {
            Thread.Sleep(50000);
        }
        [TestMethod]
        public void Test05()
        {
            Thread.Sleep(50000);
        }
        [TestMethod]
        public void Test06()
        {
            Thread.Sleep(50000);
        }
        [TestMethod]
        public void Test07()
        {
            Thread.Sleep(50000);
        }
        [TestMethod]
        public void Test08()
        {
            Thread.Sleep(26000);
        }
        [TestMethod]
        public void Test09()
        {
            Thread.Sleep(50000);
        }
        [TestMethod]
        public void Test10()
        {
            Thread.Sleep(50000);
        }
        [TestMethod]
        public void Test11()
        {
            Thread.Sleep(50000);
        }
        [TestMethod]
        public void Test12()
        {
            Thread.Sleep(50000);
        }
        [TestMethod]
        public void Test13()
        {
            Thread.Sleep(50000);
        }
        [TestMethod]
        public void Test14()
        {
            Thread.Sleep(50000);
        }
        [TestMethod]
        public void Test15()
        {
            Thread.Sleep(50000);
        }
        [TestMethod]
        public void Test16()
        {
            Thread.Sleep(50000);
        }
        [TestMethod]
        public void Test17()
        {
            Thread.Sleep(50000);
        }
        [TestMethod]
        public void Test18()
        {
            Thread.Sleep(50000);
        }
        [TestMethod]
        public void Test19()
        {
            Thread.Sleep(50000);
        }
        [TestMethod]
        public void Test20()
        {
            Thread.Sleep(50000);
        }
        [TestMethod]
        public void Test21()
        {
            Thread.Sleep(50000);
        }
        [TestMethod]
        public void Test22()
        {
            Thread.Sleep(50000);
        }
        [TestMethod]
        public void Test23()
        {
            Thread.Sleep(50000);
        }
        [TestMethod]
        public void Test24()
        {
            Thread.Sleep(50000);
        }
    }
}