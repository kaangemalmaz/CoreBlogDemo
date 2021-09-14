﻿using EntityLayer.Abstract;
using System;
using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
    public class Comment : ITable
    {
        [Key]
        public int CommentID { get; set; }
        public string CommentUserName { get; set; }
        public string CommentTitle { get; set; }
        public string CommentContent { get; set; }
        public DateTime CommentDate { get; set; }
        public bool CommentStatus { get; set; }

        public int BlogID { get; set; }
        public Blog Blog { get; set; }

    }
}
