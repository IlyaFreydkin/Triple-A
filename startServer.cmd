docker rm -f mariadb_triple_a 2> nul
docker run --name mariadb_triple_a -d -p 13306:3306 -e MARIADB_USER=root -e MARIADB_ROOT_PASSWORD=MySecretPassword mariadb:10.10.2
dotnet build TripleAProject/TripleAProject.Webapi --no-incremental --force
dotnet run -c Debug --project TripleAProject/TripleAProject.Webapi
