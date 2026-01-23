using System.Runtime.CompilerServices;
using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.InlineArrays;

namespace AssetRipper.Conversions.Lzham.GlobalVariables;

[MangledName("??_C@_0DJ@OJLKDIAB@?$CK?$CK?$CKDelta?5lit?3?5?$CFu?5?8?$CFc?8?0?5Mismatch?3@")]
[DemangledName("\"***Delta lit: %u \\'%c\\', Mismatch:\"...")]
[CleanName("String")]
internal static partial class String_eiv9zx
{
	[FixedAddressValueType]
	private static InlineArray57_SByte __value;

	public unsafe static InlineArray57_SByte* Pointer => unchecked((InlineArray57_SByte*)Unsafe.AsPointer(ref __value));

	public static InlineArray57_SByte Value
	{
		get
		{
			return __value;
		}
		set
		{
			__value = value;
		}
	}

	unsafe static String_eiv9zx()
	{
		Value = InlineArrayHelper.Create<InlineArray57_SByte, byte>("***Delta lit: %u '%c', Mismatch: %u '%c', Delta: 0x%02X\n\0"u8);
		PointerIndices.Register(Pointer);
	}
}
