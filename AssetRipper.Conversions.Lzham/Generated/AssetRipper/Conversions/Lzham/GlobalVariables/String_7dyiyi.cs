using System.Runtime.CompilerServices;
using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.InlineArrays;

namespace AssetRipper.Conversions.Lzham.GlobalVariables;

[MangledName("??_C@_06GDAGLJDI@coding?$AA@")]
[DemangledName("\"coding\"")]
[CleanName("String")]
internal static partial class String_7dyiyi
{
	[FixedAddressValueType]
	private static InlineArray7_SByte __value;

	public unsafe static InlineArray7_SByte* Pointer => unchecked((InlineArray7_SByte*)Unsafe.AsPointer(ref __value));

	public static InlineArray7_SByte Value
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

	unsafe static String_7dyiyi()
	{
		Value = InlineArrayHelper.Create<InlineArray7_SByte, byte>("coding\0"u8);
		PointerIndices.Register(Pointer);
	}
}
