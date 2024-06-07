var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
// Mastera Ekleme Yapma12312
//Bir de�i�iklik yapt�m..
//Bir de�i�iklik yapt�m2..
// Yeniaaasss
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
// de�i�iklik