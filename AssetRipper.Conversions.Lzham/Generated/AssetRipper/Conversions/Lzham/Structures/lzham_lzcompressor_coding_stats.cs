using System.Runtime.InteropServices;
using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.InlineArrays;

namespace AssetRipper.Conversions.Lzham.Structures;

[StructLayout(LayoutKind.Explicit, Size = 13304)]
[MangledName("struct.lzham::lzcompressor::coding_stats")]
[DemangledName("lzham::lzcompressor::coding_stats")]
public partial struct lzham_lzcompressor_coding_stats
{
	[FieldOffset(0)]
	public int m_total_bytes;

	[FieldOffset(4)]
	public int m_total_contexts;

	[FieldOffset(8)]
	public double m_total_cost;

	[FieldOffset(16)]
	public lzham_lzcompressor_tracked_stat m_context_stats;

	[FieldOffset(56)]
	public double m_total_match_bits_cost;

	[FieldOffset(64)]
	public double m_worst_match_bits_cost;

	[FieldOffset(72)]
	public double m_total_is_match0_bits_cost;

	[FieldOffset(80)]
	public double m_total_is_match1_bits_cost;

	[FieldOffset(88)]
	public int m_total_truncated_matches;

	[FieldOffset(92)]
	public InlineArray258_Int32 m_match_truncation_len_hist;

	[FieldOffset(1124)]
	public InlineArray258_Int32 m_match_truncation_hist;

	[FieldOffset(2156)]
	public InlineArray12_InlineArray5_Int32 m_match_type_truncation_hist;

	[FieldOffset(2396)]
	public InlineArray12_InlineArray5_Int32 m_match_type_was_not_truncated_hist;

	[FieldOffset(2636)]
	public int m_total_nonmatches;

	[FieldOffset(2640)]
	public int m_total_matches;

	[FieldOffset(2648)]
	public lzham_lzcompressor_tracked_stat m_lit_stats;

	[FieldOffset(2688)]
	public lzham_lzcompressor_tracked_stat m_delta_lit_stats;

	[FieldOffset(2728)]
	public InlineArray4_lzham_lzcompressor_tracked_stat m_rep_stats;

	[FieldOffset(2888)]
	public lzham_lzcompressor_tracked_stat m_rep0_len1_stats;

	[FieldOffset(2928)]
	public lzham_lzcompressor_tracked_stat m_rep0_len2_plus_stats;

	[FieldOffset(2968)]
	public InlineArray258_lzham_lzcompressor_tracked_stat m_full_match_stats;

	[FieldOffset(13288)]
	public int m_total_far_len2_matches;

	[FieldOffset(13292)]
	public int m_total_near_len2_matches;

	[FieldOffset(13296)]
	public int m_total_update_rate_resets;

	[FieldOffset(13300)]
	public int m_max_len2_dist;
}
