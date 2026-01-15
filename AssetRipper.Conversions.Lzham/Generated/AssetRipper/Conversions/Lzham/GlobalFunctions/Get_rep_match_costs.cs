using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?get_rep_match_costs@state@lzcompressor@lzham@@QEBAXIPEA_KIHHI@Z")]
[DemangledName("public: void __cdecl lzham::lzcompressor::state::get_rep_match_costs(unsigned int, unsigned __int64 *, unsigned int, int, int, unsigned int) const")]
internal static partial class Get_rep_match_costs
{
	[return: NativeType("void")]
	public unsafe static void Invoke(void* @this, [NativeType("unsigned int")] int dict_pos, [NativeType("unsigned __int64 *")] void* pBitcosts, [NativeType("unsigned int")] int match_hist_index, [NativeType("int")] int min_len, [NativeType("int")] int max_len, [NativeType("unsigned int")] int is_match_model_index)
	{
		int num = min_len;
		unchecked
		{
			void* ptr = (byte*)(&((lzham_lzcompressor_state*)@this)->field_11) + (((uint)((lzham_lzcompressor_state_base*)@this)->m_cur_state >= 7u) ? ((nint)1) : ((nint)0)) * (nint)sizeof(lzham_quasi_adaptive_huffman_data_model);
			long num2 = Get_cost_2mqzjn.Invoke((byte*)(&((lzham_lzcompressor_state*)@this)->field_2) + (nint)(uint)is_match_model_index * (nint)sizeof(lzham_adaptive_bit_model), 1) + Get_cost_2mqzjn.Invoke((byte*)(&((lzham_lzcompressor_state*)@this)->field_3) + (nint)(uint)((lzham_lzcompressor_state_base*)@this)->m_cur_state * (nint)sizeof(lzham_adaptive_bit_model), 1);
			if (match_hist_index == 0)
			{
				num2 += Get_cost_2mqzjn.Invoke((byte*)(&((lzham_lzcompressor_state*)@this)->field_4) + (nint)(uint)((lzham_lzcompressor_state_base*)@this)->m_cur_state * (nint)sizeof(lzham_adaptive_bit_model), 1);
			}
			else
			{
				num2 += Get_cost_2mqzjn.Invoke((byte*)(&((lzham_lzcompressor_state*)@this)->field_4) + (nint)(uint)((lzham_lzcompressor_state_base*)@this)->m_cur_state * (nint)sizeof(lzham_adaptive_bit_model), 0);
				if (match_hist_index == 1)
				{
					num2 += Get_cost_2mqzjn.Invoke((byte*)(&((lzham_lzcompressor_state*)@this)->field_6) + (nint)(uint)((lzham_lzcompressor_state_base*)@this)->m_cur_state * (nint)sizeof(lzham_adaptive_bit_model), 1);
				}
				else
				{
					num2 += Get_cost_2mqzjn.Invoke((byte*)(&((lzham_lzcompressor_state*)@this)->field_6) + (nint)(uint)((lzham_lzcompressor_state_base*)@this)->m_cur_state * (nint)sizeof(lzham_adaptive_bit_model), 0);
					num2 = ((match_hist_index != 2) ? (num2 + Get_cost_2mqzjn.Invoke((byte*)(&((lzham_lzcompressor_state*)@this)->field_7) + (nint)(uint)((lzham_lzcompressor_state_base*)@this)->m_cur_state * (nint)sizeof(lzham_adaptive_bit_model), 0)) : (num2 + Get_cost_2mqzjn.Invoke((byte*)(&((lzham_lzcompressor_state*)@this)->field_7) + (nint)(uint)((lzham_lzcompressor_state_base*)@this)->m_cur_state * (nint)sizeof(lzham_adaptive_bit_model), 1)));
				}
			}
			if (match_hist_index == 0)
			{
				if (num == 1)
				{
					((long*)pBitcosts)[1] = num2 + Get_cost_2mqzjn.Invoke((byte*)(&((lzham_lzcompressor_state*)@this)->field_5) + (nint)(uint)((lzham_lzcompressor_state_base*)@this)->m_cur_state * (nint)sizeof(lzham_adaptive_bit_model), 1);
					num = checked(num + 1);
				}
				long num3 = num2 + Get_cost_2mqzjn.Invoke((byte*)(&((lzham_lzcompressor_state*)@this)->field_5) + (nint)(uint)((lzham_lzcompressor_state_base*)@this)->m_cur_state * (nint)sizeof(lzham_adaptive_bit_model), 0);
				for (int i = num; i <= max_len; i = checked(i + 1))
				{
					if (i > 257)
					{
						((long*)pBitcosts)[i] = (uint)Get_huge_match_code_len.Invoke(i) + num3 + Get_cost_dep2td.Invoke(ptr, 256);
					}
					else
					{
						((long*)pBitcosts)[i] = num3 + Get_cost_dep2td.Invoke(ptr, checked(i - 2));
					}
				}
				return;
			}
			for (int j = num; j <= max_len; j = checked(j + 1))
			{
				if (j > 257)
				{
					((long*)pBitcosts)[j] = (uint)Get_huge_match_code_len.Invoke(j) + num2 + Get_cost_dep2td.Invoke(ptr, 256);
				}
				else
				{
					((long*)pBitcosts)[j] = num2 + Get_cost_dep2td.Invoke(ptr, checked(j - 2));
				}
			}
		}
	}
}
