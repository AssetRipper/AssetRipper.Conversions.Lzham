using System.Runtime.CompilerServices;
using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.InlineArrays;

namespace AssetRipper.Conversions.Lzham.GlobalVariables;

[MangledName("??_C@_01EEMJAFIK@?6?$AA@")]
[DemangledName("\"\\n\"")]
[CleanName("String")]
internal static partial class String_69wyxh
{
	[FixedAddressValueType]
	private static InlineArray2_SByte __value;

	public unsafe static InlineArray2_SByte* Pointer => unchecked((InlineArray2_SByte*)Unsafe.AsPointer(ref __value));

	public static InlineArray2_SByte Value
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

	unsafe static String_69wyxh()
	{
		Value = InlineArrayHelper.Create<InlineArray2_SByte, byte>("\n\0"u8);
		PointerIndices.Register(Pointer);
	}
}
