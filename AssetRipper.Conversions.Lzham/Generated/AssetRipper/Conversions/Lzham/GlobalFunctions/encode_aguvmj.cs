using AssetRipper.Conversions.Lzham.GlobalVariables;
using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?encode@state@lzcompressor@lzham@@QEAA_NAEAVsymbol_codec@3@AEAUCLZBase@3@AEBVsearch_accelerator@3@AEBUlzdecision@23@@Z")]
[DemangledName("public: bool __cdecl lzham::lzcompressor::state::encode(class lzham::symbol_codec &, struct lzham::CLZBase &, class lzham::search_accelerator const &, struct lzham::lzcompressor::lzdecision const &)")]
[CleanName("encode")]
internal static partial class encode_aguvmj
{
	private partial struct LocalVariables
	{
		public int field_0;

		public int field_1;
	}

	[return: NativeType("bool")]
	public unsafe static bool Invoke(void* @this, [NativeType("class lzham::symbol_codec &")] void* codec, [NativeType("struct lzham::CLZBase &")] void* lzbase, [NativeType("class lzham::search_accelerator const &")] void* dict, [NativeType("struct lzham::lzcompressor::lzdecision const &")] void* lzdec)
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
			bool flag = encode_ay6s5b.Invoke(codec, model: (byte*)(&((lzham_lzcompressor_state*)@this)->field_2) + (nint)(uint)cur_state * (nint)sizeof(lzham_adaptive_bit_model), bit: is_match.Invoke(lzdec) ? 1 : 0, update_model: true);
			if (ExceptionInfo.Current != null)
			{
				return false;
			}
			if (!flag)
			{
				flag2 = false;
			}
			else if (!is_match.Invoke(lzdec))
			{
				int num = search_accelerator_Operator.Invoke(dict, ((lzham_CLZDecompBase*)lzdec)->m_cur_ofs);
				if ((uint)((lzham_lzcompressor_state_base*)@this)->m_cur_state < 7u)
				{
					bool flag3 = encode_gbd3f5.Invoke(codec, num, &((lzham_lzcompressor_state*)@this)->field_8);
					if (ExceptionInfo.Current != null)
					{
						return false;
					}
					if (flag3)
					{
						goto IL_0158;
					}
					flag2 = false;
				}
				else
				{
					bool flag4 = encode_gbd3f5.Invoke(codec, search_accelerator_Operator.Invoke(dict, (((lzham_CLZDecompBase*)lzdec)->m_cur_ofs - *(int*)(&((lzham_lzcompressor_state_base*)@this)->m_match_hist)) & ((lzham_search_accelerator*)dict)->m_max_dict_size_mask) ^ num, &((lzham_lzcompressor_state*)@this)->field_9);
					if (ExceptionInfo.Current != null)
					{
						return false;
					}
					if (flag4)
					{
						goto IL_0158;
					}
					flag2 = false;
				}
			}
			else if (((lzham_CLZDecompBase*)lzdec)->m_match_hist < 0)
			{
				bool flag5 = encode_ay6s5b.Invoke(codec, 1, (byte*)(&((lzham_lzcompressor_state*)@this)->field_3) + (nint)(uint)((lzham_lzcompressor_state_base*)@this)->m_cur_state * (nint)sizeof(lzham_adaptive_bit_model), update_model: true);
				if (ExceptionInfo.Current != null)
				{
					return false;
				}
				if (!flag5)
				{
					flag2 = false;
				}
				else
				{
					checked
					{
						num2 = -unchecked((lzham_CLZDecompBase*)lzdec)->m_match_hist - 1;
					}
					if (num2 == 0)
					{
						bool flag6 = encode_ay6s5b.Invoke(codec, 1, (byte*)(&((lzham_lzcompressor_state*)@this)->field_4) + (nint)(uint)((lzham_lzcompressor_state_base*)@this)->m_cur_state * (nint)sizeof(lzham_adaptive_bit_model), update_model: true);
						if (ExceptionInfo.Current != null)
						{
							return false;
						}
						if (!flag6)
						{
							flag2 = false;
						}
						else if (((lzham_CLZDecompBase*)lzdec)->m_cur_state == 1)
						{
							bool flag7 = encode_ay6s5b.Invoke(codec, 1, (byte*)(&((lzham_lzcompressor_state*)@this)->field_5) + (nint)(uint)((lzham_lzcompressor_state_base*)@this)->m_cur_state * (nint)sizeof(lzham_adaptive_bit_model), update_model: true);
							if (ExceptionInfo.Current != null)
							{
								return false;
							}
							if (flag7)
							{
								((lzham_lzcompressor_state_base*)@this)->m_cur_state = InstructionHelper.Select((uint)((lzham_lzcompressor_state_base*)@this)->m_cur_state < 7u, 9, 11);
								goto IL_0a2f;
							}
							flag2 = false;
						}
						else
						{
							bool flag8 = encode_ay6s5b.Invoke(codec, 0, (byte*)(&((lzham_lzcompressor_state*)@this)->field_5) + (nint)(uint)((lzham_lzcompressor_state_base*)@this)->m_cur_state * (nint)sizeof(lzham_adaptive_bit_model), update_model: true);
							if (ExceptionInfo.Current != null)
							{
								return false;
							}
							if (!flag8)
							{
								flag2 = false;
							}
							else if (((lzham_CLZDecompBase*)lzdec)->m_cur_state > 257)
							{
								bool flag9 = encode_gbd3f5.Invoke(codec, 256, (byte*)(&((lzham_lzcompressor_state*)@this)->field_11) + (((uint)((lzham_lzcompressor_state_base*)@this)->m_cur_state >= 7u) ? ((nint)1) : ((nint)0)) * (nint)sizeof(lzham_quasi_adaptive_huffman_data_model));
								if (ExceptionInfo.Current != null)
								{
									return false;
								}
								if (!flag9)
								{
									flag2 = false;
								}
								else
								{
									bool flag10 = encode_bits.Invoke(codec, num_bits: Get_huge_match_code_len.Invoke(((lzham_CLZDecompBase*)lzdec)->m_cur_state), bits: Get_huge_match_code_bits.Invoke(((lzham_CLZDecompBase*)lzdec)->m_cur_state));
									if (ExceptionInfo.Current != null)
									{
										return false;
									}
									if (flag10)
									{
										goto IL_0401;
									}
									flag2 = false;
								}
							}
							else
							{
								bool flag11 = encode_gbd3f5.Invoke(codec, model: (byte*)(&((lzham_lzcompressor_state*)@this)->field_11) + (((uint)((lzham_lzcompressor_state_base*)@this)->m_cur_state >= 7u) ? ((nint)1) : ((nint)0)) * (nint)sizeof(lzham_quasi_adaptive_huffman_data_model), sym: checked(unchecked((lzham_CLZDecompBase*)lzdec)->m_cur_state - 2));
								if (ExceptionInfo.Current != null)
								{
									return false;
								}
								if (flag11)
								{
									goto IL_0401;
								}
								flag2 = false;
							}
						}
					}
					else
					{
						bool flag12 = encode_ay6s5b.Invoke(codec, 0, (byte*)(&((lzham_lzcompressor_state*)@this)->field_4) + (nint)(uint)((lzham_lzcompressor_state_base*)@this)->m_cur_state * (nint)sizeof(lzham_adaptive_bit_model), update_model: true);
						if (ExceptionInfo.Current != null)
						{
							return false;
						}
						if (!flag12)
						{
							flag2 = false;
						}
						else if (((lzham_CLZDecompBase*)lzdec)->m_cur_state > 257)
						{
							bool flag13 = encode_gbd3f5.Invoke(codec, 256, (byte*)(&((lzham_lzcompressor_state*)@this)->field_11) + (((uint)((lzham_lzcompressor_state_base*)@this)->m_cur_state >= 7u) ? ((nint)1) : ((nint)0)) * (nint)sizeof(lzham_quasi_adaptive_huffman_data_model));
							if (ExceptionInfo.Current != null)
							{
								return false;
							}
							if (!flag13)
							{
								flag2 = false;
							}
							else
							{
								bool flag14 = encode_bits.Invoke(codec, num_bits: Get_huge_match_code_len.Invoke(((lzham_CLZDecompBase*)lzdec)->m_cur_state), bits: Get_huge_match_code_bits.Invoke(((lzham_CLZDecompBase*)lzdec)->m_cur_state));
								if (ExceptionInfo.Current != null)
								{
									return false;
								}
								if (flag14)
								{
									goto IL_0553;
								}
								flag2 = false;
							}
						}
						else
						{
							bool flag15 = encode_gbd3f5.Invoke(codec, model: (byte*)(&((lzham_lzcompressor_state*)@this)->field_11) + (((uint)((lzham_lzcompressor_state_base*)@this)->m_cur_state >= 7u) ? ((nint)1) : ((nint)0)) * (nint)sizeof(lzham_quasi_adaptive_huffman_data_model), sym: checked(unchecked((lzham_CLZDecompBase*)lzdec)->m_cur_state - 2));
							if (ExceptionInfo.Current != null)
							{
								return false;
							}
							if (flag15)
							{
								goto IL_0553;
							}
							flag2 = false;
						}
					}
				}
			}
			else
			{
				bool flag16 = encode_ay6s5b.Invoke(codec, 0, (byte*)(&((lzham_lzcompressor_state*)@this)->field_3) + (nint)(uint)((lzham_lzcompressor_state_base*)@this)->m_cur_state * (nint)sizeof(lzham_adaptive_bit_model), update_model: true);
				if (ExceptionInfo.Current != null)
				{
					return false;
				}
				if (!flag16)
				{
					flag2 = false;
				}
				else
				{
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
					bool flag17 = encode_gbd3f5.Invoke(codec, 2 + (num4 | (localsPointer->field_0 - 1 << 3)), &((lzham_lzcompressor_state*)@this)->field_10);
					if (ExceptionInfo.Current != null)
					{
						return false;
					}
					if (!flag17)
					{
						flag2 = false;
					}
					else
					{
						if (num3 < 0)
						{
							goto IL_0937;
						}
						if (((lzham_CLZDecompBase*)lzdec)->m_cur_state > 257)
						{
							bool flag18 = encode_gbd3f5.Invoke(codec, 249, (byte*)(&((lzham_lzcompressor_state*)@this)->field_12) + (((uint)((lzham_lzcompressor_state_base*)@this)->m_cur_state >= 7u) ? ((nint)1) : ((nint)0)) * (nint)sizeof(lzham_quasi_adaptive_huffman_data_model));
							if (ExceptionInfo.Current != null)
							{
								return false;
							}
							if (!flag18)
							{
								flag2 = false;
							}
							else
							{
								bool flag19 = encode_bits.Invoke(codec, num_bits: Get_huge_match_code_len.Invoke(((lzham_CLZDecompBase*)lzdec)->m_cur_state), bits: Get_huge_match_code_bits.Invoke(((lzham_CLZDecompBase*)lzdec)->m_cur_state));
								if (ExceptionInfo.Current != null)
								{
									return false;
								}
								if (flag19)
								{
									goto IL_0937;
								}
								flag2 = false;
							}
						}
						else
						{
							bool flag20 = encode_gbd3f5.Invoke(codec, num3, (byte*)(&((lzham_lzcompressor_state*)@this)->field_12) + (((uint)((lzham_lzcompressor_state_base*)@this)->m_cur_state >= 7u) ? ((nint)1) : ((nint)0)) * (nint)sizeof(lzham_quasi_adaptive_huffman_data_model));
							if (ExceptionInfo.Current != null)
							{
								return false;
							}
							if (flag20)
							{
								goto IL_0937;
							}
							flag2 = false;
						}
					}
				}
			}
			goto IL_0a4d;
		}
		IL_09f4:
		unchecked
		{
			update_match_hist.Invoke(@this, ((lzham_CLZDecompBase*)lzdec)->m_match_hist);
			((lzham_lzcompressor_state_base*)@this)->m_cur_state = InstructionHelper.Select((uint)((lzham_lzcompressor_state_base*)@this)->m_cur_state < 7u, 7, 10);
			goto IL_0a2f;
		}
		IL_0740:
		unchecked
		{
			((lzham_lzcompressor_state_base*)@this)->m_cur_state = InstructionHelper.Select((uint)((lzham_lzcompressor_state_base*)@this)->m_cur_state < 7u, 8, 11);
			goto IL_0a2f;
		}
		IL_0937:
		unchecked
		{
			long num5 = (uint)localsPointer->field_0;
			int num6 = (byte)((sbyte*)m_lzx_position_extra_bits.__pointer)[num5];
			if ((uint)num6 < 3u)
			{
				bool flag21 = encode_bits.Invoke(codec, localsPointer->field_1, num6);
				if (ExceptionInfo.Current != null)
				{
					return false;
				}
				if (flag21)
				{
					goto IL_09f4;
				}
				flag2 = false;
			}
			else
			{
				if ((uint)num6 > 4u)
				{
					bool flag22 = encode_bits.Invoke(codec, localsPointer->field_1 >>> 4, num6 - 4);
					if (ExceptionInfo.Current != null)
					{
						return false;
					}
					if (!flag22)
					{
						flag2 = false;
						goto IL_0a4d;
					}
				}
				bool flag23 = encode_gbd3f5.Invoke(codec, model: &((lzham_lzcompressor_state*)@this)->field_13, sym: localsPointer->field_1 & 0xF);
				if (ExceptionInfo.Current != null)
				{
					return false;
				}
				if (flag23)
				{
					goto IL_09f4;
				}
				flag2 = false;
			}
			goto IL_0a4d;
		}
		IL_0a4d:
		bool result = flag2;
		StackFrameList.Current.Clear(startFrame);
		return result;
		IL_0401:
		unchecked
		{
			((lzham_lzcompressor_state_base*)@this)->m_cur_state = InstructionHelper.Select((uint)((lzham_lzcompressor_state_base*)@this)->m_cur_state < 7u, 8, 11);
			goto IL_0a2f;
		}
		IL_0553:
		unchecked
		{
			if (num2 == 1)
			{
				bool flag24 = encode_ay6s5b.Invoke(codec, 1, (byte*)(&((lzham_lzcompressor_state*)@this)->field_6) + (nint)(uint)((lzham_lzcompressor_state_base*)@this)->m_cur_state * (nint)sizeof(lzham_adaptive_bit_model), update_model: true);
				if (ExceptionInfo.Current != null)
				{
					return false;
				}
				if (flag24)
				{
					swap_8qig99.Invoke(Right: (byte*)(&((lzham_lzcompressor_state_base*)@this)->m_match_hist) + 4, Left: &((lzham_lzcompressor_state_base*)@this)->m_match_hist);
					goto IL_0740;
				}
				flag2 = false;
			}
			else
			{
				bool flag25 = encode_ay6s5b.Invoke(codec, 0, (byte*)(&((lzham_lzcompressor_state*)@this)->field_6) + (nint)(uint)((lzham_lzcompressor_state_base*)@this)->m_cur_state * (nint)sizeof(lzham_adaptive_bit_model), update_model: true);
				if (ExceptionInfo.Current != null)
				{
					return false;
				}
				if (!flag25)
				{
					flag2 = false;
				}
				else if (num2 == 2)
				{
					bool flag26 = encode_ay6s5b.Invoke(codec, 1, (byte*)(&((lzham_lzcompressor_state*)@this)->field_7) + (nint)(uint)((lzham_lzcompressor_state_base*)@this)->m_cur_state * (nint)sizeof(lzham_adaptive_bit_model), update_model: true);
					if (ExceptionInfo.Current != null)
					{
						return false;
					}
					if (flag26)
					{
						int match_hist = ((int*)(&((lzham_lzcompressor_state_base*)@this)->m_match_hist))[2];
						int num7 = ((int*)(&((lzham_lzcompressor_state_base*)@this)->m_match_hist))[1];
						((int*)(&((lzham_lzcompressor_state_base*)@this)->m_match_hist))[2] = num7;
						int match_hist2 = *(int*)(&((lzham_lzcompressor_state_base*)@this)->m_match_hist);
						((int*)(&((lzham_lzcompressor_state_base*)@this)->m_match_hist))[1] = match_hist2;
						*(int*)(&((lzham_lzcompressor_state_base*)@this)->m_match_hist) = match_hist;
						goto IL_0740;
					}
					flag2 = false;
				}
				else
				{
					bool flag27 = encode_ay6s5b.Invoke(codec, 0, (byte*)(&((lzham_lzcompressor_state*)@this)->field_7) + (nint)(uint)((lzham_lzcompressor_state_base*)@this)->m_cur_state * (nint)sizeof(lzham_adaptive_bit_model), update_model: true);
					if (ExceptionInfo.Current != null)
					{
						return false;
					}
					if (flag27)
					{
						int match_hist3 = ((int*)(&((lzham_lzcompressor_state_base*)@this)->m_match_hist))[3];
						int num8 = ((int*)(&((lzham_lzcompressor_state_base*)@this)->m_match_hist))[2];
						((int*)(&((lzham_lzcompressor_state_base*)@this)->m_match_hist))[3] = num8;
						int num9 = ((int*)(&((lzham_lzcompressor_state_base*)@this)->m_match_hist))[1];
						((int*)(&((lzham_lzcompressor_state_base*)@this)->m_match_hist))[2] = num9;
						int match_hist4 = *(int*)(&((lzham_lzcompressor_state_base*)@this)->m_match_hist);
						((int*)(&((lzham_lzcompressor_state_base*)@this)->m_match_hist))[1] = match_hist4;
						*(int*)(&((lzham_lzcompressor_state_base*)@this)->m_match_hist) = match_hist3;
						goto IL_0740;
					}
					flag2 = false;
				}
			}
			goto IL_0a4d;
		}
		IL_0a2f:
		unchecked
		{
			((lzham_lzcompressor_state_base*)@this)->m_cur_ofs = ((lzham_CLZDecompBase*)lzdec)->m_cur_ofs + Get_len_wzf5xk.Invoke(lzdec);
			flag2 = true;
			goto IL_0a4d;
		}
		IL_0158:
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
			goto IL_0a2f;
		}
	}
}
