# EVA.GG C# Client

## Prerequisites

- Project compatible with Netstandard 2.1.

## Usage

```csharp
// Declare your configuration
var productionConfiguration = EvaGGClientConfiguration.Production("8dziu8dza1nNJDzz823e")
var preproductionConfiguration = EvaGGClientConfiguration.Preproduction("8dziu8dza1nNJDzz823e")
var customConfiguration = EvaGGClientConfiguration.Custom("http://localhost:3001/graphql", "8dziu8dza1nNJDzz823e")

var client = new EvaGGClient(customConfiguration);
var response = await client.ListGameItems();
```
