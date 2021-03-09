using System.Collections.Generic;

namespace CarFactory.UMLDiagramClasses
{
    public abstract class DetailsStorage : Storage
    {
        public List<Detail> Details { get; set; }
        public abstract Detail GetDetail();
        public void Add(Detail detail)
        {
            Details.Add(detail);
        }
    }
}
