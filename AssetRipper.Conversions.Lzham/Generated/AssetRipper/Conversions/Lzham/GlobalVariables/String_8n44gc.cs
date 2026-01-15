using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.InlineArrays;

namespace AssetRipper.Conversions.Lzham.GlobalVariables;

[MangledName("??_C@_0P@JOEJHPGM@Rep?5?$CFu?5stats?3?6?$AA@")]
[DemangledName("\"Rep %u stats:\\n\"")]
[CleanName("String")]
internal static partial class String_8n44gc
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

	unsafe static String_8n44gc()
	{
		__pointer = unchecked((InlineArray15_SByte*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray15_SByte))));
		Value = InlineArrayHelper.Create<InlineArray15_SByte, byte>("Rep %u stats:\n\0"u8);
	}
}
