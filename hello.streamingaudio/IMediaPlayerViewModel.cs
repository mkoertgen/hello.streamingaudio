namespace hello.streamingaudio
{
    public interface IMediaPlayerViewModel
    {
        IMediaPlayer Player { get; }
        IMediaDisplayViewModel Display { get; }
    }
}