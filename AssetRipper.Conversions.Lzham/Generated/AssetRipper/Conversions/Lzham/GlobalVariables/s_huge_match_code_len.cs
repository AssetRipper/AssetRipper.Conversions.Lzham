using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.InlineArrays;

namespace AssetRipper.Conversions.Lzham.GlobalVariables;

[MangledName("?s_huge_match_code_len@lzham@@3QBEB")]
[DemangledName("unsigned char const *const lzham::s_huge_match_code_len")]
internal static partial class s_huge_match_code_len
{
	public unsafe static InlineArray4_SByte* __pointer;

	public unsafe static InlineArray4_SByte Value
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

	unsafe static s_huge_match_code_len()
	{
		__pointer = unchecked((InlineArray4_SByte*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray4_SByte))));
		Value = InlineArrayHelper.Create<InlineArray4_SByte, byte>(new byte[4] { 8, 10, 12, 16 });
	}
}
