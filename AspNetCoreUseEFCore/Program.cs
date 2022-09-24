using AspNetCoreUseEFCore;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddDbContextPool<EfContext>(options =>
{
    options.UseMySql(builder.Configuration.GetConnectionString("MySqlConnectionString"), new MySqlServerVersion(new Version(8, 0, 30)), builder =>
    {
        
    });

    options.EnableDetailedErrors(true);

    options.AddInterceptors
});

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
