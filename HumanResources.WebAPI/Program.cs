using HumanResources.Business.ServiceCollectionExtension;
using HumanResources.Core.Configuration;
using HumanResources.Core.MappingProfile;
using HumanResources.DataAccess.Extension;

var builder = WebApplication.CreateBuilder(args);

builder.Host.ConfigureAppSettings();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDataAccessServices();
builder.Services.AddBusinessServices();
builder.Services.AddAutoMapper(typeof(AutoMapperProfile));

var app = builder.Build();
AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
