using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.InlineArrays;

namespace AssetRipper.Conversions.Lzham.GlobalVariables;

[MangledName("??_C@_0O@GAOPAEPN@version?5error?$AA@")]
[DemangledName("\"version error\"")]
[CleanName("String")]
internal static partial class String_ba25s9
{
	public unsafe static InlineArray14_SByte* __pointer;

	public unsafe static InlineArray14_SByte Value
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

	unsafe static String_ba25s9()
	{
		__pointer = unchecked((InlineArray14_SByte*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray14_SByte))));
		Value = InlineArrayHelper.Create<InlineArray14_SByte, byte>("version error\0"u8);
	}
}
