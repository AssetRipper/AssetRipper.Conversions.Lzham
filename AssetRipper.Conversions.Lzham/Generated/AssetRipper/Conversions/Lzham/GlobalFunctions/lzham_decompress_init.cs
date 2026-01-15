using AssetRipper.Conversions.Lzham.Helpers;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

internal static partial class lzham_decompress_init
{
	public unsafe static void* Invoke(void* pParams)
	{
		void* result = lzham_lib_decompress_init.Invoke(pParams);
		if (ExceptionInfo.Current != null)
		{
			return null;
		}
		return result;
	}
}
