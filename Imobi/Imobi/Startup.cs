using Imobi.Automapper;
using Imobi.Data;
using Imobi.Models;
using Imobi.Repository;
using Imobi.Services;
using Imobi.Services.ServiceInterface;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System.Globalization;

namespace Imobi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            services.AddSession();

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            services.AddDbContext<ImobiContext>(options =>
                    options.UseMySql(Configuration.GetConnectionString("ImobiContext"), 
                    BuilderExtensions => BuilderExtensions.MigrationsAssembly("Imobi")));

            #region Auto Mapper

            var config = new AutoMapper.MapperConfiguration(ctg =>
            {
                ctg.AddProfile(new AutoMapperProfile());
            });
            var mapper = config.CreateMapper();
            services.AddSingleton(mapper);
            services.AddMvc();

            #endregion

            #region Declaração de camadas

            #region Add Services 

            services.AddScoped<SeedingService>();

            #endregion

            #region Add Repositories 

            services.AddScoped<VistoriaRepository>();
            services.AddScoped<AccountRepository>();

            #endregion

            #endregion

            #region Interface

            #region Service Interfaces

            services.AddTransient<IVistoriaService, VistoriaService>();
            services.AddTransient<IAccountService, AccountService>();

            #endregion

            #region Repository Interfaces

            services.AddTransient<IVistoriaRepository, VistoriaRepository>();
            services.AddTransient<IAccountRepository, AccountRepository>();

            #endregion

            #endregion
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, SeedingService seedingService)
        {
            var ptBr = new CultureInfo("pt-BR");
            var localizationOption = new RequestLocalizationOptions
            {
                DefaultRequestCulture = new RequestCulture(ptBr),
                SupportedCultures = new List<CultureInfo> { ptBr},
                SupportedUICultures = new List<CultureInfo> { ptBr }
            };
            app.UseRequestLocalization(localizationOption);

            // Se está no perfil de dev
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                seedingService.Seed();
            }
            else // se em prod
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseSession();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Account}/{action=Login}/{id?}");
            });
        }
    }
}
