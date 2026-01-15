using AssetRipper.Conversions.Lzham.Helpers;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("??$lzham_new@Ulzham_decompressor@lzham@@@lzham@@YAPEAUlzham_decompressor@0@XZ")]
[DemangledName("struct lzham::lzham_decompressor * __cdecl lzham::lzham_new<struct lzham::lzham_decompressor>(void)")]
[CleanName("lzham_new")]
internal static partial class lzham_new_6ef5hx
{
	[return: NativeType("struct lzham::lzham_decompressor *")]
	public unsafe static void* Invoke()
	{
		void* ptr = lzham_malloc.Invoke(1656L, null);
		if (ExceptionInfo.Current != null)
		{
			return null;
		}
		void* ptr2 = ptr;
		if (ptr2 == null)
		{
			return null;
		}
		void* result = construct_hr2weg.Invoke(ptr2);
		if (ExceptionInfo.Current != null)
		{
			return null;
		}
		return result;
	}
}
