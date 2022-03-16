#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Integracao.App/Integracao.App.csproj", "Integracao.App/"]
COPY ["Integracao.Business/Integracao.Business.csproj", "Integracao.Business/"]
COPY ["Integracao.Data/Integracao.Data.csproj", "Integracao.Data/"]
COPY ["Integracao.Shared/Integracao.Shared.csproj", "Integracao.Shared/"]
RUN dotnet restore "Integracao.App/Integracao.App.csproj"
COPY . .
WORKDIR "/src/Integracao.App"
RUN dotnet build "Integracao.App.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Integracao.App.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Integracao.App.dll"]