using System.Runtime.CompilerServices;
using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.InlineArrays;

namespace AssetRipper.Conversions.Lzham.GlobalVariables;

[MangledName("?s_huge_match_code_len@lzham@@3QBEB")]
[DemangledName("unsigned char const *const lzham::s_huge_match_code_len")]
internal static partial class s_huge_match_code_len
{
	[FixedAddressValueType]
	private static InlineArray4_SByte __value;

	public unsafe static InlineArray4_SByte* Pointer => unchecked((InlineArray4_SByte*)Unsafe.AsPointer(ref __value));

	public static InlineArray4_SByte Value
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

	unsafe static s_huge_match_code_len()
	{
		Value = InlineArrayHelper.Create<InlineArray4_SByte, byte>(new byte[4] { 8, 10, 12, 16 });
		PointerIndices.Register(Pointer);
	}
}
