using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?lzham_lib_decompress@lzham@@YA?AW4lzham_decompress_status_t@@PEAXPEBEPEA_KPEAE2I@Z")]
[DemangledName("enum lzham_decompress_status_t __cdecl lzham::lzham_lib_decompress(void *, unsigned char const *, unsigned __int64 *, unsigned char *, unsigned __int64 *, unsigned int)")]
internal static partial class lzham_lib_decompress
{
	[return: NativeType("enum lzham_decompress_status_t")]
	public unsafe static int Invoke([NativeType("void *")] void* p, [NativeType("unsigned char const *")] void* pIn_buf, [NativeType("unsigned __int64 *")] void* pIn_buf_size, [NativeType("unsigned char *")] void* pOut_buf, [NativeType("unsigned __int64 *")] void* pOut_buf_size, [NativeType("unsigned int")] int no_more_input_bytes_flag)
	{
		unchecked
		{
			if (p == null || ((lzham_lzham_decompressor*)p)->m_params.m_dict_size_log2 == 0 || pIn_buf_size == null || pOut_buf_size == null)
			{
				return 15;
			}
			if (*(long*)pIn_buf_size != 0L && pIn_buf == null)
			{
				return 15;
			}
			if (*(long*)pOut_buf_size != 0L && pOut_buf == null)
			{
				return 15;
			}
			((lzham_lzham_decompressor*)p)->m_pIn_buf = pIn_buf;
			((lzham_lzham_decompressor*)p)->m_pIn_buf_size = pIn_buf_size;
			((lzham_lzham_decompressor*)p)->m_pOut_buf = pOut_buf;
			((lzham_lzham_decompressor*)p)->m_pOut_buf_size = pOut_buf_size;
			((lzham_lzham_decompressor*)p)->m_no_more_input_bytes_flag = ((no_more_input_bytes_flag != 0) ? ((sbyte)1) : ((sbyte)0));
			if ((((lzham_lzham_decompressor*)p)->m_params.m_decompress_flags & 1) != 0)
			{
				if (((lzham_lzham_decompressor*)p)->m_pOrig_out_buf == null)
				{
					((lzham_lzham_decompressor*)p)->m_pOrig_out_buf = pOut_buf;
					((lzham_lzham_decompressor*)p)->m_orig_out_buf_size = *(long*)pOut_buf_size;
				}
				else if (((lzham_lzham_decompressor*)p)->m_pOrig_out_buf != pOut_buf || ((lzham_lzham_decompressor*)p)->m_orig_out_buf_size != *(long*)pOut_buf_size)
				{
					return 15;
				}
			}
			int result;
			if ((((lzham_lzham_decompressor*)p)->m_params.m_decompress_flags & 1) != 0)
			{
				int num = decompress_9tv66f.Invoke(p);
				if (ExceptionInfo.Current != null)
				{
					return 0;
				}
				result = num;
			}
			else
			{
				int num2 = decompress_3euu7r.Invoke(p);
				if (ExceptionInfo.Current != null)
				{
					return 0;
				}
				result = num2;
			}
			return result;
		}
	}
}
