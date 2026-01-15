using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.InlineArrays;

namespace AssetRipper.Conversions.Lzham.GlobalVariables;

[MangledName("??_C@_06PCICMFGG@append?$AA@")]
[DemangledName("\"append\"")]
[CleanName("String")]
internal static partial class String_9pse5k
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

	unsafe static String_9pse5k()
	{
		__pointer = unchecked((InlineArray7_SByte*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray7_SByte))));
		Value = InlineArrayHelper.Create<InlineArray7_SByte, byte>("append\0"u8);
	}
}
