using AssetRipper.Conversions.Lzham.Helpers;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

internal static partial class lzham_compress2
{
	public unsafe static int Invoke(void* p, void* pIn_buf, void* pIn_buf_size, void* pOut_buf, void* pOut_buf_size, int flush_type)
	{
		int result = lzham_lib_compress2.Invoke(p, pIn_buf, pIn_buf_size, pOut_buf, pOut_buf_size, flush_type);
		if (ExceptionInfo.Current != null)
		{
			return 0;
		}
		return result;
	}
}
