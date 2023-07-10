// Author: Chris Knowles
// Date: Jul 2023
// File: Program.cs
// Version: 1.0.0

using SimpleCalculator;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// Add CORS policy - this has to be run before everything else
// Note:- the port number allowed to test the SimpleCalculator Angular app has been set at 12864 here
// so make sure that "ng serve" is listening on port 12864 or a CORS connection error will occur
builder.Services.AddCors(options => options.AddPolicy("ApiCorsPolicy", builder =>
{
    builder.WithOrigins("http://localhost:12864").AllowAnyMethod().AllowAnyHeader().AllowCredentials();
}));

builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Inject the <see cref="SimpleCalculatorByApi"/> library class as scoped service
builder.Services.AddScoped<ISimpleCalculator, SimpleCalculatorByApi>();

var app = builder.Build();

// Now use the CORS policy (make sure is first too)
app.UseCors("ApiCorsPolicy"); // enable Cors

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
