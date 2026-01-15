using AssetRipper.Conversions.Lzham.Helpers;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

internal static partial class lzham_z_inflateEnd
{
	public unsafe static int Invoke(void* pStream)
	{
		int result = lzham_lib_z_inflateEnd.Invoke(pStream);
		if (ExceptionInfo.Current != null)
		{
			return 0;
		}
		return result;
	}
}
