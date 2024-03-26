
using ApiTurnos.Data;
using Microsoft.EntityFrameworkCore;

namespace ApiTurnos
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            //REGISTRO DE DBCONTEXT EF CORE
            builder.Services.AddDbContext<DBTurnosWebApiContext>(
                options =>
                {
                    options.UseSqlServer(builder.Configuration.GetConnectionString("keyDB"));

                });


            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
