// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UiPath.Web.Client20204.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class ODataValueInt64
    {
        /// <summary>
        /// Initializes a new instance of the ODataValueInt64 class.
        /// </summary>
        public ODataValueInt64()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ODataValueInt64 class.
        /// </summary>
        public ODataValueInt64(string odatacontext = default(string), long? value = default(long?))
        {
            Odatacontext = odatacontext;
            Value = value;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "@odata.context")]
        public string Odatacontext { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public long? Value { get; set; }

    }
}
