using AssetRipper.Conversions.Lzham.GlobalVariables;
using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?advance@state@lzcompressor@lzham@@QEAA_NAEAUCLZBase@3@AEBVsearch_accelerator@3@AEBUlzdecision@23@@Z")]
[DemangledName("public: bool __cdecl lzham::lzcompressor::state::advance(struct lzham::CLZBase &, class lzham::search_accelerator const &, struct lzham::lzcompressor::lzdecision const &)")]
internal static partial class advance
{
	private partial struct LocalVariables
	{
		public int field_0;

		public int field_1;
	}

	[return: NativeType("bool")]
	public unsafe static bool Invoke(void* @this, [NativeType("struct lzham::CLZBase &")] void* lzbase, [NativeType("class lzham::search_accelerator const &")] void* dict, [NativeType("struct lzham::lzcompressor::lzdecision const &")] void* lzdec)
	{
		StackFrame startFrame = StackFrameList.Current.New<LocalVariables>();
		LocalVariables* localsPointer = startFrame.GetLocalsPointer<LocalVariables>();
		localsPointer->field_0 = 0;
		localsPointer->field_1 = 0;
		bool flag2;
		int num2;
		unchecked
		{
			int cur_state = ((lzham_lzcompressor_state_base*)@this)->m_cur_state;
			update_yyeigq.Invoke((byte*)(&((lzham_lzcompressor_state*)@this)->field_2) + (nint)(uint)cur_state * (nint)sizeof(lzham_adaptive_bit_model), is_match.Invoke(lzdec) ? 1 : 0);
			if (!is_match.Invoke(lzdec))
			{
				int num = search_accelerator_Operator.Invoke(dict, ((lzham_CLZDecompBase*)lzdec)->m_cur_ofs);
				if ((uint)((lzham_lzcompressor_state_base*)@this)->m_cur_state < 7u)
				{
					bool flag = update_sym.Invoke(&((lzham_lzcompressor_state*)@this)->field_8, num);
					if (ExceptionInfo.Current != null)
					{
						return false;
					}
					if (flag)
					{
						goto IL_0120;
					}
					flag2 = false;
				}
				else
				{
					bool flag3 = update_sym.Invoke(sym: search_accelerator_Operator.Invoke(dict, (((lzham_CLZDecompBase*)lzdec)->m_cur_ofs - *(int*)(&((lzham_lzcompressor_state_base*)@this)->m_match_hist)) & ((lzham_search_accelerator*)dict)->m_max_dict_size_mask) ^ num, @this: &((lzham_lzcompressor_state*)@this)->field_9);
					if (ExceptionInfo.Current != null)
					{
						return false;
					}
					if (flag3)
					{
						goto IL_0120;
					}
					flag2 = false;
				}
			}
			else if (((lzham_CLZDecompBase*)lzdec)->m_match_hist < 0)
			{
				update_yyeigq.Invoke((byte*)(&((lzham_lzcompressor_state*)@this)->field_3) + (nint)(uint)((lzham_lzcompressor_state_base*)@this)->m_cur_state * (nint)sizeof(lzham_adaptive_bit_model), 1);
				checked
				{
					num2 = -unchecked((lzham_CLZDecompBase*)lzdec)->m_match_hist - 1;
				}
				if (num2 == 0)
				{
					update_yyeigq.Invoke((byte*)(&((lzham_lzcompressor_state*)@this)->field_4) + (nint)(uint)((lzham_lzcompressor_state_base*)@this)->m_cur_state * (nint)sizeof(lzham_adaptive_bit_model), 1);
					if (((lzham_CLZDecompBase*)lzdec)->m_cur_state == 1)
					{
						update_yyeigq.Invoke((byte*)(&((lzham_lzcompressor_state*)@this)->field_5) + (nint)(uint)((lzham_lzcompressor_state_base*)@this)->m_cur_state * (nint)sizeof(lzham_adaptive_bit_model), 1);
						((lzham_lzcompressor_state_base*)@this)->m_cur_state = InstructionHelper.Select((uint)((lzham_lzcompressor_state_base*)@this)->m_cur_state < 7u, 9, 11);
						goto IL_0761;
					}
					update_yyeigq.Invoke((byte*)(&((lzham_lzcompressor_state*)@this)->field_5) + (nint)(uint)((lzham_lzcompressor_state_base*)@this)->m_cur_state * (nint)sizeof(lzham_adaptive_bit_model), 0);
					if (((lzham_CLZDecompBase*)lzdec)->m_cur_state > 257)
					{
						bool flag4 = update_sym.Invoke((byte*)(&((lzham_lzcompressor_state*)@this)->field_11) + (((uint)((lzham_lzcompressor_state_base*)@this)->m_cur_state >= 7u) ? ((nint)1) : ((nint)0)) * (nint)sizeof(lzham_quasi_adaptive_huffman_data_model), 256);
						if (ExceptionInfo.Current != null)
						{
							return false;
						}
						if (flag4)
						{
							goto IL_02fe;
						}
						flag2 = false;
					}
					else
					{
						bool flag5 = update_sym.Invoke((byte*)(&((lzham_lzcompressor_state*)@this)->field_11) + (((uint)((lzham_lzcompressor_state_base*)@this)->m_cur_state >= 7u) ? ((nint)1) : ((nint)0)) * (nint)sizeof(lzham_quasi_adaptive_huffman_data_model), checked(unchecked((lzham_CLZDecompBase*)lzdec)->m_cur_state - 2));
						if (ExceptionInfo.Current != null)
						{
							return false;
						}
						if (flag5)
						{
							goto IL_02fe;
						}
						flag2 = false;
					}
				}
				else
				{
					update_yyeigq.Invoke((byte*)(&((lzham_lzcompressor_state*)@this)->field_4) + (nint)(uint)((lzham_lzcompressor_state_base*)@this)->m_cur_state * (nint)sizeof(lzham_adaptive_bit_model), 0);
					if (((lzham_CLZDecompBase*)lzdec)->m_cur_state > 257)
					{
						bool flag6 = update_sym.Invoke((byte*)(&((lzham_lzcompressor_state*)@this)->field_11) + (((uint)((lzham_lzcompressor_state_base*)@this)->m_cur_state >= 7u) ? ((nint)1) : ((nint)0)) * (nint)sizeof(lzham_quasi_adaptive_huffman_data_model), 256);
						if (ExceptionInfo.Current != null)
						{
							return false;
						}
						if (flag6)
						{
							goto IL_03e5;
						}
						flag2 = false;
					}
					else
					{
						bool flag7 = update_sym.Invoke((byte*)(&((lzham_lzcompressor_state*)@this)->field_11) + (((uint)((lzham_lzcompressor_state_base*)@this)->m_cur_state >= 7u) ? ((nint)1) : ((nint)0)) * (nint)sizeof(lzham_quasi_adaptive_huffman_data_model), checked(unchecked((lzham_CLZDecompBase*)lzdec)->m_cur_state - 2));
						if (ExceptionInfo.Current != null)
						{
							return false;
						}
						if (flag7)
						{
							goto IL_03e5;
						}
						flag2 = false;
					}
				}
			}
			else
			{
				update_yyeigq.Invoke((byte*)(&((lzham_lzcompressor_state*)@this)->field_3) + (nint)(uint)((lzham_lzcompressor_state_base*)@this)->m_cur_state * (nint)sizeof(lzham_adaptive_bit_model), 0);
				compute_lzx_position_slot.Invoke(lzbase, ((lzham_CLZDecompBase*)lzdec)->m_match_hist, &localsPointer->field_0, &localsPointer->field_1);
				int num3 = -1;
				int num4;
				checked
				{
					if (unchecked((lzham_CLZDecompBase*)lzdec)->m_cur_state >= 9)
					{
						num4 = 7;
						num3 = unchecked((lzham_CLZDecompBase*)lzdec)->m_cur_state - 9;
					}
					else
					{
						num4 = unchecked((lzham_CLZDecompBase*)lzdec)->m_cur_state - 2;
					}
				}
				bool flag8 = update_sym.Invoke(sym: 2 + (num4 | (localsPointer->field_0 - 1 << 3)), @this: &((lzham_lzcompressor_state*)@this)->field_10);
				if (ExceptionInfo.Current != null)
				{
					return false;
				}
				if (!flag8)
				{
					flag2 = false;
				}
				else
				{
					if (num3 < 0)
					{
						goto IL_06d5;
					}
					if (((lzham_CLZDecompBase*)lzdec)->m_cur_state > 257)
					{
						bool flag9 = update_sym.Invoke((byte*)(&((lzham_lzcompressor_state*)@this)->field_12) + (((uint)((lzham_lzcompressor_state_base*)@this)->m_cur_state >= 7u) ? ((nint)1) : ((nint)0)) * (nint)sizeof(lzham_quasi_adaptive_huffman_data_model), 249);
						if (ExceptionInfo.Current != null)
						{
							return false;
						}
						if (flag9)
						{
							goto IL_06d5;
						}
						flag2 = false;
					}
					else
					{
						bool flag10 = update_sym.Invoke((byte*)(&((lzham_lzcompressor_state*)@this)->field_12) + (((uint)((lzham_lzcompressor_state_base*)@this)->m_cur_state >= 7u) ? ((nint)1) : ((nint)0)) * (nint)sizeof(lzham_quasi_adaptive_huffman_data_model), num3);
						if (ExceptionInfo.Current != null)
						{
							return false;
						}
						if (flag10)
						{
							goto IL_06d5;
						}
						flag2 = false;
					}
				}
			}
			goto IL_077f;
		}
		IL_0120:
		unchecked
		{
			if ((uint)((lzham_lzcompressor_state_base*)@this)->m_cur_state < 4u)
			{
				((lzham_lzcompressor_state_base*)@this)->m_cur_state = 0;
			}
			else if ((uint)((lzham_lzcompressor_state_base*)@this)->m_cur_state < 10u)
			{
				((lzham_lzcompressor_state_base*)@this)->m_cur_state -= 3;
			}
			else
			{
				((lzham_lzcompressor_state_base*)@this)->m_cur_state -= 6;
			}
			goto IL_0761;
		}
		IL_03e5:
		unchecked
		{
			if (num2 == 1)
			{
				update_yyeigq.Invoke((byte*)(&((lzham_lzcompressor_state*)@this)->field_6) + (nint)(uint)((lzham_lzcompressor_state_base*)@this)->m_cur_state * (nint)sizeof(lzham_adaptive_bit_model), 1);
				swap_8qig99.Invoke(Right: (byte*)(&((lzham_lzcompressor_state_base*)@this)->m_match_hist) + 4, Left: &((lzham_lzcompressor_state_base*)@this)->m_match_hist);
			}
			else
			{
				update_yyeigq.Invoke((byte*)(&((lzham_lzcompressor_state*)@this)->field_6) + (nint)(uint)((lzham_lzcompressor_state_base*)@this)->m_cur_state * (nint)sizeof(lzham_adaptive_bit_model), 0);
				if (num2 == 2)
				{
					update_yyeigq.Invoke((byte*)(&((lzham_lzcompressor_state*)@this)->field_7) + (nint)(uint)((lzham_lzcompressor_state_base*)@this)->m_cur_state * (nint)sizeof(lzham_adaptive_bit_model), 1);
					int match_hist = ((int*)(&((lzham_lzcompressor_state_base*)@this)->m_match_hist))[2];
					int num5 = ((int*)(&((lzham_lzcompressor_state_base*)@this)->m_match_hist))[1];
					((int*)(&((lzham_lzcompressor_state_base*)@this)->m_match_hist))[2] = num5;
					int match_hist2 = *(int*)(&((lzham_lzcompressor_state_base*)@this)->m_match_hist);
					((int*)(&((lzham_lzcompressor_state_base*)@this)->m_match_hist))[1] = match_hist2;
					*(int*)(&((lzham_lzcompressor_state_base*)@this)->m_match_hist) = match_hist;
				}
				else
				{
					update_yyeigq.Invoke((byte*)(&((lzham_lzcompressor_state*)@this)->field_7) + (nint)(uint)((lzham_lzcompressor_state_base*)@this)->m_cur_state * (nint)sizeof(lzham_adaptive_bit_model), 0);
					int match_hist3 = ((int*)(&((lzham_lzcompressor_state_base*)@this)->m_match_hist))[3];
					int num6 = ((int*)(&((lzham_lzcompressor_state_base*)@this)->m_match_hist))[2];
					((int*)(&((lzham_lzcompressor_state_base*)@this)->m_match_hist))[3] = num6;
					int num7 = ((int*)(&((lzham_lzcompressor_state_base*)@this)->m_match_hist))[1];
					((int*)(&((lzham_lzcompressor_state_base*)@this)->m_match_hist))[2] = num7;
					int match_hist4 = *(int*)(&((lzham_lzcompressor_state_base*)@this)->m_match_hist);
					((int*)(&((lzham_lzcompressor_state_base*)@this)->m_match_hist))[1] = match_hist4;
					*(int*)(&((lzham_lzcompressor_state_base*)@this)->m_match_hist) = match_hist3;
				}
			}
			((lzham_lzcompressor_state_base*)@this)->m_cur_state = InstructionHelper.Select((uint)((lzham_lzcompressor_state_base*)@this)->m_cur_state < 7u, 8, 11);
			goto IL_0761;
		}
		IL_06d5:
		unchecked
		{
			long num8 = (uint)localsPointer->field_0;
			if ((uint)(byte)((sbyte*)m_lzx_position_extra_bits.__pointer)[num8] >= 3u)
			{
				bool flag11 = update_sym.Invoke(&((lzham_lzcompressor_state*)@this)->field_13, localsPointer->field_1 & 0xF);
				if (ExceptionInfo.Current != null)
				{
					return false;
				}
				if (!flag11)
				{
					flag2 = false;
					goto IL_077f;
				}
			}
			update_match_hist.Invoke(@this, ((lzham_CLZDecompBase*)lzdec)->m_match_hist);
			((lzham_lzcompressor_state_base*)@this)->m_cur_state = InstructionHelper.Select((uint)((lzham_lzcompressor_state_base*)@this)->m_cur_state < 7u, 7, 10);
			goto IL_0761;
		}
		IL_077f:
		bool result = flag2;
		StackFrameList.Current.Clear(startFrame);
		return result;
		IL_0761:
		unchecked
		{
			((lzham_lzcompressor_state_base*)@this)->m_cur_ofs = ((lzham_CLZDecompBase*)lzdec)->m_cur_ofs + Get_len_wzf5xk.Invoke(lzdec);
			flag2 = true;
			goto IL_077f;
		}
		IL_02fe:
		unchecked
		{
			((lzham_lzcompressor_state_base*)@this)->m_cur_state = InstructionHelper.Select((uint)((lzham_lzcompressor_state_base*)@this)->m_cur_state < 7u, 8, 11);
			goto IL_0761;
		}
	}
}
