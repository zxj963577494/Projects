using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructureMap.Test
{
    public interface IContractValidator
    {
        bool Validate(ContractEntity contract);
    }
}
