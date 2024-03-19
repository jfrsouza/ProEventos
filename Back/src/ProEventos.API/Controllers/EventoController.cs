using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        public EventoController()
        {
            
        }

        [HttpGet]
        public Evento Get()
        {
            
            return new Evento(){
                EventoId=1,
                Tema = "Angula 11 e .NET 5",
                Local = "Curitiba",
                DataEvento = DateTime.Now.AddDays(2).ToString(),
                Lote = "1º lote",
                QtdPessoas = 250,
                ImagemURL = "Foto.png"
                };
            
        }

        [HttpPost]
        public string Post()
        {
            
            return "Exemplo de Post";
            
        }

        [HttpPut("{id}")]
        public string Put(int id)
        {
            
            return "Exemplo de Put com id = " + id;
            
        }

        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            
            return "Exemplo de Delete com id = " + id;
            
        }
    }
}
