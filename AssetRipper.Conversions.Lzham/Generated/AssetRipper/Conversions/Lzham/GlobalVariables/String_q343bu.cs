using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.InlineArrays;

namespace AssetRipper.Conversions.Lzham.GlobalVariables;

[MangledName("??_C@_07MNAPGDEB@parsing?$AA@")]
[DemangledName("\"parsing\"")]
[CleanName("String")]
internal static partial class String_q343bu
{
	public unsafe static InlineArray8_SByte* __pointer;

	public unsafe static InlineArray8_SByte Value
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

	unsafe static String_q343bu()
	{
		__pointer = unchecked((InlineArray8_SByte*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray8_SByte))));
		Value = InlineArrayHelper.Create<InlineArray8_SByte, byte>("parsing\0"u8);
	}
}
