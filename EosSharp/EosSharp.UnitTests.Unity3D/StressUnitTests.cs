using EosSharp.Core;
using EosSharp.Core.Providers;
using EosSharp.Unity3D;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EosSharp.UnitTests.Unity3D
{
    public class StressUnitTests
    {
        Eos Eos { get; set; }
        public StressUnitTests()
        {
            Eos = new Eos(new EosConfigurator()
            {
                SignProvider = new DefaultSignProvider("5K57oSZLpfzePvQNpsLS6NfKXLhhRARNU13q6u2ZPQCGHgKLbTA"),

                HttpEndpoint = "https://wax.api.eosnation.io/",
                ChainId = "1064487b3cd1a897ce03ae5b6a865651747e2e152090f99c1d19d44e01aea5a4"
            });
        }

        public async Task GetBlockTaskLoop()
        {
            bool success = false;
            int nrTasks = 50;
            int nrBlocks = 1000;
            int blockStartPos = 100;
            int taskBlocks = nrBlocks / nrTasks;

            try
            {
                List<Task> tasks = new List<Task>();

                for (int i = 0; i < nrTasks; i++)
                {
                    for (int j = 1; j <= taskBlocks; j++)
                    {
                        try
                        {
                            await Eos.GetBlock((i * taskBlocks + blockStartPos + j).ToString());
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(JsonConvert.SerializeObject(ex));
                        }
                    }
                }

                await Task.WhenAll(tasks.ToArray());

                success = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(JsonConvert.SerializeObject(ex));
            }

            if (success)
                Console.WriteLine("Test GetBlockTaskLoop run successfuly.");
            else
                Console.WriteLine("Test GetBlockTaskLoop run failed.");
        }

        public async Task TestAll()
        {
            //TODO disabled for now because of CORS policy blocked in localhost
            //await GetBlockTaskLoop();
            await Task.FromResult(0);
        }
    }
}
