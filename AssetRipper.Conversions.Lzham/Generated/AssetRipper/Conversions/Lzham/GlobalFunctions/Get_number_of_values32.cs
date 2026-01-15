using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?get_number_of_values32@tracked_stat@lzcompressor@lzham@@QEAAIXZ")]
[DemangledName("public: unsigned int __cdecl lzham::lzcompressor::tracked_stat::get_number_of_values32(void)")]
internal static partial class Get_number_of_values32
{
	[return: NativeType("unsigned int")]
	public unsafe static int Invoke(void* @this)
	{
		return unchecked((int)((4294967295uL >= (ulong)((lzham_lzcompressor_tracked_stat*)@this)->m_num) ? ((lzham_lzcompressor_tracked_stat*)@this)->m_num : 4294967295L));
	}
}
