using TSP.L2.Refactored;
using SOLID.OCP;

namespace Lab2
{
    class Program
    {

        static void Main(string[] args)
        {
            var bankTerminal = TSP.L2.Refactored.BankTerminalFactory.CreateBankTerminal(BankTerminalModel.Brp);
            var deviceFinder = new DeviceFinder();
            var device = deviceFinder.FindDevice(DeviceModel.BillAccepterCashCode);
            System.Console.WriteLine(device);
            System.Console.WriteLine("ok");
        }
    }
}
