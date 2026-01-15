using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.InlineArrays;

namespace AssetRipper.Conversions.Lzham.GlobalVariables;

[MangledName("??_C@_06GDAGLJDI@coding?$AA@")]
[DemangledName("\"coding\"")]
[CleanName("String")]
internal static partial class String_7dyiyi
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

	unsafe static String_7dyiyi()
	{
		__pointer = unchecked((InlineArray7_SByte*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray7_SByte))));
		Value = InlineArrayHelper.Create<InlineArray7_SByte, byte>("coding\0"u8);
	}
}
