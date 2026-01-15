using AssetRipper.Conversions.Lzham.Helpers;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("??$construct@Vtask_pool@lzham@@@helpers@lzham@@YAPEAVtask_pool@1@PEAV21@@Z")]
[DemangledName("class lzham::task_pool * __cdecl lzham::helpers::construct<class lzham::task_pool>(class lzham::task_pool *)")]
[CleanName("construct")]
internal static partial class construct_t4has9
{
	[return: NativeType("class lzham::task_pool *")]
	public unsafe static void* Invoke([NativeType("class lzham::task_pool *")] void* p)
	{
		task_pool_Constructor.Invoke(p);
		return p;
	}
}
