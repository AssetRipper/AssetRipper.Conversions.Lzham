using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.InlineArrays;

namespace AssetRipper.Conversions.Lzham.GlobalVariables;

[MangledName("??_C@_0P@MCMBFBIC@?$CB?$CB?$CBRep?50?5len1?6?$AA@")]
[DemangledName("\"!!!Rep 0 len1\\n\"")]
[CleanName("String")]
internal static partial class String_s9ddh6
{
	public unsafe static InlineArray15_SByte* __pointer;

	public unsafe static InlineArray15_SByte Value
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

	unsafe static String_s9ddh6()
	{
		__pointer = unchecked((InlineArray15_SByte*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray15_SByte))));
		Value = InlineArrayHelper.Create<InlineArray15_SByte, byte>("!!!Rep 0 len1\n\0"u8);
	}
}
