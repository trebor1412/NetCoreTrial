# Usage

Create docker image:

`
docker build -t {image name}
`

Startup the northwind database using sqlserver, remember change the password in the command and in import-database.sh.

`
docker run -e ACCEPT_EULA=Y -e SA_PASSWORD=Hk3345678 -p 1433:1433 -d mssql-northwind
`
