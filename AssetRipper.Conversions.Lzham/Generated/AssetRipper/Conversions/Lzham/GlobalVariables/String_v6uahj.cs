using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.InlineArrays;

namespace AssetRipper.Conversions.Lzham.GlobalVariables;

[MangledName("??_C@_0FB@CDGPHCAK@E?3?2repos?2AssetRipper?4Conversions@")]
[DemangledName("\"E:\\\\repos\\\\AssetRipper.Conversions\"...")]
[CleanName("String")]
internal static partial class String_v6uahj
{
	public unsafe static InlineArray81_SByte* __pointer;

	public unsafe static InlineArray81_SByte Value
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

	unsafe static String_v6uahj()
	{
		__pointer = unchecked((InlineArray81_SByte*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray81_SByte))));
		Value = InlineArrayHelper.Create<InlineArray81_SByte, byte>("E:\\repos\\AssetRipper.Conversions.Lzham\\Original\\lzhamcomp\\lzham_lzcomp_state.cpp\0"u8);
	}
}
