using System.Runtime.CompilerServices;
using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.InlineArrays;

namespace AssetRipper.Conversions.Lzham.GlobalVariables;

[MangledName("??_C@_0CC@GKCFHBDP@Max?5full?5match?5len2?5distance?3?5?$CFu@")]
[DemangledName("\"Max full match len2 distance: %u\"...")]
[CleanName("String")]
internal static partial class String_r7bdmb
{
	[FixedAddressValueType]
	private static InlineArray34_SByte __value;

	public unsafe static InlineArray34_SByte* Pointer => unchecked((InlineArray34_SByte*)Unsafe.AsPointer(ref __value));

	public static InlineArray34_SByte Value
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

	unsafe static String_r7bdmb()
	{
		Value = InlineArrayHelper.Create<InlineArray34_SByte, byte>("Max full match len2 distance: %u\n\0"u8);
		PointerIndices.Register(Pointer);
	}
}
