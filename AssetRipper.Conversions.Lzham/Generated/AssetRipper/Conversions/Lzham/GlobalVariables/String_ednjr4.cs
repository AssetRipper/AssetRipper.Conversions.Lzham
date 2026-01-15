using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.InlineArrays;

namespace AssetRipper.Conversions.Lzham.GlobalVariables;

[MangledName("??_C@_0FD@BCCONNPJ@E?3?2repos?2AssetRipper?4Conversions@")]
[DemangledName("\"E:\\\\repos\\\\AssetRipper.Conversions\"...")]
[CleanName("String")]
internal static partial class String_ednjr4
{
	public unsafe static InlineArray83_SByte* __pointer;

	public unsafe static InlineArray83_SByte Value
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

	unsafe static String_ednjr4()
	{
		__pointer = unchecked((InlineArray83_SByte*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray83_SByte))));
		Value = InlineArrayHelper.Create<InlineArray83_SByte, byte>("E:\\repos\\AssetRipper.Conversions.Lzham\\Original\\lzhamdecomp\\lzham_symbol_codec.cpp\0"u8);
	}
}
