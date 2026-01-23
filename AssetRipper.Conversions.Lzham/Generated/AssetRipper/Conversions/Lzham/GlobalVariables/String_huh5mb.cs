using System.Runtime.CompilerServices;
using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.InlineArrays;

namespace AssetRipper.Conversions.Lzham.GlobalVariables;

[MangledName("??_C@_0L@HAHMBNLP@data?5error?$AA@")]
[DemangledName("\"data error\"")]
[CleanName("String")]
internal static partial class String_huh5mb
{
	[FixedAddressValueType]
	private static InlineArray11_SByte __value;

	public unsafe static InlineArray11_SByte* Pointer => unchecked((InlineArray11_SByte*)Unsafe.AsPointer(ref __value));

	public static InlineArray11_SByte Value
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

	unsafe static String_huh5mb()
	{
		Value = InlineArrayHelper.Create<InlineArray11_SByte, byte>("data error\0"u8);
		PointerIndices.Register(Pointer);
	}
}
