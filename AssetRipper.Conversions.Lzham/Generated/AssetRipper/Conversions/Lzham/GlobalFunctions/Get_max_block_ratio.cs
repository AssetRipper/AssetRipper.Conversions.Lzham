using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?get_max_block_ratio@lzcompressor@lzham@@AEAAIXZ")]
[DemangledName("private: unsigned int __cdecl lzham::lzcompressor::get_max_block_ratio(void)")]
internal static partial class Get_max_block_ratio
{
	[return: NativeType("unsigned int")]
	public unsafe static int Invoke(void* @this)
	{
		unchecked
		{
			if (((lzham_lzcompressor*)@this)->field_22 == 0)
			{
				return 0;
			}
			int num = 0;
			for (int i = 0; (uint)i < (uint)((lzham_lzcompressor*)@this)->field_22; i++)
			{
				num = (((uint)((lzham_lzcompressor_block_history*)(&((lzham_lzcompressor*)@this)->field_21))[(uint)i].m_ratio >= (uint)num) ? ((lzham_lzcompressor_block_history*)(&((lzham_lzcompressor*)@this)->field_21))[(uint)i].m_ratio : num);
			}
			return num;
		}
	}
}
