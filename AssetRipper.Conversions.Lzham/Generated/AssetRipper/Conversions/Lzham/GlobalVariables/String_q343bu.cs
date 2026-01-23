using System.Runtime.CompilerServices;
using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.InlineArrays;

namespace AssetRipper.Conversions.Lzham.GlobalVariables;

[MangledName("??_C@_07MNAPGDEB@parsing?$AA@")]
[DemangledName("\"parsing\"")]
[CleanName("String")]
internal static partial class String_q343bu
{
	[FixedAddressValueType]
	private static InlineArray8_SByte __value;

	public unsafe static InlineArray8_SByte* Pointer => unchecked((InlineArray8_SByte*)Unsafe.AsPointer(ref __value));

	public static InlineArray8_SByte Value
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

	unsafe static String_q343bu()
	{
		Value = InlineArrayHelper.Create<InlineArray8_SByte, byte>("parsing\0"u8);
		PointerIndices.Register(Pointer);
	}
}
