using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructureMap.Test
{
    public class ContractValidator : IContractValidator
    {
        public bool Validate(ContractEntity contract)
        {
            Console.WriteLine("Contrac {0} has been validated", contract.Name);
            return true;
        }
    }
}
