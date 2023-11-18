using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraspPatterns.PureFabrication
{
    public class ClientService
    {
        private IClientRepository _clientRepository;
        public ClientService(IClientRepository clientRepository) { 
        
            _clientRepository = clientRepository;
        }

        public void Save() { 
        
            _clientRepository.Save();
        }
    }
}
