using System;
using project.Client;
using System.Net;
Console.WriteLine("hello world");
using HttpClient httpClient = new HttpClient();
swaggerClient client = new swaggerClient("http://localhost:5000/", httpClient);
