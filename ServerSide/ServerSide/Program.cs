using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.IO;

namespace ServerSide
{
    class Program
    {
        static void Main(string[] args)
        {
            TcpListener server = new TcpListener(8888);
            server.Start();
            Console.WriteLine("Server Started! Waiting for clients...");
            Socket socket = server.AcceptSocket();

            if (socket.Connected) {
                NetworkStream ns = new NetworkStream(socket);
                StreamWriter sw = new StreamWriter(ns);
                sw.WriteLine("Welcome Client");
                sw.Flush();
                sw.Close();
                ns.Close();

            
            }
            socket.Close();

        }
    }
}
