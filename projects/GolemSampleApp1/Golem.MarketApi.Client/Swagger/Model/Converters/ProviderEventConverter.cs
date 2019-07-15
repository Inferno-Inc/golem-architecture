﻿using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace Golem.MarketApi.Client.Swagger.Model.Converters
{
    public class ProviderEventConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return typeof(ProviderEvent).IsAssignableFrom(objectType);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            JObject item = JObject.Load(reader);
            if (item.ContainsKey("eventType") && item["eventType"].Value<string>() == "demand")
            {
                return item.ToObject<DemandEvent>();
            }
            if (item.ContainsKey("eventType") && item["eventType"].Value<string>() == "newAgreement")
            {
                return item.ToObject<NewAgreementEvent>();
            }
            else
            {
                return item.ToObject<ProviderEvent>();
            }
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }
    }
}
