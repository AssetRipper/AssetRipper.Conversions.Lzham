namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

internal static partial class lzham_z_deflateBound
{
	public unsafe static int Invoke(void* pStream, int source_len)
	{
		return lzham_lib_z_deflateBound.Invoke(pStream, source_len);
	}
}
