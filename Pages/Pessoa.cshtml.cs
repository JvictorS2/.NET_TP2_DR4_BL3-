using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TP2_.NET.Models;

namespace TP2_.NET.Pages
{
    public class PessoaModel : PageModel
    {
        public List<Pessoa>? PessoaLista { get; set; }

        public void OnGet()
        {
            PessoaLista =
            [
                new Pessoa("Joao", 20, "152.456.789-70"),
                new Pessoa("Victor", 20, "819.456.789-70"),
                new Pessoa("Nicolas", 29, "212.678.789-70"),
                new Pessoa("Samuel", 27, "132.456.098-70"),
                new Pessoa("Carlos", 29, "712.456.567-70"),
            ];
        }
    }
}
