using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.InlineArrays;

namespace AssetRipper.Conversions.Lzham.GlobalVariables;

[MangledName("??_C@_0HF@GNPNOCHO@Total?5Bytes?3?5?$CFu?0?5Total?5Contexts?3@")]
[DemangledName("\"Total Bytes: %u, Total Contexts:\"...")]
[CleanName("String")]
internal static partial class String_f4ahxf
{
	public unsafe static InlineArray117_SByte* __pointer;

	public unsafe static InlineArray117_SByte Value
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

	unsafe static String_f4ahxf()
	{
		__pointer = unchecked((InlineArray117_SByte*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray117_SByte))));
		Value = InlineArrayHelper.Create<InlineArray117_SByte, byte>("Total Bytes: %u, Total Contexts: %u, Total Cost: %f bits (%f bytes)\nContext ave cost: %f StdDev: %f Min: %f Max: %f\n\0"u8);
	}
}
