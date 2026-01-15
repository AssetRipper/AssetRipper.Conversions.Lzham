using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.InlineArrays;

namespace AssetRipper.Conversions.Lzham.GlobalVariables;

[MangledName("??_C@_0CK@OOPAAHAE@Total?5matches?3?5?$CFu?0?5truncated?5mat@")]
[DemangledName("\"Total matches: %u, truncated mat\"...")]
[CleanName("String")]
internal static partial class String_id92h6
{
	public unsafe static InlineArray42_SByte* __pointer;

	public unsafe static InlineArray42_SByte Value
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

	unsafe static String_id92h6()
	{
		__pointer = unchecked((InlineArray42_SByte*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray42_SByte))));
		Value = InlineArrayHelper.Create<InlineArray42_SByte, byte>("Total matches: %u, truncated matches: %u\n\0"u8);
	}
}
