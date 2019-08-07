
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;


namespace EntityFrameWorkOne.Models {
    public class Student {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(30)]
        public string Firstname { get; set; }
        [Required]
        [StringLength(30)]
        public string Lastname { get; set; }
        [Range(600, 2400, ErrorMessage ="SAT scores must be 600<=x<=2400")]
        public int SAT { get; set; }
        [Range(0, 5)]
        public double GPA { get; set; }
        public bool IsFulltime { get; set; } = true;

        public Student() {

        }


    }
}
