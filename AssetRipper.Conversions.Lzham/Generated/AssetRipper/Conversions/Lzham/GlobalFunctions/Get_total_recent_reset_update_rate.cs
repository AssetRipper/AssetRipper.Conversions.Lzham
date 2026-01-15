using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?get_total_recent_reset_update_rate@lzcompressor@lzham@@AEAAIXZ")]
[DemangledName("private: unsigned int __cdecl lzham::lzcompressor::get_total_recent_reset_update_rate(void)")]
internal static partial class Get_total_recent_reset_update_rate
{
	[return: NativeType("unsigned int")]
	public unsafe static int Invoke(void* @this)
	{
		int num = 0;
		unchecked
		{
			for (int i = 0; (uint)i < (uint)((lzham_lzcompressor*)@this)->field_22; i++)
			{
				num += (((((lzham_lzcompressor_block_history*)(&((lzham_lzcompressor*)@this)->field_21))[(uint)i].m_reset_update_rate & 1) == 1) ? 1 : 0);
			}
			return num;
		}
	}
}
