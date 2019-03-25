using AutoMapper;
using Imobi.Models;
using Imobi.Repository.Entities;
using Imobi.Services.VOs.Account;
using Imobi.Services.VOs.Usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Imobi.Repository
{
    public interface IAccountRepository
    {
        void CreateAccount(UserVO userVO);
        bool Login(ViewUserLoginVO user);
    }

    public class AccountRepository : IAccountRepository
    {
        #region Properties

        private readonly ImobiContext _contex;
        private readonly IMapper _mapper;

        #endregion

        #region Constructor

        public AccountRepository(ImobiContext contex, IMapper mapper)
        {
            _contex = contex;
            _mapper = mapper;
        }

        #endregion

        #region Methods

        public void CreateAccount(UserVO user)
        {
            _contex.Accounts.Add(_mapper.Map<User>(user));

            _contex.SaveChanges();
        }

        public bool Login(ViewUserLoginVO user)
        {
            return _contex.Accounts.Where(u => u.Email == user.Email && u.Senha == user.Senha).Any();
        }

        #endregion
    }
}
