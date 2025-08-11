using Microsoft.EntityFrameworkCore;
using SchoolProject.Infrastructure;
using SchoolProject.Infrastructure.Abstract;
using SchoolProject.Infrastructure.Context;
using SchoolProject.Infrastructure.Repositories;
namespace SchoolProject.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddDbContext<DBContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("DB")));
            
            builder.Services.AddInfrastructureDependencies();


            var app = builder.Build();

       
            app.UseSwagger();
            app.UseSwaggerUI();


            app.UseHttpsRedirection();
            app.UseAuthorization();
            app.MapControllers();
            app.Run();
        }
    }
}
