using System.Runtime.CompilerServices;
using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.InlineArrays;

namespace AssetRipper.Conversions.Lzham.GlobalVariables;

[MangledName("??_C@_0DJ@INDGOLEJ@Total?5near?5len2?5matches?3?5?$CFu?0?5tot@")]
[DemangledName("\"Total near len2 matches: %u, tot\"...")]
[CleanName("String")]
internal static partial class String_wgkvsw
{
	[FixedAddressValueType]
	private static InlineArray57_SByte __value;

	public unsafe static InlineArray57_SByte* Pointer => unchecked((InlineArray57_SByte*)Unsafe.AsPointer(ref __value));

	public static InlineArray57_SByte Value
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

	unsafe static String_wgkvsw()
	{
		Value = InlineArrayHelper.Create<InlineArray57_SByte, byte>("Total near len2 matches: %u, total far len2 matches: %u\n\0"u8);
		PointerIndices.Register(Pointer);
	}
}
