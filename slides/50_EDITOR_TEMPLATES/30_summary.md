## EditorTemplates

1. maak een folder `EditorTemplates` in eender welke view (of in `Shared` voor elke view)
1. maak een nieuwe view: `naamModel.cshtml`
1. declareer het model type in de view
```cshtml
@model mvc_demo.web.Models.MyModel
```
1. Gebruiker volgende helper waar gewenst:
```cshtml
@Html.EditorFor(model => model.PropertyVanHetTypeMyModel)
```

--
## Migrations

1. voor het gemak -> ander project
1. Add-Migration -> nieuwe migratie toevoegen
1. snapshot van model
1. teams -> update snapshot met 
```powershell
add-migration KiesMaarEenNaam -IgnoreChanges
```