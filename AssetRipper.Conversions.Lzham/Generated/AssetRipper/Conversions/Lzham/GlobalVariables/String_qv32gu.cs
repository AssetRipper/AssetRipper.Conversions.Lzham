using System.Runtime.CompilerServices;
using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.InlineArrays;

namespace AssetRipper.Conversions.Lzham.GlobalVariables;

[MangledName("??_C@_0EN@OFLHMCEC@E?3?2repos?2AssetRipper?4Conversions@")]
[DemangledName("\"E:\\\\repos\\\\AssetRipper.Conversions\"...")]
[CleanName("String")]
internal static partial class String_qv32gu
{
	[FixedAddressValueType]
	private static InlineArray77_SByte __value;

	public unsafe static InlineArray77_SByte* Pointer => unchecked((InlineArray77_SByte*)Unsafe.AsPointer(ref __value));

	public static InlineArray77_SByte Value
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

	unsafe static String_qv32gu()
	{
		Value = InlineArrayHelper.Create<InlineArray77_SByte, byte>("E:\\repos\\AssetRipper.Conversions.Lzham\\Original\\lzhamdecomp\\lzham_vector.cpp\0"u8);
		PointerIndices.Register(Pointer);
	}
}
