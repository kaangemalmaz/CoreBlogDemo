using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System.Collections.Generic;

namespace BusinessLayer.Concrete
{
    public class CommentManager : ICommentService
    {
        private readonly ICommentDal _commentDal;

        public CommentManager(ICommentDal commentDal)
        {
            _commentDal = commentDal;
        }

        public void AddComment(Comment comment)
        {
            _commentDal.Add(comment);
        }

        public void DeleteComment(Comment comment)
        {
            _commentDal.Delete(comment);
        }

        public Comment GetByIdComment(int id)
        {
            return _commentDal.GetById(i=>i.BlogID == id);
        }

        public List<Comment> ListAllComment(int id)
        {
            return _commentDal.GetAll(i => i.BlogID == id);
        }

        public void UpdateComment(Comment comment)
        {
            _commentDal.Update(comment);
        }
    }
}
