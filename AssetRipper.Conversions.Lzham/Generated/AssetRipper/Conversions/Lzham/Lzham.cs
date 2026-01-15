using System;
using AssetRipper.Conversions.Lzham.GlobalFunctions;
using AssetRipper.Conversions.Lzham.GlobalVariables;
using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.InlineArrays;
using AssetRipper.Conversions.Lzham.Intrinsics.Implemented;

namespace AssetRipper.Conversions.Lzham;

public static partial class Lzham
{
	public static sbyte g_fail_exceptions
	{
		get
		{
			return AssetRipper.Conversions.Lzham.GlobalVariables.g_fail_exceptions.Value;
		}
		set
		{
			AssetRipper.Conversions.Lzham.GlobalVariables.g_fail_exceptions.Value = value;
		}
	}

	[MangledName("??_C@_0CA@KGDCMNL@?$CFs?$CI?$CFu?$CJ?3?5Assertion?5failed?3?5?$CC?$CFs?$CC?6?$AA@")]
	[DemangledName("\"%s(%u): Assertion failed: \\\"%s\\\"\\n\"")]
	[CleanName("String")]
	public static InlineArray32_SByte String_z27cvv
	{
		get
		{
			return AssetRipper.Conversions.Lzham.GlobalVariables.String_z27cvv.Value;
		}
		set
		{
			AssetRipper.Conversions.Lzham.GlobalVariables.String_z27cvv.Value = value;
		}
	}

	[MangledName("??_C@_02DKCKIIND@?$CFs?$AA@")]
	[DemangledName("\"%s\"")]
	[CleanName("String")]
	public static InlineArray3_SByte String_289y69
	{
		get
		{
			return AssetRipper.Conversions.Lzham.GlobalVariables.String_289y69.Value;
		}
		set
		{
			AssetRipper.Conversions.Lzham.GlobalVariables.String_289y69.Value = value;
		}
	}

	[MangledName("??_C@_0BH@KMOOLNCP@?$CFs?$CI?$CFu?$CJ?3?5Failure?3?5?$CC?$CFs?$CC?6?$AA@")]
	[DemangledName("\"%s(%u): Failure: \\\"%s\\\"\\n\"")]
	[CleanName("String")]
	public static InlineArray23_SByte String_ww2gga
	{
		get
		{
			return AssetRipper.Conversions.Lzham.GlobalVariables.String_ww2gga.Value;
		}
		set
		{
			AssetRipper.Conversions.Lzham.GlobalVariables.String_ww2gga.Value = value;
		}
	}

	public static sbyte g_exit_on_failure
	{
		get
		{
			return AssetRipper.Conversions.Lzham.GlobalVariables.g_exit_on_failure.Value;
		}
		set
		{
			AssetRipper.Conversions.Lzham.GlobalVariables.g_exit_on_failure.Value = value;
		}
	}

	[MangledName("?s_crc32@lzham@@3QBIB")]
	[DemangledName("unsigned int const *const lzham::s_crc32")]
	public static InlineArray16_Int32 s_crc32
	{
		get
		{
			return AssetRipper.Conversions.Lzham.GlobalVariables.s_crc32.Value;
		}
		set
		{
			AssetRipper.Conversions.Lzham.GlobalVariables.s_crc32.Value = value;
		}
	}

	[MangledName("?g_num_lzx_position_slots@lzham@@3QBEB")]
	[DemangledName("unsigned char const *const lzham::g_num_lzx_position_slots")]
	public static InlineArray15_SByte g_num_lzx_position_slots
	{
		get
		{
			return AssetRipper.Conversions.Lzham.GlobalVariables.g_num_lzx_position_slots.Value;
		}
		set
		{
			AssetRipper.Conversions.Lzham.GlobalVariables.g_num_lzx_position_slots.Value = value;
		}
	}

	[MangledName("?s_error_descs@?1??lzham_lib_z_error@lzham@@YAPEBDH@Z@4PAU<unnamed-type-s_error_descs>@?1??12@YAPEBDH@Z@A")]
	[DemangledName("struct `char const * __cdecl lzham::lzham_lib_z_error(int)'::`2'::<unnamed-type-s_error_descs> *`char const * __cdecl lzham::lzham_lib_z_error(int)'::`2'::s_error_descs")]
	public static InlineArray10_anon s_error_descs
	{
		get
		{
			return AssetRipper.Conversions.Lzham.GlobalVariables.s_error_descs.Value;
		}
		set
		{
			AssetRipper.Conversions.Lzham.GlobalVariables.s_error_descs.Value = value;
		}
	}

	[MangledName("??_C@_00CNPNBAHC@?$AA@")]
	[DemangledName("\"\"")]
	[CleanName("String")]
	public static InlineArray1_SByte String_xaiud2
	{
		get
		{
			return AssetRipper.Conversions.Lzham.GlobalVariables.String_xaiud2.Value;
		}
		set
		{
			AssetRipper.Conversions.Lzham.GlobalVariables.String_xaiud2.Value = value;
		}
	}

	[MangledName("??_C@_0L@FNAOCBOG@stream?5end?$AA@")]
	[DemangledName("\"stream end\"")]
	[CleanName("String")]
	public static InlineArray11_SByte String_hn7j2s
	{
		get
		{
			return AssetRipper.Conversions.Lzham.GlobalVariables.String_hn7j2s.Value;
		}
		set
		{
			AssetRipper.Conversions.Lzham.GlobalVariables.String_hn7j2s.Value = value;
		}
	}

	[MangledName("??_C@_0BA@MOKMMFOD@need?5dictionary?$AA@")]
	[DemangledName("\"need dictionary\"")]
	[CleanName("String")]
	public static InlineArray16_SByte String_a27e9k
	{
		get
		{
			return AssetRipper.Conversions.Lzham.GlobalVariables.String_a27e9k.Value;
		}
		set
		{
			AssetRipper.Conversions.Lzham.GlobalVariables.String_a27e9k.Value = value;
		}
	}

	[MangledName("??_C@_0L@KIJFAKBJ@file?5error?$AA@")]
	[DemangledName("\"file error\"")]
	[CleanName("String")]
	public static InlineArray11_SByte String_87eb53
	{
		get
		{
			return AssetRipper.Conversions.Lzham.GlobalVariables.String_87eb53.Value;
		}
		set
		{
			AssetRipper.Conversions.Lzham.GlobalVariables.String_87eb53.Value = value;
		}
	}

	[MangledName("??_C@_0N@MKKNPMJD@stream?5error?$AA@")]
	[DemangledName("\"stream error\"")]
	[CleanName("String")]
	public static InlineArray13_SByte String_2bxz4p
	{
		get
		{
			return AssetRipper.Conversions.Lzham.GlobalVariables.String_2bxz4p.Value;
		}
		set
		{
			AssetRipper.Conversions.Lzham.GlobalVariables.String_2bxz4p.Value = value;
		}
	}

	[MangledName("??_C@_0L@HAHMBNLP@data?5error?$AA@")]
	[DemangledName("\"data error\"")]
	[CleanName("String")]
	public static InlineArray11_SByte String_huh5mb
	{
		get
		{
			return AssetRipper.Conversions.Lzham.GlobalVariables.String_huh5mb.Value;
		}
		set
		{
			AssetRipper.Conversions.Lzham.GlobalVariables.String_huh5mb.Value = value;
		}
	}

	[MangledName("??_C@_0O@BNNCBLEN@out?5of?5memory?$AA@")]
	[DemangledName("\"out of memory\"")]
	[CleanName("String")]
	public static InlineArray14_SByte String_38ab2g
	{
		get
		{
			return AssetRipper.Conversions.Lzham.GlobalVariables.String_38ab2g.Value;
		}
		set
		{
			AssetRipper.Conversions.Lzham.GlobalVariables.String_38ab2g.Value = value;
		}
	}

	[MangledName("??_C@_09OOPFIHMG@buf?5error?$AA@")]
	[DemangledName("\"buf error\"")]
	[CleanName("String")]
	public static InlineArray10_SByte String_3w2xpy
	{
		get
		{
			return AssetRipper.Conversions.Lzham.GlobalVariables.String_3w2xpy.Value;
		}
		set
		{
			AssetRipper.Conversions.Lzham.GlobalVariables.String_3w2xpy.Value = value;
		}
	}

	[MangledName("??_C@_0O@GAOPAEPN@version?5error?$AA@")]
	[DemangledName("\"version error\"")]
	[CleanName("String")]
	public static InlineArray14_SByte String_ba25s9
	{
		get
		{
			return AssetRipper.Conversions.Lzham.GlobalVariables.String_ba25s9.Value;
		}
		set
		{
			AssetRipper.Conversions.Lzham.GlobalVariables.String_ba25s9.Value = value;
		}
	}

	[MangledName("??_C@_0BA@PEPMCGFH@parameter?5error?$AA@")]
	[DemangledName("\"parameter error\"")]
	[CleanName("String")]
	public static InlineArray16_SByte String_zybzvv
	{
		get
		{
			return AssetRipper.Conversions.Lzham.GlobalVariables.String_zybzvv.Value;
		}
		set
		{
			AssetRipper.Conversions.Lzham.GlobalVariables.String_zybzvv.Value = value;
		}
	}

	[MangledName("?s_literal_next_state@lzham@@3QBEB")]
	[DemangledName("unsigned char const *const lzham::s_literal_next_state")]
	public static InlineArray24_SByte s_literal_next_state
	{
		get
		{
			return AssetRipper.Conversions.Lzham.GlobalVariables.s_literal_next_state.Value;
		}
		set
		{
			AssetRipper.Conversions.Lzham.GlobalVariables.s_literal_next_state.Value = value;
		}
	}

	[MangledName("?s_huge_match_code_len@lzham@@3QBEB")]
	[DemangledName("unsigned char const *const lzham::s_huge_match_code_len")]
	public static InlineArray4_SByte s_huge_match_code_len
	{
		get
		{
			return AssetRipper.Conversions.Lzham.GlobalVariables.s_huge_match_code_len.Value;
		}
		set
		{
			AssetRipper.Conversions.Lzham.GlobalVariables.s_huge_match_code_len.Value = value;
		}
	}

	[MangledName("?s_huge_match_base_len@lzham@@3QBIB")]
	[DemangledName("unsigned int const *const lzham::s_huge_match_base_len")]
	public static InlineArray4_Int32 s_huge_match_base_len
	{
		get
		{
			return AssetRipper.Conversions.Lzham.GlobalVariables.s_huge_match_base_len.Value;
		}
		set
		{
			AssetRipper.Conversions.Lzham.GlobalVariables.s_huge_match_base_len.Value = value;
		}
	}

	[MangledName("??_C@_0BL@BMCEKBHI@lzham_malloc?3?5size?5too?5big?$AA@")]
	[DemangledName("\"lzham_malloc: size too big\"")]
	[CleanName("String")]
	public static InlineArray27_SByte String_z2inc6
	{
		get
		{
			return AssetRipper.Conversions.Lzham.GlobalVariables.String_z2inc6.Value;
		}
		set
		{
			AssetRipper.Conversions.Lzham.GlobalVariables.String_z2inc6.Value = value;
		}
	}

	[MangledName("?g_pRealloc@lzham@@3P6APEAXPEAX_KPEA_KI0@ZEA")]
	[DemangledName("void * (__cdecl *lzham::g_pRealloc)(void *, unsigned __int64, unsigned __int64 *, unsigned int, void *)")]
	public unsafe static void* g_pRealloc
	{
		get
		{
			return AssetRipper.Conversions.Lzham.GlobalVariables.g_pRealloc.Value;
		}
		set
		{
			AssetRipper.Conversions.Lzham.GlobalVariables.g_pRealloc.Value = value;
		}
	}

	[MangledName("?g_pUser_data@lzham@@3PEAXEA")]
	[DemangledName("void *lzham::g_pUser_data")]
	public unsafe static void* g_pUser_data
	{
		get
		{
			return AssetRipper.Conversions.Lzham.GlobalVariables.g_pUser_data.Value;
		}
		set
		{
			AssetRipper.Conversions.Lzham.GlobalVariables.g_pUser_data.Value = value;
		}
	}

	[MangledName("??_C@_0BM@OEANAODI@lzham_malloc?3?5out?5of?5memory?$AA@")]
	[DemangledName("\"lzham_malloc: out of memory\"")]
	[CleanName("String")]
	public static InlineArray28_SByte String_tzftys
	{
		get
		{
			return AssetRipper.Conversions.Lzham.GlobalVariables.String_tzftys.Value;
		}
		set
		{
			AssetRipper.Conversions.Lzham.GlobalVariables.String_tzftys.Value = value;
		}
	}

	[MangledName("??_C@_0BH@FIGPJHFC@lzham_realloc?3?5bad?5ptr?$AA@")]
	[DemangledName("\"lzham_realloc: bad ptr\"")]
	[CleanName("String")]
	public static InlineArray23_SByte String_b3sjk2
	{
		get
		{
			return AssetRipper.Conversions.Lzham.GlobalVariables.String_b3sjk2.Value;
		}
		set
		{
			AssetRipper.Conversions.Lzham.GlobalVariables.String_b3sjk2.Value = value;
		}
	}

	[MangledName("??_C@_0BE@ONIAEEHN@lzham_free?3?5bad?5ptr?$AA@")]
	[DemangledName("\"lzham_free: bad ptr\"")]
	[CleanName("String")]
	public static InlineArray20_SByte String_6jy8jt
	{
		get
		{
			return AssetRipper.Conversions.Lzham.GlobalVariables.String_6jy8jt.Value;
		}
		set
		{
			AssetRipper.Conversions.Lzham.GlobalVariables.String_6jy8jt.Value = value;
		}
	}

	[MangledName("??_C@_0BF@EELBENBN@lzham_msize?3?5bad?5ptr?$AA@")]
	[DemangledName("\"lzham_msize: bad ptr\"")]
	[CleanName("String")]
	public static InlineArray21_SByte String_xzs3ub
	{
		get
		{
			return AssetRipper.Conversions.Lzham.GlobalVariables.String_xzs3ub.Value;
		}
		set
		{
			AssetRipper.Conversions.Lzham.GlobalVariables.String_xzs3ub.Value = value;
		}
	}

	[MangledName("?g_pMSize@lzham@@3P6A_KPEAX0@ZEA")]
	[DemangledName("unsigned __int64 (__cdecl *lzham::g_pMSize)(void *, void *)")]
	public unsafe static void* g_pMSize
	{
		get
		{
			return AssetRipper.Conversions.Lzham.GlobalVariables.g_pMSize.Value;
		}
		set
		{
			AssetRipper.Conversions.Lzham.GlobalVariables.g_pMSize.Value = value;
		}
	}

	[MangledName("??_C@_0EK@FDCIOCFI@E?3?2repos?2AssetRipper?4Conversions@")]
	[DemangledName("\"E:\\\\repos\\\\AssetRipper.Conversions\"...")]
	[CleanName("String")]
	public static InlineArray74_SByte String_pfb5rd
	{
		get
		{
			return AssetRipper.Conversions.Lzham.GlobalVariables.String_pfb5rd.Value;
		}
		set
		{
			AssetRipper.Conversions.Lzham.GlobalVariables.String_pfb5rd.Value = value;
		}
	}

	[MangledName("??_C@_0FD@BCCONNPJ@E?3?2repos?2AssetRipper?4Conversions@")]
	[DemangledName("\"E:\\\\repos\\\\AssetRipper.Conversions\"...")]
	[CleanName("String")]
	public static InlineArray83_SByte String_ednjr4
	{
		get
		{
			return AssetRipper.Conversions.Lzham.GlobalVariables.String_ednjr4.Value;
		}
		set
		{
			AssetRipper.Conversions.Lzham.GlobalVariables.String_ednjr4.Value = value;
		}
	}

	[MangledName("??_C@_0BC@GGLBIONJ@bit?5?$DN?$DN?5sym?4m_bits?$AA@")]
	[DemangledName("\"bit == sym.m_bits\"")]
	[CleanName("String")]
	public static InlineArray18_SByte String_7hba9n
	{
		get
		{
			return AssetRipper.Conversions.Lzham.GlobalVariables.String_7hba9n.Value;
		}
		set
		{
			AssetRipper.Conversions.Lzham.GlobalVariables.String_7hba9n.Value = value;
		}
	}

	[MangledName("??_C@_0EL@BCKDLKNL@E?3?2repos?2AssetRipper?4Conversions@")]
	[DemangledName("\"E:\\\\repos\\\\AssetRipper.Conversions\"...")]
	[CleanName("String")]
	public static InlineArray75_SByte String_cn9etx
	{
		get
		{
			return AssetRipper.Conversions.Lzham.GlobalVariables.String_cn9etx.Value;
		}
		set
		{
			AssetRipper.Conversions.Lzham.GlobalVariables.String_cn9etx.Value = value;
		}
	}

	[MangledName("??_C@_0CK@CBMIELDM@?$CClzham?3?3vector?5operator?$DN?3?5Out?5of@")]
	[DemangledName("\"\\\"lzham::vector operator=: Out of\"...")]
	[CleanName("String")]
	public static InlineArray42_SByte String_e4f6vd
	{
		get
		{
			return AssetRipper.Conversions.Lzham.GlobalVariables.String_e4f6vd.Value;
		}
		set
		{
			AssetRipper.Conversions.Lzham.GlobalVariables.String_e4f6vd.Value = value;
		}
	}

	[MangledName("?g_init_ticks@lzham_timer@lzham@@0_KA")]
	[DemangledName("private: static unsigned __int64 lzham::lzham_timer::g_init_ticks")]
	public static long g_init_ticks
	{
		get
		{
			return AssetRipper.Conversions.Lzham.GlobalVariables.g_init_ticks.Value;
		}
		set
		{
			AssetRipper.Conversions.Lzham.GlobalVariables.g_init_ticks.Value = value;
		}
	}

	[MangledName("?g_freq@lzham_timer@lzham@@0_KA")]
	[DemangledName("private: static unsigned __int64 lzham::lzham_timer::g_freq")]
	public static long g_freq
	{
		get
		{
			return AssetRipper.Conversions.Lzham.GlobalVariables.g_freq.Value;
		}
		set
		{
			AssetRipper.Conversions.Lzham.GlobalVariables.g_freq.Value = value;
		}
	}

	[MangledName("?g_inv_freq@lzham_timer@lzham@@0NA")]
	[DemangledName("private: static double lzham::lzham_timer::g_inv_freq")]
	public static double g_inv_freq
	{
		get
		{
			return AssetRipper.Conversions.Lzham.GlobalVariables.g_inv_freq.Value;
		}
		set
		{
			AssetRipper.Conversions.Lzham.GlobalVariables.g_inv_freq.Value = value;
		}
	}

	[MangledName("??_C@_0DD@NINNDDPA@vector?3?5lzham_realloc?$CI?$CJ?5failed?5a@")]
	[DemangledName("\"vector: lzham_realloc() failed a\"...")]
	[CleanName("String")]
	public static InlineArray51_SByte String_c93t5e
	{
		get
		{
			return AssetRipper.Conversions.Lzham.GlobalVariables.String_c93t5e.Value;
		}
		set
		{
			AssetRipper.Conversions.Lzham.GlobalVariables.String_c93t5e.Value = value;
		}
	}

	[MangledName("??_C@_0EN@OFLHMCEC@E?3?2repos?2AssetRipper?4Conversions@")]
	[DemangledName("\"E:\\\\repos\\\\AssetRipper.Conversions\"...")]
	[CleanName("String")]
	public static InlineArray77_SByte String_qv32gu
	{
		get
		{
			return AssetRipper.Conversions.Lzham.GlobalVariables.String_qv32gu.Value;
		}
		set
		{
			AssetRipper.Conversions.Lzham.GlobalVariables.String_qv32gu.Value = value;
		}
	}

	[MangledName("??_C@_03COAJHJPB@buf?$AA@")]
	[DemangledName("\"buf\"")]
	[CleanName("String")]
	public static InlineArray4_SByte String_xra7zt
	{
		get
		{
			return AssetRipper.Conversions.Lzham.GlobalVariables.String_xra7zt.Value;
		}
		set
		{
			AssetRipper.Conversions.Lzham.GlobalVariables.String_xra7zt.Value = value;
		}
	}

	[MangledName("??_C@_0DC@GCIBAKNN@vector?3?5lzham_malloc?$CI?$CJ?5failed?5al@")]
	[DemangledName("\"vector: lzham_malloc() failed al\"...")]
	[CleanName("String")]
	public static InlineArray50_SByte String_d6e2vj
	{
		get
		{
			return AssetRipper.Conversions.Lzham.GlobalVariables.String_d6e2vj.Value;
		}
		set
		{
			AssetRipper.Conversions.Lzham.GlobalVariables.String_d6e2vj.Value = value;
		}
	}

	[MangledName("?g_table_update_settings@lzham@@3PAUtable_update_settings@1@A")]
	[DemangledName("struct lzham::table_update_settings *lzham::g_table_update_settings")]
	public static InlineArray20_lzham_table_update_settings g_table_update_settings
	{
		get
		{
			return AssetRipper.Conversions.Lzham.GlobalVariables.g_table_update_settings.Value;
		}
		set
		{
			AssetRipper.Conversions.Lzham.GlobalVariables.g_table_update_settings.Value = value;
		}
	}

	[MangledName("??_C@_0FE@GFOAKDAL@E?3?2repos?2AssetRipper?4Conversions@")]
	[DemangledName("\"E:\\\\repos\\\\AssetRipper.Conversions\"...")]
	[CleanName("String")]
	public static InlineArray84_SByte String_uf3mm8
	{
		get
		{
			return AssetRipper.Conversions.Lzham.GlobalVariables.String_uf3mm8.Value;
		}
		set
		{
			AssetRipper.Conversions.Lzham.GlobalVariables.String_uf3mm8.Value = value;
		}
	}

	[MangledName("??_C@_0EC@GMMOIKFK@?$CI?$CIuint32_ptr?$CJthis?5?$CG?5?$CILZHAM_GET_A@")]
	[DemangledName("\"((uint32_ptr)this & (LZHAM_GET_A\"...")]
	[CleanName("String")]
	public static InlineArray66_SByte String_eyp45t
	{
		get
		{
			return AssetRipper.Conversions.Lzham.GlobalVariables.String_eyp45t.Value;
		}
		set
		{
			AssetRipper.Conversions.Lzham.GlobalVariables.String_eyp45t.Value = value;
		}
	}

	[MangledName("?s_level_settings@lzham@@3PAUcomp_settings@1@A")]
	[DemangledName("struct lzham::comp_settings *lzham::s_level_settings")]
	public static InlineArray5_lzham_comp_settings s_level_settings
	{
		get
		{
			return AssetRipper.Conversions.Lzham.GlobalVariables.s_level_settings.Value;
		}
		set
		{
			AssetRipper.Conversions.Lzham.GlobalVariables.s_level_settings.Value = value;
		}
	}

	[MangledName("??_C@_0BG@CFFFDGMP@parse_job_callback?5?$CFu?$AA@")]
	[DemangledName("\"parse_job_callback %u\"")]
	[CleanName("String")]
	public static InlineArray22_SByte String_kkiyv4
	{
		get
		{
			return AssetRipper.Conversions.Lzham.GlobalVariables.String_kkiyv4.Value;
		}
		set
		{
			AssetRipper.Conversions.Lzham.GlobalVariables.String_kkiyv4.Value = value;
		}
	}

	[MangledName("??_C@_0BJ@OMLMDDJC@?$CK?$CK?$CK?$CK?$CK?$CK?5compress_block?5?$CFu?$AA@")]
	[DemangledName("\"****** compress_block %u\"")]
	[CleanName("String")]
	public static InlineArray25_SByte String_2p8789
	{
		get
		{
			return AssetRipper.Conversions.Lzham.GlobalVariables.String_2p8789.Value;
		}
		set
		{
			AssetRipper.Conversions.Lzham.GlobalVariables.String_2p8789.Value = value;
		}
	}

	[MangledName("??_C@_07MNAPGDEB@parsing?$AA@")]
	[DemangledName("\"parsing\"")]
	[CleanName("String")]
	public static InlineArray8_SByte String_q343bu
	{
		get
		{
			return AssetRipper.Conversions.Lzham.GlobalVariables.String_q343bu.Value;
		}
		set
		{
			AssetRipper.Conversions.Lzham.GlobalVariables.String_q343bu.Value = value;
		}
	}

	[MangledName("??_C@_0BE@EKDGPGEN@queuing?5parse?5tasks?$AA@")]
	[DemangledName("\"queuing parse tasks\"")]
	[CleanName("String")]
	public static InlineArray20_SByte String_xvmi6j
	{
		get
		{
			return AssetRipper.Conversions.Lzham.GlobalVariables.String_xvmi6j.Value;
		}
		set
		{
			AssetRipper.Conversions.Lzham.GlobalVariables.String_xvmi6j.Value = value;
		}
	}

	[MangledName("??_C@_0BB@PJEIBCLK@waiting?5for?5jobs?$AA@")]
	[DemangledName("\"waiting for jobs\"")]
	[CleanName("String")]
	public static InlineArray17_SByte String_2t6uyd
	{
		get
		{
			return AssetRipper.Conversions.Lzham.GlobalVariables.String_2t6uyd.Value;
		}
		set
		{
			AssetRipper.Conversions.Lzham.GlobalVariables.String_2t6uyd.Value = value;
		}
	}

	[MangledName("??_C@_06GDAGLJDI@coding?$AA@")]
	[DemangledName("\"coding\"")]
	[CleanName("String")]
	public static InlineArray7_SByte String_7dyiyi
	{
		get
		{
			return AssetRipper.Conversions.Lzham.GlobalVariables.String_7dyiyi.Value;
		}
		set
		{
			AssetRipper.Conversions.Lzham.GlobalVariables.String_7dyiyi.Value = value;
		}
	}

	[MangledName("??_C@_0O@DBJNBDBM@add_bytes_end?$AA@")]
	[DemangledName("\"add_bytes_end\"")]
	[CleanName("String")]
	public static InlineArray14_SByte String_dmyz8f
	{
		get
		{
			return AssetRipper.Conversions.Lzham.GlobalVariables.String_dmyz8f.Value;
		}
		set
		{
			AssetRipper.Conversions.Lzham.GlobalVariables.String_dmyz8f.Value = value;
		}
	}

	[MangledName("??_C@_0O@PMPMJFCA@stop_encoding?$AA@")]
	[DemangledName("\"stop_encoding\"")]
	[CleanName("String")]
	public static InlineArray14_SByte String_siua9a
	{
		get
		{
			return AssetRipper.Conversions.Lzham.GlobalVariables.String_siua9a.Value;
		}
		set
		{
			AssetRipper.Conversions.Lzham.GlobalVariables.String_siua9a.Value = value;
		}
	}

	[MangledName("??_C@_06PCICMFGG@append?$AA@")]
	[DemangledName("\"append\"")]
	[CleanName("String")]
	public static InlineArray7_SByte String_9pse5k
	{
		get
		{
			return AssetRipper.Conversions.Lzham.GlobalVariables.String_9pse5k.Value;
		}
		set
		{
			AssetRipper.Conversions.Lzham.GlobalVariables.String_9pse5k.Value = value;
		}
	}

	[MangledName("?m_lzx_position_extra_bits@CLZDecompBase@lzham@@2PAEA")]
	[DemangledName("public: static unsigned char *lzham::CLZDecompBase::m_lzx_position_extra_bits")]
	public static InlineArray128_SByte m_lzx_position_extra_bits
	{
		get
		{
			return AssetRipper.Conversions.Lzham.GlobalVariables.m_lzx_position_extra_bits.Value;
		}
		set
		{
			AssetRipper.Conversions.Lzham.GlobalVariables.m_lzx_position_extra_bits.Value = value;
		}
	}

	[MangledName("??_C@_0FI@NLFGLEGK@?5?5pos?3?5?$CFu?0?5state?3?5?$CFu?0?5match_pred@")]
	[DemangledName("\"  pos: %u, state: %u, match_pred\"...")]
	[CleanName("String")]
	public static InlineArray88_SByte String_h288ig
	{
		get
		{
			return AssetRipper.Conversions.Lzham.GlobalVariables.String_h288ig.Value;
		}
		set
		{
			AssetRipper.Conversions.Lzham.GlobalVariables.String_h288ig.Value = value;
		}
	}

	[MangledName("??_C@_0BJ@OODKALFN@?9?9?9Regular?5lit?3?5?$CFu?5?8?$CFc?8?6?$AA@")]
	[DemangledName("\"---Regular lit: %u \\'%c\\'\\n\"")]
	[CleanName("String")]
	public static InlineArray25_SByte String_fadq34
	{
		get
		{
			return AssetRipper.Conversions.Lzham.GlobalVariables.String_fadq34.Value;
		}
		set
		{
			AssetRipper.Conversions.Lzham.GlobalVariables.String_fadq34.Value = value;
		}
	}

	[MangledName("??_C@_0DJ@OJLKDIAB@?$CK?$CK?$CKDelta?5lit?3?5?$CFu?5?8?$CFc?8?0?5Mismatch?3@")]
	[DemangledName("\"***Delta lit: %u \\'%c\\', Mismatch:\"...")]
	[CleanName("String")]
	public static InlineArray57_SByte String_eiv9zx
	{
		get
		{
			return AssetRipper.Conversions.Lzham.GlobalVariables.String_eiv9zx.Value;
		}
		set
		{
			AssetRipper.Conversions.Lzham.GlobalVariables.String_eiv9zx.Value = value;
		}
	}

	[MangledName("??_C@_0P@MCMBFBIC@?$CB?$CB?$CBRep?50?5len1?6?$AA@")]
	[DemangledName("\"!!!Rep 0 len1\\n\"")]
	[CleanName("String")]
	public static InlineArray15_SByte String_s9ddh6
	{
		get
		{
			return AssetRipper.Conversions.Lzham.GlobalVariables.String_s9ddh6.Value;
		}
		set
		{
			AssetRipper.Conversions.Lzham.GlobalVariables.String_s9ddh6.Value = value;
		}
	}

	[MangledName("??_C@_0BG@HHLIHKBE@?$CB?$CB?$CBRep?50?5full?5len?5?$CFu?6?$AA@")]
	[DemangledName("\"!!!Rep 0 full len %u\\n\"")]
	[CleanName("String")]
	public static InlineArray22_SByte String_3ut65i
	{
		get
		{
			return AssetRipper.Conversions.Lzham.GlobalVariables.String_3ut65i.Value;
		}
		set
		{
			AssetRipper.Conversions.Lzham.GlobalVariables.String_3ut65i.Value = value;
		}
	}

	[MangledName("??_C@_0BH@CIFPAAMN@?$CB?$CB?$CBRep?5?$CFu?5full?5len?5?$CFu?6?$AA@")]
	[DemangledName("\"!!!Rep %u full len %u\\n\"")]
	[CleanName("String")]
	public static InlineArray23_SByte String_sitzh3
	{
		get
		{
			return AssetRipper.Conversions.Lzham.GlobalVariables.String_sitzh3.Value;
		}
		set
		{
			AssetRipper.Conversions.Lzham.GlobalVariables.String_sitzh3.Value = value;
		}
	}

	[MangledName("??_C@_0DF@FLAGJPAA@?$FO?$FO?$FOFull?5match?5Len?5?$CFu?5Dist?5?$CFu?0?5Sl@")]
	[DemangledName("\"^^^Full match Len %u Dist %u, Sl\"...")]
	[CleanName("String")]
	public static InlineArray53_SByte String_486qas
	{
		get
		{
			return AssetRipper.Conversions.Lzham.GlobalVariables.String_486qas.Value;
		}
		set
		{
			AssetRipper.Conversions.Lzham.GlobalVariables.String_486qas.Value = value;
		}
	}

	[MangledName("??_C@_0BK@NBKBNKJK@?5?5?$CILow?54?5bits?3?5?$CFu?5vs?4?5?$CFu?$CJ?$AA@")]
	[DemangledName("\"  (Low 4 bits: %u vs. %u)\"")]
	[CleanName("String")]
	public static InlineArray26_SByte String_2kd87d
	{
		get
		{
			return AssetRipper.Conversions.Lzham.GlobalVariables.String_2kd87d.Value;
		}
		set
		{
			AssetRipper.Conversions.Lzham.GlobalVariables.String_2kd87d.Value = value;
		}
	}

	[MangledName("??_C@_01EEMJAFIK@?6?$AA@")]
	[DemangledName("\"\\n\"")]
	[CleanName("String")]
	public static InlineArray2_SByte String_69wyxh
	{
		get
		{
			return AssetRipper.Conversions.Lzham.GlobalVariables.String_69wyxh.Value;
		}
		set
		{
			AssetRipper.Conversions.Lzham.GlobalVariables.String_69wyxh.Value = value;
		}
	}

	[MangledName("??_C@_0DG@CNCJKPMO@?5?5TRUNCATED?5match?0?5actual?5len?5is@")]
	[DemangledName("\"  TRUNCATED match, actual len is\"...")]
	[CleanName("String")]
	public static InlineArray54_SByte String_4d3wsk
	{
		get
		{
			return AssetRipper.Conversions.Lzham.GlobalVariables.String_4d3wsk.Value;
		}
		set
		{
			AssetRipper.Conversions.Lzham.GlobalVariables.String_4d3wsk.Value = value;
		}
	}

	[MangledName("??_C@_0N@NAAKPPPI@?9?9?9?9?9?9?9?9?9?9?9?6?$AA@")]
	[DemangledName("\"-----------\\n\"")]
	[CleanName("String")]
	public static InlineArray13_SByte String_npt3bn
	{
		get
		{
			return AssetRipper.Conversions.Lzham.GlobalVariables.String_npt3bn.Value;
		}
		set
		{
			AssetRipper.Conversions.Lzham.GlobalVariables.String_npt3bn.Value = value;
		}
	}

	[MangledName("??_C@_0BE@GOICEHAK@Coding?5statistics?3?6?$AA@")]
	[DemangledName("\"Coding statistics:\\n\"")]
	[CleanName("String")]
	public static InlineArray20_SByte String_rx79g7
	{
		get
		{
			return AssetRipper.Conversions.Lzham.GlobalVariables.String_rx79g7.Value;
		}
		set
		{
			AssetRipper.Conversions.Lzham.GlobalVariables.String_rx79g7.Value = value;
		}
	}

	[MangledName("??_C@_0BO@FGCFGCKN@Total?5update?5rate?5resets?3?5?$CFu?6?$AA@")]
	[DemangledName("\"Total update rate resets: %u\\n\"")]
	[CleanName("String")]
	public static InlineArray30_SByte String_yv8y8d
	{
		get
		{
			return AssetRipper.Conversions.Lzham.GlobalVariables.String_yv8y8d.Value;
		}
		set
		{
			AssetRipper.Conversions.Lzham.GlobalVariables.String_yv8y8d.Value = value;
		}
	}

	[MangledName("??_C@_0HF@GNPNOCHO@Total?5Bytes?3?5?$CFu?0?5Total?5Contexts?3@")]
	[DemangledName("\"Total Bytes: %u, Total Contexts:\"...")]
	[CleanName("String")]
	public static InlineArray117_SByte String_f4ahxf
	{
		get
		{
			return AssetRipper.Conversions.Lzham.GlobalVariables.String_f4ahxf.Value;
		}
		set
		{
			AssetRipper.Conversions.Lzham.GlobalVariables.String_f4ahxf.Value = value;
		}
	}

	[MangledName("??_C@_0BL@CPKIOCOB@Ave?5bytes?5per?5context?3?5?$CFf?6?$AA@")]
	[DemangledName("\"Ave bytes per context: %f\\n\"")]
	[CleanName("String")]
	public static InlineArray27_SByte String_vudj64
	{
		get
		{
			return AssetRipper.Conversions.Lzham.GlobalVariables.String_vudj64.Value;
		}
		set
		{
			AssetRipper.Conversions.Lzham.GlobalVariables.String_vudj64.Value = value;
		}
	}

	[MangledName("??_C@_09ELANMBPE@IsMatch?3?6?$AA@")]
	[DemangledName("\"IsMatch:\\n\"")]
	[CleanName("String")]
	public static InlineArray10_SByte String_timpwh
	{
		get
		{
			return AssetRipper.Conversions.Lzham.GlobalVariables.String_timpwh.Value;
		}
		set
		{
			AssetRipper.Conversions.Lzham.GlobalVariables.String_timpwh.Value = value;
		}
	}

	[MangledName("??_C@_0EB@FPFLEMCG@?5?5Total?3?5?$CFu?0?5Cost?3?5?$CFf?5?$CI?$CFf?5bytes?$CJ@")]
	[DemangledName("\"  Total: %u, Cost: %f (%f bytes)\"...")]
	[CleanName("String")]
	public static InlineArray65_SByte String_e29b4t
	{
		get
		{
			return AssetRipper.Conversions.Lzham.GlobalVariables.String_e29b4t.Value;
		}
		set
		{
			AssetRipper.Conversions.Lzham.GlobalVariables.String_e29b4t.Value = value;
		}
	}

	[MangledName("??_C@_0DG@BGAJCJLF@?5?5IsMatch?$CI0?$CJ?3?5?$CFu?0?5Cost?3?5?$CFf?5?$CI?$CFf?5b@")]
	[DemangledName("\"  IsMatch(0): %u, Cost: %f (%f b\"...")]
	[CleanName("String")]
	public static InlineArray54_SByte String_9b8hig
	{
		get
		{
			return AssetRipper.Conversions.Lzham.GlobalVariables.String_9b8hig.Value;
		}
		set
		{
			AssetRipper.Conversions.Lzham.GlobalVariables.String_9b8hig.Value = value;
		}
	}

	[MangledName("??_C@_0DG@DMCBBBNH@?5?5IsMatch?$CI1?$CJ?3?5?$CFu?0?5Cost?3?5?$CFf?5?$CI?$CFf?5b@")]
	[DemangledName("\"  IsMatch(1): %u, Cost: %f (%f b\"...")]
	[CleanName("String")]
	public static InlineArray54_SByte String_i6ccyf
	{
		get
		{
			return AssetRipper.Conversions.Lzham.GlobalVariables.String_i6ccyf.Value;
		}
		set
		{
			AssetRipper.Conversions.Lzham.GlobalVariables.String_i6ccyf.Value = value;
		}
	}

	[MangledName("??_C@_0BA@BNBNJMM@Literal?5stats?3?6?$AA@")]
	[DemangledName("\"Literal stats:\\n\"")]
	[CleanName("String")]
	public static InlineArray16_SByte String_xa9qi5
	{
		get
		{
			return AssetRipper.Conversions.Lzham.GlobalVariables.String_xa9qi5.Value;
		}
		set
		{
			AssetRipper.Conversions.Lzham.GlobalVariables.String_xa9qi5.Value = value;
		}
	}

	[MangledName("??_C@_0EG@GPEGOPDI@?5?5Count?3?5?$CFu?0?5Cost?3?5?$CFf?5?$CI?$CFf?5bytes?$CJ@")]
	[DemangledName("\"  Count: %u, Cost: %f (%f bytes)\"...")]
	[CleanName("String")]
	public static InlineArray70_SByte String_fague4
	{
		get
		{
			return AssetRipper.Conversions.Lzham.GlobalVariables.String_fague4.Value;
		}
		set
		{
			AssetRipper.Conversions.Lzham.GlobalVariables.String_fague4.Value = value;
		}
	}

	[MangledName("??_C@_0BG@GBDHCKKG@Delta?5literal?5stats?3?6?$AA@")]
	[DemangledName("\"Delta literal stats:\\n\"")]
	[CleanName("String")]
	public static InlineArray22_SByte String_yaa426
	{
		get
		{
			return AssetRipper.Conversions.Lzham.GlobalVariables.String_yaa426.Value;
		}
		set
		{
			AssetRipper.Conversions.Lzham.GlobalVariables.String_yaa426.Value = value;
		}
	}

	[MangledName("??_C@_0BC@JPMPDMAN@Rep0?5Len1?5stats?3?6?$AA@")]
	[DemangledName("\"Rep0 Len1 stats:\\n\"")]
	[CleanName("String")]
	public static InlineArray18_SByte String_jnf25f
	{
		get
		{
			return AssetRipper.Conversions.Lzham.GlobalVariables.String_jnf25f.Value;
		}
		set
		{
			AssetRipper.Conversions.Lzham.GlobalVariables.String_jnf25f.Value = value;
		}
	}

	[MangledName("??_C@_0EM@MPOBPHMO@?5?5Count?3?5?$CFu?0?5Cost?3?5?$CFf?5?$CI?$CFf?5bytes?$CJ@")]
	[DemangledName("\"  Count: %u, Cost: %f (%f bytes)\"...")]
	[CleanName("String")]
	public static InlineArray76_SByte String_kn3w39
	{
		get
		{
			return AssetRipper.Conversions.Lzham.GlobalVariables.String_kn3w39.Value;
		}
		set
		{
			AssetRipper.Conversions.Lzham.GlobalVariables.String_kn3w39.Value = value;
		}
	}

	[MangledName("??_C@_0BD@LCHDLMCB@Rep0?5Len2?$CL?5stats?3?6?$AA@")]
	[DemangledName("\"Rep0 Len2+ stats:\\n\"")]
	[CleanName("String")]
	public static InlineArray19_SByte String_dpnkqw
	{
		get
		{
			return AssetRipper.Conversions.Lzham.GlobalVariables.String_dpnkqw.Value;
		}
		set
		{
			AssetRipper.Conversions.Lzham.GlobalVariables.String_dpnkqw.Value = value;
		}
	}

	[MangledName("??_C@_0P@JOEJHPGM@Rep?5?$CFu?5stats?3?6?$AA@")]
	[DemangledName("\"Rep %u stats:\\n\"")]
	[CleanName("String")]
	public static InlineArray15_SByte String_8n44gc
	{
		get
		{
			return AssetRipper.Conversions.Lzham.GlobalVariables.String_8n44gc.Value;
		}
		set
		{
			AssetRipper.Conversions.Lzham.GlobalVariables.String_8n44gc.Value = value;
		}
	}

	[MangledName("??_C@_0EO@EKBIAOLA@Match?5?$CFu?3?5Total?3?5?$CFu?0?5Cost?3?5?$CFf?5?$CI?$CF@")]
	[DemangledName("\"Match %u: Total: %u, Cost: %f (%\"...")]
	[CleanName("String")]
	public static InlineArray78_SByte String_cijmf9
	{
		get
		{
			return AssetRipper.Conversions.Lzham.GlobalVariables.String_cijmf9.Value;
		}
		set
		{
			AssetRipper.Conversions.Lzham.GlobalVariables.String_cijmf9.Value = value;
		}
	}

	[MangledName("??_C@_0DJ@INDGOLEJ@Total?5near?5len2?5matches?3?5?$CFu?0?5tot@")]
	[DemangledName("\"Total near len2 matches: %u, tot\"...")]
	[CleanName("String")]
	public static InlineArray57_SByte String_wgkvsw
	{
		get
		{
			return AssetRipper.Conversions.Lzham.GlobalVariables.String_wgkvsw.Value;
		}
		set
		{
			AssetRipper.Conversions.Lzham.GlobalVariables.String_wgkvsw.Value = value;
		}
	}

	[MangledName("??_C@_0CK@OOPAAHAE@Total?5matches?3?5?$CFu?0?5truncated?5mat@")]
	[DemangledName("\"Total matches: %u, truncated mat\"...")]
	[CleanName("String")]
	public static InlineArray42_SByte String_id92h6
	{
		get
		{
			return AssetRipper.Conversions.Lzham.GlobalVariables.String_id92h6.Value;
		}
		set
		{
			AssetRipper.Conversions.Lzham.GlobalVariables.String_id92h6.Value = value;
		}
	}

	[MangledName("??_C@_0CC@GKCFHBDP@Max?5full?5match?5len2?5distance?3?5?$CFu@")]
	[DemangledName("\"Max full match len2 distance: %u\"...")]
	[CleanName("String")]
	public static InlineArray34_SByte String_r7bdmb
	{
		get
		{
			return AssetRipper.Conversions.Lzham.GlobalVariables.String_r7bdmb.Value;
		}
		set
		{
			AssetRipper.Conversions.Lzham.GlobalVariables.String_r7bdmb.Value = value;
		}
	}

	[MangledName("??_C@_0FB@CDGPHCAK@E?3?2repos?2AssetRipper?4Conversions@")]
	[DemangledName("\"E:\\\\repos\\\\AssetRipper.Conversions\"...")]
	[CleanName("String")]
	public static InlineArray81_SByte String_v6uahj
	{
		get
		{
			return AssetRipper.Conversions.Lzham.GlobalVariables.String_v6uahj.Value;
		}
		set
		{
			AssetRipper.Conversions.Lzham.GlobalVariables.String_v6uahj.Value = value;
		}
	}

	[MangledName("??_C@_0BO@CHJDIDGP@match_len?5?$DM?$DN?5actual_match_len?$AA@")]
	[DemangledName("\"match_len <= actual_match_len\"")]
	[CleanName("String")]
	public static InlineArray30_SByte String_vkn2me
	{
		get
		{
			return AssetRipper.Conversions.Lzham.GlobalVariables.String_vkn2me.Value;
		}
		set
		{
			AssetRipper.Conversions.Lzham.GlobalVariables.String_vkn2me.Value = value;
		}
	}

	[MangledName("?g_prob_cost@lzham@@3PAIA")]
	[DemangledName("unsigned int *lzham::g_prob_cost")]
	public static InlineArray2048_Int32 g_prob_cost
	{
		get
		{
			return AssetRipper.Conversions.Lzham.GlobalVariables.g_prob_cost.Value;
		}
		set
		{
			AssetRipper.Conversions.Lzham.GlobalVariables.g_prob_cost.Value = value;
		}
	}

	[MangledName("?_OptionsStorage@?1??__local_stdio_printf_options@@9@4_KA")]
	[DemangledName("unsigned __int64 `extern \"C\" __local_stdio_printf_options'::`2'::_OptionsStorage")]
	public static long OptionsStorage
	{
		get
		{
			return AssetRipper.Conversions.Lzham.GlobalVariables.OptionsStorage.Value;
		}
		set
		{
			AssetRipper.Conversions.Lzham.GlobalVariables.OptionsStorage.Value = value;
		}
	}

	[MangledName("??_C@_0BK@OKLBJHCF@find_all_matches_callback?$AA@")]
	[DemangledName("\"find_all_matches_callback\"")]
	[CleanName("String")]
	public static InlineArray26_SByte String_d9apgb
	{
		get
		{
			return AssetRipper.Conversions.Lzham.GlobalVariables.String_d9apgb.Value;
		}
		set
		{
			AssetRipper.Conversions.Lzham.GlobalVariables.String_d9apgb.Value = value;
		}
	}

	[MangledName("?g_hamming_dist@lzham@@3PAEA")]
	[DemangledName("unsigned char *lzham::g_hamming_dist")]
	public static InlineArray256_SByte g_hamming_dist
	{
		get
		{
			return AssetRipper.Conversions.Lzham.GlobalVariables.g_hamming_dist.Value;
		}
		set
		{
			AssetRipper.Conversions.Lzham.GlobalVariables.g_hamming_dist.Value = value;
		}
	}

	[MangledName("?m_slot_tab0@CLZBase@lzham@@2PAEA")]
	[DemangledName("public: static unsigned char *lzham::CLZBase::m_slot_tab0")]
	public static InlineArray4096_SByte m_slot_tab0
	{
		get
		{
			return AssetRipper.Conversions.Lzham.GlobalVariables.m_slot_tab0.Value;
		}
		set
		{
			AssetRipper.Conversions.Lzham.GlobalVariables.m_slot_tab0.Value = value;
		}
	}

	[MangledName("?m_slot_tab1@CLZBase@lzham@@2PAEA")]
	[DemangledName("public: static unsigned char *lzham::CLZBase::m_slot_tab1")]
	public static InlineArray512_SByte m_slot_tab1
	{
		get
		{
			return AssetRipper.Conversions.Lzham.GlobalVariables.m_slot_tab1.Value;
		}
		set
		{
			AssetRipper.Conversions.Lzham.GlobalVariables.m_slot_tab1.Value = value;
		}
	}

	[MangledName("?m_slot_tab2@CLZBase@lzham@@2PAEA")]
	[DemangledName("public: static unsigned char *lzham::CLZBase::m_slot_tab2")]
	public static InlineArray256_SByte m_slot_tab2
	{
		get
		{
			return AssetRipper.Conversions.Lzham.GlobalVariables.m_slot_tab2.Value;
		}
		set
		{
			AssetRipper.Conversions.Lzham.GlobalVariables.m_slot_tab2.Value = value;
		}
	}

	[MangledName("?m_lzx_position_base@CLZDecompBase@lzham@@2PAIA")]
	[DemangledName("public: static unsigned int *lzham::CLZDecompBase::m_lzx_position_base")]
	public static InlineArray128_Int32 m_lzx_position_base
	{
		get
		{
			return AssetRipper.Conversions.Lzham.GlobalVariables.m_lzx_position_base.Value;
		}
		set
		{
			AssetRipper.Conversions.Lzham.GlobalVariables.m_lzx_position_base.Value = value;
		}
	}

	[MangledName("?m_lzx_position_extra_mask@CLZDecompBase@lzham@@2PAIA")]
	[DemangledName("public: static unsigned int *lzham::CLZDecompBase::m_lzx_position_extra_mask")]
	public static InlineArray128_Int32 m_lzx_position_extra_mask
	{
		get
		{
			return AssetRipper.Conversions.Lzham.GlobalVariables.m_lzx_position_extra_mask.Value;
		}
		set
		{
			AssetRipper.Conversions.Lzham.GlobalVariables.m_lzx_position_extra_mask.Value = value;
		}
	}

	[MangledName("_Avx2WmemEnabledWeakValue")]
	[DemangledName("_Avx2WmemEnabledWeakValue")]
	public static int Avx2WmemEnabledWeakValue
	{
		get
		{
			return AssetRipper.Conversions.Lzham.GlobalVariables.Avx2WmemEnabledWeakValue.Value;
		}
		set
		{
			AssetRipper.Conversions.Lzham.GlobalVariables.Avx2WmemEnabledWeakValue.Value = value;
		}
	}

	[MangledName("??_C@_06NHBNKELJ@10?48?41?$AA@")]
	[DemangledName("\"10.8.1\"")]
	[CleanName("String")]
	public static InlineArray7_SByte String_e9b4bg
	{
		get
		{
			return AssetRipper.Conversions.Lzham.GlobalVariables.String_e9b4bg.Value;
		}
		set
		{
			AssetRipper.Conversions.Lzham.GlobalVariables.String_e9b4bg.Value = value;
		}
	}

	[MangledName("?lzham_enable_fail_exceptions@@YAX_N@Z")]
	[DemangledName("void __cdecl lzham_enable_fail_exceptions(bool)")]
	[return: NativeType("void")]
	public static void lzham_enable_fail_exceptions([NativeType("bool")] bool enabled)
	{
		AssetRipper.Conversions.Lzham.GlobalFunctions.lzham_enable_fail_exceptions.Invoke(enabled);
	}

	[MangledName("?lzham_assert@@YAXPEBD0I@Z")]
	[DemangledName("void __cdecl lzham_assert(char const *, char const *, unsigned int)")]
	[return: NativeType("void")]
	public unsafe static void lzham_assert([NativeType("char const *")] void* pExp, [NativeType("char const *")] void* pFile, [NativeType("unsigned int")] int line)
	{
		AssetRipper.Conversions.Lzham.GlobalFunctions.lzham_assert.Invoke(pExp, pFile, line);
	}

	public unsafe static int sprintf_s([MangledName("_Buffer")] void* Buffer, [MangledName("_BufferCount")] long BufferCount, [MangledName("_Format")] void* Format, ReadOnlySpan<nint> args)
	{
		return AssetRipper.Conversions.Lzham.GlobalFunctions.sprintf_s.Invoke(Buffer, BufferCount, Format, args);
	}

	public unsafe static int printf([MangledName("_Format")] void* Format, ReadOnlySpan<nint> args)
	{
		return AssetRipper.Conversions.Lzham.GlobalFunctions.printf.Invoke(Format, args);
	}

	[MangledName("llvm.va_start.p0")]
	[DemangledName("llvm.va_start.p0")]
	public unsafe static void llvm_va_start_p0(void* parameter_0)
	{
		AssetRipper.Conversions.Lzham.Intrinsics.Implemented.llvm_va_start_p0.Invoke(parameter_0);
	}

	[MangledName("__acrt_iob_func")]
	[DemangledName("__acrt_iob_func")]
	public unsafe static void* acrt_iob_func(int parameter_0)
	{
		return AssetRipper.Conversions.Lzham.Intrinsics.Implemented.acrt_iob_func.Invoke(parameter_0);
	}

	[MangledName("_vfprintf_l")]
	[DemangledName("_vfprintf_l")]
	public unsafe static int vfprintf_l([MangledName("_Stream")] void* Stream, [MangledName("_Format")] void* Format, [MangledName("_Locale")] void* Locale, [MangledName("_ArgList")] void* ArgList)
	{
		return AssetRipper.Conversions.Lzham.GlobalFunctions.vfprintf_l.Invoke(Stream, Format, Locale, ArgList);
	}

	[MangledName("llvm.va_end.p0")]
	[DemangledName("llvm.va_end.p0")]
	public unsafe static void llvm_va_end_p0(void* parameter_0)
	{
		AssetRipper.Conversions.Lzham.Intrinsics.Implemented.llvm_va_end_p0.Invoke(parameter_0);
	}

	[MangledName("__local_stdio_printf_options")]
	[DemangledName("__local_stdio_printf_options")]
	public unsafe static void* local_stdio_printf_options()
	{
		return AssetRipper.Conversions.Lzham.GlobalFunctions.local_stdio_printf_options.Invoke();
	}

	[MangledName("__stdio_common_vfprintf")]
	[DemangledName("__stdio_common_vfprintf")]
	public unsafe static int stdio_common_vfprintf(long parameter_0, void* parameter_1, void* parameter_2, void* parameter_3, void* parameter_4)
	{
		return AssetRipper.Conversions.Lzham.Intrinsics.Implemented.stdio_common_vfprintf.Invoke(parameter_0, parameter_1, parameter_2, parameter_3, parameter_4);
	}

	[MangledName("_vsprintf_s_l")]
	[DemangledName("_vsprintf_s_l")]
	public unsafe static int vsprintf_s_l([MangledName("_Buffer")] void* Buffer, [MangledName("_BufferCount")] long BufferCount, [MangledName("_Format")] void* Format, [MangledName("_Locale")] void* Locale, [MangledName("_ArgList")] void* ArgList)
	{
		return AssetRipper.Conversions.Lzham.GlobalFunctions.vsprintf_s_l.Invoke(Buffer, BufferCount, Format, Locale, ArgList);
	}

	[MangledName("__stdio_common_vsprintf_s")]
	[DemangledName("__stdio_common_vsprintf_s")]
	public unsafe static int stdio_common_vsprintf_s(long parameter_0, void* parameter_1, long parameter_2, void* parameter_3, void* parameter_4, void* parameter_5)
	{
		return AssetRipper.Conversions.Lzham.Intrinsics.Implemented.stdio_common_vsprintf_s.Invoke(parameter_0, parameter_1, parameter_2, parameter_3, parameter_4, parameter_5);
	}

	[MangledName("?lzham_fail@@YAXPEBD0I@Z")]
	[DemangledName("void __cdecl lzham_fail(char const *, char const *, unsigned int)")]
	[return: NativeType("void")]
	public unsafe static void lzham_fail([NativeType("char const *")] void* pExp, [NativeType("char const *")] void* pFile, [NativeType("unsigned int")] int line)
	{
		AssetRipper.Conversions.Lzham.GlobalFunctions.lzham_fail.Invoke(pExp, pFile, line);
	}

	public static void exit(int parameter_0)
	{
		AssetRipper.Conversions.Lzham.Intrinsics.Implemented.exit.Invoke(parameter_0);
	}

	[MangledName("?adler32@lzham@@YAIPEBX_KI@Z")]
	[DemangledName("unsigned int __cdecl lzham::adler32(void const *, unsigned __int64, unsigned int)")]
	[return: NativeType("unsigned int")]
	public unsafe static int adler32([NativeType("void const *")] void* pBuf, [NativeType("unsigned __int64")] long buflen, [NativeType("unsigned int")] int adler32)
	{
		return AssetRipper.Conversions.Lzham.GlobalFunctions.adler32.Invoke(pBuf, buflen, adler32);
	}

	[MangledName("?crc32@lzham@@YAIIPEBE_K@Z")]
	[DemangledName("unsigned int __cdecl lzham::crc32(unsigned int, unsigned char const *, unsigned __int64)")]
	[return: NativeType("unsigned int")]
	public unsafe static int crc32([NativeType("unsigned int")] int crc, [NativeType("unsigned char const *")] void* ptr, [NativeType("unsigned __int64")] long buf_len)
	{
		return AssetRipper.Conversions.Lzham.GlobalFunctions.crc32.Invoke(crc, ptr, buf_len);
	}

	[MangledName("?get_generate_huffman_codes_table_size@lzham@@YAIXZ")]
	[DemangledName("unsigned int __cdecl lzham::get_generate_huffman_codes_table_size(void)")]
	[return: NativeType("unsigned int")]
	public static int Get_generate_huffman_codes_table_size()
	{
		return AssetRipper.Conversions.Lzham.GlobalFunctions.Get_generate_huffman_codes_table_size.Invoke();
	}

	[MangledName("?generate_huffman_codes@lzham@@YA_NPEAXIPEBGPEAEAEAI3@Z")]
	[DemangledName("bool __cdecl lzham::generate_huffman_codes(void *, unsigned int, unsigned short const *, unsigned char *, unsigned int &, unsigned int &)")]
	[return: NativeType("bool")]
	public unsafe static bool generate_huffman_codes([NativeType("void *")] void* pContext, [NativeType("unsigned int")] int num_syms, [NativeType("unsigned short const *")] void* pFreq, [NativeType("unsigned char *")] void* pCodesizes, [NativeType("unsigned int &")] void* max_code_size, [NativeType("unsigned int &")] void* total_freq_ret)
	{
		return AssetRipper.Conversions.Lzham.GlobalFunctions.generate_huffman_codes.Invoke(pContext, num_syms, pFreq, pCodesizes, max_code_size, total_freq_ret);
	}

	[MangledName("??$maximum@I@math@lzham@@YAIII@Z")]
	[DemangledName("unsigned int __cdecl lzham::math::maximum<unsigned int>(unsigned int, unsigned int)")]
	[CleanName("maximum")]
	[return: NativeType("unsigned int")]
	public static int maximum_95ffuu([NativeType("unsigned int")] int a, [NativeType("unsigned int")] int b)
	{
		return AssetRipper.Conversions.Lzham.GlobalFunctions.maximum_95ffuu.Invoke(a, b);
	}

	[MangledName("?radix_sort_syms@lzham@@YAPEAUsym_freq@1@IPEAU21@0@Z")]
	[DemangledName("struct lzham::sym_freq * __cdecl lzham::radix_sort_syms(unsigned int, struct lzham::sym_freq *, struct lzham::sym_freq *)")]
	[return: NativeType("struct lzham::sym_freq *")]
	public unsafe static void* radix_sort_syms([NativeType("unsigned int")] int num_syms, [NativeType("struct lzham::sym_freq *")] void* syms0, [NativeType("struct lzham::sym_freq *")] void* syms1)
	{
		return AssetRipper.Conversions.Lzham.GlobalFunctions.radix_sort_syms.Invoke(num_syms, syms0, syms1);
	}

	[MangledName("?calculate_minimum_redundancy@lzham@@YAXQEAHH@Z")]
	[DemangledName("void __cdecl lzham::calculate_minimum_redundancy(int *const, int)")]
	[return: NativeType("void")]
	public unsafe static void calculate_minimum_redundancy([NativeType("int *const")] void* A, [NativeType("int")] int n)
	{
		AssetRipper.Conversions.Lzham.GlobalFunctions.calculate_minimum_redundancy.Invoke(A, n);
	}

	[MangledName("llvm.memset.p0.i64")]
	[DemangledName("llvm.memset.p0.i64")]
	public unsafe static void llvm_memset_p0_i64(void* parameter_0, sbyte parameter_1, long parameter_2, bool parameter_3)
	{
		AssetRipper.Conversions.Lzham.Intrinsics.Implemented.llvm_memset_p0_i64.Invoke(parameter_0, parameter_1, parameter_2, parameter_3);
	}

	[MangledName("llvm.memcpy.p0.p0.i64")]
	[DemangledName("llvm.memcpy.p0.p0.i64")]
	public unsafe static void llvm_memcpy_p0_p0_i64(void* parameter_0, void* parameter_1, long parameter_2, bool parameter_3)
	{
		AssetRipper.Conversions.Lzham.Intrinsics.Implemented.llvm_memcpy_p0_p0_i64.Invoke(parameter_0, parameter_1, parameter_2, parameter_3);
	}

	[MangledName("?init_position_slots@CLZDecompBase@lzham@@QEAAXI@Z")]
	[DemangledName("public: void __cdecl lzham::CLZDecompBase::init_position_slots(unsigned int)")]
	[return: NativeType("void")]
	public unsafe static void init_position_slots(void* @this, [NativeType("unsigned int")] int dict_size_log2)
	{
		AssetRipper.Conversions.Lzham.GlobalFunctions.init_position_slots.Invoke(@this, dict_size_log2);
	}

	[MangledName("?init@lzham_decompressor@lzham@@QEAAXXZ")]
	[DemangledName("public: void __cdecl lzham::lzham_decompressor::init(void)")]
	[CleanName("init")]
	[return: NativeType("void")]
	public unsafe static void init_fucheg(void* @this)
	{
		try
		{
			AssetRipper.Conversions.Lzham.GlobalFunctions.init_fucheg.Invoke(@this);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
	}

	[MangledName("?reset_huff_tables@lzham_decompressor@lzham@@QEAAXXZ")]
	[DemangledName("public: void __cdecl lzham::lzham_decompressor::reset_huff_tables(void)")]
	[return: NativeType("void")]
	public unsafe static void reset_huff_tables(void* @this)
	{
		try
		{
			AssetRipper.Conversions.Lzham.GlobalFunctions.reset_huff_tables.Invoke(@this);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
	}

	[MangledName("?reset_arith_tables@lzham_decompressor@lzham@@QEAAXXZ")]
	[DemangledName("public: void __cdecl lzham::lzham_decompressor::reset_arith_tables(void)")]
	[return: NativeType("void")]
	public unsafe static void reset_arith_tables(void* @this)
	{
		AssetRipper.Conversions.Lzham.GlobalFunctions.reset_arith_tables.Invoke(@this);
	}

	[MangledName("?clear@adaptive_bit_model@lzham@@QEAAXXZ")]
	[DemangledName("public: void __cdecl lzham::adaptive_bit_model::clear(void)")]
	[CleanName("clear")]
	[return: NativeType("void")]
	public unsafe static void clear_ezdf43(void* @this)
	{
		AssetRipper.Conversions.Lzham.GlobalFunctions.clear_ezdf43.Invoke(@this);
	}

	[MangledName("?reset_all_tables@lzham_decompressor@lzham@@QEAAXXZ")]
	[DemangledName("public: void __cdecl lzham::lzham_decompressor::reset_all_tables(void)")]
	[return: NativeType("void")]
	public unsafe static void reset_all_tables(void* @this)
	{
		try
		{
			AssetRipper.Conversions.Lzham.GlobalFunctions.reset_all_tables.Invoke(@this);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
	}

	[MangledName("?reset_huffman_table_update_rates@lzham_decompressor@lzham@@QEAAXXZ")]
	[DemangledName("public: void __cdecl lzham::lzham_decompressor::reset_huffman_table_update_rates(void)")]
	[return: NativeType("void")]
	public unsafe static void reset_huffman_table_update_rates(void* @this)
	{
		AssetRipper.Conversions.Lzham.GlobalFunctions.reset_huffman_table_update_rates.Invoke(@this);
	}

	[MangledName("?lzham_lib_decompress_init@lzham@@YAPEAXPEBUlzham_decompress_params@@@Z")]
	[DemangledName("void * __cdecl lzham::lzham_lib_decompress_init(struct lzham_decompress_params const *)")]
	[return: NativeType("void *")]
	public unsafe static void* lzham_lib_decompress_init([NativeType("struct lzham_decompress_params const *")] void* pParams)
	{
		void* result;
		try
		{
			result = AssetRipper.Conversions.Lzham.GlobalFunctions.lzham_lib_decompress_init.Invoke(pParams);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
		return result;
	}

	[MangledName("?check_params@lzham@@YA_NPEBUlzham_decompress_params@@@Z")]
	[DemangledName("bool __cdecl lzham::check_params(struct lzham_decompress_params const *)")]
	[return: NativeType("bool")]
	public unsafe static bool check_params([NativeType("struct lzham_decompress_params const *")] void* pParams)
	{
		return AssetRipper.Conversions.Lzham.GlobalFunctions.check_params.Invoke(pParams);
	}

	[MangledName("??$lzham_new@Ulzham_decompressor@lzham@@@lzham@@YAPEAUlzham_decompressor@0@XZ")]
	[DemangledName("struct lzham::lzham_decompressor * __cdecl lzham::lzham_new<struct lzham::lzham_decompressor>(void)")]
	[CleanName("lzham_new")]
	[return: NativeType("struct lzham::lzham_decompressor *")]
	public unsafe static void* lzham_new_6ef5hx()
	{
		void* result;
		try
		{
			result = AssetRipper.Conversions.Lzham.GlobalFunctions.lzham_new_6ef5hx.Invoke();
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
		return result;
	}

	[MangledName("??$lzham_delete@Ulzham_decompressor@lzham@@@lzham@@YAXPEAUlzham_decompressor@0@@Z")]
	[DemangledName("void __cdecl lzham::lzham_delete<struct lzham::lzham_decompressor>(struct lzham::lzham_decompressor *)")]
	[CleanName("lzham_delete")]
	[return: NativeType("void")]
	public unsafe static void lzham_delete_2heudk([NativeType("struct lzham::lzham_decompressor *")] void* p)
	{
		try
		{
			AssetRipper.Conversions.Lzham.GlobalFunctions.lzham_delete_2heudk.Invoke(p);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
	}

	[MangledName("??$align_up_pointer@PEAE@math@lzham@@YAPEAEPEAEI@Z")]
	[DemangledName("unsigned char * __cdecl lzham::math::align_up_pointer<unsigned char *>(unsigned char *, unsigned int)")]
	[return: NativeType("unsigned char *")]
	public unsafe static void* align_up_pointer([NativeType("unsigned char *")] void* p, [NativeType("unsigned int")] int alignment)
	{
		return AssetRipper.Conversions.Lzham.GlobalFunctions.align_up_pointer.Invoke(p, alignment);
	}

	[MangledName("??$destruct@Ulzham_decompressor@lzham@@@helpers@lzham@@YAXPEAUlzham_decompressor@1@@Z")]
	[DemangledName("void __cdecl lzham::helpers::destruct<struct lzham::lzham_decompressor>(struct lzham::lzham_decompressor *)")]
	[CleanName("destruct")]
	[return: NativeType("void")]
	public unsafe static void destruct_s37tni([NativeType("struct lzham::lzham_decompressor *")] void* p)
	{
		try
		{
			AssetRipper.Conversions.Lzham.GlobalFunctions.destruct_s37tni.Invoke(p);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
	}

	[MangledName("??1lzham_decompressor@lzham@@QEAA@XZ")]
	[DemangledName("public: __cdecl lzham::lzham_decompressor::~lzham_decompressor(void)")]
	public unsafe static void lzham_decompressor_Destructor(void* @this)
	{
		try
		{
			AssetRipper.Conversions.Lzham.GlobalFunctions.lzham_decompressor_Destructor.Invoke(@this);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
	}

	[MangledName("??1quasi_adaptive_huffman_data_model@lzham@@QEAA@XZ")]
	[DemangledName("public: __cdecl lzham::quasi_adaptive_huffman_data_model::~quasi_adaptive_huffman_data_model(void)")]
	public unsafe static void quasi_adaptive_huffman_data_model_Destructor(void* @this)
	{
		try
		{
			AssetRipper.Conversions.Lzham.GlobalFunctions.quasi_adaptive_huffman_data_model_Destructor.Invoke(@this);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
	}

	[MangledName("??1symbol_codec@lzham@@QEAA@XZ")]
	[DemangledName("public: __cdecl lzham::symbol_codec::~symbol_codec(void)")]
	public unsafe static void symbol_codec_Destructor(void* @this)
	{
		try
		{
			AssetRipper.Conversions.Lzham.GlobalFunctions.symbol_codec_Destructor.Invoke(@this);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
	}

	[MangledName("??1?$vector@Uoutput_symbol@symbol_codec@lzham@@@lzham@@QEAA@XZ")]
	[DemangledName("public: __cdecl lzham::vector<struct lzham::symbol_codec::output_symbol>::~vector<struct lzham::symbol_codec::output_symbol>(void)")]
	public unsafe static void vector_struct_lzham_symbol_codec_output_symbol_Destructor(void* @this)
	{
		try
		{
			AssetRipper.Conversions.Lzham.GlobalFunctions.vector_struct_lzham_symbol_codec_output_symbol_Destructor.Invoke(@this);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
	}

	[MangledName("??1?$vector@E@lzham@@QEAA@XZ")]
	[DemangledName("public: __cdecl lzham::vector<unsigned char>::~vector<unsigned char>(void)")]
	public unsafe static void vector_unsigned_char_Destructor(void* @this)
	{
		try
		{
			AssetRipper.Conversions.Lzham.GlobalFunctions.vector_unsigned_char_Destructor.Invoke(@this);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
	}

	[MangledName("__CxxFrameHandler3")]
	[DemangledName("__CxxFrameHandler3")]
	public static int CxxFrameHandler3(ReadOnlySpan<nint> args)
	{
		return AssetRipper.Conversions.Lzham.Intrinsics.Implemented.CxxFrameHandler3.Invoke(args);
	}

	[MangledName("?destruct_array@?$scalar_type@E@lzham@@SAXPEAEI@Z")]
	[DemangledName("public: static void __cdecl lzham::scalar_type<unsigned char>::destruct_array(unsigned char *, unsigned int)")]
	[CleanName("destruct_array")]
	[return: NativeType("void")]
	public unsafe static void destruct_array_4eajvq([NativeType("unsigned char *")] void* p, [NativeType("unsigned int")] int n)
	{
		AssetRipper.Conversions.Lzham.GlobalFunctions.destruct_array_4eajvq.Invoke(p, n);
	}

	[MangledName("__std_terminate")]
	[DemangledName("__std_terminate")]
	public static void std_terminate()
	{
		AssetRipper.Conversions.Lzham.Intrinsics.Implemented.std_terminate.Invoke();
	}

	[MangledName("?destruct_array@?$scalar_type@Uoutput_symbol@symbol_codec@lzham@@@lzham@@SAXPEAUoutput_symbol@symbol_codec@2@I@Z")]
	[DemangledName("public: static void __cdecl lzham::scalar_type<struct lzham::symbol_codec::output_symbol>::destruct_array(struct lzham::symbol_codec::output_symbol *, unsigned int)")]
	[CleanName("destruct_array")]
	[return: NativeType("void")]
	public unsafe static void destruct_array_6e56yk([NativeType("struct lzham::symbol_codec::output_symbol *")] void* p, [NativeType("unsigned int")] int n)
	{
		AssetRipper.Conversions.Lzham.GlobalFunctions.destruct_array_6e56yk.Invoke(p, n);
	}

	[MangledName("??$destruct_array@Uoutput_symbol@symbol_codec@lzham@@@helpers@lzham@@YAXPEAUoutput_symbol@symbol_codec@1@I@Z")]
	[DemangledName("void __cdecl lzham::helpers::destruct_array<struct lzham::symbol_codec::output_symbol>(struct lzham::symbol_codec::output_symbol *, unsigned int)")]
	[CleanName("destruct_array")]
	[return: NativeType("void")]
	public unsafe static void destruct_array_cf3p5p([NativeType("struct lzham::symbol_codec::output_symbol *")] void* p, [NativeType("unsigned int")] int n)
	{
		AssetRipper.Conversions.Lzham.GlobalFunctions.destruct_array_cf3p5p.Invoke(p, n);
	}

	[MangledName("??$construct@Ulzham_decompressor@lzham@@@helpers@lzham@@YAPEAUlzham_decompressor@1@PEAU21@@Z")]
	[DemangledName("struct lzham::lzham_decompressor * __cdecl lzham::helpers::construct<struct lzham::lzham_decompressor>(struct lzham::lzham_decompressor *)")]
	[CleanName("construct")]
	[return: NativeType("struct lzham::lzham_decompressor *")]
	public unsafe static void* construct_hr2weg([NativeType("struct lzham::lzham_decompressor *")] void* p)
	{
		void* result;
		try
		{
			result = AssetRipper.Conversions.Lzham.GlobalFunctions.construct_hr2weg.Invoke(p);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
		return result;
	}

	[MangledName("??0lzham_decompressor@lzham@@QEAA@XZ")]
	[DemangledName("public: __cdecl lzham::lzham_decompressor::lzham_decompressor(void)")]
	public unsafe static void* lzham_decompressor_Constructor(void* @this)
	{
		void* result;
		try
		{
			result = AssetRipper.Conversions.Lzham.GlobalFunctions.lzham_decompressor_Constructor.Invoke(@this);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
		return result;
	}

	[MangledName("??0quasi_adaptive_huffman_data_model@lzham@@QEAA@XZ")]
	[DemangledName("public: __cdecl lzham::quasi_adaptive_huffman_data_model::quasi_adaptive_huffman_data_model(void)")]
	public unsafe static void* quasi_adaptive_huffman_data_model_Constructor(void* @this)
	{
		void* result;
		try
		{
			result = AssetRipper.Conversions.Lzham.GlobalFunctions.quasi_adaptive_huffman_data_model_Constructor.Invoke(@this);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
		return result;
	}

	[MangledName("??0adaptive_bit_model@lzham@@QEAA@XZ")]
	[DemangledName("public: __cdecl lzham::adaptive_bit_model::adaptive_bit_model(void)")]
	[CleanName("adaptive_bit_model_Constructor")]
	public unsafe static void* adaptive_bit_model_Constructor_8cwvp7(void* @this)
	{
		return AssetRipper.Conversions.Lzham.GlobalFunctions.adaptive_bit_model_Constructor_8cwvp7.Invoke(@this);
	}

	[MangledName("?lzham_lib_decompress_reinit@lzham@@YAPEAXPEAXPEBUlzham_decompress_params@@@Z")]
	[DemangledName("void * __cdecl lzham::lzham_lib_decompress_reinit(void *, struct lzham_decompress_params const *)")]
	[return: NativeType("void *")]
	public unsafe static void* lzham_lib_decompress_reinit([NativeType("void *")] void* p, [NativeType("struct lzham_decompress_params const *")] void* pParams)
	{
		void* result;
		try
		{
			result = AssetRipper.Conversions.Lzham.GlobalFunctions.lzham_lib_decompress_reinit.Invoke(p, pParams);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
		return result;
	}

	[MangledName("?lzham_lib_decompress_deinit@lzham@@YAIPEAX@Z")]
	[DemangledName("unsigned int __cdecl lzham::lzham_lib_decompress_deinit(void *)")]
	[return: NativeType("unsigned int")]
	public unsafe static int lzham_lib_decompress_deinit([NativeType("void *")] void* p)
	{
		int result;
		try
		{
			result = AssetRipper.Conversions.Lzham.GlobalFunctions.lzham_lib_decompress_deinit.Invoke(p);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
		return result;
	}

	[MangledName("?lzham_lib_decompress@lzham@@YA?AW4lzham_decompress_status_t@@PEAXPEBEPEA_KPEAE2I@Z")]
	[DemangledName("enum lzham_decompress_status_t __cdecl lzham::lzham_lib_decompress(void *, unsigned char const *, unsigned __int64 *, unsigned char *, unsigned __int64 *, unsigned int)")]
	[return: NativeType("enum lzham_decompress_status_t")]
	public unsafe static int lzham_lib_decompress([NativeType("void *")] void* p, [NativeType("unsigned char const *")] void* pIn_buf, [NativeType("unsigned __int64 *")] void* pIn_buf_size, [NativeType("unsigned char *")] void* pOut_buf, [NativeType("unsigned __int64 *")] void* pOut_buf_size, [NativeType("unsigned int")] int no_more_input_bytes_flag)
	{
		int result;
		try
		{
			result = AssetRipper.Conversions.Lzham.GlobalFunctions.lzham_lib_decompress.Invoke(p, pIn_buf, pIn_buf_size, pOut_buf, pOut_buf_size, no_more_input_bytes_flag);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
		return result;
	}

	[MangledName("??$decompress@$00@lzham_decompressor@lzham@@QEAA?AW4lzham_decompress_status_t@@XZ")]
	[DemangledName("public: enum lzham_decompress_status_t __cdecl lzham::lzham_decompressor::decompress<1>(void)")]
	[CleanName("decompress")]
	[return: NativeType("enum lzham_decompress_status_t")]
	public unsafe static int decompress_9tv66f(void* @this)
	{
		int result;
		try
		{
			result = AssetRipper.Conversions.Lzham.GlobalFunctions.decompress_9tv66f.Invoke(@this);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
		return result;
	}

	[MangledName("??$decompress@$0A@@lzham_decompressor@lzham@@QEAA?AW4lzham_decompress_status_t@@XZ")]
	[DemangledName("public: enum lzham_decompress_status_t __cdecl lzham::lzham_decompressor::decompress<0>(void)")]
	[CleanName("decompress")]
	[return: NativeType("enum lzham_decompress_status_t")]
	public unsafe static int decompress_3euu7r(void* @this)
	{
		int result;
		try
		{
			result = AssetRipper.Conversions.Lzham.GlobalFunctions.decompress_3euu7r.Invoke(@this);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
		return result;
	}

	[MangledName("?decode_get_bytes_consumed@symbol_codec@lzham@@QEBA_KXZ")]
	[DemangledName("public: unsigned __int64 __cdecl lzham::symbol_codec::decode_get_bytes_consumed(void) const")]
	[return: NativeType("unsigned __int64")]
	public unsafe static long decode_get_bytes_consumed(void* @this)
	{
		return AssetRipper.Conversions.Lzham.GlobalFunctions.decode_get_bytes_consumed.Invoke(@this);
	}

	[MangledName("?decode_set_input_buffer@symbol_codec@lzham@@QEAAXPEBE_K0_N@Z")]
	[DemangledName("public: void __cdecl lzham::symbol_codec::decode_set_input_buffer(unsigned char const *, unsigned __int64, unsigned char const *, bool)")]
	[return: NativeType("void")]
	public unsafe static void decode_set_input_buffer(void* @this, [NativeType("unsigned char const *")] void* pBuf, [NativeType("unsigned __int64")] long buf_size, [NativeType("unsigned char const *")] void* pBuf_next, [NativeType("bool")] bool eof_flag)
	{
		AssetRipper.Conversions.Lzham.GlobalFunctions.decode_set_input_buffer.Invoke(@this, pBuf, buf_size, pBuf_next, eof_flag);
	}

	[MangledName("??$clamp@I@math@lzham@@YAIIII@Z")]
	[DemangledName("unsigned int __cdecl lzham::math::clamp<unsigned int>(unsigned int, unsigned int, unsigned int)")]
	[return: NativeType("unsigned int")]
	public static int clamp([NativeType("unsigned int")] int value, [NativeType("unsigned int")] int low, [NativeType("unsigned int")] int high)
	{
		return AssetRipper.Conversions.Lzham.GlobalFunctions.clamp.Invoke(value, low, high);
	}

	[MangledName("??A?$vector@G@lzham@@QEAAAEAGI@Z")]
	[DemangledName("public: unsigned short & __cdecl lzham::vector<unsigned short>::operator[](unsigned int)")]
	[return: NativeType("unsigned short &")]
	public unsafe static void* vector_unsigned_short_Operator(void* @this, [NativeType("unsigned int")] int i)
	{
		return AssetRipper.Conversions.Lzham.GlobalFunctions.vector_unsigned_short_Operator.Invoke(@this, i);
	}

	[MangledName("?lzham_lib_decompress_memory@lzham@@YA?AW4lzham_decompress_status_t@@PEBUlzham_decompress_params@@PEAEPEA_KPEBE_KPEAI@Z")]
	[DemangledName("enum lzham_decompress_status_t __cdecl lzham::lzham_lib_decompress_memory(struct lzham_decompress_params const *, unsigned char *, unsigned __int64 *, unsigned char const *, unsigned __int64, unsigned int *)")]
	[return: NativeType("enum lzham_decompress_status_t")]
	public unsafe static int lzham_lib_decompress_memory([NativeType("struct lzham_decompress_params const *")] void* pParams, [NativeType("unsigned char *")] void* pDst_buf, [NativeType("unsigned __int64 *")] void* pDst_len, [NativeType("unsigned char const *")] void* pSrc_buf, [NativeType("unsigned __int64")] long src_len, [NativeType("unsigned int *")] void* pAdler32)
	{
		int result;
		try
		{
			result = AssetRipper.Conversions.Lzham.GlobalFunctions.lzham_lib_decompress_memory.Invoke(pParams, pDst_buf, pDst_len, pSrc_buf, src_len, pAdler32);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
		return result;
	}

	[MangledName("?lzham_lib_z_inflateInit@lzham@@YAHPEAUlzham_z_stream@@@Z")]
	[DemangledName("int __cdecl lzham::lzham_lib_z_inflateInit(struct lzham_z_stream *)")]
	[return: NativeType("int")]
	public unsafe static int lzham_lib_z_inflateInit([NativeType("struct lzham_z_stream *")] void* pStream)
	{
		int result;
		try
		{
			result = AssetRipper.Conversions.Lzham.GlobalFunctions.lzham_lib_z_inflateInit.Invoke(pStream);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
		return result;
	}

	[MangledName("?lzham_lib_z_inflateInit2@lzham@@YAHPEAUlzham_z_stream@@H@Z")]
	[DemangledName("int __cdecl lzham::lzham_lib_z_inflateInit2(struct lzham_z_stream *, int)")]
	[return: NativeType("int")]
	public unsafe static int lzham_lib_z_inflateInit2([NativeType("struct lzham_z_stream *")] void* pStream, [NativeType("int")] int window_bits)
	{
		int result;
		try
		{
			result = AssetRipper.Conversions.Lzham.GlobalFunctions.lzham_lib_z_inflateInit2.Invoke(pStream, window_bits);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
		return result;
	}

	[MangledName("llvm.abs.i32")]
	[DemangledName("llvm.abs.i32")]
	public static int llvm_abs_i32(int parameter_0, bool parameter_1)
	{
		return AssetRipper.Conversions.Lzham.Intrinsics.Implemented.llvm_abs_i32.Invoke(parameter_0, parameter_1);
	}

	[MangledName("??$zero_object@Ulzham_decompress_params@@@utils@lzham@@YAXAEAUlzham_decompress_params@@@Z")]
	[DemangledName("void __cdecl lzham::utils::zero_object<struct lzham_decompress_params>(struct lzham_decompress_params &)")]
	[CleanName("zero_object")]
	[return: NativeType("void")]
	public unsafe static void zero_object_bebisp([NativeType("struct lzham_decompress_params &")] void* obj)
	{
		AssetRipper.Conversions.Lzham.GlobalFunctions.zero_object_bebisp.Invoke(obj);
	}

	[MangledName("?lzham_lib_z_inflateReset@lzham@@YAHPEAUlzham_z_stream@@@Z")]
	[DemangledName("int __cdecl lzham::lzham_lib_z_inflateReset(struct lzham_z_stream *)")]
	[return: NativeType("int")]
	public unsafe static int lzham_lib_z_inflateReset([NativeType("struct lzham_z_stream *")] void* pStream)
	{
		int result;
		try
		{
			result = AssetRipper.Conversions.Lzham.GlobalFunctions.lzham_lib_z_inflateReset.Invoke(pStream);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
		return result;
	}

	[MangledName("?lzham_lib_z_inflate@lzham@@YAHPEAUlzham_z_stream@@H@Z")]
	[DemangledName("int __cdecl lzham::lzham_lib_z_inflate(struct lzham_z_stream *, int)")]
	[return: NativeType("int")]
	public unsafe static int lzham_lib_z_inflate([NativeType("struct lzham_z_stream *")] void* pStream, [NativeType("int")] int flush)
	{
		int result;
		try
		{
			result = AssetRipper.Conversions.Lzham.GlobalFunctions.lzham_lib_z_inflate.Invoke(pStream, flush);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
		return result;
	}

	[MangledName("?lzham_lib_z_inflateEnd@lzham@@YAHPEAUlzham_z_stream@@@Z")]
	[DemangledName("int __cdecl lzham::lzham_lib_z_inflateEnd(struct lzham_z_stream *)")]
	[return: NativeType("int")]
	public unsafe static int lzham_lib_z_inflateEnd([NativeType("struct lzham_z_stream *")] void* pStream)
	{
		int result;
		try
		{
			result = AssetRipper.Conversions.Lzham.GlobalFunctions.lzham_lib_z_inflateEnd.Invoke(pStream);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
		return result;
	}

	[MangledName("?lzham_lib_z_uncompress@lzham@@YAHPEAEPEAKPEBEK@Z")]
	[DemangledName("int __cdecl lzham::lzham_lib_z_uncompress(unsigned char *, unsigned long *, unsigned char const *, unsigned long)")]
	[return: NativeType("int")]
	public unsafe static int lzham_lib_z_uncompress([NativeType("unsigned char *")] void* pDest, [NativeType("unsigned long *")] void* pDest_len, [NativeType("unsigned char const *")] void* pSource, [NativeType("unsigned long")] int source_len)
	{
		int result;
		try
		{
			result = AssetRipper.Conversions.Lzham.GlobalFunctions.lzham_lib_z_uncompress.Invoke(pDest, pDest_len, pSource, source_len);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
		return result;
	}

	[MangledName("?lzham_lib_z_error@lzham@@YAPEBDH@Z")]
	[DemangledName("char const * __cdecl lzham::lzham_lib_z_error(int)")]
	[return: NativeType("char const *")]
	public unsafe static void* lzham_lib_z_error([NativeType("int")] int err)
	{
		return AssetRipper.Conversions.Lzham.GlobalFunctions.lzham_lib_z_error.Invoke(err);
	}

	[MangledName("?lzham_lib_z_adler32@lzham@@YAKKPEBE_K@Z")]
	[DemangledName("unsigned long __cdecl lzham::lzham_lib_z_adler32(unsigned long, unsigned char const *, unsigned __int64)")]
	[return: NativeType("unsigned long")]
	public unsafe static int lzham_lib_z_adler32([NativeType("unsigned long")] int adler, [NativeType("unsigned char const *")] void* ptr, [NativeType("unsigned __int64")] long buf_len)
	{
		return AssetRipper.Conversions.Lzham.GlobalFunctions.lzham_lib_z_adler32.Invoke(adler, ptr, buf_len);
	}

	[MangledName("?lzham_lib_z_crc32@lzham@@YAKKPEBE_K@Z")]
	[DemangledName("unsigned long __cdecl lzham::lzham_lib_z_crc32(unsigned long, unsigned char const *, unsigned __int64)")]
	[return: NativeType("unsigned long")]
	public unsafe static int lzham_lib_z_crc32([NativeType("unsigned long")] int crc, [NativeType("unsigned char const *")] void* ptr, [NativeType("unsigned __int64")] long buf_len)
	{
		return AssetRipper.Conversions.Lzham.GlobalFunctions.lzham_lib_z_crc32.Invoke(crc, ptr, buf_len);
	}

	[MangledName("?lzham_malloc@lzham@@YAPEAX_KPEA_K@Z")]
	[DemangledName("void * __cdecl lzham::lzham_malloc(unsigned __int64, unsigned __int64 *)")]
	[return: NativeType("void *")]
	public unsafe static void* lzham_malloc([NativeType("unsigned __int64")] long size, [NativeType("unsigned __int64 *")] void* pActual_size)
	{
		void* result;
		try
		{
			result = AssetRipper.Conversions.Lzham.GlobalFunctions.lzham_malloc.Invoke(size, pActual_size);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
		return result;
	}

	[MangledName("?lzham_mem_error@lzham@@YAXPEBD@Z")]
	[DemangledName("void __cdecl lzham::lzham_mem_error(char const *)")]
	[return: NativeType("void")]
	public unsafe static void lzham_mem_error([NativeType("char const *")] void* p_msg)
	{
		AssetRipper.Conversions.Lzham.GlobalFunctions.lzham_mem_error.Invoke(p_msg);
	}

	[MangledName("?lzham_default_realloc@lzham@@YAPEAXPEAX_KPEA_KI0@Z")]
	[DemangledName("void * __cdecl lzham::lzham_default_realloc(void *, unsigned __int64, unsigned __int64 *, unsigned int, void *)")]
	[return: NativeType("void *")]
	public unsafe static void* lzham_default_realloc([NativeType("void *")] void* p, [NativeType("unsigned __int64")] long size, [NativeType("unsigned __int64 *")] void* pActual_size, [NativeType("unsigned int")] int movable, [NativeType("void *")] void* pUser_data)
	{
		return AssetRipper.Conversions.Lzham.GlobalFunctions.lzham_default_realloc.Invoke(p, size, pActual_size, movable, pUser_data);
	}

	public unsafe static void* malloc(long parameter_0)
	{
		return AssetRipper.Conversions.Lzham.Intrinsics.Implemented.malloc.Invoke(parameter_0);
	}

	[MangledName("_msize")]
	[DemangledName("_msize")]
	public unsafe static long msize(void* parameter_0)
	{
		return AssetRipper.Conversions.Lzham.Intrinsics.Implemented.msize.Invoke(parameter_0);
	}

	public unsafe static void free(void* parameter_0)
	{
		AssetRipper.Conversions.Lzham.Intrinsics.Implemented.free.Invoke(parameter_0);
	}

	public unsafe static void* realloc(void* parameter_0, long parameter_1)
	{
		return AssetRipper.Conversions.Lzham.Intrinsics.Implemented.realloc.Invoke(parameter_0, parameter_1);
	}

	[MangledName("?lzham_realloc@lzham@@YAPEAXPEAX_KPEA_K_N@Z")]
	[DemangledName("void * __cdecl lzham::lzham_realloc(void *, unsigned __int64, unsigned __int64 *, bool)")]
	[return: NativeType("void *")]
	public unsafe static void* lzham_realloc([NativeType("void *")] void* p, [NativeType("unsigned __int64")] long size, [NativeType("unsigned __int64 *")] void* pActual_size, [NativeType("bool")] bool movable)
	{
		void* result;
		try
		{
			result = AssetRipper.Conversions.Lzham.GlobalFunctions.lzham_realloc.Invoke(p, size, pActual_size, movable);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
		return result;
	}

	[MangledName("?lzham_free@lzham@@YAXPEAX@Z")]
	[DemangledName("void __cdecl lzham::lzham_free(void *)")]
	[return: NativeType("void")]
	public unsafe static void lzham_free([NativeType("void *")] void* p)
	{
		try
		{
			AssetRipper.Conversions.Lzham.GlobalFunctions.lzham_free.Invoke(p);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
	}

	[MangledName("?lzham_msize@lzham@@YA_KPEAX@Z")]
	[DemangledName("unsigned __int64 __cdecl lzham::lzham_msize(void *)")]
	[return: NativeType("unsigned __int64")]
	public unsafe static long lzham_msize([NativeType("void *")] void* p)
	{
		long result;
		try
		{
			result = AssetRipper.Conversions.Lzham.GlobalFunctions.lzham_msize.Invoke(p);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
		return result;
	}

	[MangledName("?lzham_default_msize@lzham@@YA_KPEAX0@Z")]
	[DemangledName("unsigned __int64 __cdecl lzham::lzham_default_msize(void *, void *)")]
	[return: NativeType("unsigned __int64")]
	public unsafe static long lzham_default_msize([NativeType("void *")] void* p, [NativeType("void *")] void* pUser_data)
	{
		return AssetRipper.Conversions.Lzham.GlobalFunctions.lzham_default_msize.Invoke(p, pUser_data);
	}

	[MangledName("?lzham_lib_set_memory_callbacks@lzham@@YAXP6APEAXPEAX_KPEA_KI0@ZP6A_K00@Z0@Z")]
	[DemangledName("void __cdecl lzham::lzham_lib_set_memory_callbacks(void * (__cdecl *)(void *, unsigned __int64, unsigned __int64 *, unsigned int, void *), unsigned __int64 (__cdecl *)(void *, void *), void *)")]
	[return: NativeType("void")]
	public unsafe static void lzham_lib_set_memory_callbacks([NativeType("void * (__cdecl *)(void *, unsigned __int64, unsigned __int64 *, unsigned int, void *)")] void* pRealloc, [NativeType("unsigned __int64 (__cdecl *)(void *, void *)")] void* pMSize, [NativeType("void *")] void* pUser_data)
	{
		AssetRipper.Conversions.Lzham.GlobalFunctions.lzham_lib_set_memory_callbacks.Invoke(pRealloc, pMSize, pUser_data);
	}

	[MangledName("?lzham_print_mem_stats@lzham@@YAXXZ")]
	[DemangledName("void __cdecl lzham::lzham_print_mem_stats(void)")]
	[return: NativeType("void")]
	public static void lzham_print_mem_stats()
	{
		AssetRipper.Conversions.Lzham.GlobalFunctions.lzham_print_mem_stats.Invoke();
	}

	[MangledName("?lzham_output_debug_string@@YAXPEBD@Z")]
	[DemangledName("void __cdecl lzham_output_debug_string(char const *)")]
	[return: NativeType("void")]
	public unsafe static void lzham_output_debug_string([NativeType("char const *")] void* p)
	{
		AssetRipper.Conversions.Lzham.GlobalFunctions.lzham_output_debug_string.Invoke(p);
	}

	public unsafe static int fputs(void* parameter_0, void* parameter_1)
	{
		return AssetRipper.Conversions.Lzham.Intrinsics.Implemented.fputs.Invoke(parameter_0, parameter_1);
	}

	[MangledName("?limit_max_code_size@prefix_coding@lzham@@YA_NIPEAEI@Z")]
	[DemangledName("bool __cdecl lzham::prefix_coding::limit_max_code_size(unsigned int, unsigned char *, unsigned int)")]
	[return: NativeType("bool")]
	public unsafe static bool limit_max_code_size([NativeType("unsigned int")] int num_syms, [NativeType("unsigned char *")] void* pCodesizes, [NativeType("unsigned int")] int max_code_size)
	{
		return AssetRipper.Conversions.Lzham.GlobalFunctions.limit_max_code_size.Invoke(num_syms, pCodesizes, max_code_size);
	}

	[MangledName("??$zero_object@$$BY0CD@I@utils@lzham@@YAXAEAY0CD@I@Z")]
	[DemangledName("void __cdecl lzham::utils::zero_object<unsigned int[35]>(unsigned int (&)[35])")]
	[CleanName("zero_object")]
	[return: NativeType("void")]
	public unsafe static void zero_object_jc2sde([NativeType("unsigned int (&)[35]")] void* obj)
	{
		AssetRipper.Conversions.Lzham.GlobalFunctions.zero_object_jc2sde.Invoke(obj);
	}

	[MangledName("?generate_codes@prefix_coding@lzham@@YA_NIPEBEPEAG@Z")]
	[DemangledName("bool __cdecl lzham::prefix_coding::generate_codes(unsigned int, unsigned char const *, unsigned short *)")]
	[return: NativeType("bool")]
	public unsafe static bool generate_codes([NativeType("unsigned int")] int num_syms, [NativeType("unsigned char const *")] void* pCodesizes, [NativeType("unsigned short *")] void* pCodes)
	{
		return AssetRipper.Conversions.Lzham.GlobalFunctions.generate_codes.Invoke(num_syms, pCodesizes, pCodes);
	}

	[MangledName("??$zero_object@$$BY0BB@I@utils@lzham@@YAXAEAY0BB@I@Z")]
	[DemangledName("void __cdecl lzham::utils::zero_object<unsigned int[17]>(unsigned int (&)[17])")]
	[CleanName("zero_object")]
	[return: NativeType("void")]
	public unsafe static void zero_object_nua2vr([NativeType("unsigned int (&)[17]")] void* obj)
	{
		AssetRipper.Conversions.Lzham.GlobalFunctions.zero_object_nua2vr.Invoke(obj);
	}

	[MangledName("?generate_decoder_tables@prefix_coding@lzham@@YA_NIPEBEPEAVdecoder_tables@12@I@Z")]
	[DemangledName("bool __cdecl lzham::prefix_coding::generate_decoder_tables(unsigned int, unsigned char const *, class lzham::prefix_coding::decoder_tables *, unsigned int)")]
	[return: NativeType("bool")]
	public unsafe static bool generate_decoder_tables([NativeType("unsigned int")] int num_syms, [NativeType("unsigned char const *")] void* pCodesizes, [NativeType("class lzham::prefix_coding::decoder_tables *")] void* pTables, [NativeType("unsigned int")] int table_bits)
	{
		bool result;
		try
		{
			result = AssetRipper.Conversions.Lzham.GlobalFunctions.generate_decoder_tables.Invoke(num_syms, pCodesizes, pTables, table_bits);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
		return result;
	}

	[MangledName("??$minimum@I@math@lzham@@YAIII@Z")]
	[DemangledName("unsigned int __cdecl lzham::math::minimum<unsigned int>(unsigned int, unsigned int)")]
	[CleanName("minimum")]
	[return: NativeType("unsigned int")]
	public static int minimum_c94n3m([NativeType("unsigned int")] int a, [NativeType("unsigned int")] int b)
	{
		return AssetRipper.Conversions.Lzham.GlobalFunctions.minimum_c94n3m.Invoke(a, b);
	}

	[MangledName("?is_power_of_2@math@lzham@@YA_NI@Z")]
	[DemangledName("bool __cdecl lzham::math::is_power_of_2(unsigned int)")]
	[CleanName("is_power_of_2")]
	[return: NativeType("bool")]
	public static bool is_power_of_2_igmcwk([NativeType("unsigned int")] int x)
	{
		return AssetRipper.Conversions.Lzham.GlobalFunctions.is_power_of_2_igmcwk.Invoke(x);
	}

	[MangledName("?next_pow2@math@lzham@@YAII@Z")]
	[DemangledName("unsigned int __cdecl lzham::math::next_pow2(unsigned int)")]
	[CleanName("next_pow2")]
	[return: NativeType("unsigned int")]
	public static int next_pow2_sz9rvk([NativeType("unsigned int")] int val)
	{
		return AssetRipper.Conversions.Lzham.GlobalFunctions.next_pow2_sz9rvk.Invoke(val);
	}

	[MangledName("??$lzham_delete_array@G@lzham@@YAXPEAG@Z")]
	[DemangledName("void __cdecl lzham::lzham_delete_array<unsigned short>(unsigned short *)")]
	[CleanName("lzham_delete_array")]
	[return: NativeType("void")]
	public unsafe static void lzham_delete_array_i9xite([NativeType("unsigned short *")] void* p)
	{
		try
		{
			AssetRipper.Conversions.Lzham.GlobalFunctions.lzham_delete_array_i9xite.Invoke(p);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
	}

	[MangledName("??$lzham_new_array@G@lzham@@YAPEAGI@Z")]
	[DemangledName("unsigned short * __cdecl lzham::lzham_new_array<unsigned short>(unsigned int)")]
	[CleanName("lzham_new_array")]
	[return: NativeType("unsigned short *")]
	public unsafe static void* lzham_new_array_sb2tu4([NativeType("unsigned int")] int num)
	{
		void* result;
		try
		{
			result = AssetRipper.Conversions.Lzham.GlobalFunctions.lzham_new_array_sb2tu4.Invoke(num);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
		return result;
	}

	[MangledName("??$lzham_delete_array@I@lzham@@YAXPEAI@Z")]
	[DemangledName("void __cdecl lzham::lzham_delete_array<unsigned int>(unsigned int *)")]
	[CleanName("lzham_delete_array")]
	[return: NativeType("void")]
	public unsafe static void lzham_delete_array_g5z2nn([NativeType("unsigned int *")] void* p)
	{
		try
		{
			AssetRipper.Conversions.Lzham.GlobalFunctions.lzham_delete_array_g5z2nn.Invoke(p);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
	}

	[MangledName("??$lzham_new_array@I@lzham@@YAPEAII@Z")]
	[DemangledName("unsigned int * __cdecl lzham::lzham_new_array<unsigned int>(unsigned int)")]
	[CleanName("lzham_new_array")]
	[return: NativeType("unsigned int *")]
	public unsafe static void* lzham_new_array_qrkyp9([NativeType("unsigned int")] int num)
	{
		void* result;
		try
		{
			result = AssetRipper.Conversions.Lzham.GlobalFunctions.lzham_new_array_qrkyp9.Invoke(num);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
		return result;
	}

	[MangledName("?get_unshifted_max_code@decoder_tables@prefix_coding@lzham@@QEBAII@Z")]
	[DemangledName("public: unsigned int __cdecl lzham::prefix_coding::decoder_tables::get_unshifted_max_code(unsigned int) const")]
	[return: NativeType("unsigned int")]
	public unsafe static int Get_unshifted_max_code(void* @this, [NativeType("unsigned int")] int len)
	{
		return AssetRipper.Conversions.Lzham.GlobalFunctions.Get_unshifted_max_code.Invoke(@this, len);
	}

	[MangledName("??0raw_quasi_adaptive_huffman_data_model@lzham@@QEAA@_NIII@Z")]
	[DemangledName("public: __cdecl lzham::raw_quasi_adaptive_huffman_data_model::raw_quasi_adaptive_huffman_data_model(bool, unsigned int, unsigned int, unsigned int)")]
	[CleanName("raw_quasi_adaptive_huffman_data_model_Constructor")]
	public unsafe static void* raw_quasi_adaptive_huffman_data_model_Constructor_vwaw3p(void* @this, [NativeType("bool")] bool encoding, [NativeType("unsigned int")] int total_syms, [NativeType("unsigned int")] int max_update_interval, [NativeType("unsigned int")] int adapt_rate)
	{
		void* result;
		try
		{
			result = AssetRipper.Conversions.Lzham.GlobalFunctions.raw_quasi_adaptive_huffman_data_model_Constructor_vwaw3p.Invoke(@this, encoding, total_syms, max_update_interval, adapt_rate);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
		return result;
	}

	[MangledName("??0?$vector@G@lzham@@QEAA@XZ")]
	[DemangledName("public: __cdecl lzham::vector<unsigned short>::vector<unsigned short>(void)")]
	public unsafe static void* vector_unsigned_short_Constructor(void* @this)
	{
		return AssetRipper.Conversions.Lzham.GlobalFunctions.vector_unsigned_short_Constructor.Invoke(@this);
	}

	[MangledName("??0?$vector@E@lzham@@QEAA@XZ")]
	[DemangledName("public: __cdecl lzham::vector<unsigned char>::vector<unsigned char>(void)")]
	public unsafe static void* vector_unsigned_char_Constructor(void* @this)
	{
		return AssetRipper.Conversions.Lzham.GlobalFunctions.vector_unsigned_char_Constructor.Invoke(@this);
	}

	[MangledName("?init2@raw_quasi_adaptive_huffman_data_model@lzham@@QEAA_N_NIIIPEBG@Z")]
	[DemangledName("public: bool __cdecl lzham::raw_quasi_adaptive_huffman_data_model::init2(bool, unsigned int, unsigned int, unsigned int, unsigned short const *)")]
	[return: NativeType("bool")]
	public unsafe static bool init2(void* @this, [NativeType("bool")] bool encoding, [NativeType("unsigned int")] int total_syms, [NativeType("unsigned int")] int max_update_interval, [NativeType("unsigned int")] int adapt_rate, [NativeType("unsigned short const *")] void* pInitial_sym_freq)
	{
		bool result;
		try
		{
			result = AssetRipper.Conversions.Lzham.GlobalFunctions.init2.Invoke(@this, encoding, total_syms, max_update_interval, adapt_rate, pInitial_sym_freq);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
		return result;
	}

	[MangledName("??1?$vector@G@lzham@@QEAA@XZ")]
	[DemangledName("public: __cdecl lzham::vector<unsigned short>::~vector<unsigned short>(void)")]
	public unsafe static void vector_unsigned_short_Destructor(void* @this)
	{
		try
		{
			AssetRipper.Conversions.Lzham.GlobalFunctions.vector_unsigned_short_Destructor.Invoke(@this);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
	}

	[MangledName("?destruct_array@?$scalar_type@G@lzham@@SAXPEAGI@Z")]
	[DemangledName("public: static void __cdecl lzham::scalar_type<unsigned short>::destruct_array(unsigned short *, unsigned int)")]
	[CleanName("destruct_array")]
	[return: NativeType("void")]
	public unsafe static void destruct_array_hna8pw([NativeType("unsigned short *")] void* p, [NativeType("unsigned int")] int n)
	{
		AssetRipper.Conversions.Lzham.GlobalFunctions.destruct_array_hna8pw.Invoke(p, n);
	}

	[MangledName("?try_resize@?$vector@G@lzham@@QEAA_NI_N@Z")]
	[DemangledName("public: bool __cdecl lzham::vector<unsigned short>::try_resize(unsigned int, bool)")]
	[CleanName("try_resize")]
	[return: NativeType("bool")]
	public unsafe static bool try_resize_x6c5v6(void* @this, [NativeType("unsigned int")] int new_size, [NativeType("bool")] bool grow_hint)
	{
		bool result;
		try
		{
			result = AssetRipper.Conversions.Lzham.GlobalFunctions.try_resize_x6c5v6.Invoke(@this, new_size, grow_hint);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
		return result;
	}

	[MangledName("?clear@raw_quasi_adaptive_huffman_data_model@lzham@@QEAAXXZ")]
	[DemangledName("public: void __cdecl lzham::raw_quasi_adaptive_huffman_data_model::clear(void)")]
	[CleanName("clear")]
	[return: NativeType("void")]
	public unsafe static void clear_bzp3jp(void* @this)
	{
		try
		{
			AssetRipper.Conversions.Lzham.GlobalFunctions.clear_bzp3jp.Invoke(@this);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
	}

	[MangledName("?begin@?$vector@G@lzham@@QEAAPEAGXZ")]
	[DemangledName("public: unsigned short * __cdecl lzham::vector<unsigned short>::begin(void)")]
	[return: NativeType("unsigned short *")]
	public unsafe static void* begin(void* @this)
	{
		return AssetRipper.Conversions.Lzham.GlobalFunctions.begin.Invoke(@this);
	}

	[MangledName("?size_in_bytes@?$vector@G@lzham@@QEBAIXZ")]
	[DemangledName("public: unsigned int __cdecl lzham::vector<unsigned short>::size_in_bytes(void) const")]
	[CleanName("size_in_bytes")]
	[return: NativeType("unsigned int")]
	public unsafe static int size_in_bytes_pes8ki(void* @this)
	{
		return AssetRipper.Conversions.Lzham.GlobalFunctions.size_in_bytes_pes8ki.Invoke(@this);
	}

	[MangledName("?try_resize@?$vector@E@lzham@@QEAA_NI_N@Z")]
	[DemangledName("public: bool __cdecl lzham::vector<unsigned char>::try_resize(unsigned int, bool)")]
	[CleanName("try_resize")]
	[return: NativeType("bool")]
	public unsafe static bool try_resize_m9x9dy(void* @this, [NativeType("unsigned int")] int new_size, [NativeType("bool")] bool grow_hint)
	{
		bool result;
		try
		{
			result = AssetRipper.Conversions.Lzham.GlobalFunctions.try_resize_m9x9dy.Invoke(@this, new_size, grow_hint);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
		return result;
	}

	[MangledName("?ceil_log2i@math@lzham@@YAII@Z")]
	[DemangledName("unsigned int __cdecl lzham::math::ceil_log2i(unsigned int)")]
	[return: NativeType("unsigned int")]
	public static int ceil_log2i([NativeType("unsigned int")] int v)
	{
		return AssetRipper.Conversions.Lzham.GlobalFunctions.ceil_log2i.Invoke(v);
	}

	[MangledName("??$lzham_delete@Vdecoder_tables@prefix_coding@lzham@@@lzham@@YAXPEAVdecoder_tables@prefix_coding@0@@Z")]
	[DemangledName("void __cdecl lzham::lzham_delete<class lzham::prefix_coding::decoder_tables>(class lzham::prefix_coding::decoder_tables *)")]
	[CleanName("lzham_delete")]
	[return: NativeType("void")]
	public unsafe static void lzham_delete_thmwkf([NativeType("class lzham::prefix_coding::decoder_tables *")] void* p)
	{
		try
		{
			AssetRipper.Conversions.Lzham.GlobalFunctions.lzham_delete_thmwkf.Invoke(p);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
	}

	[MangledName("??$lzham_new@Vdecoder_tables@prefix_coding@lzham@@@lzham@@YAPEAVdecoder_tables@prefix_coding@0@XZ")]
	[DemangledName("class lzham::prefix_coding::decoder_tables * __cdecl lzham::lzham_new<class lzham::prefix_coding::decoder_tables>(void)")]
	[CleanName("lzham_new")]
	[return: NativeType("class lzham::prefix_coding::decoder_tables *")]
	public unsafe static void* lzham_new_6ts7ez()
	{
		void* result;
		try
		{
			result = AssetRipper.Conversions.Lzham.GlobalFunctions.lzham_new_6ts7ez.Invoke();
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
		return result;
	}

	[MangledName("?reset@raw_quasi_adaptive_huffman_data_model@lzham@@QEAA_NXZ")]
	[DemangledName("public: bool __cdecl lzham::raw_quasi_adaptive_huffman_data_model::reset(void)")]
	[CleanName("reset")]
	[return: NativeType("bool")]
	public unsafe static bool reset_kva6fy(void* @this)
	{
		bool result;
		try
		{
			result = AssetRipper.Conversions.Lzham.GlobalFunctions.reset_kva6fy.Invoke(@this);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
		return result;
	}

	[MangledName("?size@?$vector@G@lzham@@QEBAIXZ")]
	[DemangledName("public: unsigned int __cdecl lzham::vector<unsigned short>::size(void) const")]
	[CleanName("size")]
	[return: NativeType("unsigned int")]
	public unsafe static int size_r8uza7(void* @this)
	{
		return AssetRipper.Conversions.Lzham.GlobalFunctions.size_r8uza7.Invoke(@this);
	}

	[MangledName("?update_tables@raw_quasi_adaptive_huffman_data_model@lzham@@QEAA_NH_N@Z")]
	[DemangledName("public: bool __cdecl lzham::raw_quasi_adaptive_huffman_data_model::update_tables(int, bool)")]
	[return: NativeType("bool")]
	public unsafe static bool update_tables(void* @this, [NativeType("int")] int force_update_cycle, [NativeType("bool")] bool sym_freq_all_ones)
	{
		bool result;
		try
		{
			result = AssetRipper.Conversions.Lzham.GlobalFunctions.update_tables.Invoke(@this, force_update_cycle, sym_freq_all_ones);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
		return result;
	}

	[MangledName("?rescale@raw_quasi_adaptive_huffman_data_model@lzham@@QEAAXXZ")]
	[DemangledName("public: void __cdecl lzham::raw_quasi_adaptive_huffman_data_model::rescale(void)")]
	[return: NativeType("void")]
	public unsafe static void rescale(void* @this)
	{
		AssetRipper.Conversions.Lzham.GlobalFunctions.rescale.Invoke(@this);
	}

	[MangledName("?floor_log2i@math@lzham@@YAII@Z")]
	[DemangledName("unsigned int __cdecl lzham::math::floor_log2i(unsigned int)")]
	[return: NativeType("unsigned int")]
	public static int floor_log2i([NativeType("unsigned int")] int v)
	{
		return AssetRipper.Conversions.Lzham.GlobalFunctions.floor_log2i.Invoke(v);
	}

	[MangledName("??A?$vector@E@lzham@@QEAAAEAEI@Z")]
	[DemangledName("public: unsigned char & __cdecl lzham::vector<unsigned char>::operator[](unsigned int)")]
	[CleanName("vector_unsigned_char_Operator")]
	[return: NativeType("unsigned char &")]
	public unsafe static void* vector_unsigned_char_Operator_apxfsu(void* @this, [NativeType("unsigned int")] int i)
	{
		return AssetRipper.Conversions.Lzham.GlobalFunctions.vector_unsigned_char_Operator_apxfsu.Invoke(@this, i);
	}

	[MangledName("??$construct@Vdecoder_tables@prefix_coding@lzham@@@helpers@lzham@@YAPEAVdecoder_tables@prefix_coding@1@PEAV231@@Z")]
	[DemangledName("class lzham::prefix_coding::decoder_tables * __cdecl lzham::helpers::construct<class lzham::prefix_coding::decoder_tables>(class lzham::prefix_coding::decoder_tables *)")]
	[CleanName("construct")]
	[return: NativeType("class lzham::prefix_coding::decoder_tables *")]
	public unsafe static void* construct_awdxwb([NativeType("class lzham::prefix_coding::decoder_tables *")] void* p)
	{
		return AssetRipper.Conversions.Lzham.GlobalFunctions.construct_awdxwb.Invoke(p);
	}

	[MangledName("??0decoder_tables@prefix_coding@lzham@@QEAA@XZ")]
	[DemangledName("public: __cdecl lzham::prefix_coding::decoder_tables::decoder_tables(void)")]
	[CleanName("decoder_tables_Constructor")]
	public unsafe static void* decoder_tables_Constructor_xer4pc(void* @this)
	{
		return AssetRipper.Conversions.Lzham.GlobalFunctions.decoder_tables_Constructor_xer4pc.Invoke(@this);
	}

	[MangledName("??$destruct@Vdecoder_tables@prefix_coding@lzham@@@helpers@lzham@@YAXPEAVdecoder_tables@prefix_coding@1@@Z")]
	[DemangledName("void __cdecl lzham::helpers::destruct<class lzham::prefix_coding::decoder_tables>(class lzham::prefix_coding::decoder_tables *)")]
	[CleanName("destruct")]
	[return: NativeType("void")]
	public unsafe static void destruct_np23pw([NativeType("class lzham::prefix_coding::decoder_tables *")] void* p)
	{
		try
		{
			AssetRipper.Conversions.Lzham.GlobalFunctions.destruct_np23pw.Invoke(p);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
	}

	[MangledName("??1decoder_tables@prefix_coding@lzham@@QEAA@XZ")]
	[DemangledName("public: __cdecl lzham::prefix_coding::decoder_tables::~decoder_tables(void)")]
	public unsafe static void decoder_tables_Destructor(void* @this)
	{
		try
		{
			AssetRipper.Conversions.Lzham.GlobalFunctions.decoder_tables_Destructor.Invoke(@this);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
	}

	[MangledName("?increase_capacity@?$vector@E@lzham@@AEAA_NI_N0@Z")]
	[DemangledName("private: bool __cdecl lzham::vector<unsigned char>::increase_capacity(unsigned int, bool, bool)")]
	[CleanName("increase_capacity")]
	[return: NativeType("bool")]
	public unsafe static bool increase_capacity_hecp7w(void* @this, [NativeType("unsigned int")] int min_new_capacity, [NativeType("bool")] bool grow_hint, [NativeType("bool")] bool nofail)
	{
		bool result;
		try
		{
			result = AssetRipper.Conversions.Lzham.GlobalFunctions.increase_capacity_hecp7w.Invoke(@this, min_new_capacity, grow_hint, nofail);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
		return result;
	}

	[MangledName("?construct_array@?$scalar_type@E@lzham@@SAXPEAEI@Z")]
	[DemangledName("public: static void __cdecl lzham::scalar_type<unsigned char>::construct_array(unsigned char *, unsigned int)")]
	[CleanName("construct_array")]
	[return: NativeType("void")]
	public unsafe static void construct_array_pnydps([NativeType("unsigned char *")] void* p, [NativeType("unsigned int")] int n)
	{
		AssetRipper.Conversions.Lzham.GlobalFunctions.construct_array_pnydps.Invoke(p, n);
	}

	[MangledName("?clear@?$vector@G@lzham@@QEAAXXZ")]
	[DemangledName("public: void __cdecl lzham::vector<unsigned short>::clear(void)")]
	[CleanName("clear")]
	[return: NativeType("void")]
	public unsafe static void clear_nj6f5j(void* @this)
	{
		try
		{
			AssetRipper.Conversions.Lzham.GlobalFunctions.clear_nj6f5j.Invoke(@this);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
	}

	[MangledName("?clear@?$vector@E@lzham@@QEAAXXZ")]
	[DemangledName("public: void __cdecl lzham::vector<unsigned char>::clear(void)")]
	[CleanName("clear")]
	[return: NativeType("void")]
	public unsafe static void clear_tzajca(void* @this)
	{
		try
		{
			AssetRipper.Conversions.Lzham.GlobalFunctions.clear_tzajca.Invoke(@this);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
	}

	[MangledName("?increase_capacity@?$vector@G@lzham@@AEAA_NI_N0@Z")]
	[DemangledName("private: bool __cdecl lzham::vector<unsigned short>::increase_capacity(unsigned int, bool, bool)")]
	[CleanName("increase_capacity")]
	[return: NativeType("bool")]
	public unsafe static bool increase_capacity_dwbww2(void* @this, [NativeType("unsigned int")] int min_new_capacity, [NativeType("bool")] bool grow_hint, [NativeType("bool")] bool nofail)
	{
		bool result;
		try
		{
			result = AssetRipper.Conversions.Lzham.GlobalFunctions.increase_capacity_dwbww2.Invoke(@this, min_new_capacity, grow_hint, nofail);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
		return result;
	}

	[MangledName("?construct_array@?$scalar_type@G@lzham@@SAXPEAGI@Z")]
	[DemangledName("public: static void __cdecl lzham::scalar_type<unsigned short>::construct_array(unsigned short *, unsigned int)")]
	[CleanName("construct_array")]
	[return: NativeType("void")]
	public unsafe static void construct_array_rfafyp([NativeType("unsigned short *")] void* p, [NativeType("unsigned int")] int n)
	{
		AssetRipper.Conversions.Lzham.GlobalFunctions.construct_array_rfafyp.Invoke(p, n);
	}

	[MangledName("??0raw_quasi_adaptive_huffman_data_model@lzham@@QEAA@AEBV01@@Z")]
	[DemangledName("public: __cdecl lzham::raw_quasi_adaptive_huffman_data_model::raw_quasi_adaptive_huffman_data_model(class lzham::raw_quasi_adaptive_huffman_data_model const &)")]
	[CleanName("raw_quasi_adaptive_huffman_data_model_Constructor")]
	public unsafe static void* raw_quasi_adaptive_huffman_data_model_Constructor_d69ci2(void* @this, [NativeType("class lzham::raw_quasi_adaptive_huffman_data_model const &")] void* other)
	{
		void* result;
		try
		{
			result = AssetRipper.Conversions.Lzham.GlobalFunctions.raw_quasi_adaptive_huffman_data_model_Constructor_d69ci2.Invoke(@this, other);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
		return result;
	}

	[MangledName("??4raw_quasi_adaptive_huffman_data_model@lzham@@QEAAAEAV01@AEBV01@@Z")]
	[DemangledName("public: class lzham::raw_quasi_adaptive_huffman_data_model & __cdecl lzham::raw_quasi_adaptive_huffman_data_model::operator=(class lzham::raw_quasi_adaptive_huffman_data_model const &)")]
	[return: NativeType("class lzham::raw_quasi_adaptive_huffman_data_model &")]
	public unsafe static void* raw_quasi_adaptive_huffman_data_model_Assignment(void* @this, [NativeType("class lzham::raw_quasi_adaptive_huffman_data_model const &")] void* rhs)
	{
		void* result;
		try
		{
			result = AssetRipper.Conversions.Lzham.GlobalFunctions.raw_quasi_adaptive_huffman_data_model_Assignment.Invoke(@this, rhs);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
		return result;
	}

	[MangledName("?assign@raw_quasi_adaptive_huffman_data_model@lzham@@QEAA_NAEBV12@@Z")]
	[DemangledName("public: bool __cdecl lzham::raw_quasi_adaptive_huffman_data_model::assign(class lzham::raw_quasi_adaptive_huffman_data_model const &)")]
	[CleanName("assign")]
	[return: NativeType("bool")]
	public unsafe static bool assign_7mvy2m(void* @this, [NativeType("class lzham::raw_quasi_adaptive_huffman_data_model const &")] void* rhs)
	{
		bool result;
		try
		{
			result = AssetRipper.Conversions.Lzham.GlobalFunctions.assign_7mvy2m.Invoke(@this, rhs);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
		return result;
	}

	[MangledName("??4?$vector@G@lzham@@QEAAAEAV01@AEBV01@@Z")]
	[DemangledName("public: class lzham::vector<unsigned short> & __cdecl lzham::vector<unsigned short>::operator=(class lzham::vector<unsigned short> const &)")]
	[return: NativeType("class lzham::vector<unsigned short> &")]
	public unsafe static void* vector_unsigned_short_Assignment(void* @this, [NativeType("class lzham::vector<unsigned short> const &")] void* other)
	{
		void* result;
		try
		{
			result = AssetRipper.Conversions.Lzham.GlobalFunctions.vector_unsigned_short_Assignment.Invoke(@this, other);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
		return result;
	}

	[MangledName("??4?$vector@E@lzham@@QEAAAEAV01@AEBV01@@Z")]
	[DemangledName("public: class lzham::vector<unsigned char> & __cdecl lzham::vector<unsigned char>::operator=(class lzham::vector<unsigned char> const &)")]
	[return: NativeType("class lzham::vector<unsigned char> &")]
	public unsafe static void* vector_unsigned_char_Assignment(void* @this, [NativeType("class lzham::vector<unsigned char> const &")] void* other)
	{
		void* result;
		try
		{
			result = AssetRipper.Conversions.Lzham.GlobalFunctions.vector_unsigned_char_Assignment.Invoke(@this, other);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
		return result;
	}

	[MangledName("?assign@decoder_tables@prefix_coding@lzham@@QEAA_NAEBV123@@Z")]
	[DemangledName("public: bool __cdecl lzham::prefix_coding::decoder_tables::assign(class lzham::prefix_coding::decoder_tables const &)")]
	[CleanName("assign")]
	[return: NativeType("bool")]
	public unsafe static bool assign_e8jmuj(void* @this, [NativeType("class lzham::prefix_coding::decoder_tables const &")] void* rhs)
	{
		bool result;
		try
		{
			result = AssetRipper.Conversions.Lzham.GlobalFunctions.assign_e8jmuj.Invoke(@this, rhs);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
		return result;
	}

	[MangledName("??$lzham_new@Vdecoder_tables@prefix_coding@lzham@@V123@@lzham@@YAPEAVdecoder_tables@prefix_coding@0@AEBV120@@Z")]
	[DemangledName("class lzham::prefix_coding::decoder_tables * __cdecl lzham::lzham_new<class lzham::prefix_coding::decoder_tables, class lzham::prefix_coding::decoder_tables>(class lzham::prefix_coding::decoder_tables const &)")]
	[CleanName("lzham_new")]
	[return: NativeType("class lzham::prefix_coding::decoder_tables *")]
	public unsafe static void* lzham_new_qv8q5m([NativeType("class lzham::prefix_coding::decoder_tables const &")] void* init0)
	{
		void* result;
		try
		{
			result = AssetRipper.Conversions.Lzham.GlobalFunctions.lzham_new_qv8q5m.Invoke(init0);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
		return result;
	}

	[MangledName("??0decoder_tables@prefix_coding@lzham@@QEAA@AEBV012@@Z")]
	[DemangledName("public: __cdecl lzham::prefix_coding::decoder_tables::decoder_tables(class lzham::prefix_coding::decoder_tables const &)")]
	[CleanName("decoder_tables_Constructor")]
	public unsafe static void* decoder_tables_Constructor_dr2jyt(void* @this, [NativeType("class lzham::prefix_coding::decoder_tables const &")] void* other)
	{
		void* result;
		try
		{
			result = AssetRipper.Conversions.Lzham.GlobalFunctions.decoder_tables_Constructor_dr2jyt.Invoke(@this, other);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
		return result;
	}

	[MangledName("??4decoder_tables@prefix_coding@lzham@@QEAAAEAV012@AEBV012@@Z")]
	[DemangledName("public: class lzham::prefix_coding::decoder_tables & __cdecl lzham::prefix_coding::decoder_tables::operator=(class lzham::prefix_coding::decoder_tables const &)")]
	[return: NativeType("class lzham::prefix_coding::decoder_tables &")]
	public unsafe static void* decoder_tables_Assignment(void* @this, [NativeType("class lzham::prefix_coding::decoder_tables const &")] void* rhs)
	{
		void* result;
		try
		{
			result = AssetRipper.Conversions.Lzham.GlobalFunctions.decoder_tables_Assignment.Invoke(@this, rhs);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
		return result;
	}

	[MangledName("??1raw_quasi_adaptive_huffman_data_model@lzham@@QEAA@XZ")]
	[DemangledName("public: __cdecl lzham::raw_quasi_adaptive_huffman_data_model::~raw_quasi_adaptive_huffman_data_model(void)")]
	public unsafe static void raw_quasi_adaptive_huffman_data_model_Destructor(void* @this)
	{
		try
		{
			AssetRipper.Conversions.Lzham.GlobalFunctions.raw_quasi_adaptive_huffman_data_model_Destructor.Invoke(@this);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
	}

	[MangledName("?reset_update_rate@raw_quasi_adaptive_huffman_data_model@lzham@@QEAAXXZ")]
	[DemangledName("public: void __cdecl lzham::raw_quasi_adaptive_huffman_data_model::reset_update_rate(void)")]
	[CleanName("reset_update_rate")]
	[return: NativeType("void")]
	public unsafe static void reset_update_rate_r8jzfi(void* @this)
	{
		AssetRipper.Conversions.Lzham.GlobalFunctions.reset_update_rate_r8jzfi.Invoke(@this);
	}

	[MangledName("?update_sym@raw_quasi_adaptive_huffman_data_model@lzham@@QEAA_NI@Z")]
	[DemangledName("public: bool __cdecl lzham::raw_quasi_adaptive_huffman_data_model::update_sym(unsigned int)")]
	[return: NativeType("bool")]
	public unsafe static bool update_sym(void* @this, [NativeType("unsigned int")] int sym)
	{
		bool result;
		try
		{
			result = AssetRipper.Conversions.Lzham.GlobalFunctions.update_sym.Invoke(@this, sym);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
		return result;
	}

	[MangledName("??0adaptive_bit_model@lzham@@QEAA@M@Z")]
	[DemangledName("public: __cdecl lzham::adaptive_bit_model::adaptive_bit_model(float)")]
	[CleanName("adaptive_bit_model_Constructor")]
	public unsafe static void* adaptive_bit_model_Constructor_h22wzd(void* @this, [NativeType("float")] float prob0)
	{
		return AssetRipper.Conversions.Lzham.GlobalFunctions.adaptive_bit_model_Constructor_h22wzd.Invoke(@this, prob0);
	}

	[MangledName("?set_probability_0@adaptive_bit_model@lzham@@QEAAXM@Z")]
	[DemangledName("public: void __cdecl lzham::adaptive_bit_model::set_probability_0(float)")]
	[return: NativeType("void")]
	public unsafe static void Set_probability_0(void* @this, [NativeType("float")] float prob0)
	{
		AssetRipper.Conversions.Lzham.GlobalFunctions.Set_probability_0.Invoke(@this, prob0);
	}

	[MangledName("??0adaptive_bit_model@lzham@@QEAA@AEBV01@@Z")]
	[DemangledName("public: __cdecl lzham::adaptive_bit_model::adaptive_bit_model(class lzham::adaptive_bit_model const &)")]
	[CleanName("adaptive_bit_model_Constructor")]
	public unsafe static void* adaptive_bit_model_Constructor_m7bfzj(void* @this, [NativeType("class lzham::adaptive_bit_model const &")] void* other)
	{
		return AssetRipper.Conversions.Lzham.GlobalFunctions.adaptive_bit_model_Constructor_m7bfzj.Invoke(@this, other);
	}

	[MangledName("??0adaptive_arith_data_model@lzham@@QEAA@_NI@Z")]
	[DemangledName("public: __cdecl lzham::adaptive_arith_data_model::adaptive_arith_data_model(bool, unsigned int)")]
	[CleanName("adaptive_arith_data_model_Constructor")]
	public unsafe static void* adaptive_arith_data_model_Constructor_qhe94u(void* @this, [NativeType("bool")] bool encoding, [NativeType("unsigned int")] int total_syms)
	{
		void* result;
		try
		{
			result = AssetRipper.Conversions.Lzham.GlobalFunctions.adaptive_arith_data_model_Constructor_qhe94u.Invoke(@this, encoding, total_syms);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
		return result;
	}

	[MangledName("??0?$vector@Vadaptive_bit_model@lzham@@@lzham@@QEAA@XZ")]
	[DemangledName("public: __cdecl lzham::vector<class lzham::adaptive_bit_model>::vector<class lzham::adaptive_bit_model>(void)")]
	public unsafe static void* vector_class_lzham_adaptive_bit_model_Constructor(void* @this)
	{
		return AssetRipper.Conversions.Lzham.GlobalFunctions.vector_class_lzham_adaptive_bit_model_Constructor.Invoke(@this);
	}

	[MangledName("?init@adaptive_arith_data_model@lzham@@QEAA_N_NI@Z")]
	[DemangledName("public: bool __cdecl lzham::adaptive_arith_data_model::init(bool, unsigned int)")]
	[CleanName("init")]
	[return: NativeType("bool")]
	public unsafe static bool init_fxxkt6(void* @this, [NativeType("bool")] bool encoding, [NativeType("unsigned int")] int total_syms)
	{
		bool result;
		try
		{
			result = AssetRipper.Conversions.Lzham.GlobalFunctions.init_fxxkt6.Invoke(@this, encoding, total_syms);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
		return result;
	}

	[MangledName("??1?$vector@Vadaptive_bit_model@lzham@@@lzham@@QEAA@XZ")]
	[DemangledName("public: __cdecl lzham::vector<class lzham::adaptive_bit_model>::~vector<class lzham::adaptive_bit_model>(void)")]
	public unsafe static void vector_class_lzham_adaptive_bit_model_Destructor(void* @this)
	{
		try
		{
			AssetRipper.Conversions.Lzham.GlobalFunctions.vector_class_lzham_adaptive_bit_model_Destructor.Invoke(@this);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
	}

	[MangledName("?destruct_array@?$scalar_type@Vadaptive_bit_model@lzham@@@lzham@@SAXPEAVadaptive_bit_model@2@I@Z")]
	[DemangledName("public: static void __cdecl lzham::scalar_type<class lzham::adaptive_bit_model>::destruct_array(class lzham::adaptive_bit_model *, unsigned int)")]
	[CleanName("destruct_array")]
	[return: NativeType("void")]
	public unsafe static void destruct_array_dwzwyb([NativeType("class lzham::adaptive_bit_model *")] void* p, [NativeType("unsigned int")] int n)
	{
		AssetRipper.Conversions.Lzham.GlobalFunctions.destruct_array_dwzwyb.Invoke(p, n);
	}

	[MangledName("??$destruct_array@Vadaptive_bit_model@lzham@@@helpers@lzham@@YAXPEAVadaptive_bit_model@1@I@Z")]
	[DemangledName("void __cdecl lzham::helpers::destruct_array<class lzham::adaptive_bit_model>(class lzham::adaptive_bit_model *, unsigned int)")]
	[CleanName("destruct_array")]
	[return: NativeType("void")]
	public unsafe static void destruct_array_6r6fjb([NativeType("class lzham::adaptive_bit_model *")] void* p, [NativeType("unsigned int")] int n)
	{
		AssetRipper.Conversions.Lzham.GlobalFunctions.destruct_array_6r6fjb.Invoke(p, n);
	}

	[MangledName("?clear@adaptive_arith_data_model@lzham@@QEAAXXZ")]
	[DemangledName("public: void __cdecl lzham::adaptive_arith_data_model::clear(void)")]
	[CleanName("clear")]
	[return: NativeType("void")]
	public unsafe static void clear_3kmniu(void* @this)
	{
		try
		{
			AssetRipper.Conversions.Lzham.GlobalFunctions.clear_3kmniu.Invoke(@this);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
	}

	[MangledName("?try_resize@?$vector@Vadaptive_bit_model@lzham@@@lzham@@QEAA_NI_N@Z")]
	[DemangledName("public: bool __cdecl lzham::vector<class lzham::adaptive_bit_model>::try_resize(unsigned int, bool)")]
	[CleanName("try_resize")]
	[return: NativeType("bool")]
	public unsafe static bool try_resize_dw23aw(void* @this, [NativeType("unsigned int")] int new_size, [NativeType("bool")] bool grow_hint)
	{
		bool result;
		try
		{
			result = AssetRipper.Conversions.Lzham.GlobalFunctions.try_resize_dw23aw.Invoke(@this, new_size, grow_hint);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
		return result;
	}

	[MangledName("?increase_capacity@?$vector@Vadaptive_bit_model@lzham@@@lzham@@AEAA_NI_N0@Z")]
	[DemangledName("private: bool __cdecl lzham::vector<class lzham::adaptive_bit_model>::increase_capacity(unsigned int, bool, bool)")]
	[CleanName("increase_capacity")]
	[return: NativeType("bool")]
	public unsafe static bool increase_capacity_ggkcfn(void* @this, [NativeType("unsigned int")] int min_new_capacity, [NativeType("bool")] bool grow_hint, [NativeType("bool")] bool nofail)
	{
		bool result;
		try
		{
			result = AssetRipper.Conversions.Lzham.GlobalFunctions.increase_capacity_ggkcfn.Invoke(@this, min_new_capacity, grow_hint, nofail);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
		return result;
	}

	[MangledName("?construct_array@?$scalar_type@Vadaptive_bit_model@lzham@@@lzham@@SAXPEAVadaptive_bit_model@2@I@Z")]
	[DemangledName("public: static void __cdecl lzham::scalar_type<class lzham::adaptive_bit_model>::construct_array(class lzham::adaptive_bit_model *, unsigned int)")]
	[CleanName("construct_array")]
	[return: NativeType("void")]
	public unsafe static void construct_array_3x49nx([NativeType("class lzham::adaptive_bit_model *")] void* p, [NativeType("unsigned int")] int n)
	{
		AssetRipper.Conversions.Lzham.GlobalFunctions.construct_array_3x49nx.Invoke(p, n);
	}

	[MangledName("??$construct_array@Vadaptive_bit_model@lzham@@@helpers@lzham@@YAXPEAVadaptive_bit_model@1@I@Z")]
	[DemangledName("void __cdecl lzham::helpers::construct_array<class lzham::adaptive_bit_model>(class lzham::adaptive_bit_model *, unsigned int)")]
	[CleanName("construct_array")]
	[return: NativeType("void")]
	public unsafe static void construct_array_auatq4([NativeType("class lzham::adaptive_bit_model *")] void* p, [NativeType("unsigned int")] int n)
	{
		AssetRipper.Conversions.Lzham.GlobalFunctions.construct_array_auatq4.Invoke(p, n);
	}

	[MangledName("?object_mover@?$vector@Vadaptive_bit_model@lzham@@@lzham@@CAXPEAX0I@Z")]
	[DemangledName("private: static void __cdecl lzham::vector<class lzham::adaptive_bit_model>::object_mover(void *, void *, unsigned int)")]
	[CleanName("object_mover")]
	[return: NativeType("void")]
	public unsafe static void object_mover_2wbuit([NativeType("void *")] void* pDst_void, [NativeType("void *")] void* pSrc_void, [NativeType("unsigned int")] int num)
	{
		AssetRipper.Conversions.Lzham.GlobalFunctions.object_mover_2wbuit.Invoke(pDst_void, pSrc_void, num);
	}

	[MangledName("?clear@?$vector@Vadaptive_bit_model@lzham@@@lzham@@QEAAXXZ")]
	[DemangledName("public: void __cdecl lzham::vector<class lzham::adaptive_bit_model>::clear(void)")]
	[CleanName("clear")]
	[return: NativeType("void")]
	public unsafe static void clear_hqamxp(void* @this)
	{
		try
		{
			AssetRipper.Conversions.Lzham.GlobalFunctions.clear_hqamxp.Invoke(@this);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
	}

	[MangledName("??0adaptive_arith_data_model@lzham@@QEAA@AEBV01@@Z")]
	[DemangledName("public: __cdecl lzham::adaptive_arith_data_model::adaptive_arith_data_model(class lzham::adaptive_arith_data_model const &)")]
	[CleanName("adaptive_arith_data_model_Constructor")]
	public unsafe static void* adaptive_arith_data_model_Constructor_fgzdb4(void* @this, [NativeType("class lzham::adaptive_arith_data_model const &")] void* other)
	{
		void* result;
		try
		{
			result = AssetRipper.Conversions.Lzham.GlobalFunctions.adaptive_arith_data_model_Constructor_fgzdb4.Invoke(@this, other);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
		return result;
	}

	[MangledName("??4?$vector@Vadaptive_bit_model@lzham@@@lzham@@QEAAAEAV01@AEBV01@@Z")]
	[DemangledName("public: class lzham::vector<class lzham::adaptive_bit_model> & __cdecl lzham::vector<class lzham::adaptive_bit_model>::operator=(class lzham::vector<class lzham::adaptive_bit_model> const &)")]
	[return: NativeType("class lzham::vector<class lzham::adaptive_bit_model> &")]
	public unsafe static void* vector_class_lzham_adaptive_bit_model_Assignment(void* @this, [NativeType("class lzham::vector<class lzham::adaptive_bit_model> const &")] void* other)
	{
		void* result;
		try
		{
			result = AssetRipper.Conversions.Lzham.GlobalFunctions.vector_class_lzham_adaptive_bit_model_Assignment.Invoke(@this, other);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
		return result;
	}

	[MangledName("??$construct@Vadaptive_bit_model@lzham@@V12@@helpers@lzham@@YAPEAVadaptive_bit_model@1@PEAV21@AEBV21@@Z")]
	[DemangledName("class lzham::adaptive_bit_model * __cdecl lzham::helpers::construct<class lzham::adaptive_bit_model, class lzham::adaptive_bit_model>(class lzham::adaptive_bit_model *, class lzham::adaptive_bit_model const &)")]
	[CleanName("construct")]
	[return: NativeType("class lzham::adaptive_bit_model *")]
	public unsafe static void* construct_nx5w3v([NativeType("class lzham::adaptive_bit_model *")] void* p, [NativeType("class lzham::adaptive_bit_model const &")] void* init)
	{
		return AssetRipper.Conversions.Lzham.GlobalFunctions.construct_nx5w3v.Invoke(p, init);
	}

	[MangledName("??1adaptive_arith_data_model@lzham@@QEAA@XZ")]
	[DemangledName("public: __cdecl lzham::adaptive_arith_data_model::~adaptive_arith_data_model(void)")]
	public unsafe static void adaptive_arith_data_model_Destructor(void* @this)
	{
		try
		{
			AssetRipper.Conversions.Lzham.GlobalFunctions.adaptive_arith_data_model_Destructor.Invoke(@this);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
	}

	[MangledName("??4adaptive_arith_data_model@lzham@@QEAAAEAV01@AEBV01@@Z")]
	[DemangledName("public: class lzham::adaptive_arith_data_model & __cdecl lzham::adaptive_arith_data_model::operator=(class lzham::adaptive_arith_data_model const &)")]
	[return: NativeType("class lzham::adaptive_arith_data_model &")]
	public unsafe static void* adaptive_arith_data_model_Assignment(void* @this, [NativeType("class lzham::adaptive_arith_data_model const &")] void* rhs)
	{
		void* result;
		try
		{
			result = AssetRipper.Conversions.Lzham.GlobalFunctions.adaptive_arith_data_model_Assignment.Invoke(@this, rhs);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
		return result;
	}

	[MangledName("?reset@adaptive_arith_data_model@lzham@@QEAAXXZ")]
	[DemangledName("public: void __cdecl lzham::adaptive_arith_data_model::reset(void)")]
	[CleanName("reset")]
	[return: NativeType("void")]
	public unsafe static void reset_7s26kf(void* @this)
	{
		AssetRipper.Conversions.Lzham.GlobalFunctions.reset_7s26kf.Invoke(@this);
	}

	[MangledName("?size@?$vector@Vadaptive_bit_model@lzham@@@lzham@@QEBAIXZ")]
	[DemangledName("public: unsigned int __cdecl lzham::vector<class lzham::adaptive_bit_model>::size(void) const")]
	[CleanName("size")]
	[return: NativeType("unsigned int")]
	public unsafe static int size_eeqcx3(void* @this)
	{
		return AssetRipper.Conversions.Lzham.GlobalFunctions.size_eeqcx3.Invoke(@this);
	}

	[MangledName("??A?$vector@Vadaptive_bit_model@lzham@@@lzham@@QEAAAEAVadaptive_bit_model@1@I@Z")]
	[DemangledName("public: class lzham::adaptive_bit_model & __cdecl lzham::vector<class lzham::adaptive_bit_model>::operator[](unsigned int)")]
	[CleanName("vector_class_lzham_adaptive_bit_model_Operator")]
	[return: NativeType("class lzham::adaptive_bit_model &")]
	public unsafe static void* vector_class_lzham_adaptive_bit_model_Operator_he3z72(void* @this, [NativeType("unsigned int")] int i)
	{
		return AssetRipper.Conversions.Lzham.GlobalFunctions.vector_class_lzham_adaptive_bit_model_Operator_he3z72.Invoke(@this, i);
	}

	[MangledName("?reset_update_rate@adaptive_arith_data_model@lzham@@QEAAXXZ")]
	[DemangledName("public: void __cdecl lzham::adaptive_arith_data_model::reset_update_rate(void)")]
	[CleanName("reset_update_rate")]
	[return: NativeType("void")]
	public unsafe static void reset_update_rate_zi5hjc(void* @this)
	{
		AssetRipper.Conversions.Lzham.GlobalFunctions.reset_update_rate_zi5hjc.Invoke(@this);
	}

	[MangledName("?update@adaptive_arith_data_model@lzham@@QEAA_NI@Z")]
	[DemangledName("public: bool __cdecl lzham::adaptive_arith_data_model::update(unsigned int)")]
	[CleanName("update")]
	[return: NativeType("bool")]
	public unsafe static bool update_ejigwt(void* @this, [NativeType("unsigned int")] int sym)
	{
		return AssetRipper.Conversions.Lzham.GlobalFunctions.update_ejigwt.Invoke(@this, sym);
	}

	[MangledName("?update@adaptive_bit_model@lzham@@QEAAXI@Z")]
	[DemangledName("public: void __cdecl lzham::adaptive_bit_model::update(unsigned int)")]
	[CleanName("update")]
	[return: NativeType("void")]
	public unsafe static void update_yyeigq(void* @this, [NativeType("unsigned int")] int bit)
	{
		AssetRipper.Conversions.Lzham.GlobalFunctions.update_yyeigq.Invoke(@this, bit);
	}

	[MangledName("?get_cost@adaptive_arith_data_model@lzham@@QEBA_KI@Z")]
	[DemangledName("public: unsigned __int64 __cdecl lzham::adaptive_arith_data_model::get_cost(unsigned int) const")]
	[CleanName("Get_cost")]
	[return: NativeType("unsigned __int64")]
	public unsafe static long Get_cost_azkx9x(void* @this, [NativeType("unsigned int")] int sym)
	{
		return AssetRipper.Conversions.Lzham.GlobalFunctions.Get_cost_azkx9x.Invoke(@this, sym);
	}

	[MangledName("??A?$vector@Vadaptive_bit_model@lzham@@@lzham@@QEBAAEBVadaptive_bit_model@1@I@Z")]
	[DemangledName("public: class lzham::adaptive_bit_model const & __cdecl lzham::vector<class lzham::adaptive_bit_model>::operator[](unsigned int) const")]
	[CleanName("vector_class_lzham_adaptive_bit_model_Operator")]
	[return: NativeType("class lzham::adaptive_bit_model const &")]
	public unsafe static void* vector_class_lzham_adaptive_bit_model_Operator_jj2txr(void* @this, [NativeType("unsigned int")] int i)
	{
		return AssetRipper.Conversions.Lzham.GlobalFunctions.vector_class_lzham_adaptive_bit_model_Operator_jj2txr.Invoke(@this, i);
	}

	[MangledName("?get_cost@adaptive_bit_model@lzham@@QEBA_KI@Z")]
	[DemangledName("public: unsigned __int64 __cdecl lzham::adaptive_bit_model::get_cost(unsigned int) const")]
	[CleanName("Get_cost")]
	[return: NativeType("unsigned __int64")]
	public unsafe static long Get_cost_2mqzjn(void* @this, [NativeType("unsigned int")] int bit)
	{
		return AssetRipper.Conversions.Lzham.GlobalFunctions.Get_cost_2mqzjn.Invoke(@this, bit);
	}

	[MangledName("??0symbol_codec@lzham@@QEAA@XZ")]
	[DemangledName("public: __cdecl lzham::symbol_codec::symbol_codec(void)")]
	public unsafe static void* symbol_codec_Constructor(void* @this)
	{
		void* result;
		try
		{
			result = AssetRipper.Conversions.Lzham.GlobalFunctions.symbol_codec_Constructor.Invoke(@this);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
		return result;
	}

	[MangledName("??0?$vector@Uoutput_symbol@symbol_codec@lzham@@@lzham@@QEAA@XZ")]
	[DemangledName("public: __cdecl lzham::vector<struct lzham::symbol_codec::output_symbol>::vector<struct lzham::symbol_codec::output_symbol>(void)")]
	public unsafe static void* vector_struct_lzham_symbol_codec_output_symbol_Constructor(void* @this)
	{
		return AssetRipper.Conversions.Lzham.GlobalFunctions.vector_struct_lzham_symbol_codec_output_symbol_Constructor.Invoke(@this);
	}

	[MangledName("?clear@symbol_codec@lzham@@QEAAXXZ")]
	[DemangledName("public: void __cdecl lzham::symbol_codec::clear(void)")]
	[CleanName("clear")]
	[return: NativeType("void")]
	public unsafe static void clear_sksy5s(void* @this)
	{
		try
		{
			AssetRipper.Conversions.Lzham.GlobalFunctions.clear_sksy5s.Invoke(@this);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
	}

	[MangledName("?reset@symbol_codec@lzham@@QEAAXXZ")]
	[DemangledName("public: void __cdecl lzham::symbol_codec::reset(void)")]
	[CleanName("reset")]
	[return: NativeType("void")]
	public unsafe static void reset_jag9x3(void* @this)
	{
		try
		{
			AssetRipper.Conversions.Lzham.GlobalFunctions.reset_jag9x3.Invoke(@this);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
	}

	[MangledName("?clear@?$vector@Uoutput_symbol@symbol_codec@lzham@@@lzham@@QEAAXXZ")]
	[DemangledName("public: void __cdecl lzham::vector<struct lzham::symbol_codec::output_symbol>::clear(void)")]
	[CleanName("clear")]
	[return: NativeType("void")]
	public unsafe static void clear_rvrac9(void* @this)
	{
		try
		{
			AssetRipper.Conversions.Lzham.GlobalFunctions.clear_rvrac9.Invoke(@this);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
	}

	[MangledName("?try_resize@?$vector@Uoutput_symbol@symbol_codec@lzham@@@lzham@@QEAA_NI_N@Z")]
	[DemangledName("public: bool __cdecl lzham::vector<struct lzham::symbol_codec::output_symbol>::try_resize(unsigned int, bool)")]
	[CleanName("try_resize")]
	[return: NativeType("bool")]
	public unsafe static bool try_resize_tzyfr4(void* @this, [NativeType("unsigned int")] int new_size, [NativeType("bool")] bool grow_hint)
	{
		bool result;
		try
		{
			result = AssetRipper.Conversions.Lzham.GlobalFunctions.try_resize_tzyfr4.Invoke(@this, new_size, grow_hint);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
		return result;
	}

	[MangledName("?increase_capacity@?$vector@Uoutput_symbol@symbol_codec@lzham@@@lzham@@AEAA_NI_N0@Z")]
	[DemangledName("private: bool __cdecl lzham::vector<struct lzham::symbol_codec::output_symbol>::increase_capacity(unsigned int, bool, bool)")]
	[CleanName("increase_capacity")]
	[return: NativeType("bool")]
	public unsafe static bool increase_capacity_8hubbd(void* @this, [NativeType("unsigned int")] int min_new_capacity, [NativeType("bool")] bool grow_hint, [NativeType("bool")] bool nofail)
	{
		bool result;
		try
		{
			result = AssetRipper.Conversions.Lzham.GlobalFunctions.increase_capacity_8hubbd.Invoke(@this, min_new_capacity, grow_hint, nofail);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
		return result;
	}

	[MangledName("?construct_array@?$scalar_type@Uoutput_symbol@symbol_codec@lzham@@@lzham@@SAXPEAUoutput_symbol@symbol_codec@2@I@Z")]
	[DemangledName("public: static void __cdecl lzham::scalar_type<struct lzham::symbol_codec::output_symbol>::construct_array(struct lzham::symbol_codec::output_symbol *, unsigned int)")]
	[CleanName("construct_array")]
	[return: NativeType("void")]
	public unsafe static void construct_array_q5zph8([NativeType("struct lzham::symbol_codec::output_symbol *")] void* p, [NativeType("unsigned int")] int n)
	{
		AssetRipper.Conversions.Lzham.GlobalFunctions.construct_array_q5zph8.Invoke(p, n);
	}

	[MangledName("??$construct_array@Uoutput_symbol@symbol_codec@lzham@@@helpers@lzham@@YAXPEAUoutput_symbol@symbol_codec@1@I@Z")]
	[DemangledName("void __cdecl lzham::helpers::construct_array<struct lzham::symbol_codec::output_symbol>(struct lzham::symbol_codec::output_symbol *, unsigned int)")]
	[CleanName("construct_array")]
	[return: NativeType("void")]
	public unsafe static void construct_array_wenq3b([NativeType("struct lzham::symbol_codec::output_symbol *")] void* p, [NativeType("unsigned int")] int n)
	{
		AssetRipper.Conversions.Lzham.GlobalFunctions.construct_array_wenq3b.Invoke(p, n);
	}

	[MangledName("?start_encoding@symbol_codec@lzham@@QEAA_NI@Z")]
	[DemangledName("public: bool __cdecl lzham::symbol_codec::start_encoding(unsigned int)")]
	[return: NativeType("bool")]
	public unsafe static bool start_encoding(void* @this, [NativeType("unsigned int")] int expected_file_size)
	{
		bool result;
		try
		{
			result = AssetRipper.Conversions.Lzham.GlobalFunctions.start_encoding.Invoke(@this, expected_file_size);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
		return result;
	}

	[MangledName("?put_bits_init@symbol_codec@lzham@@QEAA_NI@Z")]
	[DemangledName("public: bool __cdecl lzham::symbol_codec::put_bits_init(unsigned int)")]
	[return: NativeType("bool")]
	public unsafe static bool put_bits_init(void* @this, [NativeType("unsigned int")] int expected_size)
	{
		bool result;
		try
		{
			result = AssetRipper.Conversions.Lzham.GlobalFunctions.put_bits_init.Invoke(@this, expected_size);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
		return result;
	}

	[MangledName("?arith_start_encoding@symbol_codec@lzham@@QEAAXXZ")]
	[DemangledName("public: void __cdecl lzham::symbol_codec::arith_start_encoding(void)")]
	[return: NativeType("void")]
	public unsafe static void arith_start_encoding(void* @this)
	{
		try
		{
			AssetRipper.Conversions.Lzham.GlobalFunctions.arith_start_encoding.Invoke(@this);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
	}

	[MangledName("?try_reserve@?$vector@E@lzham@@QEAA_NI@Z")]
	[DemangledName("public: bool __cdecl lzham::vector<unsigned char>::try_reserve(unsigned int)")]
	[CleanName("try_reserve")]
	[return: NativeType("bool")]
	public unsafe static bool try_reserve_cnc229(void* @this, [NativeType("unsigned int")] int new_capacity)
	{
		bool result;
		try
		{
			result = AssetRipper.Conversions.Lzham.GlobalFunctions.try_reserve_cnc229.Invoke(@this, new_capacity);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
		return result;
	}

	[MangledName("?encode_bits@symbol_codec@lzham@@QEAA_NII@Z")]
	[DemangledName("public: bool __cdecl lzham::symbol_codec::encode_bits(unsigned int, unsigned int)")]
	[return: NativeType("bool")]
	public unsafe static bool encode_bits(void* @this, [NativeType("unsigned int")] int bits, [NativeType("unsigned int")] int num_bits)
	{
		bool result;
		try
		{
			result = AssetRipper.Conversions.Lzham.GlobalFunctions.encode_bits.Invoke(@this, bits, num_bits);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
		return result;
	}

	[MangledName("?record_put_bits@symbol_codec@lzham@@QEAA_NII@Z")]
	[DemangledName("public: bool __cdecl lzham::symbol_codec::record_put_bits(unsigned int, unsigned int)")]
	[return: NativeType("bool")]
	public unsafe static bool record_put_bits(void* @this, [NativeType("unsigned int")] int bits, [NativeType("unsigned int")] int num_bits)
	{
		bool result;
		try
		{
			result = AssetRipper.Conversions.Lzham.GlobalFunctions.record_put_bits.Invoke(@this, bits, num_bits);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
		return result;
	}

	[MangledName("?try_push_back@?$vector@Uoutput_symbol@symbol_codec@lzham@@@lzham@@QEAA_NAEBUoutput_symbol@symbol_codec@2@@Z")]
	[DemangledName("public: bool __cdecl lzham::vector<struct lzham::symbol_codec::output_symbol>::try_push_back(struct lzham::symbol_codec::output_symbol const &)")]
	[CleanName("try_push_back")]
	[return: NativeType("bool")]
	public unsafe static bool try_push_back_wrcwgy(void* @this, [NativeType("struct lzham::symbol_codec::output_symbol const &")] void* obj)
	{
		bool result;
		try
		{
			result = AssetRipper.Conversions.Lzham.GlobalFunctions.try_push_back_wrcwgy.Invoke(@this, obj);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
		return result;
	}

	[MangledName("?construct@?$scalar_type@Uoutput_symbol@symbol_codec@lzham@@@lzham@@SAXPEAUoutput_symbol@symbol_codec@2@AEBU342@@Z")]
	[DemangledName("public: static void __cdecl lzham::scalar_type<struct lzham::symbol_codec::output_symbol>::construct(struct lzham::symbol_codec::output_symbol *, struct lzham::symbol_codec::output_symbol const &)")]
	[CleanName("construct")]
	[return: NativeType("void")]
	public unsafe static void construct_vpnrgd([NativeType("struct lzham::symbol_codec::output_symbol *")] void* p, [NativeType("struct lzham::symbol_codec::output_symbol const &")] void* init)
	{
		AssetRipper.Conversions.Lzham.GlobalFunctions.construct_vpnrgd.Invoke(p, init);
	}

	[MangledName("??$construct@Uoutput_symbol@symbol_codec@lzham@@U123@@helpers@lzham@@YAPEAUoutput_symbol@symbol_codec@1@PEAU231@AEBU231@@Z")]
	[DemangledName("struct lzham::symbol_codec::output_symbol * __cdecl lzham::helpers::construct<struct lzham::symbol_codec::output_symbol, struct lzham::symbol_codec::output_symbol>(struct lzham::symbol_codec::output_symbol *, struct lzham::symbol_codec::output_symbol const &)")]
	[CleanName("construct")]
	[return: NativeType("struct lzham::symbol_codec::output_symbol *")]
	public unsafe static void* construct_7whkt4([NativeType("struct lzham::symbol_codec::output_symbol *")] void* p, [NativeType("struct lzham::symbol_codec::output_symbol const &")] void* init)
	{
		return AssetRipper.Conversions.Lzham.GlobalFunctions.construct_7whkt4.Invoke(p, init);
	}

	[MangledName("?encode_arith_init@symbol_codec@lzham@@QEAA_NXZ")]
	[DemangledName("public: bool __cdecl lzham::symbol_codec::encode_arith_init(void)")]
	[return: NativeType("bool")]
	public unsafe static bool encode_arith_init(void* @this)
	{
		bool result;
		try
		{
			result = AssetRipper.Conversions.Lzham.GlobalFunctions.encode_arith_init.Invoke(@this);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
		return result;
	}

	[MangledName("?encode_align_to_byte@symbol_codec@lzham@@QEAA_NXZ")]
	[DemangledName("public: bool __cdecl lzham::symbol_codec::encode_align_to_byte(void)")]
	[return: NativeType("bool")]
	public unsafe static bool encode_align_to_byte(void* @this)
	{
		bool result;
		try
		{
			result = AssetRipper.Conversions.Lzham.GlobalFunctions.encode_align_to_byte.Invoke(@this);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
		return result;
	}

	[MangledName("?encode@symbol_codec@lzham@@QEAA_NIAEAUquasi_adaptive_huffman_data_model@2@@Z")]
	[DemangledName("public: bool __cdecl lzham::symbol_codec::encode(unsigned int, struct lzham::quasi_adaptive_huffman_data_model &)")]
	[CleanName("encode")]
	[return: NativeType("bool")]
	public unsafe static bool encode_gbd3f5(void* @this, [NativeType("unsigned int")] int sym, [NativeType("struct lzham::quasi_adaptive_huffman_data_model &")] void* model)
	{
		bool result;
		try
		{
			result = AssetRipper.Conversions.Lzham.GlobalFunctions.encode_gbd3f5.Invoke(@this, sym, model);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
		return result;
	}

	[MangledName("?arith_propagate_carry@symbol_codec@lzham@@QEAAXXZ")]
	[DemangledName("public: void __cdecl lzham::symbol_codec::arith_propagate_carry(void)")]
	[return: NativeType("void")]
	public unsafe static void arith_propagate_carry(void* @this)
	{
		AssetRipper.Conversions.Lzham.GlobalFunctions.arith_propagate_carry.Invoke(@this);
	}

	[MangledName("?size@?$vector@E@lzham@@QEBAIXZ")]
	[DemangledName("public: unsigned int __cdecl lzham::vector<unsigned char>::size(void) const")]
	[CleanName("size")]
	[return: NativeType("unsigned int")]
	public unsafe static int size_s5xcpk(void* @this)
	{
		return AssetRipper.Conversions.Lzham.GlobalFunctions.size_s5xcpk.Invoke(@this);
	}

	[MangledName("?arith_renorm_enc_interval@symbol_codec@lzham@@QEAA_NXZ")]
	[DemangledName("public: bool __cdecl lzham::symbol_codec::arith_renorm_enc_interval(void)")]
	[return: NativeType("bool")]
	public unsafe static bool arith_renorm_enc_interval(void* @this)
	{
		bool result;
		try
		{
			result = AssetRipper.Conversions.Lzham.GlobalFunctions.arith_renorm_enc_interval.Invoke(@this);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
		return result;
	}

	[MangledName("?try_push_back@?$vector@E@lzham@@QEAA_NAEBE@Z")]
	[DemangledName("public: bool __cdecl lzham::vector<unsigned char>::try_push_back(unsigned char const &)")]
	[CleanName("try_push_back")]
	[return: NativeType("bool")]
	public unsafe static bool try_push_back_myg3iw(void* @this, [NativeType("unsigned char const &")] void* obj)
	{
		bool result;
		try
		{
			result = AssetRipper.Conversions.Lzham.GlobalFunctions.try_push_back_myg3iw.Invoke(@this, obj);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
		return result;
	}

	[MangledName("?construct@?$scalar_type@E@lzham@@SAXPEAEAEBE@Z")]
	[DemangledName("public: static void __cdecl lzham::scalar_type<unsigned char>::construct(unsigned char *, unsigned char const &)")]
	[CleanName("construct")]
	[return: NativeType("void")]
	public unsafe static void construct_ceg736([NativeType("unsigned char *")] void* p, [NativeType("unsigned char const &")] void* init)
	{
		AssetRipper.Conversions.Lzham.GlobalFunctions.construct_ceg736.Invoke(p, init);
	}

	[MangledName("?encode@symbol_codec@lzham@@QEAA_NIAEAVadaptive_bit_model@2@_N@Z")]
	[DemangledName("public: bool __cdecl lzham::symbol_codec::encode(unsigned int, class lzham::adaptive_bit_model &, bool)")]
	[CleanName("encode")]
	[return: NativeType("bool")]
	public unsafe static bool encode_ay6s5b(void* @this, [NativeType("unsigned int")] int bit, [NativeType("class lzham::adaptive_bit_model &")] void* model, [NativeType("bool")] bool update_model)
	{
		bool result;
		try
		{
			result = AssetRipper.Conversions.Lzham.GlobalFunctions.encode_ay6s5b.Invoke(@this, bit, model, update_model);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
		return result;
	}

	[MangledName("?encode@symbol_codec@lzham@@QEAA_NIAEAVadaptive_arith_data_model@2@@Z")]
	[DemangledName("public: bool __cdecl lzham::symbol_codec::encode(unsigned int, class lzham::adaptive_arith_data_model &)")]
	[CleanName("encode")]
	[return: NativeType("bool")]
	public unsafe static bool encode_gz4yug(void* @this, [NativeType("unsigned int")] int sym, [NativeType("class lzham::adaptive_arith_data_model &")] void* model)
	{
		bool result;
		try
		{
			result = AssetRipper.Conversions.Lzham.GlobalFunctions.encode_gz4yug.Invoke(@this, sym, model);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
		return result;
	}

	[MangledName("?arith_stop_encoding@symbol_codec@lzham@@QEAA_NXZ")]
	[DemangledName("public: bool __cdecl lzham::symbol_codec::arith_stop_encoding(void)")]
	[return: NativeType("bool")]
	public unsafe static bool arith_stop_encoding(void* @this)
	{
		bool result;
		try
		{
			result = AssetRipper.Conversions.Lzham.GlobalFunctions.arith_stop_encoding.Invoke(@this);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
		return result;
	}

	[MangledName("?stop_encoding@symbol_codec@lzham@@QEAA_N_N@Z")]
	[DemangledName("public: bool __cdecl lzham::symbol_codec::stop_encoding(bool)")]
	[return: NativeType("bool")]
	public unsafe static bool stop_encoding(void* @this, [NativeType("bool")] bool support_arith)
	{
		bool result;
		try
		{
			result = AssetRipper.Conversions.Lzham.GlobalFunctions.stop_encoding.Invoke(@this, support_arith);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
		return result;
	}

	[MangledName("?assemble_output_buf@symbol_codec@lzham@@QEAA_NXZ")]
	[DemangledName("public: bool __cdecl lzham::symbol_codec::assemble_output_buf(void)")]
	[return: NativeType("bool")]
	public unsafe static bool assemble_output_buf(void* @this)
	{
		bool result;
		try
		{
			result = AssetRipper.Conversions.Lzham.GlobalFunctions.assemble_output_buf.Invoke(@this);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
		return result;
	}

	[MangledName("?size@?$vector@Uoutput_symbol@symbol_codec@lzham@@@lzham@@QEBAIXZ")]
	[DemangledName("public: unsigned int __cdecl lzham::vector<struct lzham::symbol_codec::output_symbol>::size(void) const")]
	[CleanName("size")]
	[return: NativeType("unsigned int")]
	public unsafe static int size_atskx2(void* @this)
	{
		return AssetRipper.Conversions.Lzham.GlobalFunctions.size_atskx2.Invoke(@this);
	}

	[MangledName("??A?$vector@Uoutput_symbol@symbol_codec@lzham@@@lzham@@QEAAAEAUoutput_symbol@symbol_codec@1@I@Z")]
	[DemangledName("public: struct lzham::symbol_codec::output_symbol & __cdecl lzham::vector<struct lzham::symbol_codec::output_symbol>::operator[](unsigned int)")]
	[return: NativeType("struct lzham::symbol_codec::output_symbol &")]
	public unsafe static void* vector_struct_lzham_symbol_codec_output_symbol_Operator(void* @this, [NativeType("unsigned int")] int i)
	{
		return AssetRipper.Conversions.Lzham.GlobalFunctions.vector_struct_lzham_symbol_codec_output_symbol_Operator.Invoke(@this, i);
	}

	[MangledName("?put_bits_align_to_byte@symbol_codec@lzham@@QEAA_NXZ")]
	[DemangledName("public: bool __cdecl lzham::symbol_codec::put_bits_align_to_byte(void)")]
	[return: NativeType("bool")]
	public unsafe static bool put_bits_align_to_byte(void* @this)
	{
		bool result;
		try
		{
			result = AssetRipper.Conversions.Lzham.GlobalFunctions.put_bits_align_to_byte.Invoke(@this);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
		return result;
	}

	[MangledName("?put_bits@symbol_codec@lzham@@QEAA_NII@Z")]
	[DemangledName("public: bool __cdecl lzham::symbol_codec::put_bits(unsigned int, unsigned int)")]
	[return: NativeType("bool")]
	public unsafe static bool put_bits(void* @this, [NativeType("unsigned int")] int bits, [NativeType("unsigned int")] int num_bits)
	{
		bool result;
		try
		{
			result = AssetRipper.Conversions.Lzham.GlobalFunctions.put_bits.Invoke(@this, bits, num_bits);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
		return result;
	}

	[MangledName("?flush_bits@symbol_codec@lzham@@QEAA_NXZ")]
	[DemangledName("public: bool __cdecl lzham::symbol_codec::flush_bits(void)")]
	[return: NativeType("bool")]
	public unsafe static bool flush_bits(void* @this)
	{
		bool result;
		try
		{
			result = AssetRipper.Conversions.Lzham.GlobalFunctions.flush_bits.Invoke(@this);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
		return result;
	}

	[MangledName("?start_decoding@symbol_codec@lzham@@QEAA_NPEBE_K_NP6AX1PEAXAEAPEBEAEA_KAEA_N@Z3@Z")]
	[DemangledName("public: bool __cdecl lzham::symbol_codec::start_decoding(unsigned char const *, unsigned __int64, bool, void (__cdecl *)(unsigned __int64, void *, unsigned char const *&, unsigned __int64 &, bool &), void *)")]
	[return: NativeType("bool")]
	public unsafe static bool start_decoding(void* @this, [NativeType("unsigned char const *")] void* pBuf, [NativeType("unsigned __int64")] long buf_size, [NativeType("bool")] bool eof_flag, [NativeType("void (__cdecl *)(unsigned __int64, void *, unsigned char const *&, unsigned __int64 &, bool &)")] void* pNeed_bytes_func, [NativeType("void *")] void* pPrivate_data)
	{
		return AssetRipper.Conversions.Lzham.GlobalFunctions.start_decoding.Invoke(@this, pBuf, buf_size, eof_flag, pNeed_bytes_func, pPrivate_data);
	}

	[MangledName("?decode_bits@symbol_codec@lzham@@QEAAII@Z")]
	[DemangledName("public: unsigned int __cdecl lzham::symbol_codec::decode_bits(unsigned int)")]
	[return: NativeType("unsigned int")]
	public unsafe static int decode_bits(void* @this, [NativeType("unsigned int")] int num_bits)
	{
		int result;
		try
		{
			result = AssetRipper.Conversions.Lzham.GlobalFunctions.decode_bits.Invoke(@this, num_bits);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
		return result;
	}

	[MangledName("?get_bits@symbol_codec@lzham@@QEAAII@Z")]
	[DemangledName("public: unsigned int __cdecl lzham::symbol_codec::get_bits(unsigned int)")]
	[return: NativeType("unsigned int")]
	public unsafe static int Get_bits(void* @this, [NativeType("unsigned int")] int num_bits)
	{
		int result;
		try
		{
			result = AssetRipper.Conversions.Lzham.GlobalFunctions.Get_bits.Invoke(@this, num_bits);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
		return result;
	}

	[MangledName("?decode_remove_bits@symbol_codec@lzham@@QEAAXI@Z")]
	[DemangledName("public: void __cdecl lzham::symbol_codec::decode_remove_bits(unsigned int)")]
	[return: NativeType("void")]
	public unsafe static void decode_remove_bits(void* @this, [NativeType("unsigned int")] int num_bits)
	{
		try
		{
			AssetRipper.Conversions.Lzham.GlobalFunctions.decode_remove_bits.Invoke(@this, num_bits);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
	}

	[MangledName("?remove_bits@symbol_codec@lzham@@QEAAXI@Z")]
	[DemangledName("public: void __cdecl lzham::symbol_codec::remove_bits(unsigned int)")]
	[return: NativeType("void")]
	public unsafe static void remove_bits(void* @this, [NativeType("unsigned int")] int num_bits)
	{
		try
		{
			AssetRipper.Conversions.Lzham.GlobalFunctions.remove_bits.Invoke(@this, num_bits);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
	}

	[MangledName("?decode_peek_bits@symbol_codec@lzham@@QEAAII@Z")]
	[DemangledName("public: unsigned int __cdecl lzham::symbol_codec::decode_peek_bits(unsigned int)")]
	[return: NativeType("unsigned int")]
	public unsafe static int decode_peek_bits(void* @this, [NativeType("unsigned int")] int num_bits)
	{
		int result;
		try
		{
			result = AssetRipper.Conversions.Lzham.GlobalFunctions.decode_peek_bits.Invoke(@this, num_bits);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
		return result;
	}

	[MangledName("?decode@symbol_codec@lzham@@QEAAIAEAUquasi_adaptive_huffman_data_model@2@@Z")]
	[DemangledName("public: unsigned int __cdecl lzham::symbol_codec::decode(struct lzham::quasi_adaptive_huffman_data_model &)")]
	[CleanName("decode")]
	[return: NativeType("unsigned int")]
	public unsafe static int decode_9wzr2x(void* @this, [NativeType("struct lzham::quasi_adaptive_huffman_data_model &")] void* model)
	{
		int result;
		try
		{
			result = AssetRipper.Conversions.Lzham.GlobalFunctions.decode_9wzr2x.Invoke(@this, model);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
		return result;
	}

	[MangledName("?stop_decoding@symbol_codec@lzham@@QEAA_KXZ")]
	[DemangledName("public: unsigned __int64 __cdecl lzham::symbol_codec::stop_decoding(void)")]
	[return: NativeType("unsigned __int64")]
	public unsafe static long stop_decoding(void* @this)
	{
		return AssetRipper.Conversions.Lzham.GlobalFunctions.stop_decoding.Invoke(@this);
	}

	[MangledName("?decode_align_to_byte@symbol_codec@lzham@@QEAAXXZ")]
	[DemangledName("public: void __cdecl lzham::symbol_codec::decode_align_to_byte(void)")]
	[return: NativeType("void")]
	public unsafe static void decode_align_to_byte(void* @this)
	{
		try
		{
			AssetRipper.Conversions.Lzham.GlobalFunctions.decode_align_to_byte.Invoke(@this);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
	}

	[MangledName("?decode_remove_byte_from_bit_buf@symbol_codec@lzham@@QEAAHXZ")]
	[DemangledName("public: int __cdecl lzham::symbol_codec::decode_remove_byte_from_bit_buf(void)")]
	[return: NativeType("int")]
	public unsafe static int decode_remove_byte_from_bit_buf(void* @this)
	{
		return AssetRipper.Conversions.Lzham.GlobalFunctions.decode_remove_byte_from_bit_buf.Invoke(@this);
	}

	[MangledName("?decode@symbol_codec@lzham@@QEAAIAEAVadaptive_bit_model@2@_N@Z")]
	[DemangledName("public: unsigned int __cdecl lzham::symbol_codec::decode(class lzham::adaptive_bit_model &, bool)")]
	[CleanName("decode")]
	[return: NativeType("unsigned int")]
	public unsafe static int decode_vnvphn(void* @this, [NativeType("class lzham::adaptive_bit_model &")] void* model, [NativeType("bool")] bool update_model)
	{
		int result;
		try
		{
			result = AssetRipper.Conversions.Lzham.GlobalFunctions.decode_vnvphn.Invoke(@this, model, update_model);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
		return result;
	}

	[MangledName("?decode@symbol_codec@lzham@@QEAAIAEAVadaptive_arith_data_model@2@@Z")]
	[DemangledName("public: unsigned int __cdecl lzham::symbol_codec::decode(class lzham::adaptive_arith_data_model &)")]
	[CleanName("decode")]
	[return: NativeType("unsigned int")]
	public unsafe static int decode_689gy3(void* @this, [NativeType("class lzham::adaptive_arith_data_model &")] void* model)
	{
		int result;
		try
		{
			result = AssetRipper.Conversions.Lzham.GlobalFunctions.decode_689gy3.Invoke(@this, model);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
		return result;
	}

	[MangledName("?start_arith_decoding@symbol_codec@lzham@@QEAAXXZ")]
	[DemangledName("public: void __cdecl lzham::symbol_codec::start_arith_decoding(void)")]
	[return: NativeType("void")]
	public unsafe static void start_arith_decoding(void* @this)
	{
		try
		{
			AssetRipper.Conversions.Lzham.GlobalFunctions.start_arith_decoding.Invoke(@this);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
	}

	[MangledName("?decode_need_bytes@symbol_codec@lzham@@QEAAXXZ")]
	[DemangledName("public: void __cdecl lzham::symbol_codec::decode_need_bytes(void)")]
	[return: NativeType("void")]
	public unsafe static void decode_need_bytes(void* @this)
	{
		try
		{
			AssetRipper.Conversions.Lzham.GlobalFunctions.decode_need_bytes.Invoke(@this);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
	}

	[MangledName("??0lzham_timer@lzham@@QEAA@XZ")]
	[DemangledName("public: __cdecl lzham::lzham_timer::lzham_timer(void)")]
	[CleanName("lzham_timer_Constructor")]
	public unsafe static void* lzham_timer_Constructor_yuikg8(void* @this)
	{
		return AssetRipper.Conversions.Lzham.GlobalFunctions.lzham_timer_Constructor_yuikg8.Invoke(@this);
	}

	[MangledName("?init@lzham_timer@lzham@@SAXXZ")]
	[DemangledName("public: static void __cdecl lzham::lzham_timer::init(void)")]
	[CleanName("init")]
	[return: NativeType("void")]
	public static void init_ptjsy3()
	{
		AssetRipper.Conversions.Lzham.GlobalFunctions.init_ptjsy3.Invoke();
	}

	[MangledName("?query_counter_frequency@lzham@@YAXPEA_K@Z")]
	[DemangledName("void __cdecl lzham::query_counter_frequency(unsigned __int64 *)")]
	[return: NativeType("void")]
	public unsafe static void query_counter_frequency([NativeType("unsigned __int64 *")] void* pTicks)
	{
		AssetRipper.Conversions.Lzham.GlobalFunctions.query_counter_frequency.Invoke(pTicks);
	}

	[MangledName("?query_counter@lzham@@YAXPEA_K@Z")]
	[DemangledName("void __cdecl lzham::query_counter(unsigned __int64 *)")]
	[return: NativeType("void")]
	public unsafe static void query_counter([NativeType("unsigned __int64 *")] void* pTicks)
	{
		AssetRipper.Conversions.Lzham.GlobalFunctions.query_counter.Invoke(pTicks);
	}

	public static int clock()
	{
		return AssetRipper.Conversions.Lzham.Intrinsics.Implemented.clock.Invoke();
	}

	[MangledName("??0lzham_timer@lzham@@QEAA@_K@Z")]
	[DemangledName("public: __cdecl lzham::lzham_timer::lzham_timer(unsigned __int64)")]
	[CleanName("lzham_timer_Constructor")]
	public unsafe static void* lzham_timer_Constructor_bpj5rd(void* @this, [NativeType("unsigned __int64")] long start_ticks)
	{
		return AssetRipper.Conversions.Lzham.GlobalFunctions.lzham_timer_Constructor_bpj5rd.Invoke(@this, start_ticks);
	}

	[MangledName("?start@lzham_timer@lzham@@QEAAX_K@Z")]
	[DemangledName("public: void __cdecl lzham::lzham_timer::start(unsigned __int64)")]
	[CleanName("start")]
	[return: NativeType("void")]
	public unsafe static void start_mxvdwq(void* @this, [NativeType("unsigned __int64")] long start_ticks)
	{
		AssetRipper.Conversions.Lzham.GlobalFunctions.start_mxvdwq.Invoke(@this, start_ticks);
	}

	[MangledName("?start@lzham_timer@lzham@@QEAAXXZ")]
	[DemangledName("public: void __cdecl lzham::lzham_timer::start(void)")]
	[CleanName("start")]
	[return: NativeType("void")]
	public unsafe static void start_qr7y7s(void* @this)
	{
		AssetRipper.Conversions.Lzham.GlobalFunctions.start_qr7y7s.Invoke(@this);
	}

	[MangledName("?stop@lzham_timer@lzham@@QEAAXXZ")]
	[DemangledName("public: void __cdecl lzham::lzham_timer::stop(void)")]
	[return: NativeType("void")]
	public unsafe static void stop(void* @this)
	{
		AssetRipper.Conversions.Lzham.GlobalFunctions.stop.Invoke(@this);
	}

	[MangledName("?get_elapsed_secs@lzham_timer@lzham@@QEBANXZ")]
	[DemangledName("public: double __cdecl lzham::lzham_timer::get_elapsed_secs(void) const")]
	[return: NativeType("double")]
	public unsafe static double Get_elapsed_secs(void* @this)
	{
		return AssetRipper.Conversions.Lzham.GlobalFunctions.Get_elapsed_secs.Invoke(@this);
	}

	[MangledName("?get_elapsed_us@lzham_timer@lzham@@QEBA_KXZ")]
	[DemangledName("public: unsigned __int64 __cdecl lzham::lzham_timer::get_elapsed_us(void) const")]
	[return: NativeType("unsigned __int64")]
	public unsafe static long Get_elapsed_us(void* @this)
	{
		return AssetRipper.Conversions.Lzham.GlobalFunctions.Get_elapsed_us.Invoke(@this);
	}

	[MangledName("?get_init_ticks@lzham_timer@lzham@@SA_KXZ")]
	[DemangledName("public: static unsigned __int64 __cdecl lzham::lzham_timer::get_init_ticks(void)")]
	[return: NativeType("unsigned __int64")]
	public static long Get_init_ticks()
	{
		return AssetRipper.Conversions.Lzham.GlobalFunctions.Get_init_ticks.Invoke();
	}

	[MangledName("?get_ticks@lzham_timer@lzham@@SA_KXZ")]
	[DemangledName("public: static unsigned __int64 __cdecl lzham::lzham_timer::get_ticks(void)")]
	[return: NativeType("unsigned __int64")]
	public static long Get_ticks()
	{
		return AssetRipper.Conversions.Lzham.GlobalFunctions.Get_ticks.Invoke();
	}

	[MangledName("?ticks_to_secs@lzham_timer@lzham@@SAN_K@Z")]
	[DemangledName("public: static double __cdecl lzham::lzham_timer::ticks_to_secs(unsigned __int64)")]
	[return: NativeType("double")]
	public static double ticks_to_secs([NativeType("unsigned __int64")] long ticks)
	{
		return AssetRipper.Conversions.Lzham.GlobalFunctions.ticks_to_secs.Invoke(ticks);
	}

	[MangledName("?increase_capacity@elemental_vector@lzham@@QEAA_NI_NIP6AXPEAX1I@Z0@Z")]
	[DemangledName("public: bool __cdecl lzham::elemental_vector::increase_capacity(unsigned int, bool, unsigned int, void (__cdecl *)(void *, void *, unsigned int), bool)")]
	[CleanName("increase_capacity")]
	[return: NativeType("bool")]
	public unsafe static bool increase_capacity_k3pwnk(void* @this, [NativeType("unsigned int")] int min_new_capacity, [NativeType("bool")] bool grow_hint, [NativeType("unsigned int")] int element_size, [NativeType("void (__cdecl *)(void *, void *, unsigned int)")] void* pMover, [NativeType("bool")] bool nofail)
	{
		bool result;
		try
		{
			result = AssetRipper.Conversions.Lzham.GlobalFunctions.increase_capacity_k3pwnk.Invoke(@this, min_new_capacity, grow_hint, element_size, pMover, nofail);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
		return result;
	}

	[MangledName("?is_power_of_2@math@lzham@@YA_N_K@Z")]
	[DemangledName("bool __cdecl lzham::math::is_power_of_2(unsigned __int64)")]
	[CleanName("is_power_of_2")]
	[return: NativeType("bool")]
	public static bool is_power_of_2_7smfqf([NativeType("unsigned __int64")] long x)
	{
		return AssetRipper.Conversions.Lzham.GlobalFunctions.is_power_of_2_7smfqf.Invoke(x);
	}

	[MangledName("?next_pow2@math@lzham@@YA_K_K@Z")]
	[DemangledName("unsigned __int64 __cdecl lzham::math::next_pow2(unsigned __int64)")]
	[CleanName("next_pow2")]
	[return: NativeType("unsigned __int64")]
	public static long next_pow2_csqeav([NativeType("unsigned __int64")] long val)
	{
		return AssetRipper.Conversions.Lzham.GlobalFunctions.next_pow2_csqeav.Invoke(val);
	}

	[MangledName("?init_slot_tabs@CLZBase@lzham@@QEAAXXZ")]
	[DemangledName("public: void __cdecl lzham::CLZBase::init_slot_tabs(void)")]
	[return: NativeType("void")]
	public unsafe static void init_slot_tabs(void* @this)
	{
		AssetRipper.Conversions.Lzham.GlobalFunctions.init_slot_tabs.Invoke(@this);
	}

	[MangledName("?compute_lzx_position_slot@CLZBase@lzham@@QEAAXIAEAI0@Z")]
	[DemangledName("public: void __cdecl lzham::CLZBase::compute_lzx_position_slot(unsigned int, unsigned int &, unsigned int &)")]
	[return: NativeType("void")]
	public unsafe static void compute_lzx_position_slot(void* @this, [NativeType("unsigned int")] int dist, [NativeType("unsigned int &")] void* slot, [NativeType("unsigned int &")] void* ofs)
	{
		AssetRipper.Conversions.Lzham.GlobalFunctions.compute_lzx_position_slot.Invoke(@this, dist, slot, ofs);
	}

	[MangledName("?lzham_lib_compress_init@lzham@@YAPEAXPEBUlzham_compress_params@@@Z")]
	[DemangledName("void * __cdecl lzham::lzham_lib_compress_init(struct lzham_compress_params const *)")]
	[return: NativeType("void *")]
	public unsafe static void* lzham_lib_compress_init([NativeType("struct lzham_compress_params const *")] void* pParams)
	{
		void* result;
		try
		{
			result = AssetRipper.Conversions.Lzham.GlobalFunctions.lzham_lib_compress_init.Invoke(pParams);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
		return result;
	}

	[MangledName("??0init_params@lzcompressor@lzham@@QEAA@XZ")]
	[DemangledName("public: __cdecl lzham::lzcompressor::init_params::init_params(void)")]
	public unsafe static void* init_params_Constructor(void* @this)
	{
		return AssetRipper.Conversions.Lzham.GlobalFunctions.init_params_Constructor.Invoke(@this);
	}

	[MangledName("?create_internal_init_params@lzham@@YA?AW4lzham_compress_status_t@@AEAUinit_params@lzcompressor@1@PEBUlzham_compress_params@@@Z")]
	[DemangledName("enum lzham_compress_status_t __cdecl lzham::create_internal_init_params(struct lzham::lzcompressor::init_params &, struct lzham_compress_params const *)")]
	[return: NativeType("enum lzham_compress_status_t")]
	public unsafe static int create_internal_init_params([NativeType("struct lzham::lzcompressor::init_params &")] void* internal_params, [NativeType("struct lzham_compress_params const *")] void* pParams)
	{
		return AssetRipper.Conversions.Lzham.GlobalFunctions.create_internal_init_params.Invoke(internal_params, pParams);
	}

	[MangledName("??$lzham_new@Ulzham_compress_state@lzham@@@lzham@@YAPEAUlzham_compress_state@0@XZ")]
	[DemangledName("struct lzham::lzham_compress_state * __cdecl lzham::lzham_new<struct lzham::lzham_compress_state>(void)")]
	[CleanName("lzham_new")]
	[return: NativeType("struct lzham::lzham_compress_state *")]
	public unsafe static void* lzham_new_2zi7i7()
	{
		void* result;
		try
		{
			result = AssetRipper.Conversions.Lzham.GlobalFunctions.lzham_new_2zi7i7.Invoke();
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
		return result;
	}

	[MangledName("?init@task_pool@lzham@@QEAA_NI@Z")]
	[DemangledName("public: bool __cdecl lzham::task_pool::init(unsigned int)")]
	[CleanName("init")]
	[return: NativeType("bool")]
	public unsafe static bool init_g7adhy(void* @this, [NativeType("unsigned int")] int num_threads)
	{
		return AssetRipper.Conversions.Lzham.GlobalFunctions.init_g7adhy.Invoke(@this, num_threads);
	}

	[MangledName("??$lzham_delete@Ulzham_compress_state@lzham@@@lzham@@YAXPEAUlzham_compress_state@0@@Z")]
	[DemangledName("void __cdecl lzham::lzham_delete<struct lzham::lzham_compress_state>(struct lzham::lzham_compress_state *)")]
	[CleanName("lzham_delete")]
	[return: NativeType("void")]
	public unsafe static void lzham_delete_w5u5xk([NativeType("struct lzham::lzham_compress_state *")] void* p)
	{
		try
		{
			AssetRipper.Conversions.Lzham.GlobalFunctions.lzham_delete_w5u5xk.Invoke(p);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
	}

	[MangledName("?get_num_threads@task_pool@lzham@@QEBAIXZ")]
	[DemangledName("public: unsigned int __cdecl lzham::task_pool::get_num_threads(void) const")]
	[return: NativeType("unsigned int")]
	public unsafe static int Get_num_threads(void* @this)
	{
		return AssetRipper.Conversions.Lzham.GlobalFunctions.Get_num_threads.Invoke(@this);
	}

	[MangledName("??$destruct@Ulzham_compress_state@lzham@@@helpers@lzham@@YAXPEAUlzham_compress_state@1@@Z")]
	[DemangledName("void __cdecl lzham::helpers::destruct<struct lzham::lzham_compress_state>(struct lzham::lzham_compress_state *)")]
	[CleanName("destruct")]
	[return: NativeType("void")]
	public unsafe static void destruct_qtfz2c([NativeType("struct lzham::lzham_compress_state *")] void* p)
	{
		try
		{
			AssetRipper.Conversions.Lzham.GlobalFunctions.destruct_qtfz2c.Invoke(p);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
	}

	[MangledName("??1lzham_compress_state@lzham@@QEAA@XZ")]
	[DemangledName("public: __cdecl lzham::lzham_compress_state::~lzham_compress_state(void)")]
	public unsafe static void lzham_compress_state_Destructor(void* @this)
	{
		try
		{
			AssetRipper.Conversions.Lzham.GlobalFunctions.lzham_compress_state_Destructor.Invoke(@this);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
	}

	[MangledName("??1lzcompressor@lzham@@QEAA@XZ")]
	[DemangledName("public: __cdecl lzham::lzcompressor::~lzcompressor(void)")]
	public unsafe static void lzcompressor_Destructor(void* @this)
	{
		try
		{
			AssetRipper.Conversions.Lzham.GlobalFunctions.lzcompressor_Destructor.Invoke(@this);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
	}

	[MangledName("??1task_pool@lzham@@QEAA@XZ")]
	[DemangledName("public: __cdecl lzham::task_pool::~task_pool(void)")]
	public unsafe static void task_pool_Destructor(void* @this)
	{
		AssetRipper.Conversions.Lzham.GlobalFunctions.task_pool_Destructor.Invoke(@this);
	}

	[MangledName("??1semaphore@lzham@@QEAA@XZ")]
	[DemangledName("public: __cdecl lzham::semaphore::~semaphore(void)")]
	public unsafe static void semaphore_Destructor(void* @this)
	{
		AssetRipper.Conversions.Lzham.GlobalFunctions.semaphore_Destructor.Invoke(@this);
	}

	[MangledName("??1parse_thread_state@lzcompressor@lzham@@QEAA@XZ")]
	[DemangledName("public: __cdecl lzham::lzcompressor::parse_thread_state::~parse_thread_state(void)")]
	public unsafe static void parse_thread_state_Destructor(void* @this)
	{
		try
		{
			AssetRipper.Conversions.Lzham.GlobalFunctions.parse_thread_state_Destructor.Invoke(@this);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
	}

	[MangledName("??1state@lzcompressor@lzham@@QEAA@XZ")]
	[DemangledName("public: __cdecl lzham::lzcompressor::state::~state(void)")]
	public unsafe static void state_Destructor(void* @this)
	{
		try
		{
			AssetRipper.Conversions.Lzham.GlobalFunctions.state_Destructor.Invoke(@this);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
	}

	[MangledName("??1search_accelerator@lzham@@QEAA@XZ")]
	[DemangledName("public: __cdecl lzham::search_accelerator::~search_accelerator(void)")]
	public unsafe static void search_accelerator_Destructor(void* @this)
	{
		try
		{
			AssetRipper.Conversions.Lzham.GlobalFunctions.search_accelerator_Destructor.Invoke(@this);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
	}

	[MangledName("??1?$vector@I@lzham@@QEAA@XZ")]
	[DemangledName("public: __cdecl lzham::vector<unsigned int>::~vector<unsigned int>(void)")]
	public unsafe static void vector_unsigned_int_Destructor(void* @this)
	{
		try
		{
			AssetRipper.Conversions.Lzham.GlobalFunctions.vector_unsigned_int_Destructor.Invoke(@this);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
	}

	[MangledName("??1?$vector@J@lzham@@QEAA@XZ")]
	[DemangledName("public: __cdecl lzham::vector<long>::~vector<long>(void)")]
	public unsafe static void vector_long_Destructor(void* @this)
	{
		try
		{
			AssetRipper.Conversions.Lzham.GlobalFunctions.vector_long_Destructor.Invoke(@this);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
	}

	[MangledName("??1?$vector@Udict_match@lzham@@@lzham@@QEAA@XZ")]
	[DemangledName("public: __cdecl lzham::vector<struct lzham::dict_match>::~vector<struct lzham::dict_match>(void)")]
	public unsafe static void vector_struct_lzham_dict_match_Destructor(void* @this)
	{
		try
		{
			AssetRipper.Conversions.Lzham.GlobalFunctions.vector_struct_lzham_dict_match_Destructor.Invoke(@this);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
	}

	[MangledName("??1?$vector@Unode@lzham@@@lzham@@QEAA@XZ")]
	[DemangledName("public: __cdecl lzham::vector<struct lzham::node>::~vector<struct lzham::node>(void)")]
	public unsafe static void vector_struct_lzham_node_Destructor(void* @this)
	{
		try
		{
			AssetRipper.Conversions.Lzham.GlobalFunctions.vector_struct_lzham_node_Destructor.Invoke(@this);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
	}

	[MangledName("?destruct_array@?$scalar_type@Unode@lzham@@@lzham@@SAXPEAUnode@2@I@Z")]
	[DemangledName("public: static void __cdecl lzham::scalar_type<struct lzham::node>::destruct_array(struct lzham::node *, unsigned int)")]
	[CleanName("destruct_array")]
	[return: NativeType("void")]
	public unsafe static void destruct_array_92sfup([NativeType("struct lzham::node *")] void* p, [NativeType("unsigned int")] int n)
	{
		AssetRipper.Conversions.Lzham.GlobalFunctions.destruct_array_92sfup.Invoke(p, n);
	}

	[MangledName("??$destruct_array@Unode@lzham@@@helpers@lzham@@YAXPEAUnode@1@I@Z")]
	[DemangledName("void __cdecl lzham::helpers::destruct_array<struct lzham::node>(struct lzham::node *, unsigned int)")]
	[CleanName("destruct_array")]
	[return: NativeType("void")]
	public unsafe static void destruct_array_4m8e38([NativeType("struct lzham::node *")] void* p, [NativeType("unsigned int")] int n)
	{
		AssetRipper.Conversions.Lzham.GlobalFunctions.destruct_array_4m8e38.Invoke(p, n);
	}

	[MangledName("?destruct_array@?$scalar_type@Udict_match@lzham@@@lzham@@SAXPEAUdict_match@2@I@Z")]
	[DemangledName("public: static void __cdecl lzham::scalar_type<struct lzham::dict_match>::destruct_array(struct lzham::dict_match *, unsigned int)")]
	[CleanName("destruct_array")]
	[return: NativeType("void")]
	public unsafe static void destruct_array_j4mhvj([NativeType("struct lzham::dict_match *")] void* p, [NativeType("unsigned int")] int n)
	{
		AssetRipper.Conversions.Lzham.GlobalFunctions.destruct_array_j4mhvj.Invoke(p, n);
	}

	[MangledName("??$destruct_array@Udict_match@lzham@@@helpers@lzham@@YAXPEAUdict_match@1@I@Z")]
	[DemangledName("void __cdecl lzham::helpers::destruct_array<struct lzham::dict_match>(struct lzham::dict_match *, unsigned int)")]
	[CleanName("destruct_array")]
	[return: NativeType("void")]
	public unsafe static void destruct_array_nmf7rm([NativeType("struct lzham::dict_match *")] void* p, [NativeType("unsigned int")] int n)
	{
		AssetRipper.Conversions.Lzham.GlobalFunctions.destruct_array_nmf7rm.Invoke(p, n);
	}

	[MangledName("?destruct_array@?$scalar_type@J@lzham@@SAXPEAJI@Z")]
	[DemangledName("public: static void __cdecl lzham::scalar_type<long>::destruct_array(long *, unsigned int)")]
	[CleanName("destruct_array")]
	[return: NativeType("void")]
	public unsafe static void destruct_array_3vfhbd([NativeType("long *")] void* p, [NativeType("unsigned int")] int n)
	{
		AssetRipper.Conversions.Lzham.GlobalFunctions.destruct_array_3vfhbd.Invoke(p, n);
	}

	[MangledName("?destruct_array@?$scalar_type@I@lzham@@SAXPEAII@Z")]
	[DemangledName("public: static void __cdecl lzham::scalar_type<unsigned int>::destruct_array(unsigned int *, unsigned int)")]
	[CleanName("destruct_array")]
	[return: NativeType("void")]
	public unsafe static void destruct_array_k4df6b([NativeType("unsigned int *")] void* p, [NativeType("unsigned int")] int n)
	{
		AssetRipper.Conversions.Lzham.GlobalFunctions.destruct_array_k4df6b.Invoke(p, n);
	}

	[MangledName("??1raw_parse_thread_state@lzcompressor@lzham@@QEAA@XZ")]
	[DemangledName("public: __cdecl lzham::lzcompressor::raw_parse_thread_state::~raw_parse_thread_state(void)")]
	public unsafe static void raw_parse_thread_state_Destructor(void* @this)
	{
		try
		{
			AssetRipper.Conversions.Lzham.GlobalFunctions.raw_parse_thread_state_Destructor.Invoke(@this);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
	}

	[MangledName("??1?$vector@Ulzpriced_decision@lzcompressor@lzham@@@lzham@@QEAA@XZ")]
	[DemangledName("public: __cdecl lzham::vector<struct lzham::lzcompressor::lzpriced_decision>::~vector<struct lzham::lzcompressor::lzpriced_decision>(void)")]
	public unsafe static void vector_struct_lzham_lzcompressor_lzpriced_decision_Destructor(void* @this)
	{
		try
		{
			AssetRipper.Conversions.Lzham.GlobalFunctions.vector_struct_lzham_lzcompressor_lzpriced_decision_Destructor.Invoke(@this);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
	}

	[MangledName("??1?$vector@Ulzdecision@lzcompressor@lzham@@@lzham@@QEAA@XZ")]
	[DemangledName("public: __cdecl lzham::vector<struct lzham::lzcompressor::lzdecision>::~vector<struct lzham::lzcompressor::lzdecision>(void)")]
	public unsafe static void vector_struct_lzham_lzcompressor_lzdecision_Destructor(void* @this)
	{
		try
		{
			AssetRipper.Conversions.Lzham.GlobalFunctions.vector_struct_lzham_lzcompressor_lzdecision_Destructor.Invoke(@this);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
	}

	[MangledName("?destruct_array@?$scalar_type@Ulzdecision@lzcompressor@lzham@@@lzham@@SAXPEAUlzdecision@lzcompressor@2@I@Z")]
	[DemangledName("public: static void __cdecl lzham::scalar_type<struct lzham::lzcompressor::lzdecision>::destruct_array(struct lzham::lzcompressor::lzdecision *, unsigned int)")]
	[CleanName("destruct_array")]
	[return: NativeType("void")]
	public unsafe static void destruct_array_d9vgvt([NativeType("struct lzham::lzcompressor::lzdecision *")] void* p, [NativeType("unsigned int")] int n)
	{
		AssetRipper.Conversions.Lzham.GlobalFunctions.destruct_array_d9vgvt.Invoke(p, n);
	}

	[MangledName("??$destruct_array@Ulzdecision@lzcompressor@lzham@@@helpers@lzham@@YAXPEAUlzdecision@lzcompressor@1@I@Z")]
	[DemangledName("void __cdecl lzham::helpers::destruct_array<struct lzham::lzcompressor::lzdecision>(struct lzham::lzcompressor::lzdecision *, unsigned int)")]
	[CleanName("destruct_array")]
	[return: NativeType("void")]
	public unsafe static void destruct_array_8t24pa([NativeType("struct lzham::lzcompressor::lzdecision *")] void* p, [NativeType("unsigned int")] int n)
	{
		AssetRipper.Conversions.Lzham.GlobalFunctions.destruct_array_8t24pa.Invoke(p, n);
	}

	[MangledName("?destruct_array@?$scalar_type@Ulzpriced_decision@lzcompressor@lzham@@@lzham@@SAXPEAUlzpriced_decision@lzcompressor@2@I@Z")]
	[DemangledName("public: static void __cdecl lzham::scalar_type<struct lzham::lzcompressor::lzpriced_decision>::destruct_array(struct lzham::lzcompressor::lzpriced_decision *, unsigned int)")]
	[CleanName("destruct_array")]
	[return: NativeType("void")]
	public unsafe static void destruct_array_3ymcrm([NativeType("struct lzham::lzcompressor::lzpriced_decision *")] void* p, [NativeType("unsigned int")] int n)
	{
		AssetRipper.Conversions.Lzham.GlobalFunctions.destruct_array_3ymcrm.Invoke(p, n);
	}

	[MangledName("??$destruct_array@Ulzpriced_decision@lzcompressor@lzham@@@helpers@lzham@@YAXPEAUlzpriced_decision@lzcompressor@1@I@Z")]
	[DemangledName("void __cdecl lzham::helpers::destruct_array<struct lzham::lzcompressor::lzpriced_decision>(struct lzham::lzcompressor::lzpriced_decision *, unsigned int)")]
	[CleanName("destruct_array")]
	[return: NativeType("void")]
	public unsafe static void destruct_array_aafy6n([NativeType("struct lzham::lzcompressor::lzpriced_decision *")] void* p, [NativeType("unsigned int")] int n)
	{
		AssetRipper.Conversions.Lzham.GlobalFunctions.destruct_array_aafy6n.Invoke(p, n);
	}

	[MangledName("??$construct@Ulzham_compress_state@lzham@@@helpers@lzham@@YAPEAUlzham_compress_state@1@PEAU21@@Z")]
	[DemangledName("struct lzham::lzham_compress_state * __cdecl lzham::helpers::construct<struct lzham::lzham_compress_state>(struct lzham::lzham_compress_state *)")]
	[CleanName("construct")]
	[return: NativeType("struct lzham::lzham_compress_state *")]
	public unsafe static void* construct_hipv6j([NativeType("struct lzham::lzham_compress_state *")] void* p)
	{
		void* result;
		try
		{
			result = AssetRipper.Conversions.Lzham.GlobalFunctions.construct_hipv6j.Invoke(p);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
		return result;
	}

	[MangledName("??0lzham_compress_state@lzham@@QEAA@XZ")]
	[DemangledName("public: __cdecl lzham::lzham_compress_state::lzham_compress_state(void)")]
	public unsafe static void* lzham_compress_state_Constructor(void* @this)
	{
		void* result;
		try
		{
			result = AssetRipper.Conversions.Lzham.GlobalFunctions.lzham_compress_state_Constructor.Invoke(@this);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
		return result;
	}

	[MangledName("??0task_pool@lzham@@QEAA@XZ")]
	[DemangledName("public: __cdecl lzham::task_pool::task_pool(void)")]
	public unsafe static void* task_pool_Constructor(void* @this)
	{
		return AssetRipper.Conversions.Lzham.GlobalFunctions.task_pool_Constructor.Invoke(@this);
	}

	[MangledName("?lzham_get_max_helper_threads@lzham@@YAIXZ")]
	[DemangledName("unsigned int __cdecl lzham::lzham_get_max_helper_threads(void)")]
	[return: NativeType("unsigned int")]
	public static int lzham_get_max_helper_threads()
	{
		return AssetRipper.Conversions.Lzham.GlobalFunctions.lzham_get_max_helper_threads.Invoke();
	}

	[MangledName("?lzham_lib_compress_reinit@lzham@@YAPEAXPEAX@Z")]
	[DemangledName("void * __cdecl lzham::lzham_lib_compress_reinit(void *)")]
	[return: NativeType("void *")]
	public unsafe static void* lzham_lib_compress_reinit([NativeType("void *")] void* p)
	{
		void* result;
		try
		{
			result = AssetRipper.Conversions.Lzham.GlobalFunctions.lzham_lib_compress_reinit.Invoke(p);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
		return result;
	}

	[MangledName("?lzham_lib_compress_deinit@lzham@@YAIPEAX@Z")]
	[DemangledName("unsigned int __cdecl lzham::lzham_lib_compress_deinit(void *)")]
	[return: NativeType("unsigned int")]
	public unsafe static int lzham_lib_compress_deinit([NativeType("void *")] void* p)
	{
		int result;
		try
		{
			result = AssetRipper.Conversions.Lzham.GlobalFunctions.lzham_lib_compress_deinit.Invoke(p);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
		return result;
	}

	[MangledName("?get_src_adler32@lzcompressor@lzham@@QEBAIXZ")]
	[DemangledName("public: unsigned int __cdecl lzham::lzcompressor::get_src_adler32(void) const")]
	[return: NativeType("unsigned int")]
	public unsafe static int Get_src_adler32(void* @this)
	{
		return AssetRipper.Conversions.Lzham.GlobalFunctions.Get_src_adler32.Invoke(@this);
	}

	[MangledName("?lzham_lib_compress@lzham@@YA?AW4lzham_compress_status_t@@PEAXPEBEPEA_KPEAE2I@Z")]
	[DemangledName("enum lzham_compress_status_t __cdecl lzham::lzham_lib_compress(void *, unsigned char const *, unsigned __int64 *, unsigned char *, unsigned __int64 *, unsigned int)")]
	[return: NativeType("enum lzham_compress_status_t")]
	public unsafe static int lzham_lib_compress([NativeType("void *")] void* p, [NativeType("unsigned char const *")] void* pIn_buf, [NativeType("unsigned __int64 *")] void* pIn_buf_size, [NativeType("unsigned char *")] void* pOut_buf, [NativeType("unsigned __int64 *")] void* pOut_buf_size, [NativeType("unsigned int")] int no_more_input_bytes_flag)
	{
		int result;
		try
		{
			result = AssetRipper.Conversions.Lzham.GlobalFunctions.lzham_lib_compress.Invoke(p, pIn_buf, pIn_buf_size, pOut_buf, pOut_buf_size, no_more_input_bytes_flag);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
		return result;
	}

	[MangledName("?lzham_lib_compress2@lzham@@YA?AW4lzham_compress_status_t@@PEAXPEBEPEA_KPEAE2W4lzham_flush_t@@@Z")]
	[DemangledName("enum lzham_compress_status_t __cdecl lzham::lzham_lib_compress2(void *, unsigned char const *, unsigned __int64 *, unsigned char *, unsigned __int64 *, enum lzham_flush_t)")]
	[return: NativeType("enum lzham_compress_status_t")]
	public unsafe static int lzham_lib_compress2([NativeType("void *")] void* p, [NativeType("unsigned char const *")] void* pIn_buf, [NativeType("unsigned __int64 *")] void* pIn_buf_size, [NativeType("unsigned char *")] void* pOut_buf, [NativeType("unsigned __int64 *")] void* pOut_buf_size, [NativeType("enum lzham_flush_t")] int flush_type)
	{
		int result;
		try
		{
			result = AssetRipper.Conversions.Lzham.GlobalFunctions.lzham_lib_compress2.Invoke(p, pIn_buf, pIn_buf_size, pOut_buf, pOut_buf_size, flush_type);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
		return result;
	}

	[MangledName("?get_compressed_data@lzcompressor@lzham@@QEAAAEAV?$vector@E@2@XZ")]
	[DemangledName("public: class lzham::vector<unsigned char> & __cdecl lzham::lzcompressor::get_compressed_data(void)")]
	[return: NativeType("class lzham::vector<unsigned char> &")]
	public unsafe static void* Get_compressed_data(void* @this)
	{
		return AssetRipper.Conversions.Lzham.GlobalFunctions.Get_compressed_data.Invoke(@this);
	}

	[MangledName("?get_ptr@?$vector@E@lzham@@QEAAPEAEXZ")]
	[DemangledName("public: unsigned char * __cdecl lzham::vector<unsigned char>::get_ptr(void)")]
	[CleanName("Get_ptr")]
	[return: NativeType("unsigned char *")]
	public unsafe static void* Get_ptr_cpjzjc(void* @this)
	{
		return AssetRipper.Conversions.Lzham.GlobalFunctions.Get_ptr_cpjzjc.Invoke(@this);
	}

	[MangledName("?lzham_lib_compress_memory@lzham@@YA?AW4lzham_compress_status_t@@PEBUlzham_compress_params@@PEAEPEA_KPEBE_KPEAI@Z")]
	[DemangledName("enum lzham_compress_status_t __cdecl lzham::lzham_lib_compress_memory(struct lzham_compress_params const *, unsigned char *, unsigned __int64 *, unsigned char const *, unsigned __int64, unsigned int *)")]
	[return: NativeType("enum lzham_compress_status_t")]
	public unsafe static int lzham_lib_compress_memory([NativeType("struct lzham_compress_params const *")] void* pParams, [NativeType("unsigned char *")] void* pDst_buf, [NativeType("unsigned __int64 *")] void* pDst_len, [NativeType("unsigned char const *")] void* pSrc_buf, [NativeType("unsigned __int64")] long src_len, [NativeType("unsigned int *")] void* pAdler32)
	{
		int result;
		try
		{
			result = AssetRipper.Conversions.Lzham.GlobalFunctions.lzham_lib_compress_memory.Invoke(pParams, pDst_buf, pDst_len, pSrc_buf, src_len, pAdler32);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
		return result;
	}

	[MangledName("??$lzham_new@Vtask_pool@lzham@@@lzham@@YAPEAVtask_pool@0@XZ")]
	[DemangledName("class lzham::task_pool * __cdecl lzham::lzham_new<class lzham::task_pool>(void)")]
	[CleanName("lzham_new")]
	[return: NativeType("class lzham::task_pool *")]
	public unsafe static void* lzham_new_9wezva()
	{
		void* result;
		try
		{
			result = AssetRipper.Conversions.Lzham.GlobalFunctions.lzham_new_9wezva.Invoke();
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
		return result;
	}

	[MangledName("??$lzham_new@Vlzcompressor@lzham@@@lzham@@YAPEAVlzcompressor@0@XZ")]
	[DemangledName("class lzham::lzcompressor * __cdecl lzham::lzham_new<class lzham::lzcompressor>(void)")]
	[CleanName("lzham_new")]
	[return: NativeType("class lzham::lzcompressor *")]
	public unsafe static void* lzham_new_pkbiun()
	{
		void* result;
		try
		{
			result = AssetRipper.Conversions.Lzham.GlobalFunctions.lzham_new_pkbiun.Invoke();
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
		return result;
	}

	[MangledName("??$lzham_delete@Vtask_pool@lzham@@@lzham@@YAXPEAVtask_pool@0@@Z")]
	[DemangledName("void __cdecl lzham::lzham_delete<class lzham::task_pool>(class lzham::task_pool *)")]
	[CleanName("lzham_delete")]
	[return: NativeType("void")]
	public unsafe static void lzham_delete_w9ji3f([NativeType("class lzham::task_pool *")] void* p)
	{
		try
		{
			AssetRipper.Conversions.Lzham.GlobalFunctions.lzham_delete_w9ji3f.Invoke(p);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
	}

	[MangledName("??$lzham_delete@Vlzcompressor@lzham@@@lzham@@YAXPEAVlzcompressor@0@@Z")]
	[DemangledName("void __cdecl lzham::lzham_delete<class lzham::lzcompressor>(class lzham::lzcompressor *)")]
	[CleanName("lzham_delete")]
	[return: NativeType("void")]
	public unsafe static void lzham_delete_5e8ypf([NativeType("class lzham::lzcompressor *")] void* p)
	{
		try
		{
			AssetRipper.Conversions.Lzham.GlobalFunctions.lzham_delete_5e8ypf.Invoke(p);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
	}

	[MangledName("?get_ptr@?$vector@E@lzham@@QEBAPEBEXZ")]
	[DemangledName("public: unsigned char const * __cdecl lzham::vector<unsigned char>::get_ptr(void) const")]
	[CleanName("Get_ptr")]
	[return: NativeType("unsigned char const *")]
	public unsafe static void* Get_ptr_pyhvtd(void* @this)
	{
		return AssetRipper.Conversions.Lzham.GlobalFunctions.Get_ptr_pyhvtd.Invoke(@this);
	}

	[MangledName("??$destruct@Vlzcompressor@lzham@@@helpers@lzham@@YAXPEAVlzcompressor@1@@Z")]
	[DemangledName("void __cdecl lzham::helpers::destruct<class lzham::lzcompressor>(class lzham::lzcompressor *)")]
	[CleanName("destruct")]
	[return: NativeType("void")]
	public unsafe static void destruct_ivrhzw([NativeType("class lzham::lzcompressor *")] void* p)
	{
		try
		{
			AssetRipper.Conversions.Lzham.GlobalFunctions.destruct_ivrhzw.Invoke(p);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
	}

	[MangledName("??$destruct@Vtask_pool@lzham@@@helpers@lzham@@YAXPEAVtask_pool@1@@Z")]
	[DemangledName("void __cdecl lzham::helpers::destruct<class lzham::task_pool>(class lzham::task_pool *)")]
	[CleanName("destruct")]
	[return: NativeType("void")]
	public unsafe static void destruct_qywrhp([NativeType("class lzham::task_pool *")] void* p)
	{
		AssetRipper.Conversions.Lzham.GlobalFunctions.destruct_qywrhp.Invoke(p);
	}

	[MangledName("??$construct@Vlzcompressor@lzham@@@helpers@lzham@@YAPEAVlzcompressor@1@PEAV21@@Z")]
	[DemangledName("class lzham::lzcompressor * __cdecl lzham::helpers::construct<class lzham::lzcompressor>(class lzham::lzcompressor *)")]
	[CleanName("construct")]
	[return: NativeType("class lzham::lzcompressor *")]
	public unsafe static void* construct_9447k8([NativeType("class lzham::lzcompressor *")] void* p)
	{
		void* result;
		try
		{
			result = AssetRipper.Conversions.Lzham.GlobalFunctions.construct_9447k8.Invoke(p);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
		return result;
	}

	[MangledName("??$construct@Vtask_pool@lzham@@@helpers@lzham@@YAPEAVtask_pool@1@PEAV21@@Z")]
	[DemangledName("class lzham::task_pool * __cdecl lzham::helpers::construct<class lzham::task_pool>(class lzham::task_pool *)")]
	[CleanName("construct")]
	[return: NativeType("class lzham::task_pool *")]
	public unsafe static void* construct_t4has9([NativeType("class lzham::task_pool *")] void* p)
	{
		return AssetRipper.Conversions.Lzham.GlobalFunctions.construct_t4has9.Invoke(p);
	}

	[MangledName("?lzham_lib_z_deflateInit@lzham@@YAHPEAUlzham_z_stream@@H@Z")]
	[DemangledName("int __cdecl lzham::lzham_lib_z_deflateInit(struct lzham_z_stream *, int)")]
	[return: NativeType("int")]
	public unsafe static int lzham_lib_z_deflateInit([NativeType("struct lzham_z_stream *")] void* pStream, [NativeType("int")] int level)
	{
		int result;
		try
		{
			result = AssetRipper.Conversions.Lzham.GlobalFunctions.lzham_lib_z_deflateInit.Invoke(pStream, level);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
		return result;
	}

	[MangledName("?lzham_lib_z_deflateInit2@lzham@@YAHPEAUlzham_z_stream@@HHHHH@Z")]
	[DemangledName("int __cdecl lzham::lzham_lib_z_deflateInit2(struct lzham_z_stream *, int, int, int, int, int)")]
	[return: NativeType("int")]
	public unsafe static int lzham_lib_z_deflateInit2([NativeType("struct lzham_z_stream *")] void* pStream, [NativeType("int")] int level, [NativeType("int")] int method, [NativeType("int")] int window_bits, [NativeType("int")] int mem_level, [NativeType("int")] int strategy)
	{
		int result;
		try
		{
			result = AssetRipper.Conversions.Lzham.GlobalFunctions.lzham_lib_z_deflateInit2.Invoke(pStream, level, method, window_bits, mem_level, strategy);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
		return result;
	}

	[MangledName("??$zero_object@Ulzham_compress_params@@@utils@lzham@@YAXAEAUlzham_compress_params@@@Z")]
	[DemangledName("void __cdecl lzham::utils::zero_object<struct lzham_compress_params>(struct lzham_compress_params &)")]
	[CleanName("zero_object")]
	[return: NativeType("void")]
	public unsafe static void zero_object_ccd6zn([NativeType("struct lzham_compress_params &")] void* obj)
	{
		AssetRipper.Conversions.Lzham.GlobalFunctions.zero_object_ccd6zn.Invoke(obj);
	}

	[MangledName("?lzham_lib_z_deflateReset@lzham@@YAHPEAUlzham_z_stream@@@Z")]
	[DemangledName("int __cdecl lzham::lzham_lib_z_deflateReset(struct lzham_z_stream *)")]
	[return: NativeType("int")]
	public unsafe static int lzham_lib_z_deflateReset([NativeType("struct lzham_z_stream *")] void* pStream)
	{
		int result;
		try
		{
			result = AssetRipper.Conversions.Lzham.GlobalFunctions.lzham_lib_z_deflateReset.Invoke(pStream);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
		return result;
	}

	[MangledName("?lzham_lib_z_deflate@lzham@@YAHPEAUlzham_z_stream@@H@Z")]
	[DemangledName("int __cdecl lzham::lzham_lib_z_deflate(struct lzham_z_stream *, int)")]
	[return: NativeType("int")]
	public unsafe static int lzham_lib_z_deflate([NativeType("struct lzham_z_stream *")] void* pStream, [NativeType("int")] int flush)
	{
		int result;
		try
		{
			result = AssetRipper.Conversions.Lzham.GlobalFunctions.lzham_lib_z_deflate.Invoke(pStream, flush);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
		return result;
	}

	[MangledName("?lzham_lib_z_deflateEnd@lzham@@YAHPEAUlzham_z_stream@@@Z")]
	[DemangledName("int __cdecl lzham::lzham_lib_z_deflateEnd(struct lzham_z_stream *)")]
	[return: NativeType("int")]
	public unsafe static int lzham_lib_z_deflateEnd([NativeType("struct lzham_z_stream *")] void* pStream)
	{
		int result;
		try
		{
			result = AssetRipper.Conversions.Lzham.GlobalFunctions.lzham_lib_z_deflateEnd.Invoke(pStream);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
		return result;
	}

	[MangledName("?lzham_lib_z_deflateBound@lzham@@YAKPEAUlzham_z_stream@@K@Z")]
	[DemangledName("unsigned long __cdecl lzham::lzham_lib_z_deflateBound(struct lzham_z_stream *, unsigned long)")]
	[return: NativeType("unsigned long")]
	public unsafe static int lzham_lib_z_deflateBound([NativeType("struct lzham_z_stream *")] void* pStream, [NativeType("unsigned long")] int source_len)
	{
		return AssetRipper.Conversions.Lzham.GlobalFunctions.lzham_lib_z_deflateBound.Invoke(pStream, source_len);
	}

	[MangledName("?lzham_lib_z_compress2@lzham@@YAHPEAEPEAKPEBEKH@Z")]
	[DemangledName("int __cdecl lzham::lzham_lib_z_compress2(unsigned char *, unsigned long *, unsigned char const *, unsigned long, int)")]
	[return: NativeType("int")]
	public unsafe static int lzham_lib_z_compress2([NativeType("unsigned char *")] void* pDest, [NativeType("unsigned long *")] void* pDest_len, [NativeType("unsigned char const *")] void* pSource, [NativeType("unsigned long")] int source_len, [NativeType("int")] int level)
	{
		int result;
		try
		{
			result = AssetRipper.Conversions.Lzham.GlobalFunctions.lzham_lib_z_compress2.Invoke(pDest, pDest_len, pSource, source_len, level);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
		return result;
	}

	[MangledName("?lzham_lib_z_compress@lzham@@YAHPEAEPEAKPEBEK@Z")]
	[DemangledName("int __cdecl lzham::lzham_lib_z_compress(unsigned char *, unsigned long *, unsigned char const *, unsigned long)")]
	[return: NativeType("int")]
	public unsafe static int lzham_lib_z_compress([NativeType("unsigned char *")] void* pDest, [NativeType("unsigned long *")] void* pDest_len, [NativeType("unsigned char const *")] void* pSource, [NativeType("unsigned long")] int source_len)
	{
		int result;
		try
		{
			result = AssetRipper.Conversions.Lzham.GlobalFunctions.lzham_lib_z_compress.Invoke(pDest, pDest_len, pSource, source_len);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
		return result;
	}

	[MangledName("?lzham_lib_z_compressBound@lzham@@YAKK@Z")]
	[DemangledName("unsigned long __cdecl lzham::lzham_lib_z_compressBound(unsigned long)")]
	[return: NativeType("unsigned long")]
	public static int lzham_lib_z_compressBound([NativeType("unsigned long")] int source_len)
	{
		return AssetRipper.Conversions.Lzham.GlobalFunctions.lzham_lib_z_compressBound.Invoke(source_len);
	}

	[MangledName("??0lzcompressor@lzham@@QEAA@XZ")]
	[DemangledName("public: __cdecl lzham::lzcompressor::lzcompressor(void)")]
	public unsafe static void* lzcompressor_Constructor(void* @this)
	{
		void* result;
		try
		{
			result = AssetRipper.Conversions.Lzham.GlobalFunctions.lzcompressor_Constructor.Invoke(@this);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
		return result;
	}

	[MangledName("??0coding_stats@lzcompressor@lzham@@QEAA@XZ")]
	[DemangledName("public: __cdecl lzham::lzcompressor::coding_stats::coding_stats(void)")]
	public unsafe static void* coding_stats_Constructor(void* @this)
	{
		return AssetRipper.Conversions.Lzham.GlobalFunctions.coding_stats_Constructor.Invoke(@this);
	}

	[MangledName("??0parse_thread_state@lzcompressor@lzham@@QEAA@XZ")]
	[DemangledName("public: __cdecl lzham::lzcompressor::parse_thread_state::parse_thread_state(void)")]
	public unsafe static void* parse_thread_state_Constructor(void* @this)
	{
		void* result;
		try
		{
			result = AssetRipper.Conversions.Lzham.GlobalFunctions.parse_thread_state_Constructor.Invoke(@this);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
		return result;
	}

	[MangledName("??0semaphore@lzham@@QEAA@JJPEBD@Z")]
	[DemangledName("public: __cdecl lzham::semaphore::semaphore(long, long, char const *)")]
	public unsafe static void* semaphore_Constructor(void* @this, [NativeType("long")] int initialCount, [NativeType("long")] int maximumCount, [NativeType("char const *")] void* pName)
	{
		return AssetRipper.Conversions.Lzham.GlobalFunctions.semaphore_Constructor.Invoke(@this, initialCount, maximumCount, pName);
	}

	[MangledName("??0raw_parse_thread_state@lzcompressor@lzham@@QEAA@XZ")]
	[DemangledName("public: __cdecl lzham::lzcompressor::raw_parse_thread_state::raw_parse_thread_state(void)")]
	public unsafe static void* raw_parse_thread_state_Constructor(void* @this)
	{
		void* result;
		try
		{
			result = AssetRipper.Conversions.Lzham.GlobalFunctions.raw_parse_thread_state_Constructor.Invoke(@this);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
		return result;
	}

	[MangledName("??0node@lzcompressor@lzham@@QEAA@XZ")]
	[DemangledName("public: __cdecl lzham::lzcompressor::node::node(void)")]
	public unsafe static void* node_Constructor(void* @this)
	{
		return AssetRipper.Conversions.Lzham.GlobalFunctions.node_Constructor.Invoke(@this);
	}

	[MangledName("??0?$vector@Ulzdecision@lzcompressor@lzham@@@lzham@@QEAA@XZ")]
	[DemangledName("public: __cdecl lzham::vector<struct lzham::lzcompressor::lzdecision>::vector<struct lzham::lzcompressor::lzdecision>(void)")]
	public unsafe static void* vector_struct_lzham_lzcompressor_lzdecision_Constructor(void* @this)
	{
		return AssetRipper.Conversions.Lzham.GlobalFunctions.vector_struct_lzham_lzcompressor_lzdecision_Constructor.Invoke(@this);
	}

	[MangledName("??0?$vector@Ulzpriced_decision@lzcompressor@lzham@@@lzham@@QEAA@XZ")]
	[DemangledName("public: __cdecl lzham::vector<struct lzham::lzcompressor::lzpriced_decision>::vector<struct lzham::lzcompressor::lzpriced_decision>(void)")]
	public unsafe static void* vector_struct_lzham_lzcompressor_lzpriced_decision_Constructor(void* @this)
	{
		return AssetRipper.Conversions.Lzham.GlobalFunctions.vector_struct_lzham_lzcompressor_lzpriced_decision_Constructor.Invoke(@this);
	}

	[MangledName("??0node_state@lzcompressor@lzham@@QEAA@XZ")]
	[DemangledName("public: __cdecl lzham::lzcompressor::node_state::node_state(void)")]
	public unsafe static void* node_state_Constructor(void* @this)
	{
		return AssetRipper.Conversions.Lzham.GlobalFunctions.node_state_Constructor.Invoke(@this);
	}

	[MangledName("??0lzdecision@lzcompressor@lzham@@QEAA@XZ")]
	[DemangledName("public: __cdecl lzham::lzcompressor::lzdecision::lzdecision(void)")]
	[CleanName("lzdecision_Constructor")]
	public unsafe static void* lzdecision_Constructor_y4m6um(void* @this)
	{
		return AssetRipper.Conversions.Lzham.GlobalFunctions.lzdecision_Constructor_y4m6um.Invoke(@this);
	}

	[MangledName("??0tracked_stat@lzcompressor@lzham@@QEAA@XZ")]
	[DemangledName("public: __cdecl lzham::lzcompressor::tracked_stat::tracked_stat(void)")]
	public unsafe static void* tracked_stat_Constructor(void* @this)
	{
		return AssetRipper.Conversions.Lzham.GlobalFunctions.tracked_stat_Constructor.Invoke(@this);
	}

	[MangledName("?clear@tracked_stat@lzcompressor@lzham@@QEAAXXZ")]
	[DemangledName("public: void __cdecl lzham::lzcompressor::tracked_stat::clear(void)")]
	[CleanName("clear")]
	[return: NativeType("void")]
	public unsafe static void clear_yhrysc(void* @this)
	{
		AssetRipper.Conversions.Lzham.GlobalFunctions.clear_yhrysc.Invoke(@this);
	}

	[MangledName("?init_seed_bytes@lzcompressor@lzham@@AEAA_NXZ")]
	[DemangledName("private: bool __cdecl lzham::lzcompressor::init_seed_bytes(void)")]
	[return: NativeType("bool")]
	public unsafe static bool init_seed_bytes(void* @this)
	{
		bool result;
		try
		{
			result = AssetRipper.Conversions.Lzham.GlobalFunctions.init_seed_bytes.Invoke(@this);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
		return result;
	}

	[MangledName("?init@lzcompressor@lzham@@QEAA_NAEBUinit_params@12@@Z")]
	[DemangledName("public: bool __cdecl lzham::lzcompressor::init(struct lzham::lzcompressor::init_params const &)")]
	[CleanName("init")]
	[return: NativeType("bool")]
	public unsafe static bool init_7dz6ee(void* @this, [NativeType("struct lzham::lzcompressor::init_params const &")] void* @params)
	{
		bool result;
		try
		{
			result = AssetRipper.Conversions.Lzham.GlobalFunctions.init_7dz6ee.Invoke(@this, @params);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
		return result;
	}

	[MangledName("?clear@lzcompressor@lzham@@QEAAXXZ")]
	[DemangledName("public: void __cdecl lzham::lzcompressor::clear(void)")]
	[CleanName("clear")]
	[return: NativeType("void")]
	public unsafe static void clear_uak2zs(void* @this)
	{
		try
		{
			AssetRipper.Conversions.Lzham.GlobalFunctions.clear_uak2zs.Invoke(@this);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
	}

	[MangledName("?send_zlib_header@lzcompressor@lzham@@AEAA_NXZ")]
	[DemangledName("private: bool __cdecl lzham::lzcompressor::send_zlib_header(void)")]
	[return: NativeType("bool")]
	public unsafe static bool send_zlib_header(void* @this)
	{
		bool result;
		try
		{
			result = AssetRipper.Conversions.Lzham.GlobalFunctions.send_zlib_header.Invoke(@this);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
		return result;
	}

	[MangledName("?clear@node@lzcompressor@lzham@@QEAAXXZ")]
	[DemangledName("public: void __cdecl lzham::lzcompressor::node::clear(void)")]
	[CleanName("clear")]
	[return: NativeType("void")]
	public unsafe static void clear_xf8fic(void* @this)
	{
		AssetRipper.Conversions.Lzham.GlobalFunctions.clear_xf8fic.Invoke(@this);
	}

	[MangledName("?clear@?$vector@Ulzdecision@lzcompressor@lzham@@@lzham@@QEAAXXZ")]
	[DemangledName("public: void __cdecl lzham::vector<struct lzham::lzcompressor::lzdecision>::clear(void)")]
	[CleanName("clear")]
	[return: NativeType("void")]
	public unsafe static void clear_hawvcm(void* @this)
	{
		try
		{
			AssetRipper.Conversions.Lzham.GlobalFunctions.clear_hawvcm.Invoke(@this);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
	}

	[MangledName("?reset@lzcompressor@lzham@@QEAA_NXZ")]
	[DemangledName("public: bool __cdecl lzham::lzcompressor::reset(void)")]
	[CleanName("reset")]
	[return: NativeType("bool")]
	public unsafe static bool reset_j4w9gw(void* @this)
	{
		bool result;
		try
		{
			result = AssetRipper.Conversions.Lzham.GlobalFunctions.reset_j4w9gw.Invoke(@this);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
		return result;
	}

	[MangledName("?code_decision@lzcompressor@lzham@@AEAA_NUlzdecision@12@AEAI1@Z")]
	[DemangledName("private: bool __cdecl lzham::lzcompressor::code_decision(struct lzham::lzcompressor::lzdecision, unsigned int &, unsigned int &)")]
	[return: NativeType("bool")]
	public unsafe static bool code_decision(void* @this, [NativeType("struct lzham::lzcompressor::lzdecision")] void* lzdec, [NativeType("unsigned int &")] void* cur_ofs, [NativeType("unsigned int &")] void* bytes_to_match)
	{
		bool result;
		try
		{
			result = AssetRipper.Conversions.Lzham.GlobalFunctions.code_decision.Invoke(@this, lzdec, cur_ofs, bytes_to_match);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
		return result;
	}

	[MangledName("?get_len@lzdecision@lzcompressor@lzham@@QEBAIXZ")]
	[DemangledName("public: unsigned int __cdecl lzham::lzcompressor::lzdecision::get_len(void) const")]
	[CleanName("Get_len")]
	[return: NativeType("unsigned int")]
	public unsafe static int Get_len_wzf5xk(void* @this)
	{
		return AssetRipper.Conversions.Lzham.GlobalFunctions.Get_len_wzf5xk.Invoke(@this);
	}

	[MangledName("?send_sync_block@lzcompressor@lzham@@AEAA_NW4lzham_flush_t@@@Z")]
	[DemangledName("private: bool __cdecl lzham::lzcompressor::send_sync_block(enum lzham_flush_t)")]
	[return: NativeType("bool")]
	public unsafe static bool send_sync_block(void* @this, [NativeType("enum lzham_flush_t")] int flush_type)
	{
		bool result;
		try
		{
			result = AssetRipper.Conversions.Lzham.GlobalFunctions.send_sync_block.Invoke(@this, flush_type);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
		return result;
	}

	[MangledName("?get_encoding_buf@symbol_codec@lzham@@QEAAAEAV?$vector@E@2@XZ")]
	[DemangledName("public: class lzham::vector<unsigned char> & __cdecl lzham::symbol_codec::get_encoding_buf(void)")]
	[return: NativeType("class lzham::vector<unsigned char> &")]
	public unsafe static void* Get_encoding_buf(void* @this)
	{
		return AssetRipper.Conversions.Lzham.GlobalFunctions.Get_encoding_buf.Invoke(@this);
	}

	[MangledName("?append@?$vector@E@lzham@@QEAA_NAEBV12@@Z")]
	[DemangledName("public: bool __cdecl lzham::vector<unsigned char>::append(class lzham::vector<unsigned char> const &)")]
	[CleanName("append")]
	[return: NativeType("bool")]
	public unsafe static bool append_9ee93x(void* @this, [NativeType("class lzham::vector<unsigned char> const &")] void* other)
	{
		bool result;
		try
		{
			result = AssetRipper.Conversions.Lzham.GlobalFunctions.append_9ee93x.Invoke(@this, other);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
		return result;
	}

	[MangledName("??A?$vector@E@lzham@@QEBAAEBEI@Z")]
	[DemangledName("public: unsigned char const & __cdecl lzham::vector<unsigned char>::operator[](unsigned int) const")]
	[CleanName("vector_unsigned_char_Operator")]
	[return: NativeType("unsigned char const &")]
	public unsafe static void* vector_unsigned_char_Operator_7ma9vz(void* @this, [NativeType("unsigned int")] int i)
	{
		return AssetRipper.Conversions.Lzham.GlobalFunctions.vector_unsigned_char_Operator_7ma9vz.Invoke(@this, i);
	}

	[MangledName("?insert@?$vector@E@lzham@@QEAA_NIPEBEI@Z")]
	[DemangledName("public: bool __cdecl lzham::vector<unsigned char>::insert(unsigned int, unsigned char const *, unsigned int)")]
	[return: NativeType("bool")]
	public unsafe static bool insert(void* @this, [NativeType("unsigned int")] int index, [NativeType("unsigned char const *")] void* p, [NativeType("unsigned int")] int n)
	{
		bool result;
		try
		{
			result = AssetRipper.Conversions.Lzham.GlobalFunctions.insert.Invoke(@this, index, p, n);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
		return result;
	}

	[MangledName("llvm.memmove.p0.p0.i64")]
	[DemangledName("llvm.memmove.p0.p0.i64")]
	public unsafe static void llvm_memmove_p0_p0_i64(void* parameter_0, void* parameter_1, long parameter_2, bool parameter_3)
	{
		AssetRipper.Conversions.Lzham.Intrinsics.Implemented.llvm_memmove_p0_p0_i64.Invoke(parameter_0, parameter_1, parameter_2, parameter_3);
	}

	[MangledName("?flush@lzcompressor@lzham@@QEAA_NW4lzham_flush_t@@@Z")]
	[DemangledName("public: bool __cdecl lzham::lzcompressor::flush(enum lzham_flush_t)")]
	[CleanName("flush")]
	[return: NativeType("bool")]
	public unsafe static bool flush_z9myat(void* @this, [NativeType("enum lzham_flush_t")] int flush_type)
	{
		bool result;
		try
		{
			result = AssetRipper.Conversions.Lzham.GlobalFunctions.flush_z9myat.Invoke(@this, flush_type);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
		return result;
	}

	[MangledName("?compress_block@lzcompressor@lzham@@AEAA_NPEBXI@Z")]
	[DemangledName("private: bool __cdecl lzham::lzcompressor::compress_block(void const *, unsigned int)")]
	[return: NativeType("bool")]
	public unsafe static bool compress_block(void* @this, [NativeType("void const *")] void* pBuf, [NativeType("unsigned int")] int buf_len)
	{
		bool result;
		try
		{
			result = AssetRipper.Conversions.Lzham.GlobalFunctions.compress_block.Invoke(@this, pBuf, buf_len);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
		return result;
	}

	[MangledName("?lzham_flush_buffered_printf@lzham@@YAXXZ")]
	[DemangledName("void __cdecl lzham::lzham_flush_buffered_printf(void)")]
	[return: NativeType("void")]
	public static void lzham_flush_buffered_printf()
	{
		AssetRipper.Conversions.Lzham.GlobalFunctions.lzham_flush_buffered_printf.Invoke();
	}

	[MangledName("?compress_block_internal@lzcompressor@lzham@@AEAA_NPEBXI@Z")]
	[DemangledName("private: bool __cdecl lzham::lzcompressor::compress_block_internal(void const *, unsigned int)")]
	[return: NativeType("bool")]
	public unsafe static bool compress_block_internal(void* @this, [NativeType("void const *")] void* pBuf, [NativeType("unsigned int")] int buf_len)
	{
		bool result;
		try
		{
			result = AssetRipper.Conversions.Lzham.GlobalFunctions.compress_block_internal.Invoke(@this, pBuf, buf_len);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
		return result;
	}

	[MangledName("??0scoped_perf_section@lzham@@QEAA@W4var_args_t@1@PEBDZZ")]
	[DemangledName("public: __cdecl lzham::scoped_perf_section::scoped_perf_section(enum lzham::var_args_t, char const *, ...)")]
	public unsafe static void* _0scoped_perf_section(void* @this, int parameter_1, void* pName, ReadOnlySpan<nint> args)
	{
		return AssetRipper.Conversions.Lzham.GlobalFunctions._0scoped_perf_section.Invoke(@this, parameter_1, pName, args);
	}

	[MangledName("??4state@lzcompressor@lzham@@QEAAAEAV012@AEBV012@@Z")]
	[DemangledName("public: class lzham::lzcompressor::state & __cdecl lzham::lzcompressor::state::operator=(class lzham::lzcompressor::state const &)")]
	[return: NativeType("class lzham::lzcompressor::state &")]
	public unsafe static void* state_Assignment(void* @this, [NativeType("class lzham::lzcompressor::state const &")] void* parameter_1)
	{
		void* result;
		try
		{
			result = AssetRipper.Conversions.Lzham.GlobalFunctions.state_Assignment.Invoke(@this, parameter_1);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
		return result;
	}

	[MangledName("?get_lookahead_pos@search_accelerator@lzham@@QEBAIXZ")]
	[DemangledName("public: unsigned int __cdecl lzham::search_accelerator::get_lookahead_pos(void) const")]
	[return: NativeType("unsigned int")]
	public unsafe static int Get_lookahead_pos(void* @this)
	{
		return AssetRipper.Conversions.Lzham.GlobalFunctions.Get_lookahead_pos.Invoke(@this);
	}

	[MangledName("?get_max_dict_size@search_accelerator@lzham@@QEBAIXZ")]
	[DemangledName("public: unsigned int __cdecl lzham::search_accelerator::get_max_dict_size(void) const")]
	[return: NativeType("unsigned int")]
	public unsafe static int Get_max_dict_size(void* @this)
	{
		return AssetRipper.Conversions.Lzham.GlobalFunctions.Get_max_dict_size.Invoke(@this);
	}

	[MangledName("?send_configuration@lzcompressor@lzham@@AEAA_NXZ")]
	[DemangledName("private: bool __cdecl lzham::lzcompressor::send_configuration(void)")]
	[return: NativeType("bool")]
	public unsafe static bool send_configuration(void* @this)
	{
		return AssetRipper.Conversions.Lzham.GlobalFunctions.send_configuration.Invoke(@this);
	}

	[MangledName("?get_total_recent_reset_update_rate@lzcompressor@lzham@@AEAAIXZ")]
	[DemangledName("private: unsigned int __cdecl lzham::lzcompressor::get_total_recent_reset_update_rate(void)")]
	[return: NativeType("unsigned int")]
	public unsafe static int Get_total_recent_reset_update_rate(void* @this)
	{
		return AssetRipper.Conversions.Lzham.GlobalFunctions.Get_total_recent_reset_update_rate.Invoke(@this);
	}

	[MangledName("?get_recent_block_ratio@lzcompressor@lzham@@AEAAIXZ")]
	[DemangledName("private: unsigned int __cdecl lzham::lzcompressor::get_recent_block_ratio(void)")]
	[return: NativeType("unsigned int")]
	public unsafe static int Get_recent_block_ratio(void* @this)
	{
		return AssetRipper.Conversions.Lzham.GlobalFunctions.Get_recent_block_ratio.Invoke(@this);
	}

	[MangledName("?get_min_block_ratio@lzcompressor@lzham@@AEAAIXZ")]
	[DemangledName("private: unsigned int __cdecl lzham::lzcompressor::get_min_block_ratio(void)")]
	[return: NativeType("unsigned int")]
	public unsafe static int Get_min_block_ratio(void* @this)
	{
		return AssetRipper.Conversions.Lzham.GlobalFunctions.Get_min_block_ratio.Invoke(@this);
	}

	[MangledName("?greedy_parse@lzcompressor@lzham@@AEAA_NAEAUparse_thread_state@12@@Z")]
	[DemangledName("private: bool __cdecl lzham::lzcompressor::greedy_parse(struct lzham::lzcompressor::parse_thread_state &)")]
	[return: NativeType("bool")]
	public unsafe static bool greedy_parse(void* @this, [NativeType("struct lzham::lzcompressor::parse_thread_state &")] void* parse_state)
	{
		bool result;
		try
		{
			result = AssetRipper.Conversions.Lzham.GlobalFunctions.greedy_parse.Invoke(@this, parse_state);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
		return result;
	}

	[MangledName("?size@?$vector@Ulzdecision@lzcompressor@lzham@@@lzham@@QEBAIXZ")]
	[DemangledName("public: unsigned int __cdecl lzham::vector<struct lzham::lzcompressor::lzdecision>::size(void) const")]
	[CleanName("size")]
	[return: NativeType("unsigned int")]
	public unsafe static int size_9gqvur(void* @this)
	{
		return AssetRipper.Conversions.Lzham.GlobalFunctions.size_9gqvur.Invoke(@this);
	}

	[MangledName("??A?$vector@Ulzdecision@lzcompressor@lzham@@@lzham@@QEBAAEBUlzdecision@lzcompressor@1@I@Z")]
	[DemangledName("public: struct lzham::lzcompressor::lzdecision const & __cdecl lzham::vector<struct lzham::lzcompressor::lzdecision>::operator[](unsigned int) const")]
	[return: NativeType("struct lzham::lzcompressor::lzdecision const &")]
	public unsafe static void* vector_struct_lzham_lzcompressor_lzdecision_Operator(void* @this, [NativeType("unsigned int")] int i)
	{
		return AssetRipper.Conversions.Lzham.GlobalFunctions.vector_struct_lzham_lzcompressor_lzdecision_Operator.Invoke(@this, i);
	}

	[MangledName("?get_max_helper_threads@search_accelerator@lzham@@QEBAIXZ")]
	[DemangledName("public: unsigned int __cdecl lzham::search_accelerator::get_max_helper_threads(void) const")]
	[return: NativeType("unsigned int")]
	public unsafe static int Get_max_helper_threads(void* @this)
	{
		return AssetRipper.Conversions.Lzham.GlobalFunctions.Get_max_helper_threads.Invoke(@this);
	}

	[MangledName("?get_num_completed_helper_threads@search_accelerator@lzham@@QEBAJXZ")]
	[DemangledName("public: long __cdecl lzham::search_accelerator::get_num_completed_helper_threads(void) const")]
	[return: NativeType("long")]
	public unsafe static int Get_num_completed_helper_threads(void* @this)
	{
		return AssetRipper.Conversions.Lzham.GlobalFunctions.Get_num_completed_helper_threads.Invoke(@this);
	}

	[MangledName("??0scoped_perf_section@lzham@@QEAA@PEBD@Z")]
	[DemangledName("public: __cdecl lzham::scoped_perf_section::scoped_perf_section(char const *)")]
	public unsafe static void* scoped_perf_section_Constructor(void* @this, [NativeType("char const *")] void* pName)
	{
		return AssetRipper.Conversions.Lzham.GlobalFunctions.scoped_perf_section_Constructor.Invoke(@this, pName);
	}

	[MangledName("?parse_job_callback@lzcompressor@lzham@@AEAAX_KPEAX@Z")]
	[DemangledName("private: void __cdecl lzham::lzcompressor::parse_job_callback(unsigned __int64, void *)")]
	[return: NativeType("void")]
	public unsafe static void parse_job_callback(void* @this, [NativeType("unsigned __int64")] long data, [NativeType("void *")] void* pData_ptr)
	{
		try
		{
			AssetRipper.Conversions.Lzham.GlobalFunctions.parse_job_callback.Invoke(@this, data, pData_ptr);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
	}

	[MangledName("??$queue_multiple_object_tasks@Vlzcompressor@lzham@@P812@EAAX_KPEAX@Z@task_pool@lzham@@QEAA_NPEAVlzcompressor@1@P821@EAAX_KPEAX@Z1I2@Z")]
	[DemangledName("public: bool __cdecl lzham::task_pool::queue_multiple_object_tasks<class lzham::lzcompressor, void (__cdecl lzham::lzcompressor::*)(unsigned __int64, void *)>(class lzham::lzcompressor *, void (__cdecl lzham::lzcompressor::*)(unsigned __int64, void *), unsigned __int64, unsigned int, void *)")]
	[CleanName("queue_multiple_object_tasks")]
	public unsafe static bool queue_multiple_object_tasks_qegt6p(void* @this, void* pObject, void* pObject_method, long first_data, int num_tasks, void* pData_ptr)
	{
		bool result;
		try
		{
			result = AssetRipper.Conversions.Lzham.GlobalFunctions.queue_multiple_object_tasks_qegt6p.Invoke(@this, pObject, pObject_method, first_data, num_tasks, pData_ptr);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
		return result;
	}

	[MangledName("?wait@semaphore@lzham@@QEAA_NI@Z")]
	[DemangledName("public: bool __cdecl lzham::semaphore::wait(unsigned int)")]
	[return: NativeType("bool")]
	public unsafe static bool wait(void* @this, [NativeType("unsigned int")] int milliseconds)
	{
		return AssetRipper.Conversions.Lzham.GlobalFunctions.wait.Invoke(@this, milliseconds);
	}

	[MangledName("?get_ptr@search_accelerator@lzham@@QEBAPEBEI@Z")]
	[DemangledName("public: unsigned char const * __cdecl lzham::search_accelerator::get_ptr(unsigned int) const")]
	[CleanName("Get_ptr")]
	[return: NativeType("unsigned char const *")]
	public unsafe static void* Get_ptr_zs5pn7(void* @this, [NativeType("unsigned int")] int pos)
	{
		return AssetRipper.Conversions.Lzham.GlobalFunctions.Get_ptr_zs5pn7.Invoke(@this, pos);
	}

	[MangledName("?update_block_history@lzcompressor@lzham@@AEAAXIII_N0@Z")]
	[DemangledName("private: void __cdecl lzham::lzcompressor::update_block_history(unsigned int, unsigned int, unsigned int, bool, bool)")]
	[return: NativeType("void")]
	public unsafe static void update_block_history(void* @this, [NativeType("unsigned int")] int comp_size, [NativeType("unsigned int")] int src_size, [NativeType("unsigned int")] int ratio, [NativeType("bool")] bool raw_block, [NativeType("bool")] bool reset_update_rate)
	{
		AssetRipper.Conversions.Lzham.GlobalFunctions.update_block_history.Invoke(@this, comp_size, src_size, ratio, raw_block, reset_update_rate);
	}

	[MangledName("?empty@?$vector@E@lzham@@QEBA_NXZ")]
	[DemangledName("public: bool __cdecl lzham::vector<unsigned char>::empty(void) const")]
	[return: NativeType("bool")]
	public unsafe static bool empty(void* @this)
	{
		return AssetRipper.Conversions.Lzham.GlobalFunctions.empty.Invoke(@this);
	}

	[MangledName("?swap@?$vector@E@lzham@@QEAAXAEAV12@@Z")]
	[DemangledName("public: void __cdecl lzham::vector<unsigned char>::swap(class lzham::vector<unsigned char> &)")]
	[CleanName("swap")]
	[return: NativeType("void")]
	public unsafe static void swap_ufmqqg(void* @this, [NativeType("class lzham::vector<unsigned char> &")] void* other)
	{
		AssetRipper.Conversions.Lzham.GlobalFunctions.swap_ufmqqg.Invoke(@this, other);
	}

	[MangledName("??$swap@PEAE@utils@lzham@@YAXAEAPEAE0@Z")]
	[DemangledName("void __cdecl lzham::utils::swap<unsigned char *>(unsigned char *&, unsigned char *&)")]
	[CleanName("swap")]
	[return: NativeType("void")]
	public unsafe static void swap_8p3mrv([NativeType("unsigned char *&")] void* l, [NativeType("unsigned char *&")] void* r)
	{
		AssetRipper.Conversions.Lzham.GlobalFunctions.swap_8p3mrv.Invoke(l, r);
	}

	[MangledName("??$swap@I@utils@lzham@@YAXAEAI0@Z")]
	[DemangledName("void __cdecl lzham::utils::swap<unsigned int>(unsigned int &, unsigned int &)")]
	[CleanName("swap")]
	[return: NativeType("void")]
	public unsafe static void swap_vigik8([NativeType("unsigned int &")] void* l, [NativeType("unsigned int &")] void* r)
	{
		AssetRipper.Conversions.Lzham.GlobalFunctions.swap_vigik8.Invoke(l, r);
	}

	[MangledName("?extreme_parse@lzcompressor@lzham@@AEAA_NAEAUparse_thread_state@12@@Z")]
	[DemangledName("private: bool __cdecl lzham::lzcompressor::extreme_parse(struct lzham::lzcompressor::parse_thread_state &)")]
	[return: NativeType("bool")]
	public unsafe static bool extreme_parse(void* @this, [NativeType("struct lzham::lzcompressor::parse_thread_state &")] void* parse_state)
	{
		bool result;
		try
		{
			result = AssetRipper.Conversions.Lzham.GlobalFunctions.extreme_parse.Invoke(@this, parse_state);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
		return result;
	}

	[MangledName("?optimal_parse@lzcompressor@lzham@@AEAA_NAEAUparse_thread_state@12@@Z")]
	[DemangledName("private: bool __cdecl lzham::lzcompressor::optimal_parse(struct lzham::lzcompressor::parse_thread_state &)")]
	[return: NativeType("bool")]
	public unsafe static bool optimal_parse(void* @this, [NativeType("struct lzham::lzcompressor::parse_thread_state &")] void* parse_state)
	{
		bool result;
		try
		{
			result = AssetRipper.Conversions.Lzham.GlobalFunctions.optimal_parse.Invoke(@this, parse_state);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
		return result;
	}

	[MangledName("?atomic_decrement32@lzham@@YAJPECJ@Z")]
	[DemangledName("long __cdecl lzham::atomic_decrement32(long volatile *)")]
	[return: NativeType("long")]
	public unsafe static int atomic_decrement32([NativeType("long volatile *")] void* pDest)
	{
		return AssetRipper.Conversions.Lzham.GlobalFunctions.atomic_decrement32.Invoke(pDest);
	}

	[MangledName("?release@semaphore@lzham@@QEAAXJPEAJ@Z")]
	[DemangledName("public: void __cdecl lzham::semaphore::release(long, long *)")]
	[return: NativeType("void")]
	public unsafe static void release(void* @this, [NativeType("long")] int releaseCount, [NativeType("long *")] void* pPreviousCount)
	{
		AssetRipper.Conversions.Lzham.GlobalFunctions.release.Invoke(@this, releaseCount, pPreviousCount);
	}

	[MangledName("?get_max_dict_size_mask@search_accelerator@lzham@@QEBAIXZ")]
	[DemangledName("public: unsigned int __cdecl lzham::search_accelerator::get_max_dict_size_mask(void) const")]
	[return: NativeType("unsigned int")]
	public unsafe static int Get_max_dict_size_mask(void* @this)
	{
		return AssetRipper.Conversions.Lzham.GlobalFunctions.Get_max_dict_size_mask.Invoke(@this);
	}

	[MangledName("?restore_partial_state@state_base@lzcompressor@lzham@@QEAAXAEBU123@@Z")]
	[DemangledName("public: void __cdecl lzham::lzcompressor::state_base::restore_partial_state(struct lzham::lzcompressor::state_base const &)")]
	[return: NativeType("void")]
	public unsafe static void restore_partial_state(void* @this, [NativeType("struct lzham::lzcompressor::state_base const &")] void* src)
	{
		AssetRipper.Conversions.Lzham.GlobalFunctions.restore_partial_state.Invoke(@this, src);
	}

	[MangledName("?save_partial_state@state_base@lzcompressor@lzham@@QEAAXAEAU123@@Z")]
	[DemangledName("public: void __cdecl lzham::lzcompressor::state_base::save_partial_state(struct lzham::lzcompressor::state_base &)")]
	[return: NativeType("void")]
	public unsafe static void save_partial_state(void* @this, [NativeType("struct lzham::lzcompressor::state_base &")] void* dst)
	{
		AssetRipper.Conversions.Lzham.GlobalFunctions.save_partial_state.Invoke(@this, dst);
	}

	[MangledName("?init@lzdecision@lzcompressor@lzham@@QEAAXHHH@Z")]
	[DemangledName("public: void __cdecl lzham::lzcompressor::lzdecision::init(int, int, int)")]
	[CleanName("init")]
	[return: NativeType("void")]
	public unsafe static void init_jzbtc6(void* @this, [NativeType("int")] int pos, [NativeType("int")] int len, [NativeType("int")] int dist)
	{
		AssetRipper.Conversions.Lzham.GlobalFunctions.init_jzbtc6.Invoke(@this, pos, len, dist);
	}

	[MangledName("?get_len@dict_match@lzham@@QEBAIXZ")]
	[DemangledName("public: unsigned int __cdecl lzham::dict_match::get_len(void) const")]
	[CleanName("Get_len")]
	[return: NativeType("unsigned int")]
	public unsafe static int Get_len_xiv86i(void* @this)
	{
		return AssetRipper.Conversions.Lzham.GlobalFunctions.Get_len_xiv86i.Invoke(@this);
	}

	[MangledName("?get_dist@dict_match@lzham@@QEBAIXZ")]
	[DemangledName("public: unsigned int __cdecl lzham::dict_match::get_dist(void) const")]
	[return: NativeType("unsigned int")]
	public unsafe static int Get_dist(void* @this)
	{
		return AssetRipper.Conversions.Lzham.GlobalFunctions.Get_dist.Invoke(@this);
	}

	[MangledName("?is_last@dict_match@lzham@@QEBA_NXZ")]
	[DemangledName("public: bool __cdecl lzham::dict_match::is_last(void) const")]
	[return: NativeType("bool")]
	public unsafe static bool is_last(void* @this)
	{
		return AssetRipper.Conversions.Lzham.GlobalFunctions.is_last.Invoke(@this);
	}

	[MangledName("?try_reserve@?$vector@Ulzdecision@lzcompressor@lzham@@@lzham@@QEAA_NI@Z")]
	[DemangledName("public: bool __cdecl lzham::vector<struct lzham::lzcompressor::lzdecision>::try_reserve(unsigned int)")]
	[CleanName("try_reserve")]
	[return: NativeType("bool")]
	public unsafe static bool try_reserve_x9kr5x(void* @this, [NativeType("unsigned int")] int new_capacity)
	{
		bool result;
		try
		{
			result = AssetRipper.Conversions.Lzham.GlobalFunctions.try_reserve_x9kr5x.Invoke(@this, new_capacity);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
		return result;
	}

	[MangledName("?get_ptr@?$vector@Ulzdecision@lzcompressor@lzham@@@lzham@@QEAAPEAUlzdecision@lzcompressor@2@XZ")]
	[DemangledName("public: struct lzham::lzcompressor::lzdecision * __cdecl lzham::vector<struct lzham::lzcompressor::lzdecision>::get_ptr(void)")]
	[CleanName("Get_ptr")]
	[return: NativeType("struct lzham::lzcompressor::lzdecision *")]
	public unsafe static void* Get_ptr_4r7f9k(void* @this)
	{
		return AssetRipper.Conversions.Lzham.GlobalFunctions.Get_ptr_4r7f9k.Invoke(@this);
	}

	[MangledName("?try_resize@?$vector@Ulzdecision@lzcompressor@lzham@@@lzham@@QEAA_NI_N@Z")]
	[DemangledName("public: bool __cdecl lzham::vector<struct lzham::lzcompressor::lzdecision>::try_resize(unsigned int, bool)")]
	[CleanName("try_resize")]
	[return: NativeType("bool")]
	public unsafe static bool try_resize_aw2beb(void* @this, [NativeType("unsigned int")] int new_size, [NativeType("bool")] bool grow_hint)
	{
		bool result;
		try
		{
			result = AssetRipper.Conversions.Lzham.GlobalFunctions.try_resize_aw2beb.Invoke(@this, new_size, grow_hint);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
		return result;
	}

	[MangledName("?increase_capacity@?$vector@Ulzdecision@lzcompressor@lzham@@@lzham@@AEAA_NI_N0@Z")]
	[DemangledName("private: bool __cdecl lzham::vector<struct lzham::lzcompressor::lzdecision>::increase_capacity(unsigned int, bool, bool)")]
	[CleanName("increase_capacity")]
	[return: NativeType("bool")]
	public unsafe static bool increase_capacity_g3qqmr(void* @this, [NativeType("unsigned int")] int min_new_capacity, [NativeType("bool")] bool grow_hint, [NativeType("bool")] bool nofail)
	{
		bool result;
		try
		{
			result = AssetRipper.Conversions.Lzham.GlobalFunctions.increase_capacity_g3qqmr.Invoke(@this, min_new_capacity, grow_hint, nofail);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
		return result;
	}

	[MangledName("?construct_array@?$scalar_type@Ulzdecision@lzcompressor@lzham@@@lzham@@SAXPEAUlzdecision@lzcompressor@2@I@Z")]
	[DemangledName("public: static void __cdecl lzham::scalar_type<struct lzham::lzcompressor::lzdecision>::construct_array(struct lzham::lzcompressor::lzdecision *, unsigned int)")]
	[CleanName("construct_array")]
	[return: NativeType("void")]
	public unsafe static void construct_array_qask44([NativeType("struct lzham::lzcompressor::lzdecision *")] void* p, [NativeType("unsigned int")] int n)
	{
		AssetRipper.Conversions.Lzham.GlobalFunctions.construct_array_qask44.Invoke(p, n);
	}

	[MangledName("??$construct_array@Ulzdecision@lzcompressor@lzham@@@helpers@lzham@@YAXPEAUlzdecision@lzcompressor@1@I@Z")]
	[DemangledName("void __cdecl lzham::helpers::construct_array<struct lzham::lzcompressor::lzdecision>(struct lzham::lzcompressor::lzdecision *, unsigned int)")]
	[CleanName("construct_array")]
	[return: NativeType("void")]
	public unsafe static void construct_array_ggqgwp([NativeType("struct lzham::lzcompressor::lzdecision *")] void* p, [NativeType("unsigned int")] int n)
	{
		AssetRipper.Conversions.Lzham.GlobalFunctions.construct_array_ggqgwp.Invoke(p, n);
	}

	[MangledName("?object_mover@?$vector@Ulzdecision@lzcompressor@lzham@@@lzham@@CAXPEAX0I@Z")]
	[DemangledName("private: static void __cdecl lzham::vector<struct lzham::lzcompressor::lzdecision>::object_mover(void *, void *, unsigned int)")]
	[CleanName("object_mover")]
	[return: NativeType("void")]
	public unsafe static void object_mover_fu5v7f([NativeType("void *")] void* pDst_void, [NativeType("void *")] void* pSrc_void, [NativeType("unsigned int")] int num)
	{
		AssetRipper.Conversions.Lzham.GlobalFunctions.object_mover_fu5v7f.Invoke(pDst_void, pSrc_void, num);
	}

	[MangledName("?get_cur_dict_size@search_accelerator@lzham@@QEBAIXZ")]
	[DemangledName("public: unsigned int __cdecl lzham::search_accelerator::get_cur_dict_size(void) const")]
	[return: NativeType("unsigned int")]
	public unsafe static int Get_cur_dict_size(void* @this)
	{
		return AssetRipper.Conversions.Lzham.GlobalFunctions.Get_cur_dict_size.Invoke(@this);
	}

	[MangledName("??0lzdecision@lzcompressor@lzham@@QEAA@HHH@Z")]
	[DemangledName("public: __cdecl lzham::lzcompressor::lzdecision::lzdecision(int, int, int)")]
	[CleanName("lzdecision_Constructor")]
	public unsafe static void* lzdecision_Constructor_v5ftey(void* @this, [NativeType("int")] int pos, [NativeType("int")] int len, [NativeType("int")] int dist)
	{
		return AssetRipper.Conversions.Lzham.GlobalFunctions.lzdecision_Constructor_v5ftey.Invoke(@this, pos, len, dist);
	}

	[MangledName("?add_state@node@lzcompressor@lzham@@QEAAXHHAEBUlzdecision@23@AEAVstate@23@_KI@Z")]
	[DemangledName("public: void __cdecl lzham::lzcompressor::node::add_state(int, int, struct lzham::lzcompressor::lzdecision const &, class lzham::lzcompressor::state &, unsigned __int64, unsigned int)")]
	[return: NativeType("void")]
	public unsafe static void add_state(void* @this, [NativeType("int")] int parent_index, [NativeType("int")] int parent_state_index, [NativeType("struct lzham::lzcompressor::lzdecision const &")] void* lzdec, [NativeType("class lzham::lzcompressor::state &")] void* parent_state, [NativeType("unsigned __int64")] long total_cost, [NativeType("unsigned int")] int total_complexity)
	{
		AssetRipper.Conversions.Lzham.GlobalFunctions.add_state.Invoke(@this, parent_index, parent_state_index, lzdec, parent_state, total_cost, total_complexity);
	}

	[MangledName("??8state_base@lzcompressor@lzham@@QEBA_NAEBU012@@Z")]
	[DemangledName("public: bool __cdecl lzham::lzcompressor::state_base::operator==(struct lzham::lzcompressor::state_base const &) const")]
	[return: NativeType("bool")]
	public unsafe static bool state_base_Equals(void* @this, [NativeType("struct lzham::lzcompressor::state_base const &")] void* rhs)
	{
		return AssetRipper.Conversions.Lzham.GlobalFunctions.state_base_Equals.Invoke(@this, rhs);
	}

	[MangledName("??$swap@Unode_state@lzcompressor@lzham@@$0A@@std@@YAXAEAUnode_state@lzcompressor@lzham@@0@Z")]
	[DemangledName("void __cdecl std::swap<struct lzham::lzcompressor::node_state, 0>(struct lzham::lzcompressor::node_state &, struct lzham::lzcompressor::node_state &)")]
	[CleanName("swap")]
	[return: NativeType("void")]
	public unsafe static void swap_bdix5g([MangledName("_Left")][NativeType("struct lzham::lzcompressor::node_state &")] void* Left, [MangledName("_Right")][NativeType("struct lzham::lzcompressor::node_state &")] void* Right)
	{
		AssetRipper.Conversions.Lzham.GlobalFunctions.swap_bdix5g.Invoke(Left, Right);
	}

	[MangledName("?try_reserve@?$vector@Ulzpriced_decision@lzcompressor@lzham@@@lzham@@QEAA_NI@Z")]
	[DemangledName("public: bool __cdecl lzham::vector<struct lzham::lzcompressor::lzpriced_decision>::try_reserve(unsigned int)")]
	[CleanName("try_reserve")]
	[return: NativeType("bool")]
	public unsafe static bool try_reserve_4p788d(void* @this, [NativeType("unsigned int")] int new_capacity)
	{
		bool result;
		try
		{
			result = AssetRipper.Conversions.Lzham.GlobalFunctions.try_reserve_4p788d.Invoke(@this, new_capacity);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
		return result;
	}

	[MangledName("?enumerate_lz_decisions@lzcompressor@lzham@@AEAAHIAEBVstate@12@AEAV?$vector@Ulzpriced_decision@lzcompressor@lzham@@@2@II@Z")]
	[DemangledName("private: int __cdecl lzham::lzcompressor::enumerate_lz_decisions(unsigned int, class lzham::lzcompressor::state const &, class lzham::vector<struct lzham::lzcompressor::lzpriced_decision> &, unsigned int, unsigned int)")]
	[return: NativeType("int")]
	public unsafe static int enumerate_lz_decisions(void* @this, [NativeType("unsigned int")] int ofs, [NativeType("class lzham::lzcompressor::state const &")] void* cur_state, [NativeType("class lzham::vector<struct lzham::lzcompressor::lzpriced_decision> &")] void* decisions, [NativeType("unsigned int")] int min_match_len, [NativeType("unsigned int")] int max_match_len)
	{
		int result;
		try
		{
			result = AssetRipper.Conversions.Lzham.GlobalFunctions.enumerate_lz_decisions.Invoke(@this, ofs, cur_state, decisions, min_match_len, max_match_len);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
		return result;
	}

	[MangledName("??A?$vector@Ulzpriced_decision@lzcompressor@lzham@@@lzham@@QEAAAEAUlzpriced_decision@lzcompressor@1@I@Z")]
	[DemangledName("public: struct lzham::lzcompressor::lzpriced_decision & __cdecl lzham::vector<struct lzham::lzcompressor::lzpriced_decision>::operator[](unsigned int)")]
	[return: NativeType("struct lzham::lzcompressor::lzpriced_decision &")]
	public unsafe static void* vector_struct_lzham_lzcompressor_lzpriced_decision_Operator(void* @this, [NativeType("unsigned int")] int i)
	{
		return AssetRipper.Conversions.Lzham.GlobalFunctions.vector_struct_lzham_lzcompressor_lzpriced_decision_Operator.Invoke(@this, i);
	}

	[MangledName("?try_push_back@?$vector@Ulzdecision@lzcompressor@lzham@@@lzham@@QEAA_NAEBUlzdecision@lzcompressor@2@@Z")]
	[DemangledName("public: bool __cdecl lzham::vector<struct lzham::lzcompressor::lzdecision>::try_push_back(struct lzham::lzcompressor::lzdecision const &)")]
	[CleanName("try_push_back")]
	[return: NativeType("bool")]
	public unsafe static bool try_push_back_cmhkzj(void* @this, [NativeType("struct lzham::lzcompressor::lzdecision const &")] void* obj)
	{
		bool result;
		try
		{
			result = AssetRipper.Conversions.Lzham.GlobalFunctions.try_push_back_cmhkzj.Invoke(@this, obj);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
		return result;
	}

	[MangledName("?construct@?$scalar_type@Ulzdecision@lzcompressor@lzham@@@lzham@@SAXPEAUlzdecision@lzcompressor@2@AEBU342@@Z")]
	[DemangledName("public: static void __cdecl lzham::scalar_type<struct lzham::lzcompressor::lzdecision>::construct(struct lzham::lzcompressor::lzdecision *, struct lzham::lzcompressor::lzdecision const &)")]
	[CleanName("construct")]
	[return: NativeType("void")]
	public unsafe static void construct_9pzk8d([NativeType("struct lzham::lzcompressor::lzdecision *")] void* p, [NativeType("struct lzham::lzcompressor::lzdecision const &")] void* init)
	{
		AssetRipper.Conversions.Lzham.GlobalFunctions.construct_9pzk8d.Invoke(p, init);
	}

	[MangledName("??$construct@Ulzdecision@lzcompressor@lzham@@U123@@helpers@lzham@@YAPEAUlzdecision@lzcompressor@1@PEAU231@AEBU231@@Z")]
	[DemangledName("struct lzham::lzcompressor::lzdecision * __cdecl lzham::helpers::construct<struct lzham::lzcompressor::lzdecision, struct lzham::lzcompressor::lzdecision>(struct lzham::lzcompressor::lzdecision *, struct lzham::lzcompressor::lzdecision const &)")]
	[CleanName("construct")]
	[return: NativeType("struct lzham::lzcompressor::lzdecision *")]
	public unsafe static void* construct_uegpcc([NativeType("struct lzham::lzcompressor::lzdecision *")] void* p, [NativeType("struct lzham::lzcompressor::lzdecision const &")] void* init)
	{
		return AssetRipper.Conversions.Lzham.GlobalFunctions.construct_uegpcc.Invoke(p, init);
	}

	[MangledName("?try_resize@?$vector@Ulzpriced_decision@lzcompressor@lzham@@@lzham@@QEAA_NI_N@Z")]
	[DemangledName("public: bool __cdecl lzham::vector<struct lzham::lzcompressor::lzpriced_decision>::try_resize(unsigned int, bool)")]
	[CleanName("try_resize")]
	[return: NativeType("bool")]
	public unsafe static bool try_resize_zaw49p(void* @this, [NativeType("unsigned int")] int new_size, [NativeType("bool")] bool grow_hint)
	{
		bool result;
		try
		{
			result = AssetRipper.Conversions.Lzham.GlobalFunctions.try_resize_zaw49p.Invoke(@this, new_size, grow_hint);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
		return result;
	}

	[MangledName("?init@lzpriced_decision@lzcompressor@lzham@@QEAAXHHH_K@Z")]
	[DemangledName("public: void __cdecl lzham::lzcompressor::lzpriced_decision::init(int, int, int, unsigned __int64)")]
	[CleanName("init")]
	[return: NativeType("void")]
	public unsafe static void init_3ayd9r(void* @this, [NativeType("int")] int pos, [NativeType("int")] int len, [NativeType("int")] int dist, [NativeType("unsigned __int64")] long cost)
	{
		AssetRipper.Conversions.Lzham.GlobalFunctions.init_3ayd9r.Invoke(@this, pos, len, dist, cost);
	}

	[MangledName("?get_match_len@search_accelerator@lzham@@QEBAIIHII@Z")]
	[DemangledName("public: unsigned int __cdecl lzham::search_accelerator::get_match_len(unsigned int, int, unsigned int, unsigned int) const")]
	[return: NativeType("unsigned int")]
	public unsafe static int Get_match_len(void* @this, [NativeType("unsigned int")] int lookahead_ofs, [NativeType("int")] int dist, [NativeType("unsigned int")] int max_match_len, [NativeType("unsigned int")] int start_match_len)
	{
		return AssetRipper.Conversions.Lzham.GlobalFunctions.Get_match_len.Invoke(@this, lookahead_ofs, dist, max_match_len, start_match_len);
	}

	[MangledName("??0lzpriced_decision@lzcompressor@lzham@@QEAA@HHH@Z")]
	[DemangledName("public: __cdecl lzham::lzcompressor::lzpriced_decision::lzpriced_decision(int, int, int)")]
	[CleanName("lzpriced_decision_Constructor")]
	public unsafe static void* lzpriced_decision_Constructor_a2ewag(void* @this, [NativeType("int")] int pos, [NativeType("int")] int len, [NativeType("int")] int dist)
	{
		return AssetRipper.Conversions.Lzham.GlobalFunctions.lzpriced_decision_Constructor_a2ewag.Invoke(@this, pos, len, dist);
	}

	[MangledName("?try_push_back@?$vector@Ulzpriced_decision@lzcompressor@lzham@@@lzham@@QEAA_NAEBUlzpriced_decision@lzcompressor@2@@Z")]
	[DemangledName("public: bool __cdecl lzham::vector<struct lzham::lzcompressor::lzpriced_decision>::try_push_back(struct lzham::lzcompressor::lzpriced_decision const &)")]
	[CleanName("try_push_back")]
	[return: NativeType("bool")]
	public unsafe static bool try_push_back_9qid3f(void* @this, [NativeType("struct lzham::lzcompressor::lzpriced_decision const &")] void* obj)
	{
		bool result;
		try
		{
			result = AssetRipper.Conversions.Lzham.GlobalFunctions.try_push_back_9qid3f.Invoke(@this, obj);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
		return result;
	}

	[MangledName("?size@?$vector@Ulzpriced_decision@lzcompressor@lzham@@@lzham@@QEBAIXZ")]
	[DemangledName("public: unsigned int __cdecl lzham::vector<struct lzham::lzcompressor::lzpriced_decision>::size(void) const")]
	[CleanName("size")]
	[return: NativeType("unsigned int")]
	public unsafe static int size_n7npue(void* @this)
	{
		return AssetRipper.Conversions.Lzham.GlobalFunctions.size_n7npue.Invoke(@this);
	}

	[MangledName("?get_cost@lzpriced_decision@lzcompressor@lzham@@QEBA_KXZ")]
	[DemangledName("public: unsigned __int64 __cdecl lzham::lzcompressor::lzpriced_decision::get_cost(void) const")]
	[CleanName("Get_cost")]
	[return: NativeType("unsigned __int64")]
	public unsafe static long Get_cost_cpkzqg(void* @this)
	{
		return AssetRipper.Conversions.Lzham.GlobalFunctions.Get_cost_cpkzqg.Invoke(@this);
	}

	[MangledName("?increase_capacity@?$vector@Ulzpriced_decision@lzcompressor@lzham@@@lzham@@AEAA_NI_N0@Z")]
	[DemangledName("private: bool __cdecl lzham::vector<struct lzham::lzcompressor::lzpriced_decision>::increase_capacity(unsigned int, bool, bool)")]
	[CleanName("increase_capacity")]
	[return: NativeType("bool")]
	public unsafe static bool increase_capacity_kdjynu(void* @this, [NativeType("unsigned int")] int min_new_capacity, [NativeType("bool")] bool grow_hint, [NativeType("bool")] bool nofail)
	{
		bool result;
		try
		{
			result = AssetRipper.Conversions.Lzham.GlobalFunctions.increase_capacity_kdjynu.Invoke(@this, min_new_capacity, grow_hint, nofail);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
		return result;
	}

	[MangledName("?construct@?$scalar_type@Ulzpriced_decision@lzcompressor@lzham@@@lzham@@SAXPEAUlzpriced_decision@lzcompressor@2@AEBU342@@Z")]
	[DemangledName("public: static void __cdecl lzham::scalar_type<struct lzham::lzcompressor::lzpriced_decision>::construct(struct lzham::lzcompressor::lzpriced_decision *, struct lzham::lzcompressor::lzpriced_decision const &)")]
	[CleanName("construct")]
	[return: NativeType("void")]
	public unsafe static void construct_xrxbj7([NativeType("struct lzham::lzcompressor::lzpriced_decision *")] void* p, [NativeType("struct lzham::lzcompressor::lzpriced_decision const &")] void* init)
	{
		AssetRipper.Conversions.Lzham.GlobalFunctions.construct_xrxbj7.Invoke(p, init);
	}

	[MangledName("??$construct@Ulzpriced_decision@lzcompressor@lzham@@U123@@helpers@lzham@@YAPEAUlzpriced_decision@lzcompressor@1@PEAU231@AEBU231@@Z")]
	[DemangledName("struct lzham::lzcompressor::lzpriced_decision * __cdecl lzham::helpers::construct<struct lzham::lzcompressor::lzpriced_decision, struct lzham::lzcompressor::lzpriced_decision>(struct lzham::lzcompressor::lzpriced_decision *, struct lzham::lzcompressor::lzpriced_decision const &)")]
	[CleanName("construct")]
	[return: NativeType("struct lzham::lzcompressor::lzpriced_decision *")]
	public unsafe static void* construct_itzgbx([NativeType("struct lzham::lzcompressor::lzpriced_decision *")] void* p, [NativeType("struct lzham::lzcompressor::lzpriced_decision const &")] void* init)
	{
		return AssetRipper.Conversions.Lzham.GlobalFunctions.construct_itzgbx.Invoke(p, init);
	}

	[MangledName("?object_mover@?$vector@Ulzpriced_decision@lzcompressor@lzham@@@lzham@@CAXPEAX0I@Z")]
	[DemangledName("private: static void __cdecl lzham::vector<struct lzham::lzcompressor::lzpriced_decision>::object_mover(void *, void *, unsigned int)")]
	[CleanName("object_mover")]
	[return: NativeType("void")]
	public unsafe static void object_mover_rddqd7([NativeType("void *")] void* pDst_void, [NativeType("void *")] void* pSrc_void, [NativeType("unsigned int")] int num)
	{
		AssetRipper.Conversions.Lzham.GlobalFunctions.object_mover_rddqd7.Invoke(pDst_void, pSrc_void, num);
	}

	[MangledName("?construct_array@?$scalar_type@Ulzpriced_decision@lzcompressor@lzham@@@lzham@@SAXPEAUlzpriced_decision@lzcompressor@2@I@Z")]
	[DemangledName("public: static void __cdecl lzham::scalar_type<struct lzham::lzcompressor::lzpriced_decision>::construct_array(struct lzham::lzcompressor::lzpriced_decision *, unsigned int)")]
	[CleanName("construct_array")]
	[return: NativeType("void")]
	public unsafe static void construct_array_7tay73([NativeType("struct lzham::lzcompressor::lzpriced_decision *")] void* p, [NativeType("unsigned int")] int n)
	{
		AssetRipper.Conversions.Lzham.GlobalFunctions.construct_array_7tay73.Invoke(p, n);
	}

	[MangledName("??$construct_array@Ulzpriced_decision@lzcompressor@lzham@@@helpers@lzham@@YAXPEAUlzpriced_decision@lzcompressor@1@I@Z")]
	[DemangledName("void __cdecl lzham::helpers::construct_array<struct lzham::lzcompressor::lzpriced_decision>(struct lzham::lzcompressor::lzpriced_decision *, unsigned int)")]
	[CleanName("construct_array")]
	[return: NativeType("void")]
	public unsafe static void construct_array_7apt7b([NativeType("struct lzham::lzcompressor::lzpriced_decision *")] void* p, [NativeType("unsigned int")] int n)
	{
		AssetRipper.Conversions.Lzham.GlobalFunctions.construct_array_7apt7b.Invoke(p, n);
	}

	[MangledName("??0lzpriced_decision@lzcompressor@lzham@@QEAA@XZ")]
	[DemangledName("public: __cdecl lzham::lzcompressor::lzpriced_decision::lzpriced_decision(void)")]
	[CleanName("lzpriced_decision_Constructor")]
	public unsafe static void* lzpriced_decision_Constructor_iyvu5a(void* @this)
	{
		return AssetRipper.Conversions.Lzham.GlobalFunctions.lzpriced_decision_Constructor_iyvu5a.Invoke(@this);
	}

	[MangledName("??4adaptive_bit_model@lzham@@QEAAAEAV01@AEBV01@@Z")]
	[DemangledName("public: class lzham::adaptive_bit_model & __cdecl lzham::adaptive_bit_model::operator=(class lzham::adaptive_bit_model const &)")]
	[return: NativeType("class lzham::adaptive_bit_model &")]
	public unsafe static void* adaptive_bit_model_Assignment(void* @this, [NativeType("class lzham::adaptive_bit_model const &")] void* rhs)
	{
		return AssetRipper.Conversions.Lzham.GlobalFunctions.adaptive_bit_model_Assignment.Invoke(@this, rhs);
	}

	[MangledName("??4quasi_adaptive_huffman_data_model@lzham@@QEAAAEAU01@AEBU01@@Z")]
	[DemangledName("public: struct lzham::quasi_adaptive_huffman_data_model & __cdecl lzham::quasi_adaptive_huffman_data_model::operator=(struct lzham::quasi_adaptive_huffman_data_model const &)")]
	[return: NativeType("struct lzham::quasi_adaptive_huffman_data_model &")]
	public unsafe static void* quasi_adaptive_huffman_data_model_Assignment(void* @this, [NativeType("struct lzham::quasi_adaptive_huffman_data_model const &")] void* parameter_1)
	{
		void* result;
		try
		{
			result = AssetRipper.Conversions.Lzham.GlobalFunctions.quasi_adaptive_huffman_data_model_Assignment.Invoke(@this, parameter_1);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
		return result;
	}

	[MangledName("?put_bytes@lzcompressor@lzham@@QEAA_NPEBXI@Z")]
	[DemangledName("public: bool __cdecl lzham::lzcompressor::put_bytes(void const *, unsigned int)")]
	[return: NativeType("bool")]
	public unsafe static bool put_bytes(void* @this, [NativeType("void const *")] void* pBuf, [NativeType("unsigned int")] int buf_len)
	{
		bool result;
		try
		{
			result = AssetRipper.Conversions.Lzham.GlobalFunctions.put_bytes.Invoke(@this, pBuf, buf_len);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
		return result;
	}

	[MangledName("?send_final_block@lzcompressor@lzham@@AEAA_NXZ")]
	[DemangledName("private: bool __cdecl lzham::lzcompressor::send_final_block(void)")]
	[return: NativeType("bool")]
	public unsafe static bool send_final_block(void* @this)
	{
		bool result;
		try
		{
			result = AssetRipper.Conversions.Lzham.GlobalFunctions.send_final_block.Invoke(@this);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
		return result;
	}

	[MangledName("?append@?$vector@E@lzham@@QEAA_NPEBEI@Z")]
	[DemangledName("public: bool __cdecl lzham::vector<unsigned char>::append(unsigned char const *, unsigned int)")]
	[CleanName("append")]
	[return: NativeType("bool")]
	public unsafe static bool append_tcvg7j(void* @this, [NativeType("unsigned char const *")] void* p, [NativeType("unsigned int")] int n)
	{
		bool result;
		try
		{
			result = AssetRipper.Conversions.Lzham.GlobalFunctions.append_tcvg7j.Invoke(@this, p, n);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
		return result;
	}

	[MangledName("?get_max_block_ratio@lzcompressor@lzham@@AEAAIXZ")]
	[DemangledName("private: unsigned int __cdecl lzham::lzcompressor::get_max_block_ratio(void)")]
	[return: NativeType("unsigned int")]
	public unsafe static int Get_max_block_ratio(void* @this)
	{
		return AssetRipper.Conversions.Lzham.GlobalFunctions.Get_max_block_ratio.Invoke(@this);
	}

	[MangledName("?get_match_dist@lzdecision@lzcompressor@lzham@@QEBAIAEBVstate@23@@Z")]
	[DemangledName("public: unsigned int __cdecl lzham::lzcompressor::lzdecision::get_match_dist(class lzham::lzcompressor::state const &) const")]
	[return: NativeType("unsigned int")]
	public unsafe static int Get_match_dist(void* @this, [NativeType("class lzham::lzcompressor::state const &")] void* cur_state)
	{
		return AssetRipper.Conversions.Lzham.GlobalFunctions.Get_match_dist.Invoke(@this, cur_state);
	}

	[MangledName("?is_match@lzdecision@lzcompressor@lzham@@QEBA_NXZ")]
	[DemangledName("public: bool __cdecl lzham::lzcompressor::lzdecision::is_match(void) const")]
	[return: NativeType("bool")]
	public unsafe static bool is_match(void* @this)
	{
		return AssetRipper.Conversions.Lzham.GlobalFunctions.is_match.Invoke(@this);
	}

	[MangledName("?is_rep@lzdecision@lzcompressor@lzham@@QEBA_NXZ")]
	[DemangledName("public: bool __cdecl lzham::lzcompressor::lzdecision::is_rep(void) const")]
	[return: NativeType("bool")]
	public unsafe static bool is_rep(void* @this)
	{
		return AssetRipper.Conversions.Lzham.GlobalFunctions.is_rep.Invoke(@this);
	}

	[MangledName("??0state@lzcompressor@lzham@@QEAA@XZ")]
	[DemangledName("public: __cdecl lzham::lzcompressor::state::state(void)")]
	public unsafe static void* state_Constructor(void* @this)
	{
		void* result;
		try
		{
			result = AssetRipper.Conversions.Lzham.GlobalFunctions.state_Constructor.Invoke(@this);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
		return result;
	}

	[MangledName("?clear@state@lzcompressor@lzham@@QEAAXXZ")]
	[DemangledName("public: void __cdecl lzham::lzcompressor::state::clear(void)")]
	[CleanName("clear")]
	[return: NativeType("void")]
	public unsafe static void clear_y36py8(void* @this)
	{
		try
		{
			AssetRipper.Conversions.Lzham.GlobalFunctions.clear_y36py8.Invoke(@this);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
	}

	[MangledName("?reset@state@lzcompressor@lzham@@QEAAXXZ")]
	[DemangledName("public: void __cdecl lzham::lzcompressor::state::reset(void)")]
	[CleanName("reset")]
	[return: NativeType("void")]
	public unsafe static void reset_2sucmm(void* @this)
	{
		try
		{
			AssetRipper.Conversions.Lzham.GlobalFunctions.reset_2sucmm.Invoke(@this);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
	}

	[MangledName("?init@state@lzcompressor@lzham@@QEAA_NAEAUCLZBase@3@II@Z")]
	[DemangledName("public: bool __cdecl lzham::lzcompressor::state::init(struct lzham::CLZBase &, unsigned int, unsigned int)")]
	[CleanName("init")]
	[return: NativeType("bool")]
	public unsafe static bool init_meqzb7(void* @this, [NativeType("struct lzham::CLZBase &")] void* lzbase, [NativeType("unsigned int")] int table_max_update_interval, [NativeType("unsigned int")] int table_update_interval_slow_rate)
	{
		bool result;
		try
		{
			result = AssetRipper.Conversions.Lzham.GlobalFunctions.init_meqzb7.Invoke(@this, lzbase, table_max_update_interval, table_update_interval_slow_rate);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
		return result;
	}

	[MangledName("?partial_advance@state_base@lzcompressor@lzham@@QEAAXAEBUlzdecision@23@@Z")]
	[DemangledName("public: void __cdecl lzham::lzcompressor::state_base::partial_advance(struct lzham::lzcompressor::lzdecision const &)")]
	[return: NativeType("void")]
	public unsafe static void partial_advance(void* @this, [NativeType("struct lzham::lzcompressor::lzdecision const &")] void* lzdec)
	{
		AssetRipper.Conversions.Lzham.GlobalFunctions.partial_advance.Invoke(@this, lzdec);
	}

	[MangledName("??$swap@I$0A@@std@@YAXAEAI0@Z")]
	[DemangledName("void __cdecl std::swap<unsigned int, 0>(unsigned int &, unsigned int &)")]
	[CleanName("swap")]
	[return: NativeType("void")]
	public unsafe static void swap_8qig99([MangledName("_Left")][NativeType("unsigned int &")] void* Left, [MangledName("_Right")][NativeType("unsigned int &")] void* Right)
	{
		AssetRipper.Conversions.Lzham.GlobalFunctions.swap_8qig99.Invoke(Left, Right);
	}

	[MangledName("?get_pred_char@state@lzcompressor@lzham@@QEBAIAEBVsearch_accelerator@3@HH@Z")]
	[DemangledName("public: unsigned int __cdecl lzham::lzcompressor::state::get_pred_char(class lzham::search_accelerator const &, int, int) const")]
	[return: NativeType("unsigned int")]
	public unsafe static int Get_pred_char(void* @this, [NativeType("class lzham::search_accelerator const &")] void* dict, [NativeType("int")] int pos, [NativeType("int")] int backward_ofs)
	{
		return AssetRipper.Conversions.Lzham.GlobalFunctions.Get_pred_char.Invoke(@this, dict, pos, backward_ofs);
	}

	[MangledName("??Asearch_accelerator@lzham@@QEBAII@Z")]
	[DemangledName("public: unsigned int __cdecl lzham::search_accelerator::operator[](unsigned int) const")]
	[return: NativeType("unsigned int")]
	public unsafe static int search_accelerator_Operator(void* @this, [NativeType("unsigned int")] int pos)
	{
		return AssetRipper.Conversions.Lzham.GlobalFunctions.search_accelerator_Operator.Invoke(@this, pos);
	}

	[MangledName("?get_cost@state@lzcompressor@lzham@@QEBA_KAEAUCLZBase@3@AEBVsearch_accelerator@3@AEBUlzdecision@23@@Z")]
	[DemangledName("public: unsigned __int64 __cdecl lzham::lzcompressor::state::get_cost(struct lzham::CLZBase &, class lzham::search_accelerator const &, struct lzham::lzcompressor::lzdecision const &) const")]
	[CleanName("Get_cost")]
	[return: NativeType("unsigned __int64")]
	public unsafe static long Get_cost_vhfk4j(void* @this, [NativeType("struct lzham::CLZBase &")] void* lzbase, [NativeType("class lzham::search_accelerator const &")] void* dict, [NativeType("struct lzham::lzcompressor::lzdecision const &")] void* lzdec)
	{
		return AssetRipper.Conversions.Lzham.GlobalFunctions.Get_cost_vhfk4j.Invoke(@this, lzbase, dict, lzdec);
	}

	[MangledName("?get_cost@raw_quasi_adaptive_huffman_data_model@lzham@@QEBA_KI@Z")]
	[DemangledName("public: unsigned __int64 __cdecl lzham::raw_quasi_adaptive_huffman_data_model::get_cost(unsigned int) const")]
	[CleanName("Get_cost")]
	[return: NativeType("unsigned __int64")]
	public unsafe static long Get_cost_dep2td(void* @this, [NativeType("unsigned int")] int sym)
	{
		return AssetRipper.Conversions.Lzham.GlobalFunctions.Get_cost_dep2td.Invoke(@this, sym);
	}

	[MangledName("?get_huge_match_code_len@lzham@@YAII@Z")]
	[DemangledName("unsigned int __cdecl lzham::get_huge_match_code_len(unsigned int)")]
	[return: NativeType("unsigned int")]
	public static int Get_huge_match_code_len([NativeType("unsigned int")] int len)
	{
		return AssetRipper.Conversions.Lzham.GlobalFunctions.Get_huge_match_code_len.Invoke(len);
	}

	[MangledName("?convert_to_scaled_bitcost@lzham@@YA_KI@Z")]
	[DemangledName("unsigned __int64 __cdecl lzham::convert_to_scaled_bitcost(unsigned int)")]
	[return: NativeType("unsigned __int64")]
	public static long convert_to_scaled_bitcost([NativeType("unsigned int")] int bits)
	{
		return AssetRipper.Conversions.Lzham.GlobalFunctions.convert_to_scaled_bitcost.Invoke(bits);
	}

	[MangledName("?get_len2_match_cost@state@lzcompressor@lzham@@QEAA_KAEAUCLZBase@3@III@Z")]
	[DemangledName("public: unsigned __int64 __cdecl lzham::lzcompressor::state::get_len2_match_cost(struct lzham::CLZBase &, unsigned int, unsigned int, unsigned int)")]
	[return: NativeType("unsigned __int64")]
	public unsafe static long Get_len2_match_cost(void* @this, [NativeType("struct lzham::CLZBase &")] void* lzbase, [NativeType("unsigned int")] int dict_pos, [NativeType("unsigned int")] int len2_match_dist, [NativeType("unsigned int")] int is_match_model_index)
	{
		return AssetRipper.Conversions.Lzham.GlobalFunctions.Get_len2_match_cost.Invoke(@this, lzbase, dict_pos, len2_match_dist, is_match_model_index);
	}

	[MangledName("?get_lit_cost@state@lzcompressor@lzham@@QEBA_KAEAUCLZBase@3@AEBVsearch_accelerator@3@III@Z")]
	[DemangledName("public: unsigned __int64 __cdecl lzham::lzcompressor::state::get_lit_cost(struct lzham::CLZBase &, class lzham::search_accelerator const &, unsigned int, unsigned int, unsigned int) const")]
	[return: NativeType("unsigned __int64")]
	public unsafe static long Get_lit_cost(void* @this, [NativeType("struct lzham::CLZBase &")] void* lzbase, [NativeType("class lzham::search_accelerator const &")] void* dict, [NativeType("unsigned int")] int dict_pos, [NativeType("unsigned int")] int lit_pred0, [NativeType("unsigned int")] int is_match_model_index)
	{
		return AssetRipper.Conversions.Lzham.GlobalFunctions.Get_lit_cost.Invoke(@this, lzbase, dict, dict_pos, lit_pred0, is_match_model_index);
	}

	[MangledName("?get_rep_match_costs@state@lzcompressor@lzham@@QEBAXIPEA_KIHHI@Z")]
	[DemangledName("public: void __cdecl lzham::lzcompressor::state::get_rep_match_costs(unsigned int, unsigned __int64 *, unsigned int, int, int, unsigned int) const")]
	[return: NativeType("void")]
	public unsafe static void Get_rep_match_costs(void* @this, [NativeType("unsigned int")] int dict_pos, [NativeType("unsigned __int64 *")] void* pBitcosts, [NativeType("unsigned int")] int match_hist_index, [NativeType("int")] int min_len, [NativeType("int")] int max_len, [NativeType("unsigned int")] int is_match_model_index)
	{
		AssetRipper.Conversions.Lzham.GlobalFunctions.Get_rep_match_costs.Invoke(@this, dict_pos, pBitcosts, match_hist_index, min_len, max_len, is_match_model_index);
	}

	[MangledName("?get_full_match_costs@state@lzcompressor@lzham@@QEBAXAEAUCLZBase@3@IPEA_KIHHI@Z")]
	[DemangledName("public: void __cdecl lzham::lzcompressor::state::get_full_match_costs(struct lzham::CLZBase &, unsigned int, unsigned __int64 *, unsigned int, int, int, unsigned int) const")]
	[return: NativeType("void")]
	public unsafe static void Get_full_match_costs(void* @this, [NativeType("struct lzham::CLZBase &")] void* lzbase, [NativeType("unsigned int")] int dict_pos, [NativeType("unsigned __int64 *")] void* pBitcosts, [NativeType("unsigned int")] int match_dist, [NativeType("int")] int min_len, [NativeType("int")] int max_len, [NativeType("unsigned int")] int is_match_model_index)
	{
		AssetRipper.Conversions.Lzham.GlobalFunctions.Get_full_match_costs.Invoke(@this, lzbase, dict_pos, pBitcosts, match_dist, min_len, max_len, is_match_model_index);
	}

	[MangledName("?advance@state@lzcompressor@lzham@@QEAA_NAEAUCLZBase@3@AEBVsearch_accelerator@3@AEBUlzdecision@23@@Z")]
	[DemangledName("public: bool __cdecl lzham::lzcompressor::state::advance(struct lzham::CLZBase &, class lzham::search_accelerator const &, struct lzham::lzcompressor::lzdecision const &)")]
	[return: NativeType("bool")]
	public unsafe static bool advance(void* @this, [NativeType("struct lzham::CLZBase &")] void* lzbase, [NativeType("class lzham::search_accelerator const &")] void* dict, [NativeType("struct lzham::lzcompressor::lzdecision const &")] void* lzdec)
	{
		bool result;
		try
		{
			result = AssetRipper.Conversions.Lzham.GlobalFunctions.advance.Invoke(@this, lzbase, dict, lzdec);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
		return result;
	}

	[MangledName("?update_match_hist@state@lzcompressor@lzham@@QEAAXI@Z")]
	[DemangledName("public: void __cdecl lzham::lzcompressor::state::update_match_hist(unsigned int)")]
	[return: NativeType("void")]
	public unsafe static void update_match_hist(void* @this, [NativeType("unsigned int")] int match_dist)
	{
		AssetRipper.Conversions.Lzham.GlobalFunctions.update_match_hist.Invoke(@this, match_dist);
	}

	[MangledName("?encode@state@lzcompressor@lzham@@QEAA_NAEAVsymbol_codec@3@AEAUCLZBase@3@AEBVsearch_accelerator@3@AEBUlzdecision@23@@Z")]
	[DemangledName("public: bool __cdecl lzham::lzcompressor::state::encode(class lzham::symbol_codec &, struct lzham::CLZBase &, class lzham::search_accelerator const &, struct lzham::lzcompressor::lzdecision const &)")]
	[CleanName("encode")]
	[return: NativeType("bool")]
	public unsafe static bool encode_aguvmj(void* @this, [NativeType("class lzham::symbol_codec &")] void* codec, [NativeType("struct lzham::CLZBase &")] void* lzbase, [NativeType("class lzham::search_accelerator const &")] void* dict, [NativeType("struct lzham::lzcompressor::lzdecision const &")] void* lzdec)
	{
		bool result;
		try
		{
			result = AssetRipper.Conversions.Lzham.GlobalFunctions.encode_aguvmj.Invoke(@this, codec, lzbase, dict, lzdec);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
		return result;
	}

	[MangledName("?get_huge_match_code_bits@lzham@@YAII@Z")]
	[DemangledName("unsigned int __cdecl lzham::get_huge_match_code_bits(unsigned int)")]
	[return: NativeType("unsigned int")]
	public static int Get_huge_match_code_bits([NativeType("unsigned int")] int len)
	{
		return AssetRipper.Conversions.Lzham.GlobalFunctions.Get_huge_match_code_bits.Invoke(len);
	}

	[MangledName("?print@state@lzcompressor@lzham@@QEAAXAEAVsymbol_codec@3@AEAUCLZBase@3@AEBVsearch_accelerator@3@AEBUlzdecision@23@@Z")]
	[DemangledName("public: void __cdecl lzham::lzcompressor::state::print(class lzham::symbol_codec &, struct lzham::CLZBase &, class lzham::search_accelerator const &, struct lzham::lzcompressor::lzdecision const &)")]
	[CleanName("print")]
	[return: NativeType("void")]
	public unsafe static void print_eta4gh(void* @this, [NativeType("class lzham::symbol_codec &")] void* codec, [NativeType("struct lzham::CLZBase &")] void* lzbase, [NativeType("class lzham::search_accelerator const &")] void* dict, [NativeType("struct lzham::lzcompressor::lzdecision const &")] void* lzdec)
	{
		AssetRipper.Conversions.Lzham.GlobalFunctions.print_eta4gh.Invoke(@this, codec, lzbase, dict, lzdec);
	}

	[MangledName("?encode_eob@state@lzcompressor@lzham@@QEAA_NAEAVsymbol_codec@3@AEBVsearch_accelerator@3@I@Z")]
	[DemangledName("public: bool __cdecl lzham::lzcompressor::state::encode_eob(class lzham::symbol_codec &, class lzham::search_accelerator const &, unsigned int)")]
	[return: NativeType("bool")]
	public unsafe static bool encode_eob(void* @this, [NativeType("class lzham::symbol_codec &")] void* codec, [NativeType("class lzham::search_accelerator const &")] void* dict, [NativeType("unsigned int")] int dict_pos)
	{
		bool result;
		try
		{
			result = AssetRipper.Conversions.Lzham.GlobalFunctions.encode_eob.Invoke(@this, codec, dict, dict_pos);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
		return result;
	}

	[MangledName("?encode_reset_state_partial@state@lzcompressor@lzham@@QEAA_NAEAVsymbol_codec@3@AEBVsearch_accelerator@3@I@Z")]
	[DemangledName("public: bool __cdecl lzham::lzcompressor::state::encode_reset_state_partial(class lzham::symbol_codec &, class lzham::search_accelerator const &, unsigned int)")]
	[return: NativeType("bool")]
	public unsafe static bool encode_reset_state_partial(void* @this, [NativeType("class lzham::symbol_codec &")] void* codec, [NativeType("class lzham::search_accelerator const &")] void* dict, [NativeType("unsigned int")] int dict_pos)
	{
		bool result;
		try
		{
			result = AssetRipper.Conversions.Lzham.GlobalFunctions.encode_reset_state_partial.Invoke(@this, codec, dict, dict_pos);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
		return result;
	}

	[MangledName("?reset_state_partial@state@lzcompressor@lzham@@QEAAXXZ")]
	[DemangledName("public: void __cdecl lzham::lzcompressor::state::reset_state_partial(void)")]
	[return: NativeType("void")]
	public unsafe static void reset_state_partial(void* @this)
	{
		AssetRipper.Conversions.Lzham.GlobalFunctions.reset_state_partial.Invoke(@this);
	}

	[MangledName("?find_match_dist@state@lzcompressor@lzham@@QEBAHI@Z")]
	[DemangledName("public: int __cdecl lzham::lzcompressor::state::find_match_dist(unsigned int) const")]
	[return: NativeType("int")]
	public unsafe static int find_match_dist(void* @this, [NativeType("unsigned int")] int match_dist)
	{
		return AssetRipper.Conversions.Lzham.GlobalFunctions.find_match_dist.Invoke(@this, match_dist);
	}

	[MangledName("?start_of_block@state@lzcompressor@lzham@@QEAAXAEBVsearch_accelerator@3@II@Z")]
	[DemangledName("public: void __cdecl lzham::lzcompressor::state::start_of_block(class lzham::search_accelerator const &, unsigned int, unsigned int)")]
	[return: NativeType("void")]
	public unsafe static void start_of_block(void* @this, [NativeType("class lzham::search_accelerator const &")] void* dict, [NativeType("unsigned int")] int cur_ofs, [NativeType("unsigned int")] int block_index)
	{
		AssetRipper.Conversions.Lzham.GlobalFunctions.start_of_block.Invoke(@this, dict, cur_ofs, block_index);
	}

	[MangledName("?reset_update_rate@state@lzcompressor@lzham@@QEAAXXZ")]
	[DemangledName("public: void __cdecl lzham::lzcompressor::state::reset_update_rate(void)")]
	[CleanName("reset_update_rate")]
	[return: NativeType("void")]
	public unsafe static void reset_update_rate_ycr949(void* @this)
	{
		AssetRipper.Conversions.Lzham.GlobalFunctions.reset_update_rate_ycr949.Invoke(@this);
	}

	[MangledName("?clear@coding_stats@lzcompressor@lzham@@QEAAXXZ")]
	[DemangledName("public: void __cdecl lzham::lzcompressor::coding_stats::clear(void)")]
	[CleanName("clear")]
	[return: NativeType("void")]
	public unsafe static void clear_mcufyu(void* @this)
	{
		AssetRipper.Conversions.Lzham.GlobalFunctions.clear_mcufyu.Invoke(@this);
	}

	[MangledName("??$zero_object@$$BY0BAC@I@utils@lzham@@YAXAEAY0BAC@I@Z")]
	[DemangledName("void __cdecl lzham::utils::zero_object<unsigned int[258]>(unsigned int (&)[258])")]
	[CleanName("zero_object")]
	[return: NativeType("void")]
	public unsafe static void zero_object_tcsufu([NativeType("unsigned int (&)[258]")] void* obj)
	{
		AssetRipper.Conversions.Lzham.GlobalFunctions.zero_object_tcsufu.Invoke(obj);
	}

	[MangledName("??$zero_object@$$BY1M@4I@utils@lzham@@YAXAEAY1M@4I@Z")]
	[DemangledName("void __cdecl lzham::utils::zero_object<unsigned int[12][5]>(unsigned int (&)[12][5])")]
	[CleanName("zero_object")]
	[return: NativeType("void")]
	public unsafe static void zero_object_cguijf([NativeType("unsigned int (&)[12][5]")] void* obj)
	{
		AssetRipper.Conversions.Lzham.GlobalFunctions.zero_object_cguijf.Invoke(obj);
	}

	[MangledName("?print@coding_stats@lzcompressor@lzham@@QEAAXXZ")]
	[DemangledName("public: void __cdecl lzham::lzcompressor::coding_stats::print(void)")]
	[CleanName("print")]
	[return: NativeType("void")]
	public unsafe static void print_zz7k6m(void* @this)
	{
		AssetRipper.Conversions.Lzham.GlobalFunctions.print_zz7k6m.Invoke(@this);
	}

	[MangledName("?get_max_val@tracked_stat@lzcompressor@lzham@@QEBANXZ")]
	[DemangledName("public: double __cdecl lzham::lzcompressor::tracked_stat::get_max_val(void) const")]
	[return: NativeType("double")]
	public unsafe static double Get_max_val(void* @this)
	{
		return AssetRipper.Conversions.Lzham.GlobalFunctions.Get_max_val.Invoke(@this);
	}

	[MangledName("?get_min_val@tracked_stat@lzcompressor@lzham@@QEBANXZ")]
	[DemangledName("public: double __cdecl lzham::lzcompressor::tracked_stat::get_min_val(void) const")]
	[return: NativeType("double")]
	public unsafe static double Get_min_val(void* @this)
	{
		return AssetRipper.Conversions.Lzham.GlobalFunctions.Get_min_val.Invoke(@this);
	}

	[MangledName("?get_std_dev@tracked_stat@lzcompressor@lzham@@QEBANXZ")]
	[DemangledName("public: double __cdecl lzham::lzcompressor::tracked_stat::get_std_dev(void) const")]
	[return: NativeType("double")]
	public unsafe static double Get_std_dev(void* @this)
	{
		return AssetRipper.Conversions.Lzham.GlobalFunctions.Get_std_dev.Invoke(@this);
	}

	[MangledName("?get_average@tracked_stat@lzcompressor@lzham@@QEBANXZ")]
	[DemangledName("public: double __cdecl lzham::lzcompressor::tracked_stat::get_average(void) const")]
	[return: NativeType("double")]
	public unsafe static double Get_average(void* @this)
	{
		return AssetRipper.Conversions.Lzham.GlobalFunctions.Get_average.Invoke(@this);
	}

	[MangledName("?get_total@tracked_stat@lzcompressor@lzham@@QEBANXZ")]
	[DemangledName("public: double __cdecl lzham::lzcompressor::tracked_stat::get_total(void) const")]
	[return: NativeType("double")]
	public unsafe static double Get_total(void* @this)
	{
		return AssetRipper.Conversions.Lzham.GlobalFunctions.Get_total.Invoke(@this);
	}

	[MangledName("?get_number_of_values32@tracked_stat@lzcompressor@lzham@@QEAAIXZ")]
	[DemangledName("public: unsigned int __cdecl lzham::lzcompressor::tracked_stat::get_number_of_values32(void)")]
	[return: NativeType("unsigned int")]
	public unsafe static int Get_number_of_values32(void* @this)
	{
		return AssetRipper.Conversions.Lzham.GlobalFunctions.Get_number_of_values32.Invoke(@this);
	}

	[MangledName("llvm.fmuladd.f64")]
	[DemangledName("llvm.fmuladd.f64")]
	public static double llvm_fmuladd_f64(double parameter_0, double parameter_1, double parameter_2)
	{
		return AssetRipper.Conversions.Lzham.Intrinsics.Implemented.llvm_fmuladd_f64.Invoke(parameter_0, parameter_1, parameter_2);
	}

	public static double sqrt(double parameter_0)
	{
		return AssetRipper.Conversions.Lzham.Intrinsics.Implemented.sqrt.Invoke(parameter_0);
	}

	[MangledName("?update@coding_stats@lzcompressor@lzham@@QEAAXAEBUlzdecision@23@AEBVstate@23@AEBVsearch_accelerator@3@_K@Z")]
	[DemangledName("public: void __cdecl lzham::lzcompressor::coding_stats::update(struct lzham::lzcompressor::lzdecision const &, class lzham::lzcompressor::state const &, class lzham::search_accelerator const &, unsigned __int64)")]
	[CleanName("update")]
	[return: NativeType("void")]
	public unsafe static void update_xmta7z(void* @this, [NativeType("struct lzham::lzcompressor::lzdecision const &")] void* lzdec, [NativeType("class lzham::lzcompressor::state const &")] void* cur_state, [NativeType("class lzham::search_accelerator const &")] void* dict, [NativeType("unsigned __int64")] long cost)
	{
		AssetRipper.Conversions.Lzham.GlobalFunctions.update_xmta7z.Invoke(@this, lzdec, cur_state, dict, cost);
	}

	[MangledName("?update@tracked_stat@lzcompressor@lzham@@QEAAXN@Z")]
	[DemangledName("public: void __cdecl lzham::lzcompressor::tracked_stat::update(double)")]
	[CleanName("update")]
	[return: NativeType("void")]
	public unsafe static void update_dvgbkc(void* @this, [NativeType("double")] double val)
	{
		AssetRipper.Conversions.Lzham.GlobalFunctions.update_dvgbkc.Invoke(@this, val);
	}

	[MangledName("??$maximum@N@math@lzham@@YANNN@Z")]
	[DemangledName("double __cdecl lzham::math::maximum<double>(double, double)")]
	[CleanName("maximum")]
	[return: NativeType("double")]
	public static double maximum_qi5jyn([NativeType("double")] double a, [NativeType("double")] double b)
	{
		return AssetRipper.Conversions.Lzham.GlobalFunctions.maximum_qi5jyn.Invoke(a, b);
	}

	[MangledName("?get_lookahead_size@search_accelerator@lzham@@QEBAIXZ")]
	[DemangledName("public: unsigned int __cdecl lzham::search_accelerator::get_lookahead_size(void) const")]
	[return: NativeType("unsigned int")]
	public unsafe static int Get_lookahead_size(void* @this)
	{
		return AssetRipper.Conversions.Lzham.GlobalFunctions.Get_lookahead_size.Invoke(@this);
	}

	[MangledName("??$maximum@H@math@lzham@@YAHHH@Z")]
	[DemangledName("int __cdecl lzham::math::maximum<int>(int, int)")]
	[CleanName("maximum")]
	[return: NativeType("int")]
	public static int maximum_67w4wi([NativeType("int")] int a, [NativeType("int")] int b)
	{
		return AssetRipper.Conversions.Lzham.GlobalFunctions.maximum_67w4wi.Invoke(a, b);
	}

	[MangledName("?is_full_match@lzdecision@lzcompressor@lzham@@QEBA_NXZ")]
	[DemangledName("public: bool __cdecl lzham::lzcompressor::lzdecision::is_full_match(void) const")]
	[return: NativeType("bool")]
	public unsafe static bool is_full_match(void* @this)
	{
		return AssetRipper.Conversions.Lzham.GlobalFunctions.is_full_match.Invoke(@this);
	}

	[MangledName("??$minimum@H@math@lzham@@YAHHH@Z")]
	[DemangledName("int __cdecl lzham::math::minimum<int>(int, int)")]
	[CleanName("minimum")]
	[return: NativeType("int")]
	public static int minimum_y7839s([NativeType("int")] int a, [NativeType("int")] int b)
	{
		return AssetRipper.Conversions.Lzham.GlobalFunctions.minimum_y7839s.Invoke(a, b);
	}

	[MangledName("??0search_accelerator@lzham@@QEAA@XZ")]
	[DemangledName("public: __cdecl lzham::search_accelerator::search_accelerator(void)")]
	public unsafe static void* search_accelerator_Constructor(void* @this)
	{
		void* result;
		try
		{
			result = AssetRipper.Conversions.Lzham.GlobalFunctions.search_accelerator_Constructor.Invoke(@this);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
		return result;
	}

	[MangledName("??0?$vector@I@lzham@@QEAA@XZ")]
	[DemangledName("public: __cdecl lzham::vector<unsigned int>::vector<unsigned int>(void)")]
	public unsafe static void* vector_unsigned_int_Constructor(void* @this)
	{
		return AssetRipper.Conversions.Lzham.GlobalFunctions.vector_unsigned_int_Constructor.Invoke(@this);
	}

	[MangledName("??0?$vector@Unode@lzham@@@lzham@@QEAA@XZ")]
	[DemangledName("public: __cdecl lzham::vector<struct lzham::node>::vector<struct lzham::node>(void)")]
	public unsafe static void* vector_struct_lzham_node_Constructor(void* @this)
	{
		return AssetRipper.Conversions.Lzham.GlobalFunctions.vector_struct_lzham_node_Constructor.Invoke(@this);
	}

	[MangledName("??0?$vector@Udict_match@lzham@@@lzham@@QEAA@XZ")]
	[DemangledName("public: __cdecl lzham::vector<struct lzham::dict_match>::vector<struct lzham::dict_match>(void)")]
	public unsafe static void* vector_struct_lzham_dict_match_Constructor(void* @this)
	{
		return AssetRipper.Conversions.Lzham.GlobalFunctions.vector_struct_lzham_dict_match_Constructor.Invoke(@this);
	}

	[MangledName("??0?$vector@J@lzham@@QEAA@XZ")]
	[DemangledName("public: __cdecl lzham::vector<long>::vector<long>(void)")]
	public unsafe static void* vector_long_Constructor(void* @this)
	{
		return AssetRipper.Conversions.Lzham.GlobalFunctions.vector_long_Constructor.Invoke(@this);
	}

	[MangledName("?init@search_accelerator@lzham@@QEAA_NPEAUCLZBase@2@PEAVtask_pool@2@III_NI@Z")]
	[DemangledName("public: bool __cdecl lzham::search_accelerator::init(struct lzham::CLZBase *, class lzham::task_pool *, unsigned int, unsigned int, unsigned int, bool, unsigned int)")]
	[CleanName("init")]
	[return: NativeType("bool")]
	public unsafe static bool init_mdsfcs(void* @this, [NativeType("struct lzham::CLZBase *")] void* pLZBase, [NativeType("class lzham::task_pool *")] void* pPool, [NativeType("unsigned int")] int max_helper_threads, [NativeType("unsigned int")] int max_dict_size, [NativeType("unsigned int")] int max_matches, [NativeType("bool")] bool all_matches, [NativeType("unsigned int")] int max_probes)
	{
		bool result;
		try
		{
			result = AssetRipper.Conversions.Lzham.GlobalFunctions.init_mdsfcs.Invoke(@this, pLZBase, pPool, max_helper_threads, max_dict_size, max_matches, all_matches, max_probes);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
		return result;
	}

	[MangledName("?try_resize_no_construct@?$vector@E@lzham@@QEAA_NI_N@Z")]
	[DemangledName("public: bool __cdecl lzham::vector<unsigned char>::try_resize_no_construct(unsigned int, bool)")]
	[CleanName("try_resize_no_construct")]
	[return: NativeType("bool")]
	public unsafe static bool try_resize_no_construct_wtjrfv(void* @this, [NativeType("unsigned int")] int new_size, [NativeType("bool")] bool grow_hint)
	{
		bool result;
		try
		{
			result = AssetRipper.Conversions.Lzham.GlobalFunctions.try_resize_no_construct_wtjrfv.Invoke(@this, new_size, grow_hint);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
		return result;
	}

	[MangledName("?try_resize_no_construct@?$vector@I@lzham@@QEAA_NI_N@Z")]
	[DemangledName("public: bool __cdecl lzham::vector<unsigned int>::try_resize_no_construct(unsigned int, bool)")]
	[CleanName("try_resize_no_construct")]
	[return: NativeType("bool")]
	public unsafe static bool try_resize_no_construct_t7khkc(void* @this, [NativeType("unsigned int")] int new_size, [NativeType("bool")] bool grow_hint)
	{
		bool result;
		try
		{
			result = AssetRipper.Conversions.Lzham.GlobalFunctions.try_resize_no_construct_t7khkc.Invoke(@this, new_size, grow_hint);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
		return result;
	}

	[MangledName("?try_resize_no_construct@?$vector@Unode@lzham@@@lzham@@QEAA_NI_N@Z")]
	[DemangledName("public: bool __cdecl lzham::vector<struct lzham::node>::try_resize_no_construct(unsigned int, bool)")]
	[CleanName("try_resize_no_construct")]
	[return: NativeType("bool")]
	public unsafe static bool try_resize_no_construct_tu9ban(void* @this, [NativeType("unsigned int")] int new_size, [NativeType("bool")] bool grow_hint)
	{
		bool result;
		try
		{
			result = AssetRipper.Conversions.Lzham.GlobalFunctions.try_resize_no_construct_tu9ban.Invoke(@this, new_size, grow_hint);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
		return result;
	}

	[MangledName("?get_ptr@?$vector@I@lzham@@QEAAPEAIXZ")]
	[DemangledName("public: unsigned int * __cdecl lzham::vector<unsigned int>::get_ptr(void)")]
	[CleanName("Get_ptr")]
	[return: NativeType("unsigned int *")]
	public unsafe static void* Get_ptr_npwtpj(void* @this)
	{
		return AssetRipper.Conversions.Lzham.GlobalFunctions.Get_ptr_npwtpj.Invoke(@this);
	}

	[MangledName("?size_in_bytes@?$vector@I@lzham@@QEBAIXZ")]
	[DemangledName("public: unsigned int __cdecl lzham::vector<unsigned int>::size_in_bytes(void) const")]
	[CleanName("size_in_bytes")]
	[return: NativeType("unsigned int")]
	public unsafe static int size_in_bytes_uw9qkk(void* @this)
	{
		return AssetRipper.Conversions.Lzham.GlobalFunctions.size_in_bytes_uw9qkk.Invoke(@this);
	}

	[MangledName("?increase_capacity@?$vector@Unode@lzham@@@lzham@@AEAA_NI_N0@Z")]
	[DemangledName("private: bool __cdecl lzham::vector<struct lzham::node>::increase_capacity(unsigned int, bool, bool)")]
	[CleanName("increase_capacity")]
	[return: NativeType("bool")]
	public unsafe static bool increase_capacity_iqf72k(void* @this, [NativeType("unsigned int")] int min_new_capacity, [NativeType("bool")] bool grow_hint, [NativeType("bool")] bool nofail)
	{
		bool result;
		try
		{
			result = AssetRipper.Conversions.Lzham.GlobalFunctions.increase_capacity_iqf72k.Invoke(@this, min_new_capacity, grow_hint, nofail);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
		return result;
	}

	[MangledName("?increase_capacity@?$vector@I@lzham@@AEAA_NI_N0@Z")]
	[DemangledName("private: bool __cdecl lzham::vector<unsigned int>::increase_capacity(unsigned int, bool, bool)")]
	[CleanName("increase_capacity")]
	[return: NativeType("bool")]
	public unsafe static bool increase_capacity_m6yn7p(void* @this, [NativeType("unsigned int")] int min_new_capacity, [NativeType("bool")] bool grow_hint, [NativeType("bool")] bool nofail)
	{
		bool result;
		try
		{
			result = AssetRipper.Conversions.Lzham.GlobalFunctions.increase_capacity_m6yn7p.Invoke(@this, min_new_capacity, grow_hint, nofail);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
		return result;
	}

	[MangledName("?reset@search_accelerator@lzham@@QEAAXXZ")]
	[DemangledName("public: void __cdecl lzham::search_accelerator::reset(void)")]
	[CleanName("reset")]
	[return: NativeType("void")]
	public unsafe static void reset_zf86ia(void* @this)
	{
		AssetRipper.Conversions.Lzham.GlobalFunctions.reset_zf86ia.Invoke(@this);
	}

	[MangledName("?size@?$vector@I@lzham@@QEBAIXZ")]
	[DemangledName("public: unsigned int __cdecl lzham::vector<unsigned int>::size(void) const")]
	[CleanName("size")]
	[return: NativeType("unsigned int")]
	public unsafe static int size_9n9s89(void* @this)
	{
		return AssetRipper.Conversions.Lzham.GlobalFunctions.size_9n9s89.Invoke(@this);
	}

	[MangledName("?flush@search_accelerator@lzham@@QEAAXXZ")]
	[DemangledName("public: void __cdecl lzham::search_accelerator::flush(void)")]
	[CleanName("flush")]
	[return: NativeType("void")]
	public unsafe static void flush_t8im8c(void* @this)
	{
		AssetRipper.Conversions.Lzham.GlobalFunctions.flush_t8im8c.Invoke(@this);
	}

	[MangledName("?get_max_add_bytes@search_accelerator@lzham@@QEBAIXZ")]
	[DemangledName("public: unsigned int __cdecl lzham::search_accelerator::get_max_add_bytes(void) const")]
	[return: NativeType("unsigned int")]
	public unsafe static int Get_max_add_bytes(void* @this)
	{
		return AssetRipper.Conversions.Lzham.GlobalFunctions.Get_max_add_bytes.Invoke(@this);
	}

	[MangledName("?find_all_matches_callback@search_accelerator@lzham@@QEAAX_KPEAX@Z")]
	[DemangledName("public: void __cdecl lzham::search_accelerator::find_all_matches_callback(unsigned __int64, void *)")]
	[return: NativeType("void")]
	public unsafe static void find_all_matches_callback(void* @this, [NativeType("unsigned __int64")] long data, [NativeType("void *")] void* pData_ptr)
	{
		AssetRipper.Conversions.Lzham.GlobalFunctions.find_all_matches_callback.Invoke(@this, data, pData_ptr);
	}

	[MangledName("?hash3_to_16@lzham@@YAIIII@Z")]
	[DemangledName("unsigned int __cdecl lzham::hash3_to_16(unsigned int, unsigned int, unsigned int)")]
	[return: NativeType("unsigned int")]
	public static int hash3_to_16([NativeType("unsigned int")] int c0, [NativeType("unsigned int")] int c1, [NativeType("unsigned int")] int c2)
	{
		return AssetRipper.Conversions.Lzham.GlobalFunctions.hash3_to_16.Invoke(c0, c1, c2);
	}

	[MangledName("??A?$vector@I@lzham@@QEAAAEAII@Z")]
	[DemangledName("public: unsigned int & __cdecl lzham::vector<unsigned int>::operator[](unsigned int)")]
	[return: NativeType("unsigned int &")]
	public unsafe static void* vector_unsigned_int_Operator(void* @this, [NativeType("unsigned int")] int i)
	{
		return AssetRipper.Conversions.Lzham.GlobalFunctions.vector_unsigned_int_Operator.Invoke(@this, i);
	}

	[MangledName("??A?$vector@Unode@lzham@@@lzham@@QEAAAEAUnode@1@I@Z")]
	[DemangledName("public: struct lzham::node & __cdecl lzham::vector<struct lzham::node>::operator[](unsigned int)")]
	[return: NativeType("struct lzham::node &")]
	public unsafe static void* vector_struct_lzham_node_Operator(void* @this, [NativeType("unsigned int")] int i)
	{
		return AssetRipper.Conversions.Lzham.GlobalFunctions.vector_struct_lzham_node_Operator.Invoke(@this, i);
	}

	[MangledName("?atomic_exchange_add@lzham@@YAJPECJJ@Z")]
	[DemangledName("long __cdecl lzham::atomic_exchange_add(long volatile *, long)")]
	[return: NativeType("long")]
	public unsafe static int atomic_exchange_add([NativeType("long volatile *")] void* pDest, [NativeType("long")] int val)
	{
		return AssetRipper.Conversions.Lzham.GlobalFunctions.atomic_exchange_add.Invoke(pDest, val);
	}

	[MangledName("??A?$vector@Udict_match@lzham@@@lzham@@QEAAAEAUdict_match@1@I@Z")]
	[DemangledName("public: struct lzham::dict_match & __cdecl lzham::vector<struct lzham::dict_match>::operator[](unsigned int)")]
	[return: NativeType("struct lzham::dict_match &")]
	public unsafe static void* vector_struct_lzham_dict_match_Operator(void* @this, [NativeType("unsigned int")] int i)
	{
		return AssetRipper.Conversions.Lzham.GlobalFunctions.vector_struct_lzham_dict_match_Operator.Invoke(@this, i);
	}

	[MangledName("??A?$vector@J@lzham@@QEAAAEAJI@Z")]
	[DemangledName("public: long & __cdecl lzham::vector<long>::operator[](unsigned int)")]
	[return: NativeType("long &")]
	public unsafe static void* vector_long_Operator(void* @this, [NativeType("unsigned int")] int i)
	{
		return AssetRipper.Conversions.Lzham.GlobalFunctions.vector_long_Operator.Invoke(@this, i);
	}

	[MangledName("?atomic_exchange32@lzham@@YAJPECJJ@Z")]
	[DemangledName("long __cdecl lzham::atomic_exchange32(long volatile *, long)")]
	[return: NativeType("long")]
	public unsafe static int atomic_exchange32([NativeType("long volatile *")] void* pDest, [NativeType("long")] int val)
	{
		return AssetRipper.Conversions.Lzham.GlobalFunctions.atomic_exchange32.Invoke(pDest, val);
	}

	[MangledName("?atomic_increment32@lzham@@YAJPECJ@Z")]
	[DemangledName("long __cdecl lzham::atomic_increment32(long volatile *)")]
	[return: NativeType("long")]
	public unsafe static int atomic_increment32([NativeType("long volatile *")] void* pDest)
	{
		return AssetRipper.Conversions.Lzham.GlobalFunctions.atomic_increment32.Invoke(pDest);
	}

	[MangledName("?find_len2_matches@search_accelerator@lzham@@QEAA_NXZ")]
	[DemangledName("public: bool __cdecl lzham::search_accelerator::find_len2_matches(void)")]
	[return: NativeType("bool")]
	public unsafe static bool find_len2_matches(void* @this)
	{
		bool result;
		try
		{
			result = AssetRipper.Conversions.Lzham.GlobalFunctions.find_len2_matches.Invoke(@this);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
		return result;
	}

	[MangledName("?try_resize@?$vector@I@lzham@@QEAA_NI_N@Z")]
	[DemangledName("public: bool __cdecl lzham::vector<unsigned int>::try_resize(unsigned int, bool)")]
	[CleanName("try_resize")]
	[return: NativeType("bool")]
	public unsafe static bool try_resize_wakwrt(void* @this, [NativeType("unsigned int")] int new_size, [NativeType("bool")] bool grow_hint)
	{
		bool result;
		try
		{
			result = AssetRipper.Conversions.Lzham.GlobalFunctions.try_resize_wakwrt.Invoke(@this, new_size, grow_hint);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
		return result;
	}

	[MangledName("?hash2_to_12@lzham@@YAIII@Z")]
	[DemangledName("unsigned int __cdecl lzham::hash2_to_12(unsigned int, unsigned int)")]
	[return: NativeType("unsigned int")]
	public static int hash2_to_12([NativeType("unsigned int")] int c0, [NativeType("unsigned int")] int c1)
	{
		return AssetRipper.Conversions.Lzham.GlobalFunctions.hash2_to_12.Invoke(c0, c1);
	}

	[MangledName("?construct_array@?$scalar_type@I@lzham@@SAXPEAII@Z")]
	[DemangledName("public: static void __cdecl lzham::scalar_type<unsigned int>::construct_array(unsigned int *, unsigned int)")]
	[CleanName("construct_array")]
	[return: NativeType("void")]
	public unsafe static void construct_array_2kyzh4([NativeType("unsigned int *")] void* p, [NativeType("unsigned int")] int n)
	{
		AssetRipper.Conversions.Lzham.GlobalFunctions.construct_array_2kyzh4.Invoke(p, n);
	}

	[MangledName("?get_len2_match@search_accelerator@lzham@@QEAAII@Z")]
	[DemangledName("public: unsigned int __cdecl lzham::search_accelerator::get_len2_match(unsigned int)")]
	[return: NativeType("unsigned int")]
	public unsafe static int Get_len2_match(void* @this, [NativeType("unsigned int")] int lookahead_ofs)
	{
		return AssetRipper.Conversions.Lzham.GlobalFunctions.Get_len2_match.Invoke(@this, lookahead_ofs);
	}

	[MangledName("?find_all_matches@search_accelerator@lzham@@QEAA_NI@Z")]
	[DemangledName("public: bool __cdecl lzham::search_accelerator::find_all_matches(unsigned int)")]
	[return: NativeType("bool")]
	public unsafe static bool find_all_matches(void* @this, [NativeType("unsigned int")] int num_bytes)
	{
		bool result;
		try
		{
			result = AssetRipper.Conversions.Lzham.GlobalFunctions.find_all_matches.Invoke(@this, num_bytes);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
		return result;
	}

	[MangledName("?try_resize_no_construct@?$vector@Udict_match@lzham@@@lzham@@QEAA_NI_N@Z")]
	[DemangledName("public: bool __cdecl lzham::vector<struct lzham::dict_match>::try_resize_no_construct(unsigned int, bool)")]
	[CleanName("try_resize_no_construct")]
	[return: NativeType("bool")]
	public unsafe static bool try_resize_no_construct_gzser2(void* @this, [NativeType("unsigned int")] int new_size, [NativeType("bool")] bool grow_hint)
	{
		bool result;
		try
		{
			result = AssetRipper.Conversions.Lzham.GlobalFunctions.try_resize_no_construct_gzser2.Invoke(@this, new_size, grow_hint);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
		return result;
	}

	[MangledName("?try_resize_no_construct@?$vector@J@lzham@@QEAA_NI_N@Z")]
	[DemangledName("public: bool __cdecl lzham::vector<long>::try_resize_no_construct(unsigned int, bool)")]
	[CleanName("try_resize_no_construct")]
	[return: NativeType("bool")]
	public unsafe static bool try_resize_no_construct_e6uwjm(void* @this, [NativeType("unsigned int")] int new_size, [NativeType("bool")] bool grow_hint)
	{
		bool result;
		try
		{
			result = AssetRipper.Conversions.Lzham.GlobalFunctions.try_resize_no_construct_e6uwjm.Invoke(@this, new_size, grow_hint);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
		return result;
	}

	[MangledName("?get_ptr@?$vector@J@lzham@@QEAAPEAJXZ")]
	[DemangledName("public: long * __cdecl lzham::vector<long>::get_ptr(void)")]
	[CleanName("Get_ptr")]
	[return: NativeType("long *")]
	public unsafe static void* Get_ptr_ehx3tj(void* @this)
	{
		return AssetRipper.Conversions.Lzham.GlobalFunctions.Get_ptr_ehx3tj.Invoke(@this);
	}

	[MangledName("?size_in_bytes@?$vector@J@lzham@@QEBAIXZ")]
	[DemangledName("public: unsigned int __cdecl lzham::vector<long>::size_in_bytes(void) const")]
	[CleanName("size_in_bytes")]
	[return: NativeType("unsigned int")]
	public unsafe static int size_in_bytes_425i42(void* @this)
	{
		return AssetRipper.Conversions.Lzham.GlobalFunctions.size_in_bytes_425i42.Invoke(@this);
	}

	[MangledName("?size_in_bytes@?$vector@E@lzham@@QEBAIXZ")]
	[DemangledName("public: unsigned int __cdecl lzham::vector<unsigned char>::size_in_bytes(void) const")]
	[CleanName("size_in_bytes")]
	[return: NativeType("unsigned int")]
	public unsafe static int size_in_bytes_bksyn8(void* @this)
	{
		return AssetRipper.Conversions.Lzham.GlobalFunctions.size_in_bytes_bksyn8.Invoke(@this);
	}

	[MangledName("??$queue_multiple_object_tasks@Vsearch_accelerator@lzham@@P812@EAAX_KPEAX@Z@task_pool@lzham@@QEAA_NPEAVsearch_accelerator@1@P821@EAAX_KPEAX@Z1I2@Z")]
	[DemangledName("public: bool __cdecl lzham::task_pool::queue_multiple_object_tasks<class lzham::search_accelerator, void (__cdecl lzham::search_accelerator::*)(unsigned __int64, void *)>(class lzham::search_accelerator *, void (__cdecl lzham::search_accelerator::*)(unsigned __int64, void *), unsigned __int64, unsigned int, void *)")]
	[CleanName("queue_multiple_object_tasks")]
	public unsafe static bool queue_multiple_object_tasks_i2hqqa(void* @this, void* pObject, void* pObject_method, long first_data, int num_tasks, void* pData_ptr)
	{
		bool result;
		try
		{
			result = AssetRipper.Conversions.Lzham.GlobalFunctions.queue_multiple_object_tasks_i2hqqa.Invoke(@this, pObject, pObject_method, first_data, num_tasks, pData_ptr);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
		return result;
	}

	[MangledName("?increase_capacity@?$vector@J@lzham@@AEAA_NI_N0@Z")]
	[DemangledName("private: bool __cdecl lzham::vector<long>::increase_capacity(unsigned int, bool, bool)")]
	[CleanName("increase_capacity")]
	[return: NativeType("bool")]
	public unsafe static bool increase_capacity_hfvvuj(void* @this, [NativeType("unsigned int")] int min_new_capacity, [NativeType("bool")] bool grow_hint, [NativeType("bool")] bool nofail)
	{
		bool result;
		try
		{
			result = AssetRipper.Conversions.Lzham.GlobalFunctions.increase_capacity_hfvvuj.Invoke(@this, min_new_capacity, grow_hint, nofail);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
		return result;
	}

	[MangledName("?increase_capacity@?$vector@Udict_match@lzham@@@lzham@@AEAA_NI_N0@Z")]
	[DemangledName("private: bool __cdecl lzham::vector<struct lzham::dict_match>::increase_capacity(unsigned int, bool, bool)")]
	[CleanName("increase_capacity")]
	[return: NativeType("bool")]
	public unsafe static bool increase_capacity_wegvee(void* @this, [NativeType("unsigned int")] int min_new_capacity, [NativeType("bool")] bool grow_hint, [NativeType("bool")] bool nofail)
	{
		bool result;
		try
		{
			result = AssetRipper.Conversions.Lzham.GlobalFunctions.increase_capacity_wegvee.Invoke(@this, min_new_capacity, grow_hint, nofail);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
		return result;
	}

	[MangledName("?add_bytes_begin@search_accelerator@lzham@@QEAA_NIPEBE@Z")]
	[DemangledName("public: bool __cdecl lzham::search_accelerator::add_bytes_begin(unsigned int, unsigned char const *)")]
	[return: NativeType("bool")]
	public unsafe static bool add_bytes_begin(void* @this, [NativeType("unsigned int")] int num_bytes, [NativeType("unsigned char const *")] void* pBytes)
	{
		bool result;
		try
		{
			result = AssetRipper.Conversions.Lzham.GlobalFunctions.add_bytes_begin.Invoke(@this, num_bytes, pBytes);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
		return result;
	}

	[MangledName("?add_bytes_end@search_accelerator@lzham@@QEAAXXZ")]
	[DemangledName("public: void __cdecl lzham::search_accelerator::add_bytes_end(void)")]
	[return: NativeType("void")]
	public unsafe static void add_bytes_end(void* @this)
	{
		AssetRipper.Conversions.Lzham.GlobalFunctions.add_bytes_end.Invoke(@this);
	}

	[MangledName("?join@task_pool@lzham@@QEAAXXZ")]
	[DemangledName("public: void __cdecl lzham::task_pool::join(void)")]
	[return: NativeType("void")]
	public unsafe static void join(void* @this)
	{
		AssetRipper.Conversions.Lzham.GlobalFunctions.join.Invoke(@this);
	}

	[MangledName("?find_matches@search_accelerator@lzham@@QEAAPEAUdict_match@2@I_N@Z")]
	[DemangledName("public: struct lzham::dict_match * __cdecl lzham::search_accelerator::find_matches(unsigned int, bool)")]
	[return: NativeType("struct lzham::dict_match *")]
	public unsafe static void* find_matches(void* @this, [NativeType("unsigned int")] int lookahead_ofs, [NativeType("bool")] bool spin)
	{
		return AssetRipper.Conversions.Lzham.GlobalFunctions.find_matches.Invoke(@this, lookahead_ofs, spin);
	}

	[MangledName("?lzham_yield_processor@@YAXXZ")]
	[DemangledName("void __cdecl lzham_yield_processor(void)")]
	[return: NativeType("void")]
	public static void lzham_yield_processor()
	{
		AssetRipper.Conversions.Lzham.GlobalFunctions.lzham_yield_processor.Invoke();
	}

	[MangledName("?lzham_sleep@lzham@@YAXI@Z")]
	[DemangledName("void __cdecl lzham::lzham_sleep(unsigned int)")]
	[return: NativeType("void")]
	public static void lzham_sleep([NativeType("unsigned int")] int milliseconds)
	{
		AssetRipper.Conversions.Lzham.GlobalFunctions.lzham_sleep.Invoke(milliseconds);
	}

	[MangledName("?advance_bytes@search_accelerator@lzham@@QEAAXI@Z")]
	[DemangledName("public: void __cdecl lzham::search_accelerator::advance_bytes(unsigned int)")]
	[return: NativeType("void")]
	public unsafe static void advance_bytes(void* @this, [NativeType("unsigned int")] int num_bytes)
	{
		AssetRipper.Conversions.Lzham.GlobalFunctions.advance_bytes.Invoke(@this, num_bytes);
	}

	public static int lzham_get_version()
	{
		return AssetRipper.Conversions.Lzham.GlobalFunctions.lzham_get_version.Invoke();
	}

	public unsafe static void lzham_set_memory_callbacks(void* pRealloc, void* pMSize, void* pUser_data)
	{
		AssetRipper.Conversions.Lzham.GlobalFunctions.lzham_set_memory_callbacks.Invoke(pRealloc, pMSize, pUser_data);
	}

	public unsafe static void* lzham_decompress_init(void* pParams)
	{
		void* result;
		try
		{
			result = AssetRipper.Conversions.Lzham.GlobalFunctions.lzham_decompress_init.Invoke(pParams);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
		return result;
	}

	public unsafe static void* lzham_decompress_reinit(void* p, void* pParams)
	{
		void* result;
		try
		{
			result = AssetRipper.Conversions.Lzham.GlobalFunctions.lzham_decompress_reinit.Invoke(p, pParams);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
		return result;
	}

	public unsafe static int lzham_decompress_deinit(void* p)
	{
		int result;
		try
		{
			result = AssetRipper.Conversions.Lzham.GlobalFunctions.lzham_decompress_deinit.Invoke(p);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
		return result;
	}

	public unsafe static int lzham_decompress(void* p, void* pIn_buf, void* pIn_buf_size, void* pOut_buf, void* pOut_buf_size, int no_more_input_bytes_flag)
	{
		int result;
		try
		{
			result = AssetRipper.Conversions.Lzham.GlobalFunctions.lzham_decompress.Invoke(p, pIn_buf, pIn_buf_size, pOut_buf, pOut_buf_size, no_more_input_bytes_flag);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
		return result;
	}

	public unsafe static int lzham_decompress_memory(void* pParams, void* pDst_buf, void* pDst_len, void* pSrc_buf, long src_len, void* pAdler32)
	{
		int result;
		try
		{
			result = AssetRipper.Conversions.Lzham.GlobalFunctions.lzham_decompress_memory.Invoke(pParams, pDst_buf, pDst_len, pSrc_buf, src_len, pAdler32);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
		return result;
	}

	public unsafe static void* lzham_compress_init(void* pParams)
	{
		void* result;
		try
		{
			result = AssetRipper.Conversions.Lzham.GlobalFunctions.lzham_compress_init.Invoke(pParams);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
		return result;
	}

	public unsafe static void* lzham_compress_reinit(void* p)
	{
		void* result;
		try
		{
			result = AssetRipper.Conversions.Lzham.GlobalFunctions.lzham_compress_reinit.Invoke(p);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
		return result;
	}

	public unsafe static int lzham_compress_deinit(void* p)
	{
		int result;
		try
		{
			result = AssetRipper.Conversions.Lzham.GlobalFunctions.lzham_compress_deinit.Invoke(p);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
		return result;
	}

	public unsafe static int lzham_compress(void* p, void* pIn_buf, void* pIn_buf_size, void* pOut_buf, void* pOut_buf_size, int no_more_input_bytes_flag)
	{
		int result;
		try
		{
			result = AssetRipper.Conversions.Lzham.GlobalFunctions.lzham_compress.Invoke(p, pIn_buf, pIn_buf_size, pOut_buf, pOut_buf_size, no_more_input_bytes_flag);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
		return result;
	}

	public unsafe static int lzham_compress2(void* p, void* pIn_buf, void* pIn_buf_size, void* pOut_buf, void* pOut_buf_size, int flush_type)
	{
		int result;
		try
		{
			result = AssetRipper.Conversions.Lzham.GlobalFunctions.lzham_compress2.Invoke(p, pIn_buf, pIn_buf_size, pOut_buf, pOut_buf_size, flush_type);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
		return result;
	}

	public unsafe static int lzham_compress_memory(void* pParams, void* pDst_buf, void* pDst_len, void* pSrc_buf, long src_len, void* pAdler32)
	{
		int result;
		try
		{
			result = AssetRipper.Conversions.Lzham.GlobalFunctions.lzham_compress_memory.Invoke(pParams, pDst_buf, pDst_len, pSrc_buf, src_len, pAdler32);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
		return result;
	}

	public unsafe static void* lzham_z_version()
	{
		return AssetRipper.Conversions.Lzham.GlobalFunctions.lzham_z_version.Invoke();
	}

	public unsafe static int lzham_z_adler32(int adler, void* ptr, long buf_len)
	{
		return AssetRipper.Conversions.Lzham.GlobalFunctions.lzham_z_adler32.Invoke(adler, ptr, buf_len);
	}

	public unsafe static int lzham_z_crc32(int crc, void* ptr, long buf_len)
	{
		return AssetRipper.Conversions.Lzham.GlobalFunctions.lzham_z_crc32.Invoke(crc, ptr, buf_len);
	}

	public unsafe static int lzham_z_deflateInit(void* pStream, int level)
	{
		int result;
		try
		{
			result = AssetRipper.Conversions.Lzham.GlobalFunctions.lzham_z_deflateInit.Invoke(pStream, level);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
		return result;
	}

	public unsafe static int lzham_z_deflateInit2(void* pStream, int level, int method, int window_bits, int mem_level, int strategy)
	{
		int result;
		try
		{
			result = AssetRipper.Conversions.Lzham.GlobalFunctions.lzham_z_deflateInit2.Invoke(pStream, level, method, window_bits, mem_level, strategy);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
		return result;
	}

	public unsafe static int lzham_z_deflateReset(void* pStream)
	{
		int result;
		try
		{
			result = AssetRipper.Conversions.Lzham.GlobalFunctions.lzham_z_deflateReset.Invoke(pStream);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
		return result;
	}

	public unsafe static int lzham_z_deflate(void* pStream, int flush)
	{
		int result;
		try
		{
			result = AssetRipper.Conversions.Lzham.GlobalFunctions.lzham_z_deflate.Invoke(pStream, flush);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
		return result;
	}

	public unsafe static int lzham_z_deflateEnd(void* pStream)
	{
		int result;
		try
		{
			result = AssetRipper.Conversions.Lzham.GlobalFunctions.lzham_z_deflateEnd.Invoke(pStream);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
		return result;
	}

	public unsafe static int lzham_z_deflateBound(void* pStream, int source_len)
	{
		return AssetRipper.Conversions.Lzham.GlobalFunctions.lzham_z_deflateBound.Invoke(pStream, source_len);
	}

	public unsafe static int lzham_z_compress(void* pDest, void* pDest_len, void* pSource, int source_len)
	{
		int result;
		try
		{
			result = AssetRipper.Conversions.Lzham.GlobalFunctions.lzham_z_compress.Invoke(pDest, pDest_len, pSource, source_len);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
		return result;
	}

	public unsafe static int lzham_z_compress2(void* pDest, void* pDest_len, void* pSource, int source_len, int level)
	{
		int result;
		try
		{
			result = AssetRipper.Conversions.Lzham.GlobalFunctions.lzham_z_compress2.Invoke(pDest, pDest_len, pSource, source_len, level);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
		return result;
	}

	public static int lzham_z_compressBound(int source_len)
	{
		return AssetRipper.Conversions.Lzham.GlobalFunctions.lzham_z_compressBound.Invoke(source_len);
	}

	public unsafe static int lzham_z_inflateInit(void* pStream)
	{
		int result;
		try
		{
			result = AssetRipper.Conversions.Lzham.GlobalFunctions.lzham_z_inflateInit.Invoke(pStream);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
		return result;
	}

	public unsafe static int lzham_z_inflateInit2(void* pStream, int window_bits)
	{
		int result;
		try
		{
			result = AssetRipper.Conversions.Lzham.GlobalFunctions.lzham_z_inflateInit2.Invoke(pStream, window_bits);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
		return result;
	}

	public unsafe static int lzham_z_inflateReset(void* pStream)
	{
		int result;
		try
		{
			result = AssetRipper.Conversions.Lzham.GlobalFunctions.lzham_z_inflateReset.Invoke(pStream);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
		return result;
	}

	public unsafe static int lzham_z_inflate(void* pStream, int flush)
	{
		int result;
		try
		{
			result = AssetRipper.Conversions.Lzham.GlobalFunctions.lzham_z_inflate.Invoke(pStream, flush);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
		return result;
	}

	public unsafe static int lzham_z_inflateEnd(void* pStream)
	{
		int result;
		try
		{
			result = AssetRipper.Conversions.Lzham.GlobalFunctions.lzham_z_inflateEnd.Invoke(pStream);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
		return result;
	}

	public unsafe static int lzham_z_uncompress(void* pDest, void* pDest_len, void* pSource, int source_len)
	{
		int result;
		try
		{
			result = AssetRipper.Conversions.Lzham.GlobalFunctions.lzham_z_uncompress.Invoke(pDest, pDest_len, pSource, source_len);
		}
		catch
		{
			StackFrameList.ExitToUserCode();
			throw;
		}
		StackFrameList.ExitToUserCode();
		return result;
	}

	public unsafe static void* lzham_z_error(int err)
	{
		return AssetRipper.Conversions.Lzham.GlobalFunctions.lzham_z_error.Invoke(err);
	}
}
