﻿using LSRPO.Core.Contracts;
using LSRPO.Core.Models.NotifyStatus;
using LSRPO.Infrastructure.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSRPO.Core.Services
{
    public class NotifyStatusService : INotifyStatusService
    {
        private readonly IApplicatioDbRepository repo;

        public NotifyStatusService(IApplicatioDbRepository repo)
        {
            this.repo = repo;
        }

        public async Task<IEnumerable<ProcessDetailsViewModel>> GetProcessDetails(int id)
        {
            throw new NotImplementedException();
        }
    }
}