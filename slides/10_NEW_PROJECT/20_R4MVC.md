# R4MVC

--

## R4MVC

### weg met "magic strings"!

```html
<ul class="nav navbar-nav">
  <li>@Html.ActionLink("Home", "Index", "Home")</li>
  <li>
    <a asp-action="Details" asp-controller="Dinners" asp-route-id="@Model.DinnerID">
      Dinner Details
    </a>
  </li>
</ul>
```

```html
<ul class="nav navbar-nav">
  <li>@Html.ActionLink("Home",MVC.Home.Index())</li>
  <li>
    <a mvc-action="MVC.Dinners.Details(Model.DinnerID)">Dinner Details</a>
  </li>
</ul>
```

--

# voordeel?
