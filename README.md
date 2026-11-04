# Loja Masculina API

API de e-commerce de moda masculina em ASP.NET Core (.NET 10) com PostgreSQL.

## Pré-requisitos
- .NET 10 SDK
- Docker Desktop

## Como rodar

### Banco de dados
```bash
docker compose up -d      # sobe o PostgreSQL
docker compose stop       # para (mantém os dados)
docker compose start      # sobe de novo
docker compose down       # remove o container (dados ficam no volume)
docker compose down -v    # remove tudo, inclusive os dados
```

### API
```bash
dotnet run --project src/Loja.Api
```