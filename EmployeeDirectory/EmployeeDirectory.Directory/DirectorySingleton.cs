using EmployeeDirectory.Data;

namespace EmployeeDirectory.Directory
{
    public sealed class DirectorySingleton : Directory
    {
        static DirectorySingleton()
        {
        }

        private DirectorySingleton()
        {
        }

        public static Directory Instance { get; } = new Directory(DataLoader.GetEmployees());
    }
}
