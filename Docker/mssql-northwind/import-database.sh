#wait for the SQL Server to come up
sleep 3s

#run the setup script to create the DB and the schema in the DB
/opt/mssql-tools/bin/sqlcmd -S localhost -U sa -P Hk3345678 -d master -i Northwind.sql

#keep alive
while true; do sleep 1000; done
