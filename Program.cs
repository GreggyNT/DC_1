using lab_1.Context;
using lab_1.Domain;
using lab_1.Dtos.RequestDtos;
using lab_1.Dtos.ResponseDtos;
using lab_1.Repositories;
using lab_1.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<BaseService<AuthorRequestDto, AuthorResponseDto>, AuthorService>();
builder.Services.AddDbContext<AppbContext>(opt =>
{
    opt.UseNpgsql("Server=localhost;Database=distcomp;Port=5432;User Id =postgres;Password=postgres;");
});

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
Console.WriteLine();

app.Run();
