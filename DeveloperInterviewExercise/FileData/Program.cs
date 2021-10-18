using DAL.ServiceInterfaces;
using DAL.Services;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FileData
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            ITaskService taskService = new TaskService();

            // For Task 1
               taskService.CallTask1(args);

            // For Task 2
            // taskService.CallTask2(args);

            Console.ReadKey();
        }
    }
}
