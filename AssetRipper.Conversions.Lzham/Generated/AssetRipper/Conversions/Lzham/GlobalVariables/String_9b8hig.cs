using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.InlineArrays;

namespace AssetRipper.Conversions.Lzham.GlobalVariables;

[MangledName("??_C@_0DG@BGAJCJLF@?5?5IsMatch?$CI0?$CJ?3?5?$CFu?0?5Cost?3?5?$CFf?5?$CI?$CFf?5b@")]
[DemangledName("\"  IsMatch(0): %u, Cost: %f (%f b\"...")]
[CleanName("String")]
internal static partial class String_9b8hig
{
	public unsafe static InlineArray54_SByte* __pointer;

	public unsafe static InlineArray54_SByte Value
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

	unsafe static String_9b8hig()
	{
		__pointer = unchecked((InlineArray54_SByte*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray54_SByte))));
		Value = InlineArrayHelper.Create<InlineArray54_SByte, byte>("  IsMatch(0): %u, Cost: %f (%f bytes), Ave. Cost: %f\n\0"u8);
	}
}
