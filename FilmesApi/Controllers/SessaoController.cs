using AutoMapper;
using FilmesApi.Data;
using FilmesApi.Data.Dtos;
using FilmesApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace FilmesApi.Controllers;
[ApiController]
[Route("[controller]")]

public class SessaoController : ControllerBase
{

    private FilmeContext _context;
    private IMapper _mapper;

    public SessaoController(FilmeContext context, IMapper mapper)
    {
        _context=context;
        _mapper=mapper;
    }

    [HttpPost]

    public IActionResult AdicionaSessao([FromBody] CreateSessaoDto createSessaoDto)
    {
        Sessao sessao = _mapper.Map<Sessao>(createSessaoDto);
        _context.Sessoes.Add(sessao);
        _context.SaveChanges();
        return CreatedAtAction(nameof (RecuperaSessaoPorId), new {filmeId = sessao.FilmeId, cinemaId = sessao.CinemaId}, sessao);

    }

    [HttpGet]
    public IEnumerable<ReadSessaoDto> RecuperaSessao()
    {
        return _mapper.Map<List<ReadSessaoDto>>(_context.Sessoes.ToList());
    }

    [HttpGet("{filmeId}/{cinemaId}")]
    
    public IActionResult RecuperaSessaoPorId (int filmeId, int cinemaId)
    {
        var sessao = _context.Sessoes.FirstOrDefault(sessao => sessao.FilmeId == filmeId && sessao.CinemaId == cinemaId);
        if (sessao == null)
        {
            return NotFound();  
        }
        var sessaoDto = _mapper.Map<ReadSessaoDto>(sessao);
        return Ok(sessaoDto);
    }
}
