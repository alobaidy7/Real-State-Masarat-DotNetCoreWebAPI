using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Real_State_Backend.Data;
using Real_State_Backend.Interfaces;
using Real_State_Backend.Models;
using Real_State_Backend.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var ConnectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
   options.UseSqlServer(ConnectionString));


builder.Services.AddIdentity<User, IdentityRole>(options =>
{
    options.User.RequireUniqueEmail = false;
    options.Password.RequiredLength = 6;
    options.Password.RequireUppercase = false;
    
    
}).AddEntityFrameworkStores<ApplicationDbContext>().AddDefaultTokenProviders();

builder.Services.AddScoped<IPostService, PostService>();
builder.Services.AddScoped<IAuthService, AuthService>();
builder.Services.AddScoped<IAdminService, AdminService>();



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
