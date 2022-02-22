using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SchoolFunctionApp.Models;
using SchoolFunctionApp.Repository;
using SchoolFunctionApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[assembly: FunctionsStartup(typeof(SchoolFunctionApp.Startup))]
namespace SchoolFunctionApp
{
    public class Startup : FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {
            builder.Services.AddScoped<ISchoolService, SchoolService>();
            builder.Services.AddScoped<ISchoolRepo, SchoolRepo>();

            string connectionstring = Environment.GetEnvironmentVariable("ConnectionString");

            builder.Services.AddDbContext<SchoolContext>(
                options => SqlServerDbContextOptionsExtensions.UseSqlServer(options, connectionstring));
        }
    }
}
