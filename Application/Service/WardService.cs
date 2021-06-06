using Application.Dtos;
using Application.Interfaces.Repositoryplication;
using Application.Interfaces.Service;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Service
{
    public class WardService : IWardService
    {
        private readonly IMapper _mapper;
        private readonly IWardRepository _wardRepository;

        public WardService(IWardRepository wardRepository,
            IMapper mapper)
        {
            _mapper = mapper;
            _wardRepository = wardRepository;
        }

        public async Task<IEnumerable<WardDto>> GetAll()
        {
            var wardsDto = (await _wardRepository.GetAll())
                .Select(w => _mapper.Map<WardDto>(w));

            return wardsDto;
        }
    }
}
