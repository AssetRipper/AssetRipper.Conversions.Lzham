using AssetRipper.Conversions.Lzham.GlobalFunctions;
using AssetRipper.Conversions.Lzham.Helpers;

namespace AssetRipper.Conversions.Lzham.GlobalVariables;

[MangledName("?g_pRealloc@lzham@@3P6APEAXPEAX_KPEA_KI0@ZEA")]
[DemangledName("void * (__cdecl *lzham::g_pRealloc)(void *, unsigned __int64, unsigned __int64 *, unsigned int, void *)")]
internal static partial class g_pRealloc
{
	private unsafe static void* __value;

	public unsafe static void* Value
	{
		get
		{
			return __value;
		}
		set
		{
			__value = value;
		}
	}

	unsafe static g_pRealloc()
	{
		Value = lzham_default_realloc.__pointer;
	}
}
