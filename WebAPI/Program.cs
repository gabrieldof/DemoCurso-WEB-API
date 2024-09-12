using WebAPI.Interfaces;
using WebAPI.Entities;
using WebAPI.Services;
using WebAPI.Data;
using Microsoft.EntityFrameworkCore;
using WebAPI.Repositositories;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext <ApplicationContext> (dbContextoOptions => dbContextoOptions.UseSqlite(
builder.Configuration["ConnectionStrings:DBConnectionString"]));


builder.Services.AddScoped<IMusicoService, MusicoService>();
builder.Services.AddScoped <IMusicoRepository, MusicoRepository>();

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
