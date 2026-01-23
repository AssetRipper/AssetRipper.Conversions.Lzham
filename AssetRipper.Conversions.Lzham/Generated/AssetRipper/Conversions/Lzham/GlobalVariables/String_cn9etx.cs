using System.Runtime.CompilerServices;
using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.InlineArrays;

namespace AssetRipper.Conversions.Lzham.GlobalVariables;

[MangledName("??_C@_0EL@BCKDLKNL@E?3?2repos?2AssetRipper?4Conversions@")]
[DemangledName("\"E:\\\\repos\\\\AssetRipper.Conversions\"...")]
[CleanName("String")]
internal static partial class String_cn9etx
{
	[FixedAddressValueType]
	private static InlineArray75_SByte __value;

	public unsafe static InlineArray75_SByte* Pointer => unchecked((InlineArray75_SByte*)Unsafe.AsPointer(ref __value));

	public static InlineArray75_SByte Value
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

	unsafe static String_cn9etx()
	{
		Value = InlineArrayHelper.Create<InlineArray75_SByte, byte>("E:\\repos\\AssetRipper.Conversions.Lzham\\Original\\lzhamdecomp\\lzham_vector.h\0"u8);
		PointerIndices.Register(Pointer);
	}
}
