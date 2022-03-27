using LSRPO.Core.Contracts;
using LSRPO.Infrastructure.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSRPO.Core.Services
{
    public class NotifyProcessService : INotifyProcessService
    {
        private readonly IApplicatioDbRepository repo;

        public NotifyProcessService(IApplicatioDbRepository repo)
        {
            this.repo = repo;
        }


    }
}