using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.InlineArrays;

namespace AssetRipper.Conversions.Lzham.GlobalVariables;

[MangledName("??_C@_0BG@GBDHCKKG@Delta?5literal?5stats?3?6?$AA@")]
[DemangledName("\"Delta literal stats:\\n\"")]
[CleanName("String")]
internal static partial class String_yaa426
{
	public unsafe static InlineArray22_SByte* __pointer;

	public unsafe static InlineArray22_SByte Value
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

	unsafe static String_yaa426()
	{
		__pointer = unchecked((InlineArray22_SByte*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray22_SByte))));
		Value = InlineArrayHelper.Create<InlineArray22_SByte, byte>("Delta literal stats:\n\0"u8);
	}
}
