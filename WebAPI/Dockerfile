FROM mcr.microsoft.com/dotnet/sdk
COPY . /app
WORKDIR /app
RUN dotnet restore && \
    dotnet build && \
    dotnet tool install -g dotnet-ef && \
    chmod +x ./entrypoint.sh
ENV PATH=$PATH:/root/.dotnet/tools \
    ASPNETCORE_URLS=http://*:80

EXPOSE 80
CMD /bin/bash ./entrypoint.sh