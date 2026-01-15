using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.InlineArrays;
using AssetRipper.Conversions.Lzham.Intrinsics.Implemented;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?optimal_parse@lzcompressor@lzham@@AEAA_NAEAUparse_thread_state@12@@Z")]
[DemangledName("private: bool __cdecl lzham::lzcompressor::optimal_parse(struct lzham::lzcompressor::parse_thread_state &)")]
internal static partial class optimal_parse
{
	private partial struct LocalVariables
	{
		public InlineArray128_Int32 field_0;

		public InlineArray128_Int32 field_1;

		public InlineArray258_Int64 field_2;
	}

	[return: NativeType("bool")]
	public unsafe static bool Invoke(void* @this, [NativeType("struct lzham::lzcompressor::parse_thread_state &")] void* parse_state)
	{
		StackFrame startFrame = StackFrameList.Current.New<LocalVariables>();
		LocalVariables* localsPointer = startFrame.GetLocalsPointer<LocalVariables>();
		localsPointer->field_0 = default(InlineArray128_Int32);
		localsPointer->field_1 = default(InlineArray128_Int32);
		localsPointer->field_2 = default(InlineArray258_Int64);
		unchecked
		{
			((lzham_lzcompressor_raw_parse_thread_state*)parse_state)->m_failed = 0;
			((lzham_lzcompressor_raw_parse_thread_state*)parse_state)->m_emit_decisions_backwards = 1;
			void* nodes = &((lzham_lzcompressor_raw_parse_thread_state*)parse_state)->m_nodes;
			((lzham_lzcompressor_node_state*)nodes)->m_parent_index = -1;
			((lzham_lzcompressor_node_state*)nodes)->m_total_cost = 0L;
			((lzham_lzcompressor_node_state*)nodes)->m_total_complexity = 0;
			llvm_memset_p0_i64.Invoke((byte*)nodes + sizeof(lzham_lzcompressor_node_state), -1, 172032L, isVolatile: false);
			void* initial_state = &((lzham_lzcompressor_raw_parse_thread_state*)parse_state)->m_initial_state;
			int bytes_to_match = ((lzham_lzcompressor_raw_parse_thread_state*)parse_state)->m_bytes_to_match;
			int num = Get_lookahead_pos.Invoke(&((lzham_lzcompressor*)@this)->field_5) & Get_max_dict_size_mask.Invoke(&((lzham_lzcompressor*)@this)->field_5);
			int num2 = ((lzham_lzcompressor_raw_parse_thread_state*)parse_state)->m_start_ofs;
			int num3 = num2 - num;
			int num4 = 0;
			while ((uint)num4 < (uint)bytes_to_match)
			{
				void* ptr = (byte*)nodes + (nint)(uint)num4 * (nint)sizeof(lzham_lzcompressor_node_state);
				int num5 = ((257u >= (uint)(bytes_to_match - num4)) ? (bytes_to_match - num4) : 257);
				int num6 = ((lzham_lzcompressor*)@this)->field_5.m_cur_dict_size + num3;
				if (num4 != 0)
				{
					restore_partial_state.Invoke(initial_state, &((lzham_lzcompressor_node_state*)ptr)->m_saved_state);
					partial_advance.Invoke(initial_state, &((lzham_lzcompressor_node_state*)ptr)->m_lzdec);
				}
				long total_cost = ((lzham_lzcompressor_node_state*)ptr)->m_total_cost;
				int total_complexity = ((lzham_lzcompressor_node_state*)ptr)->m_total_complexity;
				int lit_pred = Get_pred_char.Invoke(initial_state, &((lzham_lzcompressor*)@this)->field_5, num2, 1);
				int cur_state = ((lzham_lzcompressor_state_base*)initial_state)->m_cur_state;
				void* ptr2 = vector_unsigned_char_Operator_apxfsu.Invoke(&((lzham_lzcompressor*)@this)->field_5.m_dict, num2);
				int num7 = 0;
				int num8 = 1;
				for (int i = 0; (uint)i < 4u; i++)
				{
					int j = 0;
					int num9 = ((int*)(&((lzham_lzcompressor_state_base*)initial_state)->m_match_hist))[(uint)i];
					if ((uint)num9 <= (uint)num6)
					{
						void* ptr3 = vector_unsigned_char_Operator_apxfsu.Invoke(i: (((lzham_lzcompressor*)@this)->field_5.m_lookahead_pos + num3 - num9) & ((lzham_lzcompressor*)@this)->field_5.m_max_dict_size_mask, @this: &((lzham_lzcompressor*)@this)->field_5.m_dict);
						for (j = 0; (uint)j < (uint)num5 && (byte)((sbyte*)ptr3)[(uint)j] == (byte)((sbyte*)ptr2)[(uint)j]; j++)
						{
						}
					}
					if ((uint)j >= (uint)num8)
					{
						num7 = maximum_95ffuu.Invoke(num7, j);
						Get_rep_match_costs.Invoke(initial_state, num2, &localsPointer->field_2, i, num8, j, cur_state);
						int num10 = total_complexity + (2 + i);
						for (int k = num8; (uint)k <= (uint)j; k++)
						{
							void* ptr4 = (byte*)ptr + (nint)(uint)k * (nint)sizeof(lzham_lzcompressor_node_state);
							long num11 = total_cost + ((long*)(&localsPointer->field_2))[(uint)k];
							if ((ulong)num11 <= (ulong)((lzham_lzcompressor_node_state*)ptr4)->m_total_cost && (num11 != ((lzham_lzcompressor_node_state*)ptr4)->m_total_cost || (uint)num10 < (uint)((lzham_lzcompressor_node_state*)ptr4)->m_total_complexity))
							{
								((lzham_lzcompressor_node_state*)ptr4)->m_total_cost = num11;
								((lzham_lzcompressor_node_state*)ptr4)->m_total_complexity = num10;
								((lzham_lzcompressor_node_state*)ptr4)->m_parent_index = (short)num4;
								save_partial_state.Invoke(initial_state, &((lzham_lzcompressor_node_state*)ptr4)->m_saved_state);
								init_jzbtc6.Invoke(&((lzham_lzcompressor_node_state*)ptr4)->m_lzdec, num2, k, checked(-(i + 1)));
								((lzham_lzcompressor_node_state*)ptr4)->m_lzdec.m_cur_state = k;
							}
						}
					}
					num8 = 2;
				}
				int num12 = num7;
				if ((uint)num12 >= (uint)((lzham_lzcompressor*)@this)->field_2.m_fast_bytes)
				{
					num2 += num12;
					num3 += num12;
					num4 += num12;
					continue;
				}
				if ((uint)num5 >= 2u)
				{
					int num13 = 0;
					if ((uint)num7 < 2u)
					{
						int num14 = Get_len2_match.Invoke(&((lzham_lzcompressor*)@this)->field_5, num3);
						if (num14 != 0)
						{
							long num15 = Get_len2_match_cost.Invoke(initial_state, @this, num2, num14, cur_state);
							void* ptr5 = (byte*)ptr + (nint)2 * sizeof(lzham_lzcompressor_node_state);
							long num16 = total_cost + num15;
							int num17 = total_complexity + 7;
							if ((ulong)num16 < (ulong)((lzham_lzcompressor_node_state*)ptr5)->m_total_cost || (num16 == ((lzham_lzcompressor_node_state*)ptr5)->m_total_cost && (uint)num17 < (uint)((lzham_lzcompressor_node_state*)ptr5)->m_total_complexity))
							{
								((lzham_lzcompressor_node_state*)ptr5)->m_total_cost = num16;
								((lzham_lzcompressor_node_state*)ptr5)->m_total_complexity = num17;
								((lzham_lzcompressor_node_state*)ptr5)->m_parent_index = (short)num4;
								save_partial_state.Invoke(initial_state, &((lzham_lzcompressor_node_state*)ptr5)->m_saved_state);
								init_jzbtc6.Invoke(&((lzham_lzcompressor_node_state*)ptr5)->m_lzdec, num2, 2, num14);
							}
							num12 = 2;
						}
					}
					int num18 = num12;
					void* ptr6 = find_matches.Invoke(&((lzham_lzcompressor*)@this)->field_5, num3, spin: true);
					if (ptr6 != null)
					{
						while (true)
						{
							int num19 = Get_len_xiv86i.Invoke(ptr6);
							num19 = (((uint)num19 >= (uint)num5) ? num5 : num19);
							if ((uint)num19 > (uint)num12)
							{
								num12 = num19;
								((int*)(&localsPointer->field_0))[(uint)num13] = num19;
								int num20 = Get_dist.Invoke(ptr6);
								((int*)(&localsPointer->field_1))[(uint)num13] = num20;
								num13++;
							}
							if (is_last.Invoke(ptr6))
							{
								break;
							}
							ptr6 = (byte*)ptr6 + sizeof(lzham_dict_match);
						}
					}
					if (num13 != 0)
					{
						int num21 = ((1u >= (uint)num18) ? 1 : num18);
						for (int l = 0; (uint)l < (uint)num13; l++)
						{
							int num22 = num21 + 1;
							int num23 = ((int*)(&localsPointer->field_0))[(uint)l];
							int num24 = ((int*)(&localsPointer->field_1))[(uint)l];
							Get_full_match_costs.Invoke(initial_state, @this, num2, &localsPointer->field_2, num24, num22, num23, cur_state);
							for (int m = num22; (uint)m <= (uint)num23; m++)
							{
								int num25 = InstructionHelper.Select((uint)m >= 9u, 6, 7);
								void* ptr7 = (byte*)ptr + (nint)(uint)m * (nint)sizeof(lzham_lzcompressor_node_state);
								long num26 = total_cost + ((long*)(&localsPointer->field_2))[(uint)m];
								int num27 = total_complexity + num25;
								if ((ulong)num26 <= (ulong)((lzham_lzcompressor_node_state*)ptr7)->m_total_cost && (num26 != ((lzham_lzcompressor_node_state*)ptr7)->m_total_cost || (uint)num27 < (uint)((lzham_lzcompressor_node_state*)ptr7)->m_total_complexity))
								{
									((lzham_lzcompressor_node_state*)ptr7)->m_total_cost = num26;
									((lzham_lzcompressor_node_state*)ptr7)->m_total_complexity = num27;
									((lzham_lzcompressor_node_state*)ptr7)->m_parent_index = (short)num4;
									save_partial_state.Invoke(initial_state, &((lzham_lzcompressor_node_state*)ptr7)->m_saved_state);
									init_jzbtc6.Invoke(&((lzham_lzcompressor_node_state*)ptr7)->m_lzdec, num2, m, num24);
								}
							}
							num21 = num23;
						}
					}
				}
				if ((uint)num12 >= (uint)((lzham_lzcompressor*)@this)->field_2.m_fast_bytes)
				{
					num2 += num12;
					num3 += num12;
					num4 += num12;
					continue;
				}
				long num28 = total_cost + Get_lit_cost.Invoke(initial_state, @this, &((lzham_lzcompressor*)@this)->field_5, num2, lit_pred, cur_state);
				int num29 = total_complexity + 1;
				if ((ulong)num28 < (ulong)((lzham_lzcompressor_node_state*)ptr)[1].m_total_cost || (num28 == ((lzham_lzcompressor_node_state*)ptr)[1].m_total_cost && (uint)num29 < (uint)((lzham_lzcompressor_node_state*)ptr)[1].m_total_complexity))
				{
					((lzham_lzcompressor_node_state*)ptr)[1].m_total_cost = num28;
					((lzham_lzcompressor_node_state*)ptr)[1].m_total_complexity = num29;
					((lzham_lzcompressor_node_state*)ptr)[1].m_parent_index = (short)num4;
					save_partial_state.Invoke(initial_state, &((lzham_lzcompressor_node_state*)ptr)[1].m_saved_state);
					init_jzbtc6.Invoke(&((lzham_lzcompressor_node_state*)ptr)[1].m_lzdec, num2, 0, 0);
				}
				num2++;
				num3++;
				num4++;
			}
			bool flag = try_reserve_x9kr5x.Invoke(&((lzham_lzcompressor_raw_parse_thread_state*)parse_state)->m_best_decisions, bytes_to_match);
			if (ExceptionInfo.Current != null)
			{
				return false;
			}
			bool flag2;
			if (!flag)
			{
				((lzham_lzcompressor_raw_parse_thread_state*)parse_state)->m_failed = 1;
				flag2 = false;
			}
			else
			{
				int num30 = bytes_to_match;
				void* ptr8 = Get_ptr_4r7f9k.Invoke(&((lzham_lzcompressor_raw_parse_thread_state*)parse_state)->m_best_decisions);
				do
				{
					void* ptr9 = (byte*)nodes + (nint)num30 * (nint)sizeof(lzham_lzcompressor_node_state);
					lzham_CLZDecompBase* lzdec = &((lzham_lzcompressor_node_state*)ptr9)->m_lzdec;
					void* ptr10 = ptr8;
					ptr8 = (byte*)ptr10 + sizeof(lzham_CLZDecompBase);
					llvm_memcpy_p0_p0_i64.Invoke(ptr10, lzdec, 12L, isVolatile: false);
					num30 = ((lzham_lzcompressor_node_state*)ptr9)->m_parent_index;
				}
				while (num30 > 0);
				try_resize_aw2beb.Invoke(&((lzham_lzcompressor_raw_parse_thread_state*)parse_state)->m_best_decisions, (int)(((long)ptr8 - (long)Get_ptr_4r7f9k.Invoke(&((lzham_lzcompressor_raw_parse_thread_state*)parse_state)->m_best_decisions)) / 12L), grow_hint: false);
				if (ExceptionInfo.Current != null)
				{
					return false;
				}
				flag2 = true;
			}
			bool result = flag2;
			StackFrameList.Current.Clear(startFrame);
			return result;
		}
	}
}
