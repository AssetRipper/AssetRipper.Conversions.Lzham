using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.InlineArrays;

namespace AssetRipper.Conversions.Lzham.GlobalVariables;

[MangledName("??_C@_0BD@LCHDLMCB@Rep0?5Len2?$CL?5stats?3?6?$AA@")]
[DemangledName("\"Rep0 Len2+ stats:\\n\"")]
[CleanName("String")]
internal static partial class String_dpnkqw
{
	public unsafe static InlineArray19_SByte* __pointer;

	public unsafe static InlineArray19_SByte Value
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

	unsafe static String_dpnkqw()
	{
		__pointer = unchecked((InlineArray19_SByte*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray19_SByte))));
		Value = InlineArrayHelper.Create<InlineArray19_SByte, byte>("Rep0 Len2+ stats:\n\0"u8);
	}
}
