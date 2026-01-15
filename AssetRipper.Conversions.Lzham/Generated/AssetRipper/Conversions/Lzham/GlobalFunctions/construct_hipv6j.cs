using AssetRipper.Conversions.Lzham.Helpers;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("??$construct@Ulzham_compress_state@lzham@@@helpers@lzham@@YAPEAUlzham_compress_state@1@PEAU21@@Z")]
[DemangledName("struct lzham::lzham_compress_state * __cdecl lzham::helpers::construct<struct lzham::lzham_compress_state>(struct lzham::lzham_compress_state *)")]
[CleanName("construct")]
internal static partial class construct_hipv6j
{
	[return: NativeType("struct lzham::lzham_compress_state *")]
	public unsafe static void* Invoke([NativeType("struct lzham::lzham_compress_state *")] void* p)
	{
		lzham_compress_state_Constructor.Invoke(p);
		if (ExceptionInfo.Current != null)
		{
			return null;
		}
		return p;
	}
}
