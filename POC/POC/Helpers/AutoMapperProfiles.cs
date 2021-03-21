using AutoMapper;
using POC.DTOs;
using POC.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POC.Helpers
{
    public class AutoMapperProfiles: Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Users, UsersDTO>().ReverseMap();

            /*
            CreateMap<GenreCreationDTO, Genre>();

            CreateMap<Person, PersonDTO>().ReverseMap();

            CreateMap<PersonCreationDTO, Person>()
                .ForMember(x => x.Picture, options => options.Ignore());

            CreateMap<Person, PersonPatchDTO>().ReverseMap();

            CreateMap<Movie, MovieDTO>().ReverseMap();

            CreateMap<MovieCreationDTO, Movie>()
                .ForMember(x => x.Poster, options => options.Ignore())
                .ForMember(x => x.MoviesGenres, options => options.MapFrom(MapMoviesGenres))
                .ForMember(x => x.MoviesActors, options => options.MapFrom(MapMoviesActors));

            CreateMap<Movie, MovieDetailsDTO>()
               .ForMember(x => x.Genres, options => options.MapFrom(MapMoviesGenres))
               .ForMember(x => x.Actors, options => options.MapFrom(MapMoviesActors));

            CreateMap<Movie, MoviePatchDTO>().ReverseMap();

            */
        }

       
    }
}
