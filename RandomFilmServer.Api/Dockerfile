#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
COPY ["RandomFilmServer.Api/RandomFilmServer.Api.csproj", "RandomFilmServer.Api/"]
COPY ["RandomFilmServer.DataAccess/RandomFilmServer.DataAccess.csproj", "RandomFilmServer.DataAccess/"]
COPY ["RandomFilmServer.Domain/RandomFilmServer.Domain.csproj", "RandomFilmServer.Domain/"]
RUN dotnet restore "RandomFilmServer.Api/RandomFilmServer.Api.csproj"
COPY . .
WORKDIR "/src/RandomFilmServer.Api"
RUN dotnet build "RandomFilmServer.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "RandomFilmServer.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "RandomFilmServer.Api.dll"]