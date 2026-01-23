using System;
using AssetRipper.Conversions.Lzham.GlobalVariables;
using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?print@coding_stats@lzcompressor@lzham@@QEAAXXZ")]
[DemangledName("public: void __cdecl lzham::lzcompressor::coding_stats::print(void)")]
[CleanName("print")]
internal static partial class print_zz7k6m
{
	[return: NativeType("void")]
	public unsafe static void Invoke(void* @this)
	{
		unchecked
		{
			if (((lzham_lzcompressor_coding_stats*)@this)->m_total_contexts != 0)
			{
				printf.Invoke(String_npt3bn.Pointer, default(ReadOnlySpan<nint>));
				printf.Invoke(String_rx79g7.Pointer, default(ReadOnlySpan<nint>));
				_ = ((lzham_lzcompressor_coding_stats*)@this)->m_total_update_rate_resets;
				printf.Invoke(String_yv8y8d.Pointer, default(ReadOnlySpan<nint>));
				Get_max_val.Invoke(&((lzham_lzcompressor_coding_stats*)@this)->m_context_stats);
				Get_min_val.Invoke(&((lzham_lzcompressor_coding_stats*)@this)->m_context_stats);
				Get_std_dev.Invoke(&((lzham_lzcompressor_coding_stats*)@this)->m_context_stats);
				Get_average.Invoke(&((lzham_lzcompressor_coding_stats*)@this)->m_context_stats);
				_ = ((lzham_lzcompressor_coding_stats*)@this)->m_total_cost / 8.0;
				_ = ((lzham_lzcompressor_coding_stats*)@this)->m_total_cost;
				_ = ((lzham_lzcompressor_coding_stats*)@this)->m_total_contexts;
				_ = ((lzham_lzcompressor_coding_stats*)@this)->m_total_bytes;
				printf.Invoke(String_f4ahxf.Pointer, default(ReadOnlySpan<nint>));
				_ = (double)((float)((lzham_lzcompressor_coding_stats*)@this)->m_total_bytes / (float)((lzham_lzcompressor_coding_stats*)@this)->m_total_contexts);
				printf.Invoke(String_vudj64.Pointer, default(ReadOnlySpan<nint>));
				printf.Invoke(String_timpwh.Pointer, default(ReadOnlySpan<nint>));
				_ = ((lzham_lzcompressor_coding_stats*)@this)->m_worst_match_bits_cost;
				_ = ((lzham_lzcompressor_coding_stats*)@this)->m_total_match_bits_cost / (double)maximum_95ffuu.Invoke(1, ((lzham_lzcompressor_coding_stats*)@this)->m_total_contexts);
				_ = ((lzham_lzcompressor_coding_stats*)@this)->m_total_match_bits_cost / 8.0;
				_ = ((lzham_lzcompressor_coding_stats*)@this)->m_total_match_bits_cost;
				_ = ((lzham_lzcompressor_coding_stats*)@this)->m_total_contexts;
				printf.Invoke(String_e29b4t.Pointer, default(ReadOnlySpan<nint>));
				_ = ((lzham_lzcompressor_coding_stats*)@this)->m_total_is_match0_bits_cost / (double)maximum_95ffuu.Invoke(1, ((lzham_lzcompressor_coding_stats*)@this)->m_total_nonmatches);
				_ = ((lzham_lzcompressor_coding_stats*)@this)->m_total_is_match0_bits_cost / 8.0;
				_ = ((lzham_lzcompressor_coding_stats*)@this)->m_total_is_match0_bits_cost;
				_ = ((lzham_lzcompressor_coding_stats*)@this)->m_total_nonmatches;
				printf.Invoke(String_9b8hig.Pointer, default(ReadOnlySpan<nint>));
				_ = ((lzham_lzcompressor_coding_stats*)@this)->m_total_is_match1_bits_cost / (double)maximum_95ffuu.Invoke(1, ((lzham_lzcompressor_coding_stats*)@this)->m_total_matches);
				_ = ((lzham_lzcompressor_coding_stats*)@this)->m_total_is_match1_bits_cost / 8.0;
				_ = ((lzham_lzcompressor_coding_stats*)@this)->m_total_is_match1_bits_cost;
				_ = ((lzham_lzcompressor_coding_stats*)@this)->m_total_matches;
				printf.Invoke(String_i6ccyf.Pointer, default(ReadOnlySpan<nint>));
				printf.Invoke(String_xa9qi5.Pointer, default(ReadOnlySpan<nint>));
				Get_max_val.Invoke(&((lzham_lzcompressor_coding_stats*)@this)->m_lit_stats);
				Get_min_val.Invoke(&((lzham_lzcompressor_coding_stats*)@this)->m_lit_stats);
				Get_std_dev.Invoke(&((lzham_lzcompressor_coding_stats*)@this)->m_lit_stats);
				Get_average.Invoke(&((lzham_lzcompressor_coding_stats*)@this)->m_lit_stats);
				_ = Get_total.Invoke(&((lzham_lzcompressor_coding_stats*)@this)->m_lit_stats) / 8.0;
				Get_total.Invoke(&((lzham_lzcompressor_coding_stats*)@this)->m_lit_stats);
				Get_number_of_values32.Invoke(&((lzham_lzcompressor_coding_stats*)@this)->m_lit_stats);
				printf.Invoke(String_fague4.Pointer, default(ReadOnlySpan<nint>));
				printf.Invoke(String_yaa426.Pointer, default(ReadOnlySpan<nint>));
				Get_max_val.Invoke(&((lzham_lzcompressor_coding_stats*)@this)->m_delta_lit_stats);
				Get_min_val.Invoke(&((lzham_lzcompressor_coding_stats*)@this)->m_delta_lit_stats);
				Get_std_dev.Invoke(&((lzham_lzcompressor_coding_stats*)@this)->m_delta_lit_stats);
				Get_average.Invoke(&((lzham_lzcompressor_coding_stats*)@this)->m_delta_lit_stats);
				_ = Get_total.Invoke(&((lzham_lzcompressor_coding_stats*)@this)->m_delta_lit_stats) / 8.0;
				Get_total.Invoke(&((lzham_lzcompressor_coding_stats*)@this)->m_delta_lit_stats);
				Get_number_of_values32.Invoke(&((lzham_lzcompressor_coding_stats*)@this)->m_delta_lit_stats);
				printf.Invoke(String_fague4.Pointer, default(ReadOnlySpan<nint>));
				printf.Invoke(String_jnf25f.Pointer, default(ReadOnlySpan<nint>));
				Get_max_val.Invoke(&((lzham_lzcompressor_coding_stats*)@this)->m_rep0_len1_stats);
				Get_min_val.Invoke(&((lzham_lzcompressor_coding_stats*)@this)->m_rep0_len1_stats);
				Get_std_dev.Invoke(&((lzham_lzcompressor_coding_stats*)@this)->m_rep0_len1_stats);
				Get_average.Invoke(&((lzham_lzcompressor_coding_stats*)@this)->m_rep0_len1_stats);
				_ = Get_total.Invoke(&((lzham_lzcompressor_coding_stats*)@this)->m_rep0_len1_stats) / 8.0;
				Get_total.Invoke(&((lzham_lzcompressor_coding_stats*)@this)->m_rep0_len1_stats);
				Get_number_of_values32.Invoke(&((lzham_lzcompressor_coding_stats*)@this)->m_rep0_len1_stats);
				printf.Invoke(String_kn3w39.Pointer, default(ReadOnlySpan<nint>));
				printf.Invoke(String_dpnkqw.Pointer, default(ReadOnlySpan<nint>));
				Get_max_val.Invoke(&((lzham_lzcompressor_coding_stats*)@this)->m_rep0_len2_plus_stats);
				Get_min_val.Invoke(&((lzham_lzcompressor_coding_stats*)@this)->m_rep0_len2_plus_stats);
				Get_std_dev.Invoke(&((lzham_lzcompressor_coding_stats*)@this)->m_rep0_len2_plus_stats);
				Get_average.Invoke(&((lzham_lzcompressor_coding_stats*)@this)->m_rep0_len2_plus_stats);
				_ = Get_total.Invoke(&((lzham_lzcompressor_coding_stats*)@this)->m_rep0_len2_plus_stats) / 8.0;
				Get_total.Invoke(&((lzham_lzcompressor_coding_stats*)@this)->m_rep0_len2_plus_stats);
				Get_number_of_values32.Invoke(&((lzham_lzcompressor_coding_stats*)@this)->m_rep0_len2_plus_stats);
				printf.Invoke(String_kn3w39.Pointer, default(ReadOnlySpan<nint>));
				for (int i = 0; (uint)i < 4u; i++)
				{
					printf.Invoke(String_8n44gc.Pointer, default(ReadOnlySpan<nint>));
					Get_max_val.Invoke((byte*)(&((lzham_lzcompressor_coding_stats*)@this)->m_rep_stats) + (nint)(uint)i * (nint)sizeof(lzham_lzcompressor_tracked_stat));
					Get_min_val.Invoke((byte*)(&((lzham_lzcompressor_coding_stats*)@this)->m_rep_stats) + (nint)(uint)i * (nint)sizeof(lzham_lzcompressor_tracked_stat));
					Get_std_dev.Invoke((byte*)(&((lzham_lzcompressor_coding_stats*)@this)->m_rep_stats) + (nint)(uint)i * (nint)sizeof(lzham_lzcompressor_tracked_stat));
					Get_average.Invoke((byte*)(&((lzham_lzcompressor_coding_stats*)@this)->m_rep_stats) + (nint)(uint)i * (nint)sizeof(lzham_lzcompressor_tracked_stat));
					_ = Get_total.Invoke((byte*)(&((lzham_lzcompressor_coding_stats*)@this)->m_rep_stats) + (nint)(uint)i * (nint)sizeof(lzham_lzcompressor_tracked_stat)) / 8.0;
					Get_total.Invoke((byte*)(&((lzham_lzcompressor_coding_stats*)@this)->m_rep_stats) + (nint)(uint)i * (nint)sizeof(lzham_lzcompressor_tracked_stat));
					Get_number_of_values32.Invoke((byte*)(&((lzham_lzcompressor_coding_stats*)@this)->m_rep_stats) + (nint)(uint)i * (nint)sizeof(lzham_lzcompressor_tracked_stat));
					printf.Invoke(String_kn3w39.Pointer, default(ReadOnlySpan<nint>));
				}
				for (int j = 2; (uint)j <= 257u; j++)
				{
					Get_max_val.Invoke((byte*)(&((lzham_lzcompressor_coding_stats*)@this)->m_full_match_stats) + (nint)(uint)j * (nint)sizeof(lzham_lzcompressor_tracked_stat));
					Get_min_val.Invoke((byte*)(&((lzham_lzcompressor_coding_stats*)@this)->m_full_match_stats) + (nint)(uint)j * (nint)sizeof(lzham_lzcompressor_tracked_stat));
					Get_std_dev.Invoke((byte*)(&((lzham_lzcompressor_coding_stats*)@this)->m_full_match_stats) + (nint)(uint)j * (nint)sizeof(lzham_lzcompressor_tracked_stat));
					Get_average.Invoke((byte*)(&((lzham_lzcompressor_coding_stats*)@this)->m_full_match_stats) + (nint)(uint)j * (nint)sizeof(lzham_lzcompressor_tracked_stat));
					_ = Get_total.Invoke((byte*)(&((lzham_lzcompressor_coding_stats*)@this)->m_full_match_stats) + (nint)(uint)j * (nint)sizeof(lzham_lzcompressor_tracked_stat)) / 8.0;
					Get_total.Invoke((byte*)(&((lzham_lzcompressor_coding_stats*)@this)->m_full_match_stats) + (nint)(uint)j * (nint)sizeof(lzham_lzcompressor_tracked_stat));
					Get_number_of_values32.Invoke((byte*)(&((lzham_lzcompressor_coding_stats*)@this)->m_full_match_stats) + (nint)(uint)j * (nint)sizeof(lzham_lzcompressor_tracked_stat));
					printf.Invoke(String_cijmf9.Pointer, default(ReadOnlySpan<nint>));
				}
				_ = ((lzham_lzcompressor_coding_stats*)@this)->m_total_far_len2_matches;
				_ = ((lzham_lzcompressor_coding_stats*)@this)->m_total_near_len2_matches;
				printf.Invoke(String_wgkvsw.Pointer, default(ReadOnlySpan<nint>));
				_ = ((lzham_lzcompressor_coding_stats*)@this)->m_total_truncated_matches;
				_ = ((lzham_lzcompressor_coding_stats*)@this)->m_total_matches;
				printf.Invoke(String_id92h6.Pointer, default(ReadOnlySpan<nint>));
				_ = ((lzham_lzcompressor_coding_stats*)@this)->m_max_len2_dist;
				printf.Invoke(String_r7bdmb.Pointer, default(ReadOnlySpan<nint>));
			}
		}
	}
}
