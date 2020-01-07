using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using CitrusDB.Model.JsonLogic;
using CitrusDB.Model.NetworkLogic.DtoData;
using CitrusDB.Model.NetworkLogic.DtoData.Respond;

namespace CitrusDB.Model.NetworkLogic
{
  public class NetworkManager
  {
    private static IPEndPoint _endPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8888);

    public static R Send<T, R>(T dto)
      where T : BaseRequestDto
      where R : BaseRespondDto
    {
      var dtoJson = JsonFormatter.Serialize(dto);
      var data = Encoding.UTF8.GetBytes(dtoJson);
      using (var socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp))
      {
        socket.Connect(_endPoint);
        socket.Send(data);

        var buff = new byte[256];
        socket.Receive(buff);
        var json = Encoding.UTF8.GetString(buff);
        return JsonFormatter.Deserialize<R>(json);
      }
    }
  }
}