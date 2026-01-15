using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Intrinsics.Implemented;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?get_std_dev@tracked_stat@lzcompressor@lzham@@QEBANXZ")]
[DemangledName("public: double __cdecl lzham::lzcompressor::tracked_stat::get_std_dev(void) const")]
internal static partial class Get_std_dev
{
	[return: NativeType("double")]
	public unsafe static double Invoke(void* @this)
	{
		return unchecked((((lzham_lzcompressor_tracked_stat*)@this)->m_num == 0L) ? 0.0 : (sqrt.Invoke(llvm_fmuladd_f64.Invoke(((lzham_lzcompressor_tracked_stat*)@this)->m_num, ((lzham_lzcompressor_tracked_stat*)@this)->m_total2, 0.0 - ((lzham_lzcompressor_tracked_stat*)@this)->m_total * ((lzham_lzcompressor_tracked_stat*)@this)->m_total)) / (double)((lzham_lzcompressor_tracked_stat*)@this)->m_num));
	}
}
