using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.InlineArrays;

namespace AssetRipper.Conversions.Lzham.GlobalVariables;

[MangledName("??_C@_06NHBNKELJ@10?48?41?$AA@")]
[DemangledName("\"10.8.1\"")]
[CleanName("String")]
internal static partial class String_e9b4bg
{
	public unsafe static InlineArray7_SByte* __pointer;

	public unsafe static InlineArray7_SByte Value
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

	unsafe static String_e9b4bg()
	{
		__pointer = unchecked((InlineArray7_SByte*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray7_SByte))));
		Value = InlineArrayHelper.Create<InlineArray7_SByte, byte>("10.8.1\0"u8);
	}
}
