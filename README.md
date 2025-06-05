# 🛡️ AdminPanel - ASP.NET Core MVC User Management System

A professional user registration, login, and profile management web application built with:

- ASP.NET Core MVC (.NET 9.0)
- PostgreSQL Database
- Entity Framework Core
- Bootstrap 5
- Server-side Cookie Authentication

---

## 📸 Features

✅ User Registration  
✅ Secure Login with Cookie Authentication  
✅ Profile Update (Name, Password, Profile Picture)  
✅ Session-based Auth  
✅ PostgreSQL Integration  
✅ Bootstrap 5 UI  
✅ Responsive Layout  
✅ Clean MVC Architecture  

---

## 🧰 Technologies Used

| Stack | Tools |
|-------|-------|
| Backend | ASP.NET Core MVC (.NET 9.0) |
| Frontend | Bootstrap 5, Razor Views |
| Database | PostgreSQL (`Admin_db`) |
| ORM | Entity Framework Core (Npgsql) |
| Auth | Cookie-based (HttpContext.SignInAsync) |
| Hosting | Kestrel / IIS Express |
| IDE | Visual Studio 2022 / Rider |

---

## 🚀 Getting Started

### 1. Clone the Repository

```bash
git clone https://github.com/jalilkhan625/AdminPanel.git
cd AdminPanel
```

---

### 2. Configure PostgreSQL Connection

Update your `appsettings.json`:

```json
"ConnectionStrings": {
  "DefaultConnection": "Host=localhost;Port=5432;Database=Admin_db;Username=replace with yours;Password=replace with yours"
}
```

---

### 3. Install Dependencies

```bash
dotnet restore
```

Ensure these NuGet packages are installed:

- Microsoft.EntityFrameworkCore
- Microsoft.EntityFrameworkCore.Tools
- Microsoft.EntityFrameworkCore.Design
- Npgsql.EntityFrameworkCore.PostgreSQL

---

### 4. Create Database & Run Migrations

```bash
dotnet ef migrations add InitialCreate
dotnet ef database update
```

> This will create the `Users` table in your PostgreSQL database.

---

### 5. Run the Application

```bash
dotnet run
```

Visit: `https://localhost:5001`

---

## 🧪 How It Works

### 🔐 Authentication
- Cookie-based login using `HttpContext.SignInAsync(...)`
- Sessions are stored server-side

### 📂 Profile Features
- Upload a profile image
- Change name or update password
- Store images in `wwwroot/uploads/`

---

## 📁 Folder Structure

```
/Controllers
  └── AccountController.cs
/Models
  ├── User.cs
  ├── RegisterViewModel.cs
  ├── LoginViewModel.cs
  └── ProfileViewModel.cs
/Views
  └── Account
      ├── Register.cshtml
      ├── Login.cshtml
      └── Profile.cshtml
  └── Shared
      ├── _Layout.cshtml
      └── _Navbar.cshtml
/Data
  └── ApplicationDbContext.cs
/wwwroot/uploads (for profile images)
```

---

## 🙋‍♂️ Credits

Developed by [Your Name]  
Feel free to fork or contribute!

---

## 📄 License

MIT License — free for personal and commercial use.
