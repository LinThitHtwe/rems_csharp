using Microsoft.EntityFrameworkCore;
using REMS.BackendApi;
using REMS.Database.AppDbContextModels;
using REMS.Modules.Features.Agent;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder
    .AddSwagger()
    .AddDbService()
    .AddDataAccessService()
    .AddBusinessLogicService();

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