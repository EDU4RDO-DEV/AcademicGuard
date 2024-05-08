using AcademicGuard.DataContext;
using Microsoft.EntityFrameworkCore;
using System;

var builder = WebApplication.CreateBuilder(args);

// Cargar el archivo de configuración
builder.Configuration.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

// Add services to the container.

// Configurar cadena de conexion
var connectionString = builder.Configuration.GetConnectionString("Connection");

// Configurar DbContext
try
{
    builder.Services.AddDbContext<ApplicationDbContext>(
        options => options.UseMySQL(connectionString)
    );
}
catch (Exception ex)
{
    Console.WriteLine($"Error al conectar con la base de datos: {ex.Message}");
    throw;
}

// Agregar CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy("MyPolicy",
        builder =>
        {
            builder.WithOrigins("http://localhost:4300")
                   .AllowAnyHeader()
                   .AllowAnyMethod();
        });
});

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseSwagger();
app.UseSwaggerUI();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseHttpsRedirection();

app.UseAuthentication(); // Implementar autenticación luego

app.UseCors("MyPolicy"); // Aplica la política CORS

app.UseAuthorization();

app.MapControllers();

app.Run();
