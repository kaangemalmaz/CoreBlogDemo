using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System.Collections.Generic;

namespace BusinessLayer.Concrete
{
    public class WriterManager : IWriterService
    {
        private readonly IWriterDal _writerDal;

        public WriterManager(IWriterDal writerDal)
        {
            _writerDal = writerDal;
        }

        public void AddWriter(Writer writer)
        {
            _writerDal.Add(writer);
        }

        public List<Writer> ListAllWriter()
        {
            return _writerDal.GetAll();
        }
    }
}
