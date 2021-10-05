using CoreLayer.Entities;
using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
    public class NewsLetter : ITable
    {
        [Key]
        public int MailId { get; set; }
        public string Mail { get; set; }
        public bool MailStatus { get; set; }
    }
}
