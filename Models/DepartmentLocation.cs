namespace EmployeesCh12.Models
{
    public class DepartmentLocation
    {
        //Composite Primary Key and foreign key for department 
        public int DepartmentID { get; set; }

        //Composite Primary key and foreign key for location 
        public int LocationID { get; set; }

        //Navigation 
        public Department Department { get; set; } = null!;
        public Location Location { get; set; } = null!;
    }
}
