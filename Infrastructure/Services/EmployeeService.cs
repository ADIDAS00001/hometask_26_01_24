using Domain.Models;

namespace Infrastructure.Services;

public class EmployeeService
{
     public  List<Employee> employees=new List<Employee>;


     public List<Employee> GetEmployee()
     {
        return employees;
     }
     public void AddEmployee(Employee emp)
     {
        employees.Add(emp);
     }
     public int CountEmployee()
     {
        return employees.Count;
     }
     public void DalateEmployee(int id)
     {
        foreach (var item in employees)
        {
            if(item.Id==id)
            {
                employees.Remove(item);
            }
        }
     }
     public void UpdateEmployee(int id)
     {
        foreach (var item in employees)
        {
            if(item.Id==id)
            {
                item.Firstname="Shoh";
            }
        }
     }
}
