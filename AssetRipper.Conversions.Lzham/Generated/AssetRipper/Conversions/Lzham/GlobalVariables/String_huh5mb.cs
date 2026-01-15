using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.InlineArrays;

namespace AssetRipper.Conversions.Lzham.GlobalVariables;

[MangledName("??_C@_0L@HAHMBNLP@data?5error?$AA@")]
[DemangledName("\"data error\"")]
[CleanName("String")]
internal static partial class String_huh5mb
{
	public unsafe static InlineArray11_SByte* __pointer;

	public unsafe static InlineArray11_SByte Value
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

	unsafe static String_huh5mb()
	{
		__pointer = unchecked((InlineArray11_SByte*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray11_SByte))));
		Value = InlineArrayHelper.Create<InlineArray11_SByte, byte>("data error\0"u8);
	}
}
