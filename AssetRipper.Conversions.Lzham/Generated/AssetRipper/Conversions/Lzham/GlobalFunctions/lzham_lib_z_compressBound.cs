using AssetRipper.Conversions.Lzham.Helpers;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?lzham_lib_z_compressBound@lzham@@YAKK@Z")]
[DemangledName("unsigned long __cdecl lzham::lzham_lib_z_compressBound(unsigned long)")]
internal static partial class lzham_lib_z_compressBound
{
	[return: NativeType("unsigned long")]
	public unsafe static int Invoke([NativeType("unsigned long")] int source_len)
	{
		return lzham_lib_z_deflateBound.Invoke(null, source_len);
	}
}
