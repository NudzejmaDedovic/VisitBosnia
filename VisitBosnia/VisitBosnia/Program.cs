using Microsoft.AspNetCore.Authentication;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using Stripe;
using System.Configuration;

using VisitBosnia.Filters;
using VisitBosnia.Helpers;
using VisitBosnia.Security;
using VisitBosnia.Services;
using VisitBosnia.Services.Database;

using VisitBosnia.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers(x=>x.Filters.Add<ExceptionFilter>());

// Add services to the container.

//builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.AddSecurityDefinition("basicAuth", new Microsoft.OpenApi.Models.OpenApiSecurityScheme
    {
        Type = Microsoft.OpenApi.Models.SecuritySchemeType.Http,
        Scheme = "basic"
    });

    c.AddSecurityRequirement(new Microsoft.OpenApi.Models.OpenApiSecurityRequirement
    {
         {
             new OpenApiSecurityScheme
             {
                 Reference = new OpenApiReference { Type = ReferenceType.SecurityScheme, Id = "basicAuth"}
             },
             new string[]{}
         }
    });
});


builder.Services.AddTransient<ICityService, CityService>();
builder.Services.AddTransient<IEventService, VisitBosnia.Services.EventService>();
builder.Services.AddTransient<ITouristFacilityService, TouristFacilityService>();
builder.Services.AddTransient<ITouristFacilityGalleryService, TouristFacilityGalleryService>();
builder.Services.AddTransient<ICategoryService, CategoryService>();
builder.Services.AddTransient<IAttractionService, AttractionService>();
builder.Services.AddTransient<IAgencyService, AgencyService>();
builder.Services.AddTransient<IAgencyMemberService, AgencyMemberService>();

builder.Services.AddTransient<IAppUserRoleService, AppUserRoleService>();
builder.Services.AddTransient<IAppUserService, AppUserService>();
builder.Services.AddTransient<IReadService<VisitBosnia.Model.Role, object>, RoleService>();
builder.Services.AddTransient<IForumService, ForumService>();
builder.Services.AddTransient<IPostService, PostService>();
builder.Services.AddTransient<IAppUserFavouriteService, AppUserFavouriteService>();

builder.Services.AddTransient<IReviewGalleryService, ReviewGalleryService>();
builder.Services.AddTransient<IReviewService, VisitBosnia.Services.ReviewService>();
builder.Services.AddTransient<IEventOrderService, EventOrderService>();
builder.Services.AddTransient<ITransactionService, TransactionService>();
builder.Services.AddTransient<IPostReplyService, PostReplyService>();
builder.Services.AddTransient<ISMSService, SMSService>();

builder.Services.AddMemoryCache();
builder.Services.AddAutoMapper(typeof(ICityService));
builder.Services.AddDbContext<VisitBosniaContext>(options => options
.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddCors(options =>
{
    options.AddPolicy("AnyOrigin", builder =>
    {
        builder
            .AllowAnyOrigin()
            .AllowAnyMethod()
            .AllowAnyHeader();
    });
});

builder.Services.AddAuthentication("BasicAuthentication")
    .AddScheme<AuthenticationSchemeOptions, BasicAuthenticationHandler>("BasicAuthentication", null);

builder.Services.AddScoped<SetupService>();


var app = builder.Build();
// Configure the HTTP request pipeline.
app.UseCors("AnyOrigin");

if (app.Environment.IsDevelopment())
{

    app.UseSwagger();
    app.UseSwaggerUI();
}

//app.UseHttpsRedirection();

app.UseAuthentication();

app.UseAuthorization();

using (var scope = app.Services.CreateScope())
{
    var dataContext = scope.ServiceProvider.GetRequiredService<VisitBosniaContext>();
    dataContext.Database.Migrate();
    scope.ServiceProvider.GetRequiredService<SetupService>();
    SetupService seeder = scope.ServiceProvider.GetRequiredService<SetupService>();
    seeder.Init();
}


app.MapControllers();

app.Run();
