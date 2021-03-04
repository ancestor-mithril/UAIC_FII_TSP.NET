using System.IO.Ports;

namespace TSP.L2.Refactored
{
    interface ISerialPortFinder
    {
        string FindPort();
    }

    public abstract class SerialPortFinder : ISerialPortFinder
    {
        protected SerialPort port;

        public SerialPortFinder(int baudRate, Parity parity, Handshake handshake)
        {
            port = new SerialPort();
            port.BaudRate = baudRate;
            port.Parity = parity;
            port.Handshake = handshake;
        }
        public string FindPort()
        {
            return Find(port);
        }
        public string Find(SerialPort port)
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

    public class PortFinderCashCode : SerialPortFinder
    {
        public PortFinderCashCode() : base(9600, Parity.Even, Handshake.RequestToSend) { }
    }
    public class PortFinderEcdm : SerialPortFinder
    {
        public PortFinderEcdm() : base(4800, Parity.Mark, Handshake.RequestToSendXOnXOff) { }
    }

    public class PortFinderNri : SerialPortFinder
    {
        public PortFinderNri() : base(19200, Parity.Odd, Handshake.XOnXOff) { }

    }

    public class PortFinderCube4 : SerialPortFinder
    {
        public PortFinderCube4() : base(9600, Parity.Space, Handshake.None) { }
    }
    
    public class PortFinderSch2 : SerialPortFinder
    {
        public PortFinderSch2() : base(4800, Parity.Even, Handshake.None) { }
    }
}
