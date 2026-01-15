using AssetRipper.Conversions.Lzham.Helpers;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?lzham_lib_z_compress@lzham@@YAHPEAEPEAKPEBEK@Z")]
[DemangledName("int __cdecl lzham::lzham_lib_z_compress(unsigned char *, unsigned long *, unsigned char const *, unsigned long)")]
internal static partial class lzham_lib_z_compress
{
	[return: NativeType("int")]
	public unsafe static int Invoke([NativeType("unsigned char *")] void* pDest, [NativeType("unsigned long *")] void* pDest_len, [NativeType("unsigned char const *")] void* pSource, [NativeType("unsigned long")] int source_len)
	{
		int result = lzham_lib_z_compress2.Invoke(pDest, pDest_len, pSource, source_len, -1);
		if (ExceptionInfo.Current != null)
		{
			return 0;
		}
		return result;
	}
}
