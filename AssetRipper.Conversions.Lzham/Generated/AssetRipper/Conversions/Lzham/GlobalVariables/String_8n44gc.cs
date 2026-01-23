using System.Runtime.CompilerServices;
using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.InlineArrays;

namespace AssetRipper.Conversions.Lzham.GlobalVariables;

[MangledName("??_C@_0P@JOEJHPGM@Rep?5?$CFu?5stats?3?6?$AA@")]
[DemangledName("\"Rep %u stats:\\n\"")]
[CleanName("String")]
internal static partial class String_8n44gc
{
	[FixedAddressValueType]
	private static InlineArray15_SByte __value;

	public unsafe static InlineArray15_SByte* Pointer => unchecked((InlineArray15_SByte*)Unsafe.AsPointer(ref __value));

	public static InlineArray15_SByte Value
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

	unsafe static String_8n44gc()
	{
		Value = InlineArrayHelper.Create<InlineArray15_SByte, byte>("Rep %u stats:\n\0"u8);
		PointerIndices.Register(Pointer);
	}
}
