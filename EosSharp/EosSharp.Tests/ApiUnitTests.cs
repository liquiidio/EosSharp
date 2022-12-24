// Auto Generated, do not edit.
using EosSharp.Core;
using EosSharp.Core.Api.v1;
using EosSharp.Core.Providers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using System;
using System.Threading.Tasks;

namespace EosSharp.UnitTests
{
    [TestClass]
    public class ApiUnitTests
    {
        ApiUnitTestCases ApiUnitTestCases;
        public ApiUnitTests()
        {
            var eosConfig = new EosConfigurator()
            {
                SignProvider = new DefaultSignProvider("5K57oSZLpfzePvQNpsLS6NfKXLhhRARNU13q6u2ZPQCGHgKLbTA"),

                HttpEndpoint = "https://wax.api.eosnation.io/",
                ChainId = "1064487b3cd1a897ce03ae5b6a865651747e2e152090f99c1d19d44e01aea5a4"
            };
            var eosApi = new EosApi(eosConfig, new HttpHandler());

            ApiUnitTestCases = new ApiUnitTestCases(eosConfig, eosApi);
        }

        [TestMethod]
        [TestCategory("Api Tests")]
        public async Task GetInfo()
        {
            bool success = false;
            try
            {
                await ApiUnitTestCases.GetInfo();
                success = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(JsonConvert.SerializeObject(ex));
            }

            Assert.IsTrue(success);
        }
        [TestMethod]
        [TestCategory("Api Tests")]
        public async Task GetAccount()
        {
            bool success = false;
            try
            {
                await ApiUnitTestCases.GetAccount();
                success = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(JsonConvert.SerializeObject(ex));
            }

            Assert.IsTrue(success);
        }
        [TestMethod]
        [TestCategory("Api Tests")]
        public async Task GetCode()
        {
            bool success = false;
            try
            {
                await ApiUnitTestCases.GetCode();
                success = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(JsonConvert.SerializeObject(ex));
            }

            Assert.IsTrue(success);
        }
        [TestMethod]
        [TestCategory("Api Tests")]
        public async Task GetAbi()
        {
            bool success = false;
            try
            {
                await ApiUnitTestCases.GetAbi();
                success = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(JsonConvert.SerializeObject(ex));
            }

            Assert.IsTrue(success);
        }
        [TestMethod]
        [TestCategory("Api Tests")]
        public async Task GetRawCodeAndAbi()
        {
            bool success = false;
            try
            {
                await ApiUnitTestCases.GetRawCodeAndAbi();
                success = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(JsonConvert.SerializeObject(ex));
            }

            Assert.IsTrue(success);
        }
        [TestMethod]
        [TestCategory("Api Tests")]
        public async Task GetRawAbi()
        {
            bool success = false;
            try
            {
                await ApiUnitTestCases.GetRawAbi();
                success = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(JsonConvert.SerializeObject(ex));
            }

            Assert.IsTrue(success);
        }
        [TestMethod]
        [TestCategory("Api Tests")]
        public async Task AbiJsonToBin()
        {
            bool success = false;
            try
            {
                await ApiUnitTestCases.AbiJsonToBin();
                success = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(JsonConvert.SerializeObject(ex));
            }

            Assert.IsTrue(success);
        }
        [TestMethod]
        [TestCategory("Api Tests")]
        public async Task AbiBinToJson()
        {
            bool success = false;
            try
            {
                await ApiUnitTestCases.AbiBinToJson();
                success = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(JsonConvert.SerializeObject(ex));
            }

            Assert.IsTrue(success);
        }

        [Ignore("Ignored because needs keys to be exposed")]
        [TestMethod]
        [TestCategory("Api Tests")]
        public async Task GetRequiredKeys()
        {
            bool success = false;
            try
            {
                await ApiUnitTestCases.GetRequiredKeys();
                success = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(JsonConvert.SerializeObject(ex));
            }

            Assert.IsTrue(success);
        }
        [TestMethod]
        [TestCategory("Api Tests")]
        public async Task GetBlock()
        {
            bool success = false;
            try
            {
                await ApiUnitTestCases.GetBlock();
                success = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(JsonConvert.SerializeObject(ex));
            }

            Assert.IsTrue(success);
        }
        [TestMethod]
        [TestCategory("Api Tests")]
        public async Task GetBlockHeaderState()
        {
            bool success = false;
            try
            {
                await ApiUnitTestCases.GetBlockHeaderState();
                success = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(JsonConvert.SerializeObject(ex));
            }

            Assert.IsTrue(success);
        }
        [TestMethod]
        [TestCategory("Api Tests")]
        public async Task GetTableRows()
        {
            bool success = false;
            try
            {
                await ApiUnitTestCases.GetTableRows();
                success = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(JsonConvert.SerializeObject(ex));
            }

            Assert.IsTrue(success);
        }
        [TestMethod]
        [TestCategory("Api Tests")]
        public async Task GetTableByScope()
        {
            bool success = false;
            try
            {
                await ApiUnitTestCases.GetTableByScope();
                success = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(JsonConvert.SerializeObject(ex));
            }

            Assert.IsTrue(success);
        }
        [TestMethod]
        [TestCategory("Api Tests")]
        public async Task GetCurrencyBalance()
        {
            bool success = false;
            try
            {
                await ApiUnitTestCases.GetCurrencyBalance();
                success = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(JsonConvert.SerializeObject(ex));
            }

            Assert.IsTrue(success);
        }
        [TestMethod]
        [TestCategory("Api Tests")]
        public async Task GetCurrencyStats()
        {
            bool success = false;
            try
            {
                await ApiUnitTestCases.GetCurrencyStats();
                success = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(JsonConvert.SerializeObject(ex));
            }

            Assert.IsTrue(success);
        }
        [TestMethod]
        [TestCategory("Api Tests")]
        public async Task GetProducers()
        {
            bool success = false;
            try
            {
                await ApiUnitTestCases.GetProducers();
                success = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(JsonConvert.SerializeObject(ex));
            }

            Assert.IsTrue(success);
        }
        [TestMethod]
        [TestCategory("Api Tests")]
        public async Task GetProducerSchedule()
        {
            bool success = false;
            try
            {
                await ApiUnitTestCases.GetProducerSchedule();
                success = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(JsonConvert.SerializeObject(ex));
            }

            Assert.IsTrue(success);
        }
        [TestMethod]
        [TestCategory("Api Tests")]
        public async Task GetScheduledTransactions()
        {
            bool success = false;
            try
            {
                await ApiUnitTestCases.GetScheduledTransactions();
                success = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(JsonConvert.SerializeObject(ex));
            }

            Assert.IsTrue(success);
        }
        [Ignore("Ignored because needs keys to be exposed")]
        [TestMethod]
        [TestCategory("Api Tests")]
        public async Task PushTransaction()
        {
            bool success = false;
            try
            {
                await ApiUnitTestCases.PushTransaction();
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