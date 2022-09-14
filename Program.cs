
using System;
using System.Managment;

namespace HW_DLLFIle

    internal class Program
    {
        static void Main()
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(@"\root\wmi", @"SELECT * FROM WmiMonitorBasicDisplayParams");
           
            foreach (ManagementObject managementObject in searcher.Get())
            {
                double width = (byte)managementObject["MaxHorizontalImageSize"] / 2.54;
                double height = (byte)managementObject["MaxVerticalImageSize"] / 2.54;
                double diagonal = Math.Sqrt(width * width + height * height);
   
                Console.WriteLine("Monitor Size: {0:F1}\"", diagonal);
            }
            Console.ReadLine();
        }  
    }
}