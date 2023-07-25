using System.Net.Sockets;

namespace NetTransfer.Sockets {
    public partial class Client {
        private TcpClient socket = new();
        private NetworkStream stream;
        private string Data;

        private int interval;

        private Thread sender, receiver;

        public Client(string host, int port) {
            socket.Connect(host, port);
            stream = socket.GetStream();
        }

        public void Run(string data, int interval) {
            this.Data = data;
            this.interval = interval;

            sender = new(Send);
            receiver = new(Receive);

            sender.Start();
            receiver.Start();
        }
    }
}
