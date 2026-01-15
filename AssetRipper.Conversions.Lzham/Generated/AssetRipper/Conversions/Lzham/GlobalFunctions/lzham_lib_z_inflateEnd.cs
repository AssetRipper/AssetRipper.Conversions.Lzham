using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?lzham_lib_z_inflateEnd@lzham@@YAHPEAUlzham_z_stream@@@Z")]
[DemangledName("int __cdecl lzham::lzham_lib_z_inflateEnd(struct lzham_z_stream *)")]
internal static partial class lzham_lib_z_inflateEnd
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
			if (state != null)
			{
				int adler33 = lzham_lib_decompress_deinit.Invoke(state);
				if (ExceptionInfo.Current != null)
				{
					return 0;
				}
				((lzham_z_stream*)pStream)->adler = adler33;
				((lzham_z_stream*)pStream)->state = null;
			}
			return 0;
		}
	}
}
