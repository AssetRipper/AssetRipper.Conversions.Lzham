using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?get_average@tracked_stat@lzcompressor@lzham@@QEBANXZ")]
[DemangledName("public: double __cdecl lzham::lzcompressor::tracked_stat::get_average(void) const")]
internal static partial class Get_average
{
	[return: NativeType("double")]
	public unsafe static double Invoke(void* @this)
	{
		return unchecked((((lzham_lzcompressor_tracked_stat*)@this)->m_num == 0L) ? 0.0 : (((lzham_lzcompressor_tracked_stat*)@this)->m_total / (double)((lzham_lzcompressor_tracked_stat*)@this)->m_num));
	}
}
