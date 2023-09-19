using System.Text.Json.Serialization;

namespace FIDO2_Dotnet_Sample.Models
{
    public sealed class AuthenticationExtensionsDevicePublicKeyInputs
    {
        [JsonPropertyName("attestation")]
        public string Attestation { get; set; } = "none";

        [JsonPropertyName("attestationFormats")]
        public string[] AttestationFormats { get; set; } = Array.Empty<string>();
    }
}
