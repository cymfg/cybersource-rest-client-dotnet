/* 
 * CyberSource Merged Spec
 *
 * All CyberSource API specs merged together. These are available at https://developer.cybersource.com/api/reference/api-reference.html
 *
 * OpenAPI spec version: 0.0.1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = CyberSource.Client.SwaggerDateConverter;

namespace CyberSource.Model
{
    /// <summary>
    /// Riskv1authenticationresultsConsumerAuthenticationInformation
    /// </summary>
    [DataContract]
    public partial class Riskv1authenticationresultsConsumerAuthenticationInformation :  IEquatable<Riskv1authenticationresultsConsumerAuthenticationInformation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Riskv1authenticationresultsConsumerAuthenticationInformation" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Riskv1authenticationresultsConsumerAuthenticationInformation() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Riskv1authenticationresultsConsumerAuthenticationInformation" /> class.
        /// </summary>
        /// <param name="AuthenticationTransactionId">Payer authentication transaction identifier passed to link the check enrollment and validate authentication messages. **Note**: Required for Standard integration for enroll service. Required for Hybrid integration for validate service. .</param>
        /// <param name="AuthenticationType">Indicates the type of authentication that will be used to challenge the card holder.  Possible Values:  01 - Static  02 - Dynamic  03 - OOB (Out of Band)  04 - Decoupled **NOTE**:  EMV 3-D Secure version 2.1.0 supports values 01-03.  Version 2.2.0 supports values 01-04.  Decoupled authentication is not supported at this time. .</param>
        /// <param name="EffectiveAuthenticationType">This field describes the type of 3DS transaction flow that took place.  It can be one of three possible flows; CH - Challenge FR - Frictionless FD - Frictionless with delegation, (challenge not generated by the issuer but by the scheme on behalf of the issuer). .</param>
        /// <param name="SignedParesStatusReason">Provides additional information as to why the PAResStatus has a specific value. .</param>
        /// <param name="SignedPares">Payer authentication result (PARes) message returned by the card-issuing bank. If you need to show proof of enrollment checking, you may need to decrypt and parse the string for the information required by the payment card company. For more information, see \&quot;Storing Payer Authentication Data,\&quot; page 160. Important The value is in base64. You must remove all carriage returns and line feeds before adding the PARes to the request.  (required).</param>
        /// <param name="WhiteListStatus">Enables the communication of trusted beneficiary/whitelist status between the ACS, the DS and the 3DS Requestor.  Possible Values:  Y - 3DS Requestor is whitelisted by cardholder  N - 3DS Requestor is not whitelisted by cardholder .</param>
        public Riskv1authenticationresultsConsumerAuthenticationInformation(string AuthenticationTransactionId = default(string), string AuthenticationType = default(string), string EffectiveAuthenticationType = default(string), string SignedParesStatusReason = default(string), string SignedPares = default(string), string WhiteListStatus = default(string))
        {
            // to ensure "SignedPares" is required (not null)
            if (SignedPares == null)
            {
                throw new InvalidDataException("SignedPares is a required property for Riskv1authenticationresultsConsumerAuthenticationInformation and cannot be null");
            }
            else
            {
                this.SignedPares = SignedPares;
            }
            this.AuthenticationTransactionId = AuthenticationTransactionId;
            this.AuthenticationType = AuthenticationType;
            this.EffectiveAuthenticationType = EffectiveAuthenticationType;
            this.SignedParesStatusReason = SignedParesStatusReason;
            this.WhiteListStatus = WhiteListStatus;
        }
        
        /// <summary>
        /// Payer authentication transaction identifier passed to link the check enrollment and validate authentication messages. **Note**: Required for Standard integration for enroll service. Required for Hybrid integration for validate service. 
        /// </summary>
        /// <value>Payer authentication transaction identifier passed to link the check enrollment and validate authentication messages. **Note**: Required for Standard integration for enroll service. Required for Hybrid integration for validate service. </value>
        [DataMember(Name="authenticationTransactionId", EmitDefaultValue=false)]
        public string AuthenticationTransactionId { get; set; }

        /// <summary>
        /// Indicates the type of authentication that will be used to challenge the card holder.  Possible Values:  01 - Static  02 - Dynamic  03 - OOB (Out of Band)  04 - Decoupled **NOTE**:  EMV 3-D Secure version 2.1.0 supports values 01-03.  Version 2.2.0 supports values 01-04.  Decoupled authentication is not supported at this time. 
        /// </summary>
        /// <value>Indicates the type of authentication that will be used to challenge the card holder.  Possible Values:  01 - Static  02 - Dynamic  03 - OOB (Out of Band)  04 - Decoupled **NOTE**:  EMV 3-D Secure version 2.1.0 supports values 01-03.  Version 2.2.0 supports values 01-04.  Decoupled authentication is not supported at this time. </value>
        [DataMember(Name="authenticationType", EmitDefaultValue=false)]
        public string AuthenticationType { get; set; }

        /// <summary>
        /// This field describes the type of 3DS transaction flow that took place.  It can be one of three possible flows; CH - Challenge FR - Frictionless FD - Frictionless with delegation, (challenge not generated by the issuer but by the scheme on behalf of the issuer). 
        /// </summary>
        /// <value>This field describes the type of 3DS transaction flow that took place.  It can be one of three possible flows; CH - Challenge FR - Frictionless FD - Frictionless with delegation, (challenge not generated by the issuer but by the scheme on behalf of the issuer). </value>
        [DataMember(Name="effectiveAuthenticationType", EmitDefaultValue=false)]
        public string EffectiveAuthenticationType { get; set; }

        /// <summary>
        /// Provides additional information as to why the PAResStatus has a specific value. 
        /// </summary>
        /// <value>Provides additional information as to why the PAResStatus has a specific value. </value>
        [DataMember(Name="signedParesStatusReason", EmitDefaultValue=false)]
        public string SignedParesStatusReason { get; set; }

        /// <summary>
        /// Payer authentication result (PARes) message returned by the card-issuing bank. If you need to show proof of enrollment checking, you may need to decrypt and parse the string for the information required by the payment card company. For more information, see \&quot;Storing Payer Authentication Data,\&quot; page 160. Important The value is in base64. You must remove all carriage returns and line feeds before adding the PARes to the request. 
        /// </summary>
        /// <value>Payer authentication result (PARes) message returned by the card-issuing bank. If you need to show proof of enrollment checking, you may need to decrypt and parse the string for the information required by the payment card company. For more information, see \&quot;Storing Payer Authentication Data,\&quot; page 160. Important The value is in base64. You must remove all carriage returns and line feeds before adding the PARes to the request. </value>
        [DataMember(Name="signedPares", EmitDefaultValue=false)]
        public string SignedPares { get; set; }

        /// <summary>
        /// Enables the communication of trusted beneficiary/whitelist status between the ACS, the DS and the 3DS Requestor.  Possible Values:  Y - 3DS Requestor is whitelisted by cardholder  N - 3DS Requestor is not whitelisted by cardholder 
        /// </summary>
        /// <value>Enables the communication of trusted beneficiary/whitelist status between the ACS, the DS and the 3DS Requestor.  Possible Values:  Y - 3DS Requestor is whitelisted by cardholder  N - 3DS Requestor is not whitelisted by cardholder </value>
        [DataMember(Name="whiteListStatus", EmitDefaultValue=false)]
        public string WhiteListStatus { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Riskv1authenticationresultsConsumerAuthenticationInformation {\n");
            sb.Append("  AuthenticationTransactionId: ").Append(AuthenticationTransactionId).Append("\n");
            sb.Append("  AuthenticationType: ").Append(AuthenticationType).Append("\n");
            sb.Append("  EffectiveAuthenticationType: ").Append(EffectiveAuthenticationType).Append("\n");
            sb.Append("  SignedParesStatusReason: ").Append(SignedParesStatusReason).Append("\n");
            sb.Append("  SignedPares: ").Append(SignedPares).Append("\n");
            sb.Append("  WhiteListStatus: ").Append(WhiteListStatus).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as Riskv1authenticationresultsConsumerAuthenticationInformation);
        }

        /// <summary>
        /// Returns true if Riskv1authenticationresultsConsumerAuthenticationInformation instances are equal
        /// </summary>
        /// <param name="other">Instance of Riskv1authenticationresultsConsumerAuthenticationInformation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Riskv1authenticationresultsConsumerAuthenticationInformation other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AuthenticationTransactionId == other.AuthenticationTransactionId ||
                    this.AuthenticationTransactionId != null &&
                    this.AuthenticationTransactionId.Equals(other.AuthenticationTransactionId)
                ) && 
                (
                    this.AuthenticationType == other.AuthenticationType ||
                    this.AuthenticationType != null &&
                    this.AuthenticationType.Equals(other.AuthenticationType)
                ) && 
                (
                    this.EffectiveAuthenticationType == other.EffectiveAuthenticationType ||
                    this.EffectiveAuthenticationType != null &&
                    this.EffectiveAuthenticationType.Equals(other.EffectiveAuthenticationType)
                ) && 
                (
                    this.SignedParesStatusReason == other.SignedParesStatusReason ||
                    this.SignedParesStatusReason != null &&
                    this.SignedParesStatusReason.Equals(other.SignedParesStatusReason)
                ) && 
                (
                    this.SignedPares == other.SignedPares ||
                    this.SignedPares != null &&
                    this.SignedPares.Equals(other.SignedPares)
                ) && 
                (
                    this.WhiteListStatus == other.WhiteListStatus ||
                    this.WhiteListStatus != null &&
                    this.WhiteListStatus.Equals(other.WhiteListStatus)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.AuthenticationTransactionId != null)
                    hash = hash * 59 + this.AuthenticationTransactionId.GetHashCode();
                if (this.AuthenticationType != null)
                    hash = hash * 59 + this.AuthenticationType.GetHashCode();
                if (this.EffectiveAuthenticationType != null)
                    hash = hash * 59 + this.EffectiveAuthenticationType.GetHashCode();
                if (this.SignedParesStatusReason != null)
                    hash = hash * 59 + this.SignedParesStatusReason.GetHashCode();
                if (this.SignedPares != null)
                    hash = hash * 59 + this.SignedPares.GetHashCode();
                if (this.WhiteListStatus != null)
                    hash = hash * 59 + this.WhiteListStatus.GetHashCode();
                return hash;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            // AuthenticationTransactionId (string) maxLength
            if(this.AuthenticationTransactionId != null && this.AuthenticationTransactionId.Length >= 20)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AuthenticationTransactionId, length must be less than or equal to 20.", new [] { "AuthenticationTransactionId" });
            }

            // AuthenticationType (string) maxLength
            if(this.AuthenticationType != null && this.AuthenticationType.Length >= 2)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AuthenticationType, length must be less than or equal to 2.", new [] { "AuthenticationType" });
            }

            // EffectiveAuthenticationType (string) maxLength
            if(this.EffectiveAuthenticationType != null && this.EffectiveAuthenticationType.Length >= 2)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for EffectiveAuthenticationType, length must be less than or equal to 2.", new [] { "EffectiveAuthenticationType" });
            }

            // SignedParesStatusReason (string) maxLength
            if(this.SignedParesStatusReason != null && this.SignedParesStatusReason.Length >= 2)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SignedParesStatusReason, length must be less than or equal to 2.", new [] { "SignedParesStatusReason" });
            }

            // WhiteListStatus (string) maxLength
            if(this.WhiteListStatus != null && this.WhiteListStatus.Length >= 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for WhiteListStatus, length must be less than or equal to 1.", new [] { "WhiteListStatus" });
            }

            yield break;
        }
    }

}
