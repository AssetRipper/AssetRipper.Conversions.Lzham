using System.Runtime.CompilerServices;
using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.InlineArrays;

namespace AssetRipper.Conversions.Lzham.GlobalVariables;

[MangledName("??_C@_0EM@MPOBPHMO@?5?5Count?3?5?$CFu?0?5Cost?3?5?$CFf?5?$CI?$CFf?5bytes?$CJ@")]
[DemangledName("\"  Count: %u, Cost: %f (%f bytes)\"...")]
[CleanName("String")]
internal static partial class String_kn3w39
{
	[FixedAddressValueType]
	private static InlineArray76_SByte __value;

	public unsafe static InlineArray76_SByte* Pointer => unchecked((InlineArray76_SByte*)Unsafe.AsPointer(ref __value));

	public static InlineArray76_SByte Value
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

	unsafe static String_kn3w39()
	{
		Value = InlineArrayHelper.Create<InlineArray76_SByte, byte>("  Count: %u, Cost: %f (%f bytes), Ave. Cost: %f StdDev: %f Min: %f Max: %f\n\0"u8);
		PointerIndices.Register(Pointer);
	}
}
