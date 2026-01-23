using System.Runtime.CompilerServices;
using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.InlineArrays;

namespace AssetRipper.Conversions.Lzham.GlobalVariables;

[MangledName("??_C@_0BF@EELBENBN@lzham_msize?3?5bad?5ptr?$AA@")]
[DemangledName("\"lzham_msize: bad ptr\"")]
[CleanName("String")]
internal static partial class String_xzs3ub
{
	[FixedAddressValueType]
	private static InlineArray21_SByte __value;

	public unsafe static InlineArray21_SByte* Pointer => unchecked((InlineArray21_SByte*)Unsafe.AsPointer(ref __value));

	public static InlineArray21_SByte Value
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

	unsafe static String_xzs3ub()
	{
		Value = InlineArrayHelper.Create<InlineArray21_SByte, byte>("lzham_msize: bad ptr\0"u8);
		PointerIndices.Register(Pointer);
	}
}
