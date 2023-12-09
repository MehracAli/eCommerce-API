#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["Presentation/eCommerce.UI/eCommerce.UI.csproj", "Presentation/eCommerce.UI/"]
COPY ["Core/eCommerce.Application/eCommerce.Application.csproj", "Core/eCommerce.Application/"]
COPY ["Core/eCommerce.Domain/eCommerce.Domain.csproj", "Core/eCommerce.Domain/"]
COPY ["Infrastructure/eCommerce.Persistance/eCommerce.Persistance.csproj", "Infrastructure/eCommerce.Persistance/"]
RUN dotnet restore "./Presentation/eCommerce.UI/./eCommerce.UI.csproj"
COPY . .
WORKDIR "/src/Presentation/eCommerce.UI"
RUN dotnet build "./eCommerce.UI.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./eCommerce.UI.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "eCommerce.UI.dll"]