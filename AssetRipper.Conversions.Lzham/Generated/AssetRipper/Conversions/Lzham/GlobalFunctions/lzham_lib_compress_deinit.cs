using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?lzham_lib_compress_deinit@lzham@@YAIPEAX@Z")]
[DemangledName("unsigned int __cdecl lzham::lzham_lib_compress_deinit(void *)")]
internal static partial class lzham_lib_compress_deinit
{
	[return: NativeType("unsigned int")]
	public unsafe static int Invoke([NativeType("void *")] void* p)
	{
		if (p == null)
		{
			return 0;
		}
		int result = Get_src_adler32.Invoke(&unchecked((lzham_lzham_compress_state*)p)->m_compressor);
		lzham_delete_w5u5xk.Invoke(p);
		if (ExceptionInfo.Current != null)
		{
			return 0;
		}
		return result;
	}
}
