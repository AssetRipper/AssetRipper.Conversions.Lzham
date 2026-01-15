using AssetRipper.Conversions.Lzham.Helpers;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

internal static partial class lzham_z_deflateInit
{
	public unsafe static int Invoke(void* pStream, int level)
	{
		int result = lzham_lib_z_deflateInit.Invoke(pStream, level);
		if (ExceptionInfo.Current != null)
		{
			return 0;
		}
		return result;
	}
}
