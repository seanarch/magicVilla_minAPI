﻿var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
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

app.MapGet("/helloworld/{id:int}", (int id) => {
    return Results.Ok("Id!!!" + id);
});
app.MapPost("/helloworld2", () => Results.Ok("Hello World2"));


app.UseHttpsRedirection();

 
app.Run();

 
