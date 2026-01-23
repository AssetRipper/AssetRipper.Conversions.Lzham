using System.Runtime.CompilerServices;
using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.InlineArrays;

namespace AssetRipper.Conversions.Lzham.GlobalVariables;

[MangledName("??_C@_0BA@BNBNJMM@Literal?5stats?3?6?$AA@")]
[DemangledName("\"Literal stats:\\n\"")]
[CleanName("String")]
internal static partial class String_xa9qi5
{
	[FixedAddressValueType]
	private static InlineArray16_SByte __value;

	public unsafe static InlineArray16_SByte* Pointer => unchecked((InlineArray16_SByte*)Unsafe.AsPointer(ref __value));

	public static InlineArray16_SByte Value
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

	unsafe static String_xa9qi5()
	{
		Value = InlineArrayHelper.Create<InlineArray16_SByte, byte>("Literal stats:\n\0"u8);
		PointerIndices.Register(Pointer);
	}
}
