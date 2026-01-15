using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.InlineArrays;

namespace AssetRipper.Conversions.Lzham.GlobalVariables;

[MangledName("??_C@_0BA@BNBNJMM@Literal?5stats?3?6?$AA@")]
[DemangledName("\"Literal stats:\\n\"")]
[CleanName("String")]
internal static partial class String_xa9qi5
{
	public unsafe static InlineArray16_SByte* __pointer;

	public unsafe static InlineArray16_SByte Value
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

	unsafe static String_xa9qi5()
	{
		__pointer = unchecked((InlineArray16_SByte*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray16_SByte))));
		Value = InlineArrayHelper.Create<InlineArray16_SByte, byte>("Literal stats:\n\0"u8);
	}
}
