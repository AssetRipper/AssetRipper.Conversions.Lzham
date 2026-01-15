using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?clear@coding_stats@lzcompressor@lzham@@QEAAXXZ")]
[DemangledName("public: void __cdecl lzham::lzcompressor::coding_stats::clear(void)")]
[CleanName("clear")]
internal static partial class clear_mcufyu
{
	[return: NativeType("void")]
	public unsafe static void Invoke(void* @this)
	{
		unchecked
		{
			((lzham_lzcompressor_coding_stats*)@this)->m_total_bytes = 0;
			((lzham_lzcompressor_coding_stats*)@this)->m_total_contexts = 0;
			((lzham_lzcompressor_coding_stats*)@this)->m_total_match_bits_cost = 0.0;
			((lzham_lzcompressor_coding_stats*)@this)->m_worst_match_bits_cost = 0.0;
			((lzham_lzcompressor_coding_stats*)@this)->m_total_is_match0_bits_cost = 0.0;
			((lzham_lzcompressor_coding_stats*)@this)->m_total_is_match1_bits_cost = 0.0;
			clear_yhrysc.Invoke(&((lzham_lzcompressor_coding_stats*)@this)->m_context_stats);
			((lzham_lzcompressor_coding_stats*)@this)->m_total_nonmatches = 0;
			((lzham_lzcompressor_coding_stats*)@this)->m_total_matches = 0;
			((lzham_lzcompressor_coding_stats*)@this)->m_total_cost = 0.0;
			clear_yhrysc.Invoke(&((lzham_lzcompressor_coding_stats*)@this)->m_lit_stats);
			clear_yhrysc.Invoke(&((lzham_lzcompressor_coding_stats*)@this)->m_delta_lit_stats);
			clear_yhrysc.Invoke(&((lzham_lzcompressor_coding_stats*)@this)->m_rep0_len1_stats);
			for (int i = 0; (uint)i < 4u; i++)
			{
				clear_yhrysc.Invoke((byte*)(&((lzham_lzcompressor_coding_stats*)@this)->m_rep_stats) + (nint)(uint)i * (nint)sizeof(lzham_lzcompressor_tracked_stat));
			}
			clear_yhrysc.Invoke(&((lzham_lzcompressor_coding_stats*)@this)->m_rep0_len1_stats);
			clear_yhrysc.Invoke(&((lzham_lzcompressor_coding_stats*)@this)->m_rep0_len2_plus_stats);
			for (int j = 0; (uint)j <= 257u; j++)
			{
				clear_yhrysc.Invoke((byte*)(&((lzham_lzcompressor_coding_stats*)@this)->m_full_match_stats) + (nint)(uint)j * (nint)sizeof(lzham_lzcompressor_tracked_stat));
			}
			((lzham_lzcompressor_coding_stats*)@this)->m_total_far_len2_matches = 0;
			((lzham_lzcompressor_coding_stats*)@this)->m_total_near_len2_matches = 0;
			((lzham_lzcompressor_coding_stats*)@this)->m_total_truncated_matches = 0;
			zero_object_tcsufu.Invoke(&((lzham_lzcompressor_coding_stats*)@this)->m_match_truncation_len_hist);
			zero_object_tcsufu.Invoke(&((lzham_lzcompressor_coding_stats*)@this)->m_match_truncation_hist);
			zero_object_cguijf.Invoke(&((lzham_lzcompressor_coding_stats*)@this)->m_match_type_truncation_hist);
			zero_object_cguijf.Invoke(&((lzham_lzcompressor_coding_stats*)@this)->m_match_type_was_not_truncated_hist);
			((lzham_lzcompressor_coding_stats*)@this)->m_total_update_rate_resets = 0;
			((lzham_lzcompressor_coding_stats*)@this)->m_max_len2_dist = 0;
		}
	}
}
