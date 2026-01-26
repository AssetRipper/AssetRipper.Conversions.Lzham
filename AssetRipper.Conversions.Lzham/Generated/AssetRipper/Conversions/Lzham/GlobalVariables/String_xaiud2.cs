using System.Runtime.CompilerServices;
using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.InlineArrays;

namespace AssetRipper.Conversions.Lzham.GlobalVariables;

[MangledName("??_C@_00CNPNBAHC@?$AA@")]
[DemangledName("\"\"")]
[CleanName("String")]
internal static partial class String_xaiud2
{
	[FixedAddressValueType]
	private static InlineArray1_SByte __value;

	public unsafe static InlineArray1_SByte* Pointer => unchecked((InlineArray1_SByte*)Unsafe.AsPointer(ref __value));

	public static InlineArray1_SByte Value
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

	unsafe static String_xaiud2()
	{
		PointerIndices.Register(Pointer);
	}
}
