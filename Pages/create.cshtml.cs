using firstCRUD.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace firstCRUD.Pages;

public class createModel : PageModel
{
    private readonly BugDbContext _bugDbContext;

    public createModel(BugDbContext bugDbContext)
    {
        this._bugDbContext = bugDbContext;
    }

    [BindProperty]
    public string Name { get; set; }
    [BindProperty]
    public string Description { get; set; }

    public IActionResult OnPost()
    {
        _bugDbContext.Bugs.Add(new Model.Bug() { Name = Name, Description = Description, IsDone=false });
        _bugDbContext.SaveChanges();
        return RedirectToPage("./Index");
    }

}
