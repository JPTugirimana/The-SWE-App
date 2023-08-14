[![codecov](https://codecov.io/gh/JPTugirimana/The-SWE-App/branch/master/graph/badge.svg?token=OXDGTQF7XJ)](https://codecov.io/gh/JPTugirimana/The-SWE-App)

# The SWE App

The Software Engineer App is a web application to allow software engineers around the world.
It helps them create online profile and showcase their portfolio projects.

Technologies:
- Backend: C# / ASP.NET Core MVC
- Frontend: HTML/CSS/JS, Bootstrap
- Database: MSSQL Server

# Notes
In my local dev environment, I used Visual Studio (2022) SQL Server (I later deployed in a Docker container). I had to put database connection info in the appsettings.json (which i listed in my .gitignore file)
So, if you clone this repo, remember to add the connection (see example below) in you appsettings.json with your own variables:

```
{
    "ConnectionStrings": {
        "sweappContextString": "Data Source=[YOUR-SERVER-NAME-DOCKER-COMPOSE]; Initial Catalog=[YOUR-DATABASE]; User ID=sa;Password=[YOUR-PASSWORD-HERE];"
    }
}
```