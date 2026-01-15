using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.InlineArrays;

namespace AssetRipper.Conversions.Lzham.GlobalVariables;

[MangledName("??_C@_0EB@FPFLEMCG@?5?5Total?3?5?$CFu?0?5Cost?3?5?$CFf?5?$CI?$CFf?5bytes?$CJ@")]
[DemangledName("\"  Total: %u, Cost: %f (%f bytes)\"...")]
[CleanName("String")]
internal static partial class String_e29b4t
{
	public unsafe static InlineArray65_SByte* __pointer;

	public unsafe static InlineArray65_SByte Value
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

	unsafe static String_e29b4t()
	{
		__pointer = unchecked((InlineArray65_SByte*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray65_SByte))));
		Value = InlineArrayHelper.Create<InlineArray65_SByte, byte>("  Total: %u, Cost: %f (%f bytes), Ave. Cost: %f, Worst Cost: %f\n\0"u8);
	}
}
