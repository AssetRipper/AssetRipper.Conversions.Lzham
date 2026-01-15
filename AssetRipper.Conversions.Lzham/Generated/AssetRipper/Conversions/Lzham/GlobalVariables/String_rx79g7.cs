using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.InlineArrays;

namespace AssetRipper.Conversions.Lzham.GlobalVariables;

[MangledName("??_C@_0BE@GOICEHAK@Coding?5statistics?3?6?$AA@")]
[DemangledName("\"Coding statistics:\\n\"")]
[CleanName("String")]
internal static partial class String_rx79g7
{
	public unsafe static InlineArray20_SByte* __pointer;

	public unsafe static InlineArray20_SByte Value
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

	unsafe static String_rx79g7()
	{
		__pointer = unchecked((InlineArray20_SByte*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray20_SByte))));
		Value = InlineArrayHelper.Create<InlineArray20_SByte, byte>("Coding statistics:\n\0"u8);
	}
}
