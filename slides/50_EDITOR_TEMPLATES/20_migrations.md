
## life saving tip #4

migrations in een apart project stoppen

```powershell
enable-migrations -ContextProjectName MyProject.MVC 
    -StartUpProjectName MyProject.MVC 
    -ContextTypeName MyProject.MVC.MyContextFolder.MyContextName
    -ProjectName MyProject
```
