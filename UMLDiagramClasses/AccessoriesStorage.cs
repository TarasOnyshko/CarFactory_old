namespace CarFactory.UMLDiagramClasses
{
    public class AccessoriesStorage : DetailsStorage
    {
        public override Detail GetDetail()
        {
            return new Accessory();
        }
    }
}
