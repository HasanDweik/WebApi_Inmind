using WebApi0.Helpers;
using WebApi0.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Registration
builder.Services.AddScoped(typeof(IStudentHelper), typeof(StudentHelpers));
builder.Services.AddScoped(typeof(IUploadFileHelper), typeof(UploadFileHelper));
builder.Services.AddScoped(typeof(IDateTimeHelper), typeof(DateTimeHelper));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();
app.UseStaticFiles();
app.MapControllers();

app.Run();