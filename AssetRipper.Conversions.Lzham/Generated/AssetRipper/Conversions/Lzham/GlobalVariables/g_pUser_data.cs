using AssetRipper.Conversions.Lzham.Helpers;

namespace AssetRipper.Conversions.Lzham.GlobalVariables;

[MangledName("?g_pUser_data@lzham@@3PEAXEA")]
[DemangledName("void *lzham::g_pUser_data")]
internal static partial class g_pUser_data
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
}
