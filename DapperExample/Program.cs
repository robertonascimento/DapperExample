using Newtonsoft.Json;
using System;

namespace DapperExample
{
    public static class Program
    {
        static void Main(string[] args)
        {
            var clientRepository = new ClientRepository();
            var clients = clientRepository.Get(new ClientCriteria());
            Console.WriteLine(JsonConvert.SerializeObject(clients));

            clients = clientRepository.Get(new ClientCriteria() { Identification = "16.456"});
            Console.WriteLine(JsonConvert.SerializeObject(clients));
            Console.ReadKey();
        }
    }
}
