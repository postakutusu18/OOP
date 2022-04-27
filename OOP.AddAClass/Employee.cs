namespace OOP.AddAClass
{
    class Employee
    {
       
        private string _firstName; //Field:alan

        //başka bir sınıftan değerine ulaşmak için kapsülleme işlemi  yapılır.
        public string FirstName //Proporties 
        {
            set { _firstName = value; }
            get { return _firstName; }
        }

        //Expression bodied proporty accessors. ctrl + . ile ekledik.  (encapsulate field
        private string _lastName;


        
        public string LastName { get => _lastName; set => _lastName = value; }


        //Auto implement proporties.
        public int Age { get; set; }


        //Metod Tanımlama İşlemi
        //field
        private List<Employee> _employees;



        public List<Employee> Employees =>GetEmployees();
        public List<Employee> Employees2 => _employees;
        public void Add(Employee employee)
        {
            _employees.Add(employee);
        }

        //birden fazla değerin eklenmesi
        public void AddRange(params Employee[] employees)
        {
            _employees.AddRange(employees);
        }

        public List<Employee> GetEmployees()
        {
            return _employees;
        }

        public Employee()
        {
            _employees = new List<Employee>();
            //Console.WriteLine("yapılandırıcı method çalıştırıldı");
        }

        //Overloading
        public Employee(string firstName, string lastName, int age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            _employees=new List<Employee>();
        }
        //Override İşlemi -geçersiz kılma
        public override string? ToString()
        {
            return $"{FirstName,-20}{LastName,-15}{Age,5}";  //eksi işareti sola yaslamak
            //return base.ToString();
        }
    }
}
