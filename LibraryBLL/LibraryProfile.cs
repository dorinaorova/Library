using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryBLL {
    public class LibraryProfile : Profile {
        public LibraryProfile() {
            CreateMap<LibraryDAL.Entities.Konyv, Konyv>().ReverseMap();
            CreateMap<LibraryDAL.Entities.Olvaso, Olvaso>().ReverseMap();
            CreateMap<LibraryDAL.Entities.Kolcsonzes, Kolcsonzes>().ReverseMap();
        }
    }
}
