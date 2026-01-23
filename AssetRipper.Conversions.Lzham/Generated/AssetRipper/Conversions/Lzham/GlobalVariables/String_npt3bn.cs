using System.Runtime.CompilerServices;
using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.InlineArrays;

namespace AssetRipper.Conversions.Lzham.GlobalVariables;

[MangledName("??_C@_0N@NAAKPPPI@?9?9?9?9?9?9?9?9?9?9?9?6?$AA@")]
[DemangledName("\"-----------\\n\"")]
[CleanName("String")]
internal static partial class String_npt3bn
{
	[FixedAddressValueType]
	private static InlineArray13_SByte __value;

	public unsafe static InlineArray13_SByte* Pointer => unchecked((InlineArray13_SByte*)Unsafe.AsPointer(ref __value));

	public static InlineArray13_SByte Value
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

	unsafe static String_npt3bn()
	{
		Value = InlineArrayHelper.Create<InlineArray13_SByte, byte>("-----------\n\0"u8);
		PointerIndices.Register(Pointer);
	}
}
