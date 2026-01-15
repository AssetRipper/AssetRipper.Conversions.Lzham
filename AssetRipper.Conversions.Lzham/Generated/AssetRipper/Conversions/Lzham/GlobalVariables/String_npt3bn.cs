using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.InlineArrays;

namespace AssetRipper.Conversions.Lzham.GlobalVariables;

[MangledName("??_C@_0N@NAAKPPPI@?9?9?9?9?9?9?9?9?9?9?9?6?$AA@")]
[DemangledName("\"-----------\\n\"")]
[CleanName("String")]
internal static partial class String_npt3bn
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

	unsafe static String_npt3bn()
	{
		__pointer = unchecked((InlineArray13_SByte*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray13_SByte))));
		Value = InlineArrayHelper.Create<InlineArray13_SByte, byte>("-----------\n\0"u8);
	}
}
