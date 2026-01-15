using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?get_lit_cost@state@lzcompressor@lzham@@QEBA_KAEAUCLZBase@3@AEBVsearch_accelerator@3@III@Z")]
[DemangledName("public: unsigned __int64 __cdecl lzham::lzcompressor::state::get_lit_cost(struct lzham::CLZBase &, class lzham::search_accelerator const &, unsigned int, unsigned int, unsigned int) const")]
internal static partial class Get_lit_cost
{
	[return: NativeType("unsigned __int64")]
	public unsafe static long Invoke(void* @this, [NativeType("struct lzham::CLZBase &")] void* lzbase, [NativeType("class lzham::search_accelerator const &")] void* dict, [NativeType("unsigned int")] int dict_pos, [NativeType("unsigned int")] int lit_pred0, [NativeType("unsigned int")] int is_match_model_index)
	{
		unchecked
		{
			long num = Get_cost_2mqzjn.Invoke((byte*)(&((lzham_lzcompressor_state*)@this)->field_2) + (nint)(uint)is_match_model_index * (nint)sizeof(lzham_adaptive_bit_model), 0);
			int num2 = search_accelerator_Operator.Invoke(dict, dict_pos);
			if ((uint)((lzham_lzcompressor_state_base*)@this)->m_cur_state < 7u)
			{
				return num + Get_cost_dep2td.Invoke(&((lzham_lzcompressor_state*)@this)->field_8, num2);
			}
			return num + Get_cost_dep2td.Invoke(sym: search_accelerator_Operator.Invoke(dict, (dict_pos - *(int*)(&((lzham_lzcompressor_state_base*)@this)->m_match_hist)) & ((lzham_search_accelerator*)dict)->m_max_dict_size_mask) ^ num2, @this: &((lzham_lzcompressor_state*)@this)->field_9);
		}
	}
}
