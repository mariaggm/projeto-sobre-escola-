using Escola.Data;
using Escola.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Escola.Controllers
{
    public class AlunoController : Controller
    {
        
        private readonly Context _context;
        public AlunoController(Context context) 
        { 
            _context = context;
        
        }
        // GET: AlunoController
        public ActionResult Index()
        {
            var alunos = _context.Alunos.Take(1000);
            return View(alunos);
        }

        // GET: AlunoController/Details/5
        public ActionResult Details(int AlunoId)
        {
            var aluno = _context.Alunos.FirstOrDefault(x =>x.AlunoId == AlunoId);
            return View(aluno); 
        }

        // GET: AlunoController/Create
        public ActionResult Create( )
        {
           
            return View();
        }

        // POST: AlunoController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Aluno aluno)
        {
            try
            {
                _context.Alunos.Add(aluno);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AlunoController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AlunoController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AlunoController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AlunoController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
