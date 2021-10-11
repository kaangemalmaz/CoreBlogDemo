

using System.ComponentModel.DataAnnotations;

namespace CoreDemo.Models
{
    public class RegisterViewModel
    {
        public int WriterID { get; set; }
        public string WriterName { get; set; }
        public string WriterAbout { get; set; }
        public string WriterImage { get; set; }
        public string WriterMail { get; set; }
        public string WriterPassword { get; set; }

        [Compare("WriterPassword", ErrorMessage ="Parolalar uyuşmamaktadır.Lütfen kontrol ediniz")]
        public string WriterPassword2 { get; set; }
        public bool WriterStatus { get; set; }
    }
}
