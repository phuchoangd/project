#Depending on the operating system of the host machines(s) that will build or run the containers, the image specified in the FROM statement may need to be changed.
#For more information, please see http://aka.ms/containercompat 

FROM microsoft/dotnet:2.1-aspnetcore-runtime-nanoserver-1709 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM microsoft/dotnet:2.1-sdk-nanoserver-1709 AS build
WORKDIR /src
COPY StockExchanges.Web/StockExchanges.Web.csproj StockExchanges.Web/
COPY StockExchanges.Model/StockExchanges.Model.csproj StockExchanges.Model/
COPY StockExchanges.Repository/StockExchanges.Repository.csproj StockExchanges.Repository/
COPY StockExchanges.Common/StockExchanges.Common.csproj StockExchanges.Common/
COPY StockExchanges.Service/StockExchanges.Service.csproj StockExchanges.Service/
RUN dotnet restore StockExchanges.Web/StockExchanges.Web.csproj
COPY . .
WORKDIR /src/StockExchanges.Web
RUN dotnet build StockExchanges.Web.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish StockExchanges.Web.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "StockExchanges.Web.dll"]
