using AssetRipper.Conversions.Lzham.Helpers;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("??$lzham_new@Vlzcompressor@lzham@@@lzham@@YAPEAVlzcompressor@0@XZ")]
[DemangledName("class lzham::lzcompressor * __cdecl lzham::lzham_new<class lzham::lzcompressor>(void)")]
[CleanName("lzham_new")]
internal static partial class lzham_new_pkbiun
{
	[return: NativeType("class lzham::lzcompressor *")]
	public unsafe static void* Invoke()
	{
		void* ptr = lzham_malloc.Invoke(6444504L, null);
		if (ExceptionInfo.Current != null)
		{
			return null;
		}
		void* ptr2 = ptr;
		if (ptr2 == null)
		{
			return null;
		}
		void* result = construct_9447k8.Invoke(ptr2);
		if (ExceptionInfo.Current != null)
		{
			return null;
		}
		return result;
	}
}
