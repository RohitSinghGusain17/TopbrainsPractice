public class Employee
{
    public int Id{get; set;}
    public string Name{get; set;}
    public string Dept{get; set;}
    public double Salary{get; set;}

    public Employee(int id, string name, string dept, double salary){
        Id=id;
        Name=name;
        Dept=dept;
        Salary=salary;
    }
}

public class Program
{
    public static void Main()
    {
        List<Employee> employees = new List<Employee> {
            new Employee(1,"Arun","IT",60000),
            new Employee(2,"Meera","HR",45000),
            new Employee(3,"John","IT",75000)
            };
        
        var result = employees.Where(x=>x.Salary>50000).GroupBy(x=>x.Dept).ToDictionary(g => g.Key, g => g.ToList());

        foreach(var dept in result)
        {
            Console.WriteLine(dept.Key);
            foreach(var emp in dept.Value)
            {
                Console.WriteLine(emp.Name);
            }
        }

    }
}