using System.Runtime.CompilerServices;
using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.InlineArrays;

namespace AssetRipper.Conversions.Lzham.GlobalVariables;

[MangledName("??_C@_0EO@EKBIAOLA@Match?5?$CFu?3?5Total?3?5?$CFu?0?5Cost?3?5?$CFf?5?$CI?$CF@")]
[DemangledName("\"Match %u: Total: %u, Cost: %f (%\"...")]
[CleanName("String")]
internal static partial class String_cijmf9
{
	[FixedAddressValueType]
	private static InlineArray78_SByte __value;

	public unsafe static InlineArray78_SByte* Pointer => unchecked((InlineArray78_SByte*)Unsafe.AsPointer(ref __value));

	public static InlineArray78_SByte Value
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

	unsafe static String_cijmf9()
	{
		Value = InlineArrayHelper.Create<InlineArray78_SByte, byte>("Match %u: Total: %u, Cost: %f (%f bytes), Ave: %f StdDev: %f Min: %f Max: %f\n\0"u8);
		PointerIndices.Register(Pointer);
	}
}
