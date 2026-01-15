using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.InlineArrays;

namespace AssetRipper.Conversions.Lzham.GlobalVariables;

[MangledName("??_C@_0BK@NBKBNKJK@?5?5?$CILow?54?5bits?3?5?$CFu?5vs?4?5?$CFu?$CJ?$AA@")]
[DemangledName("\"  (Low 4 bits: %u vs. %u)\"")]
[CleanName("String")]
internal static partial class String_2kd87d
{
	public unsafe static InlineArray26_SByte* __pointer;

	public unsafe static InlineArray26_SByte Value
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

	unsafe static String_2kd87d()
	{
		__pointer = unchecked((InlineArray26_SByte*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray26_SByte))));
		Value = InlineArrayHelper.Create<InlineArray26_SByte, byte>("  (Low 4 bits: %u vs. %u)\0"u8);
	}
}
