# Facade Pattern – Antwoorden

## 1. Welke problemen beginnen te ontstaan in je code?
Toen NormalMode/DeveloperMode en het stoppen van de game direct in `Program.cs` werden gezet:
- **Dubbele code:** het starten (en stoppen) stond er voor NormalMode en DeveloperMode bijna twee keer hetzelfde in.
- **Program.cs werd lang en onoverzichtelijk:** alle aanroepen naar alle subsystemen stonden in `Main`.
- **Sterke koppeling:** `Program` moet álle subsystemen kennen en weten in welke volgorde ze aangeroepen moeten worden.
- **Te veel verantwoordelijkheid** in één plek (`Main`).
- **Slecht onderhoudbaar:** komt er een subsysteem bij of verandert de volgorde, dan moet je dat op meerdere plekken aanpassen.

## 2. Hoe zou je die problemen kunnen oplossen?
Door één class verantwoordelijk te maken voor het starten en stoppen van de game: een **Facade** (`GameFacade`).
Deze class kent de subsystemen en regelt de juiste volgorde. De modi worden als parameter meegegeven, zodat er geen dubbele code nodig is.
`Program.cs` roept alleen nog `StartGame(...)` en `StopGame()` aan en kent de subsystemen niet meer (Principle of Least Knowledge).

## 3. Verschillen en overeenkomsten tussen Facade en Adapter

**Overeenkomsten**
- Beide zijn *structural* design patterns.
- Beide "wikkelen" andere classes in (wrapper).
- Beide ontkoppelen de client van de onderliggende classes.
- In beide gevallen hoeven de bestaande classes niet aangepast te worden.

**Verschillen**
| Facade | Adapter |
|---|---|
| Doel: een complex subsysteem **vereenvoudigen** | Doel: een interface **omzetten** naar een interface die de client verwacht |
| Wikkelt meestal **meerdere** classes in | Wikkelt meestal **één** class in |
| Maakt een **nieuwe, simpelere** interface | Past zich aan een **bestaande** (target) interface aan |
