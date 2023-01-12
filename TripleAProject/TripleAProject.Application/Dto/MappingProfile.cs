using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TripleAProject.Webapi.Model;

namespace TripleAProject.Application.Dto
{
    public class MappingProfile : Profile  // using AutoMapper;
    {
        public MappingProfile()
        {
            CreateMap<MovieDto, Movie>();
            CreateMap<Movie, MovieDto>(); 
            CreateMap<MovieRatingDto, MovieRating>();
            CreateMap<MovieRating, MovieRatingDto>(); 
            CreateMap<UserDto, User>();
            CreateMap<User, UserDto>();
        }
    }
}
