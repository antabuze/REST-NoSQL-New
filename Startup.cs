using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using REST_NoSQL_New.Data;
using REST_NoSQL_New.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace REST_NoSQL_New
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
            services.AddRazorPages();
            // Configuration for Athlete collection
            services.Configure<AthleteStoreDatabaseSettings>(Configuration.GetSection(nameof(AthleteStoreDatabaseSettings)));
            services.AddSingleton<IAthleteStoreDatabaseSettings>(sp => sp.GetRequiredService<IOptions<AthleteStoreDatabaseSettings>>().Value);
            services.AddSingleton<IMongoClient>(s => new MongoClient(Configuration.GetValue<string>("AthleteStoreDatabaseSettings:ConnectionString")));
            services.AddScoped<IAthleteService, AthleteService>();
            // Configuration for Coach collection
            services.Configure<CoachStoreDatabaseSettings>(Configuration.GetSection(nameof(CoachStoreDatabaseSettings)));
            services.AddSingleton<ICoachStoreDatabaseSettings>(sp => sp.GetRequiredService<IOptions<CoachStoreDatabaseSettings>>().Value);
            services.AddSingleton<IMongoClient>(s => new MongoClient(Configuration.GetValue<string>("CoachStoreDatabaseSettings:ConnectionString")));
            services.AddScoped<ICoachService, CoachService>();
            // Configuration for Medal collection
            services.Configure<MedalStoreDatabaseSettings>(Configuration.GetSection(nameof(MedalStoreDatabaseSettings)));
            services.AddSingleton<IMedalStoreDatabaseSettings>(sp => sp.GetRequiredService<IOptions<MedalStoreDatabaseSettings>>().Value);
            services.AddSingleton<IMongoClient>(s => new MongoClient(Configuration.GetValue<string>("MedalStoreDatabaseSettings:ConnectionString")));
            services.AddScoped<IMedalService, MedalService>();
            // Configuration for MedalTotal collection
            services.Configure<MedalTotalStoreDatabaseSettings>(Configuration.GetSection(nameof(MedalTotalStoreDatabaseSettings)));
            services.AddSingleton<IMedalTotalStoreDatabaseSettings>(sp => sp.GetRequiredService<IOptions<MedalTotalStoreDatabaseSettings>>().Value);
            services.AddSingleton<IMongoClient>(s => new MongoClient(Configuration.GetValue<string>("MedalTotalStoreDatabaseSettings:ConnectionString")));
            services.AddScoped<IMedalTotalService, MedalTotalService>();

            services.AddGraphQLServer().AddQueryType<Query>().AddMongoDbProjections().AddMongoDbFiltering().AddMongoDbSorting();

            services.AddCors(options =>
            {
                options.AddDefaultPolicy(builder =>
                {
                    builder.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
                });
            });

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
            app.UseCors();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                endpoints.MapGraphQL("/graphql");
              
            });
        }
    }
}
