using SimpleServer.API.Extensions;
using SimpleServer.API.Services;

var builder = WebApplication.CreateBuilder(args);

// Добавляем сервисы
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddApplicationServices(); // Наше кастомное расширение

var app = builder.Build();

// Настраиваем конвейер обработки запросов
app.ConfigureApplication(); // Наше кастомное расширение

app.Run();