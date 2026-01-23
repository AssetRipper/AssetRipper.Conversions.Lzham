using System.Runtime.CompilerServices;
using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.InlineArrays;

namespace AssetRipper.Conversions.Lzham.GlobalVariables;

[MangledName("??_C@_0BB@PJEIBCLK@waiting?5for?5jobs?$AA@")]
[DemangledName("\"waiting for jobs\"")]
[CleanName("String")]
internal static partial class String_2t6uyd
{
	[FixedAddressValueType]
	private static InlineArray17_SByte __value;

	public unsafe static InlineArray17_SByte* Pointer => unchecked((InlineArray17_SByte*)Unsafe.AsPointer(ref __value));

	public static InlineArray17_SByte Value
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

	unsafe static String_2t6uyd()
	{
		Value = InlineArrayHelper.Create<InlineArray17_SByte, byte>("waiting for jobs\0"u8);
		PointerIndices.Register(Pointer);
	}
}
