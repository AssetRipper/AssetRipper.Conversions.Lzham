using AssetRipper.Conversions.Lzham.GlobalVariables;
using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?get_len2_match_cost@state@lzcompressor@lzham@@QEAA_KAEAUCLZBase@3@III@Z")]
[DemangledName("public: unsigned __int64 __cdecl lzham::lzcompressor::state::get_len2_match_cost(struct lzham::CLZBase &, unsigned int, unsigned int, unsigned int)")]
internal static partial class Get_len2_match_cost
{
	[return: NativeType("unsigned __int64")]
	public unsafe static long Invoke(void* @this, [NativeType("struct lzham::CLZBase &")] void* lzbase, [NativeType("unsigned int")] int dict_pos, [NativeType("unsigned int")] int len2_match_dist, [NativeType("unsigned int")] int is_match_model_index)
	{
		int num = 0;
		int num2 = 0;
		unchecked
		{
			long num3 = Get_cost_2mqzjn.Invoke((byte*)(&((lzham_lzcompressor_state*)@this)->field_2) + (nint)(uint)is_match_model_index * (nint)sizeof(lzham_adaptive_bit_model), 1) + Get_cost_2mqzjn.Invoke((byte*)(&((lzham_lzcompressor_state*)@this)->field_3) + (nint)(uint)((lzham_lzcompressor_state_base*)@this)->m_cur_state * (nint)sizeof(lzham_adaptive_bit_model), 0);
			compute_lzx_position_slot.Invoke(lzbase, len2_match_dist, &num, &num2);
			num3 += Get_cost_dep2td.Invoke(&((lzham_lzcompressor_state*)@this)->field_10, 2 + (0 | (num - 1 << 3)));
			long num4 = (uint)num;
			int num5 = (byte)((sbyte*)m_lzx_position_extra_bits.Pointer)[num4];
			switch (num5)
			{
			case 0:
			case 1:
			case 2:
				return num3 + convert_to_scaled_bitcost.Invoke(num5);
			default:
				num3 += convert_to_scaled_bitcost.Invoke(num5 - 4);
				break;
			case 3:
			case 4:
				break;
			}
			return num3 + Get_cost_dep2td.Invoke(&((lzham_lzcompressor_state*)@this)->field_13, num2 & 0xF);
		}
	}
}
