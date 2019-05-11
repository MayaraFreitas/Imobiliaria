using Imobiliaria.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Imobiliaria.Service
{
    public interface IGenericoService
    {
        byte BuscarTipoUsuario(string idUsuario);
    }
    public class GenericoService : IGenericoService
    {
        #region Injeção

        private readonly IGenericoRepository _genericoRepo;

        public GenericoService(IGenericoRepository genericoRepository)
        {
            _genericoRepo = genericoRepository;
        }

        #endregion

        public byte BuscarTipoUsuario(string idUsuario)
        {
            return _genericoRepo.BuscarTipoUsuario(idUsuario);
        }
    }
}
