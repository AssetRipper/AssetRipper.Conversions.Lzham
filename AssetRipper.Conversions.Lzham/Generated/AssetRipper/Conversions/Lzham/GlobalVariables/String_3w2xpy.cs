using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.InlineArrays;

namespace AssetRipper.Conversions.Lzham.GlobalVariables;

[MangledName("??_C@_09OOPFIHMG@buf?5error?$AA@")]
[DemangledName("\"buf error\"")]
[CleanName("String")]
internal static partial class String_3w2xpy
{
	public unsafe static InlineArray10_SByte* __pointer;

	public unsafe static InlineArray10_SByte Value
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

	unsafe static String_3w2xpy()
	{
		__pointer = unchecked((InlineArray10_SByte*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray10_SByte))));
		Value = InlineArrayHelper.Create<InlineArray10_SByte, byte>("buf error\0"u8);
	}
}
