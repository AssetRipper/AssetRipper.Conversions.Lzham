using AssetRipper.Conversions.Lzham.Helpers;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

internal static partial class lzham_z_deflateInit2
{
	public unsafe static int Invoke(void* pStream, int level, int method, int window_bits, int mem_level, int strategy)
	{
		int result = lzham_lib_z_deflateInit2.Invoke(pStream, level, method, window_bits, mem_level, strategy);
		if (ExceptionInfo.Current != null)
		{
			return 0;
		}
		return result;
	}
}
