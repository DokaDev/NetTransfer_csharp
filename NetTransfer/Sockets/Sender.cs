using System.Text;

namespace NetTransfer.Sockets {
    public partial class Client {
        private void Send() {
            try {
                while(true) {
                    if(killFlag)
                        break;
                    byte[] buffer = Encoding.UTF8.GetBytes(Data);
                    // Debug.WriteLine($"Data Length : {Data.Length}");
                    stream.Write(buffer, 0, buffer.Length);
                    // Debug.WriteLine("Data Sent.");
                    Thread.Sleep(interval);
                }
            } catch { }
            finally {
                // Debug.WriteLine("Sender Killed");
            }
        }
    }
}
