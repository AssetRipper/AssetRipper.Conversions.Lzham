using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.InlineArrays;

namespace AssetRipper.Conversions.Lzham.GlobalVariables;

[MangledName("??_C@_0BH@FIGPJHFC@lzham_realloc?3?5bad?5ptr?$AA@")]
[DemangledName("\"lzham_realloc: bad ptr\"")]
[CleanName("String")]
internal static partial class String_b3sjk2
{
	public unsafe static InlineArray23_SByte* __pointer;

	public unsafe static InlineArray23_SByte Value
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

	unsafe static String_b3sjk2()
	{
		__pointer = unchecked((InlineArray23_SByte*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray23_SByte))));
		Value = InlineArrayHelper.Create<InlineArray23_SByte, byte>("lzham_realloc: bad ptr\0"u8);
	}
}
