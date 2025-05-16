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

##  Nächste Schritte (Sitzung 2)

###  Arbeitspaket 1: Datenbankzugriff (DAL)
- `DatabaseManager.cs` erstellen
- Verbindung zu SQL-Server herstellen
- Methode `SaveWorkout(...)` schreiben

### Arbeitspaket 2: Modellklassen
- `Workout.cs` erstellen
- Weitere Models: `Koerperdaten.cs`, `Trainingsplan.cs`

###  Arbeitspaket 3: UI starten
- Erste Maske in **WinForms**
- Eingabefelder: Datum, Übung, Gewicht, Wiederholungen, Sätze
- Button: „Speichern“

###  Arbeitspaket 4: Verbindung UI ↔ DB
- Button soll Workout über `DatabaseManager` speichern
- Erfolgsmeldung nach Eintrag
- Funktion testen

---

## 📁 Projektstruktur (geplant)



## Projektstruktur:

Die aktuelle Struktur des Projekts ist wie folgt organisiert:
/FitnessTracker
  /src
    /FitnessTracker.Core
      /Models
        Workout.cs
        Koerperdaten.cs
        Trainingsplan.cs
        PlanExercise.cs
      /Data
        FitnessDbContext.cs
      /Services
        DatabaseManager.cs (geplant)
      FitnessTracker.Core.csproj
      appsettings.json
    /FitnessTracker.WinForms
      /Forms
        WorkoutForm.cs (geplant)
        MainForm.cs (zukünftig für Hauptnavigation)
      /Controls
        (Für zukünftige benutzerdefinierte Steuerelemente)
      Program.cs
      FitnessTracker.WinForms.csproj
      appsettings.json
    /FitnessTracker.Tests
      (Platzhalter für Unit-Tests)
  /db
    /migrations
      (Entity Framework Core Migrations)
    /scripts
      init.sql (Initiales Datenbankskript)
  /resources
    /images
      (Für zukünftige Icons oder Grafiken)
    /docs
      README.md
  FitnessTracker.sln


## Arbeitspakete für heute (16.05.2025) Datenbankzugriff (Data Access Layer)
Ziel: Implementiere die DatabaseManager-Klasse für den Zugriff auf die SQL-Datenbank.
1:Erstelle DatabaseManager.cs in FitnessTracker.Core/Services.
2:Stelle die Verbindung zu SQL Server her (nutze Entity Framework Core und die appsettings.json).
3:Implementiere die Methode SaveWorkout(Workout workout) zum Speichern von Workouts.
4:Teste die Methode mit einer Konsolen-App, die einen Test-Workout-Datensatz speichert und ausliest.

