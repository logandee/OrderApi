FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build-env

WORKDIR /app

COPY OrderApi.csproj .
RUN dotnet restore

COPY . .


RUN dotnet publish -c Relase -o out

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1

WORKDIR /app
COPY --from=build-env /app/out .

ENTRYPOINT ["dotnet", "OrderApi.dll"]