using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?clear@tracked_stat@lzcompressor@lzham@@QEAAXXZ")]
[DemangledName("public: void __cdecl lzham::lzcompressor::tracked_stat::clear(void)")]
[CleanName("clear")]
internal static partial class clear_yhrysc
{
	[return: NativeType("void")]
	public unsafe static void Invoke(void* @this)
	{
		unchecked
		{
			((lzham_lzcompressor_tracked_stat*)@this)->m_num = 0L;
			((lzham_lzcompressor_tracked_stat*)@this)->m_total = 0.0;
			((lzham_lzcompressor_tracked_stat*)@this)->m_total2 = 0.0;
			((lzham_lzcompressor_tracked_stat*)@this)->m_min_val = 9E+99;
			((lzham_lzcompressor_tracked_stat*)@this)->m_max_val = -9E+99;
		}
	}
}
