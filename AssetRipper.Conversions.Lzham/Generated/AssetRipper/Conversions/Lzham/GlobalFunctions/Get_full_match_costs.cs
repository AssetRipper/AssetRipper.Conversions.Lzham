using AssetRipper.Conversions.Lzham.GlobalVariables;
using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?get_full_match_costs@state@lzcompressor@lzham@@QEBAXAEAUCLZBase@3@IPEA_KIHHI@Z")]
[DemangledName("public: void __cdecl lzham::lzcompressor::state::get_full_match_costs(struct lzham::CLZBase &, unsigned int, unsigned __int64 *, unsigned int, int, int, unsigned int) const")]
internal static partial class Get_full_match_costs
{
	[return: NativeType("void")]
	public unsafe static void Invoke(void* @this, [NativeType("struct lzham::CLZBase &")] void* lzbase, [NativeType("unsigned int")] int dict_pos, [NativeType("unsigned __int64 *")] void* pBitcosts, [NativeType("unsigned int")] int match_dist, [NativeType("int")] int min_len, [NativeType("int")] int max_len, [NativeType("unsigned int")] int is_match_model_index)
	{
		int num = 0;
		int num2 = 0;
		unchecked
		{
			long num3 = Get_cost_2mqzjn.Invoke((byte*)(&((lzham_lzcompressor_state*)@this)->field_2) + (nint)(uint)is_match_model_index * (nint)sizeof(lzham_adaptive_bit_model), 1) + Get_cost_2mqzjn.Invoke((byte*)(&((lzham_lzcompressor_state*)@this)->field_3) + (nint)(uint)((lzham_lzcompressor_state_base*)@this)->m_cur_state * (nint)sizeof(lzham_adaptive_bit_model), 0);
			compute_lzx_position_slot.Invoke(lzbase, match_dist, &num, &num2);
			long num4 = (uint)num;
			int num5 = (byte)((sbyte*)m_lzx_position_extra_bits.Pointer)[num4];
			if ((uint)num5 < 3u)
			{
				num3 += convert_to_scaled_bitcost.Invoke(num5);
			}
			else
			{
				if ((uint)num5 > 4u)
				{
					num3 += convert_to_scaled_bitcost.Invoke(num5 - 4);
				}
				num3 += Get_cost_dep2td.Invoke(&((lzham_lzcompressor_state*)@this)->field_13, num2 & 0xF);
			}
			int num6 = num - 1;
			void* ptr = (byte*)(&((lzham_lzcompressor_state*)@this)->field_12) + (((uint)((lzham_lzcompressor_state_base*)@this)->m_cur_state >= 7u) ? ((nint)1) : ((nint)0)) * (nint)sizeof(lzham_quasi_adaptive_huffman_data_model);
			for (int i = min_len; i <= max_len; i = checked(i + 1))
			{
				long num7 = num3;
				int num8;
				if (i >= 9)
				{
					num8 = 7;
					num7 = ((i <= 257) ? (num7 + Get_cost_dep2td.Invoke(ptr, checked(i - 9))) : (num7 + ((uint)Get_huge_match_code_len.Invoke(i) + Get_cost_dep2td.Invoke(ptr, 249))));
				}
				else
				{
					num8 = checked(i - 2);
				}
				((long*)pBitcosts)[i] = num7 + Get_cost_dep2td.Invoke(&((lzham_lzcompressor_state*)@this)->field_10, 2 + (num8 | (num6 << 3)));
			}
		}
	}
}
