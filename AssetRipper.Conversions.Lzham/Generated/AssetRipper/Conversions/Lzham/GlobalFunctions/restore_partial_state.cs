using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Intrinsics.Implemented;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?restore_partial_state@state_base@lzcompressor@lzham@@QEAAXAEBU123@@Z")]
[DemangledName("public: void __cdecl lzham::lzcompressor::state_base::restore_partial_state(struct lzham::lzcompressor::state_base const &)")]
internal static partial class restore_partial_state
{
	[return: NativeType("void")]
	public unsafe static void Invoke(void* @this, [NativeType("struct lzham::lzcompressor::state_base const &")] void* src)
	{
		unchecked
		{
			((lzham_lzcompressor_state_base*)@this)->m_cur_ofs = ((lzham_lzcompressor_state_base*)src)->m_cur_ofs;
			((lzham_lzcompressor_state_base*)@this)->m_cur_state = ((lzham_lzcompressor_state_base*)src)->m_cur_state;
			llvm_memcpy_p0_p0_i64.Invoke(&((lzham_lzcompressor_state_base*)@this)->m_match_hist, &((lzham_lzcompressor_state_base*)src)->m_match_hist, 16L, isVolatile: false);
		}
	}
}
