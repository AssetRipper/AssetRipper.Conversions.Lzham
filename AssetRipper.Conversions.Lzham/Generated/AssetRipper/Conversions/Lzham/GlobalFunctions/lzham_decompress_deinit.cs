using AssetRipper.Conversions.Lzham.Helpers;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

internal static partial class lzham_decompress_deinit
{
	public unsafe static int Invoke(void* p)
	{
		int result = lzham_lib_decompress_deinit.Invoke(p);
		if (ExceptionInfo.Current != null)
		{
			return 0;
		}
		return result;
	}
}
