using SOLID.OCP;
using System;
using System.Collections.Generic;
using System.IO.Ports;

namespace TSP.L2.Refactored
{
    public class DeviceFinder
    {
        private readonly Dictionary<DeviceModel, ISerialPortFinder> portFinder;
        public DeviceFinder()
        {
            portFinder = new Dictionary<DeviceModel, ISerialPortFinder>();
            portFinder.Add(DeviceModel.BillAccepterCashCode, new PortFinderCashCode());
            portFinder.Add(DeviceModel.BillDispenserEcdm, new PortFinderEcdm());
            portFinder.Add(DeviceModel.CoinAccepterNri, new PortFinderNri());
            portFinder.Add(DeviceModel.CoinDispenserCube4, new PortFinderCube4());
            portFinder.Add(DeviceModel.CoinDispsenerSch2, new PortFinderSch2());
        }
        public string FindDevice(DeviceModel model)
        {
            if (portFinder.ContainsKey(model))
            {
                var port = portFinder[model].FindPort();
                return Find(port);
            }
            throw new ArgumentException($"Unknown model: {model}.");
        }

        private string Find(SerialPort port)
        {
            string[] names = SerialPort.GetPortNames();
            foreach (string name in names)
            {
                port.Write("special code");
                if (port.ReadByte() == 0)
                    return name;
            }
            return null;
        }
    }
}
