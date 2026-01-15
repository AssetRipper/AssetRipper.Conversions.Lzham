using AssetRipper.Conversions.Lzham.Helpers;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

internal static partial class lzham_compress_memory
{
	public unsafe static int Invoke(void* pParams, void* pDst_buf, void* pDst_len, void* pSrc_buf, long src_len, void* pAdler32)
	{
		int result = lzham_lib_compress_memory.Invoke(pParams, pDst_buf, pDst_len, pSrc_buf, src_len, pAdler32);
		if (ExceptionInfo.Current != null)
		{
			return 0;
		}
		return result;
	}
}
