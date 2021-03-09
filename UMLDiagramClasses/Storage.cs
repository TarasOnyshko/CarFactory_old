using System.Collections.Generic;

namespace CarFactory.UMLDiagramClasses
{
    public abstract class Storage
    {
        public int Size { get; set; }
        public List<Employee> Employees { get; set; }
    }
}
