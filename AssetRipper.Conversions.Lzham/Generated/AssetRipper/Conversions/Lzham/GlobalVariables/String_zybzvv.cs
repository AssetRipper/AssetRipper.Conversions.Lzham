using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.InlineArrays;

namespace AssetRipper.Conversions.Lzham.GlobalVariables;

[MangledName("??_C@_0BA@PEPMCGFH@parameter?5error?$AA@")]
[DemangledName("\"parameter error\"")]
[CleanName("String")]
internal static partial class String_zybzvv
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

	unsafe static String_zybzvv()
	{
		__pointer = unchecked((InlineArray16_SByte*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray16_SByte))));
		Value = InlineArrayHelper.Create<InlineArray16_SByte, byte>("parameter error\0"u8);
	}
}
