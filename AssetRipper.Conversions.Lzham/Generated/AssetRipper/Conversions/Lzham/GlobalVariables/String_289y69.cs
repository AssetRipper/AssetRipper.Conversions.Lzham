using System.Runtime.CompilerServices;
using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.InlineArrays;

namespace AssetRipper.Conversions.Lzham.GlobalVariables;

[MangledName("??_C@_02DKCKIIND@?$CFs?$AA@")]
[DemangledName("\"%s\"")]
[CleanName("String")]
internal static partial class String_289y69
{
	[FixedAddressValueType]
	private static InlineArray3_SByte __value;

	public unsafe static InlineArray3_SByte* Pointer => unchecked((InlineArray3_SByte*)Unsafe.AsPointer(ref __value));

	public static InlineArray3_SByte Value
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

	unsafe static String_289y69()
	{
		Value = InlineArrayHelper.Create<InlineArray3_SByte, byte>("%s\0"u8);
		PointerIndices.Register(Pointer);
	}
}
