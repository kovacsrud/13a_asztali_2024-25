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
### Migrációs lépés létrehozása
A Package Manager Console-ban adjuk meg a következő parancsokatt:
 - Add-Migration init
 - Update-Database

## !! Eszünkbe jut, hogy kellene még egy Description nevű mező is!
Kibővítjük a Todo.cs fájlban lévő modellünket.
```c#
public class Todo
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime Created {  get; set; }= DateTime.Now;
    public bool Completed { get; set; }
}
```
Ezt követően adjuk ki a Package Manager Console-ban a következő parancsokat:
 - Add-Migration add_description
 - Update-Database

Ezzel a Description mező bekerült az adatbázisba.

Nyissuk meg a **MainWindow.xaml.cs** fájlt!

Deklaráljuk a contextet és egy listát, amibe majd az adatokat gyűjtjük.
```C#
TodoContext todoContext;
public ObservableCollection<Todo> Todos { get; set; }
```
A konstruktorban példányosítjuk a context osztályunkat, betöltjük az adatokat, majd megadjuk az ablak DataContext-jét:
```C#
 public MainWindow()
 {
     InitializeComponent();
     todoContext = new TodoContext();
     todoContext.Add(new Todo {
         Title = "Teszt",
         Description="Teszt todo leírása",
         Completed = false
         
     });
     todoContext.SaveChanges();
     todoContext.Todos.Load();
     Todos = todoContext.Todos.Local.ToObservableCollection();

     DataContext = Todos;

 }
```
