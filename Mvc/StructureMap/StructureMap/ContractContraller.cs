using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructureMap.Test
{
    public class ContractContraller
    {
        private IContractRepository _contractRepository;
        private IContractValidator _contractValidator;
        public ContractContraller(IContractRepository contractRepository,IContractValidator contractValidator)
        {
            this._contractRepository = contractRepository;
            this._contractValidator = contractValidator;
        }

        public void Save(ContractEntity contract)
        {
            this._contractValidator.Validate(contract);
            this._contractRepository.Save(contract);
        }
    }
}
