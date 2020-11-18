using System;
using System.IO;
using System.Net.Sockets;

namespace Server_NETFrameworkConsoleCSharp
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                TcpListener server = new TcpListener(8888);
                server.Start();
                Console.WriteLine("Server Started and waiting for clients...");
                Socket socketForClients = server.AcceptSocket();
                if (socketForClients.Connected)
                {
                    string opt = "";
                    NetworkStream ns = new NetworkStream(socketForClients);
                    StreamWriter sw = new StreamWriter(ns);
                    StreamReader sr = new StreamReader(ns);
                    sw.AutoFlush = true;
                    Console.WriteLine("Server>> Welcome Client.");

                    while (true)
                    {
                        string json = sr.ReadLine();
                        Console.WriteLine(json);
                        sw.WriteLine(json);

                        if (opt == null)
                            break;
                    }

                    sr.Close();
                    if (sw != null)
                    {
                        sw.Close();
                    }
                    ns.Close();
                }

                socketForClients.Close();
            }
            catch (Exception ex)
            {
            }


        }
    }
}
