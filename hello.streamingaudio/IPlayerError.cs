using System;
using System.ComponentModel;

namespace hello.streamingaudio
{
    public interface IPlayerError : INotifyPropertyChanged
    {
        Exception Exception { get; set; }
        bool HasException { get; }
        string Message { get; }
    }
}