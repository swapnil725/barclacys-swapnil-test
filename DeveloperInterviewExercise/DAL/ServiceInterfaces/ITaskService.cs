using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.ServiceInterfaces
{
    public interface ITaskService
    {
        void CallTask1(string[] args);
        void CallTask2(string[] args);
    }
}
