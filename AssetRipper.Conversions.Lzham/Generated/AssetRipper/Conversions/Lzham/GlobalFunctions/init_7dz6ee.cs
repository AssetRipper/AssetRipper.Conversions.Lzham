using AssetRipper.Conversions.Lzham.GlobalVariables;
using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Intrinsics.Implemented;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?init@lzcompressor@lzham@@QEAA_NAEBUinit_params@12@@Z")]
[DemangledName("public: bool __cdecl lzham::lzcompressor::init(struct lzham::lzcompressor::init_params const &)")]
[CleanName("init")]
internal static partial class init_7dz6ee
{
	[return: NativeType("bool")]
	public unsafe static bool Invoke(void* @this, [NativeType("struct lzham::lzcompressor::init_params const &")] void* @params)
	{
		clear_uak2zs.Invoke(@this);
		if (ExceptionInfo.Current != null)
		{
			return false;
		}
		int num3;
		int num5;
		unchecked
		{
			if ((uint)((lzham_lzcompressor_init_params*)@params)->m_dict_size_log2 < 15u || (uint)((lzham_lzcompressor_init_params*)@params)->m_dict_size_log2 > 29u)
			{
				return false;
			}
			if (((lzham_lzcompressor_init_params*)@params)->m_compression_level < 0 || ((lzham_lzcompressor_init_params*)@params)->m_compression_level > 5)
			{
				return false;
			}
			llvm_memcpy_p0_p0_i64.Invoke(&((lzham_lzcompressor*)@this)->field_1, @params, 56L, isVolatile: false);
			bool num = ((lzham_lzcompressor*)@this)->field_1.m_pTask_pool != null && Get_num_threads.Invoke(((lzham_lzcompressor*)@this)->field_1.m_pTask_pool) != 0 && ((lzham_lzcompressor*)@this)->field_1.m_max_helper_threads != 0;
			((lzham_lzcompressor*)@this)->field_14 = (num ? ((sbyte)1) : ((sbyte)0));
			if ((((lzham_lzcompressor*)@this)->field_14 & 1) != 1)
			{
				((lzham_lzcompressor*)@this)->field_1.m_max_helper_threads = 0;
			}
			long num2 = ((lzham_lzcompressor_init_params*)@params)->m_compression_level;
			llvm_memcpy_p0_p0_i64.Invoke(source: (byte*)s_level_settings.Pointer + (nint)num2 * sizeof(lzham_comp_settings), destination: &((lzham_lzcompressor*)@this)->field_2, length: 16L, isVolatile: false);
			num3 = 1 << ((lzham_lzcompressor*)@this)->field_1.m_dict_size_log2;
			if (((lzham_lzcompressor_init_params*)@params)->m_num_seed_bytes != 0)
			{
				if (((lzham_lzcompressor_init_params*)@params)->m_pSeed_bytes == null)
				{
					return false;
				}
				if ((uint)((lzham_lzcompressor_init_params*)@params)->m_num_seed_bytes > (uint)num3)
				{
					return false;
				}
			}
			int num4 = (int)((uint)num3 / 8u);
			if ((uint)((lzham_lzcompressor*)@this)->field_1.m_block_size > (uint)num4)
			{
				((lzham_lzcompressor*)@this)->field_1.m_block_size = num4;
			}
			((lzham_lzcompressor*)@this)->field_17 = 1;
			if (((lzham_lzcompressor*)@this)->field_1.m_max_helper_threads != 0)
			{
				if ((uint)((lzham_lzcompressor*)@this)->field_1.m_block_size < 16384u)
				{
					((lzham_lzcompressor*)@this)->field_17 = ((8u >= (uint)(((lzham_lzcompressor*)@this)->field_1.m_max_helper_threads + 1)) ? (((lzham_lzcompressor*)@this)->field_1.m_max_helper_threads + 1) : 8);
				}
				else if (((lzham_lzcompressor*)@this)->field_1.m_max_helper_threads == 1 || ((lzham_lzcompressor*)@this)->field_1.m_compression_level == 0)
				{
					((lzham_lzcompressor*)@this)->field_17 = 1;
				}
				else if ((uint)((lzham_lzcompressor*)@this)->field_1.m_max_helper_threads <= 3u)
				{
					((lzham_lzcompressor*)@this)->field_17 = 2;
				}
				else if ((uint)((lzham_lzcompressor*)@this)->field_1.m_max_helper_threads <= 7u)
				{
					if ((((lzham_lzcompressor*)@this)->field_1.m_lzham_compress_flags & 2) != 0 && ((lzham_lzcompressor*)@this)->field_1.m_compression_level == 4)
					{
						((lzham_lzcompressor*)@this)->field_17 = 4;
					}
					else
					{
						((lzham_lzcompressor*)@this)->field_17 = 2;
					}
				}
				else
				{
					((lzham_lzcompressor*)@this)->field_17 = 4;
				}
			}
			num5 = ((lzham_lzcompressor*)@this)->field_17 - 1;
		}
		int max_helper_threads = ((0 < unchecked((lzham_lzcompressor*)@this)->field_1.m_max_helper_threads - num5) ? (unchecked((lzham_lzcompressor*)@this)->field_1.m_max_helper_threads - num5) : 0);
		unchecked
		{
			if ((((lzham_lzcompressor*)@this)->field_14 & 1) != 1)
			{
			}
			bool flag = init_mdsfcs.Invoke(&((lzham_lzcompressor*)@this)->field_5, max_probes: ((lzham_lzcompressor*)@this)->field_2.m_match_accel_max_probes, max_matches: ((lzham_lzcompressor*)@this)->field_2.m_match_accel_max_matches_per_probe, pLZBase: @this, pPool: ((lzham_lzcompressor_init_params*)@params)->m_pTask_pool, max_helper_threads: max_helper_threads, max_dict_size: num3, all_matches: false);
			if (ExceptionInfo.Current != null)
			{
				return false;
			}
			if (!flag)
			{
				return false;
			}
			init_position_slots.Invoke(@this, ((lzham_lzcompressor_init_params*)@params)->m_dict_size_log2);
			init_slot_tabs.Invoke(@this);
			bool flag2 = init_meqzb7.Invoke(&((lzham_lzcompressor*)@this)->field_16, table_update_interval_slow_rate: ((lzham_lzcompressor*)@this)->field_1.m_table_update_interval_slow_rate, lzbase: @this, table_max_update_interval: ((lzham_lzcompressor*)@this)->field_1.m_table_max_update_interval);
			if (ExceptionInfo.Current != null)
			{
				return false;
			}
			if (!flag2)
			{
				return false;
			}
			bool flag3 = try_reserve_cnc229.Invoke(&((lzham_lzcompressor*)@this)->field_8, ((lzham_lzcompressor*)@this)->field_1.m_block_size);
			if (ExceptionInfo.Current != null)
			{
				return false;
			}
			if (!flag3)
			{
				return false;
			}
			bool flag4 = try_reserve_cnc229.Invoke(&((lzham_lzcompressor*)@this)->field_9, ((lzham_lzcompressor*)@this)->field_1.m_block_size * 2);
			if (ExceptionInfo.Current != null)
			{
				return false;
			}
			if (!flag4)
			{
				return false;
			}
			for (int i = 0; (uint)i < (uint)((lzham_lzcompressor*)@this)->field_17; i++)
			{
				bool flag5 = init_meqzb7.Invoke(&((lzham_lzcompressor_raw_parse_thread_state*)((byte*)(&((lzham_lzcompressor*)@this)->field_18) + (nint)(uint)i * (nint)sizeof(lzham_lzcompressor_parse_thread_state)))->m_initial_state, table_update_interval_slow_rate: ((lzham_lzcompressor*)@this)->field_1.m_table_update_interval_slow_rate, lzbase: @this, table_max_update_interval: ((lzham_lzcompressor*)@this)->field_1.m_table_max_update_interval);
				if (ExceptionInfo.Current != null)
				{
					return false;
				}
				if (!flag5)
				{
					return false;
				}
			}
			((lzham_lzcompressor*)@this)->field_22 = 0;
			((lzham_lzcompressor*)@this)->field_23 = 0;
			if (((lzham_lzcompressor_init_params*)@params)->m_num_seed_bytes != 0)
			{
				bool flag6 = init_seed_bytes.Invoke(@this);
				if (ExceptionInfo.Current != null)
				{
					return false;
				}
				if (!flag6)
				{
					return false;
				}
			}
			bool flag7 = send_zlib_header.Invoke(@this);
			if (ExceptionInfo.Current != null)
			{
				return false;
			}
			if (!flag7)
			{
				return false;
			}
			((lzham_lzcompressor*)@this)->field_3 = 0L;
			return true;
		}
	}
}
