using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SchoolFunctionApp.Models
{
    [Table("Person")]
    public partial class Person
    {
        public Person()
        {
            StudentGrades = new HashSet<StudentGrade>();
            Courses = new HashSet<Course>();
        }

        [Key]
        [Column("PersonID")]
        public int PersonId { get; set; }
        [Required]
        [StringLength(50)]
        public string LastName { get; set; }
        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? HireDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? EnrollmentDate { get; set; }
        [Required]
        [StringLength(50)]
        public string Discriminator { get; set; }

        [InverseProperty("Instructor")]
        public virtual OfficeAssignment OfficeAssignment { get; set; }
        [InverseProperty(nameof(StudentGrade.Student))]
        public virtual ICollection<StudentGrade> StudentGrades { get; set; }

        [ForeignKey("PersonId")]
        [InverseProperty(nameof(Course.People))]
        public virtual ICollection<Course> Courses { get; set; }
    }
}
