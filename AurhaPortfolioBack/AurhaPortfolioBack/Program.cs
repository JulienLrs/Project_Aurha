using MediatR;
using AurhaPortfolioBack.Infrastructures.DatabaseContext;
using AurhaPortfolioBack.Infrastructures.Repository;
using AurhaPortfolioBack.Infrastructures.RepositoryBase;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddScoped<IRepositoryWrapper, RepositoryWrapper>();
builder.Services.AddControllers();
builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(typeof(Program).Assembly));
builder.Services.AddDbContext<AurhaPortfolioContext>(ServiceLifetime.Scoped);

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
