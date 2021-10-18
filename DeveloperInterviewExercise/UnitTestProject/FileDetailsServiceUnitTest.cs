using System;
using DAL.ServiceInterfaces;
using DAL.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class FileDetailsServiceUnitTest
    {
        
        [TestMethod]
        public void GetFileVersionNullTest()
        {
            IFileDetailsService fileDetailsService = new FileDetailsService();
            var result = fileDetailsService.GetFileVersion(null);
            Assert.IsNotNull(result);
        }
        [TestMethod]
        public void GetFileSizeNullTest()
        {
            IFileDetailsService fileDetailsService = new FileDetailsService();
            var result = fileDetailsService.GetFileSize(null);
            Assert.IsTrue(result != 0);
        }
    }
}
