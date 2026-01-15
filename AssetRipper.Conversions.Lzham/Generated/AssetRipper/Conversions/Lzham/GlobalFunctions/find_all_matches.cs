using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Intrinsics.Implemented;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?find_all_matches@search_accelerator@lzham@@QEAA_NI@Z")]
[DemangledName("public: bool __cdecl lzham::search_accelerator::find_all_matches(unsigned int)")]
internal static partial class find_all_matches
{
	[return: NativeType("bool")]
	public unsafe static bool Invoke(void* @this, [NativeType("unsigned int")] int num_bytes)
	{
		unchecked
		{
			bool flag = try_resize_no_construct_gzser2.Invoke(&((lzham_search_accelerator*)@this)->m_matches, ((lzham_search_accelerator*)@this)->m_max_probes * num_bytes, grow_hint: false);
			if (ExceptionInfo.Current != null)
			{
				return false;
			}
			if (!flag)
			{
				return false;
			}
			bool flag2 = try_resize_no_construct_e6uwjm.Invoke(&((lzham_search_accelerator*)@this)->m_match_refs, num_bytes, grow_hint: false);
			if (ExceptionInfo.Current != null)
			{
				return false;
			}
			if (!flag2)
			{
				return false;
			}
			llvm_memset_p0_i64.Invoke(Get_ptr_ehx3tj.Invoke(&((lzham_search_accelerator*)@this)->m_match_refs), -1, (uint)size_in_bytes_425i42.Invoke(&((lzham_search_accelerator*)@this)->m_match_refs), isVolatile: false);
			((lzham_search_accelerator*)@this)->m_fill_lookahead_pos = ((lzham_search_accelerator*)@this)->m_lookahead_pos;
			((lzham_search_accelerator*)@this)->m_fill_lookahead_size = num_bytes;
			((lzham_search_accelerator*)@this)->m_fill_dict_size = ((lzham_search_accelerator*)@this)->m_cur_dict_size;
			((lzham_search_accelerator*)@this)->m_next_match_ref = 0;
			if (((lzham_search_accelerator*)@this)->m_pTask_pool == null)
			{
				find_all_matches_callback.Invoke(@this, 0L, null);
				((lzham_search_accelerator*)@this)->m_num_completed_helper_threads = 0;
			}
			else
			{
				bool flag3 = try_resize_no_construct_wtjrfv.Invoke(&((lzham_search_accelerator*)@this)->m_hash_thread_index, 65536, grow_hint: false);
				if (ExceptionInfo.Current != null)
				{
					return false;
				}
				if (!flag3)
				{
					return false;
				}
				llvm_memset_p0_i64.Invoke(Get_ptr_cpjzjc.Invoke(&((lzham_search_accelerator*)@this)->m_hash_thread_index), -1, (uint)size_in_bytes_bksyn8.Invoke(&((lzham_search_accelerator*)@this)->m_hash_thread_index), isVolatile: false);
				int num = 0;
				void* ptr = vector_unsigned_char_Operator_apxfsu.Invoke(&((lzham_search_accelerator*)@this)->m_dict, ((lzham_search_accelerator*)@this)->m_lookahead_pos & ((lzham_search_accelerator*)@this)->m_max_dict_size_mask);
				int num2 = 0;
				if ((uint)num_bytes >= 3u)
				{
					int c = (byte)(*(sbyte*)ptr);
					int num3 = (byte)((sbyte*)ptr)[1];
					int num4 = checked(num_bytes - 2);
					for (int i = 0; i < num4; i = checked(i + 1))
					{
						int num5 = (byte)((sbyte*)ptr)[2];
						int i2 = hash3_to_16.Invoke(c, num3, num5);
						c = num3;
						num3 = num5;
						ptr = (byte*)ptr + 1;
						if ((byte)(*(sbyte*)vector_unsigned_char_Operator_apxfsu.Invoke(&((lzham_search_accelerator*)@this)->m_hash_thread_index, i2)) == byte.MaxValue)
						{
							num2++;
							*(sbyte*)vector_unsigned_char_Operator_apxfsu.Invoke(&((lzham_search_accelerator*)@this)->m_hash_thread_index, i2) = (sbyte)num;
							int num6 = num + 1;
							num = num6;
							if (num6 == ((lzham_search_accelerator*)@this)->m_max_helper_threads)
							{
								num = 0;
							}
						}
					}
				}
				((lzham_search_accelerator*)@this)->m_num_completed_helper_threads = 0;
				bool flag4 = queue_multiple_object_tasks_i2hqqa.Invoke(((lzham_search_accelerator*)@this)->m_pTask_pool, num_tasks: ((lzham_search_accelerator*)@this)->m_max_helper_threads, pObject: @this, pObject_method: find_all_matches_callback.__pointer, first_data: 0L, pData_ptr: null);
				if (ExceptionInfo.Current != null)
				{
					return false;
				}
				if (!flag4)
				{
					return false;
				}
			}
			bool result = find_len2_matches.Invoke(@this);
			if (ExceptionInfo.Current != null)
			{
				return false;
			}
			return result;
		}
	}
}
