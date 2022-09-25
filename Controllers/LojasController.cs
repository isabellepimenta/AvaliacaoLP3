using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Avaliacao.Models;

namespace Avaliacao.Controllers;

public class LojasController : Controller {
    public static List<LojasViewModel> lojas = new List<LojasViewModel>();

    public IActionResult Index()
    {
        return View(lojas);
    }

    public IActionResult Gerenciamento()
    {
        return View(lojas);
    }

    public IActionResult Apagar(int id)
    {
        lojas.RemoveAt(id-1);
        return View();
    }

    public IActionResult Detalhar(int id)
    {
        return View(lojas[id-1]);
    }

    public IActionResult Cadastro([FromForm] string piso, [FromForm] string nome, [FromForm] string tipo, [FromForm] string descricao, [FromForm] string email)
    {
        int id = 1;

        foreach(var loja in lojas)
        {
            if(nome == loja.Nome) 
            {
                ViewData["Mensagem"] = "O cadastro não pode ser realizado!!";
                ViewData["Motivo"] = "Esss loja já está cadastrada!";
                return View();
            }
        }

        for(int i = 0; i < lojas.Count; i++) {
            id++;
        }
       
        lojas.Add(new LojasViewModel(id, piso, nome, tipo, descricao, email));

        ViewData["Mensagem"] = "Cadastro completo!";
        ViewData["Motivo"] = "Esss loja foi cadastrada com sucesso!";
        return View();
    }
    
    public IActionResult Cadastrar()
    {
        return View();
    }
}