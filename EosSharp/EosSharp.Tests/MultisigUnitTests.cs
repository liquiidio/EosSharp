using Cryptography.ECDSA;
using EosSharp.Core;
using EosSharp.Core.Api.v1;
using EosSharp.Core.Helpers;
using EosSharp.Core.Interfaces;
using EosSharp.Core.Providers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EosSharp.UnitTests
{
    [TestClass]
    public class MultisigUnitTests
    {
        EosUnitTestCases EosUnitTestCases;
        public MultisigUnitTests()
        {
            var eosConfig = new EosConfigurator()
            {
                SignProvider = new CombinedSignersProvider(new List<ISignProvider>() {
                    new DefaultSignProvider("5KQwrPbwdL6PhXujxW37FSSQZ1JiwsST4cqQzDeyXtP79zkvFD3"),
                    new DefaultSignProvider("5JjWBn4DKVPe7DSXXXK852CQeEVBQjyqW9s7vbzXAQqxLxca5Hz")
                }),

                HttpEndpoint = "https://wax.api.eosnation.io/",
                ChainId = "1064487b3cd1a897ce03ae5b6a865651747e2e152090f99c1d19d44e01aea5a4"
            };
            EosUnitTestCases = new EosUnitTestCases(new Eos(eosConfig));
        }

        [TestMethod]
        [TestCategory("Multisig Tests")]
        public async Task CreateTransaction2ProvidersAsync()
        {
            bool success = false;
            try
            {
                await EosUnitTestCases.CreateTransaction2Providers();
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
