using AssetRipper.Conversions.Lzham.Helpers;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

internal static partial class lzham_z_deflateEnd
{
	public unsafe static int Invoke(void* pStream)
	{
		int result = lzham_lib_z_deflateEnd.Invoke(pStream);
		if (ExceptionInfo.Current != null)
		{
			return 0;
		}
		return result;
	}
}
