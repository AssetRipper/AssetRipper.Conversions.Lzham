using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.InlineArrays;

namespace AssetRipper.Conversions.Lzham.GlobalVariables;

[MangledName("??_C@_0EG@GPEGOPDI@?5?5Count?3?5?$CFu?0?5Cost?3?5?$CFf?5?$CI?$CFf?5bytes?$CJ@")]
[DemangledName("\"  Count: %u, Cost: %f (%f bytes)\"...")]
[CleanName("String")]
internal static partial class String_fague4
{
	public unsafe static InlineArray70_SByte* __pointer;

	public unsafe static InlineArray70_SByte Value
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

	unsafe static String_fague4()
	{
		__pointer = unchecked((InlineArray70_SByte*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray70_SByte))));
		Value = InlineArrayHelper.Create<InlineArray70_SByte, byte>("  Count: %u, Cost: %f (%f bytes), Ave: %f StdDev: %f Min: %f Max: %f\n\0"u8);
	}
}
