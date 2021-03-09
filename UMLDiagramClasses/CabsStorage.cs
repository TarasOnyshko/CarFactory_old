namespace CarFactory.UMLDiagramClasses
{
    public class CabsStorage : DetailsStorage
    {
        public override Detail GetDetail()
        {
            return new Cab();
        }
    }
}
