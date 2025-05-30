

# 🚀 MyAPP – Application ASP.NET Core MVC + SQL Server

Application web développée avec **ASP.NET Core 9 MVC** utilisant **SQL Server** comme base de données relationnelle. Ce projet suit une architecture MVC propre et évolutive, orientée bonnes pratiques .NET.


## 🧱 Stack Technique

- **.NET 9 / ASP.NET Core MVC**
- **Entity Framework Core**
- **SQL Server** (LocalDB)
- **Razor Pages**

## 📦 Pré-requis

- [.NET 9 SDK](https://dotnet.microsoft.com/download)
- [SQL Server](https://www.microsoft.com/fr-fr/sql-server/sql-server-downloads)
- [Visual Studio 2022](https://visualstudio.microsoft.com/)

## 🚀 Lancer le projet en local

```bash
git clone https://github.com/ton-user/nom-du-projet.git
cd nom-du-projet
dotnet restore
```

### 🔧 Configurer la chaîne de connexion SQL Server

Modifier `appsettings.json` :

```json
"ConnectionStrings": {
  "DefaultConnection": "Server=localhost;Database=NomDeTaDB;Trusted_Connection=True; Certificate=true"
}
```

### 🧬 Appliquer les migrations EF Core (si utilisé)

```bash
dotnet ef database update
```

### ▶️ Démarrer l'application

```bash
dotnet run
```

## 📁 Structure du Projet

```
├── Controllers/       # Logique métier
├── Views/             # Templates Razor
├── Models/            # Modèles de données
├── Data/              # DbContext & Migrations
├── wwwroot/           # Fichiers statiques (JS/CSS/img)
├── appsettings.json   # Configurations
├── Program.cs         # Entrée de l'app
├── Startup.cs         # Services & pipeline middleware
└── README.md
```

## 📄 Licence

Projet sous licence **MIT** – open source, libre à utiliser et à modifier.

## 🙌 Auteur

**KONDO Ibrahim**  
📧 ibraumodnokpro@gmail.com  
🔗 [IBRAUM](https://github.com/ibraum)