using AssetRipper.Conversions.Lzham.Helpers;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("??$lzham_new@Vtask_pool@lzham@@@lzham@@YAPEAVtask_pool@0@XZ")]
[DemangledName("class lzham::task_pool * __cdecl lzham::lzham_new<class lzham::task_pool>(void)")]
[CleanName("lzham_new")]
internal static partial class lzham_new_9wezva
{
	[return: NativeType("class lzham::task_pool *")]
	public unsafe static void* Invoke()
	{
		void* ptr = lzham_malloc.Invoke(1L, null);
		if (ExceptionInfo.Current != null)
		{
			return null;
		}
		void* ptr2 = ptr;
		if (ptr2 == null)
		{
			return null;
		}
		return construct_t4has9.Invoke(ptr2);
	}
}
