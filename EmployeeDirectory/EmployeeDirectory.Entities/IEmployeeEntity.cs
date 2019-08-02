namespace EmployeeDirectory.Entities
{
    public interface IEmployeeEntity : IEntity
    {
        string Name { get; set; }
        string Title { get; set; }
        string Department { get; set; }
    }
}