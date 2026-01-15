using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?get_match_dist@lzdecision@lzcompressor@lzham@@QEBAIAEBVstate@23@@Z")]
[DemangledName("public: unsigned int __cdecl lzham::lzcompressor::lzdecision::get_match_dist(class lzham::lzcompressor::state const &) const")]
internal static partial class Get_match_dist
{
	[return: NativeType("unsigned int")]
	public unsafe static int Invoke(void* @this, [NativeType("class lzham::lzcompressor::state const &")] void* cur_state)
	{
		if (!is_match.Invoke(@this))
		{
			return 0;
		}
		if (is_rep.Invoke(@this))
		{
			int num = -unchecked((lzham_CLZDecompBase*)@this)->m_match_hist - 1;
			return unchecked((int*)(&((lzham_lzcompressor_state_base*)cur_state)->m_match_hist))[num];
		}
		return unchecked((lzham_CLZDecompBase*)@this)->m_match_hist;
	}
}
