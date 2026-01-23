using System.Runtime.CompilerServices;
using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.InlineArrays;

namespace AssetRipper.Conversions.Lzham.GlobalVariables;

[MangledName("??_C@_0BM@OEANAODI@lzham_malloc?3?5out?5of?5memory?$AA@")]
[DemangledName("\"lzham_malloc: out of memory\"")]
[CleanName("String")]
internal static partial class String_tzftys
{
	[FixedAddressValueType]
	private static InlineArray28_SByte __value;

	public unsafe static InlineArray28_SByte* Pointer => unchecked((InlineArray28_SByte*)Unsafe.AsPointer(ref __value));

	public static InlineArray28_SByte Value
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

	unsafe static String_tzftys()
	{
		Value = InlineArrayHelper.Create<InlineArray28_SByte, byte>("lzham_malloc: out of memory\0"u8);
		PointerIndices.Register(Pointer);
	}
}
