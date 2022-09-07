
using System;
using System.Drawing;

namespace HW_DLLFIle
{
    internal class Program
    {
        static void Main()
        {

            GetMonitorDiagonal();

        }

        public static double GetMonitorDiagonal()
        {
            string displayWidth = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Height.ToString();
            string displayHeight = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Width.ToString();
            return Math.Sqrt(Math.Pow(Convert.ToDouble(displayWidth), 2) + Math.Pow(Convert.ToDouble(displayHeight), 2)) / 96;
        }
    }
}