using System;
using PPM.Main.PPM.Model;
namespace PPM.Main.PPM.Domain
{
   //Class which consists of methods for adding and viewing projects
public class ProjectManagement
{
        private static readonly List<Project> projects1 = new List<Project>();
        public List<Project> projects = projects1;
        readonly EmployeeManagement obj1 = new EmployeeManagement();

    //Method for adding projects
    public void AddingProjects(Project project)
    {
        projects.Add(project);
    }
    public void DisplayProject(Project project)
    {
        Console.WriteLine(" Name of the project - " + project.projectName + "\n Project Id - " + project.id + "\n Start date of project - " + project.startDate + "\n End date of project - " + project.endDate);
        Console.WriteLine("");
    }

    public void DisplayAllProjects()
    {
        if(projects.Count == 0){
            Console.WriteLine("The List is Empty !!!");
        }
        else{
        foreach (var e in projects)
        {
            DisplayProject(e);
        }}
    }

    public void Display()
    {

          
        
            for (int j = 0; j < projects.Count; j++)
            {
                projects[j].employeeListfromEmployeeManagement.Sort();
                if(projects[j].employeeListfromEmployeeManagement.Count == 0){
                    Console.WriteLine("No employee in the project");
                }
                else{
                    
                    Console.WriteLine("=====================================================================================");
                    Console.WriteLine("\nProject Name - "+projects[j].projectName+"\n");
                    Console.WriteLine("Below are the details of employees in this project");
                for (int i = 0; i < projects[j].employeeListfromEmployeeManagement.Count; i++)
                {
                    Console.WriteLine("-------------------------------------------------------------------------------------");
                    Console.WriteLine(projects[j].employeeListfromEmployeeManagement[i].employeefirstName+" ["+projects[j].employeeListfromEmployeeManagement[i].roleName+"]");
                }
            }}
    }

    public void EmployeeToProject(int pid,Employee ename){
        if(!obj1.IfExists(pid)){
        for(int i=0; i<projects.Count;i++){
            if(projects[i].id==pid){
                projects[i].employeeListfromEmployeeManagement.Add(ename);
            }
        }}
        else
        {
           Console.WriteLine("The employee with this id already exists in this project");
           Console.WriteLine("Enter any key to get to main menu");
           Console.ReadLine();
        }
    }

     public void EmployeeFromProject(int pid,Employee ename){
        for(int i=0; i<projects.Count;i++){
            if(projects[i].id==pid){
                projects[i].employeeListfromEmployeeManagement.Remove(ename);
            }
        }
    }


    public Boolean IfExist(int pid){
        for(int i=0; i<projects.Count;i++){
            if(pid== projects[i].id){
                return true;
            }
        }
        return false;
    }

    //Method to View all projects
    public void ShowProject(int eid)
    {
        foreach (Project e in projects)
        {

            if (e.id == eid)
            {
                Console.WriteLine(" Name of the project - " + e.projectName + "\n Project Id - " + e.id + "\n Start date of project - " + e.startDate + "\n End date of project - " + e.endDate);
            }
            else
            {
                Console.WriteLine("Id not found");
            }
        }
    }

    public void SearchProject(string search)
    {
        
        var match = projects.Where(c => c.projectName.Contains(search));
        foreach (var e in match)
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine(" Name of the project - " + e.projectName + "\n Project Id - " + e.id + "\n Start date of project - " + e.startDate + "\n End date of project - " + e.endDate);
        }

    }

}
//Class which consists of methods for adding and viewing Employees
public class EmployeeManagement
{
    public List<Employee> employeeList = new List<Employee>();
     
    //Method for adding new employee
    public void AddEmployee(Employee emp)
    {
        employeeList.Add(emp);
    }


    public void DisplayEmployee(Employee emp)
    {
        
        
        Console.WriteLine(" Employee Id - " + emp.employeeID + "\n Employee first name - " + emp.employeefirstName + "\n Employee last name - " + emp.lastName + "\n Employee email id - " + emp.email + "\n Employee mobile number - " + emp.mobile + "\n Employee address - " + emp.address + "\n Role Id - " + emp.roleId + "\n Role Name - " + emp.roleName);
        Console.WriteLine("");
        Console.WriteLine("");
        
    }


    public Employee EmployeeDetails(int eid){
        Employee emp = new Employee();
        for(int i=0;i<employeeList.Count;i++){
            if(eid==employeeList[i].employeeID){
               emp=employeeList[i];
                return emp;
            }
        }
        return emp;
    }

    

    //Method for viewing all employees
    public void ShowEmployees()
    {
        if(employeeList.Count == 0){
            Console.WriteLine("No employees available");
        }
        else{
        foreach (var e in employeeList)
        {
            DisplayEmployee(e);
        }}
    }

    public void ShowEmployee(int eid)
    {
        foreach (Employee e in employeeList)
        {

            if (e.employeeID == eid)
            {
                Console.WriteLine(" Name of the Employee - " + e.employeefirstName + " " + e.lastName + "\n Employee Id - " + e.employeeID);
            }
            else
            {
                Console.WriteLine("Id not found");
            }
        }
    }

    public Boolean IfExists(int eid){
        for(int i=0; i<employeeList.Count;i++){
            if(eid== employeeList[i].employeeID){
                return true;
            }
        }
        return false;
    }
}

//Class which consists of methods for adding and viewing roles
public class RoleManagement
{


    public List<Role> roleList = new List<Role>();



    //Method for adding roles
    public void RoleAdd(Role role)
    {
        roleList.Add(role);
    }

    //Method for viewing all roles
    public void DisplayRole()
    {
        roleList.Sort();
        foreach (Role e in roleList)
        {
            Console.WriteLine(" Name of the Role - " + e.roleName + "\n Role Id - " + e.roleId);
            Console.WriteLine();
        }
    }
}
}

