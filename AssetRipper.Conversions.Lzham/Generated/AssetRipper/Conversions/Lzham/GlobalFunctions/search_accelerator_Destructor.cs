using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("??1search_accelerator@lzham@@QEAA@XZ")]
[DemangledName("public: __cdecl lzham::search_accelerator::~search_accelerator(void)")]
internal static partial class search_accelerator_Destructor
{
	public unsafe static void Invoke(void* @this)
	{
		unchecked
		{
			vector_unsigned_int_Destructor.Invoke(&((lzham_search_accelerator*)@this)->m_digram_next);
			if (ExceptionInfo.Current != null)
			{
				return;
			}
			vector_unsigned_int_Destructor.Invoke(&((lzham_search_accelerator*)@this)->m_digram_hash);
			if (ExceptionInfo.Current != null)
			{
				return;
			}
			vector_unsigned_char_Destructor.Invoke(&((lzham_search_accelerator*)@this)->m_hash_thread_index);
			if (ExceptionInfo.Current != null)
			{
				return;
			}
			vector_long_Destructor.Invoke(&((lzham_search_accelerator*)@this)->m_match_refs);
			if (ExceptionInfo.Current != null)
			{
				return;
			}
			vector_struct_lzham_dict_match_Destructor.Invoke(&((lzham_search_accelerator*)@this)->m_matches);
			if (ExceptionInfo.Current != null)
			{
				return;
			}
			vector_struct_lzham_node_Destructor.Invoke(&((lzham_search_accelerator*)@this)->m_nodes);
			if (ExceptionInfo.Current == null)
			{
				vector_unsigned_int_Destructor.Invoke(&((lzham_search_accelerator*)@this)->m_hash);
				if (ExceptionInfo.Current == null)
				{
					vector_unsigned_char_Destructor.Invoke(&((lzham_search_accelerator*)@this)->m_dict);
				}
			}
		}
	}
}
