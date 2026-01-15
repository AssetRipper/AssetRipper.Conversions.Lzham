using AssetRipper.Conversions.Lzham.Helpers;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("??$lzham_new@Ulzham_compress_state@lzham@@@lzham@@YAPEAUlzham_compress_state@0@XZ")]
[DemangledName("struct lzham::lzham_compress_state * __cdecl lzham::lzham_new<struct lzham::lzham_compress_state>(void)")]
[CleanName("lzham_new")]
internal static partial class lzham_new_2zi7i7
{
	[return: NativeType("struct lzham::lzham_compress_state *")]
	public unsafe static void* Invoke()
	{
		void* ptr = lzham_malloc.Invoke(6444624L, null);
		if (ExceptionInfo.Current != null)
		{
			return null;
		}
		void* ptr2 = ptr;
		if (ptr2 == null)
		{
			return null;
		}
		void* result = construct_hipv6j.Invoke(ptr2);
		if (ExceptionInfo.Current != null)
		{
			return null;
		}
		return result;
	}
}
