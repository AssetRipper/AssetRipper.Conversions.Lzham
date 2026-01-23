using System.Runtime.CompilerServices;
using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.InlineArrays;

namespace AssetRipper.Conversions.Lzham.GlobalVariables;

[MangledName("??_C@_0BH@FIGPJHFC@lzham_realloc?3?5bad?5ptr?$AA@")]
[DemangledName("\"lzham_realloc: bad ptr\"")]
[CleanName("String")]
internal static partial class String_b3sjk2
{
	[FixedAddressValueType]
	private static InlineArray23_SByte __value;

	public unsafe static InlineArray23_SByte* Pointer => unchecked((InlineArray23_SByte*)Unsafe.AsPointer(ref __value));

	public static InlineArray23_SByte Value
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

	unsafe static String_b3sjk2()
	{
		Value = InlineArrayHelper.Create<InlineArray23_SByte, byte>("lzham_realloc: bad ptr\0"u8);
		PointerIndices.Register(Pointer);
	}
}
