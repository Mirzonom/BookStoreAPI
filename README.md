# Book Store API

Это web API для автоматизации книжного магазина.

## Использование

Получение списка книг

```
GET /api/Books
```

Получение книги по ID

```
GET /api/Books/{id}
```

Добавление новой книги

```
POST /api/Books
```
При создании новой книги, **не нужно указывать ID**, так как он будет автоматически назначен.
## 
```json
{
    "id": 1,
    "title": "Война и мир",
    "price": 25.99,
    "imageUrl": "https://litres.ru/pub/c/cover/69495367.jpg",
    "category": "Роман",
    "authors": [
      "Лев Толстой"
    ]
}
```

Обновление информации о книге
```
PUT /api/Books/{id}
```

Удаление книги
```
DELETE /api/Books/{id}
```

##
## Этот проект использует следующие зависимости:

- .NET Core
- Entity Framework Core
- PostgreSQL
- Fluent Validation
- Swagger
