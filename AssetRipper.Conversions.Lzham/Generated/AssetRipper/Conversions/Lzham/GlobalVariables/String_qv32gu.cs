using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.InlineArrays;

namespace AssetRipper.Conversions.Lzham.GlobalVariables;

[MangledName("??_C@_0EN@OFLHMCEC@E?3?2repos?2AssetRipper?4Conversions@")]
[DemangledName("\"E:\\\\repos\\\\AssetRipper.Conversions\"...")]
[CleanName("String")]
internal static partial class String_qv32gu
{
	public unsafe static InlineArray77_SByte* __pointer;

	public unsafe static InlineArray77_SByte Value
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

	unsafe static String_qv32gu()
	{
		__pointer = unchecked((InlineArray77_SByte*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray77_SByte))));
		Value = InlineArrayHelper.Create<InlineArray77_SByte, byte>("E:\\repos\\AssetRipper.Conversions.Lzham\\Original\\lzhamdecomp\\lzham_vector.cpp\0"u8);
	}
}
