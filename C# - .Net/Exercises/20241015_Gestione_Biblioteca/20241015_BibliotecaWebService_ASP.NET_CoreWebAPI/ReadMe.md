# Aggiornamento tools

dotnet tool update --global dotnet-ef

# Creazione migrazione:

dotnet ef migrations add <nomeMigrazione> --project 20241015_BibliotecaWebService_ASP.NET_CoreWebAPI

# Applicare migrazione:

dotnet ef database update --project 20241015_BibliotecaWebService_ASP.NET_CoreWebAPI