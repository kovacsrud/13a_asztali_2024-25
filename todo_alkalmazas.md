# Todo alkalmazás készítése
Hozzunk létre egy WPF alkalmazást
### Csomagok telepítése
 - Microsoft.EntityFrameworkCore
 - Microsoft.EntityFrameworkCore.Tools
 - Microsoft.EntityFrameworkCore.Sqlite

.NET 7 esetén a 7-es verziók közül a legfrissebbet kell használni.

### Modell létrehozása
Hozzunk létre a projektben egy **Models** nevű mappát ebbe kerülnek az adatmodellek.

A **Models** mappában hozzunk létre egy új osztályt **Todo** néven
Az osztály kódja:
```C#
 public class Todo
 {
     public int Id { get; set; }
     public string Title { get; set; }
     public DateTime Created {  get; set; }= DateTime.Now;
     public bool Completed { get; set; }
 }
```
A **Models** mappában hozzunk létre egy másik osztályt **TodoContext** néven.
Az osztály kódja:
```c#
public class TodoContext:DbContext
{
    public virtual DbSet<Todo> Todos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder.UseSqlite(@"Data Source=d:\tododb.db");
    }
}
```

