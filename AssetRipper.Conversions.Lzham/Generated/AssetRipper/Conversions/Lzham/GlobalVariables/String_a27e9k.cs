using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.InlineArrays;

namespace AssetRipper.Conversions.Lzham.GlobalVariables;

[MangledName("??_C@_0BA@MOKMMFOD@need?5dictionary?$AA@")]
[DemangledName("\"need dictionary\"")]
[CleanName("String")]
internal static partial class String_a27e9k
{
	public unsafe static InlineArray16_SByte* __pointer;

	public unsafe static InlineArray16_SByte Value
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

	unsafe static String_a27e9k()
	{
		__pointer = unchecked((InlineArray16_SByte*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray16_SByte))));
		Value = InlineArrayHelper.Create<InlineArray16_SByte, byte>("need dictionary\0"u8);
	}
}
