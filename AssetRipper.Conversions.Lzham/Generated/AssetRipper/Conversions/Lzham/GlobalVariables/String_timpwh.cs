using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.InlineArrays;

namespace AssetRipper.Conversions.Lzham.GlobalVariables;

[MangledName("??_C@_09ELANMBPE@IsMatch?3?6?$AA@")]
[DemangledName("\"IsMatch:\\n\"")]
[CleanName("String")]
internal static partial class String_timpwh
{
	public unsafe static InlineArray10_SByte* __pointer;

	public unsafe static InlineArray10_SByte Value
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

	unsafe static String_timpwh()
	{
		__pointer = unchecked((InlineArray10_SByte*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray10_SByte))));
		Value = InlineArrayHelper.Create<InlineArray10_SByte, byte>("IsMatch:\n\0"u8);
	}
}
