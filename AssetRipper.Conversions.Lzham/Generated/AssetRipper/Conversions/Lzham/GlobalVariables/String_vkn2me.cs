using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.InlineArrays;

namespace AssetRipper.Conversions.Lzham.GlobalVariables;

[MangledName("??_C@_0BO@CHJDIDGP@match_len?5?$DM?$DN?5actual_match_len?$AA@")]
[DemangledName("\"match_len <= actual_match_len\"")]
[CleanName("String")]
internal static partial class String_vkn2me
{
	public unsafe static InlineArray30_SByte* __pointer;

	public unsafe static InlineArray30_SByte Value
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

	unsafe static String_vkn2me()
	{
		__pointer = unchecked((InlineArray30_SByte*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray30_SByte))));
		Value = InlineArrayHelper.Create<InlineArray30_SByte, byte>("match_len <= actual_match_len\0"u8);
	}
}
