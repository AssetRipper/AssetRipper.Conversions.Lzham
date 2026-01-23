using System.Runtime.CompilerServices;
using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.InlineArrays;

namespace AssetRipper.Conversions.Lzham.GlobalVariables;

[MangledName("??_C@_0FE@GFOAKDAL@E?3?2repos?2AssetRipper?4Conversions@")]
[DemangledName("\"E:\\\\repos\\\\AssetRipper.Conversions\"...")]
[CleanName("String")]
internal static partial class String_uf3mm8
{
	[FixedAddressValueType]
	private static InlineArray84_SByte __value;

	public unsafe static InlineArray84_SByte* Pointer => unchecked((InlineArray84_SByte*)Unsafe.AsPointer(ref __value));

	public static InlineArray84_SByte Value
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

	unsafe static String_uf3mm8()
	{
		Value = InlineArrayHelper.Create<InlineArray84_SByte, byte>("E:\\repos\\AssetRipper.Conversions.Lzham\\Original\\lzhamcomp\\lzham_lzcomp_internal.cpp\0"u8);
		PointerIndices.Register(Pointer);
	}
}
