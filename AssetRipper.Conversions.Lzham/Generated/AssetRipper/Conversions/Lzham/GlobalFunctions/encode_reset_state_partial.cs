using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?encode_reset_state_partial@state@lzcompressor@lzham@@QEAA_NAEAVsymbol_codec@3@AEBVsearch_accelerator@3@I@Z")]
[DemangledName("public: bool __cdecl lzham::lzcompressor::state::encode_reset_state_partial(class lzham::symbol_codec &, class lzham::search_accelerator const &, unsigned int)")]
internal static partial class encode_reset_state_partial
{
	[return: NativeType("bool")]
	public unsafe static bool Invoke(void* @this, [NativeType("class lzham::symbol_codec &")] void* codec, [NativeType("class lzham::search_accelerator const &")] void* dict, [NativeType("unsigned int")] int dict_pos)
	{
		unchecked
		{
			int cur_state = ((lzham_lzcompressor_state_base*)@this)->m_cur_state;
			bool flag = encode_ay6s5b.Invoke(codec, 1, (byte*)(&((lzham_lzcompressor_state*)@this)->field_2) + (nint)(uint)cur_state * (nint)sizeof(lzham_adaptive_bit_model), update_model: true);
			if (ExceptionInfo.Current != null)
			{
				return false;
			}
			if (!flag)
			{
				return false;
			}
			bool flag2 = encode_ay6s5b.Invoke(codec, 0, (byte*)(&((lzham_lzcompressor_state*)@this)->field_3) + (nint)(uint)((lzham_lzcompressor_state_base*)@this)->m_cur_state * (nint)sizeof(lzham_adaptive_bit_model), update_model: true);
			if (ExceptionInfo.Current != null)
			{
				return false;
			}
			if (!flag2)
			{
				return false;
			}
			bool flag3 = encode_gbd3f5.Invoke(codec, 1, &((lzham_lzcompressor_state*)@this)->field_10);
			if (ExceptionInfo.Current != null)
			{
				return false;
			}
			if (!flag3)
			{
				return false;
			}
			reset_state_partial.Invoke(@this);
			return true;
		}
	}
}
