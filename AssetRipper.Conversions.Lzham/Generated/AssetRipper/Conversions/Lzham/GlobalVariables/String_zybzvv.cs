using System.Runtime.CompilerServices;
using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.InlineArrays;

namespace AssetRipper.Conversions.Lzham.GlobalVariables;

[MangledName("??_C@_0BA@PEPMCGFH@parameter?5error?$AA@")]
[DemangledName("\"parameter error\"")]
[CleanName("String")]
internal static partial class String_zybzvv
{
	[FixedAddressValueType]
	private static InlineArray16_SByte __value;

	public unsafe static InlineArray16_SByte* Pointer => unchecked((InlineArray16_SByte*)Unsafe.AsPointer(ref __value));

	public static InlineArray16_SByte Value
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

	unsafe static String_zybzvv()
	{
		Value = InlineArrayHelper.Create<InlineArray16_SByte, byte>("parameter error\0"u8);
		PointerIndices.Register(Pointer);
	}
}
