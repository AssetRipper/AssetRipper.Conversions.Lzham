using System.Runtime.CompilerServices;
using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.InlineArrays;

namespace AssetRipper.Conversions.Lzham.GlobalVariables;

[MangledName("??_C@_0BJ@OMLMDDJC@?$CK?$CK?$CK?$CK?$CK?$CK?5compress_block?5?$CFu?$AA@")]
[DemangledName("\"****** compress_block %u\"")]
[CleanName("String")]
internal static partial class String_2p8789
{
	[FixedAddressValueType]
	private static InlineArray25_SByte __value;

	public unsafe static InlineArray25_SByte* Pointer => unchecked((InlineArray25_SByte*)Unsafe.AsPointer(ref __value));

	public static InlineArray25_SByte Value
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

	unsafe static String_2p8789()
	{
		Value = InlineArrayHelper.Create<InlineArray25_SByte, byte>("****** compress_block %u\0"u8);
		PointerIndices.Register(Pointer);
	}
}
