using AssetRipper.Conversions.Lzham.Helpers;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?lzham_lib_compress@lzham@@YA?AW4lzham_compress_status_t@@PEAXPEBEPEA_KPEAE2I@Z")]
[DemangledName("enum lzham_compress_status_t __cdecl lzham::lzham_lib_compress(void *, unsigned char const *, unsigned __int64 *, unsigned char *, unsigned __int64 *, unsigned int)")]
internal static partial class lzham_lib_compress
{
	[return: NativeType("enum lzham_compress_status_t")]
	public unsafe static int Invoke([NativeType("void *")] void* p, [NativeType("unsigned char const *")] void* pIn_buf, [NativeType("unsigned __int64 *")] void* pIn_buf_size, [NativeType("unsigned char *")] void* pOut_buf, [NativeType("unsigned __int64 *")] void* pOut_buf_size, [NativeType("unsigned int")] int no_more_input_bytes_flag)
	{
		int result = lzham_lib_compress2.Invoke(p, pIn_buf, pIn_buf_size, pOut_buf, pOut_buf_size, InstructionHelper.Select(no_more_input_bytes_flag != 0, 4, 0));
		if (ExceptionInfo.Current != null)
		{
			return 0;
		}
		return result;
	}
}
