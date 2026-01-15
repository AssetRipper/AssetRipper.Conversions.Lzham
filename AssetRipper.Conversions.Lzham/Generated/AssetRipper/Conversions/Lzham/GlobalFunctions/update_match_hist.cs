using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?update_match_hist@state@lzcompressor@lzham@@QEAAXI@Z")]
[DemangledName("public: void __cdecl lzham::lzcompressor::state::update_match_hist(unsigned int)")]
internal static partial class update_match_hist
{
	[return: NativeType("void")]
	public unsafe static void Invoke(void* @this, [NativeType("unsigned int")] int match_dist)
	{
		unchecked
		{
			int num = ((int*)(&((lzham_lzcompressor_state_base*)@this)->m_match_hist))[2];
			((int*)(&((lzham_lzcompressor_state_base*)@this)->m_match_hist))[3] = num;
			int num2 = ((int*)(&((lzham_lzcompressor_state_base*)@this)->m_match_hist))[1];
			((int*)(&((lzham_lzcompressor_state_base*)@this)->m_match_hist))[2] = num2;
			int match_hist = *(int*)(&((lzham_lzcompressor_state_base*)@this)->m_match_hist);
			((int*)(&((lzham_lzcompressor_state_base*)@this)->m_match_hist))[1] = match_hist;
			*(int*)(&((lzham_lzcompressor_state_base*)@this)->m_match_hist) = match_dist;
		}
	}
}
