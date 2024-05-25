using AcademicGuard.DataContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Cargar el archivo de configuración
builder.Configuration.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

// Configurar cadena de conexion
var connectionString = builder.Configuration.GetConnectionString("Connection");
if (connectionString == null)
{
    throw new Exception("La cadena de conexión 'Connection' no está configurada correctamente en appsettings.json");
}

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

// Agregar autenticación JWT
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        var jwtKey = builder.Configuration["Jwt:Key"];
        if (jwtKey == null)
        {
            throw new Exception("La clave JWT no está configurada correctamente en appsettings.json");
        }

        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuer = true,
            ValidateAudience = true,
            ValidateLifetime = true,
            ValidateIssuerSigningKey = true,
            ValidIssuer = builder.Configuration["Jwt:Issuer"],
            ValidAudience = builder.Configuration["Jwt:Issuer"],
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtKey))
        };
    });

// Agregar CORS para permitir frontend.
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

// Agregar proveedor de registro de consola
builder.Services.AddLogging(logging =>
{
    logging.AddConsole();
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
