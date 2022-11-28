using Ecommerce.Data;
using Microsoft.Extensions.DependencyInjection;

namespace Ecommerce.Configurations
{
    public class ServicesExtensions
    {

        public void AddAppDbContext(IServiceCollection service)
        {
            //service.AddDbContext<AppDbContext>();
        }
    }
}
