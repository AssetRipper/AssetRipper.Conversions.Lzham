using AssetRipper.Conversions.Lzham.Helpers;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("??$lzham_delete@Vtask_pool@lzham@@@lzham@@YAXPEAVtask_pool@0@@Z")]
[DemangledName("void __cdecl lzham::lzham_delete<class lzham::task_pool>(class lzham::task_pool *)")]
[CleanName("lzham_delete")]
internal static partial class lzham_delete_w9ji3f
{
	[return: NativeType("void")]
	public unsafe static void Invoke([NativeType("class lzham::task_pool *")] void* p)
	{
		if (p != null)
		{
			destruct_qywrhp.Invoke(p);
			lzham_free.Invoke(p);
			if (ExceptionInfo.Current == null)
			{
			}
		}
	}
}
