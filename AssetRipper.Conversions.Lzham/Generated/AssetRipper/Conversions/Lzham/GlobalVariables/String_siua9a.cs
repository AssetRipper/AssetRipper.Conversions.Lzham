using System.Runtime.CompilerServices;
using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.InlineArrays;

namespace AssetRipper.Conversions.Lzham.GlobalVariables;

[MangledName("??_C@_0O@PMPMJFCA@stop_encoding?$AA@")]
[DemangledName("\"stop_encoding\"")]
[CleanName("String")]
internal static partial class String_siua9a
{
	[FixedAddressValueType]
	private static InlineArray14_SByte __value;

	public unsafe static InlineArray14_SByte* Pointer => unchecked((InlineArray14_SByte*)Unsafe.AsPointer(ref __value));

	public static InlineArray14_SByte Value
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

	unsafe static String_siua9a()
	{
		Value = InlineArrayHelper.Create<InlineArray14_SByte, byte>("stop_encoding\0"u8);
		PointerIndices.Register(Pointer);
	}
}
