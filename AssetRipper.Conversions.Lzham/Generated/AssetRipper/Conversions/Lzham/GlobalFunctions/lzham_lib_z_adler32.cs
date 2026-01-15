using AssetRipper.Conversions.Lzham.Helpers;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?lzham_lib_z_adler32@lzham@@YAKKPEBE_K@Z")]
[DemangledName("unsigned long __cdecl lzham::lzham_lib_z_adler32(unsigned long, unsigned char const *, unsigned __int64)")]
internal static partial class lzham_lib_z_adler32
{
	[return: NativeType("unsigned long")]
	public unsafe static int Invoke([NativeType("unsigned long")] int adler, [NativeType("unsigned char const *")] void* ptr, [NativeType("unsigned __int64")] long buf_len)
	{
		return adler32.Invoke(ptr, buf_len, adler);
	}
}
