using EntityLayer.Concrete;
using System.Collections.Generic;

namespace BusinessLayer.Abstract
{
    public interface IWriterService
    {
        void AddWriter(Writer writer);
        List<Writer> ListAllWriter();
    }
}
