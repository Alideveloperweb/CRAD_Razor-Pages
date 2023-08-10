using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TamrinRaz.Model;

namespace TamrinRaz.Pages.BookList
{
    public class DeleteModel : PageModel
    {

        private ApplicationContext _context;

        public DeleteModel(ApplicationContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Book Book { get; set; }

        public void OnGet(int id)
        {
            Book = _context.Books.Find(id);
        }

        public async Task<IActionResult> OnPost(int id)
        {
            var book = await _context.Books.FindAsync(id);
            if (book == null)
                return NotFound();

            _context.Books.Remove(book);
            await _context.SaveChangesAsync();

            return RedirectToPage("Index");

        }
    }
}
