using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?enumerate_lz_decisions@lzcompressor@lzham@@AEAAHIAEBVstate@12@AEAV?$vector@Ulzpriced_decision@lzcompressor@lzham@@@2@II@Z")]
[DemangledName("private: int __cdecl lzham::lzcompressor::enumerate_lz_decisions(unsigned int, class lzham::lzcompressor::state const &, class lzham::vector<struct lzham::lzcompressor::lzpriced_decision> &, unsigned int, unsigned int)")]
internal static partial class enumerate_lz_decisions
{
	private partial struct LocalVariables
	{
		public lzham_lzcompressor_lzpriced_decision field_0;

		public lzham_lzcompressor_lzpriced_decision field_1;
	}

	[return: NativeType("int")]
	public unsafe static int Invoke(void* @this, [NativeType("unsigned int")] int ofs, [NativeType("class lzham::lzcompressor::state const &")] void* cur_state, [NativeType("class lzham::vector<struct lzham::lzcompressor::lzpriced_decision> &")] void* decisions, [NativeType("unsigned int")] int min_match_len, [NativeType("unsigned int")] int max_match_len)
	{
		StackFrame startFrame = StackFrameList.Current.New<LocalVariables>();
		LocalVariables* localsPointer = startFrame.GetLocalsPointer<LocalVariables>();
		localsPointer->field_0 = default(lzham_lzcompressor_lzpriced_decision);
		localsPointer->field_1 = default(lzham_lzcompressor_lzpriced_decision);
		int lookahead_ofs;
		int num;
		long num2;
		int num3;
		int num4;
		unchecked
		{
			lookahead_ofs = ofs - (Get_lookahead_pos.Invoke(&((lzham_lzcompressor*)@this)->field_5) & Get_max_dict_size_mask.Invoke(&((lzham_lzcompressor*)@this)->field_5));
			num = 0;
			if ((uint)min_match_len <= 1u)
			{
				bool flag = try_resize_zaw49p.Invoke(decisions, 1, grow_hint: false);
				if (ExceptionInfo.Current != null)
				{
					return 0;
				}
				if (flag)
				{
					void* ptr = vector_struct_lzham_lzcompressor_lzpriced_decision_Operator.Invoke(decisions, 0);
					init_3ayd9r.Invoke(ptr, ofs, 0, 0, 0L);
					((lzham_lzcompressor_lzpriced_decision*)ptr)->field_1 = Get_cost_vhfk4j.Invoke(cur_state, @this, &((lzham_lzcompressor*)@this)->field_5, ptr);
					num2 = ((lzham_lzcompressor_lzpriced_decision*)ptr)->field_1;
					num3 = 1;
					goto IL_0133;
				}
				num4 = -1;
			}
			else
			{
				bool flag2 = try_resize_zaw49p.Invoke(decisions, 0, grow_hint: false);
				if (ExceptionInfo.Current != null)
				{
					return 0;
				}
				if (flag2)
				{
					num3 = 0;
					num2 = -1L;
					goto IL_0133;
				}
				num4 = -1;
			}
			goto IL_0418;
		}
		IL_0418:
		int result = num4;
		StackFrameList.Current.Clear(startFrame);
		return result;
		IL_0133:
		int num5 = 0;
		int num6 = 0;
		unchecked
		{
			while (true)
			{
				if ((uint)num6 < 4u)
				{
					int num7 = Get_match_len.Invoke(&((lzham_lzcompressor*)@this)->field_5, lookahead_ofs, ((int*)(&((lzham_lzcompressor_state_base*)cur_state)->m_match_hist))[(uint)num6], max_match_len, 0);
					if ((uint)num7 >= (uint)min_match_len && ((num7 == 1 && num6 == 0) || (uint)num7 >= 2u))
					{
						num5 = maximum_95ffuu.Invoke(num5, num7);
						lzpriced_decision_Constructor_a2ewag.Invoke(dist: checked(-(num6 + 1)), @this: &localsPointer->field_0, pos: ofs, len: num7);
						long field_ = Get_cost_vhfk4j.Invoke(cur_state, @this, &((lzham_lzcompressor*)@this)->field_5, &localsPointer->field_0);
						localsPointer->field_0.field_1 = field_;
						bool flag3 = try_push_back_9qid3f.Invoke(decisions, &localsPointer->field_0);
						if (ExceptionInfo.Current != null)
						{
							return 0;
						}
						if (!flag3)
						{
							num4 = -1;
							break;
						}
						if ((uint)num7 > (uint)num3 || (num7 == num3 && (ulong)localsPointer->field_0.field_1 < (ulong)num2))
						{
							num = size_n7npue.Invoke(decisions) - 1;
							num3 = num7;
							num2 = localsPointer->field_0.field_1;
						}
					}
					num6++;
					continue;
				}
				if ((uint)max_match_len >= 2u && (uint)num5 < (uint)((lzham_lzcompressor*)@this)->field_2.m_fast_bytes)
				{
					void* ptr2 = find_matches.Invoke(&((lzham_lzcompressor*)@this)->field_5, lookahead_ofs, spin: true);
					if (ptr2 != null)
					{
						while (true)
						{
							int num8 = minimum_c94n3m.Invoke(Get_len_xiv86i.Invoke(ptr2), max_match_len);
							if ((uint)num8 >= (uint)min_match_len && (uint)num8 > (uint)num5)
							{
								if ((uint)max_match_len > 257u && num8 == 257)
								{
									num8 = Get_match_len.Invoke(&((lzham_lzcompressor*)@this)->field_5, lookahead_ofs, Get_dist.Invoke(ptr2), max_match_len, 257);
								}
								lzpriced_decision_Constructor_a2ewag.Invoke(dist: Get_dist.Invoke(ptr2), @this: &localsPointer->field_1, pos: ofs, len: num8);
								long field_2 = Get_cost_vhfk4j.Invoke(cur_state, @this, &((lzham_lzcompressor*)@this)->field_5, &localsPointer->field_1);
								localsPointer->field_1.field_1 = field_2;
								bool flag4 = try_push_back_9qid3f.Invoke(decisions, &localsPointer->field_1);
								if (ExceptionInfo.Current != null)
								{
									return 0;
								}
								if (!flag4)
								{
									break;
								}
								if ((uint)num8 > (uint)num3 || (num8 == num3 && (ulong)Get_cost_cpkzqg.Invoke(&localsPointer->field_1) < (ulong)num2))
								{
									num = size_n7npue.Invoke(decisions) - 1;
									num3 = num8;
									num2 = Get_cost_cpkzqg.Invoke(&localsPointer->field_1);
								}
							}
							if (is_last.Invoke(ptr2))
							{
								goto IL_0413;
							}
							ptr2 = (byte*)ptr2 + sizeof(lzham_dict_match);
						}
						num4 = -1;
						break;
					}
				}
				goto IL_0413;
				IL_0413:
				num4 = num;
				break;
			}
			goto IL_0418;
		}
	}
}
