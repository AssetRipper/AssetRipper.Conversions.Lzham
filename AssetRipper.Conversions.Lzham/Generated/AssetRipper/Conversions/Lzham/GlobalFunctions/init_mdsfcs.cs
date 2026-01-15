using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Intrinsics.Implemented;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?init@search_accelerator@lzham@@QEAA_NPEAUCLZBase@2@PEAVtask_pool@2@III_NI@Z")]
[DemangledName("public: bool __cdecl lzham::search_accelerator::init(struct lzham::CLZBase *, class lzham::task_pool *, unsigned int, unsigned int, unsigned int, bool, unsigned int)")]
[CleanName("init")]
internal static partial class init_mdsfcs
{
	[return: NativeType("bool")]
	public unsafe static bool Invoke(void* @this, [NativeType("struct lzham::CLZBase *")] void* pLZBase, [NativeType("class lzham::task_pool *")] void* pPool, [NativeType("unsigned int")] int max_helper_threads, [NativeType("unsigned int")] int max_dict_size, [NativeType("unsigned int")] int max_matches, [NativeType("bool")] bool all_matches, [NativeType("unsigned int")] int max_probes)
	{
		sbyte b = (all_matches ? ((sbyte)1) : ((sbyte)0));
		unchecked
		{
			((lzham_search_accelerator*)@this)->m_max_probes = ((128u >= (uint)max_probes) ? max_probes : 128);
			((lzham_search_accelerator*)@this)->m_pLZBase = pLZBase;
			((lzham_search_accelerator*)@this)->m_pTask_pool = ((max_helper_threads == 0) ? null : pPool);
			((lzham_search_accelerator*)@this)->m_max_helper_threads = ((((lzham_search_accelerator*)@this)->m_pTask_pool != null) ? max_helper_threads : 0);
			((lzham_search_accelerator*)@this)->m_max_matches = (((uint)((lzham_search_accelerator*)@this)->m_max_probes >= (uint)max_matches) ? max_matches : ((lzham_search_accelerator*)@this)->m_max_probes);
			((lzham_search_accelerator*)@this)->m_all_matches = (((b & 1) == 1) ? ((sbyte)1) : ((sbyte)0));
			((lzham_search_accelerator*)@this)->m_max_dict_size = max_dict_size;
			((lzham_search_accelerator*)@this)->m_max_dict_size_mask = ((lzham_search_accelerator*)@this)->m_max_dict_size - 1;
			((lzham_search_accelerator*)@this)->m_cur_dict_size = 0;
			((lzham_search_accelerator*)@this)->m_lookahead_size = 0;
			((lzham_search_accelerator*)@this)->m_lookahead_pos = 0;
			((lzham_search_accelerator*)@this)->m_fill_lookahead_pos = 0;
			((lzham_search_accelerator*)@this)->m_fill_lookahead_size = 0;
			((lzham_search_accelerator*)@this)->m_fill_dict_size = 0;
			((lzham_search_accelerator*)@this)->m_num_completed_helper_threads = 0;
			bool flag = try_resize_no_construct_wtjrfv.Invoke(&((lzham_search_accelerator*)@this)->m_dict, max_dict_size + (((uint)((lzham_search_accelerator*)@this)->m_max_dict_size >= 65536u) ? 65536 : ((lzham_search_accelerator*)@this)->m_max_dict_size), grow_hint: false);
			if (ExceptionInfo.Current != null)
			{
				return false;
			}
			if (!flag)
			{
				return false;
			}
			bool flag2 = try_resize_no_construct_t7khkc.Invoke(&((lzham_search_accelerator*)@this)->m_hash, 65536, grow_hint: false);
			if (ExceptionInfo.Current != null)
			{
				return false;
			}
			if (!flag2)
			{
				return false;
			}
			bool flag3 = try_resize_no_construct_tu9ban.Invoke(&((lzham_search_accelerator*)@this)->m_nodes, max_dict_size, grow_hint: false);
			if (ExceptionInfo.Current != null)
			{
				return false;
			}
			if (!flag3)
			{
				return false;
			}
			llvm_memset_p0_i64.Invoke(Get_ptr_npwtpj.Invoke(&((lzham_search_accelerator*)@this)->m_hash), 0, (uint)size_in_bytes_uw9qkk.Invoke(&((lzham_search_accelerator*)@this)->m_hash), isVolatile: false);
			return true;
		}
	}
}
