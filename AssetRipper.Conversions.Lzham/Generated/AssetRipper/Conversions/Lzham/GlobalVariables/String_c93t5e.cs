using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.InlineArrays;

namespace AssetRipper.Conversions.Lzham.GlobalVariables;

[MangledName("??_C@_0DD@NINNDDPA@vector?3?5lzham_realloc?$CI?$CJ?5failed?5a@")]
[DemangledName("\"vector: lzham_realloc() failed a\"...")]
[CleanName("String")]
internal static partial class String_c93t5e
{
	public unsafe static InlineArray51_SByte* __pointer;

	public unsafe static InlineArray51_SByte Value
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

	unsafe static String_c93t5e()
	{
		__pointer = unchecked((InlineArray51_SByte*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray51_SByte))));
		Value = InlineArrayHelper.Create<InlineArray51_SByte, byte>("vector: lzham_realloc() failed allocating %u bytes\0"u8);
	}
}
