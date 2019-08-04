namespace EmployeeDirectory.Entities
{
    public interface ISearchParameterEntity
    {
        string Field { get; set; }
        string Value { get; set; }
    }
}
