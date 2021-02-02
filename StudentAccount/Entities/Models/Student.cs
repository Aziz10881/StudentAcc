using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities.Models
{
    [Table("student")]
    public class Student
    {
        [Column("StudentId")]
        public Guid Id { get; set; }

        [Required(ErrorMessage ="Name is required")]
        [StringLength(60, ErrorMessage ="Cant be longer than 60 characters")]
        public string Name { get; set; }

        [Required(ErrorMessage ="Date of birth is required")]
        public DateTime DateOfBirth { get; set; }

        [Required(ErrorMessage ="Faculty is required")]
        [StringLength(100, ErrorMessage ="Cant be longer than 100 characters")]
        public string Faculty { get; set; }

        public ICollection<Account> Accounts { get; set; }
    }
}
