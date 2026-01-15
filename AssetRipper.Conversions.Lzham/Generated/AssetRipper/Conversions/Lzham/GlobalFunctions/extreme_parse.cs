using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.InlineArrays;
using AssetRipper.Conversions.Lzham.Intrinsics.Implemented;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?extreme_parse@lzcompressor@lzham@@AEAA_NAEAUparse_thread_state@12@@Z")]
[DemangledName("private: bool __cdecl lzham::lzcompressor::extreme_parse(struct lzham::lzcompressor::parse_thread_state &)")]
internal static partial class extreme_parse
{
	private partial struct LocalVariables
	{
		public InlineArray128_Int32 field_0;

		public InlineArray128_Int32 field_1;

		public InlineArray258_Int64 field_2;

		public lzham_lzcompressor_node field_3;

		public lzham_CLZDecompBase field_4;

		public lzham_CLZDecompBase field_5;

		public lzham_CLZDecompBase field_6;

		public lzham_CLZDecompBase field_7;
	}

	[return: NativeType("bool")]
	public unsafe static bool Invoke(void* @this, [NativeType("struct lzham::lzcompressor::parse_thread_state &")] void* parse_state)
	{
		StackFrame startFrame = StackFrameList.Current.New<LocalVariables>();
		LocalVariables* localsPointer = startFrame.GetLocalsPointer<LocalVariables>();
		localsPointer->field_0 = default(InlineArray128_Int32);
		localsPointer->field_1 = default(InlineArray128_Int32);
		localsPointer->field_2 = default(InlineArray258_Int64);
		localsPointer->field_3 = default(lzham_lzcompressor_node);
		localsPointer->field_4 = default(lzham_CLZDecompBase);
		localsPointer->field_5 = default(lzham_CLZDecompBase);
		localsPointer->field_6 = default(lzham_CLZDecompBase);
		localsPointer->field_7 = default(lzham_CLZDecompBase);
		unchecked
		{
			((lzham_lzcompressor_raw_parse_thread_state*)parse_state)->m_failed = 0;
			((lzham_lzcompressor_raw_parse_thread_state*)parse_state)->m_emit_decisions_backwards = 1;
			void* nodes = &((lzham_lzcompressor_raw_parse_thread_state*)parse_state)->m_nodes;
			for (int i = 0; (uint)i <= 3072u; i++)
			{
				clear_xf8fic.Invoke((byte*)nodes + (nint)(uint)i * (nint)sizeof(lzham_lzcompressor_node));
			}
			void* initial_state = &((lzham_lzcompressor_raw_parse_thread_state*)parse_state)->m_initial_state;
			((lzham_lzcompressor_node*)nodes)->m_num_node_states = 1;
			void* node_states = &((lzham_lzcompressor_node*)nodes)->m_node_states;
			save_partial_state.Invoke(initial_state, &((lzham_lzcompressor_node_state*)node_states)->m_saved_state);
			((lzham_lzcompressor_node_state*)node_states)->m_parent_index = -1;
			((lzham_lzcompressor_node_state*)node_states)->m_parent_state_index = -1;
			((lzham_lzcompressor_node_state*)node_states)->m_total_cost = 0L;
			((lzham_lzcompressor_node_state*)node_states)->m_total_complexity = 0;
			int bytes_to_match = ((lzham_lzcompressor_raw_parse_thread_state*)parse_state)->m_bytes_to_match;
			int num = Get_lookahead_pos.Invoke(&((lzham_lzcompressor*)@this)->field_5) & Get_max_dict_size_mask.Invoke(&((lzham_lzcompressor*)@this)->field_5);
			int num2 = ((lzham_lzcompressor_raw_parse_thread_state*)parse_state)->m_start_ofs;
			int num3 = num2 - num;
			int j = 0;
			node_Constructor.Invoke(&localsPointer->field_3);
			clear_xf8fic.Invoke(&localsPointer->field_3);
			for (; (uint)j < (uint)bytes_to_match; j++)
			{
				void* ptr = (byte*)nodes + (nint)(uint)j * (nint)sizeof(lzham_lzcompressor_node);
				int num4 = ((257u >= (uint)(bytes_to_match - j)) ? (bytes_to_match - j) : 257);
				int num5 = Get_cur_dict_size.Invoke(&((lzham_lzcompressor*)@this)->field_5) + num3;
				int lit_pred = Get_pred_char.Invoke(initial_state, &((lzham_lzcompressor*)@this)->field_5, num2, 1);
				void* ptr2 = vector_unsigned_char_Operator_apxfsu.Invoke(&((lzham_lzcompressor*)@this)->field_5.m_dict, num2);
				int num6 = 0;
				int num7 = 0;
				int num8 = 0;
				if ((uint)num4 >= 2u)
				{
					void* ptr3 = find_matches.Invoke(&((lzham_lzcompressor*)@this)->field_5, num3, spin: true);
					if (ptr3 != null)
					{
						while (true)
						{
							int num9 = Get_len_xiv86i.Invoke(ptr3);
							num9 = (((uint)num9 >= (uint)num4) ? num4 : num9);
							if ((uint)num9 > (uint)num6)
							{
								num6 = num9;
								((int*)(&localsPointer->field_0))[(uint)num7] = num9;
								int num10 = Get_dist.Invoke(ptr3);
								((int*)(&localsPointer->field_1))[(uint)num7] = num10;
								num7++;
							}
							if (is_last.Invoke(ptr3))
							{
								break;
							}
							ptr3 = (byte*)ptr3 + sizeof(lzham_dict_match);
						}
					}
					num8 = Get_len2_match.Invoke(&((lzham_lzcompressor*)@this)->field_5, num3);
				}
				for (int k = 0; (uint)k < (uint)((lzham_lzcompressor_node*)ptr)->m_num_node_states; k++)
				{
					void* ptr4 = (byte*)(&((lzham_lzcompressor_node*)ptr)->m_node_states) + (nint)(uint)k * (nint)sizeof(lzham_lzcompressor_node_state);
					if (j != 0)
					{
						restore_partial_state.Invoke(initial_state, &((lzham_lzcompressor_node_state*)ptr4)->m_saved_state);
					}
					int cur_state = ((lzham_lzcompressor_state_base*)initial_state)->m_cur_state;
					long total_cost = ((lzham_lzcompressor_node_state*)ptr4)->m_total_cost;
					int total_complexity = ((lzham_lzcompressor_node_state*)ptr4)->m_total_complexity;
					int num11 = 0;
					int num12 = 1;
					for (int l = 0; (uint)l < 4u; l++)
					{
						int m = 0;
						int num13 = ((int*)(&((lzham_lzcompressor_state_base*)initial_state)->m_match_hist))[(uint)l];
						if ((uint)num13 <= (uint)num5)
						{
							void* ptr5 = vector_unsigned_char_Operator_apxfsu.Invoke(i: (((lzham_lzcompressor*)@this)->field_5.m_lookahead_pos + num3 - num13) & ((lzham_lzcompressor*)@this)->field_5.m_max_dict_size_mask, @this: &((lzham_lzcompressor*)@this)->field_5.m_dict);
							for (m = 0; (uint)m < (uint)num4 && (byte)((sbyte*)ptr5)[(uint)m] == (byte)((sbyte*)ptr2)[(uint)m]; m++)
							{
							}
						}
						if ((uint)m >= (uint)num12)
						{
							num11 = maximum_95ffuu.Invoke(num11, m);
							Get_rep_match_costs.Invoke(initial_state, num2, &localsPointer->field_2, l, num12, m, cur_state);
							int num14 = total_complexity + (2 + l);
							for (int n = num12; (uint)n <= (uint)m; n++)
							{
								void* ptr6 = (byte*)ptr + (nint)(uint)n * (nint)sizeof(lzham_lzcompressor_node);
								long num15 = total_cost + ((long*)(&localsPointer->field_2))[(uint)n];
								int total_complexity2 = num14;
								long total_cost2 = num15;
								void* parent_state = initial_state;
								lzdecision_Constructor_v5ftey.Invoke(dist: checked(-(l + 1)), @this: &localsPointer->field_4, pos: num2, len: n);
								add_state.Invoke(ptr6, j, k, &localsPointer->field_4, parent_state, total_cost2, total_complexity2);
							}
						}
						num12 = 2;
					}
					int num16 = num11;
					if (num8 != 0)
					{
						lzdecision_Constructor_v5ftey.Invoke(&localsPointer->field_5, num2, 2, num8);
						add_state.Invoke(total_cost: total_cost + Get_cost_vhfk4j.Invoke(initial_state, @this, &((lzham_lzcompressor*)@this)->field_5, &localsPointer->field_5), @this: (byte*)ptr + (nint)2 * sizeof(lzham_lzcompressor_node), parent_index: j, parent_state_index: k, lzdec: &localsPointer->field_5, parent_state: initial_state, total_complexity: total_complexity + 7);
						num16 = (((uint)num16 >= 2u) ? num16 : 2);
					}
					if ((uint)num6 > (uint)num16)
					{
						int num17 = ((1u >= (uint)num16) ? 1 : num16);
						for (int num18 = 0; (uint)num18 < (uint)num7; num18++)
						{
							int num19 = ((int*)(&localsPointer->field_0))[(uint)num18];
							if ((uint)num19 > (uint)num16)
							{
								int num20 = num17 + 1;
								int num21 = ((int*)(&localsPointer->field_1))[(uint)num18];
								Get_full_match_costs.Invoke(initial_state, @this, num2, &localsPointer->field_2, num21, num20, num19, cur_state);
								for (int num22 = num20; (uint)num22 <= (uint)num19; num22++)
								{
									int num23 = InstructionHelper.Select((uint)num22 >= 9u, 6, 7);
									void* ptr7 = (byte*)ptr + (nint)(uint)num22 * (nint)sizeof(lzham_lzcompressor_node);
									long num24 = total_cost + ((long*)(&localsPointer->field_2))[(uint)num22];
									int num25 = total_complexity + num23;
									int total_complexity3 = num25;
									long total_cost3 = num24;
									void* parent_state2 = initial_state;
									lzdecision_Constructor_v5ftey.Invoke(&localsPointer->field_6, num2, num22, num21);
									add_state.Invoke(ptr7, j, k, &localsPointer->field_6, parent_state2, total_cost3, total_complexity3);
								}
								num17 = num19;
							}
						}
					}
					long num26 = total_cost + Get_lit_cost.Invoke(initial_state, @this, &((lzham_lzcompressor*)@this)->field_5, num2, lit_pred, cur_state);
					int num27 = total_complexity + 1;
					byte* num28 = (byte*)ptr + sizeof(lzham_lzcompressor_node);
					int total_complexity4 = num27;
					long total_cost4 = num26;
					void* parent_state3 = initial_state;
					lzdecision_Constructor_v5ftey.Invoke(&localsPointer->field_7, num2, 0, 0);
					add_state.Invoke(num28, j, k, &localsPointer->field_7, parent_state3, total_cost4, total_complexity4);
				}
				num2++;
				num3++;
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
				long num29 = -1L;
				int num30 = 0;
				void* node_states2 = &((lzham_lzcompressor_node*)nodes)[(uint)bytes_to_match].m_node_states;
				for (int num31 = 0; (uint)num31 < (uint)((lzham_lzcompressor_node*)nodes)[(uint)bytes_to_match].m_num_node_states; num31++)
				{
					if ((ulong)((lzham_lzcompressor_node_state*)node_states2)[(uint)num31].m_total_cost < (ulong)num29)
					{
						num29 = ((lzham_lzcompressor_node_state*)node_states2)[(uint)num31].m_total_cost;
						num30 = num31;
					}
				}
				int num32 = bytes_to_match;
				void* ptr8 = Get_ptr_4r7f9k.Invoke(&((lzham_lzcompressor_raw_parse_thread_state*)parse_state)->m_best_decisions);
				do
				{
					void* ptr9 = (byte*)(&((lzham_lzcompressor_node*)nodes)[num32].m_node_states) + (nint)num30 * (nint)sizeof(lzham_lzcompressor_node_state);
					lzham_CLZDecompBase* lzdec = &((lzham_lzcompressor_node_state*)ptr9)->m_lzdec;
					void* ptr10 = ptr8;
					ptr8 = (byte*)ptr10 + sizeof(lzham_CLZDecompBase);
					llvm_memcpy_p0_p0_i64.Invoke(ptr10, lzdec, 12L, isVolatile: false);
					num32 = ((lzham_lzcompressor_node_state*)ptr9)->m_parent_index;
					num30 = ((lzham_lzcompressor_node_state*)ptr9)->m_parent_state_index;
				}
				while (num32 > 0);
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
