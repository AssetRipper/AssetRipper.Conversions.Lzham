using System.Runtime.CompilerServices;
using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.InlineArrays;

namespace AssetRipper.Conversions.Lzham.GlobalVariables;

[MangledName("??_C@_0BD@LCHDLMCB@Rep0?5Len2?$CL?5stats?3?6?$AA@")]
[DemangledName("\"Rep0 Len2+ stats:\\n\"")]
[CleanName("String")]
internal static partial class String_dpnkqw
{
	[FixedAddressValueType]
	private static InlineArray19_SByte __value;

	public unsafe static InlineArray19_SByte* Pointer => unchecked((InlineArray19_SByte*)Unsafe.AsPointer(ref __value));

	public static InlineArray19_SByte Value
	{
		get
		{
			return __value;
		}
		set
		{
			__value = value;
		}
	}

	unsafe static String_dpnkqw()
	{
		Value = InlineArrayHelper.Create<InlineArray19_SByte, byte>("Rep0 Len2+ stats:\n\0"u8);
		PointerIndices.Register(Pointer);
	}
}
