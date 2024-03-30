using firstCRUD.Model;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace firstCRUD.Pages;
public class IndexModel : PageModel
    {
        public IList<Bug> Bugs { get; set; }
        public int UnDoneCount { get; set; }
        public void OnGet()
        {
            Bugs = new List<Bug>()
            {
                new Bug { Id = 1, Name = "baggage", Description = "Parsing baggage in accelaero", IsDone = false },
                new Bug { Id = 2, Name = "departure", Description = "departure date time error", IsDone = false },
                new Bug { Id = 3, Name = "number zero", Description = "fix zero in booking page", IsDone = false },
                new Bug { Id = 4, Name = "divide by one", Description = "prevent to error in erroring", IsDone = true },
                new Bug { Id = 5, Name = "aircraft type", Description = "show mistake aircraft name", IsDone = false },
                new Bug { Id = 6, Name = "layoff", Description = "they should be layoff", IsDone = false },
                new Bug { Id = 7, Name = "about fares", Description = "net fares and web fares", IsDone = true },
            };

            UnDoneCount = Bugs.Count(i => i.IsDone==false);
        }
    }
