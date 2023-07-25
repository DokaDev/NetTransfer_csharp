namespace NetTransfer.Sockets {
    public partial class Client {
        public enum ThreadManagementFlag {
            Suspend = 0,
            Resume = 1,
            Kill = 2
        }
        private bool killFlag = false;

        public void ChangeStatus(ThreadManagementFlag flag) {
            switch(flag) {
                case ThreadManagementFlag.Suspend:
                    sender.Suspend();
                    receiver.Suspend();
                    break;
                case ThreadManagementFlag.Resume:
                    sender.Resume();
                    receiver.Resume();
                    break;
                case ThreadManagementFlag.Kill:
                    killFlag = true;
                    sender.Join();
                    receiver.Join();
                    break;
            }
        }
    }
}
