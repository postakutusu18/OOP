using OOP.AddAClass;

Console.WriteLine("Hello, World!");

Employee employee = new Employee();
employee.FirstName = "Selçuk";
employee.LastName = "KARAAĞAÇ";
employee.Age = 37;
Console.WriteLine(String.Concat(employee.FirstName," ",employee.LastName," ",employee.Age));

Console.WriteLine("-------");
Employee employee2 = new Employee("Ali", "YILMAZ",32);
Console.WriteLine(String.Concat(employee2.FirstName, " ", employee2.LastName, " ", employee2.Age));

Employee employee3 = new Employee("Ahmet","KARA",21);
Console.WriteLine(employee3);

Employee employee4 = new Employee { FirstName = "Veli", LastName = "AK", Age = 18 };
Console.WriteLine("--- Liste ----");
var list =new List<Employee>();
list.Add(employee);
list.Add(employee2);
list.Add(employee3);
list.Add(employee4);
foreach (var item in list)
    Console.WriteLine(item);

var list2 = new List<Employee>() { employee,employee2,employee3,employee4 };
foreach (var item in list2)
    Console.WriteLine(item);


var employe5=new Employee();
employe5.Add(new Employee { FirstName = "Harun", LastName = "ÖZ", Age = 21 });


//çoklu kayıt ekle.
employe5.AddRange(new Employee("A","B",1), new Employee("C","D",2));
Console.WriteLine("--- x ----");
Console.WriteLine("Çalışan Listesi");
var listEmployee=employe5.GetEmployees();
foreach (var item in listEmployee)
    Console.WriteLine(item);

Console.WriteLine("--- x ----");
var listEmployee2 = employe5.Employees;
foreach (var item in listEmployee2)
    Console.WriteLine(item);

Console.WriteLine("--- x ----");
var listEmployee3 = employe5.Employees2;
foreach (var item in listEmployee3)
    Console.WriteLine(item);

Console.ReadLine();

