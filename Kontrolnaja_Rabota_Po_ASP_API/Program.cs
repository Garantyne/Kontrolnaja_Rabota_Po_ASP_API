using Kontrolnaja_Rabota_Po_ASP_API.Db;
using Kontrolnaja_Rabota_Po_ASP_API.Db.Repository;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<ApplicationDbContext>();
builder.Services.AddTransient<IProductRepository, ProductRepository>();
builder.Services.AddTransient<IOrderRepository, OrderRepository>();
builder.Services.AddControllers();
var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.MapControllers();

app.Run();
