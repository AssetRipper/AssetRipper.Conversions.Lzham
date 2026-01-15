using AssetRipper.Conversions.Lzham.GlobalVariables;
using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?get_elapsed_us@lzham_timer@lzham@@QEBA_KXZ")]
[DemangledName("public: unsigned __int64 __cdecl lzham::lzham_timer::get_elapsed_us(void) const")]
internal static partial class Get_elapsed_us
{
	[return: NativeType("unsigned __int64")]
	public unsafe static long Invoke(void* @this)
	{
		long num = 0L;
		unchecked
		{
			if ((((lzham_lzham_timer*)@this)->field_2 & 1 & 1) != 1)
			{
				return 0L;
			}
			num = ((lzham_lzham_timer*)@this)->field_1;
			if (((((lzham_lzham_timer*)@this)->field_2 >>> 1) & 1 & 1) != 1)
			{
				query_counter.Invoke(&num);
			}
			return (long)((ulong)((num - ((lzham_lzham_timer*)@this)->field_0) * 1000000L + (g_freq.Value >>> 1)) / (ulong)g_freq.Value);
		}
	}
}
