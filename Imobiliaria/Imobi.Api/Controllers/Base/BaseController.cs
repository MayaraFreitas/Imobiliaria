﻿using Imobi.Domain.Interfaces.Services.Base;
using Imobi.Infra.Transaction;
using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace Imobi.Api.Controllers.Base
{
    public class BaseController : ApiController
    {
        private readonly IUnitOfWork _unitOfWork;
        private IServiceBase _baseService;

        public BaseController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<HttpResponseMessage> ResponseAsync(object result, IServiceBase baseService)
        {
            _baseService = baseService;

            if (!baseService.Notifications.Any())
            {
                try
                {
                    _unitOfWork.Commit();

                    return Request.CreateResponse(HttpStatusCode.OK, result);
                }
                catch (Exception ex)
                {
                    // Aqui devo logar o erro
                    return Request.CreateResponse(HttpStatusCode.Conflict, $"Houve um problema interno com o servidor. Entre em contato com o Administrador do sistema caso o problema persista. Erro interno: {ex.Message}");
                }
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, new { errors = baseService.Notifications });
            }
        }

        public async Task<HttpResponseMessage> ResponseExceptionAsync(Exception ex)
        {
            return Request.CreateResponse(HttpStatusCode.InternalServerError, new { errors = ex.Message, exception = ex.ToString() });
        }

        protected override void Dispose(bool disposing)
        {
            //Realiza o dispose no serviço para que possa ser zerada as notificações
            if (_baseService != null)
            {
                _baseService.Dispose();
            }

            base.Dispose(disposing);
        }
    }
}