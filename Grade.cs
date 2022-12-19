using System.ComponentModel.DataAnnotations;

namespace OneToManyRelCore.Models
{
    public class Grade
    {
        [Key]
        public int GradeId { get; set; }
        public string GradeName { get; set; }
        public string Section { get; set; }

        //public ICollection<Student> Students { get; set; }
    }
}
