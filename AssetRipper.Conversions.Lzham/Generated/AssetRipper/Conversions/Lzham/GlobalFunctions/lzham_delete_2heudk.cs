using AssetRipper.Conversions.Lzham.Helpers;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("??$lzham_delete@Ulzham_decompressor@lzham@@@lzham@@YAXPEAUlzham_decompressor@0@@Z")]
[DemangledName("void __cdecl lzham::lzham_delete<struct lzham::lzham_decompressor>(struct lzham::lzham_decompressor *)")]
[CleanName("lzham_delete")]
internal static partial class lzham_delete_2heudk
{
	[return: NativeType("void")]
	public unsafe static void Invoke([NativeType("struct lzham::lzham_decompressor *")] void* p)
	{
		if (p == null)
		{
			return;
		}
		destruct_s37tni.Invoke(p);
		if (ExceptionInfo.Current == null)
		{
			lzham_free.Invoke(p);
			if (ExceptionInfo.Current == null)
			{
			}
		}
	}
}
