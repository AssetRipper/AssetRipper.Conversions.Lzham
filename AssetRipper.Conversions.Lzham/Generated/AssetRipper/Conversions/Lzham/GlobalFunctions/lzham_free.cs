using AssetRipper.Conversions.Lzham.GlobalVariables;
using AssetRipper.Conversions.Lzham.Helpers;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?lzham_free@lzham@@YAXPEAX@Z")]
[DemangledName("void __cdecl lzham::lzham_free(void *)")]
internal static partial class lzham_free
{
	[return: NativeType("void")]
	public unsafe static void Invoke([NativeType("void *")] void* p)
	{
		if (p == null)
		{
			return;
		}
		unchecked
		{
			if (((ulong)p & 0xFuL) != 0L)
			{
				lzham_mem_error.Invoke(String_6jy8jt.__pointer);
				return;
			}
			((delegate*<void*, long, void*, int, void*, void*>)g_pRealloc.Value)(p, 0L, null, 1, g_pUser_data.Value);
			if (ExceptionInfo.Current == null)
			{
			}
		}
	}
}
