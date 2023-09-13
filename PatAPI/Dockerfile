#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["PatAPI/PatAPI.csproj", "PatAPI/"]
RUN dotnet restore "PatAPI/PatAPI.csproj"
COPY . .
WORKDIR "/src/PatAPI"
RUN dotnet build "PatAPI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "PatAPI.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "PatAPI.dll"]