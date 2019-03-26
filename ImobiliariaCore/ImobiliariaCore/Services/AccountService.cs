using AutoMapper;
using Imobi.Helpers;
using Imobi.Repository;
using Imobi.Resources;
using Imobi.Services.VOs.Account;
using Imobi.Services.VOs.Usuario;
using System;

namespace Imobi.Services
{
    public interface IAccountService
    {
        string CreateAccount(UserVO userVO);
        bool Login(ViewUserLoginVO user);
    }

    public class AccountService : IAccountService
    {
        #region Propriedades

        private readonly IAccountRepository _accountRepo;
        private readonly IMapper _mapper;

        #endregion

        #region Construtor

        public AccountService(IAccountRepository accountRepo, IMapper mapper)
        {
            _accountRepo = accountRepo;
            _mapper = mapper;
        }

        #endregion

        public string CreateAccount(UserVO user)
        {
            try
            {
                string errorMessage = user.Validate();
                if (!string.IsNullOrEmpty(errorMessage))
                {
                    return errorMessage;
                }

                user.Senha = CriptoHelper.ConvertToMD5(user.Senha);
                _accountRepo.CreateAccount(user);

                return null;
            }
            catch (Exception e)
            {
                // Adicionar Log
                return Resource.Generic_Error;
            }
        }

        public bool Login(ViewUserLoginVO user)
        {
            user.Senha = CriptoHelper.ConvertToMD5(user.Senha);
            return _accountRepo.Login(user);
        }
    }
}
