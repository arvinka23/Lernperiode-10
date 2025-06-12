# Fitness-Tracker Projekt – Grobplanung

## Programmiersprache
➡️ Ich werde **C#** verwenden.  
Die Zeit ist am sinnvollsten investiert, da ich sowohl Backend (Logik, Datenbankzugriffe) als auch ein Frontend (WinForms oder Web) entwickeln möchte.

## Datenbank-Technologie
➡️ Ich werde mich weiter mit **SQL** beschäftigen (z. B. SQL Server oder MySQL).

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
- Diagramm (z. B. mit Chart-Komponente) aus Testdaten generieren
- Trainingspläne in einfacher Listenform abspeichern und abrufen

---

## Fortschritt

✍️ **Heute habe ich...**  
... die grobe Struktur meines Fitness-Trackers definiert, Programmiersprache (**C#**) und Datenbank (**SQL**) festgelegt und die drei wichtigsten Kernfeatures herausgearbeitet. Bis zum 13.06.2025 habe ich die Datenbankstruktur, Modellklassen und erste Datenbankzugriffsmethoden implementiert.

---

## 02.05.2025

### Arbeitspakete
- [x] **Arbeitspaket 1**:  
  Erstellen eines neuen C#-Projekts  
  Richte die Verzeichnisstruktur für Code, Datenbank und Ressourcen ein  

- [x] **Arbeitspaket 2**:  
  Tabelle Workouts (Datum, Übung, Gewicht, Wiederholungen, Sets)  

- [x] **Arbeitspaket 3**:  
  Tabelle Körperdaten (Datum, Gewicht, Muskelumfang etc.)  

- [x] **Arbeitspaket 4**:  
  Tabelle Trainingsplan (Name, Beschreibung, Übungen)  

### Reflexion
Der Start am 02.05.2025 lief gut. Das Erstellen des Projekts und die Definition der Verzeichnisstruktur waren einfach, da ich bereits Erfahrung mit C# habe. Die Erstellung der Tabellen war ein wichtiger Schritt, um die Datenbankstruktur zu planen. Ich bin zufrieden mit dem Fortschritt und bereit, nächste Woche den Datenbankzugriff zu implementieren.

---

## 09.05.2025

### Arbeitspakete
- [x] **Arbeitspaket 1**:  
  `DatabaseManager.cs` erstellen  
  Verbindung zu SQL Server herstellen (nutze Entity Framework Core und `appsettings.json`)  

- [x] **Arbeitspaket 2**:  
  `Workout.cs` erstellen  
  Weitere Modelle: `Körperdaten.cs`, `Trainingsplan.cs`  

- [x] **Arbeitspaket 3**:  
  Erste Maske in **WinForms** erstellen  
  Eingabefelder: Datum, Übung, Gewicht, Wiederholungen, Sätze  
  Button: „Speichern“  

- [x] **Arbeitspaket 4**:  
  Button soll Workout über `DatabaseManager` speichern  
  Erfolgsmeldung nach Eintrag  
  Funktion testen  

### Reflexion
Am 09.05.2025 habe ich Fortschritte gemacht, besonders mit der Einrichtung von Entity Framework Core und der Verbindung zur SQL-Datenbank. Die Modellklassen waren einfach zu erstellen. Die erste WinForms-Maske war eine neue Erfahrung, aber mit Tutorials konnte ich sie umsetzen. Das Testen der Speicherfunktion war erfolgreich, obwohl ich ein paar kleine Fehler bei der `appsettings.json`-Konfiguration korrigieren musste. Ich bin motiviert für die nächste Woche.

---

## 16.05.2025

### Arbeitspakete
- [x] **Arbeitspaket 1**:  
  Erstelle `DatabaseManager.cs` in `FitnessTracker.Core/Services`  

- [x] **Arbeitspaket 2**:  
  Stelle die Verbindung zu SQL Server her (nutze Entity Framework Core und `appsettings.json`)  

- [x] **Arbeitspaket 3**:  
  Implementiere die Methode `SaveWorkout(Workout workout)` zum Speichern von Workouts  

- [x] **Arbeitspaket 4**:  
  Teste die Methode mit einer Konsolen-App, die einen Test-Workout-Datensatz speichert und ausliest  

### Reflexion
Am 16.05.2025 habe ich die `DatabaseManager`-Klasse erfolgreich implementiert und die Verbindung zur SQL-Datenbank stabilisiert. Die Methode `SaveWorkout` funktioniert gut, aber ich hatte anfangs Probleme mit Entity Framework Core, die ich durch Dokumentation lösen konnte. Die Konsolen-App war ein effektiver Test, und ich bin zufrieden mit den Ergebnissen. Nächste Woche plane ich, die Körpermaße zu integrieren.

---

## 23.05.2025

### Arbeitspakete
- [x] **Arbeitspaket 1**:  
  Erweitere `DatabaseManager.cs` um `SaveBodyMeasurement(BodyMeasurement measurement)`  

- [x] **Arbeitspaket 2**:  
  Implementiere `GetBodyMeasurements(int userId)` zum Abrufen von Körpermaßen  

- [x] **Arbeitspaket 3**:  
  Erweitere die WinForms-Maske um Eingabefelder für Körpermaße (Gewicht, Muskelumfang)  

- [x] **Arbeitspaket 4**:  
  Teste das Speichern und Abrufen von Körpermaßen in der Konsolen-App  

### Reflexion
Am 23.05.2025 habe ich die Funktionalität für Körpermaße hinzugefügt, was eine logische Erweiterung war. Die Implementierung von `SaveBodyMeasurement` und `GetBodyMeasurements` lief reibungslos, aber das Anpassen der WinForms-Maske war zeitaufwändig. Der Test in der Konsolen-App zeigte, dass die Daten korrekt gespeichert werden, was mich ermutigt hat. Ich muss jedoch die UI-Designs verbessern, um sie benutzerfreundlicher zu machen.

---

## 30.05.2025

### Arbeitspakete
- [x] **Arbeitspaket 1**:  
  Erweitere `DatabaseManager.cs` um `SaveTrainingPlan(TrainingPlan plan)`  

- [x] **Arbeitspaket 2**:  
  Implementiere `GetTrainingPlans(int userId)` zum Abrufen von Trainingsplänen  

- [x] **Arbeitspaket 3**:  
  Füge der WinForms-Maske eine neue Ansicht für Trainingspläne hinzu (Name, Beschreibung)  

- [x] **Arbeitspaket 4**:  
  Teste das Speichern und Abrufen von Trainingsplänen in der Konsolen-App  

### Reflexion
Am 30.05.2025 habe ich die Trainingsplan-Funktionalität erfolgreich integriert. Die Methoden `SaveTrainingPlan` und `GetTrainingPlans` waren einfach umzusetzen, da ich bereits Erfahrung mit den vorherigen Modellen hatte. Die neue Ansicht in WinForms war eine Herausforderung, aber machbar. Der Test lief gut, obwohl ich ein Problem mit der Übungsliste hatte, das ich mit Debugging lösen konnte. Ich bin gespannt auf die Visualisierung nächste Woche.

---

## 06.06.2025

### Arbeitspakete
- [x] **Arbeitspaket 1**:  
  Implementiere eine Methode `GetWeightHistory(int userId)` in `DatabaseManager.cs` für den Gewichtsverlauf  

- [x] **Arbeitspaket 2**:  
  Integriere eine Chart-Komponente (z. B. `System.Windows.Forms.DataVisualization`) in die WinForms-Anwendung  

- [x] **Arbeitspaket 3**:  
  Zeige den Gewichtsverlauf als Linienchart an, basierend auf `GetWeightHistory`  

- [x] **Arbeitspaket 4**:  
  Teste die Visualisierung mit Testdaten in der WinForms-Anwendung  

### Reflexion
Am 06.06.2025 habe ich den Gewichtsverlauf implementiert, was ein wichtiger Meilenstein war. Die Methode `GetWeightHistory` war einfach, aber die Integration der Chart-Komponente war neu für mich und erforderte Zeit mit Tutorials. Der Linienchart funktioniert jetzt, aber die Anzeige könnte noch flüssiger gestaltet werden. Der Test mit Testdaten war erfolgreich, und ich bin stolz auf diesen Fortschritt, auch wenn ich mehr Zeit für Feinabstimmungen einplanen sollte.

---

## 13.06.2025

### Arbeitspakete
- [ ] **Arbeitspaket 1**:  
  Erweitere die WinForms-Maske um eine Funktion zum Bearbeiten von Workouts  

- [ ] **Arbeitspaket 2**:  
  Implementiere eine Methode `UpdateWorkout(Workout workout)` in `DatabaseManager.cs`  

- [ ] **Arbeitspaket 3**:  
  Füge eine Funktion zum Löschen von Workouts hinzu (Methode `DeleteWorkout(int id)`)  

- [ ] **Arbeitspaket 4**:  
  Teste Bearbeiten und Löschen in der WinForms-Anwendung  

### Reflexion
Am 13.06.2025, 00:12 Uhr CEST, beginne ich den Tag mit der Planung der Bearbeitungs- und Löschfunktionen. Basierend auf den bisherigen Erfolgen bin ich zuversichtlich, dass ich die UI-Erweiterungen und die neuen Methoden umsetzen kann. Die bisherige Arbeit hat gezeigt, dass ich mit Entity Framework Core und WinForms gut zurechtkomme, aber ich erwarte Herausforderungen bei der Fehlerbehandlung bei Updates und Deletes. Ich plane, den Tag zu nutzen, um einen stabilen Prototypen zu erstellen, und werde mich auf Tests konzentrieren, um sicherzustellen, dass die Datenbank synchron bleibt.

---
