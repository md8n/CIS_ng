using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(CIS_ng.Startup))]

namespace CIS_ng
{
  public partial class Startup
  {
    public void Configuration(IAppBuilder app)
    {
      ConfigureAuth(app);
    }
  }
}
