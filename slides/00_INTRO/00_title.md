# MVC, Git it?

--

### MVC getting started

* file -> new project
* MVC
* Geen unit tests (zelf later toevoegen)
--

## UPDATE ALL NUGET PACKAGES!

let op: template gebruikt standaard bootstrap 3! Na de upgrade -> bootstrap 4
[https://getbootstrap.com/docs/4.0/migration/](https://getbootstrap.com/docs/4.0/migration/)
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

## Andere projecten toevoegen
* <website>.core
* dbcontext maken
* <website>.migrations
* reference toevoegen naar .core
* enable migrations

```powershell
enable-migrations -ContextProjectName MyProject.MVC 
    -StartUpProjectName MyProject.MVC 
    -ContextTypeName MyProject.MVC.MyContextFolder.MyContextName
    -ProjectName MyProject
```


--