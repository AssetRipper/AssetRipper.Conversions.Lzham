using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.InlineArrays;

namespace AssetRipper.Conversions.Lzham.GlobalVariables;

[MangledName("??_C@_0BJ@OMLMDDJC@?$CK?$CK?$CK?$CK?$CK?$CK?5compress_block?5?$CFu?$AA@")]
[DemangledName("\"****** compress_block %u\"")]
[CleanName("String")]
internal static partial class String_2p8789
{
	public unsafe static InlineArray25_SByte* __pointer;

	public unsafe static InlineArray25_SByte Value
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

	unsafe static String_2p8789()
	{
		__pointer = unchecked((InlineArray25_SByte*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray25_SByte))));
		Value = InlineArrayHelper.Create<InlineArray25_SByte, byte>("****** compress_block %u\0"u8);
	}
}
