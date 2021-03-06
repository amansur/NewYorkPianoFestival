FROM microsoft/aspnetcore-build:latest

COPY . /app
WORKDIR /app/Web

RUN ["dotnet", "restore"]
RUN ["dotnet", "build"]

EXPOSE 5000/tcp
ENV ASPNETCORE_URLS http://*:5000

ENTRYPOINT ["dotnet", "run"]