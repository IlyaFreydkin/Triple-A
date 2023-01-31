# Triple A

Klone das Repository mit folgendem Befehl:

```
git clone https://github.com/IlyaFreydkin/Triple-A
```

## Kurzbeschreibung

![image](https://user-images.githubusercontent.com/100792432/214248392-56de9ef4-7f16-4934-bb59-b652964e26fa.png)



![image](https://user-images.githubusercontent.com/100792432/212732602-c075f8f0-f3ca-4897-9aba-37e87d11ee5b.png)



Unser Projekt ist ein Streaming – Plattform, um Filme zu schauen. Tripple A wird eine 
Web – Applikation, wo es eine Suchfunktion, Wunschliste, Accounts und Feedback zu einem Film abgeben (entweder nur in Form von Likes und Dislikes oder auch mit Kommentaren). Wir haben gedacht, dass so ein Service nützlich sein kann, weil wir selbst oft Filme schauen und die meisten Streaming Anbieter von uns Daten sammeln, was uns nicht gefällt. Wir wollen das verhindern, um unsere und die Privatsphäre unserer User zu schützen.


## Teammitglieder

| Name                    | Email                  | Aufgabenbereich                         |
| ----------------------- | ---------------------- | --------------------------------------- |
| Ilya *Freydkin*, 3CHIF | fre22343@spengergasse.at |Login & SignUp im Frontend; Database Seed, Login mit JWT Authentication, User Controller |
| Richard *Liu*, 3CHIF | liu2291@spengergasse.at |  Controller Angelegt, DTO Klassen erstellt, Movie Controller |
| Uros *Veljic*, 3CHIF | vel22675@spengergasse.at | Frontend Navbar, Footer; Backend mit den Hauptklassen angelegt |
| Janus *Messner*, 3CHIF | mes22377@spengergasse.at | Login Frontend geholfen |
| Mohamed *Ahmed*, 3CHIF | ahm22106@spengergasse.at | |

## Voraussetzungen

Das Projekt verwendet .NET in der Version >= 6. Prüfe mit folgendem Befehl, ob die .NET SDK in der
Version 6 oder 7 am Rechner installiert ist:

```
dotnet --version
```

Die .NET 6 SDK (LTS Version) kann von https://dotnet.microsoft.com/en-us/download/dotnet/6.0 für alle
Plattformen geladen werden.

Zum Prüfen der Docker Installation kann der folgende Befehl verwendet werden. Er muss die Version
zurückgeben:

```
docker --version
```

Im Startskript wird der Container geladen, bevor der Server gestartet wird.

## Starten des Programmes

Führe nach dem Klonen im Terminal den folgenden Befehl aus, um den Server zu starten.

**Windows**

```
startServer.cmd
```

**macOS, Linux**

```
chmod 777 startServer.sh
./startServer.sh
```

Nach dem Starten des Servers kann im Browser die Seite **http://localhost:5000**
aufgerufen werden. Falls die Meldung erscheint, dass das Zertifikat nicht geprüft werden kann,
muss mit *Fortsetzen* bestätigt werden.

## Testuser

Um das Login zu testen, kannst du folgende Logindaten verwenden:
- Username: *lichtenfeld*
- Passwort: *1111*
