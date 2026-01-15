using AssetRipper.Conversions.Lzham.Helpers;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("??$destruct@Vtask_pool@lzham@@@helpers@lzham@@YAXPEAVtask_pool@1@@Z")]
[DemangledName("void __cdecl lzham::helpers::destruct<class lzham::task_pool>(class lzham::task_pool *)")]
[CleanName("destruct")]
internal static partial class destruct_qywrhp
{
	[return: NativeType("void")]
	public unsafe static void Invoke([NativeType("class lzham::task_pool *")] void* p)
	{
		task_pool_Destructor.Invoke(p);
	}
}
