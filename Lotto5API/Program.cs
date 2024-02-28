﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Lotto5API.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<Lotto5APIContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Lotto5APIContext") ?? throw new InvalidOperationException("Connection string 'Lotto5APIContext' not found.")));

// Add services to the container.

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
app.UseCors(
builder => builder.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin()
    ); 
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
