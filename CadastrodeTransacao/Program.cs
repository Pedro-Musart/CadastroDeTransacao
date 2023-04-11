using CadastrodeTransacao.Models;
using CadastrodeTransacao.Repositorio;
using Microsoft.EntityFrameworkCore;

namespace CadastrodeTransacao;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.

        builder.Services.AddDbContext<DataContext>(opcoes => opcoes.UseSqlite(builder.Configuration.GetConnectionString("ConnectionSqlite"))); //responsável por adicionar o DataContext no Container de serviços
        builder.Services.AddScoped<IContaRepositorio, ContaRepositorio>();
        builder.Services.AddControllersWithViews();

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (!app.Environment.IsDevelopment())
        {
            app.UseExceptionHandler("/Home/Error");
        }
        app.UseStaticFiles();

        app.UseRouting();

        app.UseAuthorization();

        app.MapControllerRoute(
            name: "default",
            pattern: "{controller=Home}/{action=Index}/{id?}");

        app.Run();
    }
}