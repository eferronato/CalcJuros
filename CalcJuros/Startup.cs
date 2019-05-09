using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.PlatformAbstractions;
using Swashbuckle.AspNetCore.Swagger;
using System.IO;
using System.Threading.Tasks;

namespace CalcJuros
{
    /// <summary>
    /// Web API CalcJuros
    /// Softplayer: Elton Ferronato - 07/05/2019
    /// </summary>
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
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            //Habilita a documentação da API
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info
                {
                    Title = "API Cálculo de Juros - Elton Ferronato",
                    Version = "v1",
                    Description = "API criada por Elton Ferronato - 07/05/2019",
                    Contact = new Contact
                    {
                        Name = "Elton Ferronato",
                        Url = "https://github.com/eferronato",
                        Email = "eferronato@gmail.com"
                    }
                });

                //Adiciona os comentários na documentação                
                string applicationBasePath = PlatformServices.Default.Application.ApplicationBasePath;
                string applicationName = PlatformServices.Default.Application.ApplicationName;
                string xmlDoc = Path.Combine(applicationBasePath, $"{applicationName}.xml");
                c.IncludeXmlComments(xmlDoc);
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();

            //Habilita a documentação da API
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "API Cálculo de Juros - Elton Ferronato");
            });

            //Utiliza a documentação do swagger como página inicial da API
            app.Run(context => {
                context.Response.Redirect("swagger/index.html");
                return Task.CompletedTask;
            });
        }
    }
}
