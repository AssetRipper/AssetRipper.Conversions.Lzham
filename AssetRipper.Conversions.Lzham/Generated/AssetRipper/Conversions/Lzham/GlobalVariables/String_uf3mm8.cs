using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.InlineArrays;

namespace AssetRipper.Conversions.Lzham.GlobalVariables;

[MangledName("??_C@_0FE@GFOAKDAL@E?3?2repos?2AssetRipper?4Conversions@")]
[DemangledName("\"E:\\\\repos\\\\AssetRipper.Conversions\"...")]
[CleanName("String")]
internal static partial class String_uf3mm8
{
	public unsafe static InlineArray84_SByte* __pointer;

	public unsafe static InlineArray84_SByte Value
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

	unsafe static String_uf3mm8()
	{
		__pointer = unchecked((InlineArray84_SByte*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray84_SByte))));
		Value = InlineArrayHelper.Create<InlineArray84_SByte, byte>("E:\\repos\\AssetRipper.Conversions.Lzham\\Original\\lzhamcomp\\lzham_lzcomp_internal.cpp\0"u8);
	}
}
