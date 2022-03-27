using LSRPO.Core.Contracts;
using LSRPO.Infrastructure.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSRPO.Core.Services
{
    public class NotifyGroupService : INotifyGroupService
    {
        private readonly IApplicatioDbRepository repo;

        public NotifyGroupService(IApplicatioDbRepository repo)
        {
            this.repo = repo;
        }


    }
}