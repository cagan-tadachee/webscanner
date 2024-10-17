FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build

WORKDIR /src
COPY ["src/webscanner.Web.Host/webscanner.Web.Host.csproj", "src/webscanner.Web.Host/"]
COPY ["src/webscanner.Web.Core/webscanner.Web.Core.csproj", "src/webscanner.Web.Core/"]
COPY ["src/webscanner.Application/webscanner.Application.csproj", "src/webscanner.Application/"]
COPY ["src/webscanner.Core/webscanner.Core.csproj", "src/webscanner.Core/"]
COPY ["src/webscanner.EntityFrameworkCore/webscanner.EntityFrameworkCore.csproj", "src/webscanner.EntityFrameworkCore/"]
WORKDIR "/src/src/webscanner.Web.Host"
RUN dotnet restore 

WORKDIR /src
COPY ["src/webscanner.Web.Host", "src/webscanner.Web.Host"]
COPY ["src/webscanner.Web.Core", "src/webscanner.Web.Core"]
COPY ["src/webscanner.Application", "src/webscanner.Application"]
COPY ["src/webscanner.Core", "src/webscanner.Core"]
COPY ["src/webscanner.EntityFrameworkCore", "src/webscanner.EntityFrameworkCore"]
WORKDIR "/src/src/webscanner.Web.Host"
RUN dotnet publish -c Release -o /publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:8.0
EXPOSE 80
WORKDIR /app
COPY --from=build /publish .
ENTRYPOINT ["dotnet", "webscanner.Web.Host.dll"]
