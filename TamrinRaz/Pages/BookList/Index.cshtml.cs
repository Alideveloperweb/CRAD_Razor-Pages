using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TamrinRaz.Model;
using static System.Reflection.Metadata.BlobBuilder;

namespace TamrinRaz.Pages.BookList
{
    public class IndexModel : PageModel
    {

        private ApplicationContext _context;

        public IndexModel(ApplicationContext context)
        {
            _context = context;
        }

        public IEnumerable<Book> Books { get; set; }


        public void OnGet()
        {
            Books = _context.Books.ToList();
        }
    }
}
