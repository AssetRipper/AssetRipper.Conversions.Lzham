using AssetRipper.Conversions.Lzham.Helpers;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

internal static partial class lzham_z_inflate
{
	public unsafe static int Invoke(void* pStream, int flush)
	{
		int result = lzham_lib_z_inflate.Invoke(pStream, flush);
		if (ExceptionInfo.Current != null)
		{
			return 0;
		}
		return result;
	}
}
