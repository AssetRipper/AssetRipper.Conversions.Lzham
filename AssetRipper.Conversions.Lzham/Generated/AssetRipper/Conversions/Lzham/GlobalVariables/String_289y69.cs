using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.InlineArrays;

namespace AssetRipper.Conversions.Lzham.GlobalVariables;

[MangledName("??_C@_02DKCKIIND@?$CFs?$AA@")]
[DemangledName("\"%s\"")]
[CleanName("String")]
internal static partial class String_289y69
{
	public unsafe static InlineArray3_SByte* __pointer;

	public unsafe static InlineArray3_SByte Value
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

	unsafe static String_289y69()
	{
		__pointer = unchecked((InlineArray3_SByte*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray3_SByte))));
		Value = InlineArrayHelper.Create<InlineArray3_SByte, byte>("%s\0"u8);
	}
}
