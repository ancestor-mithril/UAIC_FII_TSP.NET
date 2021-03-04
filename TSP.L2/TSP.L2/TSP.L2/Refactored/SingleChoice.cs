using SOLID.OCP;
using System;
using System.Collections.Generic;

namespace TSP.L2.Refactored
{
    public class BankTerminalFactory
    {
        private static readonly Dictionary<BankTerminalModel, Func<IBankTerminal>> bankTerminals;

        static BankTerminalFactory()
        {
            bankTerminals = new Dictionary<BankTerminalModel, Func<IBankTerminal>>();
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
