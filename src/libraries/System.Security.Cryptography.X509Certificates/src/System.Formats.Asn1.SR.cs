using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net5.System
{
	internal static partial class SR
	{
		/// <summary>Destination is too short.</summary>
		internal static string @Argument_DestinationTooShort => GetResourceString("Argument_DestinationTooShort", @"Destination is too short.");
		/// <summary>ASN.1 Enumerated values only apply to enum types without the [Flags] attribute.</summary>
		internal static string @Argument_EnumeratedValueRequiresNonFlagsEnum => GetResourceString("Argument_EnumeratedValueRequiresNonFlagsEnum", @"ASN.1 Enumerated values only apply to enum types without the [Flags] attribute.");
		/// <summary>Enumerations with a backing type of '{0}' are not supported for ReadEnumeratedValue.</summary>
		internal static string @Argument_EnumeratedValueBackingTypeNotSupported => GetResourceString("Argument_EnumeratedValueBackingTypeNotSupported", @"Enumerations with a backing type of '{0}' are not supported for ReadEnumeratedValue.");
		/// <summary>Named bit list operations require an enum with the [Flags] attribute.</summary>
		internal static string @Argument_NamedBitListRequiresFlagsEnum => GetResourceString("Argument_NamedBitListRequiresFlagsEnum", @"Named bit list operations require an enum with the [Flags] attribute.");
		/// <summary>The destination buffer overlaps the source buffer.</summary>
		internal static string @Argument_SourceOverlapsDestination => GetResourceString("Argument_SourceOverlapsDestination", @"The destination buffer overlaps the source buffer.");
		/// <summary>The specified tag has the Universal TagClass, but the TagValue does not correspond with a known character string type.</summary>
		internal static string @Argument_Tag_NotCharacterString => GetResourceString("Argument_Tag_NotCharacterString", @"The specified tag has the Universal TagClass, but the TagValue does not correspond with a known character string type.");
		/// <summary>An integer value cannot be empty.</summary>
		internal static string @Argument_IntegerCannotBeEmpty => GetResourceString("Argument_IntegerCannotBeEmpty", @"An integer value cannot be empty.");
		/// <summary>The first 9 bits of the integer value all have the same value. Ensure the input is in big-endian byte order and that all redundant leading bytes have been removed.</summary>
		internal static string @Argument_IntegerRedundantByte => GetResourceString("Argument_IntegerRedundantByte", @"The first 9 bits of the integer value all have the same value. Ensure the input is in big-endian byte order and that all redundant leading bytes have been removed.");
		/// <summary>Tags with TagClass Universal must have the appropriate TagValue value for the data type being read or written.</summary>
		internal static string @Argument_UniversalValueIsFixed => GetResourceString("Argument_UniversalValueIsFixed", @"Tags with TagClass Universal must have the appropriate TagValue value for the data type being read or written.");
		/// <summary>Unused bit count must be 0 when the bit string is empty.</summary>
		internal static string @Argument_UnusedBitCountMustBeZero => GetResourceString("Argument_UnusedBitCountMustBeZero", @"Unused bit count must be 0 when the bit string is empty.");
		/// <summary>Unused bit count must be between 0 and 7, inclusive.</summary>
		internal static string @Argument_UnusedBitCountRange => GetResourceString("Argument_UnusedBitCountRange", @"Unused bit count must be between 0 and 7, inclusive.");
		/// <summary>One or more of the bits covered by the provided unusedBitCount value is set. All unused bits must be cleared.</summary>
		internal static string @Argument_UnusedBitWasSet => GetResourceString("Argument_UnusedBitWasSet", @"One or more of the bits covered by the provided unusedBitCount value is set. All unused bits must be cleared.");
		/// <summary>The input to WriteEncodedValue must represent a single encoded value with no trailing data.</summary>
		internal static string @Argument_WriteEncodedValue_OneValueAtATime => GetResourceString("Argument_WriteEncodedValue_OneValueAtATime", @"The input to WriteEncodedValue must represent a single encoded value with no trailing data.");
		/// <summary>Encode cannot be called while a Sequence, Set-Of, or Octet String is still open.</summary>
		internal static string @AsnWriter_EncodeUnbalancedStack => GetResourceString("AsnWriter_EncodeUnbalancedStack", @"Encode cannot be called while a Sequence, Set-Of, or Octet String is still open.");
		/// <summary>Cannot pop the requested tag as it is not currently in progress.</summary>
		internal static string @AsnWriter_PopWrongTag => GetResourceString("AsnWriter_PopWrongTag", @"Cannot pop the requested tag as it is not currently in progress.");
		/// <summary>A constructed tag used a definite length encoding, which is invalid for CER data. The input may be encoded with BER or DER.</summary>
		internal static string @ContentException_CerRequiresIndefiniteLength => GetResourceString("ContentException_CerRequiresIndefiniteLength", @"A constructed tag used a definite length encoding, which is invalid for CER data. The input may be encoded with BER or DER.");
		/// <summary>The encoded value uses a primitive encoding, which is invalid for '{0}' values.</summary>
		internal static string @ContentException_ConstructedEncodingRequired => GetResourceString("ContentException_ConstructedEncodingRequired", @"The encoded value uses a primitive encoding, which is invalid for '{0}' values.");
		/// <summary>The ASN.1 value is invalid.</summary>
		internal static string @ContentException_DefaultMessage => GetResourceString("ContentException_DefaultMessage", @"The ASN.1 value is invalid.");
		/// <summary>The encoded enumerated value is larger than the value size of the '{0}' enum.</summary>
		internal static string @ContentException_EnumeratedValueTooBig => GetResourceString("ContentException_EnumeratedValueTooBig", @"The encoded enumerated value is larger than the value size of the '{0}' enum.");
		/// <summary>The encoded value is not valid under the selected encoding, but it may be valid under the BER or DER encoding.</summary>
		internal static string @ContentException_InvalidUnderCer_TryBerOrDer => GetResourceString("ContentException_InvalidUnderCer_TryBerOrDer", @"The encoded value is not valid under the selected encoding, but it may be valid under the BER or DER encoding.");
		/// <summary>The encoded value is not valid under the selected encoding, but it may be valid under the BER encoding.</summary>
		internal static string @ContentException_InvalidUnderCerOrDer_TryBer => GetResourceString("ContentException_InvalidUnderCerOrDer_TryBer", @"The encoded value is not valid under the selected encoding, but it may be valid under the BER encoding.");
		/// <summary>The encoded value is not valid under the selected encoding, but it may be valid under the BER or CER encoding.</summary>
		internal static string @ContentException_InvalidUnderDer_TryBerOrCer => GetResourceString("ContentException_InvalidUnderDer_TryBerOrCer", @"The encoded value is not valid under the selected encoding, but it may be valid under the BER or CER encoding.");
		/// <summary>The provided data does not represent a valid tag.</summary>
		internal static string @ContentException_InvalidTag => GetResourceString("ContentException_InvalidTag", @"The provided data does not represent a valid tag.");
		/// <summary>The encoded length exceeds the number of bytes remaining in the input buffer.</summary>
		internal static string @ContentException_LengthExceedsPayload => GetResourceString("ContentException_LengthExceedsPayload", @"The encoded length exceeds the number of bytes remaining in the input buffer.");
		/// <summary>The encoded length is not valid under the requested encoding rules, the value may be valid under the BER encoding.</summary>
		internal static string @ContentException_LengthRuleSetConstraint => GetResourceString("ContentException_LengthRuleSetConstraint", @"The encoded length is not valid under the requested encoding rules, the value may be valid under the BER encoding.");
		/// <summary>The encoded length exceeds the maximum supported by this library (Int32.MaxValue).</summary>
		internal static string @ContentException_LengthTooBig => GetResourceString("ContentException_LengthTooBig", @"The encoded length exceeds the maximum supported by this library (Int32.MaxValue).");
		/// <summary>The encoded named bit list value is larger than the value size of the '{0}' enum.</summary>
		internal static string @ContentException_NamedBitListValueTooBig => GetResourceString("ContentException_NamedBitListValueTooBig", @"The encoded named bit list value is larger than the value size of the '{0}' enum.");
		/// <summary>The encoded value uses a constructed encoding, which is invalid for '{0}' values.</summary>
		internal static string @ContentException_PrimitiveEncodingRequired => GetResourceString("ContentException_PrimitiveEncodingRequired", @"The encoded value uses a constructed encoding, which is invalid for '{0}' values.");
		/// <summary>The encoded set is not sorted as required by the current encoding rules. The value may be valid under the BER encoding, or you can ignore the sort validation by specifying skipSortValidation=true.</summary>
		internal static string @ContentException_SetOfNotSorted => GetResourceString("ContentException_SetOfNotSorted", @"The encoded set is not sorted as required by the current encoding rules. The value may be valid under the BER encoding, or you can ignore the sort validation by specifying skipSortValidation=true.");
		/// <summary>The last expected value has been read, but the reader still has pending data. This value may be from a newer schema, or is corrupt.</summary>
		internal static string @ContentException_TooMuchData => GetResourceString("ContentException_TooMuchData", @"The last expected value has been read, but the reader still has pending data. This value may be from a newer schema, or is corrupt.");
		/// <summary>The provided data is tagged with '{0}' class value '{1}', but it should have been '{2}' class value '{3}'.</summary>
		internal static string @ContentException_WrongTag => GetResourceString("ContentException_WrongTag", @"The provided data is tagged with '{0}' class value '{1}', but it should have been '{2}' class value '{3}'.");
	}
}

