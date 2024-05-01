using AutoMapper;
using FilmesApi.Data.Dtos;
using FilmesApi.Models;

namespace FilmesApi.Profiles;

public class CinemaProfile : Profile
{
    public CinemaProfile ()
    {
        CreateMap<CreateCinemaDto, Cinema>();
        CreateMap<Cinema, ReadCinemaDto>()
            .ForMember(cinemaDto => cinemaDto.ReadEnderecoDto, 
            opts => opts.MapFrom(cinema => cinema.Endereco))  
        .ForMember(cinemaDto => cinemaDto.Sessoes,
            opts => opts.MapFrom(cinema => cinema.Sessoes));
        CreateMap<UpdateCinemaDto, Cinema>();
    }
}
