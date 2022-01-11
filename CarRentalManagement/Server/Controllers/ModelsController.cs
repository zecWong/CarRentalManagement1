using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CarRentalManagement.Server.Data;
using CarRentalManagement.Shared.Domain;
using CarRentalManagement.Server.Repository;
using CarRentalManagement.Server.IRepository;

namespace CarRentalManagement.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ModelsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public ModelsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/Models
        [HttpGet]
        public async Task<IActionResult> GetModels()
        {
            var Models = await _unitOfWork.Models.GetAll();
            return Ok(Models);
        }

        // GET: api/Models/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Model>> GetModels(int id)
        {
            var Models = await _unitOfWork.Models.Get(q => q.Id == id);

            if (Models == null)
            {
                return NotFound();
            }

            return Ok(Models);
        }

        // PUT: api/Models/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutModels(int id, Model Model)
        {
            if (id != Model.Id)
            {
                return BadRequest();
            }
            //Refactered
            //context.Entry(Models).state= EnitityState.Modified;
            _unitOfWork.Models.Update(Model);

            try
            {
                //Refactered
                //await _context.SaveChangesAsync();
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await ModelsExistsAsync(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Models
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Model>> PostModels(Model Model)
        {
            //_context.Models.Add(Models);
            //await _context.SaveChangesAsync();

            await _unitOfWork.Models.Insert(Model);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetModels", new { id = Model.Id }, Model);
        }

        // DELETE: api/Models/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteModels(int id)
        {
            //var Models = await _context.Models.FindAsync(id);
            var Models = await _unitOfWork.Models.Get(q => q.Id == id);
            if (Models == null)
            {
                return NotFound();
            }

            //_context.Models.Remove(Models);
            //await _context.SaveChangesAsync();

            await _unitOfWork.Models.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        private async Task<bool> ModelsExistsAsync(int id)
        {
            //return _context.Models.Any(e => e.Id == id);
            var Model = await _unitOfWork.Models.Get(q => q.Id == id);
            return Model != null;
        }
    }
}
