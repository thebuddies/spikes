using Autofac;
using Concep.TableTennis.Infrastructure.Repository;
using Concep.TableTennis.Domain.Repository;
using Concep.TableTennis.Infrastructure.Service;
using Concep.TableTennis.Domain.Service;

namespace Concep.TableTennis
{
    public class AutofacModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.Register(c => new GameRepository())
                .As<IGameRepository>()
                .InstancePerLifetimeScope();

            builder.Register(c => new GameService(c.Resolve<IGameRepository>()))
                .As<IGameService>()
                .InstancePerLifetimeScope();
        }
    }
}