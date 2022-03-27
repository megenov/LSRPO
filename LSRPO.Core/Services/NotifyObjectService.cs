using LSRPO.Core.Contracts;
using LSRPO.Infrastructure.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSRPO.Core.Services
{
    public class NotifyObjectService : INotifyObjectService
    {
        private readonly IApplicatioDbRepository repo;

        public NotifyObjectService(IApplicatioDbRepository repo)
        {
            this.repo = repo;
        }


    }
}