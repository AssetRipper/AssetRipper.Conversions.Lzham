using System.Runtime.CompilerServices;
using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.InlineArrays;

namespace AssetRipper.Conversions.Lzham.GlobalVariables;

[MangledName("??_C@_0O@GAOPAEPN@version?5error?$AA@")]
[DemangledName("\"version error\"")]
[CleanName("String")]
internal static partial class String_ba25s9
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

	unsafe static String_ba25s9()
	{
		Value = InlineArrayHelper.Create<InlineArray14_SByte, byte>("version error\0"u8);
		PointerIndices.Register(Pointer);
	}
}
