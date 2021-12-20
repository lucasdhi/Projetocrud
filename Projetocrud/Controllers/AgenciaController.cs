using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Projetocrud.Models;

namespace Projetocrud.Controllers
{
    public class AgenciaController : Controller
    {
        private readonly Context _context;

        public AgenciaController(Context context)
        {
            _context = context;
        }

        // GET: Agencia
        public async Task<IActionResult> Index()
        {
            return View(await _context.agencia.ToListAsync());
        }

        // GET: Agencia/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var agencia = await _context.agencia
                .FirstOrDefaultAsync(m => m.id == id);
            if (agencia == null)
            {
                return NotFound();
            }

            return View(agencia);
        }

        // GET: Agencia/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Agencia/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,Nome,Email,Destino,Contato,Promoção,Endereço,Cidade")] Agencia agencia)
        {
            if (ModelState.IsValid)
            {
                _context.Add(agencia);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(agencia);
        }

        // GET: Agencia/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var agencia = await _context.agencia.FindAsync(id);
            if (agencia == null)
            {
                return NotFound();
            }
            return View(agencia);
        }

        // POST: Agencia/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,Nome,Email,Destino,Contato,Promoção,Endereço,Cidade")] Agencia agencia)
        {
            if (id != agencia.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(agencia);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AgenciaExists(agencia.id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(agencia);
        }

        // GET: Agencia/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var agencia = await _context.agencia
                .FirstOrDefaultAsync(m => m.id == id);
            if (agencia == null)
            {
                return NotFound();
            }

            return View(agencia);
        }

        // POST: Agencia/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var agencia = await _context.agencia.FindAsync(id);
            _context.agencia.Remove(agencia);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AgenciaExists(int id)
        {
            return _context.agencia.Any(e => e.id == id);
        }
    }
}
