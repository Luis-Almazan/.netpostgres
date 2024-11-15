using Api.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

public class Datos : ControllerBase
{
    private readonly AdminContext _context;

    public Datos(AdminContext context)
    {
        _context = context;
    }

    [HttpGet]
    [Route("[controller]")]
    public async Task<IActionResult> Get()
    {
        var items = await _context.Usuarios.ToListAsync();
        return Ok(items);
    }
}
