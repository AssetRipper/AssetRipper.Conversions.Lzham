using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Intrinsics.Implemented;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?update@tracked_stat@lzcompressor@lzham@@QEAAXN@Z")]
[DemangledName("public: void __cdecl lzham::lzcompressor::tracked_stat::update(double)")]
[CleanName("update")]
internal static partial class update_dvgbkc
{
	[return: NativeType("void")]
	public unsafe static void Invoke(void* @this, [NativeType("double")] double val)
	{
		unchecked
		{
			((lzham_lzcompressor_tracked_stat*)@this)->m_num++;
			((lzham_lzcompressor_tracked_stat*)@this)->m_total += val;
			double* total = &((lzham_lzcompressor_tracked_stat*)@this)->m_total2;
			*total = llvm_fmuladd_f64.Invoke(val, val, *total);
			((lzham_lzcompressor_tracked_stat*)@this)->m_min_val = ((!(((lzham_lzcompressor_tracked_stat*)@this)->m_min_val < val)) ? val : ((lzham_lzcompressor_tracked_stat*)@this)->m_min_val);
			((lzham_lzcompressor_tracked_stat*)@this)->m_max_val = ((!(((lzham_lzcompressor_tracked_stat*)@this)->m_max_val < val)) ? ((lzham_lzcompressor_tracked_stat*)@this)->m_max_val : val);
		}
	}
}
