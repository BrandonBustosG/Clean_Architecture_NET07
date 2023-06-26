# Clean_Architecture_NET07

Codigo del proyecto del curso https://github.com/ferventurart/EasyPOS


### Crear Migracion
- dotnet tool install --global dotnet-ef
- dotnet ef migrations add InitialMigration -p Infraestructure -s Web.API -o Persistence/Migrations
- dotnet ef database update -p Infraestructure -s Web.API