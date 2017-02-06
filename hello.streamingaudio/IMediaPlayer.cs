using System;
using System.ComponentModel;

namespace hello.streamingaudio
{
    public interface IMediaPlayer : INotifyPropertyChanged
    {
        Uri Source { get; set; }
        IPlayerError Error { get; }
        bool CanPlay { get; }
        bool IsPlaying { get; }
        bool CanPause { get; }
        bool IsPaused { get; }
        bool CanStop { get; }
        bool IsStopped { get; }
        double Volume { get; set; }
        bool CanMute { get; }
        bool IsMuted { get; }
        bool CanUnMute { get; }
        double Position { get; set; }
        double Duration { get; }
        bool HasDuration { get; }
        bool SupportsBalance { get; }
        double Balance { get; set; }
        void Play();
        void Pause();
        void Stop();
        void Mute();
        void UnMute();
    }
}