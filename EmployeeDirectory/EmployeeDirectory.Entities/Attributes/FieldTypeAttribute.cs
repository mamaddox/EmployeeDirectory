using System;
namespace EmployeeDirectory.Entities.Attributes
{
    public class FieldTypeAttribute : Attribute
    {
        public bool IsHidden { get; set; }
        public bool IsPicture { get; set; }
    }
}
