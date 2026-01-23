using System.Runtime.CompilerServices;
using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.InlineArrays;

namespace AssetRipper.Conversions.Lzham.GlobalVariables;

[MangledName("??_C@_0FD@BCCONNPJ@E?3?2repos?2AssetRipper?4Conversions@")]
[DemangledName("\"E:\\\\repos\\\\AssetRipper.Conversions\"...")]
[CleanName("String")]
internal static partial class String_ednjr4
{
	[FixedAddressValueType]
	private static InlineArray83_SByte __value;

	public unsafe static InlineArray83_SByte* Pointer => unchecked((InlineArray83_SByte*)Unsafe.AsPointer(ref __value));

	public static InlineArray83_SByte Value
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

	unsafe static String_ednjr4()
	{
		Value = InlineArrayHelper.Create<InlineArray83_SByte, byte>("E:\\repos\\AssetRipper.Conversions.Lzham\\Original\\lzhamdecomp\\lzham_symbol_codec.cpp\0"u8);
		PointerIndices.Register(Pointer);
	}
}
