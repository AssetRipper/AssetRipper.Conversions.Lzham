using System.Runtime.CompilerServices;
using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.InlineArrays;

namespace AssetRipper.Conversions.Lzham.GlobalVariables;

[MangledName("??_C@_0DD@NINNDDPA@vector?3?5lzham_realloc?$CI?$CJ?5failed?5a@")]
[DemangledName("\"vector: lzham_realloc() failed a\"...")]
[CleanName("String")]
internal static partial class String_c93t5e
{
	[FixedAddressValueType]
	private static InlineArray51_SByte __value;

	public unsafe static InlineArray51_SByte* Pointer => unchecked((InlineArray51_SByte*)Unsafe.AsPointer(ref __value));

	public static InlineArray51_SByte Value
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

	unsafe static String_c93t5e()
	{
		Value = InlineArrayHelper.Create<InlineArray51_SByte, byte>("vector: lzham_realloc() failed allocating %u bytes\0"u8);
		PointerIndices.Register(Pointer);
	}
}
