using FaixaEtaria.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FaixaEtaria.ViewComponets
{
    public class AdultoViewComponent : ViewComponent
    {
        private readonly PessoaContexto _pessoaContexto;

        public AdultoViewComponent (PessoaContexto pessoaContexto)
        {
            _pessoaContexto = pessoaContexto;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View(await _pessoaContexto.Pessoas.Where(p => p.Idade > 18 && p.Idade < 60).ToListAsync());
        }
    }
}
