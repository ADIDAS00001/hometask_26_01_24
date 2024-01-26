namespace Domain.Models;

public class Employee
{
     public string Firstname { get; set; }
     public string Lastname { get; set; }
     public DateTime Birthdate { get; set; }
     public decimal Salary { get; set; }
     public Department Department { get; set; }
     public int Id;
}
