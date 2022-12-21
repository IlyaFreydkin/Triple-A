using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using TripleAProject.Application.Dto;
using TripleAProject.Webapi.Infrastructure;
using TripleAProject.Webapi.Model;

[ApiController]
[Route("/api/[controller]")]
public class MovieController : ControllerBase
{ 
    private readonly IMapper _mapper;
    private readonly AAAContext _db;

    public MovieController(AAAContext db, IMapper mapper)
    {
        _db = db;
        _mapper = mapper;
    }

    [HttpGet]
    public IActionResult GetAllMovie()
    {
        var movie = _db.Movies.OrderBy(a => a.Created)
            .Select(a => new
            {
                a.Guid,
                a.Title,
                a.Link,
                GenreGuid = a.Genre.Guid,
                GenreName = a.Genre.Name
            })
            .ToList();
        return Ok(movie);
    }

    [HttpGet("{guid:Guid}")]
    public IActionResult GetMovieDetail(Guid guid)
    {
        var movie = _db.Movies
            .Where(a => a.Guid == guid)
            .Select(a => new
            {
                a.Guid,
                a.Title,
                a.Link,
                GenreGuid = a.Genre.Guid,
                GenreName = a.Genre.Name
            })
            .FirstOrDefault(a => a.Guid == guid);
        if (movie is null) { return NotFound(); }
        return Ok(movie);
    }

    [HttpPost]
    public IActionResult AddMovie(MovieDto movieDto)
    {
        var movie = _mapper.Map<Movie>(movieDto,
            opt => opt.AfterMap((dto, entity) =>
            {
                entity.Genre = _db.Genres.First(a => a.Guid == movieDto.GenreGuid);
                entity.Created = DateTime.UtcNow;
            }));
        _db.Movies.Add(movie);
        try { _db.SaveChanges(); }
        catch (DbUpdateException) { return BadRequest(); } 
        return Ok(_mapper.Map<Movie, MovieDto>(movie));
    }

    [HttpPut("{guid:Guid}")]
    public IActionResult EditMovie(Guid guid, MovieDto movieDto)
    {
        if (guid != movieDto.Guid) { return BadRequest(); }
        var movie = _db.Movies.FirstOrDefault(a => a.Guid == guid);
        if (movie is null) { return NotFound(); }
        _mapper.Map(movieDto, movie,
            opt => opt.AfterMap((dto, entity) =>
            {
                entity.Genre = _db.Genres.First(a => a.Guid == movieDto.GenreGuid);
            }));
        try { _db.SaveChanges(); }
        catch (DbUpdateException) { return BadRequest(); } 
        return NoContent();
    }

    [HttpDelete("{guid:Guid}")]
    public IActionResult DeleteMovie(Guid guid)
    {
        var movie = _db.Movies.FirstOrDefault(a => a.Guid == guid);
        if (movie is null) { return NotFound(); }
        _db.Movies.Remove(movie);
        try { _db.SaveChanges(); }
        catch (DbUpdateException) { return BadRequest(); } 
        return NoContent();
    }
}