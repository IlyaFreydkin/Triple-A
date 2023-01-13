# Triple-A
Repo für Projekt Triple A, 3CHIF 2022/23


## Software
- Docker
    -Lade Docker Desktop bei [docs.docker.com](https://docs.docker.com/desktop/install/windows-install/) herunter. <br>
- Dbeaver
    -Lade DBeaver bei [dbeaver.io](https://dbeaver.io/) herunter. <br>
- Visual Studio
    - Installiere bitte Visual Studio, damit der Back-End welcher mit C# programmiert wurde funktioniert. [inkl. ASP.NET]
-Vsual Studio Code
    - Installiere bitte Visual Studio Code, damit der Front-End welcher mit Vue.js, CSS, JavaScript und HTML programmiert wurde funktioniert.

*Optional* :
  Wenn man die GET und POST Nachrichten sehen will und testen installiere bitte zusätzlich [Postman](https://www.postman.com/downloads/)


# 1.Step
Nimm diese [Video](https://youtu.be/ekmGqHBVNTM) zur Hilfe! <br>
Erstelle mit folgendem Befehl (in cmd) einen Docker Container von MariaDb:

```
docker run --name mariadb -d -p 13306:3306 ^
    -e MARIADB_USER=root ^
    -e MARIADB_ROOT_PASSWORD=MySecretPassword ^
    mariadb:latest
```

# 2.Step

1. Die sln Starten und das Projekt auführen


# 3.Step

2. DBeaver öffnen: 
Unter File gibt es ein Steckerartiges Symbol (new Database Connection) und klicke darauf

    1. Nimmt MariaDB
    2. Database: TripleA
    3. Port: 13306
    4. Password: MySecretPassword
    5. Finish drücken



# Problembehandlung bei der Installation
Eines der meisten Fehler, wenn sowohl Docker als auch DBeaver nicht funktioniert, ist ein besetzter Port. Um das zu überprüfen cmd aufmachen und ```netstat -an``` eingeben. Dieser Befehl zeigt offene und besetzte Ports. Falls das Port besetzt ist gibt es zwei Möglichkeiten. Entweder beendet man das Prozess, welches auf dem Port läuft oder man gibt Bei dem DBeaver, Docker und in den appsettings.json einen anderen freien Port an.




## Login Use-Case testen:

    - Git Repo auf C/: clonen
    
    - Den installierten Docker container starten:
    ![image](https://user-images.githubusercontent.com/100792432/212286499-5696d3bf-b55f-4473-ab61-c7c849a9680c.png)
    
    - Im ordner TripleA Project die datei startServer.cmd starten und warten bis eine leere seite im Browser aufgemacht wird:
    ![image](https://user-images.githubusercontent.com/100792432/212287666-aaceddc2-b288-4c8b-838c-e9c12928ccb6.png)
    
    - Im ordner TripleA Project die datei TripleAProject.sln starten und Webapi im richtigen Branch ausführen ausführen:
    ![image](https://user-images.githubusercontent.com/100792432/212291250-f5ef7ac3-12c6-458e-b709-581aae9ba581.png)
    
    - Postman aufmachen und folgende Einstellungen treffen:
        - In die Settings gehen: 
          ![image](https://user-images.githubusercontent.com/100792432/212288480-a6c416bd-a12b-4f14-8efb-24c9dfca0775.png)

        - SSL ausschalten:
          ![image](https://user-images.githubusercontent.com/100792432/212288820-b529ad34-078a-4c3f-be3b-9f294a5764a8.png)

        - zunächst in einer neuen Connection jeweils einen POST und einen GET Request erstellen. Folgendes JSON ist im Body Tab einzufügen und den Request Abschicken:
        
      
        {
            "Name" : "lichtenfeld",
            "Password": "1111",
            "Email": "ilyafreyd00@gmail.com",
            "Role" : 1
        }
      
        
        - Den bekommenen Token in die Zwischenablage kopieren:
            ![image](https://user-images.githubusercontent.com/100792432/212289649-b3ffd414-de05-4b94-a20d-f21bc47818d6.png)

        - Beim GET Request im Authorization Tab *Bearer Token* auswählen und den kopierten Token einfügen und den Request absenden:
            ![image](https://user-images.githubusercontent.com/100792432/212290070-00622cf0-0b1b-4860-bc07-0f8aa05920af.png)

        - Wenn man Den User *Lichtenfeld* bekommt und der Status *200 ok* ist heißt das, dass der Login funktioniert hat
        
        
        ## Nähere erklärung:
        
        Lichtenfeld ist ein generierter User von dem Bogus Faker. Wir simulieren also den Login dieses Users und seine Daten werden im POST Request übermittelt. Danach bekommen wir einen einzelartigen Token als Authenthication [JWT-Authentication]. dieser Token wird mit dem GET Request überprüft und das Login erfolgt.

