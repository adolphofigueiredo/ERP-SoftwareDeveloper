dotnet ef migrations add Version_0.01 --project 20241025_GestioneMagazzino

# Aggiornamento tools

dotnet tool update --global dotnet-ef

# Creazione migrazione:

dotnet ef migrations add <nomeMigrazione> --project 20241024_GestioneMagazzino_

dotnet ef migrations add Version_0.01 --project 20241024_GestioneMagazzino
dotnet ef migrations add Version_0.02 --project 20241024_GestioneMagazzino
dotnet ef migrations add Version_0.03 --project 20241024_GestioneMagazzino
dotnet ef migrations add Version_0.04 --project 20241024_GestioneMagazzino

# Applicare migrazione:

dotnet ef database update --project 20241024_GestioneMagazzino