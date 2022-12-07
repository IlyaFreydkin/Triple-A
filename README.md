# Triple-A
Repo für Projekt Triple A, 3CHIF 2022/23

## Vorbereitung

Erstelle mit folgendem Befehl einen Docker Container von MariaDb:

```
docker run --name mariadb -d -p 3306:3306 ^
    -e MARIADB_USER=root ^
    -e MARIADB_ROOT_PASSWORD=MySecretPassword ^
    mariadb:latest
```

