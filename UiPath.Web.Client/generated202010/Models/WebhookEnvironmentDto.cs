// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UiPath.Web.Client202010.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class WebhookEnvironmentDto
    {
        /// <summary>
        /// Initializes a new instance of the WebhookEnvironmentDto class.
        /// </summary>
        public WebhookEnvironmentDto()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the WebhookEnvironmentDto class.
        /// </summary>
        public WebhookEnvironmentDto(long? id = default(long?), string name = default(string), string description = default(string))
        {
            Id = id;
            Name = name;
            Description = description;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Id")]
        public long? Id { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Name")]
        public string Name { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Description")]
        public string Description { get; private set; }

    }
}