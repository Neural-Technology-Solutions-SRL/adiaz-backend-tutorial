var builder = WebApplication.CreateBuilder(args);

string _MyCors = "MyCors";

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: _MyCors, builder =>
    {
        //builder.WithOrigins("http://localhost");
        builder.SetIsOriginAllowed(origin => new Uri(origin).Host == "localhost").AllowAnyHeader().AllowAnyMethod();
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors(_MyCors);

app.UseAuthorization();

app.MapControllers();

app.Run();
