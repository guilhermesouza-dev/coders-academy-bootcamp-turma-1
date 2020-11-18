﻿using CodersAcademy.API.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CodersAcademy.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlbumController : ControllerBase
    {
        private AlbumRepository Repository { get; init; } 
        public AlbumController(AlbumRepository repository)
        {
            Repository = repository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAlbuns()
        {
            return Ok(await this.Repository.GetAllAsync());
        }

    }
}
