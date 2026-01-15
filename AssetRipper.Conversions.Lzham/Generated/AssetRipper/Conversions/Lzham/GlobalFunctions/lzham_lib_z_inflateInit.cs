using AssetRipper.Conversions.Lzham.Helpers;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?lzham_lib_z_inflateInit@lzham@@YAHPEAUlzham_z_stream@@@Z")]
[DemangledName("int __cdecl lzham::lzham_lib_z_inflateInit(struct lzham_z_stream *)")]
internal static partial class lzham_lib_z_inflateInit
{
	[return: NativeType("int")]
	public unsafe static int Invoke([NativeType("struct lzham_z_stream *")] void* pStream)
	{
		int result = lzham_lib_z_inflateInit2.Invoke(pStream, 15);
		if (ExceptionInfo.Current != null)
		{
			return 0;
		}
		return result;
	}
}
