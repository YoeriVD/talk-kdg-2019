# T4MVC
--
## T4MVC 
### weg met "magic strings"!


```html
<ul class="nav navbar-nav">
    <li>@Html.ActionLink("Home", "Index", "Home")</li>
    <li>@Html.ActionLink("About", "About", "Home")</li>
    <li>@Html.ActionLink("Contact", "Contact", "Home")</li>
</ul>
```
==> 

```html
<ul class="nav navbar-nav">
    <li>@Html.ActionLink("Home",MVC.Home.Index())</li>
    <li>@Html.ActionLink("About", MVC.Home.About())</li>
    <li>@Html.ActionLink("Contact", MVC.Home.Contact())</li>
</ul>
```

--
 # voordeel?