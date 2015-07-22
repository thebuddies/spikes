using Concep.TableTennis.Infrastructure.EntityMappings;
using Owin;
using System.Web.Http;

namespace Concep.TableTennis
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var gameMap = new GameMap();
            var playerMap = new PlayerMap();

            var config = new HttpConfiguration();
            WebApiConfig.Register(config);
            AutofacConfig.RegisterDespendencies(app, config);
            app.UseWebApi(config);
        }
    }
}