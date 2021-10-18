using DAL.ServiceInterfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Services
{
    public class TaskService : ITaskService
    {
        private readonly IFileDetailsService fileDetailsService;
        public TaskService()
        {
            fileDetailsService = new FileDetailsService();
        }
        public void CallTask1(string[] args)
        {
            try
            {
                if (args != null && args.Length > 1)
                {
                    if (args[0] == "-v")
                    {
                        Console.WriteLine("File Version: " + fileDetailsService.GetFileDetailVersion(args[1]));
                    }
                    else
                    {
                        Console.WriteLine("Invalid Argument");
                    }
                }
                else
                {
                    Console.WriteLine("Please provide argument");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Task 1 Exception: " + ex.ToString());
            }
        }

        public void CallTask2(string[] args)
        {
            try
            {
                if (args != null && args.Length > 1)
                {
                    switch(args[0])
                    {
                        case "-v": case "--v": case "/v": case "--version":
                         Console.WriteLine("File Version: " + fileDetailsService.GetFileDetailVersion(args[1]));
                            break;
                        case "-s": case "--s": case "/s": case "--size":
                            Console.WriteLine("File Size: " + fileDetailsService.GetFileSize(args[1]));
                            break;
                        default:
                            Console.WriteLine("Invalid Argument");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Please provide argument");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Task 2 Exception: " + ex.ToString());
            }
        }
    }
}
