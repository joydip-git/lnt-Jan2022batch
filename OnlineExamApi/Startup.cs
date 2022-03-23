using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using OnlineExamSystemApp.Models;
using OnlineExamSystemApp.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace OnlineExamSystemApp
{
    public class Startup
    {
        //private IConfiguration _configuration;
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
            //this._configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //in order to tell ASP.NET Core to create object of OnlineExamDbContext class and supply the object to every dao class object
            //all the Dao's are dependent on OnlineExamDbContext
            //this time, you have to supply the connection string to the database
            //read the connection string from appsettings.json file
            var conStr = this.Configuration.GetConnectionString("onlineExamdbConStr");
            Action<DbContextOptionsBuilder> action = (DbContextOptionsBuilder builder) =>
            {
                builder.UseSqlServer(conStr);
            };
            services.AddDbContext<OnlineExamDbContext>(action, ServiceLifetime.Scoped);

            //AnswerBank controller is dependent on AnswerBankDao
            services.AddScoped<IAnswerBankDao, AnswerBankDao>();
            //CorrectAnswer controller is dependent on CorrectAnswerDao
            services.AddScoped<ICorrectAnswerDao, CorrectAnswerDao>();
            //DifficultyLevel controller is dependent on LevelDao
            services.AddScoped<ILevelDao, LevelDao>();
            //Login controller is dependent on LoginDao
            services.AddScoped<ILoginDao, LoginDao>();
            //QuestionBank controller is dependent on QuestionBankDao
            services.AddScoped<IQuestionBankDao, QuestionBankDao>();
            //Registration controller is dependent on RegistrationDao
            services.AddScoped<IRegistrationDao, RegistrationDao>();
            //UserExamRecord controller is dependent on UserExamRecordDao
            services.AddScoped<IUserExamRecordDao, UserExamRecordDao>();
                        
            services.AddControllers();

            services.AddCors();
            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //app.UseRouting();

            //app.UseAuthorization();
            app.UseRouting();
            app.UseCors(
                policyBuilder =>
                policyBuilder
                .AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader()
                );

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
