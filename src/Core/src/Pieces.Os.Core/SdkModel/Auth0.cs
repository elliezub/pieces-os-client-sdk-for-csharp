/*
 * Pieces Isomorphic OpenAPI
 *
 * Endpoints for Assets, Formats, Users, Asset, Format, User.
 *
 * The version of the OpenAPI document: 1.0
 * Contact: tsavo@pieces.app
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Pieces.Os.Core.Client.OpenAPIDateConverter;

namespace Pieces.Os.Core.SdkModel
{
    /// <summary>
    /// An object representing all of the properties that are available within a Auth0 PKCE Flow
    /// </summary>
    [DataContract(Name = "Auth0")]
    public partial class Auth0 : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Auth0" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Auth0() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Auth0" /> class.
        /// </summary>
        /// <param name="identity">identity.</param>
        /// <param name="user">user.</param>
        /// <param name="metadata">metadata.</param>
        /// <param name="domain">The domain of your Auth 0 Service (required).</param>
        /// <param name="varClient">The Client ID for your Auth0 Service (required).</param>
        /// <param name="audience">The Server Audience of your Auth0 Service (required).</param>
        /// <param name="redirects">redirects (required).</param>
        /// <param name="oAuth">oAuth (required).</param>
        /// <param name="varNamespace">An optional namespace parameter to add an additional namespace.</param>
        public Auth0(Auth0Identity identity = default(Auth0Identity), Auth0User user = default(Auth0User), Auth0UserMetadata metadata = default(Auth0UserMetadata), string domain = default(string), string varClient = default(string), string audience = default(string), Auth0Redirects redirects = default(Auth0Redirects), OAuthGroup oAuth = default(OAuthGroup), string varNamespace = default(string))
        {
            // to ensure "domain" is required (not null)
            if (domain == null)
            {
                throw new ArgumentNullException("domain is a required property for Auth0 and cannot be null");
            }
            this.Domain = domain;
            // to ensure "varClient" is required (not null)
            if (varClient == null)
            {
                throw new ArgumentNullException("varClient is a required property for Auth0 and cannot be null");
            }
            this.VarClient = varClient;
            // to ensure "audience" is required (not null)
            if (audience == null)
            {
                throw new ArgumentNullException("audience is a required property for Auth0 and cannot be null");
            }
            this.Audience = audience;
            // to ensure "redirects" is required (not null)
            if (redirects == null)
            {
                throw new ArgumentNullException("redirects is a required property for Auth0 and cannot be null");
            }
            this.Redirects = redirects;
            // to ensure "oAuth" is required (not null)
            if (oAuth == null)
            {
                throw new ArgumentNullException("oAuth is a required property for Auth0 and cannot be null");
            }
            this.OAuth = oAuth;
            this.Identity = identity;
            this.User = user;
            this.Metadata = metadata;
            this.Namespace = varNamespace;
        }

        /// <summary>
        /// Gets or Sets Identity
        /// </summary>
        [DataMember(Name = "identity", EmitDefaultValue = false)]
        public Auth0Identity Identity { get; set; }

        /// <summary>
        /// Gets or Sets User
        /// </summary>
        [DataMember(Name = "user", EmitDefaultValue = false)]
        public Auth0User User { get; set; }

        /// <summary>
        /// Gets or Sets Metadata
        /// </summary>
        [DataMember(Name = "metadata", EmitDefaultValue = false)]
        public Auth0UserMetadata Metadata { get; set; }

        /// <summary>
        /// The domain of your Auth 0 Service
        /// </summary>
        /// <value>The domain of your Auth 0 Service</value>
        [DataMember(Name = "domain", IsRequired = true, EmitDefaultValue = true)]
        public string Domain { get; set; }

        /// <summary>
        /// The Client ID for your Auth0 Service
        /// </summary>
        /// <value>The Client ID for your Auth0 Service</value>
        [DataMember(Name = "client", IsRequired = true, EmitDefaultValue = true)]
        public string VarClient { get; set; }

        /// <summary>
        /// The Server Audience of your Auth0 Service
        /// </summary>
        /// <value>The Server Audience of your Auth0 Service</value>
        [DataMember(Name = "audience", IsRequired = true, EmitDefaultValue = true)]
        public string Audience { get; set; }

        /// <summary>
        /// Gets or Sets Redirects
        /// </summary>
        [DataMember(Name = "redirects", IsRequired = true, EmitDefaultValue = true)]
        public Auth0Redirects Redirects { get; set; }

        /// <summary>
        /// Gets or Sets OAuth
        /// </summary>
        [DataMember(Name = "oAuth", IsRequired = true, EmitDefaultValue = true)]
        public OAuthGroup OAuth { get; set; }

        /// <summary>
        /// An optional namespace parameter to add an additional namespace
        /// </summary>
        /// <value>An optional namespace parameter to add an additional namespace</value>
        [DataMember(Name = "namespace", EmitDefaultValue = false)]
        public string Namespace { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Auth0 {\n");
            sb.Append("  Identity: ").Append(Identity).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  Domain: ").Append(Domain).Append("\n");
            sb.Append("  VarClient: ").Append(VarClient).Append("\n");
            sb.Append("  Audience: ").Append(Audience).Append("\n");
            sb.Append("  Redirects: ").Append(Redirects).Append("\n");
            sb.Append("  OAuth: ").Append(OAuth).Append("\n");
            sb.Append("  Namespace: ").Append(Namespace).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

            /// <summary>
            /// To validate all properties of the instance
            /// </summary>
            /// <param name="validationContext">Validation context</param>
            /// <returns>Validation Result</returns>
            IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
            {
            yield break;
        }
    }

}
