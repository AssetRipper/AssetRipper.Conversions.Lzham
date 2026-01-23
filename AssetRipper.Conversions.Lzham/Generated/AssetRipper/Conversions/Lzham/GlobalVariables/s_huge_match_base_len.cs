using System.Runtime.CompilerServices;
using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.InlineArrays;

namespace AssetRipper.Conversions.Lzham.GlobalVariables;

[MangledName("?s_huge_match_base_len@lzham@@3QBIB")]
[DemangledName("unsigned int const *const lzham::s_huge_match_base_len")]
internal static partial class s_huge_match_base_len
{
	[FixedAddressValueType]
	private static InlineArray4_Int32 __value;

	public unsafe static InlineArray4_Int32* Pointer => unchecked((InlineArray4_Int32*)Unsafe.AsPointer(ref __value));

	public static InlineArray4_Int32 Value
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

	unsafe static s_huge_match_base_len()
	{
		Value = InlineArrayHelper.Create<InlineArray4_Int32, int>(new int[4] { 258, 514, 1538, 5634 });
		PointerIndices.Register(Pointer);
	}
}
