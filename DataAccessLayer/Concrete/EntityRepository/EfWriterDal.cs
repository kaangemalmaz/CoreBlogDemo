using DataAccessLayer.Abstract;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;

namespace DataAccessLayer.Concrete.EntityRepository
{
    public class EfWriterDal : GenericRepository<Writer>, IWriterDal
    {
    }
}
