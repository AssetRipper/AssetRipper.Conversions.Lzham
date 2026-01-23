using System.Runtime.CompilerServices;
using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.InlineArrays;

namespace AssetRipper.Conversions.Lzham.GlobalVariables;

[MangledName("??_C@_0DG@DMCBBBNH@?5?5IsMatch?$CI1?$CJ?3?5?$CFu?0?5Cost?3?5?$CFf?5?$CI?$CFf?5b@")]
[DemangledName("\"  IsMatch(1): %u, Cost: %f (%f b\"...")]
[CleanName("String")]
internal static partial class String_i6ccyf
{
	[FixedAddressValueType]
	private static InlineArray54_SByte __value;

	public unsafe static InlineArray54_SByte* Pointer => unchecked((InlineArray54_SByte*)Unsafe.AsPointer(ref __value));

	public static InlineArray54_SByte Value
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

	unsafe static String_i6ccyf()
	{
		Value = InlineArrayHelper.Create<InlineArray54_SByte, byte>("  IsMatch(1): %u, Cost: %f (%f bytes), Ave. Cost: %f\n\0"u8);
		PointerIndices.Register(Pointer);
	}
}
