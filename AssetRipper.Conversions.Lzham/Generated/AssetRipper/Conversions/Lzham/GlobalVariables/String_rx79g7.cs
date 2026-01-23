using System.Runtime.CompilerServices;
using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.InlineArrays;

namespace AssetRipper.Conversions.Lzham.GlobalVariables;

[MangledName("??_C@_0BE@GOICEHAK@Coding?5statistics?3?6?$AA@")]
[DemangledName("\"Coding statistics:\\n\"")]
[CleanName("String")]
internal static partial class String_rx79g7
{
	[FixedAddressValueType]
	private static InlineArray20_SByte __value;

	public unsafe static InlineArray20_SByte* Pointer => unchecked((InlineArray20_SByte*)Unsafe.AsPointer(ref __value));

	public static InlineArray20_SByte Value
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

	unsafe static String_rx79g7()
	{
		Value = InlineArrayHelper.Create<InlineArray20_SByte, byte>("Coding statistics:\n\0"u8);
		PointerIndices.Register(Pointer);
	}
}
