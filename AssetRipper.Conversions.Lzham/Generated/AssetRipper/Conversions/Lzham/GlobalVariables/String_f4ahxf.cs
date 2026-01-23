using System.Runtime.CompilerServices;
using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.InlineArrays;

namespace AssetRipper.Conversions.Lzham.GlobalVariables;

[MangledName("??_C@_0HF@GNPNOCHO@Total?5Bytes?3?5?$CFu?0?5Total?5Contexts?3@")]
[DemangledName("\"Total Bytes: %u, Total Contexts:\"...")]
[CleanName("String")]
internal static partial class String_f4ahxf
{
	[FixedAddressValueType]
	private static InlineArray117_SByte __value;

	public unsafe static InlineArray117_SByte* Pointer => unchecked((InlineArray117_SByte*)Unsafe.AsPointer(ref __value));

	public static InlineArray117_SByte Value
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

	unsafe static String_f4ahxf()
	{
		Value = InlineArrayHelper.Create<InlineArray117_SByte, byte>("Total Bytes: %u, Total Contexts: %u, Total Cost: %f bits (%f bytes)\nContext ave cost: %f StdDev: %f Min: %f Max: %f\n\0"u8);
		PointerIndices.Register(Pointer);
	}
}
