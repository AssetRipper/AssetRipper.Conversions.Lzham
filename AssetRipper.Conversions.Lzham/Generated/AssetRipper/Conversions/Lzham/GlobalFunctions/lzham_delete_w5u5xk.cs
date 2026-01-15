using AssetRipper.Conversions.Lzham.Helpers;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("??$lzham_delete@Ulzham_compress_state@lzham@@@lzham@@YAXPEAUlzham_compress_state@0@@Z")]
[DemangledName("void __cdecl lzham::lzham_delete<struct lzham::lzham_compress_state>(struct lzham::lzham_compress_state *)")]
[CleanName("lzham_delete")]
internal static partial class lzham_delete_w5u5xk
{
	[return: NativeType("void")]
	public unsafe static void Invoke([NativeType("struct lzham::lzham_compress_state *")] void* p)
	{
		if (p == null)
		{
			return;
		}
		destruct_qtfz2c.Invoke(p);
		if (ExceptionInfo.Current == null)
		{
			lzham_free.Invoke(p);
			if (ExceptionInfo.Current == null)
			{
			}
		}
	}
}
