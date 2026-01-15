using AssetRipper.Conversions.Lzham.Helpers;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

internal static partial class lzham_compress_init
{
	public unsafe static void* Invoke(void* pParams)
	{
		void* result = lzham_lib_compress_init.Invoke(pParams);
		if (ExceptionInfo.Current != null)
		{
			return null;
		}
		return result;
	}
}
