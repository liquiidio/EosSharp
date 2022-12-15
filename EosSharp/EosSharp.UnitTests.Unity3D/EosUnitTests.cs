// Auto Generated, do not edit.
using EosSharp.Core;
using EosSharp.Core.Api.v1;
using EosSharp.Core.Providers;
using EosSharp.Unity3D;
using Newtonsoft.Json;
using System;
using System.Threading.Tasks;

namespace EosSharp.UnitTests.Unity3D
{
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
            var eosApi = new EosApi(eosConfig, new HttpHandler());

            EosUnitTestCases = new EosUnitTestCases(new Eos(eosConfig));
        }
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

            if (success)
                Console.WriteLine("Test GetBlock run successfuly.");
            else
                Console.WriteLine("Test GetBlock run failed.");
        }
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

            if (success)
                Console.WriteLine("Test GetTableRows run successfuly.");
            else
                Console.WriteLine("Test GetTableRows run failed.");
        }
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

            if (success)
                Console.WriteLine("Test GetTableRowsGeneric run successfuly.");
            else
                Console.WriteLine("Test GetTableRowsGeneric run failed.");
        }
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

            if (success)
                Console.WriteLine("Test GetProducers run successfuly.");
            else
                Console.WriteLine("Test GetProducers run failed.");
        }
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

            if (success)
                Console.WriteLine("Test GetScheduledTransactions run successfuly.");
            else
                Console.WriteLine("Test GetScheduledTransactions run failed.");
        }
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

            if (success)
                Console.WriteLine("Test CreateTransactionArrayData run successfuly.");
            else
                Console.WriteLine("Test CreateTransactionArrayData run failed.");
        }
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

            if (success)
                Console.WriteLine("Test CreateTransactionActionArrayStructData run successfuly.");
            else
                Console.WriteLine("Test CreateTransactionActionArrayStructData run failed.");
        }
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

            if (success)
                Console.WriteLine("Test CreateTransactionAnonymousObjectData run successfuly.");
            else
                Console.WriteLine("Test CreateTransactionAnonymousObjectData run failed.");
        }
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

            if (success)
                Console.WriteLine("Test CreateTransaction run successfuly.");
            else
                Console.WriteLine("Test CreateTransaction run failed.");
        }
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

            if (success)
                Console.WriteLine("Test CreateNewAccount run successfuly.");
            else
                Console.WriteLine("Test CreateNewAccount run failed.");
        }
        public async Task CreateTransaction2Providers()
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

            if (success)
                Console.WriteLine("Test CreateTransaction2Providers run successfuly.");
            else
                Console.WriteLine("Test CreateTransaction2Providers run failed.");
        }

        public async Task TestAll()
        {
            await GetBlock();
            await GetTableRows();
            await GetTableRowsGeneric();
            await GetProducers();
            await GetScheduledTransactions();
            await CreateTransactionArrayData();
            await CreateTransactionActionArrayStructData();
            await CreateTransactionAnonymousObjectData();
            await CreateTransaction();
            await CreateNewAccount();
            await CreateTransaction2Providers();
        }
    }
}