#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
COPY ["ADT.CHALLENGE.API/ADT.CHALLENGE.API.csproj", "ADT.CHALLENGE.API/"]
RUN dotnet restore "ADT.CHALLENGE.API/ADT.CHALLENGE.API.csproj"
COPY . .
WORKDIR "/src/ADT.CHALLENGE.API"
RUN dotnet build "ADT.CHALLENGE.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ADT.CHALLENGE.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ADT.CHALLENGE.API.dll"]