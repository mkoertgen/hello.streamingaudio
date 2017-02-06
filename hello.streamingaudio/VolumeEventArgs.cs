using System;

namespace hello.streamingaudio
{
    public class VolumeEventArgs : EventArgs
    {
        public float Position { get; set; }
        public float[] MaxVolume { get; set; }
    }
}