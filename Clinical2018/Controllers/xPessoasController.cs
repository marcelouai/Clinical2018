﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Clinical2018.Models
{
    public class xPessoasController : Controller
    {
        private readonly Clinical2018Context _context;

        public xPessoasController(Clinical2018Context context)
        {
            _context = context;
        }

        // GET: Pessoas
        public async Task<IActionResult> Index()
        {
            return View(await _context.Pessoa.ToListAsync());
        }

        // GET: Pessoas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pessoa = await _context.Pessoa
                .SingleOrDefaultAsync(m => m.PessoaID == id);
            if (pessoa == null)
            {
                return NotFound();
            }

            return View(pessoa);
        }

        // GET: Pessoas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Pessoas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PessoaID,Tpo_Pessoa,Nome,NomeFantasia,CPF_CNPJ,RG,RG_Emiss,Naturalidade,Nacionalidade,EstadoCivil,Sexo,Data_Alt,Data_Cad,Data_Nasc,EMail,Tel,Tel_Cel,Tel_Cel_Mess,Tel_Comer,Tel_Comer_Mess,Tel_Comer_Ramal,CEP,Logradouro_Tpo,Logradouro,Numero,Complemento,Bairro,Localidade,UF_SGL,LocalidadeID,LogradouroID,BairroID,Logradouro_TpoID")] Pessoa pessoa)
        {
            if (ModelState.IsValid)
            {
                _context.Add(pessoa);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(pessoa);
        }

        // GET: Pessoas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pessoa = await _context.Pessoa.SingleOrDefaultAsync(m => m.PessoaID == id);
            if (pessoa == null)
            {
                return NotFound();
            }
            return View(pessoa);
        }

        public async Task<IActionResult> Teste(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pessoa = await _context.Pessoa.SingleOrDefaultAsync(m => m.PessoaID == id);
            if (pessoa == null)
            {
                return NotFound();
            }
            return View(pessoa);
        }

        // POST: Pessoas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PessoaID,Tpo_Pessoa,Nome,NomeFantasia,CPF_CNPJ,RG,RG_Emiss,Naturalidade,Nacionalidade,EstadoCivil,Sexo,Data_Alt,Data_Cad,Data_Nasc,EMail,Tel,Tel_Cel,Tel_Cel_Mess,Tel_Comer,Tel_Comer_Mess,Tel_Comer_Ramal,CEP,Logradouro_Tpo,Logradouro,Numero,Complemento,Bairro,Localidade,UF_SGL,LocalidadeID,LogradouroID,BairroID,Logradouro_TpoID")] Pessoa pessoa)
        {
            if (id != pessoa.PessoaID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pessoa);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PessoaExists(pessoa.PessoaID))
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
            return View(pessoa);
        }

        // GET: Pessoas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pessoa = await _context.Pessoa
                .SingleOrDefaultAsync(m => m.PessoaID == id);
            if (pessoa == null)
            {
                return NotFound();
            }

            return View(pessoa);
        }

        // POST: Pessoas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var pessoa = await _context.Pessoa.SingleOrDefaultAsync(m => m.PessoaID == id);
            _context.Pessoa.Remove(pessoa);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PessoaExists(int id)
        {
            return _context.Pessoa.Any(e => e.PessoaID == id);
        }


        // POST: Pessoas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Teste(int id, [Bind("PessoaID,Tpo_Pessoa,Nome,NomeFantasia,CPF_CNPJ,RG,RG_Emiss,Naturalidade,Nacionalidade,EstadoCivil,Sexo,Data_Alt,Data_Cad,Data_Nasc,EMail,Tel,Tel_Cel,Tel_Cel_Mess,Tel_Comer,Tel_Comer_Mess,Tel_Comer_Ramal,CEP,Logradouro_Tpo,Logradouro,Numero,Complemento,Bairro,Localidade,UF_SGL,LocalidadeID,LogradouroID,BairroID,Logradouro_TpoID")] Pessoa pessoa)
        {
            if (id != pessoa.PessoaID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pessoa);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PessoaExists(pessoa.PessoaID))
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
            return View(pessoa);
        }
    }
}
