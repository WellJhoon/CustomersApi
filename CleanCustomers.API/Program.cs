using CleanCustomers.Aplication.Interfaces;
using CleanCustomers.Aplication.Service;
using CleanCustomers.Infraestructure.Context;
using CleanCustomers.Infraestructure.Repository;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);

ConfigurationManager configuration = builder.Configuration;

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<CustomersDbContext>(opt => opt.UseSqlServer(configuration.GetConnectionString("connection"),
    b => b.MigrationsAssembly("CleanCustomers.API")));

builder.Services.AddScoped<ICustomersService, CustomersService>();
builder.Services.AddScoped<ICustomersRepository, CustomersRepository>();

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
