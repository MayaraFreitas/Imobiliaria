using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Imobiliaria.Data.Repository
{
    public interface IGenericoRepository
    {
        byte BuscarTipoUsuario(string idUsuario);
    }
    public class GenericoRepository : IGenericoRepository
    {
        #region Constantes

        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        #endregion

        #region Construtor
        public GenericoRepository(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        #endregion

        public byte BuscarTipoUsuario(string idUsuario)
        {
            byte? userType = _context.ViewUsuario.Where(u => u.Id == idUsuario).Select(u => u.UserType).FirstOrDefault();
            return userType ?? 0;
        }
    }
}
