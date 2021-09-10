using EntityLayer.Abstract;
using System;
using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
    public class Blog : ITable
    {
        [Key]
        public int BlogID { get; set; }
        public string BlogTitle { get; set; }
        public string BlogContent { get; set; }
        public string BlogThumbnailImage { get; set; }
        public string BlogImage { get; set; }
        public DateTime BlogCreateDate { get; set; }
        public bool BlogStatus { get; set; }
    }
}
