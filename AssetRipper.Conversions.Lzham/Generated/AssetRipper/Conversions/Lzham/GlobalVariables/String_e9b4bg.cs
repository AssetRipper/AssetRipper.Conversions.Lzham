using System.Runtime.CompilerServices;
using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.InlineArrays;

namespace AssetRipper.Conversions.Lzham.GlobalVariables;

[MangledName("??_C@_06NHBNKELJ@10?48?41?$AA@")]
[DemangledName("\"10.8.1\"")]
[CleanName("String")]
internal static partial class String_e9b4bg
{
	[FixedAddressValueType]
	private static InlineArray7_SByte __value;

	public unsafe static InlineArray7_SByte* Pointer => unchecked((InlineArray7_SByte*)Unsafe.AsPointer(ref __value));

	public static InlineArray7_SByte Value
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

	unsafe static String_e9b4bg()
	{
		Value = InlineArrayHelper.Create<InlineArray7_SByte, byte>("10.8.1\0"u8);
		PointerIndices.Register(Pointer);
	}
}
