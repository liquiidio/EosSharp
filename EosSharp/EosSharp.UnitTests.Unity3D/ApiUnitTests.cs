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

            if (success)
                Console.WriteLine("Test GetInfo run successfuly.");
            else
                Console.WriteLine("Test GetInfo run failed.");
        }
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

            if (success)
                Console.WriteLine("Test GetAccount run successfuly.");
            else
                Console.WriteLine("Test GetAccount run failed.");
        }
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

            if (success)
                Console.WriteLine("Test GetCode run successfuly.");
            else
                Console.WriteLine("Test GetCode run failed.");
        }
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

            if (success)
                Console.WriteLine("Test GetAbi run successfuly.");
            else
                Console.WriteLine("Test GetAbi run failed.");
        }
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

            if (success)
                Console.WriteLine("Test GetRawCodeAndAbi run successfuly.");
            else
                Console.WriteLine("Test GetRawCodeAndAbi run failed.");
        }
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

            if (success)
                Console.WriteLine("Test GetRawAbi run successfuly.");
            else
                Console.WriteLine("Test GetRawAbi run failed.");
        }
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

            if (success)
                Console.WriteLine("Test AbiJsonToBin run successfuly.");
            else
                Console.WriteLine("Test AbiJsonToBin run failed.");
        }
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

            if (success)
                Console.WriteLine("Test AbiBinToJson run successfuly.");
            else
                Console.WriteLine("Test AbiBinToJson run failed.");
        }
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

            if (success)
                Console.WriteLine("Test GetRequiredKeys run successfuly.");
            else
                Console.WriteLine("Test GetRequiredKeys run failed.");
        }
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

            if (success)
                Console.WriteLine("Test GetBlock run successfuly.");
            else
                Console.WriteLine("Test GetBlock run failed.");
        }
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

            if (success)
                Console.WriteLine("Test GetBlockHeaderState run successfuly.");
            else
                Console.WriteLine("Test GetBlockHeaderState run failed.");
        }
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

            if (success)
                Console.WriteLine("Test GetTableRows run successfuly.");
            else
                Console.WriteLine("Test GetTableRows run failed.");
        }
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

            if (success)
                Console.WriteLine("Test GetTableByScope run successfuly.");
            else
                Console.WriteLine("Test GetTableByScope run failed.");
        }
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

            if (success)
                Console.WriteLine("Test GetCurrencyBalance run successfuly.");
            else
                Console.WriteLine("Test GetCurrencyBalance run failed.");
        }
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

            if (success)
                Console.WriteLine("Test GetCurrencyStats run successfuly.");
            else
                Console.WriteLine("Test GetCurrencyStats run failed.");
        }
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

            if (success)
                Console.WriteLine("Test GetProducers run successfuly.");
            else
                Console.WriteLine("Test GetProducers run failed.");
        }
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

            if (success)
                Console.WriteLine("Test GetProducerSchedule run successfuly.");
            else
                Console.WriteLine("Test GetProducerSchedule run failed.");
        }
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

            if (success)
                Console.WriteLine("Test GetScheduledTransactions run successfuly.");
            else
                Console.WriteLine("Test GetScheduledTransactions run failed.");
        }
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

            if (success)
                Console.WriteLine("Test PushTransaction run successfuly.");
            else
                Console.WriteLine("Test PushTransaction run failed.");
        }

        public async Task TestAll()
        {
            await GetInfo();
            await GetAccount();
            await GetCode();
            await GetAbi();
            await GetRawCodeAndAbi();
            await GetRawAbi();
            await AbiJsonToBin();
            await AbiBinToJson();
            await GetRequiredKeys();
            await GetBlock();
            await GetBlockHeaderState();
            await GetTableRows();
            await GetTableByScope();
            await GetCurrencyBalance();
            await GetCurrencyStats();
            await GetProducers();
            await GetProducerSchedule();
            await GetScheduledTransactions();
            await PushTransaction();
        }
    }
}