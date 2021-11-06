namespace RandomFilmServer.Api.Installers
{
    using Autofac;
    using DataAccess;
    using DataAccess.ConnectionFactories;
    using Domain.Services;
    using Domain.Services.Interfaces;

    public class ServicesInstaller : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            // TODO: Выпилить Autofac
            builder.RegisterType<NpgConnectionFactory>().As<IConnectionFactory>().SingleInstance();
            builder.RegisterType<DatabaseService>().As<IDatabaseService>().SingleInstance();
        }
    }
}