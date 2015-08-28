using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Carrinho.Startup))]
namespace Carrinho
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
