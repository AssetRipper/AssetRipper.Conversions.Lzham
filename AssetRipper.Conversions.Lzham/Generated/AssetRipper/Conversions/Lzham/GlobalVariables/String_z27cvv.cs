using System.Runtime.CompilerServices;
using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.InlineArrays;

namespace AssetRipper.Conversions.Lzham.GlobalVariables;

[MangledName("??_C@_0CA@KGDCMNL@?$CFs?$CI?$CFu?$CJ?3?5Assertion?5failed?3?5?$CC?$CFs?$CC?6?$AA@")]
[DemangledName("\"%s(%u): Assertion failed: \\\"%s\\\"\\n\"")]
[CleanName("String")]
internal static partial class String_z27cvv
{
	[FixedAddressValueType]
	private static InlineArray32_SByte __value;

	public unsafe static InlineArray32_SByte* Pointer => unchecked((InlineArray32_SByte*)Unsafe.AsPointer(ref __value));

	public static InlineArray32_SByte Value
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

	unsafe static String_z27cvv()
	{
		Value = InlineArrayHelper.Create<InlineArray32_SByte, byte>("%s(%u): Assertion failed: \"%s\"\n\0"u8);
		PointerIndices.Register(Pointer);
	}
}
