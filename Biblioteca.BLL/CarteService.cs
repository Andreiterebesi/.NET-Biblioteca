using AutoMapper;
using Biblioteca.BLL.Ports;
using Biblioteca.Core.Models;
using Biblioteca.Repository;
using Biblioteca.Repository.Entity;
using Biblioteca.Repository.Ports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.BLL
{
    public class CarteService : ICarteService
    {
        private readonly ICarteRepository _carteRepository;

        private IMapper Mapper { get; set; }

        public CarteService(ICarteRepository carteRepository)
        {
            _carteRepository = carteRepository;

            Mapper = SetMapperConfigs();
        }
        public List<CarteDto> GetCartiList()
        {
            var carteEntityList = _carteRepository.GetCarti();
            var carteList = Mapper.Map<List<CarteDto>>(carteEntityList);

            return carteList;
        }
        private IMapper SetMapperConfigs()
        {
            var config = new MapperConfiguration(cfg =>
              {
                  cfg.CreateMap<CarteDto, CarteEntity>();
                  cfg.CreateMap<CarteEntity, CarteDto>();
              });

            IMapper mapper = config.CreateMapper();

            return mapper;
        }
    }
}
