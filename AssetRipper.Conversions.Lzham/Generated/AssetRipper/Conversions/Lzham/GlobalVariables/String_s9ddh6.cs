using System.Runtime.CompilerServices;
using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.InlineArrays;

namespace AssetRipper.Conversions.Lzham.GlobalVariables;

[MangledName("??_C@_0P@MCMBFBIC@?$CB?$CB?$CBRep?50?5len1?6?$AA@")]
[DemangledName("\"!!!Rep 0 len1\\n\"")]
[CleanName("String")]
internal static partial class String_s9ddh6
{
	[FixedAddressValueType]
	private static InlineArray15_SByte __value;

	public unsafe static InlineArray15_SByte* Pointer => unchecked((InlineArray15_SByte*)Unsafe.AsPointer(ref __value));

	public static InlineArray15_SByte Value
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

	unsafe static String_s9ddh6()
	{
		Value = InlineArrayHelper.Create<InlineArray15_SByte, byte>("!!!Rep 0 len1\n\0"u8);
		PointerIndices.Register(Pointer);
	}
}
