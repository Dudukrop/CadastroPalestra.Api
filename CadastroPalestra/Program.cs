using CadastroPalestra.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(opt =>
{
    opt.AddDefaultPolicy(builder =>
    {
        builder.AllowAnyOrigin()
               .AllowAnyMethod()
               .AllowAnyHeader();
    });
});

var mySqlDesConnection = builder.Configuration["ConnectionStrings:DefaultConnection"];
var mySqlProdConnection = Environment.GetEnvironmentVariable("DATABASE_URL");
var mySqlConnection = string.IsNullOrEmpty(mySqlProdConnection) ?
    mySqlDesConnection : ProductionConnection.BuildConnectionString(mySqlProdConnection);

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseMySql(mySqlConnection, ServerVersion.AutoDetect(mySqlConnection)));

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.UseCors();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
