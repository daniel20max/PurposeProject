using PurposeProject.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PurposeProject.Services
{
    public class ClientService
    {
        private PurposeContext _context;
        public ClientService(PurposeContext context)
        {
            _context = context;
        }
    }
}
