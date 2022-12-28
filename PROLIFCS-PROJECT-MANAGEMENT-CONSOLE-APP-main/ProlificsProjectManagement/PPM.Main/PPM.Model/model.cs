using System;

namespace PPM.Main.PPM.Model
{
    
//project class
public class Project 
{
    public List<Employee> employeeListfromEmployeeManagement = new List<Employee>();
    public string projectName { get; set; }
    public string startDate { get; set; }
    public string endDate { get; set; }
    public int? id { get; set; }
 
    public int employeeId;

    public Project(string projectname, string startdate, string enddate, int Id)
    {
        this.projectName = projectname;
        this.startDate = startdate;
        this.endDate = enddate;
        this.id = Id;
    }

    
    public Project(int empidd)
    {
        this.employeeId =empidd;
    }
public Project(){
    
}

}

//Employee class
public class Employee : IComparable<Employee>
{
    public int employeeID { get; set; }

    public string employeefirstName{get;set;}
    public string lastName { get; set; }
    public string email { get; set; }
    public string mobile { get; set; }
    public string address { get; set; }
    public int roleId { get; set; }
    public string roleName { get; set; }


    public Employee(int empid, string FirstName, string LastName, string Email, string Mobile, string Address, int ROleID, string ROlename)
    {
        this.employeeID = empid;
        this.employeefirstName = FirstName;
        this.lastName = LastName;
        this.email = Email;
        this.mobile = Mobile;
        this.address = Address;
        this.roleId = ROleID;
        this.roleName = ROlename;
    }

    public Employee()
    {

    }

     public int CompareTo(Employee other){
        return this.roleId.CompareTo(other.roleId);
    }

}

//Role class
public class Role : IComparable<Role>
{
    public string roleName { get; set; }
    public int roleId { get; set; }

    public Role(int roleid, string roleName)
    {
        this.roleName = roleName;
        roleId = roleid;
    }
    
    public Role()
    {

    }

    public int CompareTo(Role other){
        return this.roleId.CompareTo(other.roleId);
    }

}


}
