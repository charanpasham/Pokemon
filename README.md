# Pokemon

## setup instructions

1. Instal dotnet core 3.1 SDK. [Click here ](https://dotnet.microsoft.com/download/dotnet-core/3.1)
1. Install Docker [Click here](https://docs.docker.com/docker-for-mac/install/).
1. Instal sql server container for docker,for instructions [Click here](https://docs.microsoft.com/en-us/sql/linux/quickstart-install-connect-docker?view=sql-server-ver15&pivots=cs1-bash). Also some useful commands are listed below for easy access.
    > sudo docker pull mcr.microsoft.com/mssql/server:2019-latest

    >sudo docker run -e "ACCEPT_EULA=Y" -e "SA_PASSWORD=<YourStrong@Passw0rd>" \
   -p 1433:1433 --name sql1 -h sql1 \
   -d mcr.microsoft.com/mssql/server:2019-latest

   >sudo docker ps -a

   >SELECT @@SERVERNAME,
    SERVERPROPERTY('ComputerNamePhysicalNetBIOS'),
    SERVERPROPERTY('MachineName'),
    SERVERPROPERTY('ServerName')

    >sudo docker exec -it sql1 "bash"

    >/opt/mssql-tools/bin/sqlcmd -S localhost -U SA -P "<YourNewStrong@Passw0rd>"

    >sqlcmd -S <ip_address>,1433 -U SA -P "<YourNewStrong@Passw0rd>"

    >sudo docker stop sql1

    >sudo docker rm sql1
1. Install dotnet ef tool, [Click here](https://docs.microsoft.com/en-us/ef/core/miscellaneous/cli/dotnet).
    > dotnet tool install --global dotnet-ef

1. Install Node, [Click here](https://nodejs.org/en/download/).

1. Do npm ci to install all the npm package before building the UI project.

1. For building the API, follow the below instructions.

    1. Make sure to create the database PokemonDb in the sql docker container.
        > CREATE DATABASE PokemonDb
    1. Update the DB context to write all the structures to the DB.
        > DOTNET EF DATABASE UPDATE
