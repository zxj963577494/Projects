using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructureMap.Test
{
    public class ContractRepository : IContractRepository
    {
        private string _connectionString1=null;
        private string _connectionString2=null;
        public ContractRepository(string connectionString)
        {
            _connectionString1 = connectionString;
        }

        public ContractRepository(string connectionString, string connectionString2)
        {
            _connectionString1 = connectionString;
            _connectionString2 = connectionString2;

        }

        public bool Save(ContractEntity contract)
        {
            Console.WriteLine(this._connectionString1);
             Console.WriteLine(this._connectionString2);
            Console.WriteLine("Contract {0} has been save", contract.Name);
            return true;
        }
    }
}
