using System.ComponentModel.DataAnnotations;

namespace OneToManyRelCore.Models
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }
        public string Name { get; set; }

        public int CurrentGradeId { get; set; }

        // one to many relation
        public virtual Grade Grade { get; set; }
        public int GradeId {get; set;}

        //ONE TO ONE RELATION
        public StudentAddress Address { get; set; }
    }
}
