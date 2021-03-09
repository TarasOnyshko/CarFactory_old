namespace CarFactory.UMLDiagramClasses
{
    public abstract class Employee : Person
    {
        public decimal Salary { get; set; }
        public abstract void Work();
    }
}
