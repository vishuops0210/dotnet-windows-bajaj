# Windows Server Core is required for .NET 4.7
# This container must run on a Windows host
FROM mcr.microsoft.com/dotnet/framework/sdk:4.8-windowsservercore-ltsc2019 AS build
WORKDIR /app

# Copy csproj and restore as distinct layers
COPY App.csproj ./

# Copy everything else and build app
COPY . .
RUN msbuild /p:Configuration=Release -r:False

# Build runtime image
FROM mcr.microsoft.com/dotnet/framework/aspnet:4.8-windowsservercore-ltsc2019
WORKDIR /inetpub/wwwroot
COPY --from=build /app/. ./
