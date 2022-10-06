#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["API.Conciertos.MVC/API.Conciertos.MVC.csproj", "API.Conciertos.MVC/"]
RUN dotnet restore "API.Conciertos.MVC/API.Conciertos.MVC.csproj"
COPY . .
WORKDIR "/src/API.Conciertos.MVC"
RUN dotnet build "API.Conciertos.MVC.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "API.Conciertos.MVC.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "API.Conciertos.MVC.dll"]