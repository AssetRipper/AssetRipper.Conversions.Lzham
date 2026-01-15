using AssetRipper.Conversions.Lzham.Helpers;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?lzham_lib_z_deflateBound@lzham@@YAKPEAUlzham_z_stream@@K@Z")]
[DemangledName("unsigned long __cdecl lzham::lzham_lib_z_deflateBound(struct lzham_z_stream *, unsigned long)")]
internal static partial class lzham_lib_z_deflateBound
{
	[return: NativeType("unsigned long")]
	public unsafe static int Invoke([NativeType("struct lzham_z_stream *")] void* pStream, [NativeType("unsigned long")] int source_len)
	{
		return unchecked(64 + source_len + (int)((uint)(source_len + 4095) / 4096u * 4));
	}
}
