using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.InlineArrays;

namespace AssetRipper.Conversions.Lzham.GlobalVariables;

[MangledName("?s_huge_match_base_len@lzham@@3QBIB")]
[DemangledName("unsigned int const *const lzham::s_huge_match_base_len")]
internal static partial class s_huge_match_base_len
{
	public unsafe static InlineArray4_Int32* __pointer;

	public unsafe static InlineArray4_Int32 Value
	{
		get
		{
			return *__pointer;
		}
		set
		{
			*__pointer = value;
		}
	}

	unsafe static s_huge_match_base_len()
	{
		__pointer = unchecked((InlineArray4_Int32*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray4_Int32))));
		Value = InlineArrayHelper.Create<InlineArray4_Int32, int>(new int[4] { 258, 514, 1538, 5634 });
	}
}
