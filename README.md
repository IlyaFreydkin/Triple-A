# Triple-A
Repo für Projekt Triple A, 3CHIF 2022/23

## Vorbereitung

Lade Docker Desktop bei [docs.docker.com](https://docs.docker.com/desktop/install/windows-install/) herunter
Lade DBeaver bei [dbeaver.io](https://dbeaver.io/) herunter

Erstelle mit folgendem Befehl einen Docker Container von MariaDb:

```
docker run --name mariadb -d -p 3306:3306 ^
    -e MARIADB_USER=root ^
    -e MARIADB_ROOT_PASSWORD=MySecretPassword ^
    mariadb:latest
```

## 1.Step
DBeaver öffnen:
Unter File gibt es ein Steckerartiges Symbol (new Database Connection) und klicke darauf

## 2.Step
Anschließend erscheint ein Menü: 
    1. Wähle MariaDB aus
    2. Ändere Database zu "TripleA"
    3. Ändere Passwort zu "mysql"