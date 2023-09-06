# Projekt-Dokumentation
Jan Frey

| Datum | Version | Zusammenfassung                                              |
| ----- | ------- | ------------------------------------------------------------ |
|23.08| 0.0.1   |Das Programm generiert zufällige Zahlen von 1-100 welche erraten werden können.|
|30.08| 0.1    |Erstellung der groben Benutzeroberfläche.|
|06.09| 1.0.0|Fertigstellung der Benutzeroberfläche und Bug-fixing. |

## 1 Informieren

### 1.1 Ihr Projekt

In diesem Projekt habe ich ein Zahlenratenspiel in C# programmiert.

### 1.2 User Stories

| US-№ | Verbindlichkeit | Typ  | Beschreibung                       |
| ---- | --------------- | ---- | ---------------------------------- |
| 1    | Muss|Funktional|Als ein Benutzer möchte ich, dass eine Zahl zwischen 1-100 generiert wird, die ich anschliessend erraten kann. |
| 2 |Muss|Funktional|Als ein Benutzer möchte ich Tipps erhalten, damit ich nicht planlos raten muss.|
|3|Muss|Qualität|Als ein Benutzer möchte ich eine benutzerfreundliches Design haben, damit das Spielen mehr spass macht.|
|4|Muss|Qualität|Als ein Benutzer möchte ich Hintergrundmusik haben, damit das Spielen nicht so langweilig ist.|
### 1.3 Testfälle

| TC-№ | Ausgangslage | Eingabe | Erwartete Ausgabe |
| ---- | ------------ | ------- | ----------------- |
| 1.1  |Benutzer ist dabei das Programm zu starten.|Start des Programmes|Programm startet und wartet auf eingabe des Benutzers.|
| 1.2 |Benutzer ist am Spielen|Eingabe von Zahl|Programm gibt aus, ob der Benutzer gewonnen hat.|
|2.1|Benutzer ist am Raten|Eingabe von Zahl|Programm gibt an, ob der Benutzer zu hoch oder zu tief geraten hat.|
|3.1|Benutzer startet das Programm|-|Benutzerfreundliches Design wird angezeigt.|
|4.1|Benutzer startet das Programm|-|Hintergrundmusik wird gestartet.|

## 2 Planen

| AP-№ | Frist | Zuständig | Beschreibung | geplante Zeit |
| ---- | ----- | --------- | ------------ | ------------- |
|1.A|23.08|Jan Frey|Spiel zum Laufen bringen| 90'|
|2.A|23.08|Jan Frey|Ausgabe von Tipps für den Spieler|90'|
|3.A|30.08|Jan Frey|Erstellung des benutzerfreundlichen Designs|180'|
|4.A|06.09|Jan Frey|Hintergrund Musik abspielen|180'|

Total:540' 


## 3 Realisieren

| AP-№ | Datum | Zuständig | geplante Zeit | tatsächliche Zeit |
| ---- | ----- | --------- | ------------- | ----------------- |
|1.A| 23.08|Jan Frey|90'|40'|
|2.A|23.08|Jan Frey|90'|40'|
|3.A|30.08|Jan Frey|180'|200'|
|3.A|06.09|Jan Frey|180'|180'|



## 4 Kontrollieren

### 4.1 Testprotokoll

| TC-№ | Datum | Resultat | Tester |Fazit|
| ---- | ----- | -------- | ------ |-----|
|1.1|30.08|Funktioniert fehlerfrei|Jan Frey|Keine verbesserungen nötig.|
|2.1|30.08|Funktioniert fehlerfrei|Jan Frey|Keine verbesserungen nötig.|
|3.1|06.09|Funktioniert fehlerfrei|Jan Frey|Keine verbesserungen nötig.|
|4.1|06.09|Funktioniert fehlerfrei|Jan Frey|Eventuell verzögerung beim Song wechsel verkleinern.|


