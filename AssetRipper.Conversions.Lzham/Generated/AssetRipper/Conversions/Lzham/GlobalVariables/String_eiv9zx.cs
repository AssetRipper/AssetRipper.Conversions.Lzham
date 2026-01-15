using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.InlineArrays;

namespace AssetRipper.Conversions.Lzham.GlobalVariables;

[MangledName("??_C@_0DJ@OJLKDIAB@?$CK?$CK?$CKDelta?5lit?3?5?$CFu?5?8?$CFc?8?0?5Mismatch?3@")]
[DemangledName("\"***Delta lit: %u \\'%c\\', Mismatch:\"...")]
[CleanName("String")]
internal static partial class String_eiv9zx
{
	public unsafe static InlineArray57_SByte* __pointer;

	public unsafe static InlineArray57_SByte Value
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

	unsafe static String_eiv9zx()
	{
		__pointer = unchecked((InlineArray57_SByte*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray57_SByte))));
		Value = InlineArrayHelper.Create<InlineArray57_SByte, byte>("***Delta lit: %u '%c', Mismatch: %u '%c', Delta: 0x%02X\n\0"u8);
	}
}
