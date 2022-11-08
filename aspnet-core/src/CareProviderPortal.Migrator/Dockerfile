#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["src/CareProviderPortal.Migrator/CareProviderPortal.Migrator.csproj", "src/CareProviderPortal.Migrator/"]
COPY ["src/CareProviderPortal.EntityFrameworkCore/CareProviderPortal.EntityFrameworkCore.csproj", "src/CareProviderPortal.EntityFrameworkCore/"]
COPY ["src/CareProviderPortal.Core/CareProviderPortal.Core.csproj", "src/CareProviderPortal.Core/"]
COPY ["src/CareProviderPortal.Core.Shared/CareProviderPortal.Core.Shared.csproj", "src/CareProviderPortal.Core.Shared/"]
RUN dotnet restore "src/CareProviderPortal.Migrator/CareProviderPortal.Migrator.csproj"
COPY . .
WORKDIR "/src/src/CareProviderPortal.Migrator"
RUN dotnet build "CareProviderPortal.Migrator.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "CareProviderPortal.Migrator.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "CareProviderPortal.Migrator.dll", "-s"]
