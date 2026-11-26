<h1 align="center">Bookstore</h1>
<p align="center">
  <b>C# console exercise on classes, inheritance and events</b><br/>
  Models books, magazines and orders, and uses a C# event to notify subscribers when an order is placed.
</p>

<p align="center">
  <img src="https://img.shields.io/badge/C%23-console-512BD4?style=flat-square&logo=dotnet&logoColor=white" />
  <img src="https://img.shields.io/badge/.NET-8-512BD4?style=flat-square&logo=dotnet&logoColor=white" />
</p>

---

## Concepts covered

| Concept | Where |
|---|---|
| Classes and properties | `Boek` (book), `Tijdschrift` (magazine) |
| Inheritance | `Tijdschrift` extends `Boek` |
| Events and delegates | `Bestelling.BestellingGeplaatst` (`Action<string>`) fires when an order is placed |
| Program flow | `Program.cs` creates items, places orders and subscribes to the event |

## Run

```bash
git clone https://github.com/oiseaubleuc/opdracht_klassen_events.git
cd opdracht_klassen_events
dotnet run
```

---

<p align="center">Built by <a href="https://github.com/oiseaubleuc">Hoho</a> · Belgium</p>
