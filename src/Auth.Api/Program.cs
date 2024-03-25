using Auth.Api.Configuration;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerConfiguration();

builder.Services.AddIdentityConfiguration(builder.Configuration);

var app = builder.Build();

Console.WriteLine(app.Environment.EnvironmentName);


app.UseSwaggerConfiguration();


app.UseHttpsRedirection();

app.UseIdentityConfiguration();

app.MapControllers();

app.Run();
