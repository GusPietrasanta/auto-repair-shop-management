﻿# mcr.microsoft.com/dotnet/aspnet:7.0 -> Run-Only Environment
# mcr.microsoft.com/dotnet/sdk:7.0 -> Build Environment

# Get the base layer
FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
# Create a folder called /src and set it as the "default" directory
WORKDIR /src
# ManualDocker.sln and ManualDockerApp.csproj usually don't change
# Copy ManualDocker.sln into /src
COPY ./auto-repair-shop-management.sln ./
# Copy ManualDocker.csproj into /src/BlazorApp
COPY ./BlazorApp/BlazorApp.csproj ./BlazorApp/
# Add support library
COPY ./DataAccessLibrary/DataAccessLibrary.csproj ./DataAccessLibrary/
# Add database?
COPY ./Database/RepairShopDB.sqlproj ./Database/
# Add Tests
COPY ./RepairShopTests/RepairShopTests.csproj ./RepairShopTests/
# Restore the NuGet packages that this project needs
RUN dotnet restore
# Copy everything (even the source code) from the solution folder (host machine) into the /src folder (container)
COPY . .
# Build the solution (get it ready to docker run) and output it (-o) to the /app/ folder
RUN dotnet publish ./BlazorApp/BlazorApp.csproj -c Debug -o /app/


# Get the base layer
FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS final
# Create and set working directory
WORKDIR /app
# Copy everything from the /app folder (those are the "Release" files only) of the previous image into the /app folder of THIS container
COPY --from=build /app .

# Copy Test XMLs?
RUN mkdir -p /DataAccessLibrary/Data/APIs/TestXMLs/
COPY ./DataAccessLibrary/Data/APIs/TestXMLs/ ./DataAccessLibrary/Data/APIs/TestXMLs/

# Expose ports
EXPOSE 80
EXPOSE 443
# Set Entrypoint (script or executable that the container starts (by default) when it's run
# ENTRYPOINT ["executable", "param1", "param2"]
# When we start up this image it's going to run this following command that will start the web server
ENTRYPOINT ["dotnet", "BlazorApp.dll"]