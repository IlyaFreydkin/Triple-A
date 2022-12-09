# Triple-A
Repo für Projekt Triple A, 3CHIF 2022/23

## Vorbereitung

Lade Docker Desktop bei [docs.docker.com](https://docs.docker.com/desktop/install/windows-install/) herunter. <br>
Lade DBeaver bei [dbeaver.io](https://dbeaver.io/) herunter. <br>
Lade linux kernel update package bei [learn.microsoft.com](WSL2 Linux kernel update package for x64 machines) herunter.

Erstelle mit folgendem Befehl (in cmd) einen Docker Container von MariaDb:

```
docker run --name mariadb -d -p 13306:3306 ^
    -e MARIADB_USER=root ^
    -e MARIADB_ROOT_PASSWORD=MySecretPassword ^
    mariadb:latest
```

## 1.Step
DBeaver öffnen:
Unter File gibt es ein Steckerartiges Symbol (new Database Connection) und klicke darauf

## 2.Step
1. Nimmt MariaDB
2. Database: TripleA
3. Port: 13306
4. Password: MySecretPassword



