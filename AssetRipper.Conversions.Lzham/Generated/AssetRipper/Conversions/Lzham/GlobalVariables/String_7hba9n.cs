using System.Runtime.CompilerServices;
using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.InlineArrays;

namespace AssetRipper.Conversions.Lzham.GlobalVariables;

[MangledName("??_C@_0BC@GGLBIONJ@bit?5?$DN?$DN?5sym?4m_bits?$AA@")]
[DemangledName("\"bit == sym.m_bits\"")]
[CleanName("String")]
internal static partial class String_7hba9n
{
	[FixedAddressValueType]
	private static InlineArray18_SByte __value;

	public unsafe static InlineArray18_SByte* Pointer => unchecked((InlineArray18_SByte*)Unsafe.AsPointer(ref __value));

	public static InlineArray18_SByte Value
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

	unsafe static String_7hba9n()
	{
		Value = InlineArrayHelper.Create<InlineArray18_SByte, byte>("bit == sym.m_bits\0"u8);
		PointerIndices.Register(Pointer);
	}
}
