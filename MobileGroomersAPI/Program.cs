using MobileGoomersModels;
using MobileGroomersBL;
using MobileGroomersDL;
using MobileGroomersModels;

var builder = WebApplication.CreateBuilder(args);

//Adding CORS
builder.Services.AddCors(
    (options) => {
        options.AddDefaultPolicy(origin => {
            origin.AllowAnyOrigin();
            origin.AllowAnyMethod();
            origin.AllowAnyHeader();
        });
    }
);
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IRepository<Appointments>, SQLAppointmentsRepository>(repo => new SQLAppointmentsRepository(Environment.GetEnvironmentVariable("Connection_String")));
builder.Services.AddScoped<IAppointmentsBL, AppointmentsBL>();
builder.Services.AddScoped<IRepository<Customer>, SQLCustomerRepository>(repo => new SQLCustomerRepository(Environment.GetEnvironmentVariable("Connection_String")));
builder.Services.AddScoped<ICustomerBL, CustomerBL>();
builder.Services.AddScoped<IRepository<Store>, SQLStoreRepository>(repo => new SQLStoreRepository(Environment.GetEnvironmentVariable("Connection_String")));
builder.Services.AddScoped<IStoreBL, StoreBL>();

var app = builder.Build();

//(builder.Configuration.GetConnectionString("Maaz Umer Store") >> for swagger
//Environment.GetEnvironmentVariable("Connection_String") >> for aws

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//CORS Configure
app.UseCors();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

// using MobileGoomersModels;
// using MobileGroomersBL;
// using MobileGroomersDL;
// using Microsoft.Extensions.Configuration;

// var builder = WebApplication.CreateBuilder(args);

// // Add services to the container.

// builder.Services.AddControllers();
// // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
// builder.Services.AddEndpointsApiExplorer();
// builder.Services.AddSwaggerGen();

// builder.Services.AddScoped<IRepository<Customer>, SQLCustomerRepository>(repo => new SQLCustomerRepository(builder.Configuration.GetConnectionString("Steven Gray")));
// builder.Services.AddScoped<ICustomerBL, CustomerBL>();
// var app = builder.Build();

// // Configure the HTTP request pipeline.
// if (app.Environment.IsDevelopment())
// {
//     app.UseSwagger();
//     app.UseSwaggerUI();
// }

// app.UseHttpsRedirection();

// app.UseAuthorization();

// app.MapControllers();

// app.Run();