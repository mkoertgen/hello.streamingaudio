using System.Windows;
using Autofac;
using Caliburn.Micro.Autofac;

namespace hello.streamingaudio
{
    public class AppBootstrapper : AutofacBootstrapper<MainViewModel>
    {
        public AppBootstrapper()
        {
            Initialize();
        }

        protected override void ConfigureContainer(ContainerBuilder builder)
        {
            builder.RegisterType<MainViewModel>().AsSelf().InstancePerLifetimeScope();
            builder.RegisterType<MediaPlayerViewModel>().As<IMediaPlayerViewModel>().SingleInstance();

            builder.RegisterModule<NAudioModule>();
        }

        protected override void ConfigureBootstrapper()
        {
            base.ConfigureBootstrapper();
            EnforceNamespaceConvention = false;
        }
        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            DisplayRootViewFor<MainViewModel>();
        }
    }
}