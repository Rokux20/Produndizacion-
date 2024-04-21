using Microsoft.EntityFrameworkCore;
using Clase.Context;
using Microsoft.Extensions.Configuration;
using Clase.Services;
using Clase.Repositories;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var ConnectionStrings = builder.Configuration.GetConnectionString("Connection");
builder.Services.AddDbContext<ProyectbContext>(options => options.UseSqlServer(ConnectionStrings));



builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddScoped<IAttendeeService, AttendeeService>();
builder.Services.AddScoped<IEventsService, eventsService>();
builder.Services.AddScoped<IRoomsService, RoomsService>();
builder.Services.AddScoped<IroomAttendeeRegistrationService, roomAttendeeRegistrationService>();
builder.Services.AddScoped<IEventOrganizerAssociationService, eventOrganizerAssociationService>();


#region repositories
builder.Services.AddScoped<IAttendeeRepository, AttendeRepository>();
builder.Services.AddScoped<IEventsRepository, EventsRepository>();
builder.Services.AddScoped<IRoomsRepository, RoomsRepository>();
builder.Services.AddScoped<IRoomAttendeRegistrationRepository, RoomAttendeRegistrationRepository>();
builder.Services.AddScoped<IEventOrganizersAssociationRepository, EventOrganizersAssociationRepository>();
#endregion
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
