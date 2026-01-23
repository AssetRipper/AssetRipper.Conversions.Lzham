using System.Runtime.CompilerServices;
using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.InlineArrays;

namespace AssetRipper.Conversions.Lzham.GlobalVariables;

[MangledName("??_C@_0DC@GCIBAKNN@vector?3?5lzham_malloc?$CI?$CJ?5failed?5al@")]
[DemangledName("\"vector: lzham_malloc() failed al\"...")]
[CleanName("String")]
internal static partial class String_d6e2vj
{
	[FixedAddressValueType]
	private static InlineArray50_SByte __value;

	public unsafe static InlineArray50_SByte* Pointer => unchecked((InlineArray50_SByte*)Unsafe.AsPointer(ref __value));

	public static InlineArray50_SByte Value
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

	unsafe static String_d6e2vj()
	{
		Value = InlineArrayHelper.Create<InlineArray50_SByte, byte>("vector: lzham_malloc() failed allocating %u bytes\0"u8);
		PointerIndices.Register(Pointer);
	}
}
