using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?reset_state_partial@state@lzcompressor@lzham@@QEAAXXZ")]
[DemangledName("public: void __cdecl lzham::lzcompressor::state::reset_state_partial(void)")]
internal static partial class reset_state_partial
{
	[return: NativeType("void")]
	public unsafe static void Invoke(void* @this)
	{
		unchecked
		{
			*(int*)(&((lzham_lzcompressor_state_base*)@this)->m_match_hist) = 1;
			((int*)(&((lzham_lzcompressor_state_base*)@this)->m_match_hist))[1] = 1;
			((int*)(&((lzham_lzcompressor_state_base*)@this)->m_match_hist))[2] = 1;
			((int*)(&((lzham_lzcompressor_state_base*)@this)->m_match_hist))[3] = 1;
			((lzham_lzcompressor_state_base*)@this)->m_cur_state = 0;
		}
	}
}
