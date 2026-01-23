using System.Runtime.CompilerServices;
using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.InlineArrays;

namespace AssetRipper.Conversions.Lzham.GlobalVariables;

[MangledName("??_C@_0BG@HHLIHKBE@?$CB?$CB?$CBRep?50?5full?5len?5?$CFu?6?$AA@")]
[DemangledName("\"!!!Rep 0 full len %u\\n\"")]
[CleanName("String")]
internal static partial class String_3ut65i
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

	unsafe static String_3ut65i()
	{
		Value = InlineArrayHelper.Create<InlineArray22_SByte, byte>("!!!Rep 0 full len %u\n\0"u8);
		PointerIndices.Register(Pointer);
	}
}
