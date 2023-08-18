FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["PsychicPets/PsychicPets.csproj", "PsychicPets/"]
RUN dotnet restore "PsychicPets/PsychicPets.csproj"
COPY . .
WORKDIR "/src/PsychicPets"
RUN dotnet build "PsychicPets.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "PsychicPets.csproj" -c Release -o /app/publish

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS final
WORKDIR /app
COPY --from=publish /app/publish .

ENTRYPOINT ["dotnet", "PsychicPets.dll"]
