namespace API.Entities;

//This class is an Entity. Entities represent tables in a db.
public class AppUser    
{
    public int Id { get; set; } //property named Id is automatically used as a primary key in this table
    public string UserName { get; set; }
}
