using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApplication15.Models
{
    [Table("tblStudent")]
    public class Student
    {
       [Key]
        public int studentID { get; set; }
        public string studentName { get; set; }
        public byte[] photo { get; set; }
        public decimal Height { get; set; }
        public float weight { get; set; }

        public Grade Grade { get; set; }
    }
}