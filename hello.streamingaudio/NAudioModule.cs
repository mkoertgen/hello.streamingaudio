using Autofac;

namespace hello.streamingaudio
{
    public class NAudioModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<NAudioPlayer>()
                .AsSelf()
                .As<IMediaPlayer>()
                .SingleInstance();
            builder.RegisterType<NAudioDisplayViewModel>().As<IMediaDisplayViewModel>().SingleInstance();
        }
    }
}