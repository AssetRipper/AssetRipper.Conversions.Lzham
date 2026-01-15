using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.InlineArrays;

namespace AssetRipper.Conversions.Lzham.GlobalVariables;

[MangledName("??_C@_0L@KIJFAKBJ@file?5error?$AA@")]
[DemangledName("\"file error\"")]
[CleanName("String")]
internal static partial class String_87eb53
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

	unsafe static String_87eb53()
	{
		__pointer = unchecked((InlineArray11_SByte*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray11_SByte))));
		Value = InlineArrayHelper.Create<InlineArray11_SByte, byte>("file error\0"u8);
	}
}
