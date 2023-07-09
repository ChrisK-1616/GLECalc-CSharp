// Author: Chris Knowles
// Date: Jul 2023
// File: Program.cs
// Version: 1.0.0

using SimpleCalculator;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Inject the <see cref="SimpleCalculatorByApi"/> library class as scoped service
builder.Services.AddScoped<ISimpleCalculator, SimpleCalculatorByApi>();

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
