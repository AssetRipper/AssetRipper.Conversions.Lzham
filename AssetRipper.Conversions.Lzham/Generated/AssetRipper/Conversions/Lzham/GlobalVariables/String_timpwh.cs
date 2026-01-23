using System.Runtime.CompilerServices;
using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.InlineArrays;

namespace AssetRipper.Conversions.Lzham.GlobalVariables;

[MangledName("??_C@_09ELANMBPE@IsMatch?3?6?$AA@")]
[DemangledName("\"IsMatch:\\n\"")]
[CleanName("String")]
internal static partial class String_timpwh
{
	[FixedAddressValueType]
	private static InlineArray10_SByte __value;

	public unsafe static InlineArray10_SByte* Pointer => unchecked((InlineArray10_SByte*)Unsafe.AsPointer(ref __value));

	public static InlineArray10_SByte Value
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

	unsafe static String_timpwh()
	{
		Value = InlineArrayHelper.Create<InlineArray10_SByte, byte>("IsMatch:\n\0"u8);
		PointerIndices.Register(Pointer);
	}
}
