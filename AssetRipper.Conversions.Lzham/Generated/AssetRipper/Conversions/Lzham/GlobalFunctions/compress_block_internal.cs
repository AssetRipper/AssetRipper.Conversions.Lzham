using System;
using AssetRipper.Conversions.Lzham.GlobalVariables;
using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Intrinsics.Implemented;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?compress_block_internal@lzcompressor@lzham@@AEAA_NPEBXI@Z")]
[DemangledName("private: bool __cdecl lzham::lzcompressor::compress_block_internal(void const *, unsigned int)")]
internal static partial class compress_block_internal
{
	private partial struct LocalVariables
	{
		public lzham_scoped_perf_section field_0;

		public int field_1;

		public int field_2;

		public lzham_CLZDecompBase field_3;

		public lzham_scoped_perf_section field_4;

		public lzham_scoped_perf_section field_5;

		public lzham_scoped_perf_section field_6;

		public lzham_scoped_perf_section field_7;

		public lzham_CLZDecompBase field_8;

		public lzham_scoped_perf_section field_9;

		public lzham_scoped_perf_section field_10;

		public lzham_scoped_perf_section field_11;
	}

	[return: NativeType("bool")]
	public unsafe static bool Invoke(void* @this, [NativeType("void const *")] void* pBuf, [NativeType("unsigned int")] int buf_len)
	{
		StackFrame startFrame = StackFrameList.Current.New<LocalVariables>();
		LocalVariables* localsPointer = startFrame.GetLocalsPointer<LocalVariables>();
		localsPointer->field_0 = default(lzham_scoped_perf_section);
		localsPointer->field_1 = 0;
		localsPointer->field_2 = 0;
		localsPointer->field_3 = default(lzham_CLZDecompBase);
		localsPointer->field_4 = default(lzham_scoped_perf_section);
		localsPointer->field_5 = default(lzham_scoped_perf_section);
		localsPointer->field_6 = default(lzham_scoped_perf_section);
		localsPointer->field_7 = default(lzham_scoped_perf_section);
		localsPointer->field_8 = default(lzham_CLZDecompBase);
		localsPointer->field_9 = default(lzham_scoped_perf_section);
		localsPointer->field_10 = default(lzham_scoped_perf_section);
		localsPointer->field_11 = default(lzham_scoped_perf_section);
		unchecked
		{
			_ = ((lzham_lzcompressor*)@this)->field_12;
			_0scoped_perf_section.Invoke(&localsPointer->field_0, 0, String_2p8789.__pointer, default(ReadOnlySpan<nint>));
			bool flag;
			if (((lzham_lzcompressor*)@this)->field_3 < 0L)
			{
				flag = false;
			}
			else
			{
				checked
				{
					unchecked((lzham_lzcompressor*)@this)->field_3 += unchecked((uint)buf_len);
				}
				bool flag2 = add_bytes_begin.Invoke(&((lzham_lzcompressor*)@this)->field_5, buf_len, pBuf);
				if (ExceptionInfo.Current != null)
				{
					return false;
				}
				if (!flag2)
				{
					flag = false;
				}
				else
				{
					state_Assignment.Invoke(parameter_1: &((lzham_lzcompressor*)@this)->field_16, @this: &((lzham_lzcompressor*)@this)->field_15);
					if (ExceptionInfo.Current != null)
					{
						return false;
					}
					((lzham_lzcompressor*)@this)->field_4 = adler32.Invoke(pBuf, (uint)buf_len, ((lzham_lzcompressor*)@this)->field_4);
					((lzham_lzcompressor*)@this)->field_11 = Get_lookahead_pos.Invoke(&((lzham_lzcompressor*)@this)->field_5) & (Get_max_dict_size.Invoke(&((lzham_lzcompressor*)@this)->field_5) - 1);
					localsPointer->field_1 = ((lzham_lzcompressor*)@this)->field_11;
					localsPointer->field_2 = buf_len;
					bool flag3 = start_encoding.Invoke(&((lzham_lzcompressor*)@this)->field_6, (int)((uint)(buf_len * 9) / 8u));
					if (ExceptionInfo.Current != null)
					{
						return false;
					}
					if (!flag3)
					{
						flag = false;
					}
					else if (((lzham_lzcompressor*)@this)->field_12 == 0 && !send_configuration.Invoke(@this))
					{
						flag = false;
					}
					else
					{
						bool flag4 = encode_bits.Invoke(&((lzham_lzcompressor*)@this)->field_6, 1, 2);
						if (ExceptionInfo.Current != null)
						{
							return false;
						}
						if (!flag4)
						{
							flag = false;
						}
						else
						{
							bool flag5 = encode_arith_init.Invoke(&((lzham_lzcompressor*)@this)->field_6);
							if (ExceptionInfo.Current != null)
							{
								return false;
							}
							if (!flag5)
							{
								flag = false;
							}
							else
							{
								start_of_block.Invoke(&((lzham_lzcompressor*)@this)->field_16, block_index: ((lzham_lzcompressor*)@this)->field_12, cur_ofs: localsPointer->field_1, dict: &((lzham_lzcompressor*)@this)->field_5);
								sbyte b = 0;
								if (((lzham_lzcompressor*)@this)->field_22 != 0 && (((lzham_lzcompressor*)@this)->field_1.m_lzham_compress_flags & 0x10) != 0)
								{
									void* ptr = (byte*)(&((lzham_lzcompressor*)@this)->field_21) + (nint)(uint)((((lzham_lzcompressor*)@this)->field_23 == 0) ? 5 : (((lzham_lzcompressor*)@this)->field_23 - 1)) * (nint)sizeof(lzham_lzcompressor_block_history);
									if ((((lzham_lzcompressor_block_history*)ptr)->m_raw_block & 1) == 1)
									{
										b = 1;
									}
									else if (Get_total_recent_reset_update_rate.Invoke(@this) == 0)
									{
										if ((uint)Get_recent_block_ratio.Invoke(@this) > 950u)
										{
											b = 1;
										}
										else
										{
											int num = Get_min_block_ratio.Invoke(@this);
											if ((uint)((lzham_lzcompressor_block_history*)ptr)->m_ratio > (uint)(num * 3) / 2u)
											{
												b = 1;
											}
										}
									}
								}
								if ((b & 1) == 1)
								{
									reset_update_rate_ycr949.Invoke(&((lzham_lzcompressor*)@this)->field_16);
								}
								encode_bits.Invoke(&((lzham_lzcompressor*)@this)->field_6, InstructionHelper.Select((b & 1) == 1, 1, 0), 2);
								if (ExceptionInfo.Current != null)
								{
									return false;
								}
								int field_ = ((lzham_lzcompressor*)@this)->field_10;
								while (true)
								{
									if (localsPointer->field_2 != 0)
									{
										if (((lzham_lzcompressor*)@this)->field_1.m_pSeed_bytes != null && (uint)localsPointer->field_2 >= 384u)
										{
											void* ptr2 = (byte*)(&((lzham_lzcompressor*)@this)->field_18) + (nint)8 * sizeof(lzham_lzcompressor_parse_thread_state);
											state_Assignment.Invoke(parameter_1: &((lzham_lzcompressor*)@this)->field_16, @this: &((lzham_lzcompressor_raw_parse_thread_state*)ptr2)->m_initial_state);
											if (ExceptionInfo.Current != null)
											{
												return false;
											}
											int field_2 = localsPointer->field_1;
											((lzham_lzcompressor_state_base*)(&((lzham_lzcompressor_raw_parse_thread_state*)ptr2)->m_initial_state))->m_cur_ofs = field_2;
											((lzham_lzcompressor_raw_parse_thread_state*)ptr2)->m_issue_reset_state_partial = 0;
											((lzham_lzcompressor_raw_parse_thread_state*)ptr2)->m_start_ofs = localsPointer->field_1;
											((lzham_lzcompressor_raw_parse_thread_state*)ptr2)->m_bytes_to_match = (((uint)localsPointer->field_2 >= 65536u) ? 65536 : localsPointer->field_2);
											((lzham_lzcompressor_raw_parse_thread_state*)ptr2)->m_max_greedy_decisions = (int)(((uint)localsPointer->field_2 / 384u >= 2) ? ((uint)localsPointer->field_2 / 384u) : 2);
											((lzham_lzcompressor_raw_parse_thread_state*)ptr2)->m_greedy_parse_gave_up = 0;
											((lzham_lzcompressor_raw_parse_thread_state*)ptr2)->m_greedy_parse_total_bytes_coded = 0;
											bool flag6 = greedy_parse.Invoke(@this, ptr2);
											if (ExceptionInfo.Current != null)
											{
												return false;
											}
											if (!flag6 && (((lzham_lzcompressor_raw_parse_thread_state*)ptr2)->m_greedy_parse_gave_up & 1) != 1)
											{
												flag = false;
												break;
											}
											int num2 = 0;
											void* best_decisions = &((lzham_lzcompressor_raw_parse_thread_state*)ptr2)->m_best_decisions;
											if ((((lzham_lzcompressor_raw_parse_thread_state*)ptr2)->m_greedy_parse_gave_up & 1) != 1)
											{
												num2 = size_9gqvur.Invoke(best_decisions);
											}
											else
											{
												int num3 = 0;
												int num4 = 0;
												int num5 = 0;
												int i;
												for (i = 0; (uint)i < (uint)size_9gqvur.Invoke(best_decisions); i++)
												{
													void* ptr3 = vector_struct_lzham_lzcompressor_lzdecision_Operator.Invoke(best_decisions, i);
													if ((uint)Get_len_wzf5xk.Invoke(ptr3) <= 257u)
													{
														num3++;
														if ((uint)num3 > 16u)
														{
															break;
														}
													}
													num4 += Get_len_wzf5xk.Invoke(ptr3);
													num5 = (((uint)num5 >= (uint)Get_len_wzf5xk.Invoke(ptr3)) ? num5 : Get_len_wzf5xk.Invoke(ptr3));
												}
												if ((uint)num5 > 257u && (uint)num4 / (uint)i >= 384)
												{
													num2 = i;
												}
											}
											if (num2 != 0)
											{
												int num6 = 0;
												while ((uint)num6 < (uint)num2)
												{
													llvm_memcpy_p0_p0_i64.Invoke(source: vector_struct_lzham_lzcompressor_lzdecision_Operator.Invoke(best_decisions, num6), destination: &localsPointer->field_3, length: 12L, isVolatile: false);
													bool flag7 = code_decision.Invoke(@this, &localsPointer->field_3, &localsPointer->field_1, &localsPointer->field_2);
													if (ExceptionInfo.Current != null)
													{
														return false;
													}
													if (!flag7)
													{
														goto IL_06ac;
													}
													num6++;
												}
												if ((((lzham_lzcompressor_raw_parse_thread_state*)ptr2)->m_greedy_parse_gave_up & 1) != 1 || localsPointer->field_2 == 0)
												{
													continue;
												}
											}
										}
										int num7 = (((uint)((lzham_lzcompressor*)@this)->field_17 >= (uint)(localsPointer->field_2 + 3072 - 1) / 3072u) ? ((int)((uint)(localsPointer->field_2 + 3072 - 1) / 3072u)) : ((lzham_lzcompressor*)@this)->field_17);
										if ((((lzham_lzcompressor*)@this)->field_1.m_lzham_compress_flags & 4) == 0 && (((lzham_lzcompressor*)@this)->field_14 & 1) == 1 && Get_max_helper_threads.Invoke(&((lzham_lzcompressor*)@this)->field_5) != 0)
										{
											num7 += Get_num_completed_helper_threads.Invoke(&((lzham_lzcompressor*)@this)->field_5);
											num7 = (((uint)num7 >= 8u) ? 8 : num7);
										}
										if ((uint)localsPointer->field_2 < 1536u)
										{
											num7 = 1;
										}
										sbyte b2 = 0;
										if (((lzham_lzcompressor*)@this)->field_12 == 0 && (uint)(localsPointer->field_1 - ((lzham_lzcompressor*)@this)->field_11) < 3072u)
										{
											num7 = 1;
											b2 = 1;
										}
										int num8 = localsPointer->field_1;
										int num9 = (((uint)localsPointer->field_2 >= (uint)(3072 * num7)) ? (3072 * num7) : localsPointer->field_2);
										if ((b2 & 1) == 1)
										{
											num9 = (((uint)num9 >= 1536u) ? 1536 : num9);
										}
										int num10 = num9;
										for (int j = 0; (uint)j < (uint)num7; j++)
										{
											void* ptr4 = (byte*)(&((lzham_lzcompressor*)@this)->field_18) + (nint)(uint)j * (nint)sizeof(lzham_lzcompressor_parse_thread_state);
											state_Assignment.Invoke(parameter_1: &((lzham_lzcompressor*)@this)->field_16, @this: &((lzham_lzcompressor_raw_parse_thread_state*)ptr4)->m_initial_state);
											if (ExceptionInfo.Current != null)
											{
												return false;
											}
											((lzham_lzcompressor_state_base*)(&((lzham_lzcompressor_raw_parse_thread_state*)ptr4)->m_initial_state))->m_cur_ofs = num8;
											if (j != 0)
											{
												reset_state_partial.Invoke(&((lzham_lzcompressor_raw_parse_thread_state*)ptr4)->m_initial_state);
												((lzham_lzcompressor_raw_parse_thread_state*)ptr4)->m_issue_reset_state_partial = 1;
											}
											else
											{
												((lzham_lzcompressor_raw_parse_thread_state*)ptr4)->m_issue_reset_state_partial = 0;
											}
											((lzham_lzcompressor_raw_parse_thread_state*)ptr4)->m_start_ofs = num8;
											if (j == num7 - 1)
											{
												((lzham_lzcompressor_raw_parse_thread_state*)ptr4)->m_bytes_to_match = num10;
											}
											else
											{
												((lzham_lzcompressor_raw_parse_thread_state*)ptr4)->m_bytes_to_match = (int)((uint)num9 / (uint)num7);
											}
											((lzham_lzcompressor_raw_parse_thread_state*)ptr4)->m_bytes_to_match = (((uint)((lzham_lzcompressor_raw_parse_thread_state*)ptr4)->m_bytes_to_match >= 3072u) ? 3072 : ((lzham_lzcompressor_raw_parse_thread_state*)ptr4)->m_bytes_to_match);
											((lzham_lzcompressor_raw_parse_thread_state*)ptr4)->m_max_greedy_decisions = -1;
											((lzham_lzcompressor_raw_parse_thread_state*)ptr4)->m_greedy_parse_gave_up = 0;
											num8 += ((lzham_lzcompressor_raw_parse_thread_state*)ptr4)->m_bytes_to_match;
											num10 -= ((lzham_lzcompressor_raw_parse_thread_state*)ptr4)->m_bytes_to_match;
										}
										scoped_perf_section_Constructor.Invoke(&localsPointer->field_4, String_q343bu.__pointer);
										if ((((lzham_lzcompressor*)@this)->field_14 & 1) == 1 && (uint)num7 > 1u)
										{
											((lzham_lzcompressor*)@this)->field_19 = num7;
											scoped_perf_section_Constructor.Invoke(&localsPointer->field_5, String_xvmi6j.__pointer);
											bool flag8 = queue_multiple_object_tasks_qegt6p.Invoke(((lzham_lzcompressor*)@this)->field_1.m_pTask_pool, @this, parse_job_callback.__pointer, 1L, num7 - 1, null);
											if (ExceptionInfo.Current != null)
											{
												return false;
											}
											if (!flag8)
											{
												flag = false;
												break;
											}
											parse_job_callback.Invoke(@this, 0L, null);
											if (ExceptionInfo.Current != null)
											{
												return false;
											}
											scoped_perf_section_Constructor.Invoke(&localsPointer->field_6, String_2t6uyd.__pointer);
											wait.Invoke((byte*)@this + 6444396, -1);
										}
										else
										{
											((lzham_lzcompressor*)@this)->field_19 = int.MaxValue;
											for (int k = 0; (uint)k < (uint)num7; k++)
											{
												parse_job_callback.Invoke(@this, (uint)k, null);
												if (ExceptionInfo.Current != null)
												{
													return false;
												}
											}
										}
										scoped_perf_section_Constructor.Invoke(&localsPointer->field_7, String_7dyiyi.__pointer);
										for (int l = 0; (uint)l < (uint)num7; l++)
										{
											void* ptr5 = (byte*)(&((lzham_lzcompressor*)@this)->field_18) + (nint)(uint)l * (nint)sizeof(lzham_lzcompressor_parse_thread_state);
											if ((((lzham_lzcompressor_raw_parse_thread_state*)ptr5)->m_failed & 1) == 1)
											{
												goto IL_0ac5;
											}
											void* best_decisions2 = &((lzham_lzcompressor_raw_parse_thread_state*)ptr5)->m_best_decisions;
											if ((((lzham_lzcompressor_raw_parse_thread_state*)ptr5)->m_issue_reset_state_partial & 1) == 1)
											{
												bool flag9 = encode_reset_state_partial.Invoke(&((lzham_lzcompressor*)@this)->field_16, dict_pos: localsPointer->field_1, dict: &((lzham_lzcompressor*)@this)->field_5, codec: &((lzham_lzcompressor*)@this)->field_6);
												if (ExceptionInfo.Current != null)
												{
													return false;
												}
												if (!flag9)
												{
													goto IL_0b1f;
												}
												((lzham_lzcompressor*)@this)->field_10++;
											}
											if (size_9gqvur.Invoke(best_decisions2) == 0)
											{
												continue;
											}
											int num11 = 0;
											checked
											{
												int num12 = size_9gqvur.Invoke(best_decisions2) - 1;
												int num13 = 1;
												if ((unchecked((lzham_lzcompressor_raw_parse_thread_state*)ptr5)->m_emit_decisions_backwards & 1) == 1)
												{
													num11 = size_9gqvur.Invoke(best_decisions2) - 1;
													num12 = 0;
													num13 = -1;
												}
												while (true)
												{
													llvm_memcpy_p0_p0_i64.Invoke(source: vector_struct_lzham_lzcompressor_lzdecision_Operator.Invoke(best_decisions2, num11), destination: &localsPointer->field_8, length: 12L, isVolatile: false);
													bool flag10 = code_decision.Invoke(@this, &localsPointer->field_8, &localsPointer->field_1, &localsPointer->field_2);
													if (ExceptionInfo.Current != null)
													{
														return false;
													}
													if (!flag10)
													{
														break;
													}
													if (num11 == num12)
													{
														goto IL_0bfe;
													}
													num11 += num13;
												}
												goto IL_0bda;
											}
											IL_0bfe:;
										}
										continue;
									}
									scoped_perf_section_Constructor.Invoke(&localsPointer->field_9, String_dmyz8f.__pointer);
									add_bytes_end.Invoke(&((lzham_lzcompressor*)@this)->field_5);
									bool flag11 = encode_eob.Invoke(&((lzham_lzcompressor*)@this)->field_16, dict_pos: localsPointer->field_1, dict: &((lzham_lzcompressor*)@this)->field_5, codec: &((lzham_lzcompressor*)@this)->field_6);
									if (ExceptionInfo.Current != null)
									{
										return false;
									}
									if (!flag11)
									{
										flag = false;
										break;
									}
									scoped_perf_section_Constructor.Invoke(&localsPointer->field_10, String_siua9a.__pointer);
									bool flag12 = stop_encoding.Invoke(&((lzham_lzcompressor*)@this)->field_6, support_arith: true);
									if (ExceptionInfo.Current != null)
									{
										return false;
									}
									if (!flag12)
									{
										flag = false;
										break;
									}
									int num14 = size_s5xcpk.Invoke(Get_encoding_buf.Invoke(&((lzham_lzcompressor*)@this)->field_6));
									sbyte b3 = 0;
									if ((uint)num14 >= (uint)buf_len)
									{
										state_Assignment.Invoke(parameter_1: &((lzham_lzcompressor*)@this)->field_15, @this: &((lzham_lzcompressor*)@this)->field_16);
										if (ExceptionInfo.Current != null)
										{
											return false;
										}
										((lzham_lzcompressor*)@this)->field_10 = field_;
										reset_jag9x3.Invoke(&((lzham_lzcompressor*)@this)->field_6);
										if (ExceptionInfo.Current != null)
										{
											return false;
										}
										bool flag13 = start_encoding.Invoke(&((lzham_lzcompressor*)@this)->field_6, buf_len + 16);
										if (ExceptionInfo.Current != null)
										{
											return false;
										}
										if (!flag13)
										{
											flag = false;
											break;
										}
										if (((lzham_lzcompressor*)@this)->field_12 == 0 && !send_configuration.Invoke(@this))
										{
											flag = false;
											break;
										}
										bool flag14 = encode_bits.Invoke(&((lzham_lzcompressor*)@this)->field_6, 2, 2);
										if (ExceptionInfo.Current != null)
										{
											return false;
										}
										if (!flag14)
										{
											flag = false;
											break;
										}
										bool flag15 = encode_bits.Invoke(&((lzham_lzcompressor*)@this)->field_6, buf_len - 1, 24);
										if (ExceptionInfo.Current != null)
										{
											return false;
										}
										if (!flag15)
										{
											flag = false;
											break;
										}
										bool flag16 = encode_bits.Invoke(&((lzham_lzcompressor*)@this)->field_6, ((buf_len - 1) & 0xFF) ^ ((buf_len - 1 >>> 8) & 0xFF) ^ ((buf_len - 1 >>> 16) & 0xFF), 8);
										if (ExceptionInfo.Current != null)
										{
											return false;
										}
										if (!flag16)
										{
											flag = false;
											break;
										}
										bool flag17 = encode_align_to_byte.Invoke(&((lzham_lzcompressor*)@this)->field_6);
										if (ExceptionInfo.Current != null)
										{
											return false;
										}
										if (!flag17)
										{
											flag = false;
											break;
										}
										void* ptr6 = Get_ptr_zs5pn7.Invoke(&((lzham_lzcompressor*)@this)->field_5, ((lzham_lzcompressor*)@this)->field_11);
										int num15 = 0;
										while ((uint)num15 < (uint)buf_len)
										{
											lzham_symbol_codec* field_3 = &((lzham_lzcompressor*)@this)->field_6;
											void* ptr7 = ptr6;
											ptr6 = (byte*)ptr7 + 1;
											bool flag18 = encode_bits.Invoke(field_3, (byte)(*(sbyte*)ptr7), 8);
											if (ExceptionInfo.Current != null)
											{
												return false;
											}
											if (!flag18)
											{
												goto IL_0e80;
											}
											num15++;
										}
										bool flag19 = stop_encoding.Invoke(&((lzham_lzcompressor*)@this)->field_6, support_arith: true);
										if (ExceptionInfo.Current != null)
										{
											return false;
										}
										if (!flag19)
										{
											flag = false;
											break;
										}
										b3 = 1;
										b = 0;
									}
									int num16 = size_s5xcpk.Invoke(Get_encoding_buf.Invoke(&((lzham_lzcompressor*)@this)->field_6));
									update_block_history.Invoke(@this, num16, buf_len, (int)((uint)(num16 * 1000) / (uint)buf_len), (b3 & 1) == 1, (b & 1) == 1);
									scoped_perf_section_Constructor.Invoke(&localsPointer->field_11, String_9pse5k.__pointer);
									if (empty.Invoke(&((lzham_lzcompressor*)@this)->field_9))
									{
										swap_ufmqqg.Invoke(&((lzham_lzcompressor*)@this)->field_9, Get_encoding_buf.Invoke(&((lzham_lzcompressor*)@this)->field_6));
									}
									else
									{
										bool flag20 = append_9ee93x.Invoke(&((lzham_lzcompressor*)@this)->field_9, Get_encoding_buf.Invoke(&((lzham_lzcompressor*)@this)->field_6));
										if (ExceptionInfo.Current != null)
										{
											return false;
										}
										if (!flag20)
										{
											flag = false;
											break;
										}
									}
									((lzham_lzcompressor*)@this)->field_12++;
									flag = true;
									break;
									IL_0b1f:
									flag = false;
									break;
									IL_06ac:
									flag = false;
									break;
									IL_0e80:
									flag = false;
									break;
									IL_0bda:
									flag = false;
									break;
									IL_0ac5:
									flag = false;
									break;
								}
							}
						}
					}
				}
			}
			bool result = flag;
			StackFrameList.Current.Clear(startFrame);
			return result;
		}
	}
}
