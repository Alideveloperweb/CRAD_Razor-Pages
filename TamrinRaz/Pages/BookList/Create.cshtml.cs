using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TamrinRaz.Model;

namespace TamrinRaz.Pages.BookList
{
    public class CreateModel : PageModel
    {

        private ApplicationContext _context;

        public CreateModel(ApplicationContext context)
        {
            _context = context;
        }


        [BindProperty]
        public Book Book { get; set; }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                _context.Add(Book);
                _context.SaveChanges();
                return RedirectToPage("Index");
            }
            return Page();
        }

    }
}
