FROM mcr.microsoft.com/dotnet/sdk:6.0
COPY . /app
WORKDIR /app
RUN ["dotnet", "restore"]
RUN ["dotnet", "build"]
RUN dotnet tool install -g dotnet-ef
ENV PATH $PATH:/root/.dotnet/tools
ENV ASPNETCORE_URLS=http://*:80  
EXPOSE 80
RUN chmod +x ./entrypoint.sh
CMD /bin/bash ./entrypoint.sh