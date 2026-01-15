using AssetRipper.Conversions.Lzham.GlobalFunctions;
using AssetRipper.Conversions.Lzham.Helpers;

namespace AssetRipper.Conversions.Lzham.GlobalVariables;

[MangledName("?g_pMSize@lzham@@3P6A_KPEAX0@ZEA")]
[DemangledName("unsigned __int64 (__cdecl *lzham::g_pMSize)(void *, void *)")]
internal static partial class g_pMSize
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

	unsafe static g_pMSize()
	{
		Value = lzham_default_msize.__pointer;
	}
}
