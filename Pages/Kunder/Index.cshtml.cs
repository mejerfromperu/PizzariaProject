using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PizzariaProject.Model;
using PizzariaProject.services;

namespace PizzariaProject.Pages.Kunder
{
    public class IndexModel : PageModel
    {

        // Property til View'et

        public List<Kunde> Kunder { get; private set; }

        public void OnGet()
        {
            KundeRepository repo = new KundeRepository(true);

            Kunder = repo.HentAlleKunder();
        }
    }
}
