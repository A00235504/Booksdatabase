using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using BooksAppWebFinalSubmission.Models;
using System.Threading.Tasks;
using BooksAppWebFinalSubmission.Data;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using SearchBooks;

namespace BooksAppApi.Controllers

{
    [ApiController]
    [Route("[controller]")]
    public class SearchBooksController : Controller
    {

        private readonly ApplicationDbContext _context;


        public SearchBooksController(ApplicationDbContext context)
        {
            _context = context;

        }

        public List<string> searchResult;

        public IList<Books> Books { get; set; }


        public List<string> booksList = new List<string>();

       

        [HttpGet]
        public async Task<List<String>> searchAsync(string searchValue, string breedType)
        {

            Books = await _context.Books.ToListAsync();


            booksList = Books.Select(breed => breed.booktitle).ToList();  // The list of all main breed names
            

            searchResult = SearchBooksName.searchStrings(booksList, searchValue);
           

            return searchResult;

        }
    }
}