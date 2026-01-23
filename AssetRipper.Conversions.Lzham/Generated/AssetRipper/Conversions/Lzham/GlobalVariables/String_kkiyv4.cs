using System.Runtime.CompilerServices;
using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.InlineArrays;

namespace AssetRipper.Conversions.Lzham.GlobalVariables;

[MangledName("??_C@_0BG@CFFFDGMP@parse_job_callback?5?$CFu?$AA@")]
[DemangledName("\"parse_job_callback %u\"")]
[CleanName("String")]
internal static partial class String_kkiyv4
{
	[FixedAddressValueType]
	private static InlineArray22_SByte __value;

	public unsafe static InlineArray22_SByte* Pointer => unchecked((InlineArray22_SByte*)Unsafe.AsPointer(ref __value));

	public static InlineArray22_SByte Value
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

	unsafe static String_kkiyv4()
	{
		Value = InlineArrayHelper.Create<InlineArray22_SByte, byte>("parse_job_callback %u\0"u8);
		PointerIndices.Register(Pointer);
	}
}
