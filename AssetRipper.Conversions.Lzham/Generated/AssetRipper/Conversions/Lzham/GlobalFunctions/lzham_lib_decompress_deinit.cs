using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?lzham_lib_decompress_deinit@lzham@@YAIPEAX@Z")]
[DemangledName("unsigned int __cdecl lzham::lzham_lib_decompress_deinit(void *)")]
internal static partial class lzham_lib_decompress_deinit
{
	[return: NativeType("unsigned int")]
	public unsafe static int Invoke([NativeType("void *")] void* p)
	{
		if (p == null)
		{
			return 0;
		}
		unchecked
		{
			int decomp_adler = ((lzham_lzham_decompressor*)p)->m_decomp_adler32;
			lzham_free.Invoke(((lzham_lzham_decompressor*)p)->m_pRaw_decomp_buf);
			if (ExceptionInfo.Current != null)
			{
				return 0;
			}
			lzham_delete_2heudk.Invoke(p);
			if (ExceptionInfo.Current != null)
			{
				return 0;
			}
			return decomp_adler;
		}
	}
}
