using Booking.Gateway.DependencyInjection;
using Hellang.Middleware.ProblemDetails;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

builder.Services.Configure<RouteOptions>(options => options.LowercaseQueryStrings = true)
    .AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies())
    .AddServices()
    .AddUseCases()
    .AddClients(builder.Configuration)
    .AddCommonMappingProfiles();

builder.Services.AddExceptionHandling();




builder.Services.AddSwaggerGen();

builder.Services.AddCors(options => options.AddPolicy("allowAll", policy => policy
    .AllowAnyOrigin()
    .AllowAnyHeader()
    .AllowAnyMethod()));

var app = builder.Build();
app.UseCors("allowAll");
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();
app.UseProblemDetails();
app.MapControllers();

app.Run();
