using AssetRipper.Conversions.Lzham.Helpers;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

internal static partial class lzham_decompress
{
	public unsafe static int Invoke(void* p, void* pIn_buf, void* pIn_buf_size, void* pOut_buf, void* pOut_buf_size, int no_more_input_bytes_flag)
	{
		int result = lzham_lib_decompress.Invoke(p, pIn_buf, pIn_buf_size, pOut_buf, pOut_buf_size, no_more_input_bytes_flag);
		if (ExceptionInfo.Current != null)
		{
			return 0;
		}
		return result;
	}
}
