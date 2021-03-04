using SOLID.OCP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSP.L2.Refactored
{
    public class BankTerminalFactory
    {
        private static readonly Dictionary<BankTerminalModel, Func<IBankTerminal>> bankTerminals;

        public BankTerminalFactory()
        {
            bankTerminals.Add(BankTerminalModel.Brp, () => new BrpTerminal());
            bankTerminals.Add(BankTerminalModel.Dcp, () => new DcpTerminal());
        }

        public static IBankTerminal CreateBankTerminal(BankTerminalModel model)
        { 
            if (bankTerminals.ContainsKey(model))
            {
                return bankTerminals[model]();
            }
            throw new ArgumentException("Unknown model");
        }
    }
}
