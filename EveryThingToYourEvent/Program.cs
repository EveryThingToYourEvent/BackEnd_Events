using BLL;
using BLL.ILogicAction;
using BLL.LogicActions;
using DAL.Action.classes;
using DAL.Action.interfaces;
using DAL.Models;
using Microsoft.EntityFrameworkCore;
//using
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var configuration = builder.Configuration;

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

builder.Services.AddCors(p => p.AddPolicy("AlowAll", option =>
{
    option.AllowAnyMethod();
    option.AllowAnyHeader();
    option.AllowAnyOrigin();
}));

// הוספת מנהל התלויות
builder.Services.AddDbContext<EverythingToYourEventContext>(y => y.UseSqlServer("Server=DESKTOP-IQUC79O;Database=EverythingToYourEvent;Trusted_Connection=True;TrustServerCertificate=True;"));

// הוספת שכבות 
builder.Services.AddScoped<IEventToProviderAction, EventToProviderAction>();
builder.Services.AddScoped<IEventToProviderBL, EventToProviderBL>();

builder.Services.AddScoped<IEventTypeAction, EventTypeAction>();
builder.Services.AddScoped<IEventTypeBL,EventTypeBL>();
builder.Services.AddScoped<IEventTypeAndProvCategoryAction, EventTypeAndProvCategoryAction>();
builder.Services.AddScoped<IEventTypeAndProvCategoryBL, EventTypeAndProvCategotyBL>();
builder.Services.AddScoped<IOpinionToProviderBL, OpinionToProviderBL>();
builder.Services.AddScoped<IOpinionToProviderAction, OpinionToProviderAction>();
builder.Services.AddScoped<IParametersForCategoryBL, ParametersForCategoryBL>();
builder.Services.AddScoped<IParametersForCategoryAction, ParametersForCategoryAction>();
builder.Services.AddScoped<IProvidersBL, ProvidersBL>();
builder.Services.AddScoped<IProvidersAction, ProvidersAction>();
builder.Services.AddScoped<IProvidersCategoriesBL, ProvidersCategoriesBL>();
builder.Services.AddScoped<IProvidersCategoriesAction, ProvidersCategoriesAction>();
builder.Services.AddScoped<IUsersBL, UsersBL>();
builder.Services.AddScoped<IUsersAction, UsersAction>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseCors("AlowAll");
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors("AlowAll");
app.UseStaticFiles();
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
