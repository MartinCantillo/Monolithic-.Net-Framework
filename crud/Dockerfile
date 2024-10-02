# Base stage: Image for production runtime
# We use an ASP.NET Core 8.0 base image optimized for production runtime
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base

# Set the working directory inside the container
WORKDIR /app

# Expose port 80 so the application can be accessed via HTTP
EXPOSE 80

# Build stage: Image to develop and compile the application
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build

# Set the working directory for the build process
WORKDIR /src

# Copy the .csproj project file to the container
COPY ["crud.csproj", "./"]

# Restore the necessary dependencies (based on the .csproj file)
RUN dotnet restore "crud.csproj"

# Copy the rest of the project files to the container
COPY . .

# Set the current working directory
WORKDIR "/src/"

# Compile the project in Release mode and output the built files to /app/build
RUN dotnet build "crud.csproj" -c Release -o /app/build

# Publish stage: Prepares the files for runtime
FROM build AS publish

# Publish the application (preparing everything necessary to run the app)
RUN dotnet publish "crud.csproj" -c Release -o /app/publish

# Final stage: Run the application
# We use the ASP.NET Core base image again
FROM base AS final

# Set the working directory to /app
WORKDIR /app

# Copy the published files from the previous stage to the working directory
COPY --from=publish /app/publish .

# Define the entry point, which runs the MVC application
ENTRYPOINT ["dotnet", "crud.dll"]
