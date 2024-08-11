using Ecommerce.Data;
using Ecommerce.DTOs;
using Ecommerce.Repository;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<ApplicationDbContext>(O => O.UseSqlServer(
    builder.Configuration.GetConnectionString("MyConnection")
    ));
builder.Services.AddTransient(typeof(IRepo<>), typeof(Repo<>));
builder.Services.AddTransient(typeof(ProductsAndOpitonsDTO), typeof(ProductsAndOpitonsDTO));
builder.Services.AddTransient(typeof(CategoryAndProductsDTO), typeof(CategoryAndProductsDTO));
builder.Services.AddTransient(typeof(CategoryAndProductsDTO), typeof(CategoryAndProductsDTO));
builder.Services.AddTransient(typeof(ProductDetailsDTO), typeof(ProductDetailsDTO));

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
