using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Golem.MarketApi.Client.Swagger.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class Proposal {
    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets Properties
    /// </summary>
    [DataMember(Name="properties", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "properties")]
    public Object Properties { get; set; }

    /// <summary>
    /// Gets or Sets Constraints
    /// </summary>
    [DataMember(Name="constraints", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "constraints")]
    public string Constraints { get; set; }

    /// <summary>
    /// Gets or Sets PrevProposalId
    /// </summary>
    [DataMember(Name="prevProposalId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "prevProposalId")]
    public string PrevProposalId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Proposal {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Properties: ").Append(Properties).Append("\n");
      sb.Append("  Constraints: ").Append(Constraints).Append("\n");
      sb.Append("  PrevProposalId: ").Append(PrevProposalId).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}
}
