using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.InlineArrays;

namespace AssetRipper.Conversions.Lzham.GlobalVariables;

[MangledName("??_C@_0CC@GKCFHBDP@Max?5full?5match?5len2?5distance?3?5?$CFu@")]
[DemangledName("\"Max full match len2 distance: %u\"...")]
[CleanName("String")]
internal static partial class String_r7bdmb
{
	public unsafe static InlineArray34_SByte* __pointer;

	public unsafe static InlineArray34_SByte Value
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

	unsafe static String_r7bdmb()
	{
		__pointer = unchecked((InlineArray34_SByte*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray34_SByte))));
		Value = InlineArrayHelper.Create<InlineArray34_SByte, byte>("Max full match len2 distance: %u\n\0"u8);
	}
}
