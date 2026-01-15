using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.InlineArrays;

namespace AssetRipper.Conversions.Lzham.GlobalVariables;

[MangledName("??_C@_0BK@OKLBJHCF@find_all_matches_callback?$AA@")]
[DemangledName("\"find_all_matches_callback\"")]
[CleanName("String")]
internal static partial class String_d9apgb
{
	public unsafe static InlineArray26_SByte* __pointer;

	public unsafe static InlineArray26_SByte Value
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

	unsafe static String_d9apgb()
	{
		__pointer = unchecked((InlineArray26_SByte*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray26_SByte))));
		Value = InlineArrayHelper.Create<InlineArray26_SByte, byte>("find_all_matches_callback\0"u8);
	}
}
