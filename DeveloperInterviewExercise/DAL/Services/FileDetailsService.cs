using DAL.ServiceInterfaces;
using System;
using System.Collections.Generic;
using System.Text;
using ThirdPartyTools;

namespace DAL.Services
{
    public class FileDetailsService : IFileDetailsService
    {
        private readonly FileDetails fileDetails;
        public FileDetailsService()
        {
            fileDetails = new FileDetails();
        }
        public string GetFileDetailVersion(string filePath)
        {
            return fileDetails.Version(filePath);
        }

        public int GetFileSize(string filePath)
        {
            return fileDetails.Size(filePath);
        }
    }
}
