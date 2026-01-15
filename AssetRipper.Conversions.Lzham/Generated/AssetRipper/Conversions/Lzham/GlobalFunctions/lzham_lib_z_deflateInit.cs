using AssetRipper.Conversions.Lzham.Helpers;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?lzham_lib_z_deflateInit@lzham@@YAHPEAUlzham_z_stream@@H@Z")]
[DemangledName("int __cdecl lzham::lzham_lib_z_deflateInit(struct lzham_z_stream *, int)")]
internal static partial class lzham_lib_z_deflateInit
{
	[return: NativeType("int")]
	public unsafe static int Invoke([NativeType("struct lzham_z_stream *")] void* pStream, [NativeType("int")] int level)
	{
		int result = lzham_lib_z_deflateInit2.Invoke(pStream, level, 14, 15, 9, 0);
		if (ExceptionInfo.Current != null)
		{
			return 0;
		}
		return result;
	}
}
