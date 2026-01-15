using AssetRipper.Conversions.Lzham.Helpers;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

internal static partial class lzham_z_inflateReset
{
	public unsafe static int Invoke(void* pStream)
	{
		int result = lzham_lib_z_inflateReset.Invoke(pStream);
		if (ExceptionInfo.Current != null)
		{
			return 0;
		}
		return result;
	}
}
