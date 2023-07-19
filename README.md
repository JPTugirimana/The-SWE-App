[![Code Coverage](https://codecov.io/gh/JPTugirimana/The-SWE-App/branch/master/graph/badge.svg)](https://codecov.io/gh/JPTugirimana/The-SWE-App)


# The SWE App

The Software Engineer App is a web application to allow software engineers around the world.
It helps them create online profile and showcase their portfolio projects.

Technologies:
- Backend: C# / ASP.NET Core MVC
- Frontend: HTML/CSS/JS, Bootstrap
- Database: MySQL 

# Notes
In my local dev environment, I used MySQL Workbench and i had to put database connection info in the appsettings.json (which i listed in my .gitignore file)
So, if you clone this repo, remember to add the connection (see example below) in you appsettings.json:

'''
{
    "ConnectionStrings": {
        "DefaultConnection": "Server=localhost;Database=[YOUR-DATABASE];user=[YOUR-USERNAME-HERE];password=[YOUR-PASSWORD-HERE];"
    }
}
'''