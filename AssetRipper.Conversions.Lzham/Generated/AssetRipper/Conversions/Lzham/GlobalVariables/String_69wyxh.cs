using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.InlineArrays;

namespace AssetRipper.Conversions.Lzham.GlobalVariables;

[MangledName("??_C@_01EEMJAFIK@?6?$AA@")]
[DemangledName("\"\\n\"")]
[CleanName("String")]
internal static partial class String_69wyxh
{
	public unsafe static InlineArray2_SByte* __pointer;

	public unsafe static InlineArray2_SByte Value
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

	unsafe static String_69wyxh()
	{
		__pointer = unchecked((InlineArray2_SByte*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray2_SByte))));
		Value = InlineArrayHelper.Create<InlineArray2_SByte, byte>("\n\0"u8);
	}
}
