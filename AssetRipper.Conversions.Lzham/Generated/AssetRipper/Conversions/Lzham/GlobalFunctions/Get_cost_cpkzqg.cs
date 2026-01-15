using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?get_cost@lzpriced_decision@lzcompressor@lzham@@QEBA_KXZ")]
[DemangledName("public: unsigned __int64 __cdecl lzham::lzcompressor::lzpriced_decision::get_cost(void) const")]
[CleanName("Get_cost")]
internal static partial class Get_cost_cpkzqg
{
	[return: NativeType("unsigned __int64")]
	public unsafe static long Invoke(void* @this)
	{
		return unchecked((lzham_lzcompressor_lzpriced_decision*)@this)->field_1;
	}
}
