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

---

## life saving tip #3

Voorzie het `id` en `name` attribuut van `input`-velden altijd van een waarde met `@Html.NameFor()` en `@Html.IdFor()`
