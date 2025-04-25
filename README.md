# C--.NET-LEARN
Learn new technologies: C# and .NET


### Create new console project:
dotnet new console

### Run project
dotnet run


## Fundomentals folder - learn language concepts
## SimpleServer folder - simple server to learn API etc


## SimpleServer:

#### Create solution
dotnet new sln -n SimpleServer

#### Create API project
dotnet new webapi -n SimpleServer.API -o src/SimpleServer.API
dotnet sln add src/SimpleServer.API

#### Create Domain project (optional)
dotnet new classlib -n SimpleServer.Domain -o src/SimpleServer.Domain
dotnet sln add src/SimpleServer.Domain

#### Add reference from API to Domain
dotnet add src/SimpleServer.API reference src/SimpleServer.Domain

#### Create test projects
dotnet new xunit -n SimpleServer.API.Tests -o tests/SimpleServer.API.Tests
dotnet new xunit -n SimpleServer.Service.Tests -o tests/SimpleServer.Service.Tests
dotnet sln add tests/SimpleServer.API.Tests
dotnet sln add tests/SimpleServer.Service.Tests

#### Add references to test projects
dotnet add tests/SimpleServer.API.Tests reference src/SimpleServer.API
dotnet add tests/SimpleServer.Service.Tests reference src/SimpleServer.API
dotnet add tests/SimpleServer.Service.Tests reference src/SimpleServer.Domain



SimpleServer/
├── src/
│   ├── SimpleServer.API/          # Основной API проект
│   │   ├── Controllers/           # Контроллеры (конечные точки API)
│   │   ├── Models/                # Модели запросов/ответов
│   │   ├── Services/              # Бизнес-логика
│   │   ├── Interfaces/            # Интерфейсы для сервисов
│   │   ├── Middlewares/           # Пользовательские middleware
│   │   ├── Extensions/            # Расширения для конфигурации
│   │   ├── Properties/
│   │   ├── appsettings.json
│   │   └── Program.cs
│   │
│   └── SimpleServer.Domain/       # Доменный слой (опционально)
│       ├── Entities/              # Доменные сущности
│       └── Services/              # Доменные сервисы
│
├── tests/
│   ├── SimpleServer.API.Tests/    # Юнит-тесты
│   └── SimpleServer.Service.Tests # Интеграционные тесты
│
└── SimpleServer.sln               # Файл решения



https://chat.deepseek.com/a/chat/s/74032783-488d-46d4-991c-0b02818c3f4b