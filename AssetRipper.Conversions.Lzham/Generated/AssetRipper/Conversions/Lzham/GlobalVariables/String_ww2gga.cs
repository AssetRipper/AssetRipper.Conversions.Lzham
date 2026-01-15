using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.InlineArrays;

namespace AssetRipper.Conversions.Lzham.GlobalVariables;

[MangledName("??_C@_0BH@KMOOLNCP@?$CFs?$CI?$CFu?$CJ?3?5Failure?3?5?$CC?$CFs?$CC?6?$AA@")]
[DemangledName("\"%s(%u): Failure: \\\"%s\\\"\\n\"")]
[CleanName("String")]
internal static partial class String_ww2gga
{
	public unsafe static InlineArray23_SByte* __pointer;

	public unsafe static InlineArray23_SByte Value
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

	unsafe static String_ww2gga()
	{
		__pointer = unchecked((InlineArray23_SByte*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray23_SByte))));
		Value = InlineArrayHelper.Create<InlineArray23_SByte, byte>("%s(%u): Failure: \"%s\"\n\0"u8);
	}
}
