## DisplayTemplates

1. maak een folder `DisplayTemplates` in eender welke view (of in `Shared` voor elke view)
1. maak een nieuwe view: `naamModel.cshtml`
1. declareer het model type in de view
```cshtml
@model mvc_demo.web.Models.MyModel
```
1. Gebruiker volgende helper waar gewenst:
```cshtml
@Html.DisplayFor(model => model.PropertyVanHetTypeMyModel)
```