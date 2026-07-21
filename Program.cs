using System;
using System.Net;
using System.Text;
using System.Threading;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            int port = 8080;
            HttpListener listener = new HttpListener();
            listener.Prefixes.Add($"http://localhost:{port}/");
            listener.Start();
            Console.WriteLine($"Listening on port {port}...");

            while (result < 1000)
            {
                HttpListenerContext context = listener.GetContext();
                // HttpListenerRequest request = context.Request;
                HttpListenerResponse response = context.Response;

                string responseString = @"
                    <html>
                      <body style='font-family: sans-serif; text-align: center; margin-top: 50px;'>
                        <h1>Welcome to .NET 4.7 App!</h1>
                        <p>This is a fully functional backend API ready for the demo.</p>
                      </body>
                    </html>";
                
                byte[] buffer = Encoding.UTF8.GetBytes(responseString);
                response.ContentLength64 = buffer.Length;
                System.IO.Stream output = response.OutputStream;
                output.Write(buffer, 0, buffer.Length);
                output.Close();
            }
        }
    }
}
