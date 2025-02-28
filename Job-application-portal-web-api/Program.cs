using Job_application_portal_web_api.Data;
using Job_application_portal_web_api.Map;
using Job_application_portal_web_api.Repositories;
using Job_application_portal_web_api.Repositories.impl;
using Job_application_portal_web_api.Services;
using Job_application_portal_web_api.Services.impl;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAngular",
        policy =>
        {
            policy.WithOrigins("http://localhost:4200") // Allow Angular frontend
                  .AllowAnyHeader()
                  .AllowAnyMethod();
        });
});

// Add database connection
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseMySql(builder.Configuration.GetConnectionString("DefaultConnection"),
        ServerVersion.AutoDetect(builder.Configuration.GetConnectionString("DefaultConnection"))));


// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();
builder.Services.AddScoped<IJobService , JobService>();
builder.Services.AddScoped<IJobRepository , JobRepository>();
builder.Services.AddAutoMapper(typeof(AutomapperProfile));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("AllowAngular");
app.UseHttpsRedirection();
app.MapControllers();
app.Run();


