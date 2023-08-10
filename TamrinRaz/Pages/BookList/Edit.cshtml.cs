using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TamrinRaz.Model;

namespace TamrinRaz.Pages.BookList
{
    public class EditModel : PageModel
    {

        private ApplicationContext _context;

        public EditModel(ApplicationContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Book Book { get; set; }

        public void OnGet(int id)
        {
            Book = _context.Books.Find(id);
        }


        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                _context.Update(Book);
                _context.SaveChanges();
                return RedirectToPage("Index");
            }
            else
            {
                return Page();
            }
        }

    }
}
