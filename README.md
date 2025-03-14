# SurvivorApi


## Overview
The **Survivor API** is a web-based RESTful API developed using **.NET Core** and **Entity Framework Core**. It allows users to manage **competitors** and **categories** in a Survivor-style competition.

## Features
- **CRUD operations** for managing Competitors and Categories.
- **Entity Framework Core** for database management.
- **Request & Response models** for structured API communication.
- **Swagger Integration** for easy API documentation and testing.
- **Migrations & Database Handling** with SQL Server.

## Technologies Used
- **.NET Core 8.0**
- **Entity Framework Core**
- **SQL Server**
- **Swagger UI**

---

## Project Structure
```
SurvivorApi
│── Context
│   │── SurvivorDbContext.cs
│
│── Controllers
│   │── CategoriesController.cs
│   │── CompetitorsController.cs
│
│── Entities
│   │── BaseEntity.cs
│   │── CategoryEntity.cs
│   │── CompetitorEntity.cs
│
│── Migrations
│
│── Models
│   │── Category
│   │   │── CategoryCreateRequest.cs
│   │   │── CategoryDetailResponse.cs
│   │   │── CategoryListResponse.cs
│   │   │── CategoryUpdateRequest.cs
│   │
│   │── Competitor
│   │   │── CompetitorCreateRequest.cs
│   │   │── CompetitorDetailResponse.cs
│   │   │── CompetitorListResponse.cs
│   │   │── CompetitorUpdateRequest.cs
│
│── Properties
│── Program.cs
│── appsettings.json
│── README.md
```

---

## API Endpoints

### **CompetitorController**
| Method | Endpoint | Description |
|--------|---------|-------------|
| `GET` | `/api/competitors` | Retrieve all competitors |
| `GET` | `/api/competitors/{id}` | Get a specific competitor by ID |
| `GET` | `/api/competitors/categories/{categoryId}` | Get competitors by category ID |
| `POST` | `/api/competitors` | Create a new competitor |
| `PUT` | `/api/competitors/{id}` | Update a competitor |
| `DELETE` | `/api/competitors/{id}` | Delete a competitor |

### **CategoryController**
| Method | Endpoint | Description |
|--------|---------|-------------|
| `GET` | `/api/categories` | Retrieve all categories |
| `GET` | `/api/categories/{id}` | Get a specific category by ID |
| `POST` | `/api/categories` | Create a new category |
| `PUT` | `/api/categories/{id}` | Update a category |
| `DELETE` | `/api/categories/{id}` | Delete a category |

---

## Setup Instructions

### **1️⃣ Clone the Repository**
```sh
git clone https://github.com/ekinnn35/SurvivorApi.git
cd SurvivorApi
```


### **3️⃣ Configure Database**
Update the `appsettings.json` file with your **SQL Server** connection string:
```json
"ConnectionStrings": {
  "DefaultConnection": "Server=YOUR_SERVER;Database=SurvivorDB;Trusted_Connection=True;TrustServerCertificate=True"
}
```

### **4️⃣ Apply Migrations & Update Database**
```sh
Add-Migration InitialCreate
Update-Database
```

### **6️⃣ Open Swagger for API Testing**
Go to:
```
http://localhost:5000/swagger
```

---

## Contribution Guidelines
We welcome contributions! To contribute:
1. Fork the repository.
2. Create a new branch.
3. Make your changes and commit.
4. Submit a pull request.


---

**Happy Coding! 🚀**

