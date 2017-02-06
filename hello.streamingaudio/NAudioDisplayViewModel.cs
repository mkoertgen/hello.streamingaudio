using System;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using Caliburn.Micro;

namespace hello.streamingaudio
{
    public class NAudioDisplayViewModel : Screen, IMediaDisplayViewModel, IDisposable
    {
        private readonly NAudioPlayer _player;
        private bool _isDisposed;
        private readonly WriteableBitmap _bmp = BitmapFactory.New(1920, 1080);

        public NAudioDisplayViewModel(NAudioPlayer player)
        {
            if (player == null) throw new ArgumentNullException(nameof(player));
            _player = player;
            _player.MaxVolume += OnMaxVolume;

            _bmp.Clear(Colors.Beige);
            _bmp.DrawLineAa(10, 20, 50, 70, Colors.Blue, 5);
        }

        public void Dispose()
        {
            if (_isDisposed) return;
            _player.MaxVolume -= OnMaxVolume;
            _isDisposed = true;
        }

        private void OnMaxVolume(object sender, VolumeEventArgs e)
        {
            throw new NotImplementedException();
        }

        protected override void OnViewLoaded(object view)
        {
            var myView = view as NAudioDisplayView;
            if (myView != null)
                myView.WaveformImage.ImageSource = _bmp;
        }
    }
}