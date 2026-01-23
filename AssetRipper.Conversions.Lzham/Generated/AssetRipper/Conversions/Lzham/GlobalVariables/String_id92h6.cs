using System.Runtime.CompilerServices;
using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.InlineArrays;

namespace AssetRipper.Conversions.Lzham.GlobalVariables;

[MangledName("??_C@_0CK@OOPAAHAE@Total?5matches?3?5?$CFu?0?5truncated?5mat@")]
[DemangledName("\"Total matches: %u, truncated mat\"...")]
[CleanName("String")]
internal static partial class String_id92h6
{
	[FixedAddressValueType]
	private static InlineArray42_SByte __value;

	public unsafe static InlineArray42_SByte* Pointer => unchecked((InlineArray42_SByte*)Unsafe.AsPointer(ref __value));

	public static InlineArray42_SByte Value
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

	unsafe static String_id92h6()
	{
		Value = InlineArrayHelper.Create<InlineArray42_SByte, byte>("Total matches: %u, truncated matches: %u\n\0"u8);
		PointerIndices.Register(Pointer);
	}
}
