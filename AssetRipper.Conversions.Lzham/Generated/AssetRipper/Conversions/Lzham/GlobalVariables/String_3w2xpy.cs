using System.Runtime.CompilerServices;
using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.InlineArrays;

namespace AssetRipper.Conversions.Lzham.GlobalVariables;

[MangledName("??_C@_09OOPFIHMG@buf?5error?$AA@")]
[DemangledName("\"buf error\"")]
[CleanName("String")]
internal static partial class String_3w2xpy
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

	unsafe static String_3w2xpy()
	{
		Value = InlineArrayHelper.Create<InlineArray10_SByte, byte>("buf error\0"u8);
		PointerIndices.Register(Pointer);
	}
}
