using System.Diagnostics;

namespace NetTransfer.Sockets {
    public partial class Client {
        private void Receive() {
            try {
                while(true) {
                    if(killFlag)
                        break;
                    byte[] buffer = new byte[Data.Length];
                    stream.Read(buffer, 0, Data.Length);
                    // Debug.WriteLine("Message Received.");
                }
            } catch { }
            finally {
                // Debug.WriteLine("Sender Killed");
            }


        }
    }
}
