using System;
namespace EmployeeDirectory.Entities.Attributes
{
    internal class FieldTypeAttribute : Attribute
    {
        public bool IsHidden { get; set; }
        public bool IsPicture { get; set; }
    }
}