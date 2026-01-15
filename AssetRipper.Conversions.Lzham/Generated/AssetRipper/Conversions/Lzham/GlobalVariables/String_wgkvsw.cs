using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.InlineArrays;

namespace AssetRipper.Conversions.Lzham.GlobalVariables;

[MangledName("??_C@_0DJ@INDGOLEJ@Total?5near?5len2?5matches?3?5?$CFu?0?5tot@")]
[DemangledName("\"Total near len2 matches: %u, tot\"...")]
[CleanName("String")]
internal static partial class String_wgkvsw
{
	public unsafe static InlineArray57_SByte* __pointer;

	public unsafe static InlineArray57_SByte Value
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

	unsafe static String_wgkvsw()
	{
		__pointer = unchecked((InlineArray57_SByte*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray57_SByte))));
		Value = InlineArrayHelper.Create<InlineArray57_SByte, byte>("Total near len2 matches: %u, total far len2 matches: %u\n\0"u8);
	}
}
