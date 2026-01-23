using System.Runtime.CompilerServices;
using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.InlineArrays;

namespace AssetRipper.Conversions.Lzham.GlobalVariables;

[MangledName("??_C@_0DG@CNCJKPMO@?5?5TRUNCATED?5match?0?5actual?5len?5is@")]
[DemangledName("\"  TRUNCATED match, actual len is\"...")]
[CleanName("String")]
internal static partial class String_4d3wsk
{
	[FixedAddressValueType]
	private static InlineArray54_SByte __value;

	public unsafe static InlineArray54_SByte* Pointer => unchecked((InlineArray54_SByte*)Unsafe.AsPointer(ref __value));

	public static InlineArray54_SByte Value
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

	unsafe static String_4d3wsk()
	{
		Value = InlineArrayHelper.Create<InlineArray54_SByte, byte>("  TRUNCATED match, actual len is %u, shortened by %u\n\0"u8);
		PointerIndices.Register(Pointer);
	}
}
