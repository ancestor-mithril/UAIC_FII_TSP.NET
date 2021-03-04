using System.IO.Ports;

namespace TSP.L2.Refactored
{
    interface ISerialPortFinder
    {
        SerialPort FindPort();
    }

    public class PortFinderCashCode : ISerialPortFinder
    {
        public SerialPort FindPort()
        {
            var port = new SerialPort();
            port.BaudRate = 9600;
            port.Parity = Parity.Even;
            port.Handshake = Handshake.RequestToSend;
            return port;
        }
    }
    public class PortFinderEcdm : ISerialPortFinder
    {
        public SerialPort FindPort()
        {
            var port = new SerialPort();
            port.BaudRate = 4800;
            port.Parity = Parity.Mark;
            port.Handshake = Handshake.RequestToSendXOnXOff;
            return port;
        }
    }

    public class PortFinderNri : ISerialPortFinder
    {
        public SerialPort FindPort()
        {
            var port = new SerialPort();
            port.BaudRate = 19200;
            port.Parity = Parity.Odd;
            port.Handshake = Handshake.XOnXOff;
            return port;
        }
    }

    public class PortFinderCube4 : ISerialPortFinder
    {
        public SerialPort FindPort()
        {
            var port = new SerialPort();
            port.BaudRate = 9600;
            port.Parity = Parity.Space;
            port.Handshake = Handshake.None;
            return port;
        }
    }
    
    public class PortFinderSch2 : ISerialPortFinder
    {
        public SerialPort FindPort()
        {
            var port = new SerialPort();
            port.BaudRate = 4800;
            port.Parity = Parity.Even;
            port.Handshake = Handshake.None;
            return port;
        }
    }
}
