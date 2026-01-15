namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

internal static partial class lzham_z_adler32
{
	public unsafe static int Invoke(int adler, void* ptr, long buf_len)
	{
		return lzham_lib_z_adler32.Invoke(adler, ptr, buf_len);
	}
}
