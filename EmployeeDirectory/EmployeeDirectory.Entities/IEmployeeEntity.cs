﻿namespace EmployeeDirectory.Entities.Attributes
{
    public interface IEmployeeEntity : IEntity
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        string Title { get; set; }
        string Department { get; set; }
    }
}