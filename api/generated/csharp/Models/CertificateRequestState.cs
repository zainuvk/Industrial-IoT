// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.IIoT.Opc.Vault.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for CertificateRequestState.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum CertificateRequestState
    {
        [EnumMember(Value = "New")]
        New,
        [EnumMember(Value = "Approved")]
        Approved,
        [EnumMember(Value = "Rejected")]
        Rejected,
        [EnumMember(Value = "Failure")]
        Failure,
        [EnumMember(Value = "Completed")]
        Completed,
        [EnumMember(Value = "Accepted")]
        Accepted
    }
    internal static class CertificateRequestStateEnumExtension
    {
        internal static string ToSerializedValue(this CertificateRequestState? value)
        {
            return value == null ? null : ((CertificateRequestState)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this CertificateRequestState value)
        {
            switch( value )
            {
                case CertificateRequestState.New:
                    return "New";
                case CertificateRequestState.Approved:
                    return "Approved";
                case CertificateRequestState.Rejected:
                    return "Rejected";
                case CertificateRequestState.Failure:
                    return "Failure";
                case CertificateRequestState.Completed:
                    return "Completed";
                case CertificateRequestState.Accepted:
                    return "Accepted";
            }
            return null;
        }

        internal static CertificateRequestState? ParseCertificateRequestState(this string value)
        {
            switch( value )
            {
                case "New":
                    return CertificateRequestState.New;
                case "Approved":
                    return CertificateRequestState.Approved;
                case "Rejected":
                    return CertificateRequestState.Rejected;
                case "Failure":
                    return CertificateRequestState.Failure;
                case "Completed":
                    return CertificateRequestState.Completed;
                case "Accepted":
                    return CertificateRequestState.Accepted;
            }
            return null;
        }
    }
}