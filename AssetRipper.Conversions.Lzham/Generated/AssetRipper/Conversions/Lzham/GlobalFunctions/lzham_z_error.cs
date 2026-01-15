namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

internal static partial class lzham_z_error
{
	public unsafe static void* Invoke(int err)
	{
		return lzham_lib_z_error.Invoke(err);
	}
}
