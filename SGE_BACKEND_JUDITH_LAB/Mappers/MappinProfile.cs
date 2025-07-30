using AutoMapper;
using SGE_BACKEND_JUDITH_LAB.Dtos;
using SGE_BACKEND_JUDITH_LAB.Models;

namespace SGE_BACKEND_JUDITH_LAB.Mappers
{
    public class MappinProfile : Profile
    {
        public MappinProfile()
        {
            CreateMap<Token, Usuarios>().ReverseMap();
            CreateMap<CotizaccionCab,CotizacionCabDto>().ReverseMap();
            CreateMap<CotizacionDetalle,CotizacionDetalleDto>().ReverseMap();

        }

    }
}
