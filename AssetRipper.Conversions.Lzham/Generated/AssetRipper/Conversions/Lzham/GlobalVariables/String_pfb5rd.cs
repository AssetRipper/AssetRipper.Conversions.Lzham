using System.Runtime.CompilerServices;
using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.InlineArrays;

namespace AssetRipper.Conversions.Lzham.GlobalVariables;

[MangledName("??_C@_0EK@FDCIOCFI@E?3?2repos?2AssetRipper?4Conversions@")]
[DemangledName("\"E:\\\\repos\\\\AssetRipper.Conversions\"...")]
[CleanName("String")]
internal static partial class String_pfb5rd
{
	[FixedAddressValueType]
	private static InlineArray74_SByte __value;

	public unsafe static InlineArray74_SByte* Pointer => unchecked((InlineArray74_SByte*)Unsafe.AsPointer(ref __value));

	public static InlineArray74_SByte Value
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

	unsafe static String_pfb5rd()
	{
		Value = InlineArrayHelper.Create<InlineArray74_SByte, byte>("E:\\repos\\AssetRipper.Conversions.Lzham\\Original\\lzhamdecomp\\lzham_mem.cpp\0"u8);
		PointerIndices.Register(Pointer);
	}
}
