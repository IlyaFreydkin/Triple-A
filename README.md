# Triple-A
Repo für Projekt Triple A, 3CHIF 2022/23


## Software
Lade Docker Desktop bei [docs.docker.com](https://docs.docker.com/desktop/install/windows-install/) herunter. <br>
Lade DBeaver bei [dbeaver.io](https://dbeaver.io/) herunter. <br>




## Vorbereitung
Nimm diese [Video](https://youtu.be/ekmGqHBVNTM) zur Hilfe! <br>
Erstelle mit folgendem Befehl (in cmd) einen Docker Container von MariaDb:

```
docker run --name mariadb -d -p 13306:3306 ^
    -e MARIADB_USER=root ^
    -e MARIADB_ROOT_PASSWORD=MySecretPassword ^
    mariadb:latest
```

# 1.Step

1. Die sln Starten und das Projekt auführen


2. DBeaver öffnen: 
Unter File gibt es ein Steckerartiges Symbol (new Database Connection) und klicke darauf

# 2.Step
1. Nimmt MariaDB
2. Database: TripleA
3. Port: 13306
4. Password: MySecretPassword
5. Finish drücken



# Problembehandlung bei der Installation
Eines der meisten Fehler, wenn sowohl Docker als auch DBeaver nicht funktioniert, ist ein besetzter Port. Um das zu überprüfen cmd aufmachen und ```netstat -an``` eingeben. Dieser Befehl zeigt offene und besetzte Ports. Falls das Port besetzt ist gibt es zwei Möglichkeiten. Entweder beendet man das Prozess, welches auf dem Port läuft oder man gibt Bei dem DBeaver, Docker, Workbench und in den appsettings.json einen anderen freien Port an.



## Info
Der branch für issues ist jetzt angelegt!


