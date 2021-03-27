using System;
using Library_Lab2;

namespace Program_Lab2
{
    public class CustomMode
    {
        public void Custom(HomeCinema homeCinema)
        {
            Console.Write("Enter Brightness: ");
            int brightness = Convert.ToInt32(Console.ReadLine());
            if (brightness <= 0 || brightness > 100)
                throw new Exception("Illegal brightness level!");

            Console.Write("Enter Contrast: ");
            int contrast = Convert.ToInt32(Console.ReadLine());
            if (contrast <= 0 || contrast > 100)
                throw new Exception("Illegal contrast level!");

            Console.Write("Enter Volume: ");
            int volume = Convert.ToInt32(Console.ReadLine());
            if (volume <= 0 || volume > 100)
                throw new Exception("Illegal volume level!");

            Console.Write("Enter Speed: ");
            double speed = Convert.ToDouble(Console.ReadLine());
            if (speed <= 0 || speed > 3)
                throw new Exception("Illegal speed level!");

            Console.WriteLine("Enter Aspect Ratio");
            Console.Write("Enter Width: ");
            int width = Convert.ToInt32(Console.ReadLine());
            if (width <= 0 || width > 21)
                throw new Exception("Illegal width!");
            Console.Write("Enter Height: ");
            int height = Convert.ToInt32(Console.ReadLine());
            if (height <= 0 || height > 9)
                throw new Exception("Illegal height!");

            Console.WriteLine("Switch on Stereo?");
            Console.Write("1 - for YES, 2 - for NO: ");
            int stereo = Convert.ToInt32(Console.ReadLine());
            if (stereo < 1 || stereo > 2)
                throw new Exception("No such command was found!");

            homeCinema.SetCustom(brightness, contrast, width, height, speed, volume, stereo);
        }
    }
}