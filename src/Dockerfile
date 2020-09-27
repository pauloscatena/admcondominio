FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build
WORKDIR /app

COPY *.sln .
COPY Condo/AdmCondo.Condo.Api/*.csproj ./Condo/AdmCondo.Condo.Api/
COPY Condo/AdmCondo.Condo.Application/*.csproj ./Condo/AdmCondo.Condo.Application/
COPY Condo/AdmCondo.Condo.Domain/*.csproj ./Condo/AdmCondo.Condo.Domain/
COPY Condo/AdmCondo.Condo.Infra.Data/*.csproj ./Condo/AdmCondo.Condo.Infra.Data/
COPY Condo/AdmCondo.Condo.Infra.Ioc/*.csproj ./Condo/AdmCondo.Condo.Infra.Ioc/

RUN dotnet restore

COPY Condo/AdmCondo.Condo.Api/. ./Condo/AdmCondo.Condo.Api/
COPY Condo/AdmCondo.Condo.Application/. ./Condo/AdmCondo.Condo.Application/
COPY Condo/AdmCondo.Condo.Domain/. ./Condo/AdmCondo.Condo.Domain/
COPY Condo/AdmCondo.Condo.Infra.Data/. ./Condo/AdmCondo.Condo.Infra.Data/
COPY Condo/AdmCondo.Condo.Infra.Ioc/. ./Condo/AdmCondo.Condo.Infra.Ioc/

WORKDIR /app/Condo/AdmCondo.Condo.Api
RUN dotnet build
RUN dotnet publish -c Release -o out

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1 as runtime
WORKDIR /app

COPY --from=build /app/Condo/AdmCondo.Condo.Api/out ./
ENTRYPOINT [ "dotnet", "AdmCondo.Condo.Api.dll" ]
