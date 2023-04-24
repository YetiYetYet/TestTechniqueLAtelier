FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["TestTechniqueLAtelier/TestTechniqueLAtelier.csproj", "TestTechniqueLAtelier/"]
RUN dotnet restore "TestTechniqueLAtelier/TestTechniqueLAtelier.csproj"
COPY . .
WORKDIR "/src/TestTechniqueLAtelier"
RUN dotnet build "TestTechniqueLAtelier.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "TestTechniqueLAtelier.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "TestTechniqueLAtelier.dll"]
