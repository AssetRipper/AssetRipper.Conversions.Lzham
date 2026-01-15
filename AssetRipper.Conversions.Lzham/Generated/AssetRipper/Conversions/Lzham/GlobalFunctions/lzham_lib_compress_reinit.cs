using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?lzham_lib_compress_reinit@lzham@@YAPEAXPEAX@Z")]
[DemangledName("void * __cdecl lzham::lzham_lib_compress_reinit(void *)")]
internal static partial class lzham_lib_compress_reinit
{
	[return: NativeType("void *")]
	public unsafe static void* Invoke([NativeType("void *")] void* p)
	{
		unchecked
		{
			if (p != null)
			{
				bool flag = reset_j4w9gw.Invoke(&((lzham_lzham_compress_state*)p)->m_compressor);
				if (ExceptionInfo.Current != null)
				{
					return null;
				}
				if (!flag)
				{
					return null;
				}
				((lzham_lzham_compress_state*)p)->m_pIn_buf = null;
				((lzham_lzham_compress_state*)p)->m_pIn_buf_size = null;
				((lzham_lzham_compress_state*)p)->m_pOut_buf = null;
				((lzham_lzham_compress_state*)p)->m_pOut_buf_size = null;
				((lzham_lzham_compress_state*)p)->m_status = 0;
				((lzham_lzham_compress_state*)p)->m_comp_data_ofs = 0L;
				((lzham_lzham_compress_state*)p)->m_finished_compression = 0;
			}
			return p;
		}
	}
}
