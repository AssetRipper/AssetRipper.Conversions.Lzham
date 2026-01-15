using AssetRipper.Conversions.Lzham.Helpers;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

internal static partial class lzham_z_inflateInit2
{
	public unsafe static int Invoke(void* pStream, int window_bits)
	{
		int result = lzham_lib_z_inflateInit2.Invoke(pStream, window_bits);
		if (ExceptionInfo.Current != null)
		{
			return 0;
		}
		return result;
	}
}
