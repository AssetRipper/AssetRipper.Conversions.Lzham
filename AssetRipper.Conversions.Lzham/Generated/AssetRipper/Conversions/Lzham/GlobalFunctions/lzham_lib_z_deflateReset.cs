using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?lzham_lib_z_deflateReset@lzham@@YAHPEAUlzham_z_stream@@@Z")]
[DemangledName("int __cdecl lzham::lzham_lib_z_deflateReset(struct lzham_z_stream *)")]
internal static partial class lzham_lib_z_deflateReset
{
	[return: NativeType("int")]
	public unsafe static int Invoke([NativeType("struct lzham_z_stream *")] void* pStream)
	{
		if (pStream == null)
		{
			return -2;
		}
		unchecked
		{
			void* state = ((lzham_z_stream*)pStream)->state;
			if (state == null)
			{
				return -2;
			}
			void* ptr = lzham_lib_compress_reinit.Invoke(state);
			if (ExceptionInfo.Current != null)
			{
				return 0;
			}
			state = ptr;
			if (state == null)
			{
				return -2;
			}
			((lzham_z_stream*)pStream)->state = state;
			return 0;
		}
	}
}
