// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Peering.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The essential information related to the peer's ASN.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class PeerAsn : Resource
    {
        /// <summary>
        /// Initializes a new instance of the PeerAsn class.
        /// </summary>
        public PeerAsn()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PeerAsn class.
        /// </summary>
        /// <param name="name">The name of the resource.</param>
        /// <param name="id">The ID of the resource.</param>
        /// <param name="type">The type of the resource.</param>
        /// <param name="peerAsnProperty">The Autonomous System Number (ASN) of
        /// the peer.</param>
        /// <param name="peerContactInfo">The contact information of the
        /// peer.</param>
        /// <param name="peerName">The name of the peer.</param>
        /// <param name="validationState">The validation state of the ASN
        /// associated with the peer. Possible values include: 'None',
        /// 'Pending', 'Approved', 'Failed'</param>
        public PeerAsn(string name = default(string), string id = default(string), string type = default(string), int? peerAsnProperty = default(int?), ContactInfo peerContactInfo = default(ContactInfo), string peerName = default(string), string validationState = default(string))
            : base(name, id, type)
        {
            PeerAsnProperty = peerAsnProperty;
            PeerContactInfo = peerContactInfo;
            PeerName = peerName;
            ValidationState = validationState;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the Autonomous System Number (ASN) of the peer.
        /// </summary>
        [JsonProperty(PropertyName = "properties.peerAsn")]
        public int? PeerAsnProperty { get; set; }

        /// <summary>
        /// Gets or sets the contact information of the peer.
        /// </summary>
        [JsonProperty(PropertyName = "properties.peerContactInfo")]
        public ContactInfo PeerContactInfo { get; set; }

        /// <summary>
        /// Gets or sets the name of the peer.
        /// </summary>
        [JsonProperty(PropertyName = "properties.peerName")]
        public string PeerName { get; set; }

        /// <summary>
        /// Gets or sets the validation state of the ASN associated with the
        /// peer. Possible values include: 'None', 'Pending', 'Approved',
        /// 'Failed'
        /// </summary>
        [JsonProperty(PropertyName = "properties.validationState")]
        public string ValidationState { get; set; }

    }
}
