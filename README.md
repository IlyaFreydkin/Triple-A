# Projekt (Projektname)

Klone das Repository mit folgendem Befehl:

```
git clone https://github.com/IlyaFreydkin/Triple-A
```

## Kurzbeschreibung

Füge mit `![](filename.png)` ein Screenshot der App ein, die eine schöne Maske zeigt.

Füge hier mit 1 Absatz eine kleine Beschreibung ein, was das Projekt macht.

## Teammitglieder

| Name                    | Email                  | Aufgabenbereich                         |
| ----------------------- | ---------------------- | --------------------------------------- |
| Max *Mustermann*, 3CHIF | mus123@spengergasse.at | Login im Backend, Registration Formular |
| Max *Mustermann*, 3CHIF | mus123@spengergasse.at | Login im Backend, Registration Formular |

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
./startServer.sh
```

Nach dem Starten des Servers kann im Browser die Seite **http://localhost:5000**
aufgerufen werden. Falls die Meldung erscheint, dass das Zertifikat nicht geprüft werden kann,
muss mit *Fortsetzen* bestätigt werden.

