using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Intrinsics.Implemented;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?reset@search_accelerator@lzham@@QEAAXXZ")]
[DemangledName("public: void __cdecl lzham::search_accelerator::reset(void)")]
[CleanName("reset")]
internal static partial class reset_zf86ia
{
	[return: NativeType("void")]
	public unsafe static void Invoke(void* @this)
	{
		unchecked
		{
			((lzham_search_accelerator*)@this)->m_cur_dict_size = 0;
			((lzham_search_accelerator*)@this)->m_lookahead_size = 0;
			((lzham_search_accelerator*)@this)->m_lookahead_pos = 0;
			((lzham_search_accelerator*)@this)->m_fill_lookahead_pos = 0;
			((lzham_search_accelerator*)@this)->m_fill_lookahead_size = 0;
			((lzham_search_accelerator*)@this)->m_fill_dict_size = 0;
			((lzham_search_accelerator*)@this)->m_num_completed_helper_threads = 0;
			if (size_9n9s89.Invoke(&((lzham_search_accelerator*)@this)->m_hash) != 0)
			{
				llvm_memset_p0_i64.Invoke(Get_ptr_npwtpj.Invoke(&((lzham_search_accelerator*)@this)->m_hash), 0, (uint)size_in_bytes_uw9qkk.Invoke(&((lzham_search_accelerator*)@this)->m_hash), isVolatile: false);
			}
			if (size_9n9s89.Invoke(&((lzham_search_accelerator*)@this)->m_digram_hash) != 0)
			{
				llvm_memset_p0_i64.Invoke(Get_ptr_npwtpj.Invoke(&((lzham_search_accelerator*)@this)->m_digram_hash), 0, (uint)size_in_bytes_uw9qkk.Invoke(&((lzham_search_accelerator*)@this)->m_digram_hash), isVolatile: false);
			}
		}
	}
}
