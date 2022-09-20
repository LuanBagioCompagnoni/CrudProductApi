using CotacaoMoeda.Context;
using CrudApi.Repository;
using CrudApi.Repository.IRepository;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<ApiContext>(options => options.UseNpgsql("Server=127.0.0.1;Port=5432;Database=CrudHub;User Id=postgres;Password=admin;"));
builder.Services.AddControllers().AddJsonOptions(o =>
                o.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.Preserve
            );

builder.Services.AddScoped<IProductRepository, ProductRepository>();
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
