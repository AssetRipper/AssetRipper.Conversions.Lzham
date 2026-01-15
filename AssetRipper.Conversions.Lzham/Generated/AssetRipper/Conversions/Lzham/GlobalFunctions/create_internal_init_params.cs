using AssetRipper.Conversions.Lzham.GlobalVariables;
using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?create_internal_init_params@lzham@@YA?AW4lzham_compress_status_t@@AEAUinit_params@lzcompressor@1@PEBUlzham_compress_params@@@Z")]
[DemangledName("enum lzham_compress_status_t __cdecl lzham::create_internal_init_params(struct lzham::lzcompressor::init_params &, struct lzham_compress_params const *)")]
internal static partial class create_internal_init_params
{
	[return: NativeType("enum lzham_compress_status_t")]
	public unsafe static int Invoke([NativeType("struct lzham::lzcompressor::init_params &")] void* internal_params, [NativeType("struct lzham_compress_params const *")] void* pParams)
	{
		unchecked
		{
			if ((uint)((lzham_compress_params*)pParams)->m_dict_size_log2 < 15u || (uint)((lzham_compress_params*)pParams)->m_dict_size_log2 > 29u)
			{
				return 6;
			}
			((lzham_lzcompressor_init_params*)internal_params)->m_dict_size_log2 = ((lzham_compress_params*)pParams)->m_dict_size_log2;
			if (((lzham_compress_params*)pParams)->m_max_helper_threads < 0)
			{
				((lzham_lzcompressor_init_params*)internal_params)->m_max_helper_threads = lzham_get_max_helper_threads.Invoke();
			}
			else
			{
				((lzham_lzcompressor_init_params*)internal_params)->m_max_helper_threads = ((lzham_compress_params*)pParams)->m_max_helper_threads;
			}
			((lzham_lzcompressor_init_params*)internal_params)->m_max_helper_threads = ((64u >= (uint)((lzham_lzcompressor_init_params*)internal_params)->m_max_helper_threads) ? ((lzham_lzcompressor_init_params*)internal_params)->m_max_helper_threads : 64);
			((lzham_lzcompressor_init_params*)internal_params)->m_lzham_compress_flags = ((lzham_compress_params*)pParams)->m_compress_flags;
			if (((lzham_compress_params*)pParams)->m_num_seed_bytes != 0)
			{
				if (((lzham_compress_params*)pParams)->m_pSeed_bytes == null || (uint)((lzham_compress_params*)pParams)->m_num_seed_bytes > (uint)(1 << ((lzham_compress_params*)pParams)->m_dict_size_log2))
				{
					return 6;
				}
				((lzham_lzcompressor_init_params*)internal_params)->m_num_seed_bytes = ((lzham_compress_params*)pParams)->m_num_seed_bytes;
				((lzham_lzcompressor_init_params*)internal_params)->m_pSeed_bytes = ((lzham_compress_params*)pParams)->m_pSeed_bytes;
			}
			switch (((lzham_compress_params*)pParams)->m_level)
			{
			case 0:
				((lzham_lzcompressor_init_params*)internal_params)->m_compression_level = 0;
				break;
			case 1:
				((lzham_lzcompressor_init_params*)internal_params)->m_compression_level = 1;
				break;
			case 2:
				((lzham_lzcompressor_init_params*)internal_params)->m_compression_level = 2;
				break;
			case 3:
				((lzham_lzcompressor_init_params*)internal_params)->m_compression_level = 3;
				break;
			case 4:
				((lzham_lzcompressor_init_params*)internal_params)->m_compression_level = 4;
				break;
			default:
				return 6;
			}
			if (((lzham_compress_params*)pParams)->m_table_max_update_interval != 0 || ((lzham_compress_params*)pParams)->m_table_update_interval_slow_rate != 0)
			{
				((lzham_lzcompressor_init_params*)internal_params)->m_table_max_update_interval = ((lzham_compress_params*)pParams)->m_table_max_update_interval;
				((lzham_lzcompressor_init_params*)internal_params)->m_table_update_interval_slow_rate = ((lzham_compress_params*)pParams)->m_table_update_interval_slow_rate;
			}
			else
			{
				int num = ((lzham_compress_params*)pParams)->m_table_update_rate;
				if (num == 0)
				{
					num = 8;
				}
				num = clamp.Invoke(num, 1, 20) - 1;
				((lzham_lzcompressor_init_params*)internal_params)->m_table_max_update_interval = (ushort)((lzham_table_update_settings*)g_table_update_settings.__pointer)[(uint)num].m_max_update_interval;
				((lzham_lzcompressor_init_params*)internal_params)->m_table_update_interval_slow_rate = (ushort)((lzham_table_update_settings*)g_table_update_settings.__pointer)[(uint)num].m_slow_rate;
			}
			return 3;
		}
	}
}
