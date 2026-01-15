using AssetRipper.Conversions.Lzham.Helpers;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

internal static partial class lzham_decompress_reinit
{
	public unsafe static void* Invoke(void* p, void* pParams)
	{
		void* result = lzham_lib_decompress_reinit.Invoke(p, pParams);
		if (ExceptionInfo.Current != null)
		{
			return null;
		}
		return result;
	}
}
