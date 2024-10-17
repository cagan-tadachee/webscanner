FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build

RUN dotnet tool install -g Microsoft.Web.LibraryManager.Cli
RUN ln -s ~/.dotnet/tools/libman /usr/local/bin/libman

WORKDIR /src
COPY ["src/webscanner.Web.Mvc/webscanner.Web.Mvc.csproj", "src/webscanner.Web.Mvc/"]
COPY ["src/webscanner.Web.Core/webscanner.Web.Core.csproj", "src/webscanner.Web.Core/"]
COPY ["src/webscanner.Application/webscanner.Application.csproj", "src/webscanner.Application/"]
COPY ["src/webscanner.Core/webscanner.Core.csproj", "src/webscanner.Core/"]
COPY ["src/webscanner.EntityFrameworkCore/webscanner.EntityFrameworkCore.csproj", "src/webscanner.EntityFrameworkCore/"]
WORKDIR "/src/src/webscanner.Web.Mvc"
RUN dotnet restore 

WORKDIR /src
COPY ["src/webscanner.Web.Mvc", "src/webscanner.Web.Mvc"]
COPY ["src/webscanner.Web.Core", "src/webscanner.Web.Core"]
COPY ["src/webscanner.Application", "src/webscanner.Application"]
COPY ["src/webscanner.Core", "src/webscanner.Core"]
COPY ["src/webscanner.EntityFrameworkCore", "src/webscanner.EntityFrameworkCore"]
WORKDIR "/src/src/webscanner.Web.Mvc"
RUN libman restore
RUN dotnet publish -c Release -o /publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:8.0
EXPOSE 80
WORKDIR /app
COPY --from=build /publish .
ENTRYPOINT ["dotnet", "webscanner.Web.Mvc.dll"]
