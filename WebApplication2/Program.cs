var builder = WebApplication.CreateBuilder(args);

var result = builder.Configuration.GetSection("ArrayObject").Get<List<ArrayObject>>();

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

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

public class ArrayObject
{
	public string Name { get; set; }
	public List<Element> Elements { get; set; }
}

public class Element
{
	public string Type { get; set; }
}
