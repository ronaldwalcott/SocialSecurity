using Microsoft.AspNet.OData.Builder;
using Microsoft.AspNet.OData.Extensions;
using Microsoft.AspNet.OData.Formatter;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OData.Edm;
using Microsoft.OpenApi.Models;
using SocialSecurity.Data;
using SocialSecurity.Domain.ODataModels.SystemTables;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Net.Http.Headers;

using System.Threading.Tasks;

namespace SocialSecurityAPI
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
            services.AddDbContext<SocialSecurityDbContext>(options =>
                options.UseSqlServer(
                Configuration.GetConnectionString("DefaultConnection")));

            services.AddControllers();

            //Odata
           services.AddOData();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "SocialSecurity", Version = "v1" });
            });

            AddFormatters(services);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "SocialSecurity v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            //Enable CORS
            app.UseCors("AllowAll");
            app.UseForwardedHeaders(new ForwardedHeadersOptions
            {
                ForwardedHeaders = ForwardedHeaders.All
            });

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                endpoints.Select().Filter().OrderBy().Count().MaxTop(50);
                endpoints.MapODataRoute("odata", "odata", GetEdmModel());

            });
        }

        private static IEdmModel GetEdmModel()
        {
            var odataBuilder = new ODataConventionModelBuilder();
            odataBuilder.EntitySet<GeneralTable>("TableCountries").EntityType.HasKey(x => x.ID);
            odataBuilder.EntitySet<GeneralTable>("TableCollections").EntityType.HasKey(x => x.ID);
            odataBuilder.EntitySet<GeneralTable>("TableDistricts").EntityType.HasKey(x => x.ID);
            odataBuilder.EntitySet<GeneralTable>("TableDocumentTypes").EntityType.HasKey(x => x.ID);
            odataBuilder.EntitySet<GeneralTable>("TableEmploymentTypes").EntityType.HasKey(x => x.ID);
            odataBuilder.EntitySet<GeneralTable>("TableIndustries").EntityType.HasKey(x => x.ID);
            odataBuilder.EntitySet<GeneralTable>("TableMaritalStatuses").EntityType.HasKey(x => x.ID);
            odataBuilder.EntitySet<GeneralTable>("TableNationalities").EntityType.HasKey(x => x.ID);
            odataBuilder.EntitySet<GeneralTable>("TableOccupations").EntityType.HasKey(x => x.ID);
            odataBuilder.EntitySet<GeneralTable>("TableParishes").EntityType.HasKey(x => x.ID);
            odataBuilder.EntitySet<GeneralTable>("TablePostalCodes").EntityType.HasKey(x => x.ID);
            odataBuilder.EntitySet<GeneralTable>("TablePostOffices").EntityType.HasKey(x => x.ID);
            odataBuilder.EntitySet<GeneralTable>("TableStreets").EntityType.HasKey(x => x.ID);
            odataBuilder.EntitySet<GeneralTable>("TableTaskStatuses").EntityType.HasKey(x => x.ID);
            odataBuilder.EntitySet<GeneralTable>("TableTaskTypes").EntityType.HasKey(x => x.ID);
            odataBuilder.EntitySet<GeneralTable>("TableTaskPriorities").EntityType.HasKey(x => x.ID);
            odataBuilder.EntitySet<GeneralTable>("TableTaskReferenceTypes").EntityType.HasKey(x => x.ID);


            return odataBuilder.GetEdmModel();
        }

        private static void AddFormatters(IServiceCollection services)
        {
            services.AddMvcCore(options =>
            {
                foreach (var outputFormatter in options.OutputFormatters.OfType<ODataOutputFormatter>().Where(_ => _.SupportedMediaTypes.Count == 0))
                {
                    outputFormatter.SupportedMediaTypes.Add(new MediaTypeHeaderValue("application/prs.odatatestxx-odata"));
                }

                foreach (var inputFormatter in options.InputFormatters.OfType<ODataInputFormatter>().Where(_ => _.SupportedMediaTypes.Count == 0))
                {
                    inputFormatter.SupportedMediaTypes.Add(new MediaTypeHeaderValue("application/prs.odatatestxx-odata"));
                }

            });
        }
    }
}
