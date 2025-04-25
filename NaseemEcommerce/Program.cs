
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using NaseemEcommerce.Data;
using NaseemEcommerce.Repositories;
using NaseemEcommerce.Services;

namespace NaseemEcommerce
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
            builder.Services.AddOpenApi();

            builder.Services.AddIdentity<IdentityUser, IdentityRole>()
                .AddEntityFrameworkStores<AppDbContext>();
            string CS = builder.Configuration.GetConnectionString("ConnectinStringLocal");
            builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(CS));

            builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            builder.Services.AddScoped<IQueryProductRepository, QueryProductRepository>();
            builder.Services.AddScoped<IProductServices, ProductServices>();
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.MapOpenApi();
                app.UseSwaggerUI(options => { options.SwaggerEndpoint("/openapi/v1.json", "v1"); });
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
