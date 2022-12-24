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
    public class EosUnitTests
    {
        EosUnitTestCases EosUnitTestCases;
        public EosUnitTests()
        {
            var eosConfig = new EosConfigurator()
            {
                SignProvider = new DefaultSignProvider("5K57oSZLpfzePvQNpsLS6NfKXLhhRARNU13q6u2ZPQCGHgKLbTA"),

                HttpEndpoint = "https://wax.api.eosnation.io/",
                ChainId = "1064487b3cd1a897ce03ae5b6a865651747e2e152090f99c1d19d44e01aea5a4"
            };
            EosUnitTestCases = new EosUnitTestCases(new Eos(eosConfig));
        }
        [TestMethod]
        [TestCategory("Eos Tests")]
        public async Task GetBlock()
        {
            bool success = false;
            try
            {
                await EosUnitTestCases.GetBlock();
                success = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(JsonConvert.SerializeObject(ex));
            }

            Assert.IsTrue(success);
        }
        [TestMethod]
        [TestCategory("Eos Tests")]
        public async Task GetTableRows()
        {
            bool success = false;
            try
            {
                await EosUnitTestCases.GetTableRows();
                success = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(JsonConvert.SerializeObject(ex));
            }

            Assert.IsTrue(success);
        }
        [TestMethod]
        [TestCategory("Eos Tests")]
        public async Task GetTableRowsGeneric()
        {
            bool success = false;
            try
            {
                await EosUnitTestCases.GetTableRowsGeneric();
                success = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(JsonConvert.SerializeObject(ex));
            }

            Assert.IsTrue(success);
        }
        [TestMethod]
        [TestCategory("Eos Tests")]
        public async Task GetProducers()
        {
            bool success = false;
            try
            {
                await EosUnitTestCases.GetProducers();
                success = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(JsonConvert.SerializeObject(ex));
            }

            Assert.IsTrue(success);
        }
        [TestMethod]
        [TestCategory("Eos Tests")]
        public async Task GetScheduledTransactions()
        {
            bool success = false;
            try
            {
                await EosUnitTestCases.GetScheduledTransactions();
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
        [TestCategory("Eos Tests")]
        public async Task CreateTransactionArrayData()
        {
            bool success = false;
            try
            {
                await EosUnitTestCases.CreateTransactionArrayData();
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
        [TestCategory("Eos Tests")]
        public async Task CreateTransactionActionArrayStructData()
        {
            bool success = false;
            try
            {
                await EosUnitTestCases.CreateTransactionActionArrayStructData();
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
        [TestCategory("Eos Tests")]
        public async Task CreateTransactionAnonymousObjectData()
        {
            bool success = false;
            try
            {
                await EosUnitTestCases.CreateTransactionAnonymousObjectData();
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
        [TestCategory("Eos Tests")]
        public async Task CreateTransaction()
        {
            bool success = false;
            try
            {
                await EosUnitTestCases.CreateTransaction();
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
        [TestCategory("Eos Tests")]
        public async Task CreateNewAccount()
        {
            bool success = false;
            try
            {
                await EosUnitTestCases.CreateNewAccount();
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