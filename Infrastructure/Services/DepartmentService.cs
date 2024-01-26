namespace Infrastructure.Services;

public class DepartmentService
{
         public  List<Departments> departments=new List<Departments>;


     public List<Departments> GetDepartments()
     {
        return departments;
     }
     public void AddEmployee(Departments dep)
     {
        departments.Add(dep);
     }
     public int CountDepartments()
     {
        return departments.Count;
     }
     public void DalateDepartments(int id)
     {
        foreach (var item in departments)
        {
            if(item.Id==id)
            {
                departments.Remove(item);
            }
        }
     }
     public void UpdateDepartments(int id)
     {
        foreach (var item in departments)
        {
            if(item.Id==id)
            {
                item.Firstname="Shoh";
            }
        }
     }
}
