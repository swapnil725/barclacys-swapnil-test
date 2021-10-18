using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.ServiceInterfaces
{
   public interface IFileDetailsService
    {
        string GetFileDetailVersion(string filePath);
        int GetFileSize(string filePath);
    }
}
