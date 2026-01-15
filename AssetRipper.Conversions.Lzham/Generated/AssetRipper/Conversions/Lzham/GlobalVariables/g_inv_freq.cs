using AssetRipper.Conversions.Lzham.Helpers;

namespace AssetRipper.Conversions.Lzham.GlobalVariables;

[MangledName("?g_inv_freq@lzham_timer@lzham@@0NA")]
[DemangledName("private: static double lzham::lzham_timer::g_inv_freq")]
internal static partial class g_inv_freq
{
	private static double __value;

	public static double Value
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

	static g_inv_freq()
	{
		Value = 0.0;
	}
}
