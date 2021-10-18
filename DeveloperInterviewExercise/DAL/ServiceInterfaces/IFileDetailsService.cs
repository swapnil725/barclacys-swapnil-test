using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.ServiceInterfaces
{
   public interface IFileDetailsService
    {
        string GetFileVersion(string filePath);
        int GetFileSize(string filePath);
    }
}
