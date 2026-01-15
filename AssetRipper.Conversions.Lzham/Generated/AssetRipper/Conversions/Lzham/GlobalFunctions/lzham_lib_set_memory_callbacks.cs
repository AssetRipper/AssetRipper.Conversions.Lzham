using AssetRipper.Conversions.Lzham.GlobalVariables;
using AssetRipper.Conversions.Lzham.Helpers;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?lzham_lib_set_memory_callbacks@lzham@@YAXP6APEAXPEAX_KPEA_KI0@ZP6A_K00@Z0@Z")]
[DemangledName("void __cdecl lzham::lzham_lib_set_memory_callbacks(void * (__cdecl *)(void *, unsigned __int64, unsigned __int64 *, unsigned int, void *), unsigned __int64 (__cdecl *)(void *, void *), void *)")]
internal static partial class lzham_lib_set_memory_callbacks
{
	[return: NativeType("void")]
	public unsafe static void Invoke([NativeType("void * (__cdecl *)(void *, unsigned __int64, unsigned __int64 *, unsigned int, void *)")] void* pRealloc, [NativeType("unsigned __int64 (__cdecl *)(void *, void *)")] void* pMSize, [NativeType("void *")] void* pUser_data)
	{
		if (pRealloc == null || pMSize == null)
		{
			g_pRealloc.Value = lzham_default_realloc.__pointer;
			g_pMSize.Value = lzham_default_msize.__pointer;
			g_pUser_data.Value = null;
		}
		else
		{
			g_pRealloc.Value = pRealloc;
			g_pMSize.Value = pMSize;
			g_pUser_data.Value = pUser_data;
		}
	}
}
