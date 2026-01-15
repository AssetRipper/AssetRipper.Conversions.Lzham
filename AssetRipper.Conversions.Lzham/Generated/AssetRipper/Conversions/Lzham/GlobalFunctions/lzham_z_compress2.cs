using AssetRipper.Conversions.Lzham.Helpers;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

internal static partial class lzham_z_compress2
{
	public unsafe static int Invoke(void* pDest, void* pDest_len, void* pSource, int source_len, int level)
	{
		int result = lzham_lib_z_compress2.Invoke(pDest, pDest_len, pSource, source_len, level);
		if (ExceptionInfo.Current != null)
		{
			return 0;
		}
		return result;
	}
}
