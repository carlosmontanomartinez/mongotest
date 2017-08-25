using System;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;

namespace MongoTest.Data.Models
{
    public class MongoModel
    {
        [BsonElement]
        [JsonProperty("brand")]
        public string Brand
        {
            get;
            set;
        }
		[BsonElement]
		[JsonProperty("sub_brand")]
        public string SubBrand
        {
            get;
            set;
        }
		[BsonElement]
		[JsonProperty("year")]
        public string Year
        {
            get;
            set;
        }
		[BsonElement]
		[JsonProperty("color")]
        public string Color
        {
            get;
            set;
        }
		[BsonElement]
		[JsonProperty("gama")]
        public string Gama
        {
            get;
            set;
        }
		[BsonElement]
		[JsonProperty("name")]
        public string Name
        {
            get;
            set;
        }
    }
}
