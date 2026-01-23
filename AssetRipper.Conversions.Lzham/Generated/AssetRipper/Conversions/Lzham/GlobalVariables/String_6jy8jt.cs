using System.Runtime.CompilerServices;
using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.InlineArrays;

namespace AssetRipper.Conversions.Lzham.GlobalVariables;

[MangledName("??_C@_0BE@ONIAEEHN@lzham_free?3?5bad?5ptr?$AA@")]
[DemangledName("\"lzham_free: bad ptr\"")]
[CleanName("String")]
internal static partial class String_6jy8jt
{
	[FixedAddressValueType]
	private static InlineArray20_SByte __value;

	public unsafe static InlineArray20_SByte* Pointer => unchecked((InlineArray20_SByte*)Unsafe.AsPointer(ref __value));

	public static InlineArray20_SByte Value
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

	unsafe static String_6jy8jt()
	{
		Value = InlineArrayHelper.Create<InlineArray20_SByte, byte>("lzham_free: bad ptr\0"u8);
		PointerIndices.Register(Pointer);
	}
}
