using FactoryDesignPattern.Factory;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern.Dependencies
{
    public class DependencyInjection
    {
        public DependencyInjection(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<ICreditCardFactory, CreditCardFactory>();

            services.AddSingleton<BalanceTransferCard>();
            services.AddSingleton<CashRewardsCard>();
            services.AddSingleton<TravelCreditCard>();

            services.AddTransient<Func<string, ICreditCard>>(serviceProvider => key =>
            {
                switch (key)
                {
                    case "BalanceTransfer":
                        return serviceProvider.GetService<BalanceTransferCard>();
                    case "CashRewards":
                        return serviceProvider.GetService<CashRewardsCard>();
                    case "Travel":
                        return serviceProvider.GetService<TravelCreditCard>();
                    default:
                        return serviceProvider.GetService<TravelCreditCard>();

                }
            });

           
        }

        //public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        //{
        //    if (env.IsDevelopment())
        //    {
        //        app.UseDeveloperExceptionPage();
        //    }

        //    app.UseMvc();
        //}
    }
}

