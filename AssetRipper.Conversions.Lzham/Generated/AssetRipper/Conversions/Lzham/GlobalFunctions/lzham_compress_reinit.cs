using AssetRipper.Conversions.Lzham.Helpers;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

internal static partial class lzham_compress_reinit
{
	public unsafe static void* Invoke(void* p)
	{
		void* result = lzham_lib_compress_reinit.Invoke(p);
		if (ExceptionInfo.Current != null)
		{
			return null;
		}
		return result;
	}
}
