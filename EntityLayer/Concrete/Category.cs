using EntityLayer.Abstract;

namespace EntityLayer.Concrete
{
    public class Category : ITable
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }
        public bool CategoryStatus { get; set; }

    }
}
