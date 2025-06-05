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

Developed by Jalil Khan  
Feel free to fork or contribute!

---

## 📄 License

MIT License

Copyright (c) 2025 Jalil Khan

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell     
copies of the Software, and to permit persons to whom the Software is         
furnished to do so, subject to the following conditions:                      

The above copyright notice and this permission notice shall be included in    
all copies or substantial portions of the Software.                           

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR    
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,      
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE   
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER        
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, 
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN     
THE SOFTWARE.

