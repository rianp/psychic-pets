# Use a base image that includes the SQL Server tools
FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80

# Install the SQL Server tools
RUN apt-get update && apt-get install -y mssql-tools

# Use the SDK image for building
FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["PsychicPets/PsychicPets.csproj", "PsychicPets/"]
RUN dotnet restore "PsychicPets/PsychicPets.csproj"
COPY . .
WORKDIR "/src/PsychicPets"
RUN dotnet build "PsychicPets.csproj" -c Release -o /app/build

# Use the base image with SQL Server tools for the final image
FROM base AS final
WORKDIR /app
COPY --from=build /app/build .
ENTRYPOINT ["dotnet", "PsychicPets.dll"]
