using AssetRipper.Conversions.Lzham.Helpers;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

internal static partial class lzham_z_compress
{
	public unsafe static int Invoke(void* pDest, void* pDest_len, void* pSource, int source_len)
	{
		int result = lzham_lib_z_compress.Invoke(pDest, pDest_len, pSource, source_len);
		if (ExceptionInfo.Current != null)
		{
			return 0;
		}
		return result;
	}
}
