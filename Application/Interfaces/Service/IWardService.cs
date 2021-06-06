using Application.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.Service
{
    public interface IWardService
    {
        Task<IEnumerable<WardDto>> GetAll();
    }
}
