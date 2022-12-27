FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
COPY /bin/Release/net6.0/publish .

ENV ASPNETCORE_URLS="http://*4500"
ENV ASPNETCORE_ENVIRONMENT="Development"
ENTRYPOINT ["dotnet","DockerVolumeMvc.dll"]