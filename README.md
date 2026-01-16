## Řešení: Adapter Pattern

### Proč Adapter?
**Adapter pattern** je ideální volbou, protože:
- Umožňuje použít existující třídu s nekompatibilním rozhraním
- Nevyžaduje změnu ani klientského kódu, ani adaptované třídy
- Funguje jako "most" mezi dvěma nekompatibilními rozhraními

1. **ILogger** - stávající rozhraní používané v aplikaci
2. **AnalyticsLibrary** - nová knihovna (nedostupný zdrojový kód)
3. **AnalyticsAdapter** - náš adaptér, který implementuje `ILogger` a interně volá `AnalyticsLibrary`