namespace Library_Lab2
{
    public class HomeCinema
    {
        private readonly WidescreenTv _widescreenTv;
        private readonly DvdPlayer _dvdPlayer;
        private readonly AvReceiver _avReceiver;

        public HomeCinema(WidescreenTv widescreenTv, DvdPlayer dvdPlayer, AvReceiver avReceiver)
        {
            _widescreenTv = widescreenTv;
            _dvdPlayer = dvdPlayer;
            _avReceiver = avReceiver;
        }

        public void SetStandard()
        {
            _widescreenTv.SetBrightness(50);
            _widescreenTv.SetContrast(60);
            _dvdPlayer.SetDisplayFormat(4, 3);
            _dvdPlayer.SetSpeed(1.0);
            _avReceiver.SetVolume(50);
        }

        public void SetCinema()
        {
            _widescreenTv.SetBrightness(40);
            _widescreenTv.SetContrast(55);
            _dvdPlayer.SetDisplayFormat(21, 9);
            _dvdPlayer.SetSpeed(1.0);
            _avReceiver.SetVolume(75);
            _avReceiver.StereoOn(1);
        }

        public void SetSport()
        {
            _widescreenTv.SetBrightness(85);
            _widescreenTv.SetContrast(70);
            _dvdPlayer.SetDisplayFormat(16, 9);
            _dvdPlayer.SetSpeed(1.0);
            _avReceiver.SetVolume(90);
        }

        public void SetСlassicalMusic()
        {
            _avReceiver.SetVolume(100);
            _avReceiver.StereoOn(1);
        }

        public void SetCustom(int brightness, int contrast,
            int width, int height, double speed, int volume, int stereo)
        {
            _widescreenTv.SetBrightness(brightness);
            _widescreenTv.SetContrast(contrast);
            _dvdPlayer.SetDisplayFormat(width, height);
            _dvdPlayer.SetSpeed(speed);
            _avReceiver.SetVolume(volume);
            _avReceiver.StereoOn(stereo);
        }
    }
}