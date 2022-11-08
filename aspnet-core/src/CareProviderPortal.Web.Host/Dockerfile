#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["src/CareProviderPortal.Web.Host/CareProviderPortal.Web.Host.csproj", "src/CareProviderPortal.Web.Host/"]
COPY ["src/CareProviderPortal.Web.Core/CareProviderPortal.Web.Core.csproj", "src/CareProviderPortal.Web.Core/"]
COPY ["src/CareProviderPortal.Application/CareProviderPortal.Application.csproj", "src/CareProviderPortal.Application/"]
COPY ["src/CareProviderPortal.Application.Shared/CareProviderPortal.Application.Shared.csproj", "src/CareProviderPortal.Application.Shared/"]
COPY ["src/CareProviderPortal.Core.Shared/CareProviderPortal.Core.Shared.csproj", "src/CareProviderPortal.Core.Shared/"]
COPY ["src/CareProviderPortal.Core/CareProviderPortal.Core.csproj", "src/CareProviderPortal.Core/"]
COPY ["src/CareProviderPortal.EntityFrameworkCore/CareProviderPortal.EntityFrameworkCore.csproj", "src/CareProviderPortal.EntityFrameworkCore/"]
COPY ["src/CareProviderPortal.GraphQL/CareProviderPortal.GraphQL.csproj", "src/CareProviderPortal.GraphQL/"]
RUN dotnet restore "src/CareProviderPortal.Web.Host/CareProviderPortal.Web.Host.csproj"
COPY . .
WORKDIR "/src/src/CareProviderPortal.Web.Host"
RUN dotnet build "CareProviderPortal.Web.Host.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "CareProviderPortal.Web.Host.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "CareProviderPortal.Web.Host.dll"]
