using BaseClass;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net.Mail;
using System.Net;

namespace ParallelTests
{
    [TestClass]
    public partial class ParallelTester
    {
        Excel excel = new Excel();
        Ftp ftp = new Ftp();
        Sql sql = new Sql();

        [TestMethod()]
        public void LoadFTP_Success()
        {
            bool result = ftp.Load();   
            Assert.AreEqual(true, result);
            Thread.Sleep(2000);
        }
        [TestMethod()]
        public void LoadFTP_Fail()
        {
            bool result = ftp.Load();
            Assert.AreNotEqual(false, result);
            Thread.Sleep(2000);
        }

        [TestMethod()]
        public void LoadExcel_Success()
        {
            bool result = excel.Load();
            Assert.AreEqual(true, result);
            Thread.Sleep(2000);
        }
        [TestMethod()]
        public void LoadExcel_Fail()
        {
            bool result = excel.Load();
            Assert.AreNotEqual(false, result);
            Thread.Sleep(2000);
        }

        [TestMethod()]
        public void LoadSql_Success()
        {
            bool result = sql.Load();
            Assert.AreEqual(true, result);
            Thread.Sleep(2000);
        }
        [TestMethod()]
        public void LoadSql_Fail()
        {
            bool result = sql.Load();
            Assert.AreNotEqual(false, result);
            Thread.Sleep(2000);
        }

    }
}