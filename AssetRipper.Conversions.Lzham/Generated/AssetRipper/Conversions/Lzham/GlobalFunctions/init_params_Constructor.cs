using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("??0init_params@lzcompressor@lzham@@QEAA@XZ")]
[DemangledName("public: __cdecl lzham::lzcompressor::init_params::init_params(void)")]
internal static partial class init_params_Constructor
{
	public unsafe static void* Invoke(void* @this)
	{
		unchecked
		{
			((lzham_lzcompressor_init_params*)@this)->m_pTask_pool = null;
			((lzham_lzcompressor_init_params*)@this)->m_max_helper_threads = 0;
			((lzham_lzcompressor_init_params*)@this)->m_compression_level = 2;
			((lzham_lzcompressor_init_params*)@this)->m_dict_size_log2 = 22;
			((lzham_lzcompressor_init_params*)@this)->m_block_size = 524288;
			((lzham_lzcompressor_init_params*)@this)->m_lzham_compress_flags = 0;
			((lzham_lzcompressor_init_params*)@this)->m_pSeed_bytes = null;
			((lzham_lzcompressor_init_params*)@this)->m_num_seed_bytes = 0;
			((lzham_lzcompressor_init_params*)@this)->m_table_max_update_interval = 0;
			((lzham_lzcompressor_init_params*)@this)->m_table_update_interval_slow_rate = 0;
			return @this;
		}
	}
}
