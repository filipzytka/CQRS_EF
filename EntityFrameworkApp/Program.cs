using EntityFrameworkApp;
using EntityFrameworkApp.Endpoints;

var builder = WebApplication.CreateBuilder(args);

DotNetEnv.Env.Load("../.env");

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDatabase();
builder.Services.AddMediatR(configuration =>
{
    configuration.RegisterServicesFromAssembly(typeof(Program).Assembly);
});

var app = builder.Build();

app.UseHttpsRedirection();

app.UseSwagger();
app.UseSwaggerUI();

app.ApplyMigrations();

app.RegisterUserEndpoints();
app.RegisterDepartmentEndpoints();
app.RegisterPaymentEndpoints();

app.Run();
