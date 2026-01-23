using System.Runtime.CompilerServices;
using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.InlineArrays;

namespace AssetRipper.Conversions.Lzham.GlobalVariables;

[MangledName("??_C@_0EC@GMMOIKFK@?$CI?$CIuint32_ptr?$CJthis?5?$CG?5?$CILZHAM_GET_A@")]
[DemangledName("\"((uint32_ptr)this & (LZHAM_GET_A\"...")]
[CleanName("String")]
internal static partial class String_eyp45t
{
	[FixedAddressValueType]
	private static InlineArray66_SByte __value;

	public unsafe static InlineArray66_SByte* Pointer => unchecked((InlineArray66_SByte*)Unsafe.AsPointer(ref __value));

	public static InlineArray66_SByte Value
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

	unsafe static String_eyp45t()
	{
		Value = InlineArrayHelper.Create<InlineArray66_SByte, byte>("((uint32_ptr)this & (LZHAM_GET_ALIGNMENT(lzcompressor) - 1)) == 0\0"u8);
		PointerIndices.Register(Pointer);
	}
}
