using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.InlineArrays;

namespace AssetRipper.Conversions.Lzham.GlobalVariables;

[MangledName("??_C@_0BM@OEANAODI@lzham_malloc?3?5out?5of?5memory?$AA@")]
[DemangledName("\"lzham_malloc: out of memory\"")]
[CleanName("String")]
internal static partial class String_tzftys
{
	public unsafe static InlineArray28_SByte* __pointer;

	public unsafe static InlineArray28_SByte Value
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

	unsafe static String_tzftys()
	{
		__pointer = unchecked((InlineArray28_SByte*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray28_SByte))));
		Value = InlineArrayHelper.Create<InlineArray28_SByte, byte>("lzham_malloc: out of memory\0"u8);
	}
}
