using System;

namespace Library_Lab2
{
    public class WidescreenTv
    {
        public void SetBrightness(int brightness)
        {
            Console.WriteLine("\nCurrent Brightness: {0}%", brightness);
        }

        public void SetContrast(int contrast)
        {
            Console.WriteLine("Current Contrast: {0}%", contrast);
        }
    }
}