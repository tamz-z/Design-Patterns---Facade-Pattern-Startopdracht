# Opdracht #3 – Principle of Least Knowledge

## Code 1
```csharp
public float getTemp()
{
    return station.getThermometer().getTemperature();
}
```
**Does this code violate the Principle of Least Knowledge? Yes**

`getTemp()` roept `getTemperature()` aan op een `Thermometer`-object dat terugkomt uit een andere methodeaanroep (`station.getThermometer()`).
`Thermometer` is geen "immediate friend" van `House`: het is niet het object zelf, geen parameter, niet in de methode aangemaakt en geen component van `House`.
Hierdoor is `House` gekoppeld aan een extra class (`Thermometer`).

## Code 2
```csharp
public float getTemp()
{
    Thermometer thermometer = station.getThermometer();
    return GetTempHelper(thermometer);
}
public float GetTempHelper(Thermometer thermometer)
{
    return thermometer.getTemperature();
}
```
**Does this code violate the Principle of Least Knowledge? No**

Volgens de regels mag dit:
- `getTemp()` roept alleen een methode aan op een component (`station`) en op het object zelf (`GetTempHelper`).
- `GetTempHelper()` roept een methode aan op een object dat als parameter is meegegeven. Dat is toegestaan.

Let wel: in de praktijk is `House` nog steeds afhankelijk van `Thermometer`, dus de koppeling is niet echt kleiner geworden. Echt beter is `station.getTemperature()`.
