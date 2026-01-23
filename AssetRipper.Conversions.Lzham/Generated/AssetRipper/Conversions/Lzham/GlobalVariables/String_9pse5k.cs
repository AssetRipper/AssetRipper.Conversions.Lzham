using System.Runtime.CompilerServices;
using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.InlineArrays;

namespace AssetRipper.Conversions.Lzham.GlobalVariables;

[MangledName("??_C@_06PCICMFGG@append?$AA@")]
[DemangledName("\"append\"")]
[CleanName("String")]
internal static partial class String_9pse5k
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

	unsafe static String_9pse5k()
	{
		Value = InlineArrayHelper.Create<InlineArray7_SByte, byte>("append\0"u8);
		PointerIndices.Register(Pointer);
	}
}
