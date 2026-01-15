using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.InlineArrays;

namespace AssetRipper.Conversions.Lzham.GlobalVariables;

[MangledName("??_C@_0N@MKKNPMJD@stream?5error?$AA@")]
[DemangledName("\"stream error\"")]
[CleanName("String")]
internal static partial class String_2bxz4p
{
	public unsafe static InlineArray13_SByte* __pointer;

	public unsafe static InlineArray13_SByte Value
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

	unsafe static String_2bxz4p()
	{
		__pointer = unchecked((InlineArray13_SByte*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray13_SByte))));
		Value = InlineArrayHelper.Create<InlineArray13_SByte, byte>("stream error\0"u8);
	}
}
