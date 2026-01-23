using System.Runtime.CompilerServices;
using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.InlineArrays;

namespace AssetRipper.Conversions.Lzham.GlobalVariables;

[MangledName("??_C@_0BL@CPKIOCOB@Ave?5bytes?5per?5context?3?5?$CFf?6?$AA@")]
[DemangledName("\"Ave bytes per context: %f\\n\"")]
[CleanName("String")]
internal static partial class String_vudj64
{
	[FixedAddressValueType]
	private static InlineArray27_SByte __value;

	public unsafe static InlineArray27_SByte* Pointer => unchecked((InlineArray27_SByte*)Unsafe.AsPointer(ref __value));

	public static InlineArray27_SByte Value
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

	unsafe static String_vudj64()
	{
		Value = InlineArrayHelper.Create<InlineArray27_SByte, byte>("Ave bytes per context: %f\n\0"u8);
		PointerIndices.Register(Pointer);
	}
}
