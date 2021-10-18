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
        public string GetFileVersion(string filePath)
        {
            if(string.IsNullOrEmpty(filePath))
            {
                return null;
            }
            return fileDetails.Version(filePath);
        }

        public int GetFileSize(string filePath)
        {
            if (string.IsNullOrEmpty(filePath))
            {
                return 0;
            }
            return fileDetails.Size(filePath);
        }
    }
}
