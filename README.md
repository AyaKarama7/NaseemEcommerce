# Naseem E-commerce Web API

An E-commerce backend built with modern .NET practices, featuring N-Tier architecture, real-time notifications, secure payments, and powerful admin management tools.

---

## 🚀 Tech Stack

- **Backend**: ASP.NET Core Web API  
- **ORM**: Entity Framework Core  
- **Database**: SQL Server  
- **Authentication**: JWT  
- **Real-Time**: SignalR  
- **Payments**: Stripe API  
- **Testing Tools**: Swagger, Postman

---

## ✨ Key Features

- **N-Tier Architecture** for clean, scalable code separation.
- **Secure Authentication** using JWT.
- **Stripe Payment Integration** for handling transactions.
- **Real-Time Admin Notifications** for new orders using SignalR.
- **Admin Dashboard** to manage products, orders, and users.
- **User Features**: Cart management, subscription handling.
- **File Management**: Uploading/downloading contracts and images.
- **Manual API Testing** with Swagger and Postman.
- - Unit testing.

---

## 📦 Project Structure

```
/NaseemEcommerceAPI
│
├── /Controllers
├── /Services
├── /Repositories
├── /DTOs
├── /Models
├── /Data (EF Core DbContext)
├── /Middleware (JWT Authentication)
├── /RealTime (SignalR Hubs)
└── /Utils
```

---

## ⚙️ Getting Started

### Prerequisites

- [.NET SDK](https://dotnet.microsoft.com/en-us/download/dotnet/)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)
- [Stripe Account](https://stripe.com/) (for payment integration)

### Setup Steps

1. **Clone the repository:**
   ```bash
   git clone https://github.com/your-username/naseem-ecommerce-api.git
   ```

2. **Update appsettings.json:**
   - Add your SQL Server connection string.
   - Add JWT secret keys.
   - Add Stripe API keys.

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
- Role-based authorization enhancements.

---

## 🧑‍💻 Author

- **AyaKarama7** — [LinkedIn](#) | [GitHub](#)
