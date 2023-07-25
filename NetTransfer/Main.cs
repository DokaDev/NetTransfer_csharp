using NetTransfer.Sockets;

int sizeof_data = 1000; // buffer size

string Data = new string('a', sizeof_data);

Client socket = new("192.168.0.0", 8080);
socket.Run(data: Data, interval: 500);


/*
 * socket.ChangeStatus(Client.ThreadManagementFlag.Kill);
 */