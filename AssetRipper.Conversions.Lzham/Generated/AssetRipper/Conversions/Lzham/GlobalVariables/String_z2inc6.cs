using System.Runtime.CompilerServices;
using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.InlineArrays;

namespace AssetRipper.Conversions.Lzham.GlobalVariables;

[MangledName("??_C@_0BL@BMCEKBHI@lzham_malloc?3?5size?5too?5big?$AA@")]
[DemangledName("\"lzham_malloc: size too big\"")]
[CleanName("String")]
internal static partial class String_z2inc6
{
	[FixedAddressValueType]
	private static InlineArray27_SByte __value;

	public unsafe static InlineArray27_SByte* Pointer => unchecked((InlineArray27_SByte*)Unsafe.AsPointer(ref __value));

	public static InlineArray27_SByte Value
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

	unsafe static String_z2inc6()
	{
		Value = InlineArrayHelper.Create<InlineArray27_SByte, byte>("lzham_malloc: size too big\0"u8);
		PointerIndices.Register(Pointer);
	}
}
