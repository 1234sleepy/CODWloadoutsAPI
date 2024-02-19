using CODWloadoutsAPI.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSwaggerGen();
builder.Services.AddControllers();
builder.Services.AddScoped<IWeaponRepository, WeaponRepository>();
builder.Services.AddScoped<ITopPlayerRepository, TopPlayerRepository>();
var app = builder.Build();

app.MapSwagger();
app.UseSwaggerUI();

app.MapControllers();

app.Run();
