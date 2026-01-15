using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.InlineArrays;

namespace AssetRipper.Conversions.Lzham.GlobalVariables;

[MangledName("??_C@_0BF@EELBENBN@lzham_msize?3?5bad?5ptr?$AA@")]
[DemangledName("\"lzham_msize: bad ptr\"")]
[CleanName("String")]
internal static partial class String_xzs3ub
{
	public unsafe static InlineArray21_SByte* __pointer;

	public unsafe static InlineArray21_SByte Value
	{
		get
		{
			return *__pointer;
		}
		set
		{
			*__pointer = value;
		}
	}

	unsafe static String_xzs3ub()
	{
		__pointer = unchecked((InlineArray21_SByte*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray21_SByte))));
		Value = InlineArrayHelper.Create<InlineArray21_SByte, byte>("lzham_msize: bad ptr\0"u8);
	}
}
