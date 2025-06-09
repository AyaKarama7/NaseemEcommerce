# Naseem E-commerce Web API

An E-commerce backend built with modern .NET practices, featuring Clean architecture, and powerful admin management.

---

## 🚀 Tech Stack

- **Backend**: ASP.NET Core Web API  
- **ORM**: Entity Framework Core  
- **Database**: SQL Server  
- **Authentication**: JWT  
- **Testing Tools**: Swagger, Postman

---

## ✨ Key Features

- **Clean Architecture** for clean, scalable code separation.
- **Secure Authentication** using JWT.
- **Admin Dashboard** to manage products, orders, and users.
- **User Features**: Cart management.
- **File Management**: Uploading images.
- **Manual API Testing** with Swagger and Postman.

---

## ⚙️ Getting Started

### Prerequisites

- [.NET SDK](https://dotnet.microsoft.com/en-us/download/dotnet/)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)

### Setup Steps

1. **Clone the repository:**
   ```bash
   git clone https://github.com/AyaKarama7/NaseemEcommerce.git
   ```

2. **Update appsettings.json:**
   - Add your SQL Server connection string.
   - Add JWT secret keys.

3. **Apply migrations:**
   ```bash
   dotnet ef database update
   ```

4. **Run the project:**
   ```bash
   dotnet run
   ```

5. **Access Swagger UI:**
   ```
   https://localhost:{port}/swagger/index.html
   ```

---

## 🔒 Security

- JWT tokens for securing API endpoints.
- User-specific data access control.

---

## 📜 API Documentation

- Swagger is available at `/swagger/index.html` for full API exploration.
- Postman collection can be generated from Swagger if needed.

---

## 🛠️ Future Improvements

- Adding email notifications.
- Create UI using Angular Framewoek.
- Intgration with stripe
- using cashing redis 
---

## 🧑‍💻 Author

- **AyaKarama7** — [[LinkedIn](https://www.linkedin.com/in/aya-ahmed-karamah-90257a24a/)](#) | [[GitHub](https://github.com/AyaKarama7)](#)
