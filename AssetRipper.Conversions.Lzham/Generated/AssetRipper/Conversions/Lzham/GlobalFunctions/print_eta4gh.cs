using System;
using AssetRipper.Conversions.Lzham.GlobalVariables;
using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?print@state@lzcompressor@lzham@@QEAAXAEAVsymbol_codec@3@AEAUCLZBase@3@AEBVsearch_accelerator@3@AEBUlzdecision@23@@Z")]
[DemangledName("public: void __cdecl lzham::lzcompressor::state::print(class lzham::symbol_codec &, struct lzham::CLZBase &, class lzham::search_accelerator const &, struct lzham::lzcompressor::lzdecision const &)")]
[CleanName("print")]
internal static partial class print_eta4gh
{
	[return: NativeType("void")]
	public unsafe static void Invoke(void* @this, [NativeType("class lzham::symbol_codec &")] void* codec, [NativeType("struct lzham::CLZBase &")] void* lzbase, [NativeType("class lzham::search_accelerator const &")] void* dict, [NativeType("struct lzham::lzcompressor::lzdecision const &")] void* lzdec)
	{
		int num = 0;
		int num2 = 0;
		unchecked
		{
			Get_pred_char.Invoke(@this, dict, ((lzham_CLZDecompBase*)lzdec)->m_cur_ofs, 1);
			_ = ((lzham_lzcompressor_state_base*)@this)->m_cur_state;
			_ = (double)((float)Get_cost_vhfk4j.Invoke(@this, lzbase, dict, lzdec) / 16777216f);
			is_match.Invoke(lzdec);
			_ = ((lzham_lzcompressor_state_base*)@this)->m_cur_state;
			_ = ((lzham_CLZDecompBase*)lzdec)->m_cur_ofs;
			printf.Invoke(String_h288ig.__pointer, default(ReadOnlySpan<nint>));
			if (!is_match.Invoke(lzdec))
			{
				int num3 = search_accelerator_Operator.Invoke(dict, ((lzham_CLZDecompBase*)lzdec)->m_cur_ofs);
				if ((uint)((lzham_lzcompressor_state_base*)@this)->m_cur_state < 7u)
				{
					switch (num3)
					{
					}
					printf.Invoke(String_fadq34.__pointer, default(ReadOnlySpan<nint>));
					return;
				}
				switch (search_accelerator_Operator.Invoke(dict, (((lzham_CLZDecompBase*)lzdec)->m_cur_ofs - *(int*)(&((lzham_lzcompressor_state_base*)@this)->m_match_hist)) & ((lzham_search_accelerator*)dict)->m_max_dict_size_mask))
				{
				}
				switch (num3)
				{
				}
				printf.Invoke(String_eiv9zx.__pointer, default(ReadOnlySpan<nint>));
				return;
			}
			int num4 = Get_match_len.Invoke(dict, 0, Get_match_dist.Invoke(lzdec, @this), 257, 0);
			if (((lzham_CLZDecompBase*)lzdec)->m_match_hist < 0)
			{
				if (checked(-unchecked((lzham_CLZDecompBase*)lzdec)->m_match_hist - 1) == 0)
				{
					if (((lzham_CLZDecompBase*)lzdec)->m_cur_state == 1)
					{
						printf.Invoke(String_s9ddh6.__pointer, default(ReadOnlySpan<nint>));
					}
					else
					{
						_ = ((lzham_CLZDecompBase*)lzdec)->m_cur_state;
						printf.Invoke(String_3ut65i.__pointer, default(ReadOnlySpan<nint>));
					}
				}
				else
				{
					_ = ((lzham_CLZDecompBase*)lzdec)->m_cur_state;
					printf.Invoke(String_sitzh3.__pointer, default(ReadOnlySpan<nint>));
				}
			}
			else
			{
				compute_lzx_position_slot.Invoke(lzbase, ((lzham_CLZDecompBase*)lzdec)->m_match_hist, &num, &num2);
				checked
				{
					if (unchecked((lzham_CLZDecompBase*)lzdec)->m_cur_state >= 9)
					{
						_ = unchecked((lzham_CLZDecompBase*)lzdec)->m_cur_state - 9;
					}
					else
					{
						_ = unchecked((lzham_CLZDecompBase*)lzdec)->m_cur_state - 2;
					}
				}
				long num5 = (uint)num;
				int num6 = (byte)((sbyte*)m_lzx_position_extra_bits.__pointer)[num5];
				_ = ((lzham_CLZDecompBase*)lzdec)->m_match_hist;
				_ = ((lzham_CLZDecompBase*)lzdec)->m_cur_state;
				printf.Invoke(String_486qas.__pointer, default(ReadOnlySpan<nint>));
				if ((uint)num6 >= 3u)
				{
					_ = ((lzham_CLZDecompBase*)lzdec)->m_match_hist & 0xF;
					printf.Invoke(String_2kd87d.__pointer, default(ReadOnlySpan<nint>));
				}
				printf.Invoke(String_69wyxh.__pointer, default(ReadOnlySpan<nint>));
			}
			if ((uint)num4 > (uint)Get_len_wzf5xk.Invoke(lzdec))
			{
				_ = num4 - Get_len_wzf5xk.Invoke(lzdec);
				printf.Invoke(String_4d3wsk.__pointer, default(ReadOnlySpan<nint>));
			}
		}
	}
}
