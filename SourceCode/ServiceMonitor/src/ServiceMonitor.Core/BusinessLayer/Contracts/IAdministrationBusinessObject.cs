﻿using System;
using System.Threading.Tasks;
using ServiceMonitor.Core.BusinessLayer.Responses;
using ServiceMonitor.Core.EntityLayer;

namespace ServiceMonitor.Core.BusinessLayer.Contracts
{
    public interface IAdministrationBusinessObject : IBusinessObject
    {
        Task<ISingleViewModelResponse<ServiceEnvironmentStatusLog>> CreateServiceEnvironmentStatusLogAsync(ServiceEnvironmentStatusLog entity, Int32? serviceEnvironmentID);
    }
}
