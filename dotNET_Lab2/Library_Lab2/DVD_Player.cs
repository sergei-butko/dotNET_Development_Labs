using System;

namespace Library_Lab2
{
    public class DvdPlayer
    {
        public void SetDisplayFormat(int width, int height)
        {
            Console.WriteLine("Current display format: {0}:{1}", width, height);
        }

        public void SetSpeed(double speed)
        {
            Console.WriteLine("Current Playback Speed: x{0}", speed);
        }
    }
}