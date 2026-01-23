using AssetRipper.Conversions.Lzham.GlobalVariables;
using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?get_cost@state@lzcompressor@lzham@@QEBA_KAEAUCLZBase@3@AEBVsearch_accelerator@3@AEBUlzdecision@23@@Z")]
[DemangledName("public: unsigned __int64 __cdecl lzham::lzcompressor::state::get_cost(struct lzham::CLZBase &, class lzham::search_accelerator const &, struct lzham::lzcompressor::lzdecision const &) const")]
[CleanName("Get_cost")]
internal static partial class Get_cost_vhfk4j
{
	[return: NativeType("unsigned __int64")]
	public unsafe static long Invoke(void* @this, [NativeType("struct lzham::CLZBase &")] void* lzbase, [NativeType("class lzham::search_accelerator const &")] void* dict, [NativeType("struct lzham::lzcompressor::lzdecision const &")] void* lzdec)
	{
		int num = 0;
		int num2 = 0;
		unchecked
		{
			int cur_state = ((lzham_lzcompressor_state_base*)@this)->m_cur_state;
			long num3 = Get_cost_2mqzjn.Invoke((byte*)(&((lzham_lzcompressor_state*)@this)->field_2) + (nint)(uint)cur_state * (nint)sizeof(lzham_adaptive_bit_model), is_match.Invoke(lzdec) ? 1 : 0);
			if (!is_match.Invoke(lzdec))
			{
				int num4 = search_accelerator_Operator.Invoke(dict, ((lzham_CLZDecompBase*)lzdec)->m_cur_ofs);
				if ((uint)((lzham_lzcompressor_state_base*)@this)->m_cur_state < 7u)
				{
					return num3 + Get_cost_dep2td.Invoke(&((lzham_lzcompressor_state*)@this)->field_8, num4);
				}
				return num3 + Get_cost_dep2td.Invoke(sym: search_accelerator_Operator.Invoke(dict, (((lzham_CLZDecompBase*)lzdec)->m_cur_ofs - *(int*)(&((lzham_lzcompressor_state_base*)@this)->m_match_hist)) & ((lzham_search_accelerator*)dict)->m_max_dict_size_mask) ^ num4, @this: &((lzham_lzcompressor_state*)@this)->field_9);
			}
			if (((lzham_CLZDecompBase*)lzdec)->m_match_hist < 0)
			{
				num3 += Get_cost_2mqzjn.Invoke((byte*)(&((lzham_lzcompressor_state*)@this)->field_3) + (nint)(uint)((lzham_lzcompressor_state_base*)@this)->m_cur_state * (nint)sizeof(lzham_adaptive_bit_model), 1);
				int num5;
				checked
				{
					num5 = -unchecked((lzham_CLZDecompBase*)lzdec)->m_match_hist - 1;
				}
				if (num5 == 0)
				{
					num3 += Get_cost_2mqzjn.Invoke((byte*)(&((lzham_lzcompressor_state*)@this)->field_4) + (nint)(uint)((lzham_lzcompressor_state_base*)@this)->m_cur_state * (nint)sizeof(lzham_adaptive_bit_model), 1);
					if (((lzham_CLZDecompBase*)lzdec)->m_cur_state == 1)
					{
						return num3 + Get_cost_2mqzjn.Invoke((byte*)(&((lzham_lzcompressor_state*)@this)->field_5) + (nint)(uint)((lzham_lzcompressor_state_base*)@this)->m_cur_state * (nint)sizeof(lzham_adaptive_bit_model), 1);
					}
					num3 += Get_cost_2mqzjn.Invoke((byte*)(&((lzham_lzcompressor_state*)@this)->field_5) + (nint)(uint)((lzham_lzcompressor_state_base*)@this)->m_cur_state * (nint)sizeof(lzham_adaptive_bit_model), 0);
					if (((lzham_CLZDecompBase*)lzdec)->m_cur_state > 257)
					{
						return num3 + ((uint)Get_huge_match_code_len.Invoke(((lzham_CLZDecompBase*)lzdec)->m_cur_state) + Get_cost_dep2td.Invoke((byte*)(&((lzham_lzcompressor_state*)@this)->field_11) + (((uint)((lzham_lzcompressor_state_base*)@this)->m_cur_state >= 7u) ? ((nint)1) : ((nint)0)) * (nint)sizeof(lzham_quasi_adaptive_huffman_data_model), 256));
					}
					return num3 + Get_cost_dep2td.Invoke((byte*)(&((lzham_lzcompressor_state*)@this)->field_11) + (((uint)((lzham_lzcompressor_state_base*)@this)->m_cur_state >= 7u) ? ((nint)1) : ((nint)0)) * (nint)sizeof(lzham_quasi_adaptive_huffman_data_model), checked(unchecked((lzham_CLZDecompBase*)lzdec)->m_cur_state - 2));
				}
				num3 = ((((lzham_CLZDecompBase*)lzdec)->m_cur_state <= 257) ? (num3 + Get_cost_dep2td.Invoke((byte*)(&((lzham_lzcompressor_state*)@this)->field_11) + (((uint)((lzham_lzcompressor_state_base*)@this)->m_cur_state >= 7u) ? ((nint)1) : ((nint)0)) * (nint)sizeof(lzham_quasi_adaptive_huffman_data_model), checked(unchecked((lzham_CLZDecompBase*)lzdec)->m_cur_state - 2))) : (num3 + ((uint)Get_huge_match_code_len.Invoke(((lzham_CLZDecompBase*)lzdec)->m_cur_state) + Get_cost_dep2td.Invoke((byte*)(&((lzham_lzcompressor_state*)@this)->field_11) + (((uint)((lzham_lzcompressor_state_base*)@this)->m_cur_state >= 7u) ? ((nint)1) : ((nint)0)) * (nint)sizeof(lzham_quasi_adaptive_huffman_data_model), 256)))) + Get_cost_2mqzjn.Invoke((byte*)(&((lzham_lzcompressor_state*)@this)->field_4) + (nint)(uint)((lzham_lzcompressor_state_base*)@this)->m_cur_state * (nint)sizeof(lzham_adaptive_bit_model), 0);
				if (num5 == 1)
				{
					return num3 + Get_cost_2mqzjn.Invoke((byte*)(&((lzham_lzcompressor_state*)@this)->field_6) + (nint)(uint)((lzham_lzcompressor_state_base*)@this)->m_cur_state * (nint)sizeof(lzham_adaptive_bit_model), 1);
				}
				num3 += Get_cost_2mqzjn.Invoke((byte*)(&((lzham_lzcompressor_state*)@this)->field_6) + (nint)(uint)((lzham_lzcompressor_state_base*)@this)->m_cur_state * (nint)sizeof(lzham_adaptive_bit_model), 0);
				if (num5 == 2)
				{
					return num3 + Get_cost_2mqzjn.Invoke((byte*)(&((lzham_lzcompressor_state*)@this)->field_7) + (nint)(uint)((lzham_lzcompressor_state_base*)@this)->m_cur_state * (nint)sizeof(lzham_adaptive_bit_model), 1);
				}
				return num3 + Get_cost_2mqzjn.Invoke((byte*)(&((lzham_lzcompressor_state*)@this)->field_7) + (nint)(uint)((lzham_lzcompressor_state_base*)@this)->m_cur_state * (nint)sizeof(lzham_adaptive_bit_model), 0);
			}
			num3 += Get_cost_2mqzjn.Invoke((byte*)(&((lzham_lzcompressor_state*)@this)->field_3) + (nint)(uint)((lzham_lzcompressor_state_base*)@this)->m_cur_state * (nint)sizeof(lzham_adaptive_bit_model), 0);
			compute_lzx_position_slot.Invoke(lzbase, ((lzham_CLZDecompBase*)lzdec)->m_match_hist, &num, &num2);
			int num6;
			if (((lzham_CLZDecompBase*)lzdec)->m_cur_state >= 9)
			{
				num6 = 7;
				num3 = ((((lzham_CLZDecompBase*)lzdec)->m_cur_state <= 257) ? (num3 + Get_cost_dep2td.Invoke((byte*)(&((lzham_lzcompressor_state*)@this)->field_12) + (((uint)((lzham_lzcompressor_state_base*)@this)->m_cur_state >= 7u) ? ((nint)1) : ((nint)0)) * (nint)sizeof(lzham_quasi_adaptive_huffman_data_model), checked(unchecked((lzham_CLZDecompBase*)lzdec)->m_cur_state - 9))) : (num3 + ((uint)Get_huge_match_code_len.Invoke(((lzham_CLZDecompBase*)lzdec)->m_cur_state) + Get_cost_dep2td.Invoke((byte*)(&((lzham_lzcompressor_state*)@this)->field_12) + (((uint)((lzham_lzcompressor_state_base*)@this)->m_cur_state >= 7u) ? ((nint)1) : ((nint)0)) * (nint)sizeof(lzham_quasi_adaptive_huffman_data_model), 249))));
			}
			else
			{
				checked
				{
					num6 = unchecked((lzham_CLZDecompBase*)lzdec)->m_cur_state - 2;
				}
			}
			num3 += Get_cost_dep2td.Invoke(&((lzham_lzcompressor_state*)@this)->field_10, 2 + (num6 | (num - 1 << 3)));
			long num7 = (uint)num;
			int num8 = (byte)((sbyte*)m_lzx_position_extra_bits.Pointer)[num7];
			switch (num8)
			{
			case 0:
			case 1:
			case 2:
				return num3 + convert_to_scaled_bitcost.Invoke(num8);
			default:
				num3 += convert_to_scaled_bitcost.Invoke(num8 - 4);
				break;
			case 3:
			case 4:
				break;
			}
			return num3 + Get_cost_dep2td.Invoke(&((lzham_lzcompressor_state*)@this)->field_13, num2 & 0xF);
		}
	}
}
