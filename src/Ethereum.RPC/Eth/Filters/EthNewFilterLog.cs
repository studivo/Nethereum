using System.Numerics;
using Newtonsoft.Json;

namespace Ethereum.RPC.Eth
{
    public class EthNewFilterLog
    {

        /// <summary>
        /// TAG - pending when the log is pending. mined if log is already mined..
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        ///  QUANTITY - integer of the log index position in the block. null when its pending log.
        /// </summary>
        [JsonProperty(PropertyName = "logIndex")]
        public string LogIndexHex { get; set; }

        /// <summary>
        /// DATA, 32 Bytes - hash of the transactions this log was created from. null when its pending log.DATA, 32 Bytes - hash of the transaction.
        /// </summary>
        [JsonProperty(PropertyName = "transactionHash")]
        public string TransactionHash { get; set; }

        /// <summary>
        /// QUANTITY - integer of the transactions index position log was created from. null when its pending log.
        /// </summary>
        [JsonProperty(PropertyName = "transactionIndex")]
        public string TransactionIndexHex { get; set; }

        /// <summary>
        /// DATA, 32 Bytes - hash of the block where this log was in. null when its pending. null when its pending log.
        /// </summary>
        [JsonProperty(PropertyName = "blockHash")]
        public string BlockHashHex { get; set; }

        /// <summary>
        /// QUANTITY - the block number where this log was in. null when its pending. null when its pending log.
        /// </summary>
        [JsonProperty(PropertyName = "blockNumber")]
        public string BlockNumberHex { get; set; }

        /// <summary>
        /// DATA, 20 Bytes - address from which this log originated.
        /// </summary>
        [JsonProperty(PropertyName = "address")]
        public string Address { get; set; }

        /// <summary>
        /// DATA - contains one or more 32 Bytes non-indexed arguments of the log.
        /// </summary>
        [JsonProperty(PropertyName = "data")]
        public string Data { get; set; }

        ///<summary>
        /// Array of DATA - Array of 0 to 4 32 Bytes DATA of indexed log arguments. 
        /// (In solidity: The first topic is the hash of the signature of the event (e.g. Deposit(address,bytes32,uint256)), 
        /// except you declared the event with the anonymous specifier.)
        /// </summary>
        [JsonProperty(PropertyName = "topics")]
        public dynamic[] Topics { get; set; }

        /// <summary>
        /// QUANTITY - integer of the transactions index position in the block.
        /// </summary>
        public BigInteger? TransactionIndex => TransactionIndexHex?.ConvertBigEndianHexToBigInteger();

        ///// <summary>
        ///// DATA, 32 Bytes - hash of the block where this transaction was in.
        ///// </summary>

        public BigInteger? BlockHash => BlockHashHex?.ConvertBigEndianHexToBigInteger();

        ///// <summary>
        ///// QUANTITY - block number where this transaction was in.
        ///// </summary>

        public BigInteger? BlockNumber => BlockNumberHex?.ConvertBigEndianHexToBigInteger();

    }
}