using MobileGroomersBL;
using MobileGroomersDL;
using MobileGroomersModels;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
// Environment.GetEnvironmentVariable("Connection_String")
// builder.Configuration.GetConnectionString("Charlene Crespo")


builder.Services.AddScoped<IRepository<Appointments>, SQLAppointmentsRepository>(repo => new SQLAppointmentsRepository(builder.Configuration.GetConnectionString("Charlene Crespo")));
builder.Services.AddScoped<IAppointmentsBL, AppointmentsBL>();

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
