using AssetRipper.Conversions.Lzham.GlobalVariables;
using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?get_elapsed_secs@lzham_timer@lzham@@QEBANXZ")]
[DemangledName("public: double __cdecl lzham::lzham_timer::get_elapsed_secs(void) const")]
internal static partial class Get_elapsed_secs
{
	[return: NativeType("double")]
	public unsafe static double Invoke(void* @this)
	{
		long num = 0L;
		unchecked
		{
			if ((((lzham_lzham_timer*)@this)->field_2 & 1 & 1) != 1)
			{
				return 0.0;
			}
			num = ((lzham_lzham_timer*)@this)->field_1;
			if (((((lzham_lzham_timer*)@this)->field_2 >>> 1) & 1 & 1) != 1)
			{
				query_counter.Invoke(&num);
			}
			return (double)(num - ((lzham_lzham_timer*)@this)->field_0) * g_inv_freq.Value;
		}
	}
}
