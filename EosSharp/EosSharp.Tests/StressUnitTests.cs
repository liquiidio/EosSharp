using EosSharp.Core;
using EosSharp.Core.Providers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EosSharp.UnitTests
{
    [TestClass]
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

        [TestMethod]
        [TestCategory("Stress Tests")]
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
                    tasks.Add(Task.Factory.StartNew(async (taskIdObj) =>
                    {
                        int taskId = taskIdObj as int? ?? 0;
                        for (int j = 1; j <= taskBlocks; j++)
                        {
                            try
                            {
                                await Eos.GetBlock((taskId * taskBlocks + blockStartPos + j).ToString());
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(JsonConvert.SerializeObject(ex));
                            }
                        }
                    }, i).Unwrap());
                }

                await Task.WhenAll(tasks.ToArray());

                success = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(JsonConvert.SerializeObject(ex));
            }

            Assert.IsTrue(success);
        }
    }
}
