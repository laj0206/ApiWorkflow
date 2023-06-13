FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /source
COPY ["src/ApiWorkflow/ApiWorkflow.csproj", "src/ApiWorkflow/"]
COPY ["src/ApiWorkflow.Infrastructure/ApiWorkflow.Infrastructure.csproj", "src/ApiWorkflow.Infrastructure/"]
RUN dotnet restore "src/ApiWorkflow/ApiWorkflow.csproj"
COPY . .
WORKDIR "/source/src/ApiWorkflow"
RUN dotnet build "ApiWorkflow.csproj" -c Release --no-restore -o /app/build

FROM build AS publish
RUN dotnet publish "ApiWorkflow.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ApiWorkflow.dll"]
