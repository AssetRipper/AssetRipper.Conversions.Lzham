using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?check_params@lzham@@YA_NPEBUlzham_decompress_params@@@Z")]
[DemangledName("bool __cdecl lzham::check_params(struct lzham_decompress_params const *)")]
internal static partial class check_params
{
	[return: NativeType("bool")]
	public unsafe static bool Invoke([NativeType("struct lzham_decompress_params const *")] void* pParams)
	{
		unchecked
		{
			if (pParams == null || (long)(uint)((lzham_decompress_params*)pParams)->m_struct_size != 40L)
			{
				return false;
			}
			if ((uint)((lzham_decompress_params*)pParams)->m_dict_size_log2 < 15u || (uint)((lzham_decompress_params*)pParams)->m_dict_size_log2 > 29u)
			{
				return false;
			}
			if (((lzham_decompress_params*)pParams)->m_num_seed_bytes != 0)
			{
				if ((((lzham_decompress_params*)pParams)->m_decompress_flags & 1) != 0 || ((lzham_decompress_params*)pParams)->m_pSeed_bytes == null)
				{
					return false;
				}
				if ((uint)((lzham_decompress_params*)pParams)->m_num_seed_bytes > (uint)(1 << ((lzham_decompress_params*)pParams)->m_dict_size_log2))
				{
					return false;
				}
			}
			return true;
		}
	}
}
