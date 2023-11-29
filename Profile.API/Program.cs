using Microsoft.EntityFrameworkCore;
using Profile.API.Data;
using Profile.API.Extensions;
using Profile.Configuration;
using Profile.Extensions;
using Profile.Mapping;

var builder = WebApplication.CreateBuilder(args);
ConfigurationManager configuration = builder.Configuration;

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<ProfileContext>(options => options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddProfileCorsPolicy();
builder.Services.AddAutoMapper(typeof(MappingProfile));
builder.Services.AddSqlConnectionHealthCheck();
builder.Services.AddHttpContextAccessor();
builder.Services.ConfigureDependencies();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
  app.UseSwagger();
  app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors(Profile.API.Extensions.ServiceCollectionExtensions.ApiCorsPolicy);

app.UseAuthorization();

app.MapControllers();

app.Run();
