using EntityLayer.Abstract;
using System;

namespace EntityLayer.Concrete
{
    public class Comment : ITable
    {
        public int CommentID { get; set; }
        public string CommentUserName { get; set; }
        public string CommentTitle { get; set; }
        public string CommentContent { get; set; }
        public DateTime CommentDate { get; set; }
        public bool CommentStatus { get; set; }

    }
}
