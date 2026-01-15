using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("??0search_accelerator@lzham@@QEAA@XZ")]
[DemangledName("public: __cdecl lzham::search_accelerator::search_accelerator(void)")]
internal static partial class search_accelerator_Constructor
{
	public unsafe static void* Invoke(void* @this)
	{
		unchecked
		{
			((lzham_search_accelerator*)@this)->m_pLZBase = null;
			((lzham_search_accelerator*)@this)->m_pTask_pool = null;
			((lzham_search_accelerator*)@this)->m_max_helper_threads = 0;
			((lzham_search_accelerator*)@this)->m_max_dict_size = 0;
			((lzham_search_accelerator*)@this)->m_max_dict_size_mask = 0;
			((lzham_search_accelerator*)@this)->m_lookahead_pos = 0;
			((lzham_search_accelerator*)@this)->m_lookahead_size = 0;
			((lzham_search_accelerator*)@this)->m_cur_dict_size = 0;
			lzham_vector* dict = &((lzham_search_accelerator*)@this)->m_dict;
			vector_unsigned_char_Constructor.Invoke(dict);
			lzham_vector* hash = &((lzham_search_accelerator*)@this)->m_hash;
			vector_unsigned_int_Constructor.Invoke(hash);
			if (ExceptionInfo.Current == null)
			{
				lzham_vector* nodes = &((lzham_search_accelerator*)@this)->m_nodes;
				vector_struct_lzham_node_Constructor.Invoke(nodes);
				if (ExceptionInfo.Current == null)
				{
					lzham_vector* matches = &((lzham_search_accelerator*)@this)->m_matches;
					vector_struct_lzham_dict_match_Constructor.Invoke(matches);
					if (ExceptionInfo.Current == null)
					{
						lzham_vector* match_refs = &((lzham_search_accelerator*)@this)->m_match_refs;
						vector_long_Constructor.Invoke(match_refs);
						if (ExceptionInfo.Current == null)
						{
							lzham_vector* hash_thread_index = &((lzham_search_accelerator*)@this)->m_hash_thread_index;
							vector_unsigned_char_Constructor.Invoke(hash_thread_index);
							if (ExceptionInfo.Current == null)
							{
								lzham_vector* digram_hash = &((lzham_search_accelerator*)@this)->m_digram_hash;
								vector_unsigned_int_Constructor.Invoke(digram_hash);
								if (ExceptionInfo.Current == null)
								{
									vector_unsigned_int_Constructor.Invoke(&((lzham_search_accelerator*)@this)->m_digram_next);
									if (ExceptionInfo.Current == null)
									{
										((lzham_search_accelerator*)@this)->m_fill_lookahead_pos = 0;
										((lzham_search_accelerator*)@this)->m_fill_lookahead_size = 0;
										((lzham_search_accelerator*)@this)->m_fill_dict_size = 0;
										((lzham_search_accelerator*)@this)->m_max_probes = 0;
										((lzham_search_accelerator*)@this)->m_max_matches = 0;
										((lzham_search_accelerator*)@this)->m_all_matches = 0;
										((lzham_search_accelerator*)@this)->m_next_match_ref = 0;
										((lzham_search_accelerator*)@this)->m_num_completed_helper_threads = 0;
										return @this;
									}
									ExceptionInfo current = ExceptionInfo.Current;
									ExceptionInfo.Current = null;
									vector_unsigned_int_Destructor.Invoke(digram_hash);
									if (ExceptionInfo.Current != null)
									{
										return null;
									}
									ExceptionInfo.Current = current;
								}
								ExceptionInfo current2 = ExceptionInfo.Current;
								ExceptionInfo.Current = null;
								vector_unsigned_char_Destructor.Invoke(hash_thread_index);
								if (ExceptionInfo.Current != null)
								{
									return null;
								}
								ExceptionInfo.Current = current2;
							}
							ExceptionInfo current3 = ExceptionInfo.Current;
							ExceptionInfo.Current = null;
							vector_long_Destructor.Invoke(match_refs);
							if (ExceptionInfo.Current != null)
							{
								return null;
							}
							ExceptionInfo.Current = current3;
						}
						ExceptionInfo current4 = ExceptionInfo.Current;
						ExceptionInfo.Current = null;
						vector_struct_lzham_dict_match_Destructor.Invoke(matches);
						if (ExceptionInfo.Current != null)
						{
							return null;
						}
						ExceptionInfo.Current = current4;
					}
					ExceptionInfo current5 = ExceptionInfo.Current;
					ExceptionInfo.Current = null;
					vector_struct_lzham_node_Destructor.Invoke(nodes);
					if (ExceptionInfo.Current != null)
					{
						return null;
					}
					ExceptionInfo.Current = current5;
				}
				ExceptionInfo current6 = ExceptionInfo.Current;
				ExceptionInfo.Current = null;
				vector_unsigned_int_Destructor.Invoke(hash);
				if (ExceptionInfo.Current != null)
				{
					return null;
				}
				ExceptionInfo.Current = current6;
			}
			ExceptionInfo current7 = ExceptionInfo.Current;
			ExceptionInfo.Current = null;
			vector_unsigned_char_Destructor.Invoke(dict);
			if (ExceptionInfo.Current != null)
			{
				return null;
			}
			ExceptionInfo.Current = current7;
			return null;
		}
	}
}
