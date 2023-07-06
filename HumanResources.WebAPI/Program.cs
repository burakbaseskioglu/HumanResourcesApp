using HumanResources.Business.Abstract;
using HumanResources.Business.Concrete;
using HumanResources.Core.Configuration;
using HumanResources.Core.MappingProfile;
using HumanResources.DataAccess.Abstract;
using HumanResources.DataAccess.Concrete;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

builder.Host.ConfigureAppSettings();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//builder.Services.AddDbContext<ApplicationDbContext>(options =>
//{
//    options.UseNpgsql(builder.Configuration.GetSection("Settings")?.Get<Settings>()?.ConnectionStrings);
//});

builder.Services.AddSingleton<ILanguageRepository, LanguageRepository>();
builder.Services.AddSingleton<ILanguageBusiness, LanguageBusiness>();

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
