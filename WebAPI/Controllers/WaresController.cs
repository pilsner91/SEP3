using Logic.LogicInterfaces;
using Microsoft.AspNetCore.Mvc;
using Shared.DTOs;
using Shared.Model;

namespace WebAPI.Controllers; 

[ApiController]
[Route("[Controller]")]
public class WaresController : ControllerBase {

    private IWareLogic wareLogic;

    [HttpPost]
    public async Task<ActionResult<Ware>> CreateAsync(WareCreationDto dto) {
        try {
            Ware ware = await wareLogic.CreateAsync(dto);
            return Created($"/todos/{ware.VareNummer}", ware);
        }
        catch (Exception e) {
            Console.WriteLine(e);
            return StatusCode(500, e.Message);
        }
    }
}