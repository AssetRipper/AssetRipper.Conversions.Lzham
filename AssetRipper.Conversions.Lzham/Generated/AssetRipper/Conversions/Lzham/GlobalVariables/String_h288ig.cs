using System.Runtime.CompilerServices;
using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.InlineArrays;

namespace AssetRipper.Conversions.Lzham.GlobalVariables;

[MangledName("??_C@_0FI@NLFGLEGK@?5?5pos?3?5?$CFu?0?5state?3?5?$CFu?0?5match_pred@")]
[DemangledName("\"  pos: %u, state: %u, match_pred\"...")]
[CleanName("String")]
internal static partial class String_h288ig
{
	[FixedAddressValueType]
	private static InlineArray88_SByte __value;

	public unsafe static InlineArray88_SByte* Pointer => unchecked((InlineArray88_SByte*)Unsafe.AsPointer(ref __value));

	public static InlineArray88_SByte Value
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

	unsafe static String_h288ig()
	{
		Value = InlineArrayHelper.Create<InlineArray88_SByte, byte>("  pos: %u, state: %u, match_pred: %u, is_match_model_index: %u, is_match: %u, cost: %f\n\0"u8);
		PointerIndices.Register(Pointer);
	}
}
