# Fitness-Tracker Projekt – Grobplanung

## Programmiersprache
➡️ Ich werde **C#** verwenden.  
Die Zeit ist am sinnvollsten investiert, da ich sowohl Backend (Logik, Datenbankzugriffe) als auch ein Frontend (WinForms oder Web) entwickeln möchte.

## Datenbank-Technologie
➡️ Ich werde mich weiter mit **SQL** beschäftigen (z.B. SQL Server oder MySQL).

## Abschluss-Projekt
➡️ Mein Abschlussprojekt wird ein **Fitness-Tracker**, der folgende Funktionen bietet:

- Workouts und Körperdaten aufzeichnen
- Trainingspläne erstellen
- Fortschritt analysieren und visualisieren

---

## Wichtigste Features

- [ ] **Feature 1**: Workouts protokollieren (Übungen, Gewicht, Wiederholungen, Sets speichern)
- [ ] **Feature 2**: Körpermaße und Gewicht tracken (inkl. Verlaufsdiagramm)
- [ ] **Feature 3**: Trainingspläne erstellen und verwalten

---

## Machbarkeitsnachweis

- Kleine Testanwendung erstellen, um Workout-Daten in die SQL-Datenbank zu speichern und auszulesen
- Diagramm (z.B. mit Chart-Komponente) aus Testdaten generieren
- Trainingspläne in einfacher Listenform abspeichern und abrufen

---

## Fortschritt

✍️ **Heute habe ich...**  
... die grobe Struktur meines Fitness-Trackers definiert, Programmiersprache (**C#**) und Datenbank (**SQL**) festgelegt und die drei wichtigsten Kernfeatures herausgearbeitet.

---

## 02.05.2025
- [x] **Arbeitspacket1**:
Erstellen ein neues C#-Projekt 
Richte die Verzeichnisstruktur für Code, Datenbank und Ressourcen ein

- [x] **Arbeitspacket2 und 3**:
Tabelle Workouts (Datum, Übung, Gewicht, Wiederholungen, Sets)
Tabelle Koerperdaten (Datum, Gewicht, Muskelumfang etc.)
Tabelle Trainingsplan (Name, Beschreibung, Übungen)


---
## 09.05.2025

## ⏭️ Nächste Schritte (Sitzung 2)

### 🧩 Arbeitspaket 3: Datenbankzugriff (DAL)
- `DatabaseManager.cs` erstellen
- Verbindung zu SQL-Server herstellen
- Methode `SaveWorkout(...)` schreiben

### 🧩 Arbeitspaket 4: Modellklassen
- `Workout.cs` erstellen
- Weitere Models: `Koerperdaten.cs`, `Trainingsplan.cs`

### 🧩 Arbeitspaket 5: UI starten
- Erste Maske in **WinForms**
- Eingabefelder: Datum, Übung, Gewicht, Wiederholungen, Sätze
- Button: „Speichern“

### 🧩 Arbeitspaket 6: Verbindung UI ↔ DB
- Button soll Workout über `DatabaseManager` speichern
- Erfolgsmeldung nach Eintrag
- Funktion testen

---

## 📁 Projektstruktur (geplant)





- [ ] **Arbeitspacket4**:
Baue ein einfaches UI-Formular für das Eintragen von Workouts (Textfelder, Buttons)
Verknüpfe die Eingabemaske mit deiner Speicherfunktion


