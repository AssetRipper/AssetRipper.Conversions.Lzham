using AssetRipper.Conversions.Lzham.GlobalVariables;
using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.InlineArrays;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?update@coding_stats@lzcompressor@lzham@@QEAAXAEBUlzdecision@23@AEBVstate@23@AEBVsearch_accelerator@3@_K@Z")]
[DemangledName("public: void __cdecl lzham::lzcompressor::coding_stats::update(struct lzham::lzcompressor::lzdecision const &, class lzham::lzcompressor::state const &, class lzham::search_accelerator const &, unsigned __int64)")]
[CleanName("update")]
internal static partial class update_xmta7z
{
	[return: NativeType("void")]
	public unsafe static void Invoke(void* @this, [NativeType("struct lzham::lzcompressor::lzdecision const &")] void* lzdec, [NativeType("class lzham::lzcompressor::state const &")] void* cur_state, [NativeType("class lzham::search_accelerator const &")] void* dict, [NativeType("unsigned __int64")] long cost)
	{
		int num = Get_len_wzf5xk.Invoke(lzdec);
		unchecked
		{
			((lzham_lzcompressor_coding_stats*)@this)->m_total_bytes += num;
			((lzham_lzcompressor_coding_stats*)@this)->m_total_contexts++;
			float num2 = (float)cost / 16777216f;
			((lzham_lzcompressor_coding_stats*)@this)->m_total_cost += num2;
			update_dvgbkc.Invoke(&((lzham_lzcompressor_coding_stats*)@this)->m_context_stats, num2);
			int cur_state2 = ((lzham_lzcompressor_state_base*)cur_state)->m_cur_state;
			if (((lzham_CLZDecompBase*)lzdec)->m_cur_state == 0)
			{
				float num3 = (float)Get_cost_2mqzjn.Invoke((byte*)(&((lzham_lzcompressor_state*)cur_state)->field_2) + (nint)(uint)cur_state2 * (nint)sizeof(lzham_adaptive_bit_model), 0) / 16777216f;
				((lzham_lzcompressor_coding_stats*)@this)->m_total_is_match0_bits_cost += num3;
				((lzham_lzcompressor_coding_stats*)@this)->m_total_match_bits_cost += num3;
				((lzham_lzcompressor_coding_stats*)@this)->m_worst_match_bits_cost = maximum_qi5jyn.Invoke(((lzham_lzcompressor_coding_stats*)@this)->m_worst_match_bits_cost, num3);
				((lzham_lzcompressor_coding_stats*)@this)->m_total_nonmatches++;
				if ((uint)((lzham_lzcompressor_state_base*)cur_state)->m_cur_state < 7u)
				{
					update_dvgbkc.Invoke(&((lzham_lzcompressor_coding_stats*)@this)->m_lit_stats, num2);
				}
				else
				{
					update_dvgbkc.Invoke(&((lzham_lzcompressor_coding_stats*)@this)->m_delta_lit_stats, num2);
				}
			}
			else
			{
				if (((lzham_CLZDecompBase*)lzdec)->m_cur_state > 257)
				{
					return;
				}
				int num4 = Get_len_wzf5xk.Invoke(lzdec);
				int dist = Get_match_dist.Invoke(lzdec, cur_state);
				int num5 = Get_lookahead_size.Invoke(dict);
				int num6 = Get_match_len.Invoke(dict, 0, dist, ((uint)num5 >= 257u) ? 257 : num5, 0);
				if ((uint)num4 > (uint)num6)
				{
					lzham_assert.Invoke(String_vkn2me.__pointer, String_v6uahj.__pointer, 1342);
				}
				((lzham_lzcompressor_coding_stats*)@this)->m_total_truncated_matches += (((uint)num4 < (uint)num6) ? 1 : 0);
				((int*)(&((lzham_lzcompressor_coding_stats*)@this)->m_match_truncation_len_hist))[maximum_67w4wi.Invoke(0, num6 - num4)]++;
				int num7 = 4;
				checked
				{
					if (!is_full_match.Invoke(lzdec))
					{
						num7 = -unchecked((lzham_CLZDecompBase*)lzdec)->m_match_hist - 1;
					}
				}
				if ((uint)num6 > (uint)num4)
				{
					((int*)(&((lzham_lzcompressor_coding_stats*)@this)->m_match_truncation_hist))[(uint)num4]++;
					((int*)((byte*)(&((lzham_lzcompressor_coding_stats*)@this)->m_match_type_truncation_hist) + (nint)(uint)((lzham_lzcompressor_state_base*)cur_state)->m_cur_state * (nint)sizeof(InlineArray5_Int32)))[(uint)num7]++;
				}
				else
				{
					((int*)((byte*)(&((lzham_lzcompressor_coding_stats*)@this)->m_match_type_was_not_truncated_hist) + (nint)(uint)((lzham_lzcompressor_state_base*)cur_state)->m_cur_state * (nint)sizeof(InlineArray5_Int32)))[(uint)num7]++;
				}
				float num8 = (float)Get_cost_2mqzjn.Invoke((byte*)(&((lzham_lzcompressor_state*)cur_state)->field_2) + (nint)(uint)cur_state2 * (nint)sizeof(lzham_adaptive_bit_model), 1) / 16777216f;
				((lzham_lzcompressor_coding_stats*)@this)->m_total_is_match1_bits_cost += num8;
				((lzham_lzcompressor_coding_stats*)@this)->m_total_match_bits_cost += num8;
				((lzham_lzcompressor_coding_stats*)@this)->m_worst_match_bits_cost = maximum_qi5jyn.Invoke(((lzham_lzcompressor_coding_stats*)@this)->m_worst_match_bits_cost, num8);
				((lzham_lzcompressor_coding_stats*)@this)->m_total_matches++;
				if (((lzham_CLZDecompBase*)lzdec)->m_match_hist < 0)
				{
					int num9;
					checked
					{
						num9 = -unchecked((lzham_CLZDecompBase*)lzdec)->m_match_hist - 1;
					}
					update_dvgbkc.Invoke((byte*)(&((lzham_lzcompressor_coding_stats*)@this)->m_rep_stats) + (nint)num9 * (nint)sizeof(lzham_lzcompressor_tracked_stat), num2);
					if (num9 == 0)
					{
						if (((lzham_CLZDecompBase*)lzdec)->m_cur_state == 1)
						{
							update_dvgbkc.Invoke(&((lzham_lzcompressor_coding_stats*)@this)->m_rep0_len1_stats, num2);
						}
						else
						{
							update_dvgbkc.Invoke(&((lzham_lzcompressor_coding_stats*)@this)->m_rep0_len2_plus_stats, num2);
						}
					}
					return;
				}
				update_dvgbkc.Invoke((byte*)(&((lzham_lzcompressor_coding_stats*)@this)->m_full_match_stats) + (nint)minimum_y7839s.Invoke(257, num4) * (nint)sizeof(lzham_lzcompressor_tracked_stat), num2);
				if (num4 == 2)
				{
					if (((lzham_CLZDecompBase*)lzdec)->m_match_hist <= 512)
					{
						((lzham_lzcompressor_coding_stats*)@this)->m_total_near_len2_matches++;
					}
					else
					{
						((lzham_lzcompressor_coding_stats*)@this)->m_total_far_len2_matches++;
					}
					((lzham_lzcompressor_coding_stats*)@this)->m_max_len2_dist = ((((lzham_lzcompressor_coding_stats*)@this)->m_max_len2_dist >= ((lzham_CLZDecompBase*)lzdec)->m_match_hist) ? ((lzham_lzcompressor_coding_stats*)@this)->m_max_len2_dist : ((lzham_CLZDecompBase*)lzdec)->m_match_hist);
				}
			}
		}
	}
}
