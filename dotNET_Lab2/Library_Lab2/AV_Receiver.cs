using System;

namespace Library_Lab2
{
    public class AvReceiver
    {
        public void SetVolume(int volume)
        {
            Console.WriteLine("Current Volume: {0}%", volume);
        }

        public void StereoOn(int stereo)
        {
            if (stereo == 1)
                Console.WriteLine("Stereo was switched ON");
        }
    }
}