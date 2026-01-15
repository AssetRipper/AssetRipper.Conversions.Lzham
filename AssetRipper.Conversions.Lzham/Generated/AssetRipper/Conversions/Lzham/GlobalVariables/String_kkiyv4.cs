using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.InlineArrays;

namespace AssetRipper.Conversions.Lzham.GlobalVariables;

[MangledName("??_C@_0BG@CFFFDGMP@parse_job_callback?5?$CFu?$AA@")]
[DemangledName("\"parse_job_callback %u\"")]
[CleanName("String")]
internal static partial class String_kkiyv4
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

	unsafe static String_kkiyv4()
	{
		__pointer = unchecked((InlineArray22_SByte*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray22_SByte))));
		Value = InlineArrayHelper.Create<InlineArray22_SByte, byte>("parse_job_callback %u\0"u8);
	}
}
