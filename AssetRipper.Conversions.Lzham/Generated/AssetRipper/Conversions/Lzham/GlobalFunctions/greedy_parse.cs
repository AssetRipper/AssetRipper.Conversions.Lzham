using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?greedy_parse@lzcompressor@lzham@@AEAA_NAEAUparse_thread_state@12@@Z")]
[DemangledName("private: bool __cdecl lzham::lzcompressor::greedy_parse(struct lzham::lzcompressor::parse_thread_state &)")]
internal static partial class greedy_parse
{
	[return: NativeType("bool")]
	public unsafe static bool Invoke(void* @this, [NativeType("struct lzham::lzcompressor::parse_thread_state &")] void* parse_state)
	{
		unchecked
		{
			((lzham_lzcompressor_raw_parse_thread_state*)parse_state)->m_failed = 1;
			((lzham_lzcompressor_raw_parse_thread_state*)parse_state)->m_emit_decisions_backwards = 0;
			int bytes_to_match = ((lzham_lzcompressor_raw_parse_thread_state*)parse_state)->m_bytes_to_match;
			int num = Get_lookahead_pos.Invoke(&((lzham_lzcompressor*)@this)->field_5) & Get_max_dict_size_mask.Invoke(&((lzham_lzcompressor*)@this)->field_5);
			int num2 = ((lzham_lzcompressor_raw_parse_thread_state*)parse_state)->m_start_ofs;
			int num3 = num2 - num;
			int num4 = 0;
			void* initial_state = &((lzham_lzcompressor_raw_parse_thread_state*)parse_state)->m_initial_state;
			void* temp_decisions = &((lzham_lzcompressor_raw_parse_thread_state*)parse_state)->m_temp_decisions;
			bool flag = try_reserve_4p788d.Invoke(temp_decisions, 384);
			if (ExceptionInfo.Current != null)
			{
				return false;
			}
			if (!flag)
			{
				return false;
			}
			bool flag2 = try_resize_aw2beb.Invoke(&((lzham_lzcompressor_raw_parse_thread_state*)parse_state)->m_best_decisions, 0, grow_hint: false);
			if (ExceptionInfo.Current != null)
			{
				return false;
			}
			if (!flag2)
			{
				return false;
			}
			while ((uint)num4 < (uint)bytes_to_match)
			{
				int num5 = enumerate_lz_decisions.Invoke(@this, num2, initial_state, temp_decisions, 1, (65536u >= (uint)(bytes_to_match - num4)) ? (bytes_to_match - num4) : 65536);
				if (ExceptionInfo.Current != null)
				{
					return false;
				}
				int num6 = num5;
				if (num6 < 0)
				{
					return false;
				}
				void* ptr = vector_struct_lzham_lzcompressor_lzpriced_decision_Operator.Invoke(temp_decisions, num6);
				bool flag3 = try_push_back_cmhkzj.Invoke(&((lzham_lzcompressor_raw_parse_thread_state*)parse_state)->m_best_decisions, ptr);
				if (ExceptionInfo.Current != null)
				{
					return false;
				}
				if (!flag3)
				{
					return false;
				}
				partial_advance.Invoke(initial_state, ptr);
				int num7 = Get_len_wzf5xk.Invoke(ptr);
				num2 += num7;
				num3 += num7;
				num4 += num7;
				if ((uint)size_9gqvur.Invoke(&((lzham_lzcompressor_raw_parse_thread_state*)parse_state)->m_best_decisions) < (uint)((lzham_lzcompressor_raw_parse_thread_state*)parse_state)->m_max_greedy_decisions)
				{
					continue;
				}
				((lzham_lzcompressor_raw_parse_thread_state*)parse_state)->m_greedy_parse_total_bytes_coded = num4;
				((lzham_lzcompressor_raw_parse_thread_state*)parse_state)->m_greedy_parse_gave_up = 1;
				return false;
			}
			((lzham_lzcompressor_raw_parse_thread_state*)parse_state)->m_greedy_parse_total_bytes_coded = num4;
			((lzham_lzcompressor_raw_parse_thread_state*)parse_state)->m_failed = 0;
			return true;
		}
	}
}
