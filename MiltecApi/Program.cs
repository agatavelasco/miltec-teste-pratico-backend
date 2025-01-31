using MiltecApi.Data;
using MiltecApi.Repositories.Impl;
using MiltecApi.Repositories;
using MiltecApi.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options =>
{
    options.AddPolicy("PermitirTudo",
        policy =>
        {
            policy.WithOrigins("http://localhost:5173")
                  .AllowAnyMethod()
                  .AllowAnyHeader();
        });
});

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseInMemoryDatabase("MiltecDb"));

builder.Services.AddScoped<IAnuncioRepository, AnuncioRepository>();
builder.Services.AddScoped<AnuncioService>();

var app = builder.Build();

app.UseCors("PermitirTudo");

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();