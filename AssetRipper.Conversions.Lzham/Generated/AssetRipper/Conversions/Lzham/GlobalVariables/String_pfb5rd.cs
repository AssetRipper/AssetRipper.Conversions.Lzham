using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.InlineArrays;

namespace AssetRipper.Conversions.Lzham.GlobalVariables;

[MangledName("??_C@_0EK@FDCIOCFI@E?3?2repos?2AssetRipper?4Conversions@")]
[DemangledName("\"E:\\\\repos\\\\AssetRipper.Conversions\"...")]
[CleanName("String")]
internal static partial class String_pfb5rd
{
	public unsafe static InlineArray74_SByte* __pointer;

	public unsafe static InlineArray74_SByte Value
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

	unsafe static String_pfb5rd()
	{
		__pointer = unchecked((InlineArray74_SByte*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray74_SByte))));
		Value = InlineArrayHelper.Create<InlineArray74_SByte, byte>("E:\\repos\\AssetRipper.Conversions.Lzham\\Original\\lzhamdecomp\\lzham_mem.cpp\0"u8);
	}
}
