<div align="center">
 <img src="https://avatars.githubusercontent.com/u/82725791?s=200&v=4" align="center"
     alt="Liquiid logo" width="280" height="300">
</div>

---
**_ACTIVELY MAINTAINED Version of Eos-Sharp(originally developed by SCATTER)_**
---

# EOS Sharp
C# client library for EOSIO blockchains. The library is based on https://github.com/EOSIO/eosjs and MIT licensed.

# Installation

**_Requires Unity 2019.1+ with .NET 4.x+ Runtime_**

This package can be included into your project by either:

 1. Installing the package via Unity's Package Manager (UPM) in the editor (recommended).
 2. Importing the .unitypackage which you can download.
 3. Manually add the files in this repo.
 4. Installing it via NuGet.
 
---

### 1. Installing via Unity Package Manager (UPM).
In your Unity project:
 1. Open the Package Manager Window/Tab

    ![image](https://user-images.githubusercontent.com/74650011/208429048-37e2277c-3e10-4794-97e7-3ec87f55f8c9.png)

 2. Click on + icon and then click on "Add Package From Git URL"

    ![image](https://user-images.githubusercontent.com/74650011/208429298-76fe1101-95f3-4ab0-bbd5-f0a32a1cc652.png)

 3. Enter URL:  `https://github.com/liquiidio/EosSharp-Private.git#upm`
   
---
### 2. Importing the Unity Package.
Download the UnityPackage . Then in your Unity project:

 1. Open up the import a custom package window
    
    ![image](https://user-images.githubusercontent.com/74650011/208430044-caf91dd9-111e-4224-8441-95d116dbec3b.png)

 2. Navigate to where you downloaded the file and open it.
    
    ![image](https://user-images.githubusercontent.com/86061433/217219439-2fcba745-7173-4e96-8bcb-65810cedca6e.jpg)
 
 3. Check all the relevant files needed (if this is a first time import, just select ALL) and click on import.
           
     ![image](https://user-images.githubusercontent.com/86061433/217219778-19db7558-dcc1-4633-9966-085cf2b2724f.jpg)
     
---

### 3. Install manually.
Download this project there here . Then in your Unity project:

 1. Copy the sources from `EosSharp` into your `Assets` directory.

---
### 4. Install via NuGet (for Standard .NET users only - No Unity3D)

#### .NET CLI

`> dotnet add package Liquiid.io.EosSharp --version 1.0.1`

#### Package Manager

`PM> Install-Package Liquiid.io.EosSharp -Version 1.0.1`

---

# Usage

## Configuration

In order to interact with eos blockchain you need to create a new instance of the **Eos** class with a **EosConfigurator**.

Example:

```csharp
Eos eos = new Eos(new EosConfigurator()
{    
    HttpEndpoint = "https://nodes.eos42.io", //Mainnet
    ChainId = "aca376f206b8fc25a6ed44dbdc66547c36c6c33e3a119ffbeaef943642f0e906",
    ExpireSeconds = 60,
    SignProvider = new DefaultSignProvider("myprivatekey")
});
```
* HttpEndpoint - http or https location of a nodeosd server providing a chain API.
* ChainId - unique ID for the blockchain you're connecting to. If no ChainId is provided it will get from the get_info API call.
* ExpireInSeconds - number of seconds before the transaction will expire. The time is based on the nodeosd's clock. An unexpired transaction that may have had an error is a liability until the expiration is reached, this time should be brief.
* SignProvider - signature implementation to handle available keys and signing transactions. Use the DefaultSignProvider with a privateKey to sign transactions inside the lib.

#### Api read methods

- **GetInfo** call
```csharp
var result = await eos.GetInfo();
```
Returns:
```csharp
class GetInfoResponse 
{ 
    string server_version;
    string chain_id;
    UInt32 head_block_num;
    UInt32 last_irreversible_block_num;
    string last_irreversible_block_id;
    string head_block_id;
    DateTime head_block_time;
    string head_block_producer;
    string virtual_block_cpu_limit;
    string virtual_block_net_limit;
    string block_cpu_limit;
    string block_net_limit;
}
```

- **GetAccount** call
```csharp
var result = await eos.GetAccount("myaccountname");
```
Returns:
```csharp
class GetAccountResponse
{
    string account_name;
    UInt32 head_block_num;
    DateTime head_block_time;
    bool privileged;
    DateTime last_code_update;
    DateTime created;
    Int64 ram_quota;
    Int64 net_weight;
    Int64 cpu_weight; 
    Resource net_limit; 
    Resource cpu_limit;
    UInt64 ram_usage;
    List<Permission> permissions;
    RefundRequest refund_request;
    SelfDelegatedBandwidth self_delegated_bandwidth;
    TotalResources total_resources;
    VoterInfo voter_info;
}
```

- **GetBlock** call
```csharp
var result = await eos.GetBlock("blockIdOrNumber");
```
Returns:
```csharp
class GetBlockResponse
{
    DateTime timestamp;
    string producer;
    UInt32 confirmed;
    string previous;
    string transaction_mroot;
    string action_mroot;
    UInt32 schedule_version;
    Schedule new_producers;
    List<Extension> block_extensions;
    List<Extension> header_extensions;
    string producer_signature;
    List<TransactionReceipt> transactions;
    string id;
    UInt32 block_num;
    UInt32 ref_block_prefix;
}
```

- **GetTableRows** call
    * Json
    * Code - accountName of the contract to search for table rows
    * Scope - scope text segmenting the table set
    * Table - table name 
    * TableKey - unused so far?
    * LowerBound - lower bound for the selected index value
    * UpperBound - upper bound for the selected index value
    * KeyType - Type of the index choosen, ex: i64
    * Limit
    * IndexPosition - 1 - primary (first), 2 - secondary index (in order defined by multi_index), 3 - third index, etc
    * EncodeType - dec, hex
	* Reverse - reverse result order
	* ShowPayer - show ram payer

```csharp
var result = await eos.GetTableRows(new GetTableRowsRequest() {
    json = true,
    code = "eosio.token",
    scope = "EOS",
    table = "stat"
});
```

Returns:

```csharp
class GetTableRowsResponse
{
    List<object> rows
    bool?        more
}
```

Using generic type

```csharp
/*JsonProperty helps map the fields from the api*/
public class Stat
{
    public string issuer { get; set; }
    public string max_supply { get; set; }
    public string supply { get; set; }
}

var result = await Eos.GetTableRows<Stat>(new GetTableRowsRequest()
{
    json = true,
    code = "eosio.token",
    scope = "EOS",
    table = "stat"
});
```

Returns:

```csharp
class GetTableRowsResponse<Stat>
{
    List<Stat> rows
    bool?      more
}
```

- **GetTableByScope** call
    * Code - accountName of the contract to search for tables
    * Table - table name to filter
    * LowerBound - lower bound of scope, optional
    * UpperBound - upper bound of scope, optional
    * Limit
    * Reverse - reverse result order

```csharp
var result = await eos.GetTableByScope(new GetTableByScopeRequest() {
   code = "eosio.token",
   table = "accounts"
});
```

Returns:

```csharp
class GetTableByScopeResponse
{
    List<TableByScopeResultRow> rows
    string more
}

class TableByScopeResultRow
{
    string code;
    string scope;
    string table;
    string payer;
    UInt32? count;
}
```

- **GetActions** call
    * accountName - accountName to get actions history
    * pos - a absolute sequence positon -1 is the end/last action
    * offset - the number of actions relative to pos, negative numbers return [pos-offset,pos), positive numbers return [pos,pos+offset)

```csharp
var result = await eos.GetActions("myaccountname", 0, 10);
```

Returns:

```csharp
class GetActionsResponse
{
    List<GlobalAction> actions;
    UInt32 last_irreversible_block;
    bool time_limit_exceeded_error;
}
```

#### Create Transaction

**NOTE: using anonymous objects and / or properties as action data is not supported on WEBGL Unity exports
Use data as dictionary or strongly typed objects with fields.**

```csharp
var result = await eos.CreateTransaction(new Transaction()
{
    actions = new List<Api.v1.Action>()
    {
        new Api.v1.Action()
        {
            account = "eosio.token",
            authorization = new List<PermissionLevel>()
            {
                new PermissionLevel() {actor = "tester112345", permission = "active" }
            },
            name = "transfer",
            data = new { from = "tester112345", to = "tester212345", quantity = "0.0001 EOS", memo = "hello crypto world!" }
        }
    }
});
```

Data can also be a Dictionary with key as string. The dictionary value can be any object with nested Dictionaries

```csharp
var result = await eos.CreateTransaction(new Transaction()
{
    actions = new List<Api.v1.Action>()
    {
        new Api.v1.Action()
        {
            account = "eosio.token",
            authorization = new List<PermissionLevel>()
            {
                new PermissionLevel() {actor = "tester112345", permission = "active" }
            },
            name = "transfer",
            data = new Dictionary<string, string>()
            {
                { "from", "tester112345" },
                { "to", "tester212345" },
                { "quantity", "0.0001 EOS" },
                { "memo", "hello crypto world!" }
            }
        }
    }
});
```

Returns the transactionId
#### Custom SignProvider

Is also possible to implement your own **ISignProvider** to customize how the signatures and key handling is done.

Example:

```csharp
/// <summary>
/// Signature provider implementation that uses a private server to hold keys
/// </summary>
class SuperSecretSignProvider : ISignProvider
{
   /// <summary>
   /// Get available public keys from signature provider server
   /// </summary>
   /// <returns>List of public keys</returns>
   public async Task<IEnumerable<string>> GetAvailableKeys()
   {
        var result = await HttpHelper.GetJsonAsync<SecretResponse>("https://supersecretserver.com/get_available_keys");
        return result.Keys;
   }
   
   /// <summary>
   /// Sign bytes using the signature provider server
   /// </summary>
   /// <param name="chainId">EOSIO Chain id</param>
   /// <param name="requiredKeys">required public keys for signing this bytes</param>
   /// <param name="signBytes">signature bytes</param>
   /// <param name="abiNames">abi contract names to get abi information from</param>
   /// <returns>List of signatures per required keys</returns>
   public async Task<IEnumerable<string>> Sign(string chainId, List<string> requiredKeys, byte[] signBytes)
   {
        var result = await HttpHelper.PostJsonAsync<SecretSignResponse>("https://supersecretserver.com/sign", new SecretRequest {
            chainId = chainId,
            RequiredKeys = requiredKeys,
            Data = signBytes
        });
        return result.Signatures;
   }
}

// create new Eos client instance using your custom signature provider
Eos eos = new Eos(new EosConfigurator()
{
    SignProvider = new SuperSecretSignProvider(),
    HttpEndpoint = "https://nodes.eos42.io", //Mainnet
    ChainId = "aca376f206b8fc25a6ed44dbdc66547c36c6c33e3a119ffbeaef943642f0e906"
});
```
#### CombinedSignersProvider

Is also possible to combine multiple signature providers to complete all the signatures for a transaction

Example:

```csharp
Eos eos = new Eos(new EosConfigurator()
{    
    HttpEndpoint = "https://nodes.eos42.io", //Mainnet
    ChainId = "aca376f206b8fc25a6ed44dbdc66547c36c6c33e3a119ffbeaef943642f0e906",
    ExpireSeconds = 60,
    SignProvider = new CombinedSignersProvider(new List<ISignProvider>() {
       new SuperSecretSignProvider(),
       new DefaultSignProvider("myprivatekey")
    }),
});
```

