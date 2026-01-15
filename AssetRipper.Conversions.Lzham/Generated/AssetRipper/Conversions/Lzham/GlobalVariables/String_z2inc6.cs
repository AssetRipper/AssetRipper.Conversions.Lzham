using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.InlineArrays;

namespace AssetRipper.Conversions.Lzham.GlobalVariables;

[MangledName("??_C@_0BL@BMCEKBHI@lzham_malloc?3?5size?5too?5big?$AA@")]
[DemangledName("\"lzham_malloc: size too big\"")]
[CleanName("String")]
internal static partial class String_z2inc6
{
	public unsafe static InlineArray27_SByte* __pointer;

	public unsafe static InlineArray27_SByte Value
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

	unsafe static String_z2inc6()
	{
		__pointer = unchecked((InlineArray27_SByte*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray27_SByte))));
		Value = InlineArrayHelper.Create<InlineArray27_SByte, byte>("lzham_malloc: size too big\0"u8);
	}
}
