using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.InlineArrays;

namespace AssetRipper.Conversions.Lzham.GlobalVariables;

[MangledName("??_C@_0BB@PJEIBCLK@waiting?5for?5jobs?$AA@")]
[DemangledName("\"waiting for jobs\"")]
[CleanName("String")]
internal static partial class String_2t6uyd
{
	public unsafe static InlineArray17_SByte* __pointer;

	public unsafe static InlineArray17_SByte Value
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

	unsafe static String_2t6uyd()
	{
		__pointer = unchecked((InlineArray17_SByte*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray17_SByte))));
		Value = InlineArrayHelper.Create<InlineArray17_SByte, byte>("waiting for jobs\0"u8);
	}
}
