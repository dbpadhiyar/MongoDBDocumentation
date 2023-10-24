using ModelSeller.Utility;
using DataSeller.Resolver;
using EngineSeller.Resolver;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.Configure<MDSettings>(builder.Configuration.GetSection("MDSettings"));
builder.Services.Configure<MDCollections>(builder.Configuration.GetSection("MDCollections"));
builder.Services.AddEngineResolver();
builder.Services.AddDataResolver();


var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
