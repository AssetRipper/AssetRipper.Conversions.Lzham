using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.InlineArrays;

namespace AssetRipper.Conversions.Lzham.GlobalVariables;

[MangledName("??_C@_0BE@ONIAEEHN@lzham_free?3?5bad?5ptr?$AA@")]
[DemangledName("\"lzham_free: bad ptr\"")]
[CleanName("String")]
internal static partial class String_6jy8jt
{
	public unsafe static InlineArray20_SByte* __pointer;

	public unsafe static InlineArray20_SByte Value
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

	unsafe static String_6jy8jt()
	{
		__pointer = unchecked((InlineArray20_SByte*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray20_SByte))));
		Value = InlineArrayHelper.Create<InlineArray20_SByte, byte>("lzham_free: bad ptr\0"u8);
	}
}
