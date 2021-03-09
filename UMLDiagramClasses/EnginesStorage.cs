namespace CarFactory.UMLDiagramClasses
{
    public class EnginesStorage : DetailsStorage
    {
        public override Detail GetDetail()
        {
            return new Engine();
        }
    }
}
