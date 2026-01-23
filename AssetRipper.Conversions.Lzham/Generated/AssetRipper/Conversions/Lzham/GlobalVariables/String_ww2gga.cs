using System.Runtime.CompilerServices;
using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.InlineArrays;

namespace AssetRipper.Conversions.Lzham.GlobalVariables;

[MangledName("??_C@_0BH@KMOOLNCP@?$CFs?$CI?$CFu?$CJ?3?5Failure?3?5?$CC?$CFs?$CC?6?$AA@")]
[DemangledName("\"%s(%u): Failure: \\\"%s\\\"\\n\"")]
[CleanName("String")]
internal static partial class String_ww2gga
{
	[FixedAddressValueType]
	private static InlineArray23_SByte __value;

	public unsafe static InlineArray23_SByte* Pointer => unchecked((InlineArray23_SByte*)Unsafe.AsPointer(ref __value));

	public static InlineArray23_SByte Value
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

	unsafe static String_ww2gga()
	{
		Value = InlineArrayHelper.Create<InlineArray23_SByte, byte>("%s(%u): Failure: \"%s\"\n\0"u8);
		PointerIndices.Register(Pointer);
	}
}
