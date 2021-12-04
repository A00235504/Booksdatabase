using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace BooksAppWebFinalProject.Models
{
    public class Books
    {
        [Key]
        [HiddenInput]
        [Required]
        public int DookID { get; set; }

        public string BookName { get; set; }

        public string BookDescriptioin { get; set; }
    }
}
