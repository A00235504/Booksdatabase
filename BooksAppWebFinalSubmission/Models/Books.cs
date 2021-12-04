using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BooksAppWebFinalSubmission.Models
{
    public class Books
    {

        [Key]
        [Column("id")]
        public long Id { get; set; }

        public string booktitle { get; set; }

        public string bookdescription { get; set; }


       
    }
}
