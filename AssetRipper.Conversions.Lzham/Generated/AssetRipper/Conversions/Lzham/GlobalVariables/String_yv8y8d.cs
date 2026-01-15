using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.InlineArrays;

namespace AssetRipper.Conversions.Lzham.GlobalVariables;

[MangledName("??_C@_0BO@FGCFGCKN@Total?5update?5rate?5resets?3?5?$CFu?6?$AA@")]
[DemangledName("\"Total update rate resets: %u\\n\"")]
[CleanName("String")]
internal static partial class String_yv8y8d
{
	public unsafe static InlineArray30_SByte* __pointer;

	public unsafe static InlineArray30_SByte Value
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

	unsafe static String_yv8y8d()
	{
		__pointer = unchecked((InlineArray30_SByte*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray30_SByte))));
		Value = InlineArrayHelper.Create<InlineArray30_SByte, byte>("Total update rate resets: %u\n\0"u8);
	}
}
