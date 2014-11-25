using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructureMap.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            BootStrapper.ConfigureStructureMap();
            IContractRepository repository=ObjectFactory.GetInstance<IContractRepository>();
            IContractValidator validator=ObjectFactory.GetInstance<IContractValidator>();
            ContractContraller contraller = new ContractContraller(repository, validator);

            ContractEntity entity = new ContractEntity() { Name = "zxj", Birthday = DateTime.Now, IdCard = "332624" };

            contraller.Save(entity);

            Console.Read();
        }
    }

}
