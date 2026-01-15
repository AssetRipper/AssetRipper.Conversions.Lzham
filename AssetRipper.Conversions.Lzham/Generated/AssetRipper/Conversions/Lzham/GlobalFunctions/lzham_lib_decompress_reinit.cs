using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Intrinsics.Implemented;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?lzham_lib_decompress_reinit@lzham@@YAPEAXPEAXPEBUlzham_decompress_params@@@Z")]
[DemangledName("void * __cdecl lzham::lzham_lib_decompress_reinit(void *, struct lzham_decompress_params const *)")]
internal static partial class lzham_lib_decompress_reinit
{
	[return: NativeType("void *")]
	public unsafe static void* Invoke([NativeType("void *")] void* p, [NativeType("struct lzham_decompress_params const *")] void* pParams)
	{
		if (p == null)
		{
			void* result = lzham_lib_decompress_init.Invoke(pParams);
			if (ExceptionInfo.Current != null)
			{
				return null;
			}
			return result;
		}
		if (!check_params.Invoke(pParams))
		{
			return null;
		}
		unchecked
		{
			if ((((lzham_lzham_decompressor*)p)->m_params.m_decompress_flags & 1) != 0)
			{
				lzham_free.Invoke(((lzham_lzham_decompressor*)p)->m_pRaw_decomp_buf);
				if (ExceptionInfo.Current != null)
				{
					return null;
				}
				((lzham_lzham_decompressor*)p)->m_pRaw_decomp_buf = null;
				((lzham_lzham_decompressor*)p)->m_raw_decomp_buf_size = 0;
				((lzham_lzham_decompressor*)p)->m_pDecomp_buf = null;
			}
			else
			{
				int num = 1 << ((lzham_lzham_decompressor*)p)->m_params.m_dict_size_log2;
				if (((lzham_lzham_decompressor*)p)->m_pRaw_decomp_buf == null || (uint)((lzham_lzham_decompressor*)p)->m_raw_decomp_buf_size < (uint)num)
				{
					void* ptr = lzham_realloc.Invoke(((lzham_lzham_decompressor*)p)->m_pRaw_decomp_buf, (uint)(num + 15), null, movable: true);
					if (ExceptionInfo.Current != null)
					{
						return null;
					}
					void* ptr2 = ptr;
					if (ptr2 == null)
					{
						return null;
					}
					((lzham_lzham_decompressor*)p)->m_pRaw_decomp_buf = ptr2;
					((lzham_lzham_decompressor*)p)->m_raw_decomp_buf_size = num;
					((lzham_lzham_decompressor*)p)->m_pDecomp_buf = align_up_pointer.Invoke(((lzham_lzham_decompressor*)p)->m_pRaw_decomp_buf, 16);
				}
			}
			llvm_memcpy_p0_p0_i64.Invoke(&((lzham_lzham_decompressor*)p)->m_params, pParams, 40L, isVolatile: false);
			init_fucheg.Invoke(p);
			if (ExceptionInfo.Current != null)
			{
				return null;
			}
			reset_arith_tables.Invoke(p);
			return p;
		}
	}
}
