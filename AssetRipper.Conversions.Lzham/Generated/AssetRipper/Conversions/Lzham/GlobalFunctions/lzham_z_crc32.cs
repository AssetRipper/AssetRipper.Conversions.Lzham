namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

internal static partial class lzham_z_crc32
{
	public unsafe static int Invoke(int crc, void* ptr, long buf_len)
	{
		return lzham_lib_z_crc32.Invoke(crc, ptr, buf_len);
	}
}
