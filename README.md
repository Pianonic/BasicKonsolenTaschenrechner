# BasicKonsolenTaschenrechner

Ein einfacher und flexibler Konsolen-Taschenrechner, der die grundlegenden mathematischen Operationen wie Addition, Subtraktion, Multiplikation und Division unterstützt. Das Programm ist modular aufgebaut und folgt den SOLID-Prinzipien sowie anderen Software-Design-Standards.

## Features

- **Addition, Subtraktion, Multiplikation, Division**
- **Fehlerbehandlung bei Division durch Null**
- **Einfache, benutzerfreundliche Konsoleingabe und -ausgabe**
- **Erweiterbar mit neuen Operationen, ohne den bestehenden Code zu ändern**

## Architektur

Das Projekt folgt den **SOLID-Prinzipien** und anderen wichtigen Design-Richtlinien:

- **Single Responsibility Principle (SRP):** Jede Klasse hat nur eine Verantwortung.
- **Open-Closed Principle (OCP):** Das System ist erweiterbar, ohne bestehenden Code zu verändern.
- **Liskov Substitution Principle (LSP):** Alle Operationen können problemlos ohne unerwartete Fehler verwendet werden.
- **Interface Segregation Principle (ISP):** Das Interface für die Operationen ist minimal und spezifisch.
- **Dependency Inversion Principle (DIP):** Abstraktionen werden genutzt, um die Abhängigkeiten zu reduzieren.
- **DRY (Don't Repeat Yourself):** Kein Code-Duplikat.
- **KISS (Keep It Simple and Stupid):** Klare und einfache Struktur ohne unnötige Komplexität.
- **Fehlerbehandlung:** Angemessenes Exception-Handling für Benutzereingaben und mathematische Fehler (z. B. Division durch Null).

## Installation

1. Clone das Repository:
    ```bash
    git clone https://github.com/PianoNic/BasicKonsolenTaschenrechner.git
    ```

2. Navigiere in das Projektverzeichnis:
    ```bash
    cd BasicKonsolenTaschenrechner
    ```

3. Kompiliere das Projekt:
    ```bash
    dotnet build
    ```

4. Starte die Anwendung:
    ```bash
    dotnet run
    ```

## Verwendung

Startet das Programm und folgt den Anweisungen, um eine mathematische Berechnung durchzuführen. Der Taschenrechner akzeptiert Eingaben wie:
- `5 + 3`
- `12 - 4`
- `6 * 7`
- `20 / 4`

## Code Review

Ein detailliertes **Code Review** des Projekts ist verfügbar. [Klicke hier, um das Code Review zu sehen](codereview.md).