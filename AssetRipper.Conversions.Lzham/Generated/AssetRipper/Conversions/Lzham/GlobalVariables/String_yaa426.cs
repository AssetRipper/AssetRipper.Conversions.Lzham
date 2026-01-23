using System.Runtime.CompilerServices;
using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.InlineArrays;

namespace AssetRipper.Conversions.Lzham.GlobalVariables;

[MangledName("??_C@_0BG@GBDHCKKG@Delta?5literal?5stats?3?6?$AA@")]
[DemangledName("\"Delta literal stats:\\n\"")]
[CleanName("String")]
internal static partial class String_yaa426
{
	[FixedAddressValueType]
	private static InlineArray22_SByte __value;

	public unsafe static InlineArray22_SByte* Pointer => unchecked((InlineArray22_SByte*)Unsafe.AsPointer(ref __value));

	public static InlineArray22_SByte Value
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

	unsafe static String_yaa426()
	{
		Value = InlineArrayHelper.Create<InlineArray22_SByte, byte>("Delta literal stats:\n\0"u8);
		PointerIndices.Register(Pointer);
	}
}
