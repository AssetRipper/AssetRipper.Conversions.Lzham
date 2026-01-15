using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.InlineArrays;

namespace AssetRipper.Conversions.Lzham.GlobalVariables;

[MangledName("??_C@_0BG@HHLIHKBE@?$CB?$CB?$CBRep?50?5full?5len?5?$CFu?6?$AA@")]
[DemangledName("\"!!!Rep 0 full len %u\\n\"")]
[CleanName("String")]
internal static partial class String_3ut65i
{
	public unsafe static InlineArray22_SByte* __pointer;

	public unsafe static InlineArray22_SByte Value
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

	unsafe static String_3ut65i()
	{
		__pointer = unchecked((InlineArray22_SByte*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray22_SByte))));
		Value = InlineArrayHelper.Create<InlineArray22_SByte, byte>("!!!Rep 0 full len %u\n\0"u8);
	}
}
