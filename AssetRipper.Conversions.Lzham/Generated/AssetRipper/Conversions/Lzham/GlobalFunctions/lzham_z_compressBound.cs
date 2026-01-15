namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

internal static partial class lzham_z_compressBound
{
	public static int Invoke(int source_len)
	{
		return lzham_lib_z_compressBound.Invoke(source_len);
	}
}
