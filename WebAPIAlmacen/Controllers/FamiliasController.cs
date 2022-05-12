﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAPIAlmacen.Entidades;

namespace WebAPIAlmacen.Controllers
{
    [ApiController]
    [Route("api/Familias")]
    public class FamiliasController:ControllerBase
    {
        private readonly ApplicationDbContext context;

        public FamiliasController(ApplicationDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<IEnumerable<Familia>> Get()
        {
            return await context.Familias.ToListAsync();
        }
    }
}
