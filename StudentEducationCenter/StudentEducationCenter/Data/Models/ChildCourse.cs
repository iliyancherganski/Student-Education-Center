using System.ComponentModel.DataAnnotations.Schema;

namespace StudentEducationCenter.Data.Models
{
    public class ChildCourse
    {
        [ForeignKey(nameof(Child))]
        public int ChildId { get; set; }
        public Child Child { get; set; } = null!;

        [ForeignKey(nameof(Course))]
        public int CourseId { get; set; }
        public Course Course { get; set; } = null!;
    }
}
