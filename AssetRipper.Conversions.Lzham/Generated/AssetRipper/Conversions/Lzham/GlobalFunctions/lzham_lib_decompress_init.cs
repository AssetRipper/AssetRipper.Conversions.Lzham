using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Intrinsics.Implemented;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?lzham_lib_decompress_init@lzham@@YAPEAXPEBUlzham_decompress_params@@@Z")]
[DemangledName("void * __cdecl lzham::lzham_lib_decompress_init(struct lzham_decompress_params const *)")]
internal static partial class lzham_lib_decompress_init
{
	[return: NativeType("void *")]
	public unsafe static void* Invoke([NativeType("struct lzham_decompress_params const *")] void* pParams)
	{
		if (!check_params.Invoke(pParams))
		{
			return null;
		}
		void* ptr = lzham_new_6ef5hx.Invoke();
		if (ExceptionInfo.Current != null)
		{
			return null;
		}
		void* ptr2 = ptr;
		if (ptr2 == null)
		{
			return null;
		}
		unchecked
		{
			llvm_memcpy_p0_p0_i64.Invoke(&((lzham_lzham_decompressor*)ptr2)->m_params, pParams, 40L, isVolatile: false);
			if ((((lzham_lzham_decompressor*)ptr2)->m_params.m_decompress_flags & 1) != 0)
			{
				((lzham_lzham_decompressor*)ptr2)->m_pRaw_decomp_buf = null;
				((lzham_lzham_decompressor*)ptr2)->m_raw_decomp_buf_size = 0;
				((lzham_lzham_decompressor*)ptr2)->m_pDecomp_buf = null;
			}
			else
			{
				int num = 1 << ((lzham_lzham_decompressor*)ptr2)->m_params.m_dict_size_log2;
				void* pRaw_decomp_buf = lzham_malloc.Invoke((uint)(num + 15), null);
				if (ExceptionInfo.Current != null)
				{
					return null;
				}
				((lzham_lzham_decompressor*)ptr2)->m_pRaw_decomp_buf = pRaw_decomp_buf;
				if (((lzham_lzham_decompressor*)ptr2)->m_pRaw_decomp_buf == null)
				{
					lzham_delete_2heudk.Invoke(ptr2);
					if (ExceptionInfo.Current != null)
					{
						return null;
					}
					return null;
				}
				((lzham_lzham_decompressor*)ptr2)->m_raw_decomp_buf_size = num;
				((lzham_lzham_decompressor*)ptr2)->m_pDecomp_buf = align_up_pointer.Invoke(((lzham_lzham_decompressor*)ptr2)->m_pRaw_decomp_buf, 16);
			}
			init_fucheg.Invoke(ptr2);
			if (ExceptionInfo.Current != null)
			{
				return null;
			}
			return ptr2;
		}
	}
}
