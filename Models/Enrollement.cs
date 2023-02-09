using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dziekanat.Models
{
    /* Model Enrollment wiążę Studenta z przedmiotami (Model Course) 
     * na które się zapisał.
     */
    public class Enrollement
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime enrolledAt { get; set; }

        /* do uzupełnienia */
    }
}
