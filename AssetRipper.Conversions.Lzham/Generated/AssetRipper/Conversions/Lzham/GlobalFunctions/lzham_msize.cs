using AssetRipper.Conversions.Lzham.GlobalVariables;
using AssetRipper.Conversions.Lzham.Helpers;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?lzham_msize@lzham@@YA_KPEAX@Z")]
[DemangledName("unsigned __int64 __cdecl lzham::lzham_msize(void *)")]
internal static partial class lzham_msize
{
	[return: NativeType("unsigned __int64")]
	public unsafe static long Invoke([NativeType("void *")] void* p)
	{
		if (p == null)
		{
			return 0L;
		}
		unchecked
		{
			if (((ulong)p & 0xFuL) != 0L)
			{
				lzham_mem_error.Invoke(String_xzs3ub.Pointer);
				return 0L;
			}
			long result = ((delegate*<void*, void*, long>)g_pMSize.Value)(p, g_pUser_data.Value);
			if (ExceptionInfo.Current != null)
			{
				return 0L;
			}
			return result;
		}
	}
}
