FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build

WORKDIR /src
COPY . .

WORKDIR "/src/ApiWorkflow"
RUN dotnet restore ApiWorkflow.csproj 
RUN dotnet build . -c Release --no-restore

FROM build AS publish
RUN dotnet publish . -c Release -o /app/publish --no-restore --no-build

FROM mcr.microsoft.com/dotnet/aspnet:6.0
WORKDIR /app
COPY --from=publish /app/publish .
#COPY .buildinfo ./

ENTRYPOINT ["dotnet", "ApiWorkflow.dll"]