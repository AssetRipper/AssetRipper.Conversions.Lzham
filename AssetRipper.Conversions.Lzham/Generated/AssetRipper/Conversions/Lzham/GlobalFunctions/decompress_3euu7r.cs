using AssetRipper.Conversions.Lzham.GlobalVariables;
using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Intrinsics.Implemented;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("??$decompress@$0A@@lzham_decompressor@lzham@@QEAA?AW4lzham_decompress_status_t@@XZ")]
[DemangledName("public: enum lzham_decompress_status_t __cdecl lzham::lzham_decompressor::decompress<0>(void)")]
[CleanName("decompress")]
internal static partial class decompress_3euu7r
{
	[return: NativeType("enum lzham_decompress_status_t")]
	public unsafe static int Invoke(void* @this)
	{
		void* ptr = @this;
		int num;
		int num2;
		int num4;
		int num5;
		int num6;
		int num7;
		void* pDecomp_buf;
		void* ptr2;
		int num9;
		void* ptr3;
		int num14;
		void* ptr4;
		void* pDecode_tables;
		int num16;
		void* ptr5;
		void* pDecode_tables2;
		void* ptr6;
		void* pDecode_tables3;
		void* ptr7;
		void* pDecode_tables4;
		void* ptr8;
		void* pDecode_tables5;
		int num17;
		void* ptr9;
		void* pDecode_tables6;
		void* ptr10;
		void* pDecode_tables7;
		int num10;
		long num20;
		int num18;
		long num11;
		int num12;
		long num19;
		int num3;
		int num8;
		void* codec;
		int num15;
		int num13;
		unchecked
		{
			codec = &((lzham_lzham_decompressor*)ptr)->m_codec;
			num = 1 << ((lzham_lzham_decompressor*)ptr)->m_params.m_dict_size_log2;
			num2 = num - 1;
			num3 = 0;
			num4 = 0;
			num5 = 0;
			num6 = 0;
			num7 = 0;
			num8 = 0;
			_ = *(long*)((lzham_lzham_decompressor*)ptr)->m_pOut_buf_size;
			pDecomp_buf = ((lzham_lzham_decompressor*)ptr)->m_pDecomp_buf;
			ptr2 = (byte*)((lzham_lzham_decompressor*)ptr)->m_pDecomp_buf + (uint)num;
			int state = ((lzham_lzham_decompressor*)ptr)->m_state;
			if (state != 0)
			{
				if (state != 369)
				{
					if (state != 370)
					{
						if (state != 381)
						{
							if (state != 431)
							{
								if (state != 437)
								{
									if (state != 445)
									{
										if (state != 447)
										{
											if (state != 453)
											{
												if (state != 456)
												{
													if (state != 462)
													{
														if (state != 473)
														{
															if (state != 496)
															{
																if (state != 517)
																{
																	if (state != 520)
																	{
																		if (state != 530)
																		{
																			if (state != 536)
																			{
																				if (state != 551)
																				{
																					if (state != 559)
																					{
																						if (state != 584)
																						{
																							if (state != 588)
																							{
																								if (state != 608)
																								{
																									if (state != 625)
																									{
																										if (state != 640)
																										{
																											if (state != 651)
																											{
																												if (state != 682)
																												{
																													if (state != 705)
																													{
																														if (state != 711)
																														{
																															if (state != 737)
																															{
																																if (state != 757)
																																{
																																	if (state != 774)
																																	{
																																		if (state != 777)
																																		{
																																			if (state != 780)
																																			{
																																				if (state != 787)
																																				{
																																					if (state != 796)
																																					{
																																						if (state != 801)
																																						{
																																							if (state != 810)
																																							{
																																								if (state != 819)
																																								{
																																									if (state != 824)
																																									{
																																										if (state != 828)
																																										{
																																											if (state != 837)
																																											{
																																												if (state != 864)
																																												{
																																													if (state != 898)
																																													{
																																														if (state != 907)
																																														{
																																															if (state != 912)
																																															{
																																																if (state != 929)
																																																{
																																																	if (state != 936)
																																																	{
																																																		if (state != 945)
																																																		{
																																																			if (state != 976)
																																																			{
																																																				if (state != 1002)
																																																				{
																																																					if (state != 1054)
																																																					{
																																																						if (state != 1074)
																																																						{
																																																							if (state != 1080)
																																																							{
																																																								if (state != 1082)
																																																								{
																																																									if (state != 1083)
																																																									{
																																																										if (state == 1110 || state == 1116)
																																																										{
																																																											*(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size = 0L;
																																																											*(long*)((lzham_lzham_decompressor*)ptr)->m_pOut_buf_size = 0L;
																																																											((lzham_lzham_decompressor*)ptr)->m_state = 1116;
																																																											return ((lzham_lzham_decompressor*)ptr)->m_status;
																																																										}
																																																										return ((lzham_lzham_decompressor*)ptr)->m_status;
																																																									}
																																																									decode_set_input_buffer.Invoke(&((lzham_lzham_decompressor*)ptr)->m_codec, eof_flag: (((lzham_lzham_decompressor*)ptr)->m_no_more_input_bytes_flag & 1) == 1, pBuf_next: ((lzham_lzham_decompressor*)ptr)->m_pIn_buf, buf_size: *(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size, pBuf: ((lzham_lzham_decompressor*)ptr)->m_pIn_buf);
																																																									if ((((lzham_lzham_decompressor*)ptr)->m_codec.m_decode_buf_eof & 1) != 1 && ((lzham_lzham_decompressor*)ptr)->m_codec.m_decode_buf_size == 0L)
																																																									{
																																																										goto IL_b171;
																																																									}
																																																									num3 = ((lzham_lzham_decompressor*)ptr)->m_match_hist0;
																																																									num4 = ((lzham_lzham_decompressor*)ptr)->m_match_hist1;
																																																									num5 = ((lzham_lzham_decompressor*)ptr)->m_match_hist2;
																																																									num6 = ((lzham_lzham_decompressor*)ptr)->m_match_hist3;
																																																									num7 = ((lzham_lzham_decompressor*)ptr)->m_cur_state;
																																																									num8 = ((lzham_lzham_decompressor*)ptr)->m_dst_ofs;
																																																									num9 = ((lzham_symbol_codec*)codec)->m_arith_value;
																																																									num10 = ((lzham_symbol_codec*)codec)->m_arith_length;
																																																									num11 = ((lzham_symbol_codec*)codec)->m_bit_buf;
																																																									num12 = ((lzham_symbol_codec*)codec)->m_bit_count;
																																																									ptr3 = ((lzham_symbol_codec*)codec)->m_pDecode_buf_next;
																																																									goto IL_b29a;
																																																								}
																																																								decode_set_input_buffer.Invoke(&((lzham_lzham_decompressor*)ptr)->m_codec, eof_flag: (((lzham_lzham_decompressor*)ptr)->m_no_more_input_bytes_flag & 1) == 1, pBuf_next: ((lzham_lzham_decompressor*)ptr)->m_pIn_buf, buf_size: *(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size, pBuf: ((lzham_lzham_decompressor*)ptr)->m_pIn_buf);
																																																								if ((((lzham_lzham_decompressor*)ptr)->m_codec.m_decode_buf_eof & 1) != 1 && ((lzham_lzham_decompressor*)ptr)->m_codec.m_decode_buf_size == 0L)
																																																								{
																																																									goto IL_aeb2;
																																																								}
																																																								num3 = ((lzham_lzham_decompressor*)ptr)->m_match_hist0;
																																																								num4 = ((lzham_lzham_decompressor*)ptr)->m_match_hist1;
																																																								num5 = ((lzham_lzham_decompressor*)ptr)->m_match_hist2;
																																																								num6 = ((lzham_lzham_decompressor*)ptr)->m_match_hist3;
																																																								num7 = ((lzham_lzham_decompressor*)ptr)->m_cur_state;
																																																								num8 = ((lzham_lzham_decompressor*)ptr)->m_dst_ofs;
																																																								num9 = ((lzham_symbol_codec*)codec)->m_arith_value;
																																																								num10 = ((lzham_symbol_codec*)codec)->m_arith_length;
																																																								num11 = ((lzham_symbol_codec*)codec)->m_bit_buf;
																																																								num12 = ((lzham_symbol_codec*)codec)->m_bit_count;
																																																								ptr3 = ((lzham_symbol_codec*)codec)->m_pDecode_buf_next;
																																																								goto IL_afdb;
																																																							}
																																																							decode_set_input_buffer.Invoke(&((lzham_lzham_decompressor*)ptr)->m_codec, eof_flag: (((lzham_lzham_decompressor*)ptr)->m_no_more_input_bytes_flag & 1) == 1, pBuf_next: ((lzham_lzham_decompressor*)ptr)->m_pIn_buf, buf_size: *(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size, pBuf: ((lzham_lzham_decompressor*)ptr)->m_pIn_buf);
																																																							if ((((lzham_lzham_decompressor*)ptr)->m_codec.m_decode_buf_eof & 1) != 1 && ((lzham_lzham_decompressor*)ptr)->m_codec.m_decode_buf_size == 0L)
																																																							{
																																																								goto IL_abcd;
																																																							}
																																																							num3 = ((lzham_lzham_decompressor*)ptr)->m_match_hist0;
																																																							num4 = ((lzham_lzham_decompressor*)ptr)->m_match_hist1;
																																																							num5 = ((lzham_lzham_decompressor*)ptr)->m_match_hist2;
																																																							num6 = ((lzham_lzham_decompressor*)ptr)->m_match_hist3;
																																																							num7 = ((lzham_lzham_decompressor*)ptr)->m_cur_state;
																																																							num8 = ((lzham_lzham_decompressor*)ptr)->m_dst_ofs;
																																																							num9 = ((lzham_symbol_codec*)codec)->m_arith_value;
																																																							num10 = ((lzham_symbol_codec*)codec)->m_arith_length;
																																																							num11 = ((lzham_symbol_codec*)codec)->m_bit_buf;
																																																							num12 = ((lzham_symbol_codec*)codec)->m_bit_count;
																																																							ptr3 = ((lzham_symbol_codec*)codec)->m_pDecode_buf_next;
																																																							goto IL_acf6;
																																																						}
																																																						decode_set_input_buffer.Invoke(&((lzham_lzham_decompressor*)ptr)->m_codec, eof_flag: (((lzham_lzham_decompressor*)ptr)->m_no_more_input_bytes_flag & 1) == 1, pBuf_next: ((lzham_lzham_decompressor*)ptr)->m_pIn_buf, buf_size: *(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size, pBuf: ((lzham_lzham_decompressor*)ptr)->m_pIn_buf);
																																																						long flush_n = ((lzham_lzham_decompressor*)ptr)->m_flush_n;
																																																						void** pFlush_src = &((lzham_lzham_decompressor*)ptr)->m_pFlush_src;
																																																						*pFlush_src = (byte*)(*pFlush_src) + flush_n;
																																																						long flush_n2 = ((lzham_lzham_decompressor*)ptr)->m_flush_n;
																																																						((lzham_lzham_decompressor*)ptr)->m_flush_num_bytes_remaining -= flush_n2;
																																																						goto IL_a7f4;
																																																					}
																																																					decode_set_input_buffer.Invoke(&((lzham_lzham_decompressor*)ptr)->m_codec, eof_flag: (((lzham_lzham_decompressor*)ptr)->m_no_more_input_bytes_flag & 1) == 1, pBuf_next: ((lzham_lzham_decompressor*)ptr)->m_pIn_buf, buf_size: *(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size, pBuf: ((lzham_lzham_decompressor*)ptr)->m_pIn_buf);
																																																					if ((((lzham_lzham_decompressor*)ptr)->m_codec.m_decode_buf_eof & 1) != 1 && ((lzham_lzham_decompressor*)ptr)->m_codec.m_decode_buf_size == 0L)
																																																					{
																																																						goto IL_a46d;
																																																					}
																																																					num3 = ((lzham_lzham_decompressor*)ptr)->m_match_hist0;
																																																					num4 = ((lzham_lzham_decompressor*)ptr)->m_match_hist1;
																																																					num5 = ((lzham_lzham_decompressor*)ptr)->m_match_hist2;
																																																					num6 = ((lzham_lzham_decompressor*)ptr)->m_match_hist3;
																																																					num7 = ((lzham_lzham_decompressor*)ptr)->m_cur_state;
																																																					num8 = ((lzham_lzham_decompressor*)ptr)->m_dst_ofs;
																																																					num9 = ((lzham_symbol_codec*)codec)->m_arith_value;
																																																					num10 = ((lzham_symbol_codec*)codec)->m_arith_length;
																																																					num11 = ((lzham_symbol_codec*)codec)->m_bit_buf;
																																																					num12 = ((lzham_symbol_codec*)codec)->m_bit_count;
																																																					ptr3 = ((lzham_symbol_codec*)codec)->m_pDecode_buf_next;
																																																					goto IL_a596;
																																																				}
																																																				decode_set_input_buffer.Invoke(&((lzham_lzham_decompressor*)ptr)->m_codec, eof_flag: (((lzham_lzham_decompressor*)ptr)->m_no_more_input_bytes_flag & 1) == 1, pBuf_next: ((lzham_lzham_decompressor*)ptr)->m_pIn_buf, buf_size: *(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size, pBuf: ((lzham_lzham_decompressor*)ptr)->m_pIn_buf);
																																																				long flush_n3 = ((lzham_lzham_decompressor*)ptr)->m_flush_n;
																																																				void** pFlush_src2 = &((lzham_lzham_decompressor*)ptr)->m_pFlush_src;
																																																				*pFlush_src2 = (byte*)(*pFlush_src2) + flush_n3;
																																																				long flush_n4 = ((lzham_lzham_decompressor*)ptr)->m_flush_n;
																																																				((lzham_lzham_decompressor*)ptr)->m_flush_num_bytes_remaining -= flush_n4;
																																																				goto IL_9f77;
																																																			}
																																																			goto IL_9d7d;
																																																		}
																																																		decode_set_input_buffer.Invoke(&((lzham_lzham_decompressor*)ptr)->m_codec, eof_flag: (((lzham_lzham_decompressor*)ptr)->m_no_more_input_bytes_flag & 1) == 1, pBuf_next: ((lzham_lzham_decompressor*)ptr)->m_pIn_buf, buf_size: *(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size, pBuf: ((lzham_lzham_decompressor*)ptr)->m_pIn_buf);
																																																		if ((((lzham_lzham_decompressor*)ptr)->m_codec.m_decode_buf_eof & 1) != 1 && ((lzham_lzham_decompressor*)ptr)->m_codec.m_decode_buf_size == 0L)
																																																		{
																																																			goto IL_98d9;
																																																		}
																																																		num13 = ((lzham_lzham_decompressor*)ptr)->m_match_len;
																																																		num14 = ((lzham_lzham_decompressor*)ptr)->m_match_slot;
																																																		num15 = ((lzham_lzham_decompressor*)ptr)->m_extra_bits;
																																																		num3 = ((lzham_lzham_decompressor*)ptr)->m_match_hist0;
																																																		num4 = ((lzham_lzham_decompressor*)ptr)->m_match_hist1;
																																																		num5 = ((lzham_lzham_decompressor*)ptr)->m_match_hist2;
																																																		num6 = ((lzham_lzham_decompressor*)ptr)->m_match_hist3;
																																																		num7 = ((lzham_lzham_decompressor*)ptr)->m_cur_state;
																																																		num8 = ((lzham_lzham_decompressor*)ptr)->m_dst_ofs;
																																																		num9 = ((lzham_symbol_codec*)codec)->m_arith_value;
																																																		num10 = ((lzham_symbol_codec*)codec)->m_arith_length;
																																																		num11 = ((lzham_symbol_codec*)codec)->m_bit_buf;
																																																		num12 = ((lzham_symbol_codec*)codec)->m_bit_count;
																																																		ptr3 = ((lzham_symbol_codec*)codec)->m_pDecode_buf_next;
																																																		ptr4 = ((lzham_symbol_codec*)codec)->m_pSaved_huff_model;
																																																		pDecode_tables = ((lzham_raw_quasi_adaptive_huffman_data_model*)ptr4)->m_pDecode_tables;
																																																		goto IL_9a2f;
																																																	}
																																																	decode_set_input_buffer.Invoke(&((lzham_lzham_decompressor*)ptr)->m_codec, eof_flag: (((lzham_lzham_decompressor*)ptr)->m_no_more_input_bytes_flag & 1) == 1, pBuf_next: ((lzham_lzham_decompressor*)ptr)->m_pIn_buf, buf_size: *(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size, pBuf: ((lzham_lzham_decompressor*)ptr)->m_pIn_buf);
																																																	if ((((lzham_lzham_decompressor*)ptr)->m_codec.m_decode_buf_eof & 1) != 1 && ((lzham_lzham_decompressor*)ptr)->m_codec.m_decode_buf_size == 0L)
																																																	{
																																																		goto IL_9558;
																																																	}
																																																	num13 = ((lzham_lzham_decompressor*)ptr)->m_match_len;
																																																	num14 = ((lzham_lzham_decompressor*)ptr)->m_match_slot;
																																																	num16 = ((lzham_lzham_decompressor*)ptr)->m_num_extra_bits;
																																																	num3 = ((lzham_lzham_decompressor*)ptr)->m_match_hist0;
																																																	num4 = ((lzham_lzham_decompressor*)ptr)->m_match_hist1;
																																																	num5 = ((lzham_lzham_decompressor*)ptr)->m_match_hist2;
																																																	num6 = ((lzham_lzham_decompressor*)ptr)->m_match_hist3;
																																																	num7 = ((lzham_lzham_decompressor*)ptr)->m_cur_state;
																																																	num8 = ((lzham_lzham_decompressor*)ptr)->m_dst_ofs;
																																																	num9 = ((lzham_symbol_codec*)codec)->m_arith_value;
																																																	num10 = ((lzham_symbol_codec*)codec)->m_arith_length;
																																																	num11 = ((lzham_symbol_codec*)codec)->m_bit_buf;
																																																	num12 = ((lzham_symbol_codec*)codec)->m_bit_count;
																																																	ptr3 = ((lzham_symbol_codec*)codec)->m_pDecode_buf_next;
																																																	goto IL_969c;
																																																}
																																																decode_set_input_buffer.Invoke(&((lzham_lzham_decompressor*)ptr)->m_codec, eof_flag: (((lzham_lzham_decompressor*)ptr)->m_no_more_input_bytes_flag & 1) == 1, pBuf_next: ((lzham_lzham_decompressor*)ptr)->m_pIn_buf, buf_size: *(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size, pBuf: ((lzham_lzham_decompressor*)ptr)->m_pIn_buf);
																																																if ((((lzham_lzham_decompressor*)ptr)->m_codec.m_decode_buf_eof & 1) != 1 && ((lzham_lzham_decompressor*)ptr)->m_codec.m_decode_buf_size == 0L)
																																																{
																																																	goto IL_9218;
																																																}
																																																num13 = ((lzham_lzham_decompressor*)ptr)->m_match_len;
																																																num14 = ((lzham_lzham_decompressor*)ptr)->m_match_slot;
																																																num16 = ((lzham_lzham_decompressor*)ptr)->m_num_extra_bits;
																																																num3 = ((lzham_lzham_decompressor*)ptr)->m_match_hist0;
																																																num4 = ((lzham_lzham_decompressor*)ptr)->m_match_hist1;
																																																num5 = ((lzham_lzham_decompressor*)ptr)->m_match_hist2;
																																																num6 = ((lzham_lzham_decompressor*)ptr)->m_match_hist3;
																																																num7 = ((lzham_lzham_decompressor*)ptr)->m_cur_state;
																																																num8 = ((lzham_lzham_decompressor*)ptr)->m_dst_ofs;
																																																num9 = ((lzham_symbol_codec*)codec)->m_arith_value;
																																																num10 = ((lzham_symbol_codec*)codec)->m_arith_length;
																																																num11 = ((lzham_symbol_codec*)codec)->m_bit_buf;
																																																num12 = ((lzham_symbol_codec*)codec)->m_bit_count;
																																																ptr3 = ((lzham_symbol_codec*)codec)->m_pDecode_buf_next;
																																																goto IL_935c;
																																															}
																																															decode_set_input_buffer.Invoke(&((lzham_lzham_decompressor*)ptr)->m_codec, eof_flag: (((lzham_lzham_decompressor*)ptr)->m_no_more_input_bytes_flag & 1) == 1, pBuf_next: ((lzham_lzham_decompressor*)ptr)->m_pIn_buf, buf_size: *(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size, pBuf: ((lzham_lzham_decompressor*)ptr)->m_pIn_buf);
																																															if ((((lzham_lzham_decompressor*)ptr)->m_codec.m_decode_buf_eof & 1) != 1 && ((lzham_lzham_decompressor*)ptr)->m_codec.m_decode_buf_size == 0L)
																																															{
																																																goto IL_8e5e;
																																															}
																																															num13 = ((lzham_lzham_decompressor*)ptr)->m_match_len;
																																															num14 = ((lzham_lzham_decompressor*)ptr)->m_match_slot;
																																															num3 = ((lzham_lzham_decompressor*)ptr)->m_match_hist0;
																																															num4 = ((lzham_lzham_decompressor*)ptr)->m_match_hist1;
																																															num5 = ((lzham_lzham_decompressor*)ptr)->m_match_hist2;
																																															num6 = ((lzham_lzham_decompressor*)ptr)->m_match_hist3;
																																															num7 = ((lzham_lzham_decompressor*)ptr)->m_cur_state;
																																															num8 = ((lzham_lzham_decompressor*)ptr)->m_dst_ofs;
																																															num9 = ((lzham_symbol_codec*)codec)->m_arith_value;
																																															num10 = ((lzham_symbol_codec*)codec)->m_arith_length;
																																															num11 = ((lzham_symbol_codec*)codec)->m_bit_buf;
																																															num12 = ((lzham_symbol_codec*)codec)->m_bit_count;
																																															ptr3 = ((lzham_symbol_codec*)codec)->m_pDecode_buf_next;
																																															goto IL_8f99;
																																														}
																																														decode_set_input_buffer.Invoke(&((lzham_lzham_decompressor*)ptr)->m_codec, eof_flag: (((lzham_lzham_decompressor*)ptr)->m_no_more_input_bytes_flag & 1) == 1, pBuf_next: ((lzham_lzham_decompressor*)ptr)->m_pIn_buf, buf_size: *(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size, pBuf: ((lzham_lzham_decompressor*)ptr)->m_pIn_buf);
																																														if ((((lzham_lzham_decompressor*)ptr)->m_codec.m_decode_buf_eof & 1) != 1 && ((lzham_lzham_decompressor*)ptr)->m_codec.m_decode_buf_size == 0L)
																																														{
																																															goto IL_8b43;
																																														}
																																														num13 = ((lzham_lzham_decompressor*)ptr)->m_match_len;
																																														num14 = ((lzham_lzham_decompressor*)ptr)->m_match_slot;
																																														num3 = ((lzham_lzham_decompressor*)ptr)->m_match_hist0;
																																														num4 = ((lzham_lzham_decompressor*)ptr)->m_match_hist1;
																																														num5 = ((lzham_lzham_decompressor*)ptr)->m_match_hist2;
																																														num6 = ((lzham_lzham_decompressor*)ptr)->m_match_hist3;
																																														num7 = ((lzham_lzham_decompressor*)ptr)->m_cur_state;
																																														num8 = ((lzham_lzham_decompressor*)ptr)->m_dst_ofs;
																																														num9 = ((lzham_symbol_codec*)codec)->m_arith_value;
																																														num10 = ((lzham_symbol_codec*)codec)->m_arith_length;
																																														num11 = ((lzham_symbol_codec*)codec)->m_bit_buf;
																																														num12 = ((lzham_symbol_codec*)codec)->m_bit_count;
																																														ptr3 = ((lzham_symbol_codec*)codec)->m_pDecode_buf_next;
																																														goto IL_8c7e;
																																													}
																																													decode_set_input_buffer.Invoke(&((lzham_lzham_decompressor*)ptr)->m_codec, eof_flag: (((lzham_lzham_decompressor*)ptr)->m_no_more_input_bytes_flag & 1) == 1, pBuf_next: ((lzham_lzham_decompressor*)ptr)->m_pIn_buf, buf_size: *(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size, pBuf: ((lzham_lzham_decompressor*)ptr)->m_pIn_buf);
																																													if ((((lzham_lzham_decompressor*)ptr)->m_codec.m_decode_buf_eof & 1) != 1 && ((lzham_lzham_decompressor*)ptr)->m_codec.m_decode_buf_size == 0L)
																																													{
																																														goto IL_8679;
																																													}
																																													num13 = ((lzham_lzham_decompressor*)ptr)->m_match_len;
																																													num14 = ((lzham_lzham_decompressor*)ptr)->m_match_slot;
																																													num3 = ((lzham_lzham_decompressor*)ptr)->m_match_hist0;
																																													num4 = ((lzham_lzham_decompressor*)ptr)->m_match_hist1;
																																													num5 = ((lzham_lzham_decompressor*)ptr)->m_match_hist2;
																																													num6 = ((lzham_lzham_decompressor*)ptr)->m_match_hist3;
																																													num7 = ((lzham_lzham_decompressor*)ptr)->m_cur_state;
																																													num8 = ((lzham_lzham_decompressor*)ptr)->m_dst_ofs;
																																													num9 = ((lzham_symbol_codec*)codec)->m_arith_value;
																																													num10 = ((lzham_symbol_codec*)codec)->m_arith_length;
																																													num11 = ((lzham_symbol_codec*)codec)->m_bit_buf;
																																													num12 = ((lzham_symbol_codec*)codec)->m_bit_count;
																																													ptr3 = ((lzham_symbol_codec*)codec)->m_pDecode_buf_next;
																																													ptr5 = ((lzham_symbol_codec*)codec)->m_pSaved_huff_model;
																																													pDecode_tables2 = ((lzham_raw_quasi_adaptive_huffman_data_model*)ptr5)->m_pDecode_tables;
																																													goto IL_87c6;
																																												}
																																												decode_set_input_buffer.Invoke(&((lzham_lzham_decompressor*)ptr)->m_codec, eof_flag: (((lzham_lzham_decompressor*)ptr)->m_no_more_input_bytes_flag & 1) == 1, pBuf_next: ((lzham_lzham_decompressor*)ptr)->m_pIn_buf, buf_size: *(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size, pBuf: ((lzham_lzham_decompressor*)ptr)->m_pIn_buf);
																																												if ((((lzham_lzham_decompressor*)ptr)->m_codec.m_decode_buf_eof & 1) != 1 && ((lzham_lzham_decompressor*)ptr)->m_codec.m_decode_buf_size == 0L)
																																												{
																																													goto IL_8121;
																																												}
																																												num13 = ((lzham_lzham_decompressor*)ptr)->m_match_len;
																																												num3 = ((lzham_lzham_decompressor*)ptr)->m_match_hist0;
																																												num4 = ((lzham_lzham_decompressor*)ptr)->m_match_hist1;
																																												num5 = ((lzham_lzham_decompressor*)ptr)->m_match_hist2;
																																												num6 = ((lzham_lzham_decompressor*)ptr)->m_match_hist3;
																																												num7 = ((lzham_lzham_decompressor*)ptr)->m_cur_state;
																																												num8 = ((lzham_lzham_decompressor*)ptr)->m_dst_ofs;
																																												num9 = ((lzham_symbol_codec*)codec)->m_arith_value;
																																												num10 = ((lzham_symbol_codec*)codec)->m_arith_length;
																																												num11 = ((lzham_symbol_codec*)codec)->m_bit_buf;
																																												num12 = ((lzham_symbol_codec*)codec)->m_bit_count;
																																												ptr3 = ((lzham_symbol_codec*)codec)->m_pDecode_buf_next;
																																												ptr6 = ((lzham_symbol_codec*)codec)->m_pSaved_huff_model;
																																												pDecode_tables3 = ((lzham_raw_quasi_adaptive_huffman_data_model*)ptr6)->m_pDecode_tables;
																																												goto IL_8265;
																																											}
																																											decode_set_input_buffer.Invoke(&((lzham_lzham_decompressor*)ptr)->m_codec, eof_flag: (((lzham_lzham_decompressor*)ptr)->m_no_more_input_bytes_flag & 1) == 1, pBuf_next: ((lzham_lzham_decompressor*)ptr)->m_pIn_buf, buf_size: *(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size, pBuf: ((lzham_lzham_decompressor*)ptr)->m_pIn_buf);
																																											if ((((lzham_lzham_decompressor*)ptr)->m_codec.m_decode_buf_eof & 1) != 1 && ((lzham_lzham_decompressor*)ptr)->m_codec.m_decode_buf_size == 0L)
																																											{
																																												goto IL_7cd3;
																																											}
																																											num13 = ((lzham_lzham_decompressor*)ptr)->m_match_len;
																																											num3 = ((lzham_lzham_decompressor*)ptr)->m_match_hist0;
																																											num4 = ((lzham_lzham_decompressor*)ptr)->m_match_hist1;
																																											num5 = ((lzham_lzham_decompressor*)ptr)->m_match_hist2;
																																											num6 = ((lzham_lzham_decompressor*)ptr)->m_match_hist3;
																																											num7 = ((lzham_lzham_decompressor*)ptr)->m_cur_state;
																																											num8 = ((lzham_lzham_decompressor*)ptr)->m_dst_ofs;
																																											num9 = ((lzham_symbol_codec*)codec)->m_arith_value;
																																											num10 = ((lzham_symbol_codec*)codec)->m_arith_length;
																																											num11 = ((lzham_symbol_codec*)codec)->m_bit_buf;
																																											num12 = ((lzham_symbol_codec*)codec)->m_bit_count;
																																											ptr3 = ((lzham_symbol_codec*)codec)->m_pDecode_buf_next;
																																											goto IL_7e05;
																																										}
																																										decode_set_input_buffer.Invoke(&((lzham_lzham_decompressor*)ptr)->m_codec, eof_flag: (((lzham_lzham_decompressor*)ptr)->m_no_more_input_bytes_flag & 1) == 1, pBuf_next: ((lzham_lzham_decompressor*)ptr)->m_pIn_buf, buf_size: *(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size, pBuf: ((lzham_lzham_decompressor*)ptr)->m_pIn_buf);
																																										if ((((lzham_lzham_decompressor*)ptr)->m_codec.m_decode_buf_eof & 1) != 1 && ((lzham_lzham_decompressor*)ptr)->m_codec.m_decode_buf_size == 0L)
																																										{
																																											goto IL_78d1;
																																										}
																																										num13 = ((lzham_lzham_decompressor*)ptr)->m_match_len;
																																										num3 = ((lzham_lzham_decompressor*)ptr)->m_match_hist0;
																																										num4 = ((lzham_lzham_decompressor*)ptr)->m_match_hist1;
																																										num5 = ((lzham_lzham_decompressor*)ptr)->m_match_hist2;
																																										num6 = ((lzham_lzham_decompressor*)ptr)->m_match_hist3;
																																										num7 = ((lzham_lzham_decompressor*)ptr)->m_cur_state;
																																										num8 = ((lzham_lzham_decompressor*)ptr)->m_dst_ofs;
																																										num9 = ((lzham_symbol_codec*)codec)->m_arith_value;
																																										num10 = ((lzham_symbol_codec*)codec)->m_arith_length;
																																										num11 = ((lzham_symbol_codec*)codec)->m_bit_buf;
																																										num12 = ((lzham_symbol_codec*)codec)->m_bit_count;
																																										ptr3 = ((lzham_symbol_codec*)codec)->m_pDecode_buf_next;
																																										goto IL_7a03;
																																									}
																																									decode_set_input_buffer.Invoke(&((lzham_lzham_decompressor*)ptr)->m_codec, eof_flag: (((lzham_lzham_decompressor*)ptr)->m_no_more_input_bytes_flag & 1) == 1, pBuf_next: ((lzham_lzham_decompressor*)ptr)->m_pIn_buf, buf_size: *(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size, pBuf: ((lzham_lzham_decompressor*)ptr)->m_pIn_buf);
																																									if ((((lzham_lzham_decompressor*)ptr)->m_codec.m_decode_buf_eof & 1) != 1 && ((lzham_lzham_decompressor*)ptr)->m_codec.m_decode_buf_size == 0L)
																																									{
																																										goto IL_7538;
																																									}
																																									num13 = ((lzham_lzham_decompressor*)ptr)->m_match_len;
																																									num3 = ((lzham_lzham_decompressor*)ptr)->m_match_hist0;
																																									num4 = ((lzham_lzham_decompressor*)ptr)->m_match_hist1;
																																									num5 = ((lzham_lzham_decompressor*)ptr)->m_match_hist2;
																																									num6 = ((lzham_lzham_decompressor*)ptr)->m_match_hist3;
																																									num7 = ((lzham_lzham_decompressor*)ptr)->m_cur_state;
																																									num8 = ((lzham_lzham_decompressor*)ptr)->m_dst_ofs;
																																									num9 = ((lzham_symbol_codec*)codec)->m_arith_value;
																																									num10 = ((lzham_symbol_codec*)codec)->m_arith_length;
																																									num11 = ((lzham_symbol_codec*)codec)->m_bit_buf;
																																									num12 = ((lzham_symbol_codec*)codec)->m_bit_count;
																																									ptr3 = ((lzham_symbol_codec*)codec)->m_pDecode_buf_next;
																																									goto IL_766a;
																																								}
																																								decode_set_input_buffer.Invoke(&((lzham_lzham_decompressor*)ptr)->m_codec, eof_flag: (((lzham_lzham_decompressor*)ptr)->m_no_more_input_bytes_flag & 1) == 1, pBuf_next: ((lzham_lzham_decompressor*)ptr)->m_pIn_buf, buf_size: *(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size, pBuf: ((lzham_lzham_decompressor*)ptr)->m_pIn_buf);
																																								if ((((lzham_lzham_decompressor*)ptr)->m_codec.m_decode_buf_eof & 1) != 1 && ((lzham_lzham_decompressor*)ptr)->m_codec.m_decode_buf_size == 0L)
																																								{
																																									goto IL_7237;
																																								}
																																								num13 = ((lzham_lzham_decompressor*)ptr)->m_match_len;
																																								num3 = ((lzham_lzham_decompressor*)ptr)->m_match_hist0;
																																								num4 = ((lzham_lzham_decompressor*)ptr)->m_match_hist1;
																																								num5 = ((lzham_lzham_decompressor*)ptr)->m_match_hist2;
																																								num6 = ((lzham_lzham_decompressor*)ptr)->m_match_hist3;
																																								num7 = ((lzham_lzham_decompressor*)ptr)->m_cur_state;
																																								num8 = ((lzham_lzham_decompressor*)ptr)->m_dst_ofs;
																																								num9 = ((lzham_symbol_codec*)codec)->m_arith_value;
																																								num10 = ((lzham_symbol_codec*)codec)->m_arith_length;
																																								num11 = ((lzham_symbol_codec*)codec)->m_bit_buf;
																																								num12 = ((lzham_symbol_codec*)codec)->m_bit_count;
																																								ptr3 = ((lzham_symbol_codec*)codec)->m_pDecode_buf_next;
																																								goto IL_7369;
																																							}
																																							decode_set_input_buffer.Invoke(&((lzham_lzham_decompressor*)ptr)->m_codec, eof_flag: (((lzham_lzham_decompressor*)ptr)->m_no_more_input_bytes_flag & 1) == 1, pBuf_next: ((lzham_lzham_decompressor*)ptr)->m_pIn_buf, buf_size: *(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size, pBuf: ((lzham_lzham_decompressor*)ptr)->m_pIn_buf);
																																							if ((((lzham_lzham_decompressor*)ptr)->m_codec.m_decode_buf_eof & 1) != 1 && ((lzham_lzham_decompressor*)ptr)->m_codec.m_decode_buf_size == 0L)
																																							{
																																								goto IL_6d90;
																																							}
																																							num13 = ((lzham_lzham_decompressor*)ptr)->m_match_len;
																																							num3 = ((lzham_lzham_decompressor*)ptr)->m_match_hist0;
																																							num4 = ((lzham_lzham_decompressor*)ptr)->m_match_hist1;
																																							num5 = ((lzham_lzham_decompressor*)ptr)->m_match_hist2;
																																							num6 = ((lzham_lzham_decompressor*)ptr)->m_match_hist3;
																																							num7 = ((lzham_lzham_decompressor*)ptr)->m_cur_state;
																																							num8 = ((lzham_lzham_decompressor*)ptr)->m_dst_ofs;
																																							num9 = ((lzham_symbol_codec*)codec)->m_arith_value;
																																							num10 = ((lzham_symbol_codec*)codec)->m_arith_length;
																																							num11 = ((lzham_symbol_codec*)codec)->m_bit_buf;
																																							num12 = ((lzham_symbol_codec*)codec)->m_bit_count;
																																							ptr3 = ((lzham_symbol_codec*)codec)->m_pDecode_buf_next;
																																							ptr7 = ((lzham_symbol_codec*)codec)->m_pSaved_huff_model;
																																							pDecode_tables4 = ((lzham_raw_quasi_adaptive_huffman_data_model*)ptr7)->m_pDecode_tables;
																																							goto IL_6ed4;
																																						}
																																						decode_set_input_buffer.Invoke(&((lzham_lzham_decompressor*)ptr)->m_codec, eof_flag: (((lzham_lzham_decompressor*)ptr)->m_no_more_input_bytes_flag & 1) == 1, pBuf_next: ((lzham_lzham_decompressor*)ptr)->m_pIn_buf, buf_size: *(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size, pBuf: ((lzham_lzham_decompressor*)ptr)->m_pIn_buf);
																																						if ((((lzham_lzham_decompressor*)ptr)->m_codec.m_decode_buf_eof & 1) != 1 && ((lzham_lzham_decompressor*)ptr)->m_codec.m_decode_buf_size == 0L)
																																						{
																																							goto IL_69a0;
																																						}
																																						num13 = ((lzham_lzham_decompressor*)ptr)->m_match_len;
																																						num3 = ((lzham_lzham_decompressor*)ptr)->m_match_hist0;
																																						num4 = ((lzham_lzham_decompressor*)ptr)->m_match_hist1;
																																						num5 = ((lzham_lzham_decompressor*)ptr)->m_match_hist2;
																																						num6 = ((lzham_lzham_decompressor*)ptr)->m_match_hist3;
																																						num7 = ((lzham_lzham_decompressor*)ptr)->m_cur_state;
																																						num8 = ((lzham_lzham_decompressor*)ptr)->m_dst_ofs;
																																						num9 = ((lzham_symbol_codec*)codec)->m_arith_value;
																																						num10 = ((lzham_symbol_codec*)codec)->m_arith_length;
																																						num11 = ((lzham_symbol_codec*)codec)->m_bit_buf;
																																						num12 = ((lzham_symbol_codec*)codec)->m_bit_count;
																																						ptr3 = ((lzham_symbol_codec*)codec)->m_pDecode_buf_next;
																																						goto IL_6ad2;
																																					}
																																					decode_set_input_buffer.Invoke(&((lzham_lzham_decompressor*)ptr)->m_codec, eof_flag: (((lzham_lzham_decompressor*)ptr)->m_no_more_input_bytes_flag & 1) == 1, pBuf_next: ((lzham_lzham_decompressor*)ptr)->m_pIn_buf, buf_size: *(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size, pBuf: ((lzham_lzham_decompressor*)ptr)->m_pIn_buf);
																																					if ((((lzham_lzham_decompressor*)ptr)->m_codec.m_decode_buf_eof & 1) != 1 && ((lzham_lzham_decompressor*)ptr)->m_codec.m_decode_buf_size == 0L)
																																					{
																																						goto IL_669f;
																																					}
																																					num13 = ((lzham_lzham_decompressor*)ptr)->m_match_len;
																																					num3 = ((lzham_lzham_decompressor*)ptr)->m_match_hist0;
																																					num4 = ((lzham_lzham_decompressor*)ptr)->m_match_hist1;
																																					num5 = ((lzham_lzham_decompressor*)ptr)->m_match_hist2;
																																					num6 = ((lzham_lzham_decompressor*)ptr)->m_match_hist3;
																																					num7 = ((lzham_lzham_decompressor*)ptr)->m_cur_state;
																																					num8 = ((lzham_lzham_decompressor*)ptr)->m_dst_ofs;
																																					num9 = ((lzham_symbol_codec*)codec)->m_arith_value;
																																					num10 = ((lzham_symbol_codec*)codec)->m_arith_length;
																																					num11 = ((lzham_symbol_codec*)codec)->m_bit_buf;
																																					num12 = ((lzham_symbol_codec*)codec)->m_bit_count;
																																					ptr3 = ((lzham_symbol_codec*)codec)->m_pDecode_buf_next;
																																					goto IL_67d1;
																																				}
																																				decode_set_input_buffer.Invoke(&((lzham_lzham_decompressor*)ptr)->m_codec, eof_flag: (((lzham_lzham_decompressor*)ptr)->m_no_more_input_bytes_flag & 1) == 1, pBuf_next: ((lzham_lzham_decompressor*)ptr)->m_pIn_buf, buf_size: *(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size, pBuf: ((lzham_lzham_decompressor*)ptr)->m_pIn_buf);
																																				if ((((lzham_lzham_decompressor*)ptr)->m_codec.m_decode_buf_eof & 1) != 1 && ((lzham_lzham_decompressor*)ptr)->m_codec.m_decode_buf_size == 0L)
																																				{
																																					goto IL_61f8;
																																				}
																																				num13 = ((lzham_lzham_decompressor*)ptr)->m_match_len;
																																				num3 = ((lzham_lzham_decompressor*)ptr)->m_match_hist0;
																																				num4 = ((lzham_lzham_decompressor*)ptr)->m_match_hist1;
																																				num5 = ((lzham_lzham_decompressor*)ptr)->m_match_hist2;
																																				num6 = ((lzham_lzham_decompressor*)ptr)->m_match_hist3;
																																				num7 = ((lzham_lzham_decompressor*)ptr)->m_cur_state;
																																				num8 = ((lzham_lzham_decompressor*)ptr)->m_dst_ofs;
																																				num9 = ((lzham_symbol_codec*)codec)->m_arith_value;
																																				num10 = ((lzham_symbol_codec*)codec)->m_arith_length;
																																				num11 = ((lzham_symbol_codec*)codec)->m_bit_buf;
																																				num12 = ((lzham_symbol_codec*)codec)->m_bit_count;
																																				ptr3 = ((lzham_symbol_codec*)codec)->m_pDecode_buf_next;
																																				ptr8 = ((lzham_symbol_codec*)codec)->m_pSaved_huff_model;
																																				pDecode_tables5 = ((lzham_raw_quasi_adaptive_huffman_data_model*)ptr8)->m_pDecode_tables;
																																				goto IL_633c;
																																			}
																																			decode_set_input_buffer.Invoke(&((lzham_lzham_decompressor*)ptr)->m_codec, eof_flag: (((lzham_lzham_decompressor*)ptr)->m_no_more_input_bytes_flag & 1) == 1, pBuf_next: ((lzham_lzham_decompressor*)ptr)->m_pIn_buf, buf_size: *(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size, pBuf: ((lzham_lzham_decompressor*)ptr)->m_pIn_buf);
																																			if ((((lzham_lzham_decompressor*)ptr)->m_codec.m_decode_buf_eof & 1) != 1 && ((lzham_lzham_decompressor*)ptr)->m_codec.m_decode_buf_size == 0L)
																																			{
																																				goto IL_5db1;
																																			}
																																			num13 = ((lzham_lzham_decompressor*)ptr)->m_match_len;
																																			num3 = ((lzham_lzham_decompressor*)ptr)->m_match_hist0;
																																			num4 = ((lzham_lzham_decompressor*)ptr)->m_match_hist1;
																																			num5 = ((lzham_lzham_decompressor*)ptr)->m_match_hist2;
																																			num6 = ((lzham_lzham_decompressor*)ptr)->m_match_hist3;
																																			num7 = ((lzham_lzham_decompressor*)ptr)->m_cur_state;
																																			num8 = ((lzham_lzham_decompressor*)ptr)->m_dst_ofs;
																																			num9 = ((lzham_symbol_codec*)codec)->m_arith_value;
																																			num10 = ((lzham_symbol_codec*)codec)->m_arith_length;
																																			num11 = ((lzham_symbol_codec*)codec)->m_bit_buf;
																																			num12 = ((lzham_symbol_codec*)codec)->m_bit_count;
																																			ptr3 = ((lzham_symbol_codec*)codec)->m_pDecode_buf_next;
																																			goto IL_5ee3;
																																		}
																																		decode_set_input_buffer.Invoke(&((lzham_lzham_decompressor*)ptr)->m_codec, eof_flag: (((lzham_lzham_decompressor*)ptr)->m_no_more_input_bytes_flag & 1) == 1, pBuf_next: ((lzham_lzham_decompressor*)ptr)->m_pIn_buf, buf_size: *(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size, pBuf: ((lzham_lzham_decompressor*)ptr)->m_pIn_buf);
																																		if ((((lzham_lzham_decompressor*)ptr)->m_codec.m_decode_buf_eof & 1) != 1 && ((lzham_lzham_decompressor*)ptr)->m_codec.m_decode_buf_size == 0L)
																																		{
																																			goto IL_59bd;
																																		}
																																		num13 = ((lzham_lzham_decompressor*)ptr)->m_match_len;
																																		num3 = ((lzham_lzham_decompressor*)ptr)->m_match_hist0;
																																		num4 = ((lzham_lzham_decompressor*)ptr)->m_match_hist1;
																																		num5 = ((lzham_lzham_decompressor*)ptr)->m_match_hist2;
																																		num6 = ((lzham_lzham_decompressor*)ptr)->m_match_hist3;
																																		num7 = ((lzham_lzham_decompressor*)ptr)->m_cur_state;
																																		num8 = ((lzham_lzham_decompressor*)ptr)->m_dst_ofs;
																																		num9 = ((lzham_symbol_codec*)codec)->m_arith_value;
																																		num10 = ((lzham_symbol_codec*)codec)->m_arith_length;
																																		num11 = ((lzham_symbol_codec*)codec)->m_bit_buf;
																																		num12 = ((lzham_symbol_codec*)codec)->m_bit_count;
																																		ptr3 = ((lzham_symbol_codec*)codec)->m_pDecode_buf_next;
																																		goto IL_5aef;
																																	}
																																	decode_set_input_buffer.Invoke(&((lzham_lzham_decompressor*)ptr)->m_codec, eof_flag: (((lzham_lzham_decompressor*)ptr)->m_no_more_input_bytes_flag & 1) == 1, pBuf_next: ((lzham_lzham_decompressor*)ptr)->m_pIn_buf, buf_size: *(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size, pBuf: ((lzham_lzham_decompressor*)ptr)->m_pIn_buf);
																																	if ((((lzham_lzham_decompressor*)ptr)->m_codec.m_decode_buf_eof & 1) != 1 && ((lzham_lzham_decompressor*)ptr)->m_codec.m_decode_buf_size == 0L)
																																	{
																																		goto IL_55c9;
																																	}
																																	num13 = ((lzham_lzham_decompressor*)ptr)->m_match_len;
																																	num3 = ((lzham_lzham_decompressor*)ptr)->m_match_hist0;
																																	num4 = ((lzham_lzham_decompressor*)ptr)->m_match_hist1;
																																	num5 = ((lzham_lzham_decompressor*)ptr)->m_match_hist2;
																																	num6 = ((lzham_lzham_decompressor*)ptr)->m_match_hist3;
																																	num7 = ((lzham_lzham_decompressor*)ptr)->m_cur_state;
																																	num8 = ((lzham_lzham_decompressor*)ptr)->m_dst_ofs;
																																	num9 = ((lzham_symbol_codec*)codec)->m_arith_value;
																																	num10 = ((lzham_symbol_codec*)codec)->m_arith_length;
																																	num11 = ((lzham_symbol_codec*)codec)->m_bit_buf;
																																	num12 = ((lzham_symbol_codec*)codec)->m_bit_count;
																																	ptr3 = ((lzham_symbol_codec*)codec)->m_pDecode_buf_next;
																																	goto IL_56fb;
																																}
																																decode_set_input_buffer.Invoke(&((lzham_lzham_decompressor*)ptr)->m_codec, eof_flag: (((lzham_lzham_decompressor*)ptr)->m_no_more_input_bytes_flag & 1) == 1, pBuf_next: ((lzham_lzham_decompressor*)ptr)->m_pIn_buf, buf_size: *(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size, pBuf: ((lzham_lzham_decompressor*)ptr)->m_pIn_buf);
																																long flush_n5 = ((lzham_lzham_decompressor*)ptr)->m_flush_n;
																																void** pFlush_src3 = &((lzham_lzham_decompressor*)ptr)->m_pFlush_src;
																																*pFlush_src3 = (byte*)(*pFlush_src3) + flush_n5;
																																long flush_n6 = ((lzham_lzham_decompressor*)ptr)->m_flush_n;
																																((lzham_lzham_decompressor*)ptr)->m_flush_num_bytes_remaining -= flush_n6;
																																goto IL_51c0;
																															}
																															decode_set_input_buffer.Invoke(&((lzham_lzham_decompressor*)ptr)->m_codec, eof_flag: (((lzham_lzham_decompressor*)ptr)->m_no_more_input_bytes_flag & 1) == 1, pBuf_next: ((lzham_lzham_decompressor*)ptr)->m_pIn_buf, buf_size: *(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size, pBuf: ((lzham_lzham_decompressor*)ptr)->m_pIn_buf);
																															if ((((lzham_lzham_decompressor*)ptr)->m_codec.m_decode_buf_eof & 1) != 1 && ((lzham_lzham_decompressor*)ptr)->m_codec.m_decode_buf_size == 0L)
																															{
																																goto IL_4cbd;
																															}
																															num17 = ((lzham_lzham_decompressor*)ptr)->m_rep_lit0;
																															num3 = ((lzham_lzham_decompressor*)ptr)->m_match_hist0;
																															num4 = ((lzham_lzham_decompressor*)ptr)->m_match_hist1;
																															num5 = ((lzham_lzham_decompressor*)ptr)->m_match_hist2;
																															num6 = ((lzham_lzham_decompressor*)ptr)->m_match_hist3;
																															num7 = ((lzham_lzham_decompressor*)ptr)->m_cur_state;
																															num8 = ((lzham_lzham_decompressor*)ptr)->m_dst_ofs;
																															num9 = ((lzham_symbol_codec*)codec)->m_arith_value;
																															num10 = ((lzham_symbol_codec*)codec)->m_arith_length;
																															num11 = ((lzham_symbol_codec*)codec)->m_bit_buf;
																															num12 = ((lzham_symbol_codec*)codec)->m_bit_count;
																															ptr3 = ((lzham_symbol_codec*)codec)->m_pDecode_buf_next;
																															ptr9 = ((lzham_symbol_codec*)codec)->m_pSaved_huff_model;
																															pDecode_tables6 = ((lzham_raw_quasi_adaptive_huffman_data_model*)ptr9)->m_pDecode_tables;
																															goto IL_4e01;
																														}
																														decode_set_input_buffer.Invoke(&((lzham_lzham_decompressor*)ptr)->m_codec, eof_flag: (((lzham_lzham_decompressor*)ptr)->m_no_more_input_bytes_flag & 1) == 1, pBuf_next: ((lzham_lzham_decompressor*)ptr)->m_pIn_buf, buf_size: *(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size, pBuf: ((lzham_lzham_decompressor*)ptr)->m_pIn_buf);
																														if ((((lzham_lzham_decompressor*)ptr)->m_codec.m_decode_buf_eof & 1) != 1 && ((lzham_lzham_decompressor*)ptr)->m_codec.m_decode_buf_size == 0L)
																														{
																															goto IL_47c2;
																														}
																														num3 = ((lzham_lzham_decompressor*)ptr)->m_match_hist0;
																														num4 = ((lzham_lzham_decompressor*)ptr)->m_match_hist1;
																														num5 = ((lzham_lzham_decompressor*)ptr)->m_match_hist2;
																														num6 = ((lzham_lzham_decompressor*)ptr)->m_match_hist3;
																														num7 = ((lzham_lzham_decompressor*)ptr)->m_cur_state;
																														num8 = ((lzham_lzham_decompressor*)ptr)->m_dst_ofs;
																														num9 = ((lzham_symbol_codec*)codec)->m_arith_value;
																														num10 = ((lzham_symbol_codec*)codec)->m_arith_length;
																														num11 = ((lzham_symbol_codec*)codec)->m_bit_buf;
																														num12 = ((lzham_symbol_codec*)codec)->m_bit_count;
																														ptr3 = ((lzham_symbol_codec*)codec)->m_pDecode_buf_next;
																														ptr10 = ((lzham_symbol_codec*)codec)->m_pSaved_huff_model;
																														pDecode_tables7 = ((lzham_raw_quasi_adaptive_huffman_data_model*)ptr10)->m_pDecode_tables;
																														goto IL_48fd;
																													}
																													goto IL_4667;
																												}
																												decode_set_input_buffer.Invoke(&((lzham_lzham_decompressor*)ptr)->m_codec, eof_flag: (((lzham_lzham_decompressor*)ptr)->m_no_more_input_bytes_flag & 1) == 1, pBuf_next: ((lzham_lzham_decompressor*)ptr)->m_pIn_buf, buf_size: *(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size, pBuf: ((lzham_lzham_decompressor*)ptr)->m_pIn_buf);
																												if ((((lzham_lzham_decompressor*)ptr)->m_codec.m_decode_buf_eof & 1) != 1 && ((lzham_lzham_decompressor*)ptr)->m_codec.m_decode_buf_size == 0L)
																												{
																													goto IL_431b;
																												}
																												num3 = ((lzham_lzham_decompressor*)ptr)->m_match_hist0;
																												num4 = ((lzham_lzham_decompressor*)ptr)->m_match_hist1;
																												num5 = ((lzham_lzham_decompressor*)ptr)->m_match_hist2;
																												num6 = ((lzham_lzham_decompressor*)ptr)->m_match_hist3;
																												num7 = ((lzham_lzham_decompressor*)ptr)->m_cur_state;
																												num8 = ((lzham_lzham_decompressor*)ptr)->m_dst_ofs;
																												num9 = ((lzham_symbol_codec*)codec)->m_arith_value;
																												num10 = ((lzham_symbol_codec*)codec)->m_arith_length;
																												num11 = ((lzham_symbol_codec*)codec)->m_bit_buf;
																												num12 = ((lzham_symbol_codec*)codec)->m_bit_count;
																												ptr3 = ((lzham_symbol_codec*)codec)->m_pDecode_buf_next;
																												goto IL_4444;
																											}
																											decode_set_input_buffer.Invoke(&((lzham_lzham_decompressor*)ptr)->m_codec, eof_flag: (((lzham_lzham_decompressor*)ptr)->m_no_more_input_bytes_flag & 1) == 1, pBuf_next: ((lzham_lzham_decompressor*)ptr)->m_pIn_buf, buf_size: *(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size, pBuf: ((lzham_lzham_decompressor*)ptr)->m_pIn_buf);
																											if ((((lzham_lzham_decompressor*)ptr)->m_codec.m_decode_buf_eof & 1) != 1 && ((lzham_lzham_decompressor*)ptr)->m_codec.m_decode_buf_size == 0L)
																											{
																												goto IL_3ffc;
																											}
																											num3 = ((lzham_lzham_decompressor*)ptr)->m_match_hist0;
																											num4 = ((lzham_lzham_decompressor*)ptr)->m_match_hist1;
																											num5 = ((lzham_lzham_decompressor*)ptr)->m_match_hist2;
																											num6 = ((lzham_lzham_decompressor*)ptr)->m_match_hist3;
																											num7 = ((lzham_lzham_decompressor*)ptr)->m_cur_state;
																											num8 = ((lzham_lzham_decompressor*)ptr)->m_dst_ofs;
																											num9 = ((lzham_symbol_codec*)codec)->m_arith_value;
																											num10 = ((lzham_symbol_codec*)codec)->m_arith_length;
																											num11 = ((lzham_symbol_codec*)codec)->m_bit_buf;
																											num12 = ((lzham_symbol_codec*)codec)->m_bit_count;
																											ptr3 = ((lzham_symbol_codec*)codec)->m_pDecode_buf_next;
																											goto IL_4125;
																										}
																										decode_set_input_buffer.Invoke(&((lzham_lzham_decompressor*)ptr)->m_codec, eof_flag: (((lzham_lzham_decompressor*)ptr)->m_no_more_input_bytes_flag & 1) == 1, pBuf_next: ((lzham_lzham_decompressor*)ptr)->m_pIn_buf, buf_size: *(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size, pBuf: ((lzham_lzham_decompressor*)ptr)->m_pIn_buf);
																										if ((((lzham_lzham_decompressor*)ptr)->m_codec.m_decode_buf_eof & 1) != 1 && ((lzham_lzham_decompressor*)ptr)->m_codec.m_decode_buf_size == 0L)
																										{
																											goto IL_3d13;
																										}
																										num3 = ((lzham_lzham_decompressor*)ptr)->m_match_hist0;
																										num4 = ((lzham_lzham_decompressor*)ptr)->m_match_hist1;
																										num5 = ((lzham_lzham_decompressor*)ptr)->m_match_hist2;
																										num6 = ((lzham_lzham_decompressor*)ptr)->m_match_hist3;
																										num7 = ((lzham_lzham_decompressor*)ptr)->m_cur_state;
																										num8 = ((lzham_lzham_decompressor*)ptr)->m_dst_ofs;
																										num9 = ((lzham_symbol_codec*)codec)->m_arith_value;
																										num10 = ((lzham_symbol_codec*)codec)->m_arith_length;
																										num11 = ((lzham_symbol_codec*)codec)->m_bit_buf;
																										num12 = ((lzham_symbol_codec*)codec)->m_bit_count;
																										ptr3 = ((lzham_symbol_codec*)codec)->m_pDecode_buf_next;
																										goto IL_3e3c;
																									}
																									decode_set_input_buffer.Invoke(&((lzham_lzham_decompressor*)ptr)->m_codec, eof_flag: (((lzham_lzham_decompressor*)ptr)->m_no_more_input_bytes_flag & 1) == 1, pBuf_next: ((lzham_lzham_decompressor*)ptr)->m_pIn_buf, buf_size: *(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size, pBuf: ((lzham_lzham_decompressor*)ptr)->m_pIn_buf);
																									long flush_n7 = ((lzham_lzham_decompressor*)ptr)->m_flush_n;
																									void** pFlush_src4 = &((lzham_lzham_decompressor*)ptr)->m_pFlush_src;
																									*pFlush_src4 = (byte*)(*pFlush_src4) + flush_n7;
																									long flush_n8 = ((lzham_lzham_decompressor*)ptr)->m_flush_n;
																									((lzham_lzham_decompressor*)ptr)->m_flush_num_bytes_remaining -= flush_n8;
																									goto IL_3924;
																								}
																								goto IL_378b;
																							}
																							num18 = ((lzham_lzham_decompressor*)ptr)->m_num_raw_bytes_remaining;
																							num3 = ((lzham_lzham_decompressor*)ptr)->m_match_hist0;
																							num4 = ((lzham_lzham_decompressor*)ptr)->m_match_hist1;
																							num5 = ((lzham_lzham_decompressor*)ptr)->m_match_hist2;
																							num6 = ((lzham_lzham_decompressor*)ptr)->m_match_hist3;
																							num7 = ((lzham_lzham_decompressor*)ptr)->m_cur_state;
																							num8 = ((lzham_lzham_decompressor*)ptr)->m_dst_ofs;
																							decode_set_input_buffer.Invoke(&((lzham_lzham_decompressor*)ptr)->m_codec, eof_flag: (((lzham_lzham_decompressor*)ptr)->m_no_more_input_bytes_flag & 1) == 1, pBuf_next: ((lzham_lzham_decompressor*)ptr)->m_pIn_buf, buf_size: *(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size, pBuf: ((lzham_lzham_decompressor*)ptr)->m_pIn_buf);
																							num19 = 0L;
																							num20 = *(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size;
																							goto IL_3590;
																						}
																						goto IL_35e0;
																					}
																					decode_set_input_buffer.Invoke(&((lzham_lzham_decompressor*)ptr)->m_codec, eof_flag: (((lzham_lzham_decompressor*)ptr)->m_no_more_input_bytes_flag & 1) == 1, pBuf_next: ((lzham_lzham_decompressor*)ptr)->m_pIn_buf, buf_size: *(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size, pBuf: ((lzham_lzham_decompressor*)ptr)->m_pIn_buf);
																					long flush_n9 = ((lzham_lzham_decompressor*)ptr)->m_flush_n;
																					void** pFlush_src5 = &((lzham_lzham_decompressor*)ptr)->m_pFlush_src;
																					*pFlush_src5 = (byte*)(*pFlush_src5) + flush_n9;
																					long flush_n10 = ((lzham_lzham_decompressor*)ptr)->m_flush_n;
																					((lzham_lzham_decompressor*)ptr)->m_flush_num_bytes_remaining -= flush_n10;
																					goto IL_322b;
																				}
																				goto IL_30aa;
																			}
																			decode_set_input_buffer.Invoke(&((lzham_lzham_decompressor*)ptr)->m_codec, eof_flag: (((lzham_lzham_decompressor*)ptr)->m_no_more_input_bytes_flag & 1) == 1, pBuf_next: ((lzham_lzham_decompressor*)ptr)->m_pIn_buf, buf_size: *(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size, pBuf: ((lzham_lzham_decompressor*)ptr)->m_pIn_buf);
																			if ((((lzham_lzham_decompressor*)ptr)->m_codec.m_decode_buf_eof & 1) != 1 && ((lzham_lzham_decompressor*)ptr)->m_codec.m_decode_buf_size == 0L)
																			{
																				goto IL_2dce;
																			}
																			num18 = ((lzham_lzham_decompressor*)ptr)->m_num_raw_bytes_remaining;
																			num3 = ((lzham_lzham_decompressor*)ptr)->m_match_hist0;
																			num4 = ((lzham_lzham_decompressor*)ptr)->m_match_hist1;
																			num5 = ((lzham_lzham_decompressor*)ptr)->m_match_hist2;
																			num6 = ((lzham_lzham_decompressor*)ptr)->m_match_hist3;
																			num7 = ((lzham_lzham_decompressor*)ptr)->m_cur_state;
																			num8 = ((lzham_lzham_decompressor*)ptr)->m_dst_ofs;
																			num9 = ((lzham_symbol_codec*)codec)->m_arith_value;
																			num10 = ((lzham_symbol_codec*)codec)->m_arith_length;
																			num11 = ((lzham_symbol_codec*)codec)->m_bit_buf;
																			num12 = ((lzham_symbol_codec*)codec)->m_bit_count;
																			ptr3 = ((lzham_symbol_codec*)codec)->m_pDecode_buf_next;
																			goto IL_2f00;
																		}
																		goto IL_2c9b;
																	}
																	decode_set_input_buffer.Invoke(&((lzham_lzham_decompressor*)ptr)->m_codec, eof_flag: (((lzham_lzham_decompressor*)ptr)->m_no_more_input_bytes_flag & 1) == 1, pBuf_next: ((lzham_lzham_decompressor*)ptr)->m_pIn_buf, buf_size: *(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size, pBuf: ((lzham_lzham_decompressor*)ptr)->m_pIn_buf);
																	if ((((lzham_lzham_decompressor*)ptr)->m_codec.m_decode_buf_eof & 1) != 1 && ((lzham_lzham_decompressor*)ptr)->m_codec.m_decode_buf_size == 0L)
																	{
																		goto IL_2a18;
																	}
																	num18 = ((lzham_lzham_decompressor*)ptr)->m_num_raw_bytes_remaining;
																	num3 = ((lzham_lzham_decompressor*)ptr)->m_match_hist0;
																	num4 = ((lzham_lzham_decompressor*)ptr)->m_match_hist1;
																	num5 = ((lzham_lzham_decompressor*)ptr)->m_match_hist2;
																	num6 = ((lzham_lzham_decompressor*)ptr)->m_match_hist3;
																	num7 = ((lzham_lzham_decompressor*)ptr)->m_cur_state;
																	num8 = ((lzham_lzham_decompressor*)ptr)->m_dst_ofs;
																	num9 = ((lzham_symbol_codec*)codec)->m_arith_value;
																	num10 = ((lzham_symbol_codec*)codec)->m_arith_length;
																	num11 = ((lzham_symbol_codec*)codec)->m_bit_buf;
																	num12 = ((lzham_symbol_codec*)codec)->m_bit_count;
																	ptr3 = ((lzham_symbol_codec*)codec)->m_pDecode_buf_next;
																	goto IL_2b4a;
																}
																decode_set_input_buffer.Invoke(&((lzham_lzham_decompressor*)ptr)->m_codec, eof_flag: (((lzham_lzham_decompressor*)ptr)->m_no_more_input_bytes_flag & 1) == 1, pBuf_next: ((lzham_lzham_decompressor*)ptr)->m_pIn_buf, buf_size: *(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size, pBuf: ((lzham_lzham_decompressor*)ptr)->m_pIn_buf);
																if ((((lzham_lzham_decompressor*)ptr)->m_codec.m_decode_buf_eof & 1) != 1 && ((lzham_lzham_decompressor*)ptr)->m_codec.m_decode_buf_size == 0L)
																{
																	goto IL_274d;
																}
																num18 = ((lzham_lzham_decompressor*)ptr)->m_num_raw_bytes_remaining;
																num3 = ((lzham_lzham_decompressor*)ptr)->m_match_hist0;
																num4 = ((lzham_lzham_decompressor*)ptr)->m_match_hist1;
																num5 = ((lzham_lzham_decompressor*)ptr)->m_match_hist2;
																num6 = ((lzham_lzham_decompressor*)ptr)->m_match_hist3;
																num7 = ((lzham_lzham_decompressor*)ptr)->m_cur_state;
																num8 = ((lzham_lzham_decompressor*)ptr)->m_dst_ofs;
																num9 = ((lzham_symbol_codec*)codec)->m_arith_value;
																num10 = ((lzham_symbol_codec*)codec)->m_arith_length;
																num11 = ((lzham_symbol_codec*)codec)->m_bit_buf;
																num12 = ((lzham_symbol_codec*)codec)->m_bit_count;
																ptr3 = ((lzham_symbol_codec*)codec)->m_pDecode_buf_next;
																goto IL_287f;
															}
															num3 = ((lzham_lzham_decompressor*)ptr)->m_match_hist0;
															num4 = ((lzham_lzham_decompressor*)ptr)->m_match_hist1;
															num5 = ((lzham_lzham_decompressor*)ptr)->m_match_hist2;
															num6 = ((lzham_lzham_decompressor*)ptr)->m_match_hist3;
															num7 = ((lzham_lzham_decompressor*)ptr)->m_cur_state;
															num8 = ((lzham_lzham_decompressor*)ptr)->m_dst_ofs;
															decode_set_input_buffer.Invoke(&((lzham_lzham_decompressor*)ptr)->m_codec, eof_flag: (((lzham_lzham_decompressor*)ptr)->m_no_more_input_bytes_flag & 1) == 1, pBuf_next: ((lzham_lzham_decompressor*)ptr)->m_pIn_buf, buf_size: *(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size, pBuf: ((lzham_lzham_decompressor*)ptr)->m_pIn_buf);
															goto IL_2603;
														}
														decode_set_input_buffer.Invoke(&((lzham_lzham_decompressor*)ptr)->m_codec, eof_flag: (((lzham_lzham_decompressor*)ptr)->m_no_more_input_bytes_flag & 1) == 1, pBuf_next: ((lzham_lzham_decompressor*)ptr)->m_pIn_buf, buf_size: *(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size, pBuf: ((lzham_lzham_decompressor*)ptr)->m_pIn_buf);
														long flush_n11 = ((lzham_lzham_decompressor*)ptr)->m_flush_n;
														void** pFlush_src6 = &((lzham_lzham_decompressor*)ptr)->m_pFlush_src;
														*pFlush_src6 = (byte*)(*pFlush_src6) + flush_n11;
														long flush_n12 = ((lzham_lzham_decompressor*)ptr)->m_flush_n;
														((lzham_lzham_decompressor*)ptr)->m_flush_num_bytes_remaining -= flush_n12;
														goto IL_222a;
													}
													goto IL_20bc;
												}
												decode_set_input_buffer.Invoke(&((lzham_lzham_decompressor*)ptr)->m_codec, eof_flag: (((lzham_lzham_decompressor*)ptr)->m_no_more_input_bytes_flag & 1) == 1, pBuf_next: ((lzham_lzham_decompressor*)ptr)->m_pIn_buf, buf_size: *(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size, pBuf: ((lzham_lzham_decompressor*)ptr)->m_pIn_buf);
												if ((((lzham_lzham_decompressor*)ptr)->m_codec.m_decode_buf_eof & 1) != 1 && ((lzham_lzham_decompressor*)ptr)->m_codec.m_decode_buf_size == 0L)
												{
													goto IL_1e67;
												}
												num3 = ((lzham_lzham_decompressor*)ptr)->m_match_hist0;
												num4 = ((lzham_lzham_decompressor*)ptr)->m_match_hist1;
												num5 = ((lzham_lzham_decompressor*)ptr)->m_match_hist2;
												num6 = ((lzham_lzham_decompressor*)ptr)->m_match_hist3;
												num7 = ((lzham_lzham_decompressor*)ptr)->m_cur_state;
												num8 = ((lzham_lzham_decompressor*)ptr)->m_dst_ofs;
												num9 = ((lzham_symbol_codec*)codec)->m_arith_value;
												num10 = ((lzham_symbol_codec*)codec)->m_arith_length;
												num11 = ((lzham_symbol_codec*)codec)->m_bit_buf;
												num12 = ((lzham_symbol_codec*)codec)->m_bit_count;
												ptr3 = ((lzham_symbol_codec*)codec)->m_pDecode_buf_next;
												goto IL_1f90;
											}
											goto IL_1d5e;
										}
										decode_set_input_buffer.Invoke(&((lzham_lzham_decompressor*)ptr)->m_codec, eof_flag: (((lzham_lzham_decompressor*)ptr)->m_no_more_input_bytes_flag & 1) == 1, pBuf_next: ((lzham_lzham_decompressor*)ptr)->m_pIn_buf, buf_size: *(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size, pBuf: ((lzham_lzham_decompressor*)ptr)->m_pIn_buf);
										if ((((lzham_lzham_decompressor*)ptr)->m_codec.m_decode_buf_eof & 1) != 1 && ((lzham_lzham_decompressor*)ptr)->m_codec.m_decode_buf_size == 0L)
										{
											goto IL_1b0d;
										}
										num3 = ((lzham_lzham_decompressor*)ptr)->m_match_hist0;
										num4 = ((lzham_lzham_decompressor*)ptr)->m_match_hist1;
										num5 = ((lzham_lzham_decompressor*)ptr)->m_match_hist2;
										num6 = ((lzham_lzham_decompressor*)ptr)->m_match_hist3;
										num7 = ((lzham_lzham_decompressor*)ptr)->m_cur_state;
										num8 = ((lzham_lzham_decompressor*)ptr)->m_dst_ofs;
										num9 = ((lzham_symbol_codec*)codec)->m_arith_value;
										num10 = ((lzham_symbol_codec*)codec)->m_arith_length;
										num11 = ((lzham_symbol_codec*)codec)->m_bit_buf;
										num12 = ((lzham_symbol_codec*)codec)->m_bit_count;
										ptr3 = ((lzham_symbol_codec*)codec)->m_pDecode_buf_next;
										goto IL_1c36;
									}
									decode_set_input_buffer.Invoke(&((lzham_lzham_decompressor*)ptr)->m_codec, eof_flag: (((lzham_lzham_decompressor*)ptr)->m_no_more_input_bytes_flag & 1) == 1, pBuf_next: ((lzham_lzham_decompressor*)ptr)->m_pIn_buf, buf_size: *(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size, pBuf: ((lzham_lzham_decompressor*)ptr)->m_pIn_buf);
									if ((((lzham_lzham_decompressor*)ptr)->m_codec.m_decode_buf_eof & 1) != 1 && ((lzham_lzham_decompressor*)ptr)->m_codec.m_decode_buf_size == 0L)
									{
										goto IL_1828;
									}
									num3 = ((lzham_lzham_decompressor*)ptr)->m_match_hist0;
									num4 = ((lzham_lzham_decompressor*)ptr)->m_match_hist1;
									num5 = ((lzham_lzham_decompressor*)ptr)->m_match_hist2;
									num6 = ((lzham_lzham_decompressor*)ptr)->m_match_hist3;
									num7 = ((lzham_lzham_decompressor*)ptr)->m_cur_state;
									num8 = ((lzham_lzham_decompressor*)ptr)->m_dst_ofs;
									num9 = ((lzham_symbol_codec*)codec)->m_arith_value;
									num10 = ((lzham_symbol_codec*)codec)->m_arith_length;
									num11 = ((lzham_symbol_codec*)codec)->m_bit_buf;
									num12 = ((lzham_symbol_codec*)codec)->m_bit_count;
									ptr3 = ((lzham_symbol_codec*)codec)->m_pDecode_buf_next;
									goto IL_1951;
								}
								decode_set_input_buffer.Invoke(&((lzham_lzham_decompressor*)ptr)->m_codec, eof_flag: (((lzham_lzham_decompressor*)ptr)->m_no_more_input_bytes_flag & 1) == 1, pBuf_next: ((lzham_lzham_decompressor*)ptr)->m_pIn_buf, buf_size: *(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size, pBuf: ((lzham_lzham_decompressor*)ptr)->m_pIn_buf);
								if ((((lzham_lzham_decompressor*)ptr)->m_codec.m_decode_buf_eof & 1) != 1 && ((lzham_lzham_decompressor*)ptr)->m_codec.m_decode_buf_size == 0L)
								{
									goto IL_151d;
								}
								num3 = ((lzham_lzham_decompressor*)ptr)->m_match_hist0;
								num4 = ((lzham_lzham_decompressor*)ptr)->m_match_hist1;
								num5 = ((lzham_lzham_decompressor*)ptr)->m_match_hist2;
								num6 = ((lzham_lzham_decompressor*)ptr)->m_match_hist3;
								num7 = ((lzham_lzham_decompressor*)ptr)->m_cur_state;
								num8 = ((lzham_lzham_decompressor*)ptr)->m_dst_ofs;
								num9 = ((lzham_symbol_codec*)codec)->m_arith_value;
								num10 = ((lzham_symbol_codec*)codec)->m_arith_length;
								num11 = ((lzham_symbol_codec*)codec)->m_bit_buf;
								num12 = ((lzham_symbol_codec*)codec)->m_bit_count;
								ptr3 = ((lzham_symbol_codec*)codec)->m_pDecode_buf_next;
								goto IL_1646;
							}
							decode_set_input_buffer.Invoke(&((lzham_lzham_decompressor*)ptr)->m_codec, eof_flag: (((lzham_lzham_decompressor*)ptr)->m_no_more_input_bytes_flag & 1) == 1, pBuf_next: ((lzham_lzham_decompressor*)ptr)->m_pIn_buf, buf_size: *(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size, pBuf: ((lzham_lzham_decompressor*)ptr)->m_pIn_buf);
							if ((((lzham_lzham_decompressor*)ptr)->m_codec.m_decode_buf_eof & 1) != 1 && ((lzham_lzham_decompressor*)ptr)->m_codec.m_decode_buf_size == 0L)
							{
								goto IL_124f;
							}
							num3 = ((lzham_lzham_decompressor*)ptr)->m_match_hist0;
							num4 = ((lzham_lzham_decompressor*)ptr)->m_match_hist1;
							num5 = ((lzham_lzham_decompressor*)ptr)->m_match_hist2;
							num6 = ((lzham_lzham_decompressor*)ptr)->m_match_hist3;
							num7 = ((lzham_lzham_decompressor*)ptr)->m_cur_state;
							num8 = ((lzham_lzham_decompressor*)ptr)->m_dst_ofs;
							num9 = ((lzham_symbol_codec*)codec)->m_arith_value;
							num10 = ((lzham_symbol_codec*)codec)->m_arith_length;
							num11 = ((lzham_symbol_codec*)codec)->m_bit_buf;
							num12 = ((lzham_symbol_codec*)codec)->m_bit_count;
							ptr3 = ((lzham_symbol_codec*)codec)->m_pDecode_buf_next;
							goto IL_1378;
						}
						decode_set_input_buffer.Invoke(&((lzham_lzham_decompressor*)ptr)->m_codec, eof_flag: (((lzham_lzham_decompressor*)ptr)->m_no_more_input_bytes_flag & 1) == 1, pBuf_next: ((lzham_lzham_decompressor*)ptr)->m_pIn_buf, buf_size: *(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size, pBuf: ((lzham_lzham_decompressor*)ptr)->m_pIn_buf);
						if ((((lzham_lzham_decompressor*)ptr)->m_codec.m_decode_buf_eof & 1) != 1 && ((lzham_lzham_decompressor*)ptr)->m_codec.m_decode_buf_size == 0L)
						{
							goto IL_0c59;
						}
						num3 = ((lzham_lzham_decompressor*)ptr)->m_match_hist0;
						num4 = ((lzham_lzham_decompressor*)ptr)->m_match_hist1;
						num5 = ((lzham_lzham_decompressor*)ptr)->m_match_hist2;
						num6 = ((lzham_lzham_decompressor*)ptr)->m_match_hist3;
						num7 = ((lzham_lzham_decompressor*)ptr)->m_cur_state;
						num8 = ((lzham_lzham_decompressor*)ptr)->m_dst_ofs;
						num9 = ((lzham_symbol_codec*)codec)->m_arith_value;
						num10 = ((lzham_symbol_codec*)codec)->m_arith_length;
						num11 = ((lzham_symbol_codec*)codec)->m_bit_buf;
						num12 = ((lzham_symbol_codec*)codec)->m_bit_count;
						ptr3 = ((lzham_symbol_codec*)codec)->m_pDecode_buf_next;
						goto IL_0d72;
					}
					decode_set_input_buffer.Invoke(&((lzham_lzham_decompressor*)ptr)->m_codec, eof_flag: (((lzham_lzham_decompressor*)ptr)->m_no_more_input_bytes_flag & 1) == 1, pBuf_next: ((lzham_lzham_decompressor*)ptr)->m_pIn_buf, buf_size: *(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size, pBuf: ((lzham_lzham_decompressor*)ptr)->m_pIn_buf);
					if ((((lzham_lzham_decompressor*)ptr)->m_codec.m_decode_buf_eof & 1) != 1 && ((lzham_lzham_decompressor*)ptr)->m_codec.m_decode_buf_size == 0L)
					{
						goto IL_095e;
					}
					num3 = ((lzham_lzham_decompressor*)ptr)->m_match_hist0;
					num4 = ((lzham_lzham_decompressor*)ptr)->m_match_hist1;
					num5 = ((lzham_lzham_decompressor*)ptr)->m_match_hist2;
					num6 = ((lzham_lzham_decompressor*)ptr)->m_match_hist3;
					num7 = ((lzham_lzham_decompressor*)ptr)->m_cur_state;
					num8 = ((lzham_lzham_decompressor*)ptr)->m_dst_ofs;
					num9 = ((lzham_symbol_codec*)codec)->m_arith_value;
					num10 = ((lzham_symbol_codec*)codec)->m_arith_length;
					num11 = ((lzham_symbol_codec*)codec)->m_bit_buf;
					num12 = ((lzham_symbol_codec*)codec)->m_bit_count;
					ptr3 = ((lzham_symbol_codec*)codec)->m_pDecode_buf_next;
					goto IL_0a77;
				}
				decode_set_input_buffer.Invoke(&((lzham_lzham_decompressor*)ptr)->m_codec, eof_flag: (((lzham_lzham_decompressor*)ptr)->m_no_more_input_bytes_flag & 1) == 1, pBuf_next: ((lzham_lzham_decompressor*)ptr)->m_pIn_buf, buf_size: *(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size, pBuf: ((lzham_lzham_decompressor*)ptr)->m_pIn_buf);
				if ((((lzham_lzham_decompressor*)ptr)->m_codec.m_decode_buf_eof & 1) != 1 && ((lzham_lzham_decompressor*)ptr)->m_codec.m_decode_buf_size == 0L)
				{
					goto IL_06f9;
				}
				num3 = ((lzham_lzham_decompressor*)ptr)->m_match_hist0;
				num4 = ((lzham_lzham_decompressor*)ptr)->m_match_hist1;
				num5 = ((lzham_lzham_decompressor*)ptr)->m_match_hist2;
				num6 = ((lzham_lzham_decompressor*)ptr)->m_match_hist3;
				num7 = ((lzham_lzham_decompressor*)ptr)->m_cur_state;
				num8 = ((lzham_lzham_decompressor*)ptr)->m_dst_ofs;
				num9 = ((lzham_symbol_codec*)codec)->m_arith_value;
				num10 = ((lzham_symbol_codec*)codec)->m_arith_length;
				num11 = ((lzham_symbol_codec*)codec)->m_bit_buf;
				num12 = ((lzham_symbol_codec*)codec)->m_bit_count;
				ptr3 = ((lzham_symbol_codec*)codec)->m_pDecode_buf_next;
				goto IL_0812;
			}
			if (((lzham_lzham_decompressor*)ptr)->m_params.m_num_seed_bytes != 0)
			{
				llvm_memcpy_p0_p0_i64.Invoke(pDecomp_buf, ((lzham_lzham_decompressor*)ptr)->m_params.m_pSeed_bytes, (uint)((lzham_lzham_decompressor*)ptr)->m_params.m_num_seed_bytes, isVolatile: false);
				int num_seed_bytes = ((lzham_lzham_decompressor*)ptr)->m_params.m_num_seed_bytes;
				num8 += num_seed_bytes;
				if ((uint)num8 >= (uint)num)
				{
					num8 = 0;
				}
				else
				{
					((lzham_lzham_decompressor*)ptr)->m_seed_bytes_to_ignore_when_flushing = num8;
				}
			}
			if (!start_decoding.Invoke(&((lzham_lzham_decompressor*)ptr)->m_codec, eof_flag: (((lzham_lzham_decompressor*)ptr)->m_no_more_input_bytes_flag & 1) == 1, buf_size: *(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size, pBuf: ((lzham_lzham_decompressor*)ptr)->m_pIn_buf, pNeed_bytes_func: null, pPrivate_data: null))
			{
				return 4;
			}
			num9 = ((lzham_symbol_codec*)codec)->m_arith_value;
			num10 = ((lzham_symbol_codec*)codec)->m_arith_length;
			num11 = ((lzham_symbol_codec*)codec)->m_bit_buf;
			num12 = ((lzham_symbol_codec*)codec)->m_bit_count;
			ptr3 = ((lzham_symbol_codec*)codec)->m_pDecode_buf_next;
			if ((((lzham_lzham_decompressor*)ptr)->m_params.m_decompress_flags & 4) == 0)
			{
				goto IL_0e6c;
			}
			goto IL_0637;
		}
		IL_8a33:
		int num22;
		unchecked
		{
			while (num12 >= 1)
			{
				int num21 = (int)(num11 >>> 63);
				num11 <<= 1;
				num12 = checked(num12 - 1);
				if (num21 != 0)
				{
					num13++;
					if ((uint)num13 < 3u)
					{
						continue;
					}
				}
				goto IL_8d39;
			}
			if (ptr3 == ((lzham_symbol_codec*)codec)->m_pDecode_buf_end)
			{
				if ((((lzham_symbol_codec*)codec)->m_decode_buf_eof & 1) != 1)
				{
					((lzham_symbol_codec*)codec)->m_arith_value = num9;
					((lzham_symbol_codec*)codec)->m_arith_length = num10;
					((lzham_symbol_codec*)codec)->m_bit_buf = num11;
					((lzham_symbol_codec*)codec)->m_bit_count = num12;
					((lzham_symbol_codec*)codec)->m_pDecode_buf_next = ptr3;
					((lzham_lzham_decompressor*)ptr)->m_match_len = num13;
					((lzham_lzham_decompressor*)ptr)->m_match_slot = num14;
					((lzham_lzham_decompressor*)ptr)->m_match_hist0 = num3;
					((lzham_lzham_decompressor*)ptr)->m_match_hist1 = num4;
					((lzham_lzham_decompressor*)ptr)->m_match_hist2 = num5;
					((lzham_lzham_decompressor*)ptr)->m_match_hist3 = num6;
					((lzham_lzham_decompressor*)ptr)->m_cur_state = num7;
					((lzham_lzham_decompressor*)ptr)->m_dst_ofs = num8;
					goto IL_8b43;
				}
				goto IL_8c7e;
			}
			void* ptr11 = ptr3;
			ptr3 = (byte*)ptr11 + 1;
			num22 = (byte)(*(sbyte*)ptr11);
			goto IL_8cc6;
		}
		IL_8d39:
		int num23;
		int num24;
		unchecked
		{
			if (num12 < (byte)((sbyte*)s_huge_match_code_len.Pointer)[(uint)num13])
			{
				if (ptr3 == ((lzham_symbol_codec*)codec)->m_pDecode_buf_end)
				{
					if ((((lzham_symbol_codec*)codec)->m_decode_buf_eof & 1) != 1)
					{
						((lzham_symbol_codec*)codec)->m_arith_value = num9;
						((lzham_symbol_codec*)codec)->m_arith_length = num10;
						((lzham_symbol_codec*)codec)->m_bit_buf = num11;
						((lzham_symbol_codec*)codec)->m_bit_count = num12;
						((lzham_symbol_codec*)codec)->m_pDecode_buf_next = ptr3;
						((lzham_lzham_decompressor*)ptr)->m_match_len = num13;
						((lzham_lzham_decompressor*)ptr)->m_match_slot = num14;
						((lzham_lzham_decompressor*)ptr)->m_match_hist0 = num3;
						((lzham_lzham_decompressor*)ptr)->m_match_hist1 = num4;
						((lzham_lzham_decompressor*)ptr)->m_match_hist2 = num5;
						((lzham_lzham_decompressor*)ptr)->m_match_hist3 = num6;
						((lzham_lzham_decompressor*)ptr)->m_cur_state = num7;
						((lzham_lzham_decompressor*)ptr)->m_dst_ofs = num8;
						goto IL_8e5e;
					}
					goto IL_8f99;
				}
				void* ptr12 = ptr3;
				ptr3 = (byte*)ptr12 + 1;
				num23 = (byte)(*(sbyte*)ptr12);
				goto IL_8fe1;
			}
			num24 = (int)(((bool*)s_huge_match_code_len.Pointer)[(uint)num13] ? (num11 >>> (int)(uint)checked(64 - unchecked((byte)((sbyte*)s_huge_match_code_len.Pointer)[(uint)num13]))) : 0);
			num11 <<= (int)(byte)((sbyte*)s_huge_match_code_len.Pointer)[(uint)num13];
		}
		num12 -= unchecked((byte)((sbyte*)s_huge_match_code_len.Pointer)[(uint)num13]);
		num13 = unchecked(((int*)s_huge_match_base_len.Pointer)[(uint)num13] + num24);
		goto IL_90c8;
		IL_8cc6:
		num12 += 8;
		unchecked
		{
			num11 |= (long)((ulong)(uint)num22 << (int)(uint)checked(64 - num12));
			goto IL_8a33;
		}
		IL_2f48:
		num12 += 8;
		int num25;
		unchecked
		{
			num11 |= (long)((ulong)(uint)num25 << (int)(uint)checked(64 - num12));
			goto IL_2ccc;
		}
		IL_2dce:
		unchecked
		{
			long num26 = decode_get_bytes_consumed.Invoke(&((lzham_lzham_decompressor*)ptr)->m_codec);
			*(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size = num26;
			*(long*)((lzham_lzham_decompressor*)ptr)->m_pOut_buf_size = 0L;
			((lzham_lzham_decompressor*)ptr)->m_state = 536;
			return 2;
		}
		IL_8b43:
		unchecked
		{
			long num27 = decode_get_bytes_consumed.Invoke(&((lzham_lzham_decompressor*)ptr)->m_codec);
			*(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size = num27;
			*(long*)((lzham_lzham_decompressor*)ptr)->m_pOut_buf_size = 0L;
			((lzham_lzham_decompressor*)ptr)->m_state = 907;
			return 2;
		}
		IL_63fc:
		unchecked
		{
			int num28 = (int)((num11 >>> 48) + 1L);
			int i;
			if ((uint)num28 <= (uint)((lzham_prefix_coding_decoder_tables*)pDecode_tables5)->m_table_max_code)
			{
				int num29 = ((int*)((lzham_prefix_coding_decoder_tables*)pDecode_tables5)->m_lookup)[num11 >>> (int)(uint)(64 - ((lzham_prefix_coding_decoder_tables*)pDecode_tables5)->m_table_bits)];
				num13 = num29 & 0xFFFF;
				i = num29 >>> 16;
			}
			else
			{
				for (i = ((lzham_prefix_coding_decoder_tables*)pDecode_tables5)->m_decode_start_code_size; (uint)num28 > (uint)((int*)(&((lzham_prefix_coding_decoder_tables*)pDecode_tables5)->m_max_codes))[(uint)(i - 1)]; i++)
				{
				}
				int num30;
				checked
				{
					num30 = unchecked(((int*)(&((lzham_prefix_coding_decoder_tables*)pDecode_tables5)->m_val_ptrs))[(uint)(i - 1)]) + unchecked((int)(num11 >>> (int)(uint)(64 - i)));
				}
				if ((uint)num30 >= (uint)((lzham_raw_quasi_adaptive_huffman_data_model*)ptr8)->m_total_syms)
				{
					num30 = 0;
				}
				num13 = (ushort)((short*)((lzham_prefix_coding_decoder_tables*)pDecode_tables5)->m_sorted_symbol_order)[num30];
			}
			num11 <<= (int)(uint)i;
			num12 -= i;
			int num31 = (ushort)(*(short*)vector_unsigned_short_Operator.Invoke(&((lzham_raw_quasi_adaptive_huffman_data_model*)ptr8)->m_sym_freq, num13));
			*(short*)vector_unsigned_short_Operator.Invoke(&((lzham_raw_quasi_adaptive_huffman_data_model*)ptr8)->m_sym_freq, num13) = (short)(num31 + 1);
			if ((((lzham_raw_quasi_adaptive_huffman_data_model*)ptr8)->m_symbols_until_update += -1) == 0)
			{
				update_tables.Invoke(ptr8, -1, sym_freq_all_ones: false);
				if (ExceptionInfo.Current != null)
				{
					return 0;
				}
			}
			num13 += 2;
			if (num13 != 258)
			{
				goto IL_6bff;
			}
			num13 = 0;
			goto IL_65a0;
		}
		IL_8886:
		unchecked
		{
			int num32 = (int)((num11 >>> 48) + 1L);
			int num34;
			int j;
			if ((uint)num32 <= (uint)((lzham_prefix_coding_decoder_tables*)pDecode_tables2)->m_table_max_code)
			{
				int num33 = ((int*)((lzham_prefix_coding_decoder_tables*)pDecode_tables2)->m_lookup)[num11 >>> (int)(uint)(64 - ((lzham_prefix_coding_decoder_tables*)pDecode_tables2)->m_table_bits)];
				num34 = num33 & 0xFFFF;
				j = num33 >>> 16;
			}
			else
			{
				for (j = ((lzham_prefix_coding_decoder_tables*)pDecode_tables2)->m_decode_start_code_size; (uint)num32 > (uint)((int*)(&((lzham_prefix_coding_decoder_tables*)pDecode_tables2)->m_max_codes))[(uint)(j - 1)]; j++)
				{
				}
				int num35;
				checked
				{
					num35 = unchecked(((int*)(&((lzham_prefix_coding_decoder_tables*)pDecode_tables2)->m_val_ptrs))[(uint)(j - 1)]) + unchecked((int)(num11 >>> (int)(uint)(64 - j)));
				}
				if ((uint)num35 >= (uint)((lzham_raw_quasi_adaptive_huffman_data_model*)ptr5)->m_total_syms)
				{
					num35 = 0;
				}
				num34 = (ushort)((short*)((lzham_prefix_coding_decoder_tables*)pDecode_tables2)->m_sorted_symbol_order)[num35];
			}
			num11 <<= (int)(uint)j;
			num12 -= j;
			int num36 = (ushort)(*(short*)vector_unsigned_short_Operator.Invoke(&((lzham_raw_quasi_adaptive_huffman_data_model*)ptr5)->m_sym_freq, num34));
			*(short*)vector_unsigned_short_Operator.Invoke(&((lzham_raw_quasi_adaptive_huffman_data_model*)ptr5)->m_sym_freq, num34) = (short)(num36 + 1);
			if ((((lzham_raw_quasi_adaptive_huffman_data_model*)ptr5)->m_symbols_until_update += -1) == 0)
			{
				update_tables.Invoke(ptr5, -1, sym_freq_all_ones: false);
				if (ExceptionInfo.Current != null)
				{
					return 0;
				}
			}
			num13 += num34;
			if (num13 != 258)
			{
				goto IL_90c8;
			}
			num13 = 0;
			goto IL_8a33;
		}
		IL_5ee3:
		int num37 = 0;
		unchecked
		{
			if (ptr3 < ((lzham_symbol_codec*)codec)->m_pDecode_buf_end)
			{
				void* ptr13 = ptr3;
				ptr3 = (byte*)ptr13 + 1;
				num37 = (byte)(*(sbyte*)ptr13);
			}
			goto IL_5f2b;
		}
		IL_9dca:
		void* ptr15;
		void* ptr14 = ptr15;
		int num38;
		unchecked
		{
			ptr15 = (byte*)ptr14 + 1;
			sbyte b = *(sbyte*)ptr14;
			((sbyte*)pDecomp_buf)[(uint)num8++] = b;
			if (ptr15 == ptr2)
			{
				ptr15 = pDecomp_buf;
			}
			if ((uint)num8 <= (uint)num2)
			{
				goto IL_a259;
			}
			((lzham_symbol_codec*)codec)->m_arith_value = num9;
			((lzham_symbol_codec*)codec)->m_arith_length = num10;
			((lzham_symbol_codec*)codec)->m_bit_buf = num11;
			((lzham_symbol_codec*)codec)->m_bit_count = num12;
			((lzham_symbol_codec*)codec)->m_pDecode_buf_next = ptr3;
			((lzham_lzham_decompressor*)ptr)->m_match_len = num13;
			((lzham_lzham_decompressor*)ptr)->m_src_ofs = num38;
			((lzham_lzham_decompressor*)ptr)->m_pCopy_src = ptr15;
			((lzham_lzham_decompressor*)ptr)->m_match_hist0 = num3;
			((lzham_lzham_decompressor*)ptr)->m_match_hist1 = num4;
			((lzham_lzham_decompressor*)ptr)->m_match_hist2 = num5;
			((lzham_lzham_decompressor*)ptr)->m_match_hist3 = num6;
			((lzham_lzham_decompressor*)ptr)->m_cur_state = num7;
			((lzham_lzham_decompressor*)ptr)->m_dst_ofs = num8;
			((lzham_lzham_decompressor*)ptr)->m_pFlush_src = (byte*)((lzham_lzham_decompressor*)ptr)->m_pDecomp_buf + (uint)((lzham_lzham_decompressor*)ptr)->m_seed_bytes_to_ignore_when_flushing + (uint)((lzham_lzham_decompressor*)ptr)->m_dst_highwater_ofs;
			((lzham_lzham_decompressor*)ptr)->m_flush_num_bytes_remaining = (uint)(num - ((lzham_lzham_decompressor*)ptr)->m_seed_bytes_to_ignore_when_flushing - ((lzham_lzham_decompressor*)ptr)->m_dst_highwater_ofs);
			((lzham_lzham_decompressor*)ptr)->m_seed_bytes_to_ignore_when_flushing = 0;
			((lzham_lzham_decompressor*)ptr)->m_dst_highwater_ofs = num & num2;
			goto IL_9f77;
		}
		IL_448c:
		num12 += 8;
		int num39;
		unchecked
		{
			num11 |= (long)((ulong)(uint)num39 << (int)(uint)checked(64 - num12));
			goto IL_422d;
		}
		IL_0812:
		int num40 = 0;
		unchecked
		{
			if (ptr3 < ((lzham_symbol_codec*)codec)->m_pDecode_buf_end)
			{
				void* ptr16 = ptr3;
				ptr3 = (byte*)ptr16 + 1;
				num40 = (byte)(*(sbyte*)ptr16);
			}
			goto IL_084b;
		}
		IL_5aef:
		int num41 = 0;
		unchecked
		{
			if (ptr3 < ((lzham_symbol_codec*)codec)->m_pDecode_buf_end)
			{
				void* ptr17 = ptr3;
				ptr3 = (byte*)ptr17 + 1;
				num41 = (byte)(*(sbyte*)ptr17);
			}
			goto IL_5b37;
		}
		IL_084b:
		num12 += 8;
		unchecked
		{
			num11 |= (long)((ulong)(uint)num40 << (int)(uint)checked(64 - num12));
			goto IL_0637;
		}
		IL_0637:
		unchecked
		{
			if (num12 < 8)
			{
				if (ptr3 == ((lzham_symbol_codec*)codec)->m_pDecode_buf_end)
				{
					if ((((lzham_symbol_codec*)codec)->m_decode_buf_eof & 1) != 1)
					{
						((lzham_symbol_codec*)codec)->m_arith_value = num9;
						((lzham_symbol_codec*)codec)->m_arith_length = num10;
						((lzham_symbol_codec*)codec)->m_bit_buf = num11;
						((lzham_symbol_codec*)codec)->m_bit_count = num12;
						((lzham_symbol_codec*)codec)->m_pDecode_buf_next = ptr3;
						((lzham_lzham_decompressor*)ptr)->m_match_hist0 = num3;
						((lzham_lzham_decompressor*)ptr)->m_match_hist1 = num4;
						((lzham_lzham_decompressor*)ptr)->m_match_hist2 = num5;
						((lzham_lzham_decompressor*)ptr)->m_match_hist3 = num6;
						((lzham_lzham_decompressor*)ptr)->m_cur_state = num7;
						((lzham_lzham_decompressor*)ptr)->m_dst_ofs = num8;
						goto IL_06f9;
					}
					goto IL_0812;
				}
				void* ptr18 = ptr3;
				ptr3 = (byte*)ptr18 + 1;
				num40 = (byte)(*(sbyte*)ptr18);
				goto IL_084b;
			}
			((lzham_lzham_decompressor*)ptr)->m_z_cmf = (int)(num11 >>> 56);
			num11 <<= 8;
		}
		num12 -= 8;
		goto IL_089c;
		IL_afdb:
		int num42 = 0;
		unchecked
		{
			if (ptr3 < ((lzham_symbol_codec*)codec)->m_pDecode_buf_end)
			{
				void* ptr19 = ptr3;
				ptr3 = (byte*)ptr19 + 1;
				num42 = (byte)(*(sbyte*)ptr19);
			}
			goto IL_b023;
		}
		IL_90f6:
		int num43;
		unchecked
		{
			if (num12 < num16)
			{
				if (ptr3 == ((lzham_symbol_codec*)codec)->m_pDecode_buf_end)
				{
					if ((((lzham_symbol_codec*)codec)->m_decode_buf_eof & 1) != 1)
					{
						((lzham_symbol_codec*)codec)->m_arith_value = num9;
						((lzham_symbol_codec*)codec)->m_arith_length = num10;
						((lzham_symbol_codec*)codec)->m_bit_buf = num11;
						((lzham_symbol_codec*)codec)->m_bit_count = num12;
						((lzham_symbol_codec*)codec)->m_pDecode_buf_next = ptr3;
						((lzham_lzham_decompressor*)ptr)->m_match_len = num13;
						((lzham_lzham_decompressor*)ptr)->m_match_slot = num14;
						((lzham_lzham_decompressor*)ptr)->m_num_extra_bits = num16;
						((lzham_lzham_decompressor*)ptr)->m_match_hist0 = num3;
						((lzham_lzham_decompressor*)ptr)->m_match_hist1 = num4;
						((lzham_lzham_decompressor*)ptr)->m_match_hist2 = num5;
						((lzham_lzham_decompressor*)ptr)->m_match_hist3 = num6;
						((lzham_lzham_decompressor*)ptr)->m_cur_state = num7;
						((lzham_lzham_decompressor*)ptr)->m_dst_ofs = num8;
						goto IL_9218;
					}
					goto IL_935c;
				}
				void* ptr20 = ptr3;
				ptr3 = (byte*)ptr20 + 1;
				num43 = (byte)(*(sbyte*)ptr20);
				goto IL_93a4;
			}
			num15 = (int)((num16 != 0) ? (num11 >>> (int)(uint)(64 - num16)) : 0);
			num11 <<= (int)(uint)num16;
			num12 -= num16;
			goto IL_9c87;
		}
		IL_78d1:
		unchecked
		{
			long num44 = decode_get_bytes_consumed.Invoke(&((lzham_lzham_decompressor*)ptr)->m_codec);
			*(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size = num44;
			*(long*)((lzham_lzham_decompressor*)ptr)->m_pOut_buf_size = 0L;
			((lzham_lzham_decompressor*)ptr)->m_state = 828;
			return 2;
		}
		IL_90c8:
		unchecked
		{
			_ = &((lzham_lzham_decompressor*)ptr)->m_lzBase;
			num16 = (byte)((sbyte*)m_lzx_position_extra_bits.Pointer)[(uint)num14];
			if ((uint)num16 < 3u)
			{
				goto IL_90f6;
			}
			num15 = 0;
			if ((uint)num16 <= 4u)
			{
				goto IL_976e;
			}
			goto IL_9434;
		}
		IL_2fcd:
		int num45 = -1;
		if (num12 >= 8)
		{
			num45 = unchecked((int)(num11 >>> 56));
			num11 <<= 8;
			num12 -= 8;
		}
		if (num45 < 0)
		{
			goto IL_3512;
		}
		unchecked
		{
			long num46;
			if (false && (ulong)(uint)num8 >= (ulong)num46)
			{
				int arith_value;
				((lzham_symbol_codec*)codec)->m_arith_value = arith_value;
				int arith_length;
				((lzham_symbol_codec*)codec)->m_arith_length = arith_length;
				long bit_buf;
				((lzham_symbol_codec*)codec)->m_bit_buf = bit_buf;
				int bit_count;
				((lzham_symbol_codec*)codec)->m_bit_count = bit_count;
				void* pDecode_buf_next;
				((lzham_symbol_codec*)codec)->m_pDecode_buf_next = pDecode_buf_next;
				decode_get_bytes_consumed.Invoke(codec);
				long num47;
				*(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size = num47;
				*(long*)((lzham_lzham_decompressor*)ptr)->m_pOut_buf_size = 0L;
				goto IL_30aa;
			}
			((sbyte*)pDecomp_buf)[(uint)num8++] = (sbyte)num45;
			if ((uint)num8 <= (uint)num2)
			{
				goto IL_34fb;
			}
			((lzham_symbol_codec*)codec)->m_arith_value = num9;
			((lzham_symbol_codec*)codec)->m_arith_length = num10;
			((lzham_symbol_codec*)codec)->m_bit_buf = num11;
			((lzham_symbol_codec*)codec)->m_bit_count = num12;
			((lzham_symbol_codec*)codec)->m_pDecode_buf_next = ptr3;
			((lzham_lzham_decompressor*)ptr)->m_num_raw_bytes_remaining = num18;
			((lzham_lzham_decompressor*)ptr)->m_match_hist0 = num3;
			((lzham_lzham_decompressor*)ptr)->m_match_hist1 = num4;
			((lzham_lzham_decompressor*)ptr)->m_match_hist2 = num5;
			((lzham_lzham_decompressor*)ptr)->m_match_hist3 = num6;
			((lzham_lzham_decompressor*)ptr)->m_cur_state = num7;
			((lzham_lzham_decompressor*)ptr)->m_dst_ofs = num8;
			((lzham_lzham_decompressor*)ptr)->m_pFlush_src = (byte*)((lzham_lzham_decompressor*)ptr)->m_pDecomp_buf + (uint)((lzham_lzham_decompressor*)ptr)->m_seed_bytes_to_ignore_when_flushing + (uint)((lzham_lzham_decompressor*)ptr)->m_dst_highwater_ofs;
			((lzham_lzham_decompressor*)ptr)->m_flush_num_bytes_remaining = (uint)(num - ((lzham_lzham_decompressor*)ptr)->m_seed_bytes_to_ignore_when_flushing - ((lzham_lzham_decompressor*)ptr)->m_dst_highwater_ofs);
			((lzham_lzham_decompressor*)ptr)->m_seed_bytes_to_ignore_when_flushing = 0;
			((lzham_lzham_decompressor*)ptr)->m_dst_highwater_ofs = num & num2;
			goto IL_322b;
		}
		IL_06f9:
		unchecked
		{
			long num48 = decode_get_bytes_consumed.Invoke(&((lzham_lzham_decompressor*)ptr)->m_codec);
			*(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size = num48;
			*(long*)((lzham_lzham_decompressor*)ptr)->m_pOut_buf_size = 0L;
			((lzham_lzham_decompressor*)ptr)->m_state = 369;
			return 2;
		}
		IL_a7f4:
		unchecked
		{
			if (((lzham_lzham_decompressor*)ptr)->m_flush_num_bytes_remaining != 0L)
			{
				((lzham_lzham_decompressor*)ptr)->m_flush_n = (((ulong)((lzham_lzham_decompressor*)ptr)->m_flush_num_bytes_remaining >= (ulong)(*(long*)((lzham_lzham_decompressor*)ptr)->m_pOut_buf_size)) ? (*(long*)((lzham_lzham_decompressor*)ptr)->m_pOut_buf_size) : ((lzham_lzham_decompressor*)ptr)->m_flush_num_bytes_remaining);
				if (0 == (((lzham_lzham_decompressor*)ptr)->m_params.m_decompress_flags & 2))
				{
					llvm_memcpy_p0_p0_i64.Invoke(((lzham_lzham_decompressor*)ptr)->m_pOut_buf, ((lzham_lzham_decompressor*)ptr)->m_pFlush_src, ((lzham_lzham_decompressor*)ptr)->m_flush_n, isVolatile: false);
				}
				else
				{
					long num50;
					for (long num49 = 0L; (ulong)num49 < (ulong)((lzham_lzham_decompressor*)ptr)->m_flush_n; num49 += num50)
					{
						num50 = (((ulong)(((lzham_lzham_decompressor*)ptr)->m_flush_n - num49) >= 8192uL) ? 8192L : (((lzham_lzham_decompressor*)ptr)->m_flush_n - num49));
						llvm_memcpy_p0_p0_i64.Invoke((byte*)((lzham_lzham_decompressor*)ptr)->m_pOut_buf + num49, (byte*)((lzham_lzham_decompressor*)ptr)->m_pFlush_src + num49, num50, isVolatile: false);
						((lzham_lzham_decompressor*)ptr)->m_decomp_adler32 = adler32.Invoke(adler32: ((lzham_lzham_decompressor*)ptr)->m_decomp_adler32, pBuf: (byte*)((lzham_lzham_decompressor*)ptr)->m_pFlush_src + num49, buflen: num50);
					}
				}
				long num51 = decode_get_bytes_consumed.Invoke(&((lzham_lzham_decompressor*)ptr)->m_codec);
				*(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size = num51;
				long flush_n13 = ((lzham_lzham_decompressor*)ptr)->m_flush_n;
				*(long*)((lzham_lzham_decompressor*)ptr)->m_pOut_buf_size = flush_n13;
				((lzham_lzham_decompressor*)ptr)->m_state = 1074;
				return InstructionHelper.Select(((lzham_lzham_decompressor*)ptr)->m_flush_n != 0L, 0, 1);
			}
			num3 = ((lzham_lzham_decompressor*)ptr)->m_match_hist0;
			num4 = ((lzham_lzham_decompressor*)ptr)->m_match_hist1;
			num5 = ((lzham_lzham_decompressor*)ptr)->m_match_hist2;
			num6 = ((lzham_lzham_decompressor*)ptr)->m_match_hist3;
			num7 = ((lzham_lzham_decompressor*)ptr)->m_cur_state;
			num8 = ((lzham_lzham_decompressor*)ptr)->m_dst_ofs;
			num9 = ((lzham_symbol_codec*)codec)->m_arith_value;
			num10 = ((lzham_symbol_codec*)codec)->m_arith_length;
			num11 = ((lzham_symbol_codec*)codec)->m_bit_buf;
			num12 = ((lzham_symbol_codec*)codec)->m_bit_count;
			ptr3 = ((lzham_symbol_codec*)codec)->m_pDecode_buf_next;
			goto IL_aab8;
		}
		IL_49bd:
		unchecked
		{
			int num52 = (int)((num11 >>> 48) + 1L);
			int num54;
			int k;
			if ((uint)num52 <= (uint)((lzham_prefix_coding_decoder_tables*)pDecode_tables7)->m_table_max_code)
			{
				int num53 = ((int*)((lzham_prefix_coding_decoder_tables*)pDecode_tables7)->m_lookup)[num11 >>> (int)(uint)(64 - ((lzham_prefix_coding_decoder_tables*)pDecode_tables7)->m_table_bits)];
				num54 = num53 & 0xFFFF;
				k = num53 >>> 16;
			}
			else
			{
				for (k = ((lzham_prefix_coding_decoder_tables*)pDecode_tables7)->m_decode_start_code_size; (uint)num52 > (uint)((int*)(&((lzham_prefix_coding_decoder_tables*)pDecode_tables7)->m_max_codes))[(uint)(k - 1)]; k++)
				{
				}
				int num55;
				checked
				{
					num55 = unchecked(((int*)(&((lzham_prefix_coding_decoder_tables*)pDecode_tables7)->m_val_ptrs))[(uint)(k - 1)]) + unchecked((int)(num11 >>> (int)(uint)(64 - k)));
				}
				if ((uint)num55 >= (uint)((lzham_raw_quasi_adaptive_huffman_data_model*)ptr10)->m_total_syms)
				{
					num55 = 0;
				}
				num54 = (ushort)((short*)((lzham_prefix_coding_decoder_tables*)pDecode_tables7)->m_sorted_symbol_order)[num55];
			}
			num11 <<= (int)(uint)k;
			num12 -= k;
			int num56 = (ushort)(*(short*)vector_unsigned_short_Operator.Invoke(&((lzham_raw_quasi_adaptive_huffman_data_model*)ptr10)->m_sym_freq, num54));
			*(short*)vector_unsigned_short_Operator.Invoke(&((lzham_raw_quasi_adaptive_huffman_data_model*)ptr10)->m_sym_freq, num54) = (short)(num56 + 1);
			if ((((lzham_raw_quasi_adaptive_huffman_data_model*)ptr10)->m_symbols_until_update += -1) == 0)
			{
				update_tables.Invoke(ptr10, -1, sym_freq_all_ones: false);
				if (ExceptionInfo.Current != null)
				{
					return 0;
				}
			}
			((sbyte*)pDecomp_buf)[(uint)num8] = (sbyte)num54;
			goto IL_506d;
		}
		IL_2f00:
		num25 = 0;
		unchecked
		{
			if (ptr3 < ((lzham_symbol_codec*)codec)->m_pDecode_buf_end)
			{
				void* ptr21 = ptr3;
				ptr3 = (byte*)ptr21 + 1;
				num25 = (byte)(*(sbyte*)ptr21);
			}
			goto IL_2f48;
		}
		IL_1828:
		unchecked
		{
			long num57 = decode_get_bytes_consumed.Invoke(&((lzham_lzham_decompressor*)ptr)->m_codec);
			*(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size = num57;
			*(long*)((lzham_lzham_decompressor*)ptr)->m_pOut_buf_size = 0L;
			((lzham_lzham_decompressor*)ptr)->m_state = 445;
			return 2;
		}
		IL_0a77:
		int num58 = 0;
		unchecked
		{
			if (ptr3 < ((lzham_symbol_codec*)codec)->m_pDecode_buf_end)
			{
				void* ptr22 = ptr3;
				ptr3 = (byte*)ptr22 + 1;
				num58 = (byte)(*(sbyte*)ptr22);
			}
			goto IL_0ab0;
		}
		IL_3e84:
		num12 += 8;
		int num59;
		unchecked
		{
			num11 |= (long)((ulong)(uint)num59 << (int)(uint)checked(64 - num12));
			goto IL_3c25;
		}
		IL_0ab0:
		num12 += 8;
		unchecked
		{
			num11 |= (long)((ulong)(uint)num58 << (int)(uint)checked(64 - num12));
			goto IL_089c;
		}
		IL_089c:
		unchecked
		{
			if (num12 < 8)
			{
				if (ptr3 == ((lzham_symbol_codec*)codec)->m_pDecode_buf_end)
				{
					if ((((lzham_symbol_codec*)codec)->m_decode_buf_eof & 1) != 1)
					{
						((lzham_symbol_codec*)codec)->m_arith_value = num9;
						((lzham_symbol_codec*)codec)->m_arith_length = num10;
						((lzham_symbol_codec*)codec)->m_bit_buf = num11;
						((lzham_symbol_codec*)codec)->m_bit_count = num12;
						((lzham_symbol_codec*)codec)->m_pDecode_buf_next = ptr3;
						((lzham_lzham_decompressor*)ptr)->m_match_hist0 = num3;
						((lzham_lzham_decompressor*)ptr)->m_match_hist1 = num4;
						((lzham_lzham_decompressor*)ptr)->m_match_hist2 = num5;
						((lzham_lzham_decompressor*)ptr)->m_match_hist3 = num6;
						((lzham_lzham_decompressor*)ptr)->m_cur_state = num7;
						((lzham_lzham_decompressor*)ptr)->m_dst_ofs = num8;
						goto IL_095e;
					}
					goto IL_0a77;
				}
				void* ptr23 = ptr3;
				ptr3 = (byte*)ptr23 + 1;
				num58 = (byte)(*(sbyte*)ptr23);
				goto IL_0ab0;
			}
			((lzham_lzham_decompressor*)ptr)->m_z_flg = (int)(num11 >>> 56);
			num11 <<= 8;
			num12 = checked(num12 - 8);
			if ((uint)((((lzham_lzham_decompressor*)ptr)->m_z_cmf << 8) + ((lzham_lzham_decompressor*)ptr)->m_z_flg) % 31u != 0 || (((lzham_lzham_decompressor*)ptr)->m_z_cmf & 0xF) != 14)
			{
				return 11;
			}
			if ((((lzham_lzham_decompressor*)ptr)->m_z_flg & 0x20) == 0)
			{
				goto IL_0e6c;
			}
			if (((lzham_lzham_decompressor*)ptr)->m_params.m_pSeed_bytes == null)
			{
				return 12;
			}
			((lzham_lzham_decompressor*)ptr)->m_z_dict_adler32 = 0;
			((lzham_lzham_decompressor*)ptr)->m_tmp = 0;
			goto IL_0b84;
		}
		IL_30aa:
		unchecked((lzham_lzham_decompressor*)ptr)->m_state = 551;
		return 5;
		IL_1a1e:
		int num60;
		unchecked
		{
			if (num12 < 16)
			{
				if (ptr3 == ((lzham_symbol_codec*)codec)->m_pDecode_buf_end)
				{
					if ((((lzham_symbol_codec*)codec)->m_decode_buf_eof & 1) != 1)
					{
						((lzham_symbol_codec*)codec)->m_arith_value = num9;
						((lzham_symbol_codec*)codec)->m_arith_length = num10;
						((lzham_symbol_codec*)codec)->m_bit_buf = num11;
						((lzham_symbol_codec*)codec)->m_bit_count = num12;
						((lzham_symbol_codec*)codec)->m_pDecode_buf_next = ptr3;
						((lzham_lzham_decompressor*)ptr)->m_match_hist0 = num3;
						((lzham_lzham_decompressor*)ptr)->m_match_hist1 = num4;
						((lzham_lzham_decompressor*)ptr)->m_match_hist2 = num5;
						((lzham_lzham_decompressor*)ptr)->m_match_hist3 = num6;
						((lzham_lzham_decompressor*)ptr)->m_cur_state = num7;
						((lzham_lzham_decompressor*)ptr)->m_dst_ofs = num8;
						goto IL_1b0d;
					}
					goto IL_1c36;
				}
				void* ptr24 = ptr3;
				ptr3 = (byte*)ptr24 + 1;
				num60 = (byte)(*(sbyte*)ptr24);
				goto IL_1c7e;
			}
			int num61 = (int)(num11 >>> 48);
			num11 <<= 16;
			num12 = checked(num12 - 16);
			if (num61 == 0)
			{
				goto IL_1d78;
			}
			((lzham_symbol_codec*)codec)->m_arith_value = num9;
			((lzham_symbol_codec*)codec)->m_arith_length = num10;
			((lzham_symbol_codec*)codec)->m_bit_buf = num11;
			((lzham_symbol_codec*)codec)->m_bit_count = num12;
			((lzham_symbol_codec*)codec)->m_pDecode_buf_next = ptr3;
			long num62 = decode_get_bytes_consumed.Invoke(codec);
			*(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size = num62;
			*(long*)((lzham_lzham_decompressor*)ptr)->m_pOut_buf_size = 0L;
			goto IL_1d5e;
		}
		IL_b29a:
		int num63 = 0;
		unchecked
		{
			if (ptr3 < ((lzham_symbol_codec*)codec)->m_pDecode_buf_end)
			{
				void* ptr25 = ptr3;
				ptr3 = (byte*)ptr25 + 1;
				num63 = (byte)(*(sbyte*)ptr25);
			}
			goto IL_b2e2;
		}
		IL_7a4b:
		num12 += 8;
		int num64;
		unchecked
		{
			num11 |= (long)((ulong)(uint)num64 << (int)(uint)checked(64 - num12));
			goto IL_77d2;
		}
		IL_7bb1:
		void* ptr26;
		unchecked
		{
			if ((uint)num10 < 16777216u)
			{
				((lzham_symbol_codec*)codec)->m_pSaved_model = ptr26;
				goto IL_7bd4;
			}
			int num65 = (ushort)((lzham_adaptive_bit_model*)ptr26)->m_bit_0_prob * (num10 >>> 11);
			int num66 = (((uint)num9 >= (uint)num65) ? 1 : 0);
			if (num66 == 0)
			{
				int num67 = 2048 - (ushort)((lzham_adaptive_bit_model*)ptr26)->m_bit_0_prob >>> 5;
				short* bit_0_prob = &((lzham_adaptive_bit_model*)ptr26)->m_bit_0_prob;
				*bit_0_prob = (short)((ushort)(*bit_0_prob) + num67);
				num10 = num65;
			}
			else
			{
				int num68 = (ushort)((lzham_adaptive_bit_model*)ptr26)->m_bit_0_prob >> 5;
				short* bit_0_prob2 = &((lzham_adaptive_bit_model*)ptr26)->m_bit_0_prob;
				*bit_0_prob2 = (short)checked(unchecked((ushort)(*bit_0_prob2)) - num68);
				num9 -= num65;
				num10 -= num65;
			}
			if (num66 != 0)
			{
				int num69 = num5;
				num5 = num4;
				num4 = num3;
				num3 = num69;
			}
			else
			{
				int num70 = num6;
				num6 = num5;
				num5 = num4;
				num4 = num3;
				num3 = num70;
			}
			goto IL_7fb4;
		}
		IL_7138:
		int num72;
		unchecked
		{
			while (num12 >= 1)
			{
				int num71 = (int)(num11 >>> 63);
				num11 <<= 1;
				num12 = checked(num12 - 1);
				if (num71 != 0)
				{
					num13++;
					if ((uint)num13 < 3u)
					{
						continue;
					}
				}
				goto IL_7424;
			}
			if (ptr3 == ((lzham_symbol_codec*)codec)->m_pDecode_buf_end)
			{
				if ((((lzham_symbol_codec*)codec)->m_decode_buf_eof & 1) != 1)
				{
					((lzham_symbol_codec*)codec)->m_arith_value = num9;
					((lzham_symbol_codec*)codec)->m_arith_length = num10;
					((lzham_symbol_codec*)codec)->m_bit_buf = num11;
					((lzham_symbol_codec*)codec)->m_bit_count = num12;
					((lzham_symbol_codec*)codec)->m_pDecode_buf_next = ptr3;
					((lzham_lzham_decompressor*)ptr)->m_match_len = num13;
					((lzham_lzham_decompressor*)ptr)->m_match_hist0 = num3;
					((lzham_lzham_decompressor*)ptr)->m_match_hist1 = num4;
					((lzham_lzham_decompressor*)ptr)->m_match_hist2 = num5;
					((lzham_lzham_decompressor*)ptr)->m_match_hist3 = num6;
					((lzham_lzham_decompressor*)ptr)->m_cur_state = num7;
					((lzham_lzham_decompressor*)ptr)->m_dst_ofs = num8;
					goto IL_7237;
				}
				goto IL_7369;
			}
			void* ptr27 = ptr3;
			ptr3 = (byte*)ptr27 + 1;
			num72 = (byte)(*(sbyte*)ptr27);
			goto IL_73b1;
		}
		IL_9f77:
		unchecked
		{
			if (((lzham_lzham_decompressor*)ptr)->m_flush_num_bytes_remaining != 0L)
			{
				((lzham_lzham_decompressor*)ptr)->m_flush_n = (((ulong)((lzham_lzham_decompressor*)ptr)->m_flush_num_bytes_remaining >= (ulong)(*(long*)((lzham_lzham_decompressor*)ptr)->m_pOut_buf_size)) ? (*(long*)((lzham_lzham_decompressor*)ptr)->m_pOut_buf_size) : ((lzham_lzham_decompressor*)ptr)->m_flush_num_bytes_remaining);
				if (0 == (((lzham_lzham_decompressor*)ptr)->m_params.m_decompress_flags & 2))
				{
					llvm_memcpy_p0_p0_i64.Invoke(((lzham_lzham_decompressor*)ptr)->m_pOut_buf, ((lzham_lzham_decompressor*)ptr)->m_pFlush_src, ((lzham_lzham_decompressor*)ptr)->m_flush_n, isVolatile: false);
				}
				else
				{
					long num74;
					for (long num73 = 0L; (ulong)num73 < (ulong)((lzham_lzham_decompressor*)ptr)->m_flush_n; num73 += num74)
					{
						num74 = (((ulong)(((lzham_lzham_decompressor*)ptr)->m_flush_n - num73) >= 8192uL) ? 8192L : (((lzham_lzham_decompressor*)ptr)->m_flush_n - num73));
						llvm_memcpy_p0_p0_i64.Invoke((byte*)((lzham_lzham_decompressor*)ptr)->m_pOut_buf + num73, (byte*)((lzham_lzham_decompressor*)ptr)->m_pFlush_src + num73, num74, isVolatile: false);
						((lzham_lzham_decompressor*)ptr)->m_decomp_adler32 = adler32.Invoke(adler32: ((lzham_lzham_decompressor*)ptr)->m_decomp_adler32, pBuf: (byte*)((lzham_lzham_decompressor*)ptr)->m_pFlush_src + num73, buflen: num74);
					}
				}
				long num75 = decode_get_bytes_consumed.Invoke(&((lzham_lzham_decompressor*)ptr)->m_codec);
				*(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size = num75;
				long flush_n14 = ((lzham_lzham_decompressor*)ptr)->m_flush_n;
				*(long*)((lzham_lzham_decompressor*)ptr)->m_pOut_buf_size = flush_n14;
				((lzham_lzham_decompressor*)ptr)->m_state = 1002;
				return InstructionHelper.Select(((lzham_lzham_decompressor*)ptr)->m_flush_n != 0L, 0, 1);
			}
			num13 = ((lzham_lzham_decompressor*)ptr)->m_match_len;
			num38 = ((lzham_lzham_decompressor*)ptr)->m_src_ofs;
			ptr15 = ((lzham_lzham_decompressor*)ptr)->m_pCopy_src;
			num3 = ((lzham_lzham_decompressor*)ptr)->m_match_hist0;
			num4 = ((lzham_lzham_decompressor*)ptr)->m_match_hist1;
			num5 = ((lzham_lzham_decompressor*)ptr)->m_match_hist2;
			num6 = ((lzham_lzham_decompressor*)ptr)->m_match_hist3;
			num7 = ((lzham_lzham_decompressor*)ptr)->m_cur_state;
			_ = ((lzham_lzham_decompressor*)ptr)->m_dst_ofs;
			num9 = ((lzham_symbol_codec*)codec)->m_arith_value;
			num10 = ((lzham_symbol_codec*)codec)->m_arith_length;
			num11 = ((lzham_symbol_codec*)codec)->m_bit_buf;
			num12 = ((lzham_symbol_codec*)codec)->m_bit_count;
			ptr3 = ((lzham_symbol_codec*)codec)->m_pDecode_buf_next;
			num8 = 0;
			goto IL_a259;
		}
		IL_322b:
		unchecked
		{
			if (((lzham_lzham_decompressor*)ptr)->m_flush_num_bytes_remaining != 0L)
			{
				((lzham_lzham_decompressor*)ptr)->m_flush_n = (((ulong)((lzham_lzham_decompressor*)ptr)->m_flush_num_bytes_remaining >= (ulong)(*(long*)((lzham_lzham_decompressor*)ptr)->m_pOut_buf_size)) ? (*(long*)((lzham_lzham_decompressor*)ptr)->m_pOut_buf_size) : ((lzham_lzham_decompressor*)ptr)->m_flush_num_bytes_remaining);
				if (0 == (((lzham_lzham_decompressor*)ptr)->m_params.m_decompress_flags & 2))
				{
					llvm_memcpy_p0_p0_i64.Invoke(((lzham_lzham_decompressor*)ptr)->m_pOut_buf, ((lzham_lzham_decompressor*)ptr)->m_pFlush_src, ((lzham_lzham_decompressor*)ptr)->m_flush_n, isVolatile: false);
				}
				else
				{
					long num77;
					for (long num76 = 0L; (ulong)num76 < (ulong)((lzham_lzham_decompressor*)ptr)->m_flush_n; num76 += num77)
					{
						num77 = (((ulong)(((lzham_lzham_decompressor*)ptr)->m_flush_n - num76) >= 8192uL) ? 8192L : (((lzham_lzham_decompressor*)ptr)->m_flush_n - num76));
						llvm_memcpy_p0_p0_i64.Invoke((byte*)((lzham_lzham_decompressor*)ptr)->m_pOut_buf + num76, (byte*)((lzham_lzham_decompressor*)ptr)->m_pFlush_src + num76, num77, isVolatile: false);
						((lzham_lzham_decompressor*)ptr)->m_decomp_adler32 = adler32.Invoke(adler32: ((lzham_lzham_decompressor*)ptr)->m_decomp_adler32, pBuf: (byte*)((lzham_lzham_decompressor*)ptr)->m_pFlush_src + num76, buflen: num77);
					}
				}
				long num78 = decode_get_bytes_consumed.Invoke(&((lzham_lzham_decompressor*)ptr)->m_codec);
				*(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size = num78;
				long flush_n15 = ((lzham_lzham_decompressor*)ptr)->m_flush_n;
				*(long*)((lzham_lzham_decompressor*)ptr)->m_pOut_buf_size = flush_n15;
				((lzham_lzham_decompressor*)ptr)->m_state = 559;
				return InstructionHelper.Select(((lzham_lzham_decompressor*)ptr)->m_flush_n != 0L, 0, 1);
			}
			num18 = ((lzham_lzham_decompressor*)ptr)->m_num_raw_bytes_remaining;
			num3 = ((lzham_lzham_decompressor*)ptr)->m_match_hist0;
			num4 = ((lzham_lzham_decompressor*)ptr)->m_match_hist1;
			num5 = ((lzham_lzham_decompressor*)ptr)->m_match_hist2;
			num6 = ((lzham_lzham_decompressor*)ptr)->m_match_hist3;
			num7 = ((lzham_lzham_decompressor*)ptr)->m_cur_state;
			_ = ((lzham_lzham_decompressor*)ptr)->m_dst_ofs;
			num9 = ((lzham_symbol_codec*)codec)->m_arith_value;
			num10 = ((lzham_symbol_codec*)codec)->m_arith_length;
			num11 = ((lzham_symbol_codec*)codec)->m_bit_buf;
			num12 = ((lzham_symbol_codec*)codec)->m_bit_count;
			ptr3 = ((lzham_symbol_codec*)codec)->m_pDecode_buf_next;
			num8 = 0;
			goto IL_34fb;
		}
		IL_93a4:
		num12 += 8;
		unchecked
		{
			num11 |= (long)((ulong)(uint)num43 << (int)(uint)checked(64 - num12));
			goto IL_90f6;
		}
		IL_7a03:
		num64 = 0;
		unchecked
		{
			if (ptr3 < ((lzham_symbol_codec*)codec)->m_pDecode_buf_end)
			{
				void* ptr28 = ptr3;
				ptr3 = (byte*)ptr28 + 1;
				num64 = (byte)(*(sbyte*)ptr28);
			}
			goto IL_7a4b;
		}
		IL_1999:
		num12 += 8;
		int num79;
		unchecked
		{
			num11 |= (long)((ulong)(uint)num79 << (int)(uint)checked(64 - num12));
			goto IL_1737;
		}
		IL_095e:
		unchecked
		{
			long num80 = decode_get_bytes_consumed.Invoke(&((lzham_lzham_decompressor*)ptr)->m_codec);
			*(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size = num80;
			*(long*)((lzham_lzham_decompressor*)ptr)->m_pOut_buf_size = 0L;
			((lzham_lzham_decompressor*)ptr)->m_state = 370;
			return 2;
		}
		IL_56fb:
		int num81 = 0;
		unchecked
		{
			if (ptr3 < ((lzham_symbol_codec*)codec)->m_pDecode_buf_end)
			{
				void* ptr29 = ptr3;
				ptr3 = (byte*)ptr29 + 1;
				num81 = (byte)(*(sbyte*)ptr29);
			}
			goto IL_5743;
		}
		IL_a68b:
		unchecked
		{
			((lzham_lzham_decompressor*)ptr)->m_block_index++;
			if (((lzham_lzham_decompressor*)ptr)->m_status == 0)
			{
				goto IL_1161;
			}
			if (num8 == 0)
			{
				goto IL_aab8;
			}
			((lzham_symbol_codec*)codec)->m_arith_value = num9;
			((lzham_symbol_codec*)codec)->m_arith_length = num10;
			((lzham_symbol_codec*)codec)->m_bit_buf = num11;
			((lzham_symbol_codec*)codec)->m_bit_count = num12;
			((lzham_symbol_codec*)codec)->m_pDecode_buf_next = ptr3;
			((lzham_lzham_decompressor*)ptr)->m_match_hist0 = num3;
			((lzham_lzham_decompressor*)ptr)->m_match_hist1 = num4;
			((lzham_lzham_decompressor*)ptr)->m_match_hist2 = num5;
			((lzham_lzham_decompressor*)ptr)->m_match_hist3 = num6;
			((lzham_lzham_decompressor*)ptr)->m_cur_state = num7;
			((lzham_lzham_decompressor*)ptr)->m_dst_ofs = num8;
			((lzham_lzham_decompressor*)ptr)->m_pFlush_src = (byte*)((lzham_lzham_decompressor*)ptr)->m_pDecomp_buf + (uint)((lzham_lzham_decompressor*)ptr)->m_seed_bytes_to_ignore_when_flushing + (uint)((lzham_lzham_decompressor*)ptr)->m_dst_highwater_ofs;
			((lzham_lzham_decompressor*)ptr)->m_flush_num_bytes_remaining = (uint)(num8 - ((lzham_lzham_decompressor*)ptr)->m_seed_bytes_to_ignore_when_flushing - ((lzham_lzham_decompressor*)ptr)->m_dst_highwater_ofs);
			((lzham_lzham_decompressor*)ptr)->m_seed_bytes_to_ignore_when_flushing = 0;
			((lzham_lzham_decompressor*)ptr)->m_dst_highwater_ofs = num8 & num2;
			goto IL_a7f4;
		}
		IL_9d7d:
		unchecked((lzham_lzham_decompressor*)ptr)->m_state = 976;
		return 7;
		IL_2ccc:
		unchecked
		{
			if (num12 < (num12 & 7))
			{
				if (ptr3 == ((lzham_symbol_codec*)codec)->m_pDecode_buf_end)
				{
					if ((((lzham_symbol_codec*)codec)->m_decode_buf_eof & 1) != 1)
					{
						((lzham_symbol_codec*)codec)->m_arith_value = num9;
						((lzham_symbol_codec*)codec)->m_arith_length = num10;
						((lzham_symbol_codec*)codec)->m_bit_buf = num11;
						((lzham_symbol_codec*)codec)->m_bit_count = num12;
						((lzham_symbol_codec*)codec)->m_pDecode_buf_next = ptr3;
						((lzham_lzham_decompressor*)ptr)->m_num_raw_bytes_remaining = num18;
						((lzham_lzham_decompressor*)ptr)->m_match_hist0 = num3;
						((lzham_lzham_decompressor*)ptr)->m_match_hist1 = num4;
						((lzham_lzham_decompressor*)ptr)->m_match_hist2 = num5;
						((lzham_lzham_decompressor*)ptr)->m_match_hist3 = num6;
						((lzham_lzham_decompressor*)ptr)->m_cur_state = num7;
						((lzham_lzham_decompressor*)ptr)->m_dst_ofs = num8;
						goto IL_2dce;
					}
					goto IL_2f00;
				}
				void* ptr30 = ptr3;
				ptr3 = (byte*)ptr30 + 1;
				num25 = (byte)(*(sbyte*)ptr30);
				goto IL_2f48;
			}
			if ((num12 & 7) != 0)
			{
				_ = num11 >>> (int)(uint)checked(64 - (num12 & 7));
			}
			num11 <<= (int)(uint)(num12 & 7);
		}
		num12 -= num12 & 7;
		goto IL_2fcd;
		IL_0d72:
		int num82 = 0;
		unchecked
		{
			if (ptr3 < ((lzham_symbol_codec*)codec)->m_pDecode_buf_end)
			{
				void* ptr31 = ptr3;
				ptr3 = (byte*)ptr31 + 1;
				num82 = (byte)(*(sbyte*)ptr31);
			}
			goto IL_0dae;
		}
		IL_aadc:
		int num83;
		unchecked
		{
			if (num12 < (num12 & 7))
			{
				if (ptr3 == ((lzham_symbol_codec*)codec)->m_pDecode_buf_end)
				{
					if ((((lzham_symbol_codec*)codec)->m_decode_buf_eof & 1) != 1)
					{
						((lzham_symbol_codec*)codec)->m_arith_value = num9;
						((lzham_symbol_codec*)codec)->m_arith_length = num10;
						((lzham_symbol_codec*)codec)->m_bit_buf = num11;
						((lzham_symbol_codec*)codec)->m_bit_count = num12;
						((lzham_symbol_codec*)codec)->m_pDecode_buf_next = ptr3;
						((lzham_lzham_decompressor*)ptr)->m_match_hist0 = num3;
						((lzham_lzham_decompressor*)ptr)->m_match_hist1 = num4;
						((lzham_lzham_decompressor*)ptr)->m_match_hist2 = num5;
						((lzham_lzham_decompressor*)ptr)->m_match_hist3 = num6;
						((lzham_lzham_decompressor*)ptr)->m_cur_state = num7;
						((lzham_lzham_decompressor*)ptr)->m_dst_ofs = num8;
						goto IL_abcd;
					}
					goto IL_acf6;
				}
				void* ptr32 = ptr3;
				ptr3 = (byte*)ptr32 + 1;
				num83 = (byte)(*(sbyte*)ptr32);
				goto IL_ad3e;
			}
			if ((num12 & 7) != 0)
			{
				_ = num11 >>> (int)(uint)checked(64 - (num12 & 7));
			}
			num11 <<= (int)(uint)(num12 & 7);
		}
		num12 -= num12 & 7;
		goto IL_adc3;
		IL_0dae:
		num12 += 8;
		unchecked
		{
			num11 |= (long)((ulong)(uint)num82 << (int)(uint)checked(64 - num12));
			goto IL_0b97;
		}
		IL_0b97:
		unchecked
		{
			if (num12 < 8)
			{
				if (ptr3 == ((lzham_symbol_codec*)codec)->m_pDecode_buf_end)
				{
					if ((((lzham_symbol_codec*)codec)->m_decode_buf_eof & 1) != 1)
					{
						((lzham_symbol_codec*)codec)->m_arith_value = num9;
						((lzham_symbol_codec*)codec)->m_arith_length = num10;
						((lzham_symbol_codec*)codec)->m_bit_buf = num11;
						((lzham_symbol_codec*)codec)->m_bit_count = num12;
						((lzham_symbol_codec*)codec)->m_pDecode_buf_next = ptr3;
						((lzham_lzham_decompressor*)ptr)->m_match_hist0 = num3;
						((lzham_lzham_decompressor*)ptr)->m_match_hist1 = num4;
						((lzham_lzham_decompressor*)ptr)->m_match_hist2 = num5;
						((lzham_lzham_decompressor*)ptr)->m_match_hist3 = num6;
						((lzham_lzham_decompressor*)ptr)->m_cur_state = num7;
						((lzham_lzham_decompressor*)ptr)->m_dst_ofs = num8;
						goto IL_0c59;
					}
					goto IL_0d72;
				}
				void* ptr33 = ptr3;
				ptr3 = (byte*)ptr33 + 1;
				num82 = (byte)(*(sbyte*)ptr33);
				goto IL_0dae;
			}
			int num84 = (int)(num11 >>> 56);
			num11 <<= 8;
			num12 = checked(num12 - 8);
			((lzham_lzham_decompressor*)ptr)->m_z_dict_adler32 = (((lzham_lzham_decompressor*)ptr)->m_z_dict_adler32 << 8) | num84;
			((lzham_lzham_decompressor*)ptr)->m_tmp++;
			goto IL_0b84;
		}
		IL_1c36:
		num60 = 0;
		unchecked
		{
			if (ptr3 < ((lzham_symbol_codec*)codec)->m_pDecode_buf_end)
			{
				void* ptr34 = ptr3;
				ptr3 = (byte*)ptr34 + 1;
				num60 = (byte)(*(sbyte*)ptr34);
			}
			goto IL_1c7e;
		}
		IL_4bbe:
		if (num12 >= 24)
		{
			goto IL_4ec1;
		}
		unchecked
		{
			if ((((lzham_symbol_codec*)codec)->m_decode_buf_eof & 1) != 1)
			{
				((lzham_symbol_codec*)codec)->m_pSaved_huff_model = ptr9;
				((lzham_symbol_codec*)codec)->m_arith_value = num9;
				((lzham_symbol_codec*)codec)->m_arith_length = num10;
				((lzham_symbol_codec*)codec)->m_bit_buf = num11;
				((lzham_symbol_codec*)codec)->m_bit_count = num12;
				((lzham_symbol_codec*)codec)->m_pDecode_buf_next = ptr3;
				((lzham_lzham_decompressor*)ptr)->m_rep_lit0 = num17;
				((lzham_lzham_decompressor*)ptr)->m_match_hist0 = num3;
				((lzham_lzham_decompressor*)ptr)->m_match_hist1 = num4;
				((lzham_lzham_decompressor*)ptr)->m_match_hist2 = num5;
				((lzham_lzham_decompressor*)ptr)->m_match_hist3 = num6;
				((lzham_lzham_decompressor*)ptr)->m_cur_state = num7;
				((lzham_lzham_decompressor*)ptr)->m_dst_ofs = num8;
				goto IL_4cbd;
			}
			goto IL_4e01;
		}
		IL_ad3e:
		num12 += 8;
		unchecked
		{
			num11 |= (long)((ulong)(uint)num83 << (int)(uint)checked(64 - num12));
			goto IL_aadc;
		}
		IL_acf6:
		num83 = 0;
		unchecked
		{
			if (ptr3 < ((lzham_symbol_codec*)codec)->m_pDecode_buf_end)
			{
				void* ptr35 = ptr3;
				ptr3 = (byte*)ptr35 + 1;
				num83 = (byte)(*(sbyte*)ptr35);
			}
			goto IL_ad3e;
		}
		IL_aab8:
		if (unchecked((lzham_lzham_decompressor*)ptr)->m_status != 3)
		{
			goto IL_b3a3;
		}
		if ((num12 & 7) == 0)
		{
			goto IL_adc3;
		}
		goto IL_aadc;
		IL_0b84:
		unchecked
		{
			if ((uint)((lzham_lzham_decompressor*)ptr)->m_tmp < 4u)
			{
				goto IL_0b97;
			}
			if (adler32.Invoke(buflen: (uint)((lzham_lzham_decompressor*)ptr)->m_params.m_num_seed_bytes, pBuf: ((lzham_lzham_decompressor*)ptr)->m_params.m_pSeed_bytes, adler32: 1) == ((lzham_lzham_decompressor*)ptr)->m_z_dict_adler32)
			{
				goto IL_0e6c;
			}
			return 13;
		}
		IL_9218:
		unchecked
		{
			long num85 = decode_get_bytes_consumed.Invoke(&((lzham_lzham_decompressor*)ptr)->m_codec);
			*(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size = num85;
			*(long*)((lzham_lzham_decompressor*)ptr)->m_pOut_buf_size = 0L;
			((lzham_lzham_decompressor*)ptr)->m_state = 929;
			return 2;
		}
		IL_5743:
		num12 += 8;
		unchecked
		{
			num11 |= (long)((ulong)(uint)num81 << (int)(uint)checked(64 - num12));
			goto IL_54ca;
		}
		IL_0e6c:
		unchecked
		{
			int num86 = ((lzham_lzham_decompressor*)ptr)->m_params.m_table_max_update_interval;
			int num87 = ((lzham_lzham_decompressor*)ptr)->m_params.m_table_update_interval_slow_rate;
			if (num86 == 0 && num87 == 0)
			{
				int num88 = ((lzham_lzham_decompressor*)ptr)->m_params.m_table_update_rate;
				if (num88 == 0)
				{
					num88 = 8;
				}
				num88 = clamp.Invoke(num88, 1, 20) - 1;
				num86 = (ushort)((lzham_table_update_settings*)g_table_update_settings.Pointer)[(uint)num88].m_max_update_interval;
				num87 = (ushort)((lzham_table_update_settings*)g_table_update_settings.Pointer)[(uint)num88].m_slow_rate;
			}
			bool flag = init2.Invoke(&((lzham_lzham_decompressor*)ptr)->m_lit_table, encoding: false, 256, num86, num87, null);
			if (ExceptionInfo.Current != null)
			{
				return 0;
			}
			int num89;
			if (((flag ? 1u : 0u) & 1u) != 1)
			{
				num89 = 0;
			}
			else
			{
				bool flag2 = assign_7mvy2m.Invoke(&((lzham_lzham_decompressor*)ptr)->m_delta_lit_table, &((lzham_lzham_decompressor*)ptr)->m_lit_table);
				if (ExceptionInfo.Current != null)
				{
					return 0;
				}
				num89 = (flag2 ? 1 : 0);
			}
			int num90;
			if (((byte)num89 & 1) != 1)
			{
				num90 = 0;
			}
			else
			{
				bool flag3 = init2.Invoke(&((lzham_lzham_decompressor*)ptr)->m_main_table, encoding: false, 2 + (((lzham_lzham_decompressor*)ptr)->m_lzBase.m_match_hist - 1) * 8, num86, num87, null);
				if (ExceptionInfo.Current != null)
				{
					return 0;
				}
				num90 = (flag3 ? 1 : 0);
			}
			int num91;
			if (((byte)num90 & 1) != 1)
			{
				num91 = 0;
			}
			else
			{
				bool flag4 = init2.Invoke(&((lzham_lzham_decompressor*)ptr)->m_rep_len_table, encoding: false, 257, num86, num87, null);
				if (ExceptionInfo.Current != null)
				{
					return 0;
				}
				num91 = (flag4 ? 1 : 0);
			}
			int num92;
			if (((byte)num91 & 1) != 1)
			{
				num92 = 0;
			}
			else
			{
				bool flag5 = assign_7mvy2m.Invoke((byte*)(&((lzham_lzham_decompressor*)ptr)->m_rep_len_table) + sizeof(lzham_quasi_adaptive_huffman_data_model), &((lzham_lzham_decompressor*)ptr)->m_rep_len_table);
				if (ExceptionInfo.Current != null)
				{
					return 0;
				}
				num92 = (flag5 ? 1 : 0);
			}
			int num93;
			if (((byte)num92 & 1) != 1)
			{
				num93 = 0;
			}
			else
			{
				bool flag6 = init2.Invoke(&((lzham_lzham_decompressor*)ptr)->m_large_len_table, encoding: false, 250, num86, num87, null);
				if (ExceptionInfo.Current != null)
				{
					return 0;
				}
				num93 = (flag6 ? 1 : 0);
			}
			int num94;
			if (((byte)num93 & 1) != 1)
			{
				num94 = 0;
			}
			else
			{
				bool flag7 = assign_7mvy2m.Invoke((byte*)(&((lzham_lzham_decompressor*)ptr)->m_large_len_table) + sizeof(lzham_quasi_adaptive_huffman_data_model), &((lzham_lzham_decompressor*)ptr)->m_large_len_table);
				if (ExceptionInfo.Current != null)
				{
					return 0;
				}
				num94 = (flag7 ? 1 : 0);
			}
			int num95;
			if (((byte)num94 & 1) != 1)
			{
				num95 = 0;
			}
			else
			{
				bool flag8 = init2.Invoke(&((lzham_lzham_decompressor*)ptr)->m_dist_lsb_table, encoding: false, 16, num86, num87, null);
				if (ExceptionInfo.Current != null)
				{
					return 0;
				}
				num95 = (flag8 ? 1 : 0);
			}
			if (((byte)num95 & 1) != 1)
			{
				return 4;
			}
			goto IL_1161;
		}
		IL_5b37:
		num12 += 8;
		unchecked
		{
			num11 |= (long)((ulong)(uint)num41 << (int)(uint)checked(64 - num12));
			goto IL_58be;
		}
		IL_b2e2:
		num12 += 8;
		unchecked
		{
			num11 |= (long)((ulong)(uint)num63 << (int)(uint)checked(64 - num12));
			goto IL_b082;
		}
		IL_935c:
		num43 = 0;
		unchecked
		{
			if (ptr3 < ((lzham_symbol_codec*)codec)->m_pDecode_buf_end)
			{
				void* ptr36 = ptr3;
				ptr3 = (byte*)ptr36 + 1;
				num43 = (byte)(*(sbyte*)ptr36);
			}
			goto IL_93a4;
		}
		IL_5c8f:
		void* ptr37;
		int num100;
		unchecked
		{
			if ((uint)num10 < 16777216u)
			{
				((lzham_symbol_codec*)codec)->m_pSaved_model = ptr37;
				goto IL_5cb2;
			}
			int num96 = (ushort)((lzham_adaptive_bit_model*)ptr37)->m_bit_0_prob * (num10 >>> 11);
			int num97 = (((uint)num9 >= (uint)num96) ? 1 : 0);
			if (num97 == 0)
			{
				int num98 = 2048 - (ushort)((lzham_adaptive_bit_model*)ptr37)->m_bit_0_prob >>> 5;
				short* bit_0_prob3 = &((lzham_adaptive_bit_model*)ptr37)->m_bit_0_prob;
				*bit_0_prob3 = (short)((ushort)(*bit_0_prob3) + num98);
				num10 = num96;
			}
			else
			{
				int num99 = (ushort)((lzham_adaptive_bit_model*)ptr37)->m_bit_0_prob >> 5;
				short* bit_0_prob4 = &((lzham_adaptive_bit_model*)ptr37)->m_bit_0_prob;
				*bit_0_prob4 = (short)checked(unchecked((ushort)(*bit_0_prob4)) - num99);
				num9 -= num96;
				num10 -= num96;
			}
			if (num97 != 0)
			{
				num7 = InstructionHelper.Select((uint)num7 < 7u, 9, 11);
				goto IL_9cd5;
			}
			ptr8 = (byte*)(&((lzham_lzham_decompressor*)ptr)->m_rep_len_table) + (((uint)num7 >= 7u) ? ((nint)1) : ((nint)0)) * (nint)sizeof(lzham_quasi_adaptive_huffman_data_model);
			pDecode_tables5 = ((lzham_raw_quasi_adaptive_huffman_data_model*)((byte*)(&((lzham_lzham_decompressor*)ptr)->m_rep_len_table) + (((uint)num7 >= 7u) ? ((nint)1) : ((nint)0)) * (nint)sizeof(lzham_quasi_adaptive_huffman_data_model)))->m_pDecode_tables;
			if (num12 < 24)
			{
				ptr3 = (byte*)ptr3 + 4;
				if (ptr3 >= ((lzham_symbol_codec*)codec)->m_pDecode_buf_end)
				{
					ptr3 = (byte*)ptr3 + -4;
					goto IL_60f9;
				}
				num100 = ((byte)((sbyte*)ptr3)[-4] << 24) | (((byte*)ptr3 + -4)[1] << 16) | (((byte*)ptr3 + -4)[2] << 8) | ((byte*)ptr3 + -4)[3];
				num12 = checked(num12 + 32);
				num11 |= (long)((ulong)(uint)num100 << (int)(uint)checked(64 - num12));
			}
			goto IL_63fc;
		}
		IL_b082:
		unchecked
		{
			if (num12 < 16)
			{
				if (ptr3 == ((lzham_symbol_codec*)codec)->m_pDecode_buf_end)
				{
					if ((((lzham_symbol_codec*)codec)->m_decode_buf_eof & 1) != 1)
					{
						((lzham_symbol_codec*)codec)->m_arith_value = num9;
						((lzham_symbol_codec*)codec)->m_arith_length = num10;
						((lzham_symbol_codec*)codec)->m_bit_buf = num11;
						((lzham_symbol_codec*)codec)->m_bit_count = num12;
						((lzham_symbol_codec*)codec)->m_pDecode_buf_next = ptr3;
						((lzham_lzham_decompressor*)ptr)->m_match_hist0 = num3;
						((lzham_lzham_decompressor*)ptr)->m_match_hist1 = num4;
						((lzham_lzham_decompressor*)ptr)->m_match_hist2 = num5;
						((lzham_lzham_decompressor*)ptr)->m_match_hist3 = num6;
						((lzham_lzham_decompressor*)ptr)->m_cur_state = num7;
						((lzham_lzham_decompressor*)ptr)->m_dst_ofs = num8;
						goto IL_b171;
					}
					goto IL_b29a;
				}
				void* ptr38 = ptr3;
				ptr3 = (byte*)ptr38 + 1;
				num63 = (byte)(*(sbyte*)ptr38);
				goto IL_b2e2;
			}
			int num101 = (int)(num11 >>> 48);
			num11 <<= 16;
			num12 = checked(num12 - 16);
			((lzham_lzham_decompressor*)ptr)->m_file_src_file_adler32 = (((lzham_lzham_decompressor*)ptr)->m_file_src_file_adler32 << 16) | num101;
			if ((((lzham_lzham_decompressor*)ptr)->m_params.m_decompress_flags & 2) != 0)
			{
				if (((lzham_lzham_decompressor*)ptr)->m_file_src_file_adler32 != ((lzham_lzham_decompressor*)ptr)->m_decomp_adler32)
				{
					((lzham_lzham_decompressor*)ptr)->m_status = 8;
				}
			}
			else
			{
				((lzham_lzham_decompressor*)ptr)->m_decomp_adler32 = ((lzham_lzham_decompressor*)ptr)->m_file_src_file_adler32;
			}
			goto IL_b3a3;
		}
		IL_3512:
		unchecked
		{
			((lzham_symbol_codec*)codec)->m_arith_value = num9;
			((lzham_symbol_codec*)codec)->m_arith_length = num10;
			((lzham_symbol_codec*)codec)->m_bit_buf = num11;
			((lzham_symbol_codec*)codec)->m_bit_count = num12;
			((lzham_symbol_codec*)codec)->m_pDecode_buf_next = ptr3;
			goto IL_3569;
		}
		IL_3590:
		unchecked
		{
			if ((((num20 != 0L) ? 1u : 0u) ^ 0xFFFFFFFFu) != 0)
			{
				*(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size = num19;
				*(long*)((lzham_lzham_decompressor*)ptr)->m_pOut_buf_size = 0L;
				if ((((lzham_lzham_decompressor*)ptr)->m_no_more_input_bytes_flag & 1) == 1)
				{
					goto IL_35e0;
				}
				((lzham_lzham_decompressor*)ptr)->m_num_raw_bytes_remaining = num18;
				((lzham_lzham_decompressor*)ptr)->m_match_hist0 = num3;
				((lzham_lzham_decompressor*)ptr)->m_match_hist1 = num4;
				((lzham_lzham_decompressor*)ptr)->m_match_hist2 = num5;
				((lzham_lzham_decompressor*)ptr)->m_match_hist3 = num6;
				((lzham_lzham_decompressor*)ptr)->m_cur_state = num7;
				((lzham_lzham_decompressor*)ptr)->m_dst_ofs = num8;
				((lzham_lzham_decompressor*)ptr)->m_state = 588;
				return 2;
			}
			int num102 = (int)(((ulong)(uint)num18 >= (ulong)num20) ? num20 : ((uint)num18));
			num102 = (((uint)num102 >= (uint)(num - num8)) ? (num - num8) : num102);
			long num46;
			if (false && (ulong)(uint)(num8 + num102) > (ulong)num46)
			{
				long num103;
				*(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size = num103;
				*(long*)((lzham_lzham_decompressor*)ptr)->m_pOut_buf_size = 0L;
				goto IL_378b;
			}
			llvm_memcpy_p0_p0_i64.Invoke((byte*)pDecomp_buf + (uint)num8, (byte*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf + num19, (uint)num102, isVolatile: false);
			num19 += (uint)num102;
			num18 -= num102;
			decode_set_input_buffer.Invoke(codec, eof_flag: (((lzham_lzham_decompressor*)ptr)->m_no_more_input_bytes_flag & 1) == 1, pBuf_next: (byte*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf + num19, buf_size: *(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size, pBuf: ((lzham_lzham_decompressor*)ptr)->m_pIn_buf);
			num8 += num102;
			if ((uint)num8 <= (uint)num2)
			{
				goto IL_3569;
			}
			((lzham_lzham_decompressor*)ptr)->m_num_raw_bytes_remaining = num18;
			((lzham_lzham_decompressor*)ptr)->m_match_hist0 = num3;
			((lzham_lzham_decompressor*)ptr)->m_match_hist1 = num4;
			((lzham_lzham_decompressor*)ptr)->m_match_hist2 = num5;
			((lzham_lzham_decompressor*)ptr)->m_match_hist3 = num6;
			((lzham_lzham_decompressor*)ptr)->m_cur_state = num7;
			((lzham_lzham_decompressor*)ptr)->m_dst_ofs = num8;
			((lzham_lzham_decompressor*)ptr)->m_pFlush_src = (byte*)((lzham_lzham_decompressor*)ptr)->m_pDecomp_buf + (uint)((lzham_lzham_decompressor*)ptr)->m_seed_bytes_to_ignore_when_flushing + (uint)((lzham_lzham_decompressor*)ptr)->m_dst_highwater_ofs;
			((lzham_lzham_decompressor*)ptr)->m_flush_num_bytes_remaining = (uint)(num - ((lzham_lzham_decompressor*)ptr)->m_seed_bytes_to_ignore_when_flushing - ((lzham_lzham_decompressor*)ptr)->m_dst_highwater_ofs);
			((lzham_lzham_decompressor*)ptr)->m_seed_bytes_to_ignore_when_flushing = 0;
			((lzham_lzham_decompressor*)ptr)->m_dst_highwater_ofs = num & num2;
			goto IL_3924;
		}
		IL_35e0:
		unchecked((lzham_lzham_decompressor*)ptr)->m_state = 584;
		return 6;
		IL_87c6:
		int num104 = 0;
		unchecked
		{
			if (ptr3 < ((lzham_symbol_codec*)codec)->m_pDecode_buf_end)
			{
				void* ptr39 = ptr3;
				ptr3 = (byte*)ptr39 + 1;
				num104 = (byte)(*(sbyte*)ptr39);
			}
			num12 = checked(num12 + 8);
			num11 |= (long)((ulong)(uint)num104 << (int)(uint)checked(64 - num12));
			goto IL_8569;
		}
		IL_a259:
		num13 = unchecked(num13 + -1);
		if (num13 == 0)
		{
			goto IL_41ee;
		}
		goto IL_9dca;
		IL_3569:
		unchecked
		{
			if (num18 != 0)
			{
				num19 = decode_get_bytes_consumed.Invoke(codec);
				num20 = *(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size - num19;
				goto IL_3590;
			}
			num9 = ((lzham_symbol_codec*)codec)->m_arith_value;
			num10 = ((lzham_symbol_codec*)codec)->m_arith_length;
			num11 = ((lzham_symbol_codec*)codec)->m_bit_buf;
			num12 = ((lzham_symbol_codec*)codec)->m_bit_count;
			ptr3 = ((lzham_symbol_codec*)codec)->m_pDecode_buf_next;
			goto IL_a68b;
		}
		IL_8121:
		unchecked
		{
			long num105 = decode_get_bytes_consumed.Invoke(&((lzham_lzham_decompressor*)ptr)->m_codec);
			*(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size = num105;
			*(long*)((lzham_lzham_decompressor*)ptr)->m_pOut_buf_size = 0L;
			((lzham_lzham_decompressor*)ptr)->m_state = 864;
			return 2;
		}
		IL_aeb2:
		unchecked
		{
			long num106 = decode_get_bytes_consumed.Invoke(&((lzham_lzham_decompressor*)ptr)->m_codec);
			*(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size = num106;
			*(long*)((lzham_lzham_decompressor*)ptr)->m_pOut_buf_size = 0L;
			((lzham_lzham_decompressor*)ptr)->m_state = 1082;
			return 2;
		}
		IL_6819:
		num12 += 8;
		int num107;
		unchecked
		{
			num11 |= (long)((ulong)(uint)num107 << (int)(uint)checked(64 - num12));
			goto IL_65a0;
		}
		IL_8679:
		unchecked
		{
			long num108 = decode_get_bytes_consumed.Invoke(&((lzham_lzham_decompressor*)ptr)->m_codec);
			*(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size = num108;
			*(long*)((lzham_lzham_decompressor*)ptr)->m_pOut_buf_size = 0L;
			((lzham_lzham_decompressor*)ptr)->m_state = 898;
			return 2;
		}
		IL_8f99:
		num23 = 0;
		unchecked
		{
			if (ptr3 < ((lzham_symbol_codec*)codec)->m_pDecode_buf_end)
			{
				void* ptr40 = ptr3;
				ptr3 = (byte*)ptr40 + 1;
				num23 = (byte)(*(sbyte*)ptr40);
			}
			goto IL_8fe1;
		}
		IL_a46d:
		unchecked
		{
			long num109 = decode_get_bytes_consumed.Invoke(&((lzham_lzham_decompressor*)ptr)->m_codec);
			*(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size = num109;
			*(long*)((lzham_lzham_decompressor*)ptr)->m_pOut_buf_size = 0L;
			((lzham_lzham_decompressor*)ptr)->m_state = 1054;
			return 2;
		}
		IL_67d1:
		num107 = 0;
		unchecked
		{
			if (ptr3 < ((lzham_symbol_codec*)codec)->m_pDecode_buf_end)
			{
				void* ptr41 = ptr3;
				ptr3 = (byte*)ptr41 + 1;
				num107 = (byte)(*(sbyte*)ptr41);
			}
			goto IL_6819;
		}
		IL_669f:
		unchecked
		{
			long num110 = decode_get_bytes_consumed.Invoke(&((lzham_lzham_decompressor*)ptr)->m_codec);
			*(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size = num110;
			*(long*)((lzham_lzham_decompressor*)ptr)->m_pOut_buf_size = 0L;
			((lzham_lzham_decompressor*)ptr)->m_state = 796;
			return 2;
		}
		IL_8265:
		int num111 = 0;
		unchecked
		{
			if (ptr3 < ((lzham_symbol_codec*)codec)->m_pDecode_buf_end)
			{
				void* ptr42 = ptr3;
				ptr3 = (byte*)ptr42 + 1;
				num111 = (byte)(*(sbyte*)ptr42);
			}
			num12 = checked(num12 + 8);
			num11 |= (long)((ulong)(uint)num111 << (int)(uint)checked(64 - num12));
			goto IL_8022;
		}
		IL_688c:
		int num112;
		int num113;
		unchecked
		{
			if (num12 < (byte)((sbyte*)s_huge_match_code_len.Pointer)[(uint)num13])
			{
				if (ptr3 == ((lzham_symbol_codec*)codec)->m_pDecode_buf_end)
				{
					if ((((lzham_symbol_codec*)codec)->m_decode_buf_eof & 1) != 1)
					{
						((lzham_symbol_codec*)codec)->m_arith_value = num9;
						((lzham_symbol_codec*)codec)->m_arith_length = num10;
						((lzham_symbol_codec*)codec)->m_bit_buf = num11;
						((lzham_symbol_codec*)codec)->m_bit_count = num12;
						((lzham_symbol_codec*)codec)->m_pDecode_buf_next = ptr3;
						((lzham_lzham_decompressor*)ptr)->m_match_len = num13;
						((lzham_lzham_decompressor*)ptr)->m_match_hist0 = num3;
						((lzham_lzham_decompressor*)ptr)->m_match_hist1 = num4;
						((lzham_lzham_decompressor*)ptr)->m_match_hist2 = num5;
						((lzham_lzham_decompressor*)ptr)->m_match_hist3 = num6;
						((lzham_lzham_decompressor*)ptr)->m_cur_state = num7;
						((lzham_lzham_decompressor*)ptr)->m_dst_ofs = num8;
						goto IL_69a0;
					}
					goto IL_6ad2;
				}
				void* ptr43 = ptr3;
				ptr3 = (byte*)ptr43 + 1;
				num112 = (byte)(*(sbyte*)ptr43);
				goto IL_6b1a;
			}
			num113 = (int)(((bool*)s_huge_match_code_len.Pointer)[(uint)num13] ? (num11 >>> (int)(uint)checked(64 - unchecked((byte)((sbyte*)s_huge_match_code_len.Pointer)[(uint)num13]))) : 0);
			num11 <<= (int)(byte)((sbyte*)s_huge_match_code_len.Pointer)[(uint)num13];
		}
		num12 -= unchecked((byte)((sbyte*)s_huge_match_code_len.Pointer)[(uint)num13]);
		num13 = unchecked(((int*)s_huge_match_base_len.Pointer)[(uint)num13] + num113);
		goto IL_6bff;
		IL_8fe1:
		num12 += 8;
		unchecked
		{
			num11 |= (long)((ulong)(uint)num23 << (int)(uint)checked(64 - num12));
			goto IL_8d39;
		}
		IL_6ad2:
		num112 = 0;
		unchecked
		{
			if (ptr3 < ((lzham_symbol_codec*)codec)->m_pDecode_buf_end)
			{
				void* ptr44 = ptr3;
				ptr3 = (byte*)ptr44 + 1;
				num112 = (byte)(*(sbyte*)ptr44);
			}
			goto IL_6b1a;
		}
		IL_3924:
		unchecked
		{
			if (((lzham_lzham_decompressor*)ptr)->m_flush_num_bytes_remaining != 0L)
			{
				((lzham_lzham_decompressor*)ptr)->m_flush_n = (((ulong)((lzham_lzham_decompressor*)ptr)->m_flush_num_bytes_remaining >= (ulong)(*(long*)((lzham_lzham_decompressor*)ptr)->m_pOut_buf_size)) ? (*(long*)((lzham_lzham_decompressor*)ptr)->m_pOut_buf_size) : ((lzham_lzham_decompressor*)ptr)->m_flush_num_bytes_remaining);
				if (0 == (((lzham_lzham_decompressor*)ptr)->m_params.m_decompress_flags & 2))
				{
					llvm_memcpy_p0_p0_i64.Invoke(((lzham_lzham_decompressor*)ptr)->m_pOut_buf, ((lzham_lzham_decompressor*)ptr)->m_pFlush_src, ((lzham_lzham_decompressor*)ptr)->m_flush_n, isVolatile: false);
				}
				else
				{
					long num115;
					for (long num114 = 0L; (ulong)num114 < (ulong)((lzham_lzham_decompressor*)ptr)->m_flush_n; num114 += num115)
					{
						num115 = (((ulong)(((lzham_lzham_decompressor*)ptr)->m_flush_n - num114) >= 8192uL) ? 8192L : (((lzham_lzham_decompressor*)ptr)->m_flush_n - num114));
						llvm_memcpy_p0_p0_i64.Invoke((byte*)((lzham_lzham_decompressor*)ptr)->m_pOut_buf + num114, (byte*)((lzham_lzham_decompressor*)ptr)->m_pFlush_src + num114, num115, isVolatile: false);
						((lzham_lzham_decompressor*)ptr)->m_decomp_adler32 = adler32.Invoke(adler32: ((lzham_lzham_decompressor*)ptr)->m_decomp_adler32, pBuf: (byte*)((lzham_lzham_decompressor*)ptr)->m_pFlush_src + num114, buflen: num115);
					}
				}
				long num116 = decode_get_bytes_consumed.Invoke(&((lzham_lzham_decompressor*)ptr)->m_codec);
				*(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size = num116;
				long flush_n16 = ((lzham_lzham_decompressor*)ptr)->m_flush_n;
				*(long*)((lzham_lzham_decompressor*)ptr)->m_pOut_buf_size = flush_n16;
				((lzham_lzham_decompressor*)ptr)->m_state = 625;
				return InstructionHelper.Select(((lzham_lzham_decompressor*)ptr)->m_flush_n != 0L, 0, 1);
			}
			num18 = ((lzham_lzham_decompressor*)ptr)->m_num_raw_bytes_remaining;
			num3 = ((lzham_lzham_decompressor*)ptr)->m_match_hist0;
			num4 = ((lzham_lzham_decompressor*)ptr)->m_match_hist1;
			num5 = ((lzham_lzham_decompressor*)ptr)->m_match_hist2;
			num6 = ((lzham_lzham_decompressor*)ptr)->m_match_hist3;
			num7 = ((lzham_lzham_decompressor*)ptr)->m_cur_state;
			_ = ((lzham_lzham_decompressor*)ptr)->m_dst_ofs;
			num8 = 0;
			goto IL_3569;
		}
		IL_8e5e:
		unchecked
		{
			long num117 = decode_get_bytes_consumed.Invoke(&((lzham_lzham_decompressor*)ptr)->m_codec);
			*(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size = num117;
			*(long*)((lzham_lzham_decompressor*)ptr)->m_pOut_buf_size = 0L;
			((lzham_lzham_decompressor*)ptr)->m_state = 912;
			return 2;
		}
		IL_378b:
		unchecked((lzham_lzham_decompressor*)ptr)->m_state = 608;
		return 5;
		IL_6bff:
		num7 = InstructionHelper.Select(unchecked((uint)num7) < 7u, 8, 11);
		goto IL_9cd5;
		IL_420a:
		void* ptr45;
		void* ptr46;
		int num124;
		int num123;
		unchecked
		{
			if ((uint)num10 < 16777216u)
			{
				((lzham_symbol_codec*)codec)->m_pSaved_model = ptr45;
				goto IL_422d;
			}
			int num118 = (ushort)((lzham_adaptive_bit_model*)ptr45)->m_bit_0_prob * (num10 >>> 11);
			int num119 = (((uint)num9 >= (uint)num118) ? 1 : 0);
			if (num119 == 0)
			{
				int num120 = 2048 - (ushort)((lzham_adaptive_bit_model*)ptr45)->m_bit_0_prob >>> 5;
				short* bit_0_prob5 = &((lzham_adaptive_bit_model*)ptr45)->m_bit_0_prob;
				*bit_0_prob5 = (short)((ushort)(*bit_0_prob5) + num120);
				num10 = num118;
			}
			else
			{
				int num121 = (ushort)((lzham_adaptive_bit_model*)ptr45)->m_bit_0_prob >> 5;
				short* bit_0_prob6 = &((lzham_adaptive_bit_model*)ptr45)->m_bit_0_prob;
				*bit_0_prob6 = (short)checked(unchecked((ushort)(*bit_0_prob6)) - num121);
				num9 -= num118;
				num10 -= num118;
			}
			if (num119 == 0)
			{
				long num46;
				if (false && (ulong)(uint)num8 >= (ulong)num46)
				{
					int arith_value2;
					((lzham_symbol_codec*)codec)->m_arith_value = arith_value2;
					int arith_length2;
					((lzham_symbol_codec*)codec)->m_arith_length = arith_length2;
					long bit_buf2;
					((lzham_symbol_codec*)codec)->m_bit_buf = bit_buf2;
					int bit_count2;
					((lzham_symbol_codec*)codec)->m_bit_count = bit_count2;
					void* pDecode_buf_next2;
					((lzham_symbol_codec*)codec)->m_pDecode_buf_next = pDecode_buf_next2;
					decode_get_bytes_consumed.Invoke(codec);
					long num122;
					*(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size = num122;
					*(long*)((lzham_lzham_decompressor*)ptr)->m_pOut_buf_size = 0L;
					goto IL_4667;
				}
				if ((uint)num7 < 7u)
				{
					ptr10 = &((lzham_lzham_decompressor*)ptr)->m_lit_table;
					pDecode_tables7 = ((lzham_raw_quasi_adaptive_huffman_data_model*)(&((lzham_lzham_decompressor*)ptr)->m_lit_table))->m_pDecode_tables;
					if (num12 < 24)
					{
						ptr3 = (byte*)ptr3 + 4;
						if (ptr3 >= ((lzham_symbol_codec*)codec)->m_pDecode_buf_end)
						{
							ptr3 = (byte*)ptr3 + -4;
							goto IL_46d4;
						}
						num123 = ((byte)((sbyte*)ptr3)[-4] << 24) | (((byte*)ptr3 + -4)[1] << 16) | (((byte*)ptr3 + -4)[2] << 8) | ((byte*)ptr3 + -4)[3];
						num12 = checked(num12 + 32);
						num11 |= (long)((ulong)(uint)num123 << (int)(uint)checked(64 - num12));
					}
					goto IL_49bd;
				}
				num17 = (byte)((sbyte*)pDecomp_buf)[(uint)((num8 - num3) & num2)];
				ptr9 = &((lzham_lzham_decompressor*)ptr)->m_delta_lit_table;
				pDecode_tables6 = ((lzham_raw_quasi_adaptive_huffman_data_model*)(&((lzham_lzham_decompressor*)ptr)->m_delta_lit_table))->m_pDecode_tables;
				if (num12 < 24)
				{
					ptr3 = (byte*)ptr3 + 4;
					if (ptr3 >= ((lzham_symbol_codec*)codec)->m_pDecode_buf_end)
					{
						ptr3 = (byte*)ptr3 + -4;
						goto IL_4bbe;
					}
					num124 = ((byte)((sbyte*)ptr3)[-4] << 24) | (((byte*)ptr3 + -4)[1] << 16) | (((byte*)ptr3 + -4)[2] << 8) | ((byte*)ptr3 + -4)[3];
					num12 = checked(num12 + 32);
					num11 |= (long)((ulong)(uint)num124 << (int)(uint)checked(64 - num12));
				}
				goto IL_4ec1;
			}
			num13 = 1;
			ptr46 = (byte*)(&((lzham_lzham_decompressor*)ptr)->m_is_rep_model) + (nint)(uint)num7 * (nint)sizeof(lzham_adaptive_bit_model);
			goto IL_54a7;
		}
		IL_76b2:
		num12 += 8;
		int num125;
		unchecked
		{
			num11 |= (long)((ulong)(uint)num125 << (int)(uint)checked(64 - num12));
			goto IL_7424;
		}
		IL_416d:
		num12 += 8;
		int num126;
		unchecked
		{
			num11 |= (long)((ulong)(uint)num126 << (int)(uint)checked(64 - num12));
			goto IL_3f0e;
		}
		IL_422d:
		unchecked
		{
			if (num12 < 8)
			{
				if (ptr3 == ((lzham_symbol_codec*)codec)->m_pDecode_buf_end)
				{
					if ((((lzham_symbol_codec*)codec)->m_decode_buf_eof & 1) != 1)
					{
						((lzham_symbol_codec*)codec)->m_arith_value = num9;
						((lzham_symbol_codec*)codec)->m_arith_length = num10;
						((lzham_symbol_codec*)codec)->m_bit_buf = num11;
						((lzham_symbol_codec*)codec)->m_bit_count = num12;
						((lzham_symbol_codec*)codec)->m_pDecode_buf_next = ptr3;
						((lzham_lzham_decompressor*)ptr)->m_match_hist0 = num3;
						((lzham_lzham_decompressor*)ptr)->m_match_hist1 = num4;
						((lzham_lzham_decompressor*)ptr)->m_match_hist2 = num5;
						((lzham_lzham_decompressor*)ptr)->m_match_hist3 = num6;
						((lzham_lzham_decompressor*)ptr)->m_cur_state = num7;
						((lzham_lzham_decompressor*)ptr)->m_dst_ofs = num8;
						goto IL_431b;
					}
					goto IL_4444;
				}
				void* ptr47 = ptr3;
				ptr3 = (byte*)ptr47 + 1;
				num39 = (byte)(*(sbyte*)ptr47);
				goto IL_448c;
			}
			int num127 = (int)(num11 >>> 56);
			num11 <<= 8;
			num12 = checked(num12 - 8);
			ptr45 = ((lzham_symbol_codec*)codec)->m_pSaved_model;
			num9 = (num9 << 8) | num127;
			num10 <<= 8;
			goto IL_420a;
		}
		IL_abcd:
		unchecked
		{
			long num128 = decode_get_bytes_consumed.Invoke(&((lzham_lzham_decompressor*)ptr)->m_codec);
			*(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size = num128;
			*(long*)((lzham_lzham_decompressor*)ptr)->m_pOut_buf_size = 0L;
			((lzham_lzham_decompressor*)ptr)->m_state = 1080;
			return 2;
		}
		IL_5f2b:
		num12 += 8;
		unchecked
		{
			num11 |= (long)((ulong)(uint)num37 << (int)(uint)checked(64 - num12));
			goto IL_5cb2;
		}
		IL_766a:
		num125 = 0;
		unchecked
		{
			if (ptr3 < ((lzham_symbol_codec*)codec)->m_pDecode_buf_end)
			{
				void* ptr48 = ptr3;
				ptr3 = (byte*)ptr48 + 1;
				num125 = (byte)(*(sbyte*)ptr48);
			}
			goto IL_76b2;
		}
		IL_589b:
		void* ptr49;
		int num133;
		unchecked
		{
			if ((uint)num10 < 16777216u)
			{
				((lzham_symbol_codec*)codec)->m_pSaved_model = ptr49;
				goto IL_58be;
			}
			int num129 = (ushort)((lzham_adaptive_bit_model*)ptr49)->m_bit_0_prob * (num10 >>> 11);
			int num130 = (((uint)num9 >= (uint)num129) ? 1 : 0);
			if (num130 == 0)
			{
				int num131 = 2048 - (ushort)((lzham_adaptive_bit_model*)ptr49)->m_bit_0_prob >>> 5;
				short* bit_0_prob7 = &((lzham_adaptive_bit_model*)ptr49)->m_bit_0_prob;
				*bit_0_prob7 = (short)((ushort)(*bit_0_prob7) + num131);
				num10 = num129;
			}
			else
			{
				int num132 = (ushort)((lzham_adaptive_bit_model*)ptr49)->m_bit_0_prob >> 5;
				short* bit_0_prob8 = &((lzham_adaptive_bit_model*)ptr49)->m_bit_0_prob;
				*bit_0_prob8 = (short)checked(unchecked((ushort)(*bit_0_prob8)) - num132);
				num9 -= num129;
				num10 -= num129;
			}
			if (num130 != 0)
			{
				ptr37 = (byte*)(&((lzham_lzham_decompressor*)ptr)->m_is_rep0_single_byte_model) + (nint)(uint)num7 * (nint)sizeof(lzham_adaptive_bit_model);
				goto IL_5c8f;
			}
			ptr7 = (byte*)(&((lzham_lzham_decompressor*)ptr)->m_rep_len_table) + (((uint)num7 >= 7u) ? ((nint)1) : ((nint)0)) * (nint)sizeof(lzham_quasi_adaptive_huffman_data_model);
			pDecode_tables4 = ((lzham_raw_quasi_adaptive_huffman_data_model*)((byte*)(&((lzham_lzham_decompressor*)ptr)->m_rep_len_table) + (((uint)num7 >= 7u) ? ((nint)1) : ((nint)0)) * (nint)sizeof(lzham_quasi_adaptive_huffman_data_model)))->m_pDecode_tables;
			if (num12 < 24)
			{
				ptr3 = (byte*)ptr3 + 4;
				if (ptr3 >= ((lzham_symbol_codec*)codec)->m_pDecode_buf_end)
				{
					ptr3 = (byte*)ptr3 + -4;
					goto IL_6c91;
				}
				num133 = ((byte)((sbyte*)ptr3)[-4] << 24) | (((byte*)ptr3 + -4)[1] << 16) | (((byte*)ptr3 + -4)[2] << 8) | ((byte*)ptr3 + -4)[3];
				num12 = checked(num12 + 32);
				num11 |= (long)((ulong)(uint)num133 << (int)(uint)checked(64 - num12));
			}
			goto IL_6f94;
		}
		IL_431b:
		unchecked
		{
			long num134 = decode_get_bytes_consumed.Invoke(&((lzham_lzham_decompressor*)ptr)->m_codec);
			*(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size = num134;
			*(long*)((lzham_lzham_decompressor*)ptr)->m_pOut_buf_size = 0L;
			((lzham_lzham_decompressor*)ptr)->m_state = 682;
			return 2;
		}
		IL_8325:
		unchecked
		{
			int num135 = (int)((num11 >>> 48) + 1L);
			int l;
			int num137;
			if ((uint)num135 <= (uint)((lzham_prefix_coding_decoder_tables*)pDecode_tables3)->m_table_max_code)
			{
				int num136 = ((int*)((lzham_prefix_coding_decoder_tables*)pDecode_tables3)->m_lookup)[num11 >>> (int)(uint)(64 - ((lzham_prefix_coding_decoder_tables*)pDecode_tables3)->m_table_bits)];
				num137 = num136 & 0xFFFF;
				l = num136 >>> 16;
			}
			else
			{
				for (l = ((lzham_prefix_coding_decoder_tables*)pDecode_tables3)->m_decode_start_code_size; (uint)num135 > (uint)((int*)(&((lzham_prefix_coding_decoder_tables*)pDecode_tables3)->m_max_codes))[(uint)(l - 1)]; l++)
				{
				}
				int num138;
				checked
				{
					num138 = unchecked(((int*)(&((lzham_prefix_coding_decoder_tables*)pDecode_tables3)->m_val_ptrs))[(uint)(l - 1)]) + unchecked((int)(num11 >>> (int)(uint)(64 - l)));
				}
				if ((uint)num138 >= (uint)((lzham_raw_quasi_adaptive_huffman_data_model*)ptr6)->m_total_syms)
				{
					num138 = 0;
				}
				num137 = (ushort)((short*)((lzham_prefix_coding_decoder_tables*)pDecode_tables3)->m_sorted_symbol_order)[num138];
			}
			num11 <<= (int)(uint)l;
			num12 -= l;
			int num139 = (ushort)(*(short*)vector_unsigned_short_Operator.Invoke(&((lzham_raw_quasi_adaptive_huffman_data_model*)ptr6)->m_sym_freq, num137));
			*(short*)vector_unsigned_short_Operator.Invoke(&((lzham_raw_quasi_adaptive_huffman_data_model*)ptr6)->m_sym_freq, num137) = (short)(num139 + 1);
			if ((((lzham_raw_quasi_adaptive_huffman_data_model*)ptr6)->m_symbols_until_update += -1) == 0)
			{
				update_tables.Invoke(ptr6, -1, sym_freq_all_ones: false);
				if (ExceptionInfo.Current != null)
				{
					return 0;
				}
			}
			num137 -= 2;
			if (num137 < 0)
			{
				if (num137 != -2)
				{
					num3 = 1;
					num4 = 1;
					num5 = 1;
					num6 = 1;
					num7 = 0;
					goto IL_41ee;
				}
				if ((num12 & 7) == 0)
				{
					goto IL_a68b;
				}
				goto IL_a37c;
			}
			num13 = (num137 & 7) + 2;
			num14 = (num137 >>> 3) + 1;
			if (num13 != 9)
			{
				goto IL_90c8;
			}
			ptr5 = (byte*)(&((lzham_lzham_decompressor*)ptr)->m_large_len_table) + (((uint)num7 >= 7u) ? ((nint)1) : ((nint)0)) * (nint)sizeof(lzham_quasi_adaptive_huffman_data_model);
			pDecode_tables2 = ((lzham_raw_quasi_adaptive_huffman_data_model*)((byte*)(&((lzham_lzham_decompressor*)ptr)->m_large_len_table) + (((uint)num7 >= 7u) ? ((nint)1) : ((nint)0)) * (nint)sizeof(lzham_quasi_adaptive_huffman_data_model)))->m_pDecode_tables;
			if (num12 < 24)
			{
				ptr3 = (byte*)ptr3 + 4;
				if (ptr3 >= ((lzham_symbol_codec*)codec)->m_pDecode_buf_end)
				{
					ptr3 = (byte*)ptr3 + -4;
					goto IL_8569;
				}
				num104 = ((byte)((sbyte*)ptr3)[-4] << 24) | (((byte*)ptr3 + -4)[1] << 16) | (((byte*)ptr3 + -4)[2] << 8) | ((byte*)ptr3 + -4)[3];
				num12 = checked(num12 + 32);
				num11 |= (long)((ulong)(uint)num104 << (int)(uint)checked(64 - num12));
			}
			goto IL_8886;
		}
		IL_3d13:
		unchecked
		{
			long num140 = decode_get_bytes_consumed.Invoke(&((lzham_lzham_decompressor*)ptr)->m_codec);
			*(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size = num140;
			*(long*)((lzham_lzham_decompressor*)ptr)->m_pOut_buf_size = 0L;
			((lzham_lzham_decompressor*)ptr)->m_state = 640;
			return 2;
		}
		IL_3e3c:
		num59 = 0;
		unchecked
		{
			if (ptr3 < ((lzham_symbol_codec*)codec)->m_pDecode_buf_end)
			{
				void* ptr50 = ptr3;
				ptr3 = (byte*)ptr50 + 1;
				num59 = (byte)(*(sbyte*)ptr50);
			}
			goto IL_3e84;
		}
		IL_adc3:
		unchecked
		{
			if (num12 < 16)
			{
				if (ptr3 == ((lzham_symbol_codec*)codec)->m_pDecode_buf_end)
				{
					if ((((lzham_symbol_codec*)codec)->m_decode_buf_eof & 1) != 1)
					{
						((lzham_symbol_codec*)codec)->m_arith_value = num9;
						((lzham_symbol_codec*)codec)->m_arith_length = num10;
						((lzham_symbol_codec*)codec)->m_bit_buf = num11;
						((lzham_symbol_codec*)codec)->m_bit_count = num12;
						((lzham_symbol_codec*)codec)->m_pDecode_buf_next = ptr3;
						((lzham_lzham_decompressor*)ptr)->m_match_hist0 = num3;
						((lzham_lzham_decompressor*)ptr)->m_match_hist1 = num4;
						((lzham_lzham_decompressor*)ptr)->m_match_hist2 = num5;
						((lzham_lzham_decompressor*)ptr)->m_match_hist3 = num6;
						((lzham_lzham_decompressor*)ptr)->m_cur_state = num7;
						((lzham_lzham_decompressor*)ptr)->m_dst_ofs = num8;
						goto IL_aeb2;
					}
					goto IL_afdb;
				}
				void* ptr51 = ptr3;
				ptr3 = (byte*)ptr51 + 1;
				num42 = (byte)(*(sbyte*)ptr51);
				goto IL_b023;
			}
			((lzham_lzham_decompressor*)ptr)->m_file_src_file_adler32 = (int)(num11 >>> 48);
			num11 <<= 16;
		}
		num12 -= 16;
		goto IL_b082;
		IL_4667:
		unchecked((lzham_lzham_decompressor*)ptr)->m_state = 705;
		return 5;
		IL_3c17:
		unchecked
		{
			if ((uint)num10 < 4u)
			{
				goto IL_3c25;
			}
			num10 = -1;
			num3 = 1;
			num4 = 1;
			num5 = 1;
			num6 = 1;
			num7 = 0;
			((lzham_lzham_decompressor*)ptr)->m_start_block_dst_ofs = num8;
			goto IL_3f0e;
		}
		IL_34fb:
		num18 = unchecked(num18 + -1);
		if (num18 != 0)
		{
			goto IL_2fcd;
		}
		goto IL_3512;
		IL_0c59:
		unchecked
		{
			long num141 = decode_get_bytes_consumed.Invoke(&((lzham_lzham_decompressor*)ptr)->m_codec);
			*(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size = num141;
			*(long*)((lzham_lzham_decompressor*)ptr)->m_pOut_buf_size = 0L;
			((lzham_lzham_decompressor*)ptr)->m_state = 381;
			return 2;
		}
		IL_7fb4:
		num7 = InstructionHelper.Select(unchecked((uint)num7) < 7u, 8, 11);
		goto IL_9cd5;
		IL_3ffc:
		unchecked
		{
			long num142 = decode_get_bytes_consumed.Invoke(&((lzham_lzham_decompressor*)ptr)->m_codec);
			*(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size = num142;
			*(long*)((lzham_lzham_decompressor*)ptr)->m_pOut_buf_size = 0L;
			((lzham_lzham_decompressor*)ptr)->m_state = 651;
			return 2;
		}
		IL_6d90:
		unchecked
		{
			long num143 = decode_get_bytes_consumed.Invoke(&((lzham_lzham_decompressor*)ptr)->m_codec);
			*(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size = num143;
			*(long*)((lzham_lzham_decompressor*)ptr)->m_pOut_buf_size = 0L;
			((lzham_lzham_decompressor*)ptr)->m_state = 810;
			return 2;
		}
		IL_2c9b:
		unchecked((lzham_lzham_decompressor*)ptr)->m_state = 530;
		return 9;
		IL_222a:
		unchecked
		{
			if (((lzham_lzham_decompressor*)ptr)->m_flush_num_bytes_remaining != 0L)
			{
				((lzham_lzham_decompressor*)ptr)->m_flush_n = (((ulong)((lzham_lzham_decompressor*)ptr)->m_flush_num_bytes_remaining >= (ulong)(*(long*)((lzham_lzham_decompressor*)ptr)->m_pOut_buf_size)) ? (*(long*)((lzham_lzham_decompressor*)ptr)->m_pOut_buf_size) : ((lzham_lzham_decompressor*)ptr)->m_flush_num_bytes_remaining);
				if (0 == (((lzham_lzham_decompressor*)ptr)->m_params.m_decompress_flags & 2))
				{
					llvm_memcpy_p0_p0_i64.Invoke(((lzham_lzham_decompressor*)ptr)->m_pOut_buf, ((lzham_lzham_decompressor*)ptr)->m_pFlush_src, ((lzham_lzham_decompressor*)ptr)->m_flush_n, isVolatile: false);
				}
				else
				{
					long num145;
					for (long num144 = 0L; (ulong)num144 < (ulong)((lzham_lzham_decompressor*)ptr)->m_flush_n; num144 += num145)
					{
						num145 = (((ulong)(((lzham_lzham_decompressor*)ptr)->m_flush_n - num144) >= 8192uL) ? 8192L : (((lzham_lzham_decompressor*)ptr)->m_flush_n - num144));
						llvm_memcpy_p0_p0_i64.Invoke((byte*)((lzham_lzham_decompressor*)ptr)->m_pOut_buf + num144, (byte*)((lzham_lzham_decompressor*)ptr)->m_pFlush_src + num144, num145, isVolatile: false);
						((lzham_lzham_decompressor*)ptr)->m_decomp_adler32 = adler32.Invoke(adler32: ((lzham_lzham_decompressor*)ptr)->m_decomp_adler32, pBuf: (byte*)((lzham_lzham_decompressor*)ptr)->m_pFlush_src + num144, buflen: num145);
					}
				}
				long num146 = decode_get_bytes_consumed.Invoke(&((lzham_lzham_decompressor*)ptr)->m_codec);
				*(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size = num146;
				long flush_n17 = ((lzham_lzham_decompressor*)ptr)->m_flush_n;
				*(long*)((lzham_lzham_decompressor*)ptr)->m_pOut_buf_size = flush_n17;
				((lzham_lzham_decompressor*)ptr)->m_state = 473;
				return InstructionHelper.Select(((lzham_lzham_decompressor*)ptr)->m_flush_n != 0L, 0, 1);
			}
			num3 = ((lzham_lzham_decompressor*)ptr)->m_match_hist0;
			num4 = ((lzham_lzham_decompressor*)ptr)->m_match_hist1;
			num5 = ((lzham_lzham_decompressor*)ptr)->m_match_hist2;
			num6 = ((lzham_lzham_decompressor*)ptr)->m_match_hist3;
			num7 = ((lzham_lzham_decompressor*)ptr)->m_cur_state;
			num8 = ((lzham_lzham_decompressor*)ptr)->m_dst_ofs;
			goto IL_2603;
		}
		IL_98d9:
		unchecked
		{
			long num147 = decode_get_bytes_consumed.Invoke(&((lzham_lzham_decompressor*)ptr)->m_codec);
			*(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size = num147;
			*(long*)((lzham_lzham_decompressor*)ptr)->m_pOut_buf_size = 0L;
			((lzham_lzham_decompressor*)ptr)->m_state = 945;
			return 2;
		}
		IL_9c87:
		num6 = num5;
		num5 = num4;
		num4 = num3;
		unchecked
		{
			_ = &((lzham_lzham_decompressor*)ptr)->m_lzBase;
			num3 = ((int*)m_lzx_position_base.Pointer)[(uint)num14] + num15;
			num7 = InstructionHelper.Select((uint)num7 < 7u, 7, 10);
			goto IL_9cd5;
		}
		IL_7bd4:
		int num148;
		unchecked
		{
			if (num12 < 8)
			{
				if (ptr3 == ((lzham_symbol_codec*)codec)->m_pDecode_buf_end)
				{
					if ((((lzham_symbol_codec*)codec)->m_decode_buf_eof & 1) != 1)
					{
						((lzham_symbol_codec*)codec)->m_arith_value = num9;
						((lzham_symbol_codec*)codec)->m_arith_length = num10;
						((lzham_symbol_codec*)codec)->m_bit_buf = num11;
						((lzham_symbol_codec*)codec)->m_bit_count = num12;
						((lzham_symbol_codec*)codec)->m_pDecode_buf_next = ptr3;
						((lzham_lzham_decompressor*)ptr)->m_match_len = num13;
						((lzham_lzham_decompressor*)ptr)->m_match_hist0 = num3;
						((lzham_lzham_decompressor*)ptr)->m_match_hist1 = num4;
						((lzham_lzham_decompressor*)ptr)->m_match_hist2 = num5;
						((lzham_lzham_decompressor*)ptr)->m_match_hist3 = num6;
						((lzham_lzham_decompressor*)ptr)->m_cur_state = num7;
						((lzham_lzham_decompressor*)ptr)->m_dst_ofs = num8;
						goto IL_7cd3;
					}
					goto IL_7e05;
				}
				void* ptr52 = ptr3;
				ptr3 = (byte*)ptr52 + 1;
				num148 = (byte)(*(sbyte*)ptr52);
				goto IL_7e4d;
			}
			int num149 = (int)(num11 >>> 56);
			num11 <<= 8;
			num12 = checked(num12 - 8);
			ptr26 = ((lzham_symbol_codec*)codec)->m_pSaved_model;
			num9 = (num9 << 8) | num149;
			num10 <<= 8;
			goto IL_7bb1;
		}
		IL_7237:
		unchecked
		{
			long num150 = decode_get_bytes_consumed.Invoke(&((lzham_lzham_decompressor*)ptr)->m_codec);
			*(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size = num150;
			*(long*)((lzham_lzham_decompressor*)ptr)->m_pOut_buf_size = 0L;
			((lzham_lzham_decompressor*)ptr)->m_state = 819;
			return 2;
		}
		IL_77d2:
		void* ptr54;
		unchecked
		{
			if (num12 < 8)
			{
				if (ptr3 == ((lzham_symbol_codec*)codec)->m_pDecode_buf_end)
				{
					if ((((lzham_symbol_codec*)codec)->m_decode_buf_eof & 1) != 1)
					{
						((lzham_symbol_codec*)codec)->m_arith_value = num9;
						((lzham_symbol_codec*)codec)->m_arith_length = num10;
						((lzham_symbol_codec*)codec)->m_bit_buf = num11;
						((lzham_symbol_codec*)codec)->m_bit_count = num12;
						((lzham_symbol_codec*)codec)->m_pDecode_buf_next = ptr3;
						((lzham_lzham_decompressor*)ptr)->m_match_len = num13;
						((lzham_lzham_decompressor*)ptr)->m_match_hist0 = num3;
						((lzham_lzham_decompressor*)ptr)->m_match_hist1 = num4;
						((lzham_lzham_decompressor*)ptr)->m_match_hist2 = num5;
						((lzham_lzham_decompressor*)ptr)->m_match_hist3 = num6;
						((lzham_lzham_decompressor*)ptr)->m_cur_state = num7;
						((lzham_lzham_decompressor*)ptr)->m_dst_ofs = num8;
						goto IL_78d1;
					}
					goto IL_7a03;
				}
				void* ptr53 = ptr3;
				ptr3 = (byte*)ptr53 + 1;
				num64 = (byte)(*(sbyte*)ptr53);
				goto IL_7a4b;
			}
			int num151 = (int)(num11 >>> 56);
			num11 <<= 8;
			num12 = checked(num12 - 8);
			ptr54 = ((lzham_symbol_codec*)codec)->m_pSaved_model;
			num9 = (num9 << 8) | num151;
			num10 <<= 8;
			goto IL_77af;
		}
		IL_2b92:
		num12 += 8;
		int num152;
		unchecked
		{
			num11 |= (long)((ulong)(uint)num152 << (int)(uint)checked(64 - num12));
			goto IL_2919;
		}
		IL_9cd5:
		unchecked
		{
			long num46;
			if (false && ((ulong)num3 > (ulong)(uint)num8 || (ulong)(uint)(num8 + num13) > (ulong)num46))
			{
				int arith_value3;
				((lzham_symbol_codec*)codec)->m_arith_value = arith_value3;
				int arith_length3;
				((lzham_symbol_codec*)codec)->m_arith_length = arith_length3;
				long bit_buf3;
				((lzham_symbol_codec*)codec)->m_bit_buf = bit_buf3;
				int bit_count3;
				((lzham_symbol_codec*)codec)->m_bit_count = bit_count3;
				void* pDecode_buf_next3;
				((lzham_symbol_codec*)codec)->m_pDecode_buf_next = pDecode_buf_next3;
				decode_get_bytes_consumed.Invoke(codec);
				long num153;
				*(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size = num153;
				*(long*)((lzham_lzham_decompressor*)ptr)->m_pOut_buf_size = 0L;
				goto IL_9d7d;
			}
			num38 = (num8 - num3) & num2;
			ptr15 = (byte*)pDecomp_buf + (uint)num38;
			if ((uint)((((uint)num38 >= (uint)num8) ? num38 : num8) + num13) > (uint)num2)
			{
				goto IL_9dca;
			}
			void* ptr55 = (byte*)pDecomp_buf + (uint)num8;
			if (num3 == 1)
			{
				sbyte b2 = *(sbyte*)ptr15;
				if ((uint)num13 < 8u)
				{
					for (int m = num13; m > 0; m = checked(m + -1))
					{
						sbyte b3 = b2;
						void* ptr56 = ptr55;
						ptr55 = (byte*)ptr56 + 1;
						*(sbyte*)ptr56 = b3;
					}
				}
				else
				{
					llvm_memset_p0_i64.Invoke(ptr55, (sbyte)(byte)b2, (uint)num13, isVolatile: false);
				}
			}
			else if ((uint)num13 < 8u || num13 > num3)
			{
				for (int n = num13; n > 0; n = checked(n + -1))
				{
					void* ptr57 = ptr15;
					ptr15 = (byte*)ptr57 + 1;
					sbyte b4 = *(sbyte*)ptr57;
					void* ptr58 = ptr55;
					ptr55 = (byte*)ptr58 + 1;
					*(sbyte*)ptr58 = b4;
				}
			}
			else
			{
				llvm_memcpy_p0_p0_i64.Invoke(ptr55, ptr15, (uint)num13, isVolatile: false);
			}
			num8 += num13;
			goto IL_41ee;
		}
		IL_4cbd:
		unchecked
		{
			long num154 = decode_get_bytes_consumed.Invoke(&((lzham_lzham_decompressor*)ptr)->m_codec);
			*(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size = num154;
			*(long*)((lzham_lzham_decompressor*)ptr)->m_pOut_buf_size = 0L;
			((lzham_lzham_decompressor*)ptr)->m_state = 737;
			return 2;
		}
		IL_1378:
		int num155 = 0;
		unchecked
		{
			if (ptr3 < ((lzham_symbol_codec*)codec)->m_pDecode_buf_end)
			{
				void* ptr59 = ptr3;
				ptr3 = (byte*)ptr59 + 1;
				num155 = (byte)(*(sbyte*)ptr59);
			}
			goto IL_13c0;
		}
		IL_2a18:
		unchecked
		{
			long num156 = decode_get_bytes_consumed.Invoke(&((lzham_lzham_decompressor*)ptr)->m_codec);
			*(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size = num156;
			*(long*)((lzham_lzham_decompressor*)ptr)->m_pOut_buf_size = 0L;
			((lzham_lzham_decompressor*)ptr)->m_state = 520;
			return 2;
		}
		IL_b023:
		num12 += 8;
		unchecked
		{
			num11 |= (long)((ulong)(uint)num42 << (int)(uint)checked(64 - num12));
			goto IL_adc3;
		}
		IL_1161:
		unchecked
		{
			if (num12 < 2)
			{
				if (ptr3 == ((lzham_symbol_codec*)codec)->m_pDecode_buf_end)
				{
					if ((((lzham_symbol_codec*)codec)->m_decode_buf_eof & 1) != 1)
					{
						((lzham_symbol_codec*)codec)->m_arith_value = num9;
						((lzham_symbol_codec*)codec)->m_arith_length = num10;
						((lzham_symbol_codec*)codec)->m_bit_buf = num11;
						((lzham_symbol_codec*)codec)->m_bit_count = num12;
						((lzham_symbol_codec*)codec)->m_pDecode_buf_next = ptr3;
						((lzham_lzham_decompressor*)ptr)->m_match_hist0 = num3;
						((lzham_lzham_decompressor*)ptr)->m_match_hist1 = num4;
						((lzham_lzham_decompressor*)ptr)->m_match_hist2 = num5;
						((lzham_lzham_decompressor*)ptr)->m_match_hist3 = num6;
						((lzham_lzham_decompressor*)ptr)->m_cur_state = num7;
						((lzham_lzham_decompressor*)ptr)->m_dst_ofs = num8;
						goto IL_124f;
					}
					goto IL_1378;
				}
				void* ptr60 = ptr3;
				ptr3 = (byte*)ptr60 + 1;
				num155 = (byte)(*(sbyte*)ptr60);
				goto IL_13c0;
			}
			((lzham_lzham_decompressor*)ptr)->m_block_type = (int)(num11 >>> 62);
			num11 <<= 2;
			num12 = checked(num12 - 2);
			if (((lzham_lzham_decompressor*)ptr)->m_block_type == 0)
			{
				goto IL_142f;
			}
			if (((lzham_lzham_decompressor*)ptr)->m_block_type == 2)
			{
				num18 = 0;
				goto IL_264d;
			}
			if (((lzham_lzham_decompressor*)ptr)->m_block_type == 1)
			{
				num9 = 0;
				num10 = 0;
				goto IL_3c17;
			}
			if (((lzham_lzham_decompressor*)ptr)->m_block_type == 3)
			{
				((lzham_lzham_decompressor*)ptr)->m_status = 3;
			}
			else
			{
				((lzham_lzham_decompressor*)ptr)->m_status = 7;
			}
			goto IL_a68b;
		}
		IL_976e:
		int num157;
		unchecked
		{
			ptr4 = &((lzham_lzham_decompressor*)ptr)->m_dist_lsb_table;
			pDecode_tables = ((lzham_raw_quasi_adaptive_huffman_data_model*)(&((lzham_lzham_decompressor*)ptr)->m_dist_lsb_table))->m_pDecode_tables;
			if (num12 < 24)
			{
				ptr3 = (byte*)ptr3 + 4;
				if (ptr3 >= ((lzham_symbol_codec*)codec)->m_pDecode_buf_end)
				{
					ptr3 = (byte*)ptr3 + -4;
					goto IL_97b8;
				}
				num157 = ((byte)((sbyte*)ptr3)[-4] << 24) | (((byte*)ptr3 + -4)[1] << 16) | (((byte*)ptr3 + -4)[2] << 8) | ((byte*)ptr3 + -4)[3];
				num12 = checked(num12 + 32);
				num11 |= (long)((ulong)(uint)num157 << (int)(uint)checked(64 - num12));
			}
			goto IL_9aef;
		}
		IL_4125:
		num126 = 0;
		unchecked
		{
			if (ptr3 < ((lzham_symbol_codec*)codec)->m_pDecode_buf_end)
			{
				void* ptr61 = ptr3;
				ptr3 = (byte*)ptr61 + 1;
				num126 = (byte)(*(sbyte*)ptr61);
			}
			goto IL_416d;
		}
		IL_46d4:
		if (num12 >= 24)
		{
			goto IL_49bd;
		}
		unchecked
		{
			if ((((lzham_symbol_codec*)codec)->m_decode_buf_eof & 1) != 1)
			{
				((lzham_symbol_codec*)codec)->m_pSaved_huff_model = ptr10;
				((lzham_symbol_codec*)codec)->m_arith_value = num9;
				((lzham_symbol_codec*)codec)->m_arith_length = num10;
				((lzham_symbol_codec*)codec)->m_bit_buf = num11;
				((lzham_symbol_codec*)codec)->m_bit_count = num12;
				((lzham_symbol_codec*)codec)->m_pDecode_buf_next = ptr3;
				((lzham_lzham_decompressor*)ptr)->m_match_hist0 = num3;
				((lzham_lzham_decompressor*)ptr)->m_match_hist1 = num4;
				((lzham_lzham_decompressor*)ptr)->m_match_hist2 = num5;
				((lzham_lzham_decompressor*)ptr)->m_match_hist3 = num6;
				((lzham_lzham_decompressor*)ptr)->m_cur_state = num7;
				((lzham_lzham_decompressor*)ptr)->m_dst_ofs = num8;
				goto IL_47c2;
			}
			goto IL_48fd;
		}
		IL_2b4a:
		num152 = 0;
		unchecked
		{
			if (ptr3 < ((lzham_symbol_codec*)codec)->m_pDecode_buf_end)
			{
				void* ptr62 = ptr3;
				ptr3 = (byte*)ptr62 + 1;
				num152 = (byte)(*(sbyte*)ptr62);
			}
			goto IL_2b92;
		}
		IL_20bc:
		unchecked((lzham_lzham_decompressor*)ptr)->m_state = 462;
		return 14;
		IL_3f0e:
		int num158;
		unchecked
		{
			if (num12 < 2)
			{
				if (ptr3 == ((lzham_symbol_codec*)codec)->m_pDecode_buf_end)
				{
					if ((((lzham_symbol_codec*)codec)->m_decode_buf_eof & 1) != 1)
					{
						((lzham_symbol_codec*)codec)->m_arith_value = num9;
						((lzham_symbol_codec*)codec)->m_arith_length = num10;
						((lzham_symbol_codec*)codec)->m_bit_buf = num11;
						((lzham_symbol_codec*)codec)->m_bit_count = num12;
						((lzham_symbol_codec*)codec)->m_pDecode_buf_next = ptr3;
						((lzham_lzham_decompressor*)ptr)->m_match_hist0 = num3;
						((lzham_lzham_decompressor*)ptr)->m_match_hist1 = num4;
						((lzham_lzham_decompressor*)ptr)->m_match_hist2 = num5;
						((lzham_lzham_decompressor*)ptr)->m_match_hist3 = num6;
						((lzham_lzham_decompressor*)ptr)->m_cur_state = num7;
						((lzham_lzham_decompressor*)ptr)->m_dst_ofs = num8;
						goto IL_3ffc;
					}
					goto IL_4125;
				}
				void* ptr63 = ptr3;
				ptr3 = (byte*)ptr63 + 1;
				num126 = (byte)(*(sbyte*)ptr63);
				goto IL_416d;
			}
			num158 = (int)(num11 >>> 62);
			num11 <<= 2;
		}
		num12 -= 2;
		switch (num158)
		{
		case 1:
			reset_huffman_table_update_rates.Invoke(ptr);
			break;
		case 2:
			reset_all_tables.Invoke(ptr);
			if (ExceptionInfo.Current != null)
			{
				return 0;
			}
			break;
		}
		goto IL_41ee;
		IL_4e01:
		num124 = 0;
		unchecked
		{
			if (ptr3 < ((lzham_symbol_codec*)codec)->m_pDecode_buf_end)
			{
				void* ptr64 = ptr3;
				ptr3 = (byte*)ptr64 + 1;
				num124 = (byte)(*(sbyte*)ptr64);
			}
			num12 = checked(num12 + 8);
			num11 |= (long)((ulong)(uint)num124 << (int)(uint)checked(64 - num12));
			goto IL_4bbe;
		}
		IL_633c:
		num100 = 0;
		unchecked
		{
			if (ptr3 < ((lzham_symbol_codec*)codec)->m_pDecode_buf_end)
			{
				void* ptr65 = ptr3;
				ptr3 = (byte*)ptr65 + 1;
				num100 = (byte)(*(sbyte*)ptr65);
			}
			num12 = checked(num12 + 8);
			num11 |= (long)((ulong)(uint)num100 << (int)(uint)checked(64 - num12));
			goto IL_60f9;
		}
		IL_9434:
		int num159;
		unchecked
		{
			if (num12 < num16 - 4)
			{
				if (ptr3 == ((lzham_symbol_codec*)codec)->m_pDecode_buf_end)
				{
					if ((((lzham_symbol_codec*)codec)->m_decode_buf_eof & 1) != 1)
					{
						((lzham_symbol_codec*)codec)->m_arith_value = num9;
						((lzham_symbol_codec*)codec)->m_arith_length = num10;
						((lzham_symbol_codec*)codec)->m_bit_buf = num11;
						((lzham_symbol_codec*)codec)->m_bit_count = num12;
						((lzham_symbol_codec*)codec)->m_pDecode_buf_next = ptr3;
						((lzham_lzham_decompressor*)ptr)->m_match_len = num13;
						((lzham_lzham_decompressor*)ptr)->m_match_slot = num14;
						((lzham_lzham_decompressor*)ptr)->m_num_extra_bits = num16;
						((lzham_lzham_decompressor*)ptr)->m_match_hist0 = num3;
						((lzham_lzham_decompressor*)ptr)->m_match_hist1 = num4;
						((lzham_lzham_decompressor*)ptr)->m_match_hist2 = num5;
						((lzham_lzham_decompressor*)ptr)->m_match_hist3 = num6;
						((lzham_lzham_decompressor*)ptr)->m_cur_state = num7;
						((lzham_lzham_decompressor*)ptr)->m_dst_ofs = num8;
						goto IL_9558;
					}
					goto IL_969c;
				}
				void* ptr66 = ptr3;
				ptr3 = (byte*)ptr66 + 1;
				num159 = (byte)(*(sbyte*)ptr66);
				goto IL_96e4;
			}
			num15 = (int)((num16 - 4 != 0) ? (num11 >>> (int)(uint)(64 - (num16 - 4))) : 0);
			num11 <<= (int)(uint)(num16 - 4);
			num12 -= num16 - 4;
			num15 <<= 4;
			goto IL_976e;
		}
		IL_1951:
		num79 = 0;
		unchecked
		{
			if (ptr3 < ((lzham_symbol_codec*)codec)->m_pDecode_buf_end)
			{
				void* ptr67 = ptr3;
				ptr3 = (byte*)ptr67 + 1;
				num79 = (byte)(*(sbyte*)ptr67);
			}
			goto IL_1999;
		}
		IL_59bd:
		unchecked
		{
			long num160 = decode_get_bytes_consumed.Invoke(&((lzham_lzham_decompressor*)ptr)->m_codec);
			*(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size = num160;
			*(long*)((lzham_lzham_decompressor*)ptr)->m_pOut_buf_size = 0L;
			((lzham_lzham_decompressor*)ptr)->m_state = 777;
			return 2;
		}
		IL_7e4d:
		num12 += 8;
		unchecked
		{
			num11 |= (long)((ulong)(uint)num148 << (int)(uint)checked(64 - num12));
			goto IL_7bd4;
		}
		IL_6f94:
		unchecked
		{
			int num161 = (int)((num11 >>> 48) + 1L);
			int num163;
			if ((uint)num161 <= (uint)((lzham_prefix_coding_decoder_tables*)pDecode_tables4)->m_table_max_code)
			{
				int num162 = ((int*)((lzham_prefix_coding_decoder_tables*)pDecode_tables4)->m_lookup)[num11 >>> (int)(uint)(64 - ((lzham_prefix_coding_decoder_tables*)pDecode_tables4)->m_table_bits)];
				num13 = num162 & 0xFFFF;
				num163 = num162 >>> 16;
			}
			else
			{
				for (num163 = ((lzham_prefix_coding_decoder_tables*)pDecode_tables4)->m_decode_start_code_size; (uint)num161 > (uint)((int*)(&((lzham_prefix_coding_decoder_tables*)pDecode_tables4)->m_max_codes))[(uint)(num163 - 1)]; num163++)
				{
				}
				int num164;
				checked
				{
					num164 = unchecked(((int*)(&((lzham_prefix_coding_decoder_tables*)pDecode_tables4)->m_val_ptrs))[(uint)(num163 - 1)]) + unchecked((int)(num11 >>> (int)(uint)(64 - num163)));
				}
				if ((uint)num164 >= (uint)((lzham_raw_quasi_adaptive_huffman_data_model*)ptr7)->m_total_syms)
				{
					num164 = 0;
				}
				num13 = (ushort)((short*)((lzham_prefix_coding_decoder_tables*)pDecode_tables4)->m_sorted_symbol_order)[num164];
			}
			num11 <<= (int)(uint)num163;
			num12 -= num163;
			int num165 = (ushort)(*(short*)vector_unsigned_short_Operator.Invoke(&((lzham_raw_quasi_adaptive_huffman_data_model*)ptr7)->m_sym_freq, num13));
			*(short*)vector_unsigned_short_Operator.Invoke(&((lzham_raw_quasi_adaptive_huffman_data_model*)ptr7)->m_sym_freq, num13) = (short)(num165 + 1);
			if ((((lzham_raw_quasi_adaptive_huffman_data_model*)ptr7)->m_symbols_until_update += -1) == 0)
			{
				update_tables.Invoke(ptr7, -1, sym_freq_all_ones: false);
				if (ExceptionInfo.Current != null)
				{
					return 0;
				}
			}
			num13 += 2;
			if (num13 != 258)
			{
				goto IL_7797;
			}
			num13 = 0;
			goto IL_7138;
		}
		IL_1fd8:
		num12 += 8;
		int num166;
		unchecked
		{
			num11 |= (long)((ulong)(uint)num166 << (int)(uint)checked(64 - num12));
			goto IL_1d78;
		}
		IL_3c25:
		unchecked
		{
			if (num12 < 8)
			{
				if (ptr3 == ((lzham_symbol_codec*)codec)->m_pDecode_buf_end)
				{
					if ((((lzham_symbol_codec*)codec)->m_decode_buf_eof & 1) != 1)
					{
						((lzham_symbol_codec*)codec)->m_arith_value = num9;
						((lzham_symbol_codec*)codec)->m_arith_length = num10;
						((lzham_symbol_codec*)codec)->m_bit_buf = num11;
						((lzham_symbol_codec*)codec)->m_bit_count = num12;
						((lzham_symbol_codec*)codec)->m_pDecode_buf_next = ptr3;
						((lzham_lzham_decompressor*)ptr)->m_match_hist0 = num3;
						((lzham_lzham_decompressor*)ptr)->m_match_hist1 = num4;
						((lzham_lzham_decompressor*)ptr)->m_match_hist2 = num5;
						((lzham_lzham_decompressor*)ptr)->m_match_hist3 = num6;
						((lzham_lzham_decompressor*)ptr)->m_cur_state = num7;
						((lzham_lzham_decompressor*)ptr)->m_dst_ofs = num8;
						goto IL_3d13;
					}
					goto IL_3e3c;
				}
				void* ptr68 = ptr3;
				ptr3 = (byte*)ptr68 + 1;
				num59 = (byte)(*(sbyte*)ptr68);
				goto IL_3e84;
			}
			int num167 = (int)(num11 >>> 56);
			num11 <<= 8;
			num12 = checked(num12 - 8);
			num9 = (num9 << 8) | num167;
			num10++;
			goto IL_3c17;
		}
		IL_2919:
		unchecked
		{
			if (num12 < 8)
			{
				if (ptr3 == ((lzham_symbol_codec*)codec)->m_pDecode_buf_end)
				{
					if ((((lzham_symbol_codec*)codec)->m_decode_buf_eof & 1) != 1)
					{
						((lzham_symbol_codec*)codec)->m_arith_value = num9;
						((lzham_symbol_codec*)codec)->m_arith_length = num10;
						((lzham_symbol_codec*)codec)->m_bit_buf = num11;
						((lzham_symbol_codec*)codec)->m_bit_count = num12;
						((lzham_symbol_codec*)codec)->m_pDecode_buf_next = ptr3;
						((lzham_lzham_decompressor*)ptr)->m_num_raw_bytes_remaining = num18;
						((lzham_lzham_decompressor*)ptr)->m_match_hist0 = num3;
						((lzham_lzham_decompressor*)ptr)->m_match_hist1 = num4;
						((lzham_lzham_decompressor*)ptr)->m_match_hist2 = num5;
						((lzham_lzham_decompressor*)ptr)->m_match_hist3 = num6;
						((lzham_lzham_decompressor*)ptr)->m_cur_state = num7;
						((lzham_lzham_decompressor*)ptr)->m_dst_ofs = num8;
						goto IL_2a18;
					}
					goto IL_2b4a;
				}
				void* ptr69 = ptr3;
				ptr3 = (byte*)ptr69 + 1;
				num152 = (byte)(*(sbyte*)ptr69);
				goto IL_2b92;
			}
			int num168 = (int)(num11 >>> 56);
			num11 <<= 8;
			num12 = checked(num12 - 8);
			if (num168 != ((num18 & 0xFF) ^ ((num18 >>> 8) & 0xFF) ^ ((num18 >>> 16) & 0xFF)))
			{
				((lzham_symbol_codec*)codec)->m_arith_value = num9;
				((lzham_symbol_codec*)codec)->m_arith_length = num10;
				((lzham_symbol_codec*)codec)->m_bit_buf = num11;
				((lzham_symbol_codec*)codec)->m_bit_count = num12;
				((lzham_symbol_codec*)codec)->m_pDecode_buf_next = ptr3;
				long num169 = decode_get_bytes_consumed.Invoke(codec);
				*(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size = num169;
				*(long*)((lzham_lzham_decompressor*)ptr)->m_pOut_buf_size = 0L;
				goto IL_2c9b;
			}
			num18++;
			if ((num12 & 7) == 0)
			{
				goto IL_2fcd;
			}
			goto IL_2ccc;
		}
		IL_6ed4:
		num133 = 0;
		unchecked
		{
			if (ptr3 < ((lzham_symbol_codec*)codec)->m_pDecode_buf_end)
			{
				void* ptr70 = ptr3;
				ptr3 = (byte*)ptr70 + 1;
				num133 = (byte)(*(sbyte*)ptr70);
			}
			num12 = checked(num12 + 8);
			num11 |= (long)((ulong)(uint)num133 << (int)(uint)checked(64 - num12));
			goto IL_6c91;
		}
		IL_124f:
		unchecked
		{
			long num170 = decode_get_bytes_consumed.Invoke(&((lzham_lzham_decompressor*)ptr)->m_codec);
			*(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size = num170;
			*(long*)((lzham_lzham_decompressor*)ptr)->m_pOut_buf_size = 0L;
			((lzham_lzham_decompressor*)ptr)->m_state = 431;
			return 2;
		}
		IL_1e67:
		unchecked
		{
			long num171 = decode_get_bytes_consumed.Invoke(&((lzham_lzham_decompressor*)ptr)->m_codec);
			*(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size = num171;
			*(long*)((lzham_lzham_decompressor*)ptr)->m_pOut_buf_size = 0L;
			((lzham_lzham_decompressor*)ptr)->m_state = 456;
			return 2;
		}
		IL_13c0:
		num12 += 8;
		unchecked
		{
			num11 |= (long)((ulong)(uint)num155 << (int)(uint)checked(64 - num12));
			goto IL_1161;
		}
		IL_28c7:
		num12 += 8;
		int num172;
		unchecked
		{
			num11 |= (long)((ulong)(uint)num172 << (int)(uint)checked(64 - num12));
			goto IL_264d;
		}
		IL_77af:
		unchecked
		{
			if ((uint)num10 < 16777216u)
			{
				((lzham_symbol_codec*)codec)->m_pSaved_model = ptr54;
				goto IL_77d2;
			}
			int num173 = (ushort)((lzham_adaptive_bit_model*)ptr54)->m_bit_0_prob * (num10 >>> 11);
			int num174 = (((uint)num9 >= (uint)num173) ? 1 : 0);
			if (num174 == 0)
			{
				int num175 = 2048 - (ushort)((lzham_adaptive_bit_model*)ptr54)->m_bit_0_prob >>> 5;
				short* bit_0_prob9 = &((lzham_adaptive_bit_model*)ptr54)->m_bit_0_prob;
				*bit_0_prob9 = (short)((ushort)(*bit_0_prob9) + num175);
				num10 = num173;
			}
			else
			{
				int num176 = (ushort)((lzham_adaptive_bit_model*)ptr54)->m_bit_0_prob >> 5;
				short* bit_0_prob10 = &((lzham_adaptive_bit_model*)ptr54)->m_bit_0_prob;
				*bit_0_prob10 = (short)checked(unchecked((ushort)(*bit_0_prob10)) - num176);
				num9 -= num173;
				num10 -= num173;
			}
			if (num174 != 0)
			{
				int num177 = num4;
				num4 = num3;
				num3 = num177;
				goto IL_7fb4;
			}
			ptr26 = (byte*)(&((lzham_lzham_decompressor*)ptr)->m_is_rep2_model) + (nint)(uint)num7 * (nint)sizeof(lzham_adaptive_bit_model);
			goto IL_7bb1;
		}
		IL_54a7:
		unchecked
		{
			if ((uint)num10 < 16777216u)
			{
				((lzham_symbol_codec*)codec)->m_pSaved_model = ptr46;
				goto IL_54ca;
			}
			int num178 = (ushort)((lzham_adaptive_bit_model*)ptr46)->m_bit_0_prob * (num10 >>> 11);
			int num179 = (((uint)num9 >= (uint)num178) ? 1 : 0);
			if (num179 == 0)
			{
				int num180 = 2048 - (ushort)((lzham_adaptive_bit_model*)ptr46)->m_bit_0_prob >>> 5;
				short* bit_0_prob11 = &((lzham_adaptive_bit_model*)ptr46)->m_bit_0_prob;
				*bit_0_prob11 = (short)((ushort)(*bit_0_prob11) + num180);
				num10 = num178;
			}
			else
			{
				int num181 = (ushort)((lzham_adaptive_bit_model*)ptr46)->m_bit_0_prob >> 5;
				short* bit_0_prob12 = &((lzham_adaptive_bit_model*)ptr46)->m_bit_0_prob;
				*bit_0_prob12 = (short)checked(unchecked((ushort)(*bit_0_prob12)) - num181);
				num9 -= num178;
				num10 -= num178;
			}
			if (num179 != 0)
			{
				ptr49 = (byte*)(&((lzham_lzham_decompressor*)ptr)->m_is_rep0_model) + (nint)(uint)num7 * (nint)sizeof(lzham_adaptive_bit_model);
				goto IL_589b;
			}
			ptr6 = &((lzham_lzham_decompressor*)ptr)->m_main_table;
			pDecode_tables3 = ((lzham_raw_quasi_adaptive_huffman_data_model*)(&((lzham_lzham_decompressor*)ptr)->m_main_table))->m_pDecode_tables;
			if (num12 < 24)
			{
				ptr3 = (byte*)ptr3 + 4;
				if (ptr3 >= ((lzham_symbol_codec*)codec)->m_pDecode_buf_end)
				{
					ptr3 = (byte*)ptr3 + -4;
					goto IL_8022;
				}
				num111 = ((byte)((sbyte*)ptr3)[-4] << 24) | (((byte*)ptr3 + -4)[1] << 16) | (((byte*)ptr3 + -4)[2] << 8) | ((byte*)ptr3 + -4)[3];
				num12 = checked(num12 + 32);
				num11 |= (long)((ulong)(uint)num111 << (int)(uint)checked(64 - num12));
			}
			goto IL_8325;
		}
		IL_7538:
		unchecked
		{
			long num182 = decode_get_bytes_consumed.Invoke(&((lzham_lzham_decompressor*)ptr)->m_codec);
			*(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size = num182;
			*(long*)((lzham_lzham_decompressor*)ptr)->m_pOut_buf_size = 0L;
			((lzham_lzham_decompressor*)ptr)->m_state = 824;
			return 2;
		}
		IL_1f90:
		num166 = 0;
		unchecked
		{
			if (ptr3 < ((lzham_symbol_codec*)codec)->m_pDecode_buf_end)
			{
				void* ptr71 = ptr3;
				ptr3 = (byte*)ptr71 + 1;
				num166 = (byte)(*(sbyte*)ptr71);
			}
			goto IL_1fd8;
		}
		IL_9558:
		unchecked
		{
			long num183 = decode_get_bytes_consumed.Invoke(&((lzham_lzham_decompressor*)ptr)->m_codec);
			*(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size = num183;
			*(long*)((lzham_lzham_decompressor*)ptr)->m_pOut_buf_size = 0L;
			((lzham_lzham_decompressor*)ptr)->m_state = 936;
			return 2;
		}
		IL_142f:
		int num184;
		unchecked
		{
			if (num12 < 2)
			{
				if (ptr3 == ((lzham_symbol_codec*)codec)->m_pDecode_buf_end)
				{
					if ((((lzham_symbol_codec*)codec)->m_decode_buf_eof & 1) != 1)
					{
						((lzham_symbol_codec*)codec)->m_arith_value = num9;
						((lzham_symbol_codec*)codec)->m_arith_length = num10;
						((lzham_symbol_codec*)codec)->m_bit_buf = num11;
						((lzham_symbol_codec*)codec)->m_bit_count = num12;
						((lzham_symbol_codec*)codec)->m_pDecode_buf_next = ptr3;
						((lzham_lzham_decompressor*)ptr)->m_match_hist0 = num3;
						((lzham_lzham_decompressor*)ptr)->m_match_hist1 = num4;
						((lzham_lzham_decompressor*)ptr)->m_match_hist2 = num5;
						((lzham_lzham_decompressor*)ptr)->m_match_hist3 = num6;
						((lzham_lzham_decompressor*)ptr)->m_cur_state = num7;
						((lzham_lzham_decompressor*)ptr)->m_dst_ofs = num8;
						goto IL_151d;
					}
					goto IL_1646;
				}
				void* ptr72 = ptr3;
				ptr3 = (byte*)ptr72 + 1;
				num184 = (byte)(*(sbyte*)ptr72);
				goto IL_168e;
			}
			((lzham_lzham_decompressor*)ptr)->m_tmp = (int)(num11 >>> 62);
			num11 <<= 2;
			num12 = checked(num12 - 2);
			if (((lzham_lzham_decompressor*)ptr)->m_tmp == 1)
			{
				reset_huffman_table_update_rates.Invoke(ptr);
			}
			else if (((lzham_lzham_decompressor*)ptr)->m_tmp == 2)
			{
				reset_all_tables.Invoke(ptr);
				if (ExceptionInfo.Current != null)
				{
					return 0;
				}
			}
			if ((num12 & 7) == 0)
			{
				goto IL_1a1e;
			}
			goto IL_1737;
		}
		IL_41ee:
		ptr45 = unchecked((byte*)(&((lzham_lzham_decompressor*)ptr)->m_is_match_model) + (nint)(uint)num7 * (nint)sizeof(lzham_adaptive_bit_model));
		goto IL_420a;
		IL_1646:
		num184 = 0;
		unchecked
		{
			if (ptr3 < ((lzham_symbol_codec*)codec)->m_pDecode_buf_end)
			{
				void* ptr73 = ptr3;
				ptr3 = (byte*)ptr73 + 1;
				num184 = (byte)(*(sbyte*)ptr73);
			}
			goto IL_168e;
		}
		IL_69a0:
		unchecked
		{
			long num185 = decode_get_bytes_consumed.Invoke(&((lzham_lzham_decompressor*)ptr)->m_codec);
			*(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size = num185;
			*(long*)((lzham_lzham_decompressor*)ptr)->m_pOut_buf_size = 0L;
			((lzham_lzham_decompressor*)ptr)->m_state = 801;
			return 2;
		}
		IL_5cb2:
		unchecked
		{
			if (num12 < 8)
			{
				if (ptr3 == ((lzham_symbol_codec*)codec)->m_pDecode_buf_end)
				{
					if ((((lzham_symbol_codec*)codec)->m_decode_buf_eof & 1) != 1)
					{
						((lzham_symbol_codec*)codec)->m_arith_value = num9;
						((lzham_symbol_codec*)codec)->m_arith_length = num10;
						((lzham_symbol_codec*)codec)->m_bit_buf = num11;
						((lzham_symbol_codec*)codec)->m_bit_count = num12;
						((lzham_symbol_codec*)codec)->m_pDecode_buf_next = ptr3;
						((lzham_lzham_decompressor*)ptr)->m_match_len = num13;
						((lzham_lzham_decompressor*)ptr)->m_match_hist0 = num3;
						((lzham_lzham_decompressor*)ptr)->m_match_hist1 = num4;
						((lzham_lzham_decompressor*)ptr)->m_match_hist2 = num5;
						((lzham_lzham_decompressor*)ptr)->m_match_hist3 = num6;
						((lzham_lzham_decompressor*)ptr)->m_cur_state = num7;
						((lzham_lzham_decompressor*)ptr)->m_dst_ofs = num8;
						goto IL_5db1;
					}
					goto IL_5ee3;
				}
				void* ptr74 = ptr3;
				ptr3 = (byte*)ptr74 + 1;
				num37 = (byte)(*(sbyte*)ptr74);
				goto IL_5f2b;
			}
			int num186 = (int)(num11 >>> 56);
			num11 <<= 8;
			num12 = checked(num12 - 8);
			ptr37 = ((lzham_symbol_codec*)codec)->m_pSaved_model;
			num9 = (num9 << 8) | num186;
			num10 <<= 8;
			goto IL_5c8f;
		}
		IL_96e4:
		num12 += 8;
		unchecked
		{
			num11 |= (long)((ulong)(uint)num159 << (int)(uint)checked(64 - num12));
			goto IL_9434;
		}
		IL_1d5e:
		unchecked((lzham_lzham_decompressor*)ptr)->m_state = 453;
		return 14;
		IL_274d:
		unchecked
		{
			long num187 = decode_get_bytes_consumed.Invoke(&((lzham_lzham_decompressor*)ptr)->m_codec);
			*(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size = num187;
			*(long*)((lzham_lzham_decompressor*)ptr)->m_pOut_buf_size = 0L;
			((lzham_lzham_decompressor*)ptr)->m_state = 517;
			return 2;
		}
		IL_7cd3:
		unchecked
		{
			long num188 = decode_get_bytes_consumed.Invoke(&((lzham_lzham_decompressor*)ptr)->m_codec);
			*(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size = num188;
			*(long*)((lzham_lzham_decompressor*)ptr)->m_pOut_buf_size = 0L;
			((lzham_lzham_decompressor*)ptr)->m_state = 837;
			return 2;
		}
		IL_1d78:
		unchecked
		{
			if (num12 < 16)
			{
				if (ptr3 == ((lzham_symbol_codec*)codec)->m_pDecode_buf_end)
				{
					if ((((lzham_symbol_codec*)codec)->m_decode_buf_eof & 1) != 1)
					{
						((lzham_symbol_codec*)codec)->m_arith_value = num9;
						((lzham_symbol_codec*)codec)->m_arith_length = num10;
						((lzham_symbol_codec*)codec)->m_bit_buf = num11;
						((lzham_symbol_codec*)codec)->m_bit_count = num12;
						((lzham_symbol_codec*)codec)->m_pDecode_buf_next = ptr3;
						((lzham_lzham_decompressor*)ptr)->m_match_hist0 = num3;
						((lzham_lzham_decompressor*)ptr)->m_match_hist1 = num4;
						((lzham_lzham_decompressor*)ptr)->m_match_hist2 = num5;
						((lzham_lzham_decompressor*)ptr)->m_match_hist3 = num6;
						((lzham_lzham_decompressor*)ptr)->m_cur_state = num7;
						((lzham_lzham_decompressor*)ptr)->m_dst_ofs = num8;
						goto IL_1e67;
					}
					goto IL_1f90;
				}
				void* ptr75 = ptr3;
				ptr3 = (byte*)ptr75 + 1;
				num166 = (byte)(*(sbyte*)ptr75);
				goto IL_1fd8;
			}
			int num61 = (int)(num11 >>> 48);
			num11 <<= 16;
			num12 = checked(num12 - 16);
			if (num61 != 65535)
			{
				((lzham_symbol_codec*)codec)->m_arith_value = num9;
				((lzham_symbol_codec*)codec)->m_arith_length = num10;
				((lzham_symbol_codec*)codec)->m_bit_buf = num11;
				((lzham_symbol_codec*)codec)->m_bit_count = num12;
				((lzham_symbol_codec*)codec)->m_pDecode_buf_next = ptr3;
				long num189 = decode_get_bytes_consumed.Invoke(codec);
				*(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size = num189;
				*(long*)((lzham_lzham_decompressor*)ptr)->m_pOut_buf_size = 0L;
				goto IL_20bc;
			}
			if (((lzham_lzham_decompressor*)ptr)->m_tmp != 2 && ((lzham_lzham_decompressor*)ptr)->m_tmp != 3)
			{
				goto IL_a68b;
			}
			((lzham_symbol_codec*)codec)->m_arith_value = num9;
			((lzham_symbol_codec*)codec)->m_arith_length = num10;
			((lzham_symbol_codec*)codec)->m_bit_buf = num11;
			((lzham_symbol_codec*)codec)->m_bit_count = num12;
			((lzham_symbol_codec*)codec)->m_pDecode_buf_next = ptr3;
			if (num8 != 0)
			{
				((lzham_lzham_decompressor*)ptr)->m_match_hist0 = num3;
				((lzham_lzham_decompressor*)ptr)->m_match_hist1 = num4;
				((lzham_lzham_decompressor*)ptr)->m_match_hist2 = num5;
				((lzham_lzham_decompressor*)ptr)->m_match_hist3 = num6;
				((lzham_lzham_decompressor*)ptr)->m_cur_state = num7;
				((lzham_lzham_decompressor*)ptr)->m_dst_ofs = num8;
				((lzham_lzham_decompressor*)ptr)->m_pFlush_src = (byte*)((lzham_lzham_decompressor*)ptr)->m_pDecomp_buf + (uint)((lzham_lzham_decompressor*)ptr)->m_seed_bytes_to_ignore_when_flushing + (uint)((lzham_lzham_decompressor*)ptr)->m_dst_highwater_ofs;
				((lzham_lzham_decompressor*)ptr)->m_flush_num_bytes_remaining = (uint)(num8 - ((lzham_lzham_decompressor*)ptr)->m_seed_bytes_to_ignore_when_flushing - ((lzham_lzham_decompressor*)ptr)->m_dst_highwater_ofs);
				((lzham_lzham_decompressor*)ptr)->m_seed_bytes_to_ignore_when_flushing = 0;
				((lzham_lzham_decompressor*)ptr)->m_dst_highwater_ofs = num8 & num2;
				goto IL_222a;
			}
			long num190 = decode_get_bytes_consumed.Invoke(codec);
			*(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size = num190;
			long num191 = (uint)(num8 - ((lzham_lzham_decompressor*)ptr)->m_dst_highwater_ofs);
			*(long*)((lzham_lzham_decompressor*)ptr)->m_pOut_buf_size = num191;
			((lzham_lzham_decompressor*)ptr)->m_dst_highwater_ofs = num8;
			((lzham_lzham_decompressor*)ptr)->m_match_hist0 = num3;
			((lzham_lzham_decompressor*)ptr)->m_match_hist1 = num4;
			((lzham_lzham_decompressor*)ptr)->m_match_hist2 = num5;
			((lzham_lzham_decompressor*)ptr)->m_match_hist3 = num6;
			((lzham_lzham_decompressor*)ptr)->m_cur_state = num7;
			((lzham_lzham_decompressor*)ptr)->m_dst_ofs = num8;
			((lzham_lzham_decompressor*)ptr)->m_state = 496;
			return 0;
		}
		IL_7e05:
		num148 = 0;
		unchecked
		{
			if (ptr3 < ((lzham_symbol_codec*)codec)->m_pDecode_buf_end)
			{
				void* ptr76 = ptr3;
				ptr3 = (byte*)ptr76 + 1;
				num148 = (byte)(*(sbyte*)ptr76);
			}
			goto IL_7e4d;
		}
		IL_55c9:
		unchecked
		{
			long num192 = decode_get_bytes_consumed.Invoke(&((lzham_lzham_decompressor*)ptr)->m_codec);
			*(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size = num192;
			*(long*)((lzham_lzham_decompressor*)ptr)->m_pOut_buf_size = 0L;
			((lzham_lzham_decompressor*)ptr)->m_state = 774;
			return 2;
		}
		IL_287f:
		num172 = 0;
		unchecked
		{
			if (ptr3 < ((lzham_symbol_codec*)codec)->m_pDecode_buf_end)
			{
				void* ptr77 = ptr3;
				ptr3 = (byte*)ptr77 + 1;
				num172 = (byte)(*(sbyte*)ptr77);
			}
			goto IL_28c7;
		}
		IL_1737:
		unchecked
		{
			if (num12 < (num12 & 7))
			{
				if (ptr3 == ((lzham_symbol_codec*)codec)->m_pDecode_buf_end)
				{
					if ((((lzham_symbol_codec*)codec)->m_decode_buf_eof & 1) != 1)
					{
						((lzham_symbol_codec*)codec)->m_arith_value = num9;
						((lzham_symbol_codec*)codec)->m_arith_length = num10;
						((lzham_symbol_codec*)codec)->m_bit_buf = num11;
						((lzham_symbol_codec*)codec)->m_bit_count = num12;
						((lzham_symbol_codec*)codec)->m_pDecode_buf_next = ptr3;
						((lzham_lzham_decompressor*)ptr)->m_match_hist0 = num3;
						((lzham_lzham_decompressor*)ptr)->m_match_hist1 = num4;
						((lzham_lzham_decompressor*)ptr)->m_match_hist2 = num5;
						((lzham_lzham_decompressor*)ptr)->m_match_hist3 = num6;
						((lzham_lzham_decompressor*)ptr)->m_cur_state = num7;
						((lzham_lzham_decompressor*)ptr)->m_dst_ofs = num8;
						goto IL_1828;
					}
					goto IL_1951;
				}
				void* ptr78 = ptr3;
				ptr3 = (byte*)ptr78 + 1;
				num79 = (byte)(*(sbyte*)ptr78);
				goto IL_1999;
			}
			if ((num12 & 7) != 0)
			{
				_ = num11 >>> (int)(uint)checked(64 - (num12 & 7));
			}
			num11 <<= (int)(uint)(num12 & 7);
		}
		num12 -= num12 & 7;
		goto IL_1a1e;
		IL_7797:
		ptr54 = unchecked((byte*)(&((lzham_lzham_decompressor*)ptr)->m_is_rep1_model) + (nint)(uint)num7 * (nint)sizeof(lzham_adaptive_bit_model));
		goto IL_77af;
		IL_60f9:
		if (num12 >= 24)
		{
			goto IL_63fc;
		}
		unchecked
		{
			if ((((lzham_symbol_codec*)codec)->m_decode_buf_eof & 1) != 1)
			{
				((lzham_symbol_codec*)codec)->m_pSaved_huff_model = ptr8;
				((lzham_symbol_codec*)codec)->m_arith_value = num9;
				((lzham_symbol_codec*)codec)->m_arith_length = num10;
				((lzham_symbol_codec*)codec)->m_bit_buf = num11;
				((lzham_symbol_codec*)codec)->m_bit_count = num12;
				((lzham_symbol_codec*)codec)->m_pDecode_buf_next = ptr3;
				((lzham_lzham_decompressor*)ptr)->m_match_len = num13;
				((lzham_lzham_decompressor*)ptr)->m_match_hist0 = num3;
				((lzham_lzham_decompressor*)ptr)->m_match_hist1 = num4;
				((lzham_lzham_decompressor*)ptr)->m_match_hist2 = num5;
				((lzham_lzham_decompressor*)ptr)->m_match_hist3 = num6;
				((lzham_lzham_decompressor*)ptr)->m_cur_state = num7;
				((lzham_lzham_decompressor*)ptr)->m_dst_ofs = num8;
				goto IL_61f8;
			}
			goto IL_633c;
		}
		IL_61f8:
		unchecked
		{
			long num193 = decode_get_bytes_consumed.Invoke(&((lzham_lzham_decompressor*)ptr)->m_codec);
			*(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size = num193;
			*(long*)((lzham_lzham_decompressor*)ptr)->m_pOut_buf_size = 0L;
			((lzham_lzham_decompressor*)ptr)->m_state = 787;
			return 2;
		}
		IL_4444:
		num39 = 0;
		unchecked
		{
			if (ptr3 < ((lzham_symbol_codec*)codec)->m_pDecode_buf_end)
			{
				void* ptr79 = ptr3;
				ptr3 = (byte*)ptr79 + 1;
				num39 = (byte)(*(sbyte*)ptr79);
			}
			goto IL_448c;
		}
		IL_151d:
		unchecked
		{
			long num194 = decode_get_bytes_consumed.Invoke(&((lzham_lzham_decompressor*)ptr)->m_codec);
			*(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size = num194;
			*(long*)((lzham_lzham_decompressor*)ptr)->m_pOut_buf_size = 0L;
			((lzham_lzham_decompressor*)ptr)->m_state = 437;
			return 2;
		}
		IL_1c7e:
		num12 += 8;
		unchecked
		{
			num11 |= (long)((ulong)(uint)num60 << (int)(uint)checked(64 - num12));
			goto IL_1a1e;
		}
		IL_264d:
		unchecked
		{
			if (num12 < 24)
			{
				if (ptr3 == ((lzham_symbol_codec*)codec)->m_pDecode_buf_end)
				{
					if ((((lzham_symbol_codec*)codec)->m_decode_buf_eof & 1) != 1)
					{
						((lzham_symbol_codec*)codec)->m_arith_value = num9;
						((lzham_symbol_codec*)codec)->m_arith_length = num10;
						((lzham_symbol_codec*)codec)->m_bit_buf = num11;
						((lzham_symbol_codec*)codec)->m_bit_count = num12;
						((lzham_symbol_codec*)codec)->m_pDecode_buf_next = ptr3;
						((lzham_lzham_decompressor*)ptr)->m_num_raw_bytes_remaining = num18;
						((lzham_lzham_decompressor*)ptr)->m_match_hist0 = num3;
						((lzham_lzham_decompressor*)ptr)->m_match_hist1 = num4;
						((lzham_lzham_decompressor*)ptr)->m_match_hist2 = num5;
						((lzham_lzham_decompressor*)ptr)->m_match_hist3 = num6;
						((lzham_lzham_decompressor*)ptr)->m_cur_state = num7;
						((lzham_lzham_decompressor*)ptr)->m_dst_ofs = num8;
						goto IL_274d;
					}
					goto IL_287f;
				}
				void* ptr80 = ptr3;
				ptr3 = (byte*)ptr80 + 1;
				num172 = (byte)(*(sbyte*)ptr80);
				goto IL_28c7;
			}
			num18 = (int)(num11 >>> 40);
			num11 <<= 24;
		}
		num12 -= 24;
		goto IL_2919;
		IL_6c91:
		if (num12 >= 24)
		{
			goto IL_6f94;
		}
		unchecked
		{
			if ((((lzham_symbol_codec*)codec)->m_decode_buf_eof & 1) != 1)
			{
				((lzham_symbol_codec*)codec)->m_pSaved_huff_model = ptr7;
				((lzham_symbol_codec*)codec)->m_arith_value = num9;
				((lzham_symbol_codec*)codec)->m_arith_length = num10;
				((lzham_symbol_codec*)codec)->m_bit_buf = num11;
				((lzham_symbol_codec*)codec)->m_bit_count = num12;
				((lzham_symbol_codec*)codec)->m_pDecode_buf_next = ptr3;
				((lzham_lzham_decompressor*)ptr)->m_match_len = num13;
				((lzham_lzham_decompressor*)ptr)->m_match_hist0 = num3;
				((lzham_lzham_decompressor*)ptr)->m_match_hist1 = num4;
				((lzham_lzham_decompressor*)ptr)->m_match_hist2 = num5;
				((lzham_lzham_decompressor*)ptr)->m_match_hist3 = num6;
				((lzham_lzham_decompressor*)ptr)->m_cur_state = num7;
				((lzham_lzham_decompressor*)ptr)->m_dst_ofs = num8;
				goto IL_6d90;
			}
			goto IL_6ed4;
		}
		IL_48fd:
		num123 = 0;
		unchecked
		{
			if (ptr3 < ((lzham_symbol_codec*)codec)->m_pDecode_buf_end)
			{
				void* ptr81 = ptr3;
				ptr3 = (byte*)ptr81 + 1;
				num123 = (byte)(*(sbyte*)ptr81);
			}
			num12 = checked(num12 + 8);
			num11 |= (long)((ulong)(uint)num123 << (int)(uint)checked(64 - num12));
			goto IL_46d4;
		}
		IL_168e:
		num12 += 8;
		unchecked
		{
			num11 |= (long)((ulong)(uint)num184 << (int)(uint)checked(64 - num12));
			goto IL_142f;
		}
		IL_9aef:
		unchecked
		{
			int num195 = (int)((num11 >>> 48) + 1L);
			int num197;
			int num198;
			if ((uint)num195 <= (uint)((lzham_prefix_coding_decoder_tables*)pDecode_tables)->m_table_max_code)
			{
				int num196 = ((int*)((lzham_prefix_coding_decoder_tables*)pDecode_tables)->m_lookup)[num11 >>> (int)(uint)(64 - ((lzham_prefix_coding_decoder_tables*)pDecode_tables)->m_table_bits)];
				num197 = num196 & 0xFFFF;
				num198 = num196 >>> 16;
			}
			else
			{
				for (num198 = ((lzham_prefix_coding_decoder_tables*)pDecode_tables)->m_decode_start_code_size; (uint)num195 > (uint)((int*)(&((lzham_prefix_coding_decoder_tables*)pDecode_tables)->m_max_codes))[(uint)(num198 - 1)]; num198++)
				{
				}
				int num199;
				checked
				{
					num199 = unchecked(((int*)(&((lzham_prefix_coding_decoder_tables*)pDecode_tables)->m_val_ptrs))[(uint)(num198 - 1)]) + unchecked((int)(num11 >>> (int)(uint)(64 - num198)));
				}
				if ((uint)num199 >= (uint)((lzham_raw_quasi_adaptive_huffman_data_model*)ptr4)->m_total_syms)
				{
					num199 = 0;
				}
				num197 = (ushort)((short*)((lzham_prefix_coding_decoder_tables*)pDecode_tables)->m_sorted_symbol_order)[num199];
			}
			num11 <<= (int)(uint)num198;
			num12 -= num198;
			int num200 = (ushort)(*(short*)vector_unsigned_short_Operator.Invoke(&((lzham_raw_quasi_adaptive_huffman_data_model*)ptr4)->m_sym_freq, num197));
			*(short*)vector_unsigned_short_Operator.Invoke(&((lzham_raw_quasi_adaptive_huffman_data_model*)ptr4)->m_sym_freq, num197) = (short)(num200 + 1);
			if ((((lzham_raw_quasi_adaptive_huffman_data_model*)ptr4)->m_symbols_until_update += -1) == 0)
			{
				update_tables.Invoke(ptr4, -1, sym_freq_all_ones: false);
				if (ExceptionInfo.Current != null)
				{
					return 0;
				}
			}
			num15 += num197;
			goto IL_9c87;
		}
		IL_4ec1:
		unchecked
		{
			int num201 = (int)((num11 >>> 48) + 1L);
			int num203;
			int num204;
			if ((uint)num201 <= (uint)((lzham_prefix_coding_decoder_tables*)pDecode_tables6)->m_table_max_code)
			{
				int num202 = ((int*)((lzham_prefix_coding_decoder_tables*)pDecode_tables6)->m_lookup)[num11 >>> (int)(uint)(64 - ((lzham_prefix_coding_decoder_tables*)pDecode_tables6)->m_table_bits)];
				num203 = num202 & 0xFFFF;
				num204 = num202 >>> 16;
			}
			else
			{
				for (num204 = ((lzham_prefix_coding_decoder_tables*)pDecode_tables6)->m_decode_start_code_size; (uint)num201 > (uint)((int*)(&((lzham_prefix_coding_decoder_tables*)pDecode_tables6)->m_max_codes))[(uint)(num204 - 1)]; num204++)
				{
				}
				int num205;
				checked
				{
					num205 = unchecked(((int*)(&((lzham_prefix_coding_decoder_tables*)pDecode_tables6)->m_val_ptrs))[(uint)(num204 - 1)]) + unchecked((int)(num11 >>> (int)(uint)(64 - num204)));
				}
				if ((uint)num205 >= (uint)((lzham_raw_quasi_adaptive_huffman_data_model*)ptr9)->m_total_syms)
				{
					num205 = 0;
				}
				num203 = (ushort)((short*)((lzham_prefix_coding_decoder_tables*)pDecode_tables6)->m_sorted_symbol_order)[num205];
			}
			num11 <<= (int)(uint)num204;
			num12 -= num204;
			int num206 = (ushort)(*(short*)vector_unsigned_short_Operator.Invoke(&((lzham_raw_quasi_adaptive_huffman_data_model*)ptr9)->m_sym_freq, num203));
			*(short*)vector_unsigned_short_Operator.Invoke(&((lzham_raw_quasi_adaptive_huffman_data_model*)ptr9)->m_sym_freq, num203) = (short)(num206 + 1);
			if ((((lzham_raw_quasi_adaptive_huffman_data_model*)ptr9)->m_symbols_until_update += -1) == 0)
			{
				update_tables.Invoke(ptr9, -1, sym_freq_all_ones: false);
				if (ExceptionInfo.Current != null)
				{
					return 0;
				}
			}
			((sbyte*)pDecomp_buf)[(uint)num8] = (sbyte)(num203 ^ num17);
			goto IL_506d;
		}
		IL_9a2f:
		num157 = 0;
		unchecked
		{
			if (ptr3 < ((lzham_symbol_codec*)codec)->m_pDecode_buf_end)
			{
				void* ptr82 = ptr3;
				ptr3 = (byte*)ptr82 + 1;
				num157 = (byte)(*(sbyte*)ptr82);
			}
			num12 = checked(num12 + 8);
			num11 |= (long)((ulong)(uint)num157 << (int)(uint)checked(64 - num12));
			goto IL_97b8;
		}
		IL_97b8:
		if (num12 >= 24)
		{
			goto IL_9aef;
		}
		unchecked
		{
			if ((((lzham_symbol_codec*)codec)->m_decode_buf_eof & 1) != 1)
			{
				((lzham_symbol_codec*)codec)->m_pSaved_huff_model = ptr4;
				((lzham_symbol_codec*)codec)->m_arith_value = num9;
				((lzham_symbol_codec*)codec)->m_arith_length = num10;
				((lzham_symbol_codec*)codec)->m_bit_buf = num11;
				((lzham_symbol_codec*)codec)->m_bit_count = num12;
				((lzham_symbol_codec*)codec)->m_pDecode_buf_next = ptr3;
				((lzham_lzham_decompressor*)ptr)->m_match_len = num13;
				((lzham_lzham_decompressor*)ptr)->m_match_slot = num14;
				((lzham_lzham_decompressor*)ptr)->m_extra_bits = num15;
				((lzham_lzham_decompressor*)ptr)->m_match_hist0 = num3;
				((lzham_lzham_decompressor*)ptr)->m_match_hist1 = num4;
				((lzham_lzham_decompressor*)ptr)->m_match_hist2 = num5;
				((lzham_lzham_decompressor*)ptr)->m_match_hist3 = num6;
				((lzham_lzham_decompressor*)ptr)->m_cur_state = num7;
				((lzham_lzham_decompressor*)ptr)->m_dst_ofs = num8;
				goto IL_98d9;
			}
			goto IL_9a2f;
		}
		IL_47c2:
		unchecked
		{
			long num207 = decode_get_bytes_consumed.Invoke(&((lzham_lzham_decompressor*)ptr)->m_codec);
			*(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size = num207;
			*(long*)((lzham_lzham_decompressor*)ptr)->m_pOut_buf_size = 0L;
			((lzham_lzham_decompressor*)ptr)->m_state = 711;
			return 2;
		}
		IL_5db1:
		unchecked
		{
			long num208 = decode_get_bytes_consumed.Invoke(&((lzham_lzham_decompressor*)ptr)->m_codec);
			*(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size = num208;
			*(long*)((lzham_lzham_decompressor*)ptr)->m_pOut_buf_size = 0L;
			((lzham_lzham_decompressor*)ptr)->m_state = 780;
			return 2;
		}
		IL_2603:
		unchecked
		{
			num9 = ((lzham_symbol_codec*)codec)->m_arith_value;
			num10 = ((lzham_symbol_codec*)codec)->m_arith_length;
			num11 = ((lzham_symbol_codec*)codec)->m_bit_buf;
			num12 = ((lzham_symbol_codec*)codec)->m_bit_count;
			ptr3 = ((lzham_symbol_codec*)codec)->m_pDecode_buf_next;
			goto IL_a68b;
		}
		IL_54ca:
		unchecked
		{
			if (num12 < 8)
			{
				if (ptr3 == ((lzham_symbol_codec*)codec)->m_pDecode_buf_end)
				{
					if ((((lzham_symbol_codec*)codec)->m_decode_buf_eof & 1) != 1)
					{
						((lzham_symbol_codec*)codec)->m_arith_value = num9;
						((lzham_symbol_codec*)codec)->m_arith_length = num10;
						((lzham_symbol_codec*)codec)->m_bit_buf = num11;
						((lzham_symbol_codec*)codec)->m_bit_count = num12;
						((lzham_symbol_codec*)codec)->m_pDecode_buf_next = ptr3;
						((lzham_lzham_decompressor*)ptr)->m_match_len = num13;
						((lzham_lzham_decompressor*)ptr)->m_match_hist0 = num3;
						((lzham_lzham_decompressor*)ptr)->m_match_hist1 = num4;
						((lzham_lzham_decompressor*)ptr)->m_match_hist2 = num5;
						((lzham_lzham_decompressor*)ptr)->m_match_hist3 = num6;
						((lzham_lzham_decompressor*)ptr)->m_cur_state = num7;
						((lzham_lzham_decompressor*)ptr)->m_dst_ofs = num8;
						goto IL_55c9;
					}
					goto IL_56fb;
				}
				void* ptr83 = ptr3;
				ptr3 = (byte*)ptr83 + 1;
				num81 = (byte)(*(sbyte*)ptr83);
				goto IL_5743;
			}
			int num209 = (int)(num11 >>> 56);
			num11 <<= 8;
			num12 = checked(num12 - 8);
			ptr46 = ((lzham_symbol_codec*)codec)->m_pSaved_model;
			num9 = (num9 << 8) | num209;
			num10 <<= 8;
			goto IL_54a7;
		}
		IL_6b1a:
		num12 += 8;
		unchecked
		{
			num11 |= (long)((ulong)(uint)num112 << (int)(uint)checked(64 - num12));
			goto IL_688c;
		}
		IL_7369:
		num72 = 0;
		unchecked
		{
			if (ptr3 < ((lzham_symbol_codec*)codec)->m_pDecode_buf_end)
			{
				void* ptr84 = ptr3;
				ptr3 = (byte*)ptr84 + 1;
				num72 = (byte)(*(sbyte*)ptr84);
			}
			goto IL_73b1;
		}
		IL_8c7e:
		num22 = 0;
		unchecked
		{
			if (ptr3 < ((lzham_symbol_codec*)codec)->m_pDecode_buf_end)
			{
				void* ptr85 = ptr3;
				ptr3 = (byte*)ptr85 + 1;
				num22 = (byte)(*(sbyte*)ptr85);
			}
			goto IL_8cc6;
		}
		IL_58be:
		unchecked
		{
			if (num12 < 8)
			{
				if (ptr3 == ((lzham_symbol_codec*)codec)->m_pDecode_buf_end)
				{
					if ((((lzham_symbol_codec*)codec)->m_decode_buf_eof & 1) != 1)
					{
						((lzham_symbol_codec*)codec)->m_arith_value = num9;
						((lzham_symbol_codec*)codec)->m_arith_length = num10;
						((lzham_symbol_codec*)codec)->m_bit_buf = num11;
						((lzham_symbol_codec*)codec)->m_bit_count = num12;
						((lzham_symbol_codec*)codec)->m_pDecode_buf_next = ptr3;
						((lzham_lzham_decompressor*)ptr)->m_match_len = num13;
						((lzham_lzham_decompressor*)ptr)->m_match_hist0 = num3;
						((lzham_lzham_decompressor*)ptr)->m_match_hist1 = num4;
						((lzham_lzham_decompressor*)ptr)->m_match_hist2 = num5;
						((lzham_lzham_decompressor*)ptr)->m_match_hist3 = num6;
						((lzham_lzham_decompressor*)ptr)->m_cur_state = num7;
						((lzham_lzham_decompressor*)ptr)->m_dst_ofs = num8;
						goto IL_59bd;
					}
					goto IL_5aef;
				}
				void* ptr86 = ptr3;
				ptr3 = (byte*)ptr86 + 1;
				num41 = (byte)(*(sbyte*)ptr86);
				goto IL_5b37;
			}
			int num210 = (int)(num11 >>> 56);
			num11 <<= 8;
			num12 = checked(num12 - 8);
			ptr49 = ((lzham_symbol_codec*)codec)->m_pSaved_model;
			num9 = (num9 << 8) | num210;
			num10 <<= 8;
			goto IL_589b;
		}
		IL_1b0d:
		unchecked
		{
			long num211 = decode_get_bytes_consumed.Invoke(&((lzham_lzham_decompressor*)ptr)->m_codec);
			*(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size = num211;
			*(long*)((lzham_lzham_decompressor*)ptr)->m_pOut_buf_size = 0L;
			((lzham_lzham_decompressor*)ptr)->m_state = 447;
			return 2;
		}
		IL_7424:
		int num212;
		unchecked
		{
			if (num12 < (byte)((sbyte*)s_huge_match_code_len.Pointer)[(uint)num13])
			{
				if (ptr3 == ((lzham_symbol_codec*)codec)->m_pDecode_buf_end)
				{
					if ((((lzham_symbol_codec*)codec)->m_decode_buf_eof & 1) != 1)
					{
						((lzham_symbol_codec*)codec)->m_arith_value = num9;
						((lzham_symbol_codec*)codec)->m_arith_length = num10;
						((lzham_symbol_codec*)codec)->m_bit_buf = num11;
						((lzham_symbol_codec*)codec)->m_bit_count = num12;
						((lzham_symbol_codec*)codec)->m_pDecode_buf_next = ptr3;
						((lzham_lzham_decompressor*)ptr)->m_match_len = num13;
						((lzham_lzham_decompressor*)ptr)->m_match_hist0 = num3;
						((lzham_lzham_decompressor*)ptr)->m_match_hist1 = num4;
						((lzham_lzham_decompressor*)ptr)->m_match_hist2 = num5;
						((lzham_lzham_decompressor*)ptr)->m_match_hist3 = num6;
						((lzham_lzham_decompressor*)ptr)->m_cur_state = num7;
						((lzham_lzham_decompressor*)ptr)->m_dst_ofs = num8;
						goto IL_7538;
					}
					goto IL_766a;
				}
				void* ptr87 = ptr3;
				ptr3 = (byte*)ptr87 + 1;
				num125 = (byte)(*(sbyte*)ptr87);
				goto IL_76b2;
			}
			num212 = (int)(((bool*)s_huge_match_code_len.Pointer)[(uint)num13] ? (num11 >>> (int)(uint)checked(64 - unchecked((byte)((sbyte*)s_huge_match_code_len.Pointer)[(uint)num13]))) : 0);
			num11 <<= (int)(byte)((sbyte*)s_huge_match_code_len.Pointer)[(uint)num13];
		}
		num12 -= unchecked((byte)((sbyte*)s_huge_match_code_len.Pointer)[(uint)num13]);
		num13 = unchecked(((int*)s_huge_match_base_len.Pointer)[(uint)num13] + num212);
		goto IL_7797;
		IL_b3a3:
		unchecked
		{
			((lzham_symbol_codec*)codec)->m_arith_value = num9;
			((lzham_symbol_codec*)codec)->m_arith_length = num10;
			((lzham_symbol_codec*)codec)->m_bit_buf = num11;
			((lzham_symbol_codec*)codec)->m_bit_count = num12;
			((lzham_symbol_codec*)codec)->m_pDecode_buf_next = ptr3;
			long num213 = stop_decoding.Invoke(codec);
			*(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size = num213;
			*(long*)((lzham_lzham_decompressor*)ptr)->m_pOut_buf_size = 0L;
			((lzham_lzham_decompressor*)ptr)->m_dst_highwater_ofs = num8;
			((lzham_lzham_decompressor*)ptr)->m_state = 1110;
			return ((lzham_lzham_decompressor*)ptr)->m_status;
		}
		IL_65a0:
		unchecked
		{
			while (num12 >= 1)
			{
				int num214 = (int)(num11 >>> 63);
				num11 <<= 1;
				num12 = checked(num12 - 1);
				if (num214 != 0)
				{
					num13++;
					if ((uint)num13 < 3u)
					{
						continue;
					}
				}
				goto IL_688c;
			}
			if (ptr3 == ((lzham_symbol_codec*)codec)->m_pDecode_buf_end)
			{
				if ((((lzham_symbol_codec*)codec)->m_decode_buf_eof & 1) != 1)
				{
					((lzham_symbol_codec*)codec)->m_arith_value = num9;
					((lzham_symbol_codec*)codec)->m_arith_length = num10;
					((lzham_symbol_codec*)codec)->m_bit_buf = num11;
					((lzham_symbol_codec*)codec)->m_bit_count = num12;
					((lzham_symbol_codec*)codec)->m_pDecode_buf_next = ptr3;
					((lzham_lzham_decompressor*)ptr)->m_match_len = num13;
					((lzham_lzham_decompressor*)ptr)->m_match_hist0 = num3;
					((lzham_lzham_decompressor*)ptr)->m_match_hist1 = num4;
					((lzham_lzham_decompressor*)ptr)->m_match_hist2 = num5;
					((lzham_lzham_decompressor*)ptr)->m_match_hist3 = num6;
					((lzham_lzham_decompressor*)ptr)->m_cur_state = num7;
					((lzham_lzham_decompressor*)ptr)->m_dst_ofs = num8;
					goto IL_669f;
				}
				goto IL_67d1;
			}
			void* ptr88 = ptr3;
			ptr3 = (byte*)ptr88 + 1;
			num107 = (byte)(*(sbyte*)ptr88);
			goto IL_6819;
		}
		IL_a596:
		int num215 = 0;
		unchecked
		{
			if (ptr3 < ((lzham_symbol_codec*)codec)->m_pDecode_buf_end)
			{
				void* ptr89 = ptr3;
				ptr3 = (byte*)ptr89 + 1;
				num215 = (byte)(*(sbyte*)ptr89);
			}
			goto IL_a5de;
		}
		IL_a37c:
		unchecked
		{
			if (num12 < (num12 & 7))
			{
				if (ptr3 == ((lzham_symbol_codec*)codec)->m_pDecode_buf_end)
				{
					if ((((lzham_symbol_codec*)codec)->m_decode_buf_eof & 1) != 1)
					{
						((lzham_symbol_codec*)codec)->m_arith_value = num9;
						((lzham_symbol_codec*)codec)->m_arith_length = num10;
						((lzham_symbol_codec*)codec)->m_bit_buf = num11;
						((lzham_symbol_codec*)codec)->m_bit_count = num12;
						((lzham_symbol_codec*)codec)->m_pDecode_buf_next = ptr3;
						((lzham_lzham_decompressor*)ptr)->m_match_hist0 = num3;
						((lzham_lzham_decompressor*)ptr)->m_match_hist1 = num4;
						((lzham_lzham_decompressor*)ptr)->m_match_hist2 = num5;
						((lzham_lzham_decompressor*)ptr)->m_match_hist3 = num6;
						((lzham_lzham_decompressor*)ptr)->m_cur_state = num7;
						((lzham_lzham_decompressor*)ptr)->m_dst_ofs = num8;
						goto IL_a46d;
					}
					goto IL_a596;
				}
				void* ptr90 = ptr3;
				ptr3 = (byte*)ptr90 + 1;
				num215 = (byte)(*(sbyte*)ptr90);
				goto IL_a5de;
			}
			if ((num12 & 7) != 0)
			{
				_ = num11 >>> (int)(uint)checked(64 - (num12 & 7));
			}
			num11 <<= (int)(uint)(num12 & 7);
		}
		num12 -= num12 & 7;
		goto IL_a68b;
		IL_b171:
		unchecked
		{
			long num216 = decode_get_bytes_consumed.Invoke(&((lzham_lzham_decompressor*)ptr)->m_codec);
			*(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size = num216;
			*(long*)((lzham_lzham_decompressor*)ptr)->m_pOut_buf_size = 0L;
			((lzham_lzham_decompressor*)ptr)->m_state = 1083;
			return 2;
		}
		IL_51c0:
		unchecked
		{
			if (((lzham_lzham_decompressor*)ptr)->m_flush_num_bytes_remaining != 0L)
			{
				((lzham_lzham_decompressor*)ptr)->m_flush_n = (((ulong)((lzham_lzham_decompressor*)ptr)->m_flush_num_bytes_remaining >= (ulong)(*(long*)((lzham_lzham_decompressor*)ptr)->m_pOut_buf_size)) ? (*(long*)((lzham_lzham_decompressor*)ptr)->m_pOut_buf_size) : ((lzham_lzham_decompressor*)ptr)->m_flush_num_bytes_remaining);
				if (0 == (((lzham_lzham_decompressor*)ptr)->m_params.m_decompress_flags & 2))
				{
					llvm_memcpy_p0_p0_i64.Invoke(((lzham_lzham_decompressor*)ptr)->m_pOut_buf, ((lzham_lzham_decompressor*)ptr)->m_pFlush_src, ((lzham_lzham_decompressor*)ptr)->m_flush_n, isVolatile: false);
				}
				else
				{
					long num218;
					for (long num217 = 0L; (ulong)num217 < (ulong)((lzham_lzham_decompressor*)ptr)->m_flush_n; num217 += num218)
					{
						num218 = (((ulong)(((lzham_lzham_decompressor*)ptr)->m_flush_n - num217) >= 8192uL) ? 8192L : (((lzham_lzham_decompressor*)ptr)->m_flush_n - num217));
						llvm_memcpy_p0_p0_i64.Invoke((byte*)((lzham_lzham_decompressor*)ptr)->m_pOut_buf + num217, (byte*)((lzham_lzham_decompressor*)ptr)->m_pFlush_src + num217, num218, isVolatile: false);
						((lzham_lzham_decompressor*)ptr)->m_decomp_adler32 = adler32.Invoke(adler32: ((lzham_lzham_decompressor*)ptr)->m_decomp_adler32, pBuf: (byte*)((lzham_lzham_decompressor*)ptr)->m_pFlush_src + num217, buflen: num218);
					}
				}
				long num219 = decode_get_bytes_consumed.Invoke(&((lzham_lzham_decompressor*)ptr)->m_codec);
				*(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size = num219;
				long flush_n18 = ((lzham_lzham_decompressor*)ptr)->m_flush_n;
				*(long*)((lzham_lzham_decompressor*)ptr)->m_pOut_buf_size = flush_n18;
				((lzham_lzham_decompressor*)ptr)->m_state = 757;
				return InstructionHelper.Select(((lzham_lzham_decompressor*)ptr)->m_flush_n != 0L, 0, 1);
			}
			num3 = ((lzham_lzham_decompressor*)ptr)->m_match_hist0;
			num4 = ((lzham_lzham_decompressor*)ptr)->m_match_hist1;
			num5 = ((lzham_lzham_decompressor*)ptr)->m_match_hist2;
			num6 = ((lzham_lzham_decompressor*)ptr)->m_match_hist3;
			num7 = ((lzham_lzham_decompressor*)ptr)->m_cur_state;
			_ = ((lzham_lzham_decompressor*)ptr)->m_dst_ofs;
			num9 = ((lzham_symbol_codec*)codec)->m_arith_value;
			num10 = ((lzham_symbol_codec*)codec)->m_arith_length;
			num11 = ((lzham_symbol_codec*)codec)->m_bit_buf;
			num12 = ((lzham_symbol_codec*)codec)->m_bit_count;
			ptr3 = ((lzham_symbol_codec*)codec)->m_pDecode_buf_next;
			num8 = 0;
			goto IL_41ee;
		}
		IL_a5de:
		num12 += 8;
		unchecked
		{
			num11 |= (long)((ulong)(uint)num215 << (int)(uint)checked(64 - num12));
			goto IL_a37c;
		}
		IL_8569:
		if (num12 >= 24)
		{
			goto IL_8886;
		}
		unchecked
		{
			if ((((lzham_symbol_codec*)codec)->m_decode_buf_eof & 1) != 1)
			{
				((lzham_symbol_codec*)codec)->m_pSaved_huff_model = ptr5;
				((lzham_symbol_codec*)codec)->m_arith_value = num9;
				((lzham_symbol_codec*)codec)->m_arith_length = num10;
				((lzham_symbol_codec*)codec)->m_bit_buf = num11;
				((lzham_symbol_codec*)codec)->m_bit_count = num12;
				((lzham_symbol_codec*)codec)->m_pDecode_buf_next = ptr3;
				((lzham_lzham_decompressor*)ptr)->m_match_len = num13;
				((lzham_lzham_decompressor*)ptr)->m_match_slot = num14;
				((lzham_lzham_decompressor*)ptr)->m_match_hist0 = num3;
				((lzham_lzham_decompressor*)ptr)->m_match_hist1 = num4;
				((lzham_lzham_decompressor*)ptr)->m_match_hist2 = num5;
				((lzham_lzham_decompressor*)ptr)->m_match_hist3 = num6;
				((lzham_lzham_decompressor*)ptr)->m_cur_state = num7;
				((lzham_lzham_decompressor*)ptr)->m_dst_ofs = num8;
				goto IL_8679;
			}
			goto IL_87c6;
		}
		IL_506d:
		unchecked
		{
			num7 = (byte)((sbyte*)s_literal_next_state.Pointer)[(uint)num7];
			num8++;
			if ((uint)num8 <= (uint)num2)
			{
				goto IL_41ee;
			}
			((lzham_symbol_codec*)codec)->m_arith_value = num9;
			((lzham_symbol_codec*)codec)->m_arith_length = num10;
			((lzham_symbol_codec*)codec)->m_bit_buf = num11;
			((lzham_symbol_codec*)codec)->m_bit_count = num12;
			((lzham_symbol_codec*)codec)->m_pDecode_buf_next = ptr3;
			((lzham_lzham_decompressor*)ptr)->m_match_hist0 = num3;
			((lzham_lzham_decompressor*)ptr)->m_match_hist1 = num4;
			((lzham_lzham_decompressor*)ptr)->m_match_hist2 = num5;
			((lzham_lzham_decompressor*)ptr)->m_match_hist3 = num6;
			((lzham_lzham_decompressor*)ptr)->m_cur_state = num7;
			((lzham_lzham_decompressor*)ptr)->m_dst_ofs = num8;
			((lzham_lzham_decompressor*)ptr)->m_pFlush_src = (byte*)((lzham_lzham_decompressor*)ptr)->m_pDecomp_buf + (uint)((lzham_lzham_decompressor*)ptr)->m_seed_bytes_to_ignore_when_flushing + (uint)((lzham_lzham_decompressor*)ptr)->m_dst_highwater_ofs;
			((lzham_lzham_decompressor*)ptr)->m_flush_num_bytes_remaining = (uint)(num - ((lzham_lzham_decompressor*)ptr)->m_seed_bytes_to_ignore_when_flushing - ((lzham_lzham_decompressor*)ptr)->m_dst_highwater_ofs);
			((lzham_lzham_decompressor*)ptr)->m_seed_bytes_to_ignore_when_flushing = 0;
			((lzham_lzham_decompressor*)ptr)->m_dst_highwater_ofs = num & num2;
			goto IL_51c0;
		}
		IL_969c:
		num159 = 0;
		unchecked
		{
			if (ptr3 < ((lzham_symbol_codec*)codec)->m_pDecode_buf_end)
			{
				void* ptr91 = ptr3;
				ptr3 = (byte*)ptr91 + 1;
				num159 = (byte)(*(sbyte*)ptr91);
			}
			goto IL_96e4;
		}
		IL_8022:
		if (num12 >= 24)
		{
			goto IL_8325;
		}
		unchecked
		{
			if ((((lzham_symbol_codec*)codec)->m_decode_buf_eof & 1) != 1)
			{
				((lzham_symbol_codec*)codec)->m_pSaved_huff_model = ptr6;
				((lzham_symbol_codec*)codec)->m_arith_value = num9;
				((lzham_symbol_codec*)codec)->m_arith_length = num10;
				((lzham_symbol_codec*)codec)->m_bit_buf = num11;
				((lzham_symbol_codec*)codec)->m_bit_count = num12;
				((lzham_symbol_codec*)codec)->m_pDecode_buf_next = ptr3;
				((lzham_lzham_decompressor*)ptr)->m_match_len = num13;
				((lzham_lzham_decompressor*)ptr)->m_match_hist0 = num3;
				((lzham_lzham_decompressor*)ptr)->m_match_hist1 = num4;
				((lzham_lzham_decompressor*)ptr)->m_match_hist2 = num5;
				((lzham_lzham_decompressor*)ptr)->m_match_hist3 = num6;
				((lzham_lzham_decompressor*)ptr)->m_cur_state = num7;
				((lzham_lzham_decompressor*)ptr)->m_dst_ofs = num8;
				goto IL_8121;
			}
			goto IL_8265;
		}
		IL_73b1:
		num12 += 8;
		unchecked
		{
			num11 |= (long)((ulong)(uint)num72 << (int)(uint)checked(64 - num12));
			goto IL_7138;
		}
	}
}
