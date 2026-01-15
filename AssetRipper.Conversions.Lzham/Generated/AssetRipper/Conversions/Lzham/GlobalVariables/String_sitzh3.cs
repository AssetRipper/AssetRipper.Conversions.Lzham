using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.InlineArrays;

namespace AssetRipper.Conversions.Lzham.GlobalVariables;

[MangledName("??_C@_0BH@CIFPAAMN@?$CB?$CB?$CBRep?5?$CFu?5full?5len?5?$CFu?6?$AA@")]
[DemangledName("\"!!!Rep %u full len %u\\n\"")]
[CleanName("String")]
internal static partial class String_sitzh3
{
	public unsafe static InlineArray23_SByte* __pointer;

	public unsafe static InlineArray23_SByte Value
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

	unsafe static String_sitzh3()
	{
		__pointer = unchecked((InlineArray23_SByte*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray23_SByte))));
		Value = InlineArrayHelper.Create<InlineArray23_SByte, byte>("!!!Rep %u full len %u\n\0"u8);
	}
}
