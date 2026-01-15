using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.InlineArrays;

namespace AssetRipper.Conversions.Lzham.GlobalVariables;

[MangledName("??_C@_0EL@BCKDLKNL@E?3?2repos?2AssetRipper?4Conversions@")]
[DemangledName("\"E:\\\\repos\\\\AssetRipper.Conversions\"...")]
[CleanName("String")]
internal static partial class String_cn9etx
{
	public unsafe static InlineArray75_SByte* __pointer;

	public unsafe static InlineArray75_SByte Value
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

	unsafe static String_cn9etx()
	{
		__pointer = unchecked((InlineArray75_SByte*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray75_SByte))));
		Value = InlineArrayHelper.Create<InlineArray75_SByte, byte>("E:\\repos\\AssetRipper.Conversions.Lzham\\Original\\lzhamdecomp\\lzham_vector.h\0"u8);
	}
}
