using curso.api.Bussines.Entidades;
using curso.api.Filters;
using curso.api.Infra.Data;
using curso.api.Models;
using curso.api.Models.Usuarios;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace curso.api.Controllers
{
    [Route("api/v1/usuario")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        [SwaggerResponse(statusCode: 200, description: "Sucesso", Type = typeof(LoginViewModelInput))]
        [SwaggerResponse(statusCode: 400, description: "Campos Error", Type = typeof(ValidaCampoViewModelOutput))]
        [SwaggerResponse(statusCode: 500, description: "Error", Type = typeof(ErroGenericoViewModel))]
        [HttpPost]
        [Route("logar")]
        [ValidacaoModelStateCustomizado]
        public IActionResult Logar(LoginViewModelInput loginViewModelIput)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(new ValidaCampoViewModelOutput(ModelState.SelectMany(sm => sm.Value.Errors).Select(s => s.ErrorMessage)));
            }
            return Ok(loginViewModelIput);
        }
        [HttpPost]
        [Route("registrar")]
        public IActionResult Registrar(RegistrarViewModelInput loginViewModelIput)
        {
            var options = new DbContextOptionsBuilder<CursoDbContext>();
            options.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=Curso2;Trusted_Connection=True;MultipleActiveResultSets=true");
            CursoDbContext context = new CursoDbContext(options);

            var usuario = new Usuario();
            usuario.Senha = loginViewModelIput.Senha;
            usuario.Login = loginViewModelIput.Login;
            usuario.Email = loginViewModelIput.Email;
            context.Usuario.Add(usuario);
            context.SaveChanges();
            return Created("", loginViewModelIput);
        }
    }
}
