using AssetRipper.Conversions.Lzham.GlobalVariables;
using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Intrinsics.Implemented;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("??$decompress@$00@lzham_decompressor@lzham@@QEAA?AW4lzham_decompress_status_t@@XZ")]
[DemangledName("public: enum lzham_decompress_status_t __cdecl lzham::lzham_decompressor::decompress<1>(void)")]
[CleanName("decompress")]
internal static partial class decompress_9tv66f
{
	[return: NativeType("enum lzham_decompress_status_t")]
	public unsafe static int Invoke(void* @this)
	{
		void* ptr = @this;
		int num2;
		int num3;
		int num4;
		int num5;
		int num6;
		long pOut_buf_size;
		void* pOut_buf;
		void* ptr2;
		int num8;
		void* ptr3;
		int num13;
		void* ptr4;
		void* pDecode_tables;
		int num15;
		void* ptr5;
		void* pDecode_tables2;
		void* ptr6;
		void* pDecode_tables3;
		void* ptr7;
		void* pDecode_tables4;
		void* ptr8;
		void* pDecode_tables5;
		int num16;
		void* ptr9;
		void* pDecode_tables6;
		void* ptr10;
		void* pDecode_tables7;
		int num9;
		long num19;
		int num17;
		long num10;
		int num11;
		int num14;
		long num18;
		int num12;
		int num7;
		void* codec;
		int num;
		unchecked
		{
			codec = &((lzham_lzham_decompressor*)ptr)->m_codec;
			num = 1 << ((lzham_lzham_decompressor*)ptr)->m_params.m_dict_size_log2;
			num2 = 0;
			num3 = 0;
			num4 = 0;
			num5 = 0;
			num6 = 0;
			num7 = 0;
			pOut_buf_size = *(long*)((lzham_lzham_decompressor*)ptr)->m_pOut_buf_size;
			pOut_buf = ((lzham_lzham_decompressor*)ptr)->m_pOut_buf;
			ptr2 = (byte*)((lzham_lzham_decompressor*)ptr)->m_pOut_buf + pOut_buf_size;
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
																																																										goto IL_b113;
																																																									}
																																																									num2 = ((lzham_lzham_decompressor*)ptr)->m_match_hist0;
																																																									num3 = ((lzham_lzham_decompressor*)ptr)->m_match_hist1;
																																																									num4 = ((lzham_lzham_decompressor*)ptr)->m_match_hist2;
																																																									num5 = ((lzham_lzham_decompressor*)ptr)->m_match_hist3;
																																																									num6 = ((lzham_lzham_decompressor*)ptr)->m_cur_state;
																																																									num7 = ((lzham_lzham_decompressor*)ptr)->m_dst_ofs;
																																																									num8 = ((lzham_symbol_codec*)codec)->m_arith_value;
																																																									num9 = ((lzham_symbol_codec*)codec)->m_arith_length;
																																																									num10 = ((lzham_symbol_codec*)codec)->m_bit_buf;
																																																									num11 = ((lzham_symbol_codec*)codec)->m_bit_count;
																																																									ptr3 = ((lzham_symbol_codec*)codec)->m_pDecode_buf_next;
																																																									goto IL_b23c;
																																																								}
																																																								decode_set_input_buffer.Invoke(&((lzham_lzham_decompressor*)ptr)->m_codec, eof_flag: (((lzham_lzham_decompressor*)ptr)->m_no_more_input_bytes_flag & 1) == 1, pBuf_next: ((lzham_lzham_decompressor*)ptr)->m_pIn_buf, buf_size: *(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size, pBuf: ((lzham_lzham_decompressor*)ptr)->m_pIn_buf);
																																																								if ((((lzham_lzham_decompressor*)ptr)->m_codec.m_decode_buf_eof & 1) != 1 && ((lzham_lzham_decompressor*)ptr)->m_codec.m_decode_buf_size == 0L)
																																																								{
																																																									goto IL_ae54;
																																																								}
																																																								num2 = ((lzham_lzham_decompressor*)ptr)->m_match_hist0;
																																																								num3 = ((lzham_lzham_decompressor*)ptr)->m_match_hist1;
																																																								num4 = ((lzham_lzham_decompressor*)ptr)->m_match_hist2;
																																																								num5 = ((lzham_lzham_decompressor*)ptr)->m_match_hist3;
																																																								num6 = ((lzham_lzham_decompressor*)ptr)->m_cur_state;
																																																								num7 = ((lzham_lzham_decompressor*)ptr)->m_dst_ofs;
																																																								num8 = ((lzham_symbol_codec*)codec)->m_arith_value;
																																																								num9 = ((lzham_symbol_codec*)codec)->m_arith_length;
																																																								num10 = ((lzham_symbol_codec*)codec)->m_bit_buf;
																																																								num11 = ((lzham_symbol_codec*)codec)->m_bit_count;
																																																								ptr3 = ((lzham_symbol_codec*)codec)->m_pDecode_buf_next;
																																																								goto IL_af7d;
																																																							}
																																																							decode_set_input_buffer.Invoke(&((lzham_lzham_decompressor*)ptr)->m_codec, eof_flag: (((lzham_lzham_decompressor*)ptr)->m_no_more_input_bytes_flag & 1) == 1, pBuf_next: ((lzham_lzham_decompressor*)ptr)->m_pIn_buf, buf_size: *(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size, pBuf: ((lzham_lzham_decompressor*)ptr)->m_pIn_buf);
																																																							if ((((lzham_lzham_decompressor*)ptr)->m_codec.m_decode_buf_eof & 1) != 1 && ((lzham_lzham_decompressor*)ptr)->m_codec.m_decode_buf_size == 0L)
																																																							{
																																																								goto IL_ab6f;
																																																							}
																																																							num2 = ((lzham_lzham_decompressor*)ptr)->m_match_hist0;
																																																							num3 = ((lzham_lzham_decompressor*)ptr)->m_match_hist1;
																																																							num4 = ((lzham_lzham_decompressor*)ptr)->m_match_hist2;
																																																							num5 = ((lzham_lzham_decompressor*)ptr)->m_match_hist3;
																																																							num6 = ((lzham_lzham_decompressor*)ptr)->m_cur_state;
																																																							num7 = ((lzham_lzham_decompressor*)ptr)->m_dst_ofs;
																																																							num8 = ((lzham_symbol_codec*)codec)->m_arith_value;
																																																							num9 = ((lzham_symbol_codec*)codec)->m_arith_length;
																																																							num10 = ((lzham_symbol_codec*)codec)->m_bit_buf;
																																																							num11 = ((lzham_symbol_codec*)codec)->m_bit_count;
																																																							ptr3 = ((lzham_symbol_codec*)codec)->m_pDecode_buf_next;
																																																							goto IL_ac98;
																																																						}
																																																						decode_set_input_buffer.Invoke(&((lzham_lzham_decompressor*)ptr)->m_codec, eof_flag: (((lzham_lzham_decompressor*)ptr)->m_no_more_input_bytes_flag & 1) == 1, pBuf_next: ((lzham_lzham_decompressor*)ptr)->m_pIn_buf, buf_size: *(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size, pBuf: ((lzham_lzham_decompressor*)ptr)->m_pIn_buf);
																																																						long flush_n = ((lzham_lzham_decompressor*)ptr)->m_flush_n;
																																																						void** pFlush_src = &((lzham_lzham_decompressor*)ptr)->m_pFlush_src;
																																																						*pFlush_src = (byte*)(*pFlush_src) + flush_n;
																																																						long flush_n2 = ((lzham_lzham_decompressor*)ptr)->m_flush_n;
																																																						((lzham_lzham_decompressor*)ptr)->m_flush_num_bytes_remaining -= flush_n2;
																																																						goto IL_a78f;
																																																					}
																																																					decode_set_input_buffer.Invoke(&((lzham_lzham_decompressor*)ptr)->m_codec, eof_flag: (((lzham_lzham_decompressor*)ptr)->m_no_more_input_bytes_flag & 1) == 1, pBuf_next: ((lzham_lzham_decompressor*)ptr)->m_pIn_buf, buf_size: *(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size, pBuf: ((lzham_lzham_decompressor*)ptr)->m_pIn_buf);
																																																					if ((((lzham_lzham_decompressor*)ptr)->m_codec.m_decode_buf_eof & 1) != 1 && ((lzham_lzham_decompressor*)ptr)->m_codec.m_decode_buf_size == 0L)
																																																					{
																																																						goto IL_a401;
																																																					}
																																																					num2 = ((lzham_lzham_decompressor*)ptr)->m_match_hist0;
																																																					num3 = ((lzham_lzham_decompressor*)ptr)->m_match_hist1;
																																																					num4 = ((lzham_lzham_decompressor*)ptr)->m_match_hist2;
																																																					num5 = ((lzham_lzham_decompressor*)ptr)->m_match_hist3;
																																																					num6 = ((lzham_lzham_decompressor*)ptr)->m_cur_state;
																																																					num7 = ((lzham_lzham_decompressor*)ptr)->m_dst_ofs;
																																																					num8 = ((lzham_symbol_codec*)codec)->m_arith_value;
																																																					num9 = ((lzham_symbol_codec*)codec)->m_arith_length;
																																																					num10 = ((lzham_symbol_codec*)codec)->m_bit_buf;
																																																					num11 = ((lzham_symbol_codec*)codec)->m_bit_count;
																																																					ptr3 = ((lzham_symbol_codec*)codec)->m_pDecode_buf_next;
																																																					goto IL_a52a;
																																																				}
																																																				decode_set_input_buffer.Invoke(&((lzham_lzham_decompressor*)ptr)->m_codec, eof_flag: (((lzham_lzham_decompressor*)ptr)->m_no_more_input_bytes_flag & 1) == 1, pBuf_next: ((lzham_lzham_decompressor*)ptr)->m_pIn_buf, buf_size: *(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size, pBuf: ((lzham_lzham_decompressor*)ptr)->m_pIn_buf);
																																																				long flush_n3 = ((lzham_lzham_decompressor*)ptr)->m_flush_n;
																																																				void** pFlush_src2 = &((lzham_lzham_decompressor*)ptr)->m_pFlush_src;
																																																				*pFlush_src2 = (byte*)(*pFlush_src2) + flush_n3;
																																																				long flush_n4 = ((lzham_lzham_decompressor*)ptr)->m_flush_n;
																																																				((lzham_lzham_decompressor*)ptr)->m_flush_num_bytes_remaining -= flush_n4;
																																																				goto IL_9f04;
																																																			}
																																																			goto IL_9d06;
																																																		}
																																																		decode_set_input_buffer.Invoke(&((lzham_lzham_decompressor*)ptr)->m_codec, eof_flag: (((lzham_lzham_decompressor*)ptr)->m_no_more_input_bytes_flag & 1) == 1, pBuf_next: ((lzham_lzham_decompressor*)ptr)->m_pIn_buf, buf_size: *(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size, pBuf: ((lzham_lzham_decompressor*)ptr)->m_pIn_buf);
																																																		if ((((lzham_lzham_decompressor*)ptr)->m_codec.m_decode_buf_eof & 1) != 1 && ((lzham_lzham_decompressor*)ptr)->m_codec.m_decode_buf_size == 0L)
																																																		{
																																																			goto IL_986a;
																																																		}
																																																		num12 = ((lzham_lzham_decompressor*)ptr)->m_match_len;
																																																		num13 = ((lzham_lzham_decompressor*)ptr)->m_match_slot;
																																																		num14 = ((lzham_lzham_decompressor*)ptr)->m_extra_bits;
																																																		num2 = ((lzham_lzham_decompressor*)ptr)->m_match_hist0;
																																																		num3 = ((lzham_lzham_decompressor*)ptr)->m_match_hist1;
																																																		num4 = ((lzham_lzham_decompressor*)ptr)->m_match_hist2;
																																																		num5 = ((lzham_lzham_decompressor*)ptr)->m_match_hist3;
																																																		num6 = ((lzham_lzham_decompressor*)ptr)->m_cur_state;
																																																		num7 = ((lzham_lzham_decompressor*)ptr)->m_dst_ofs;
																																																		num8 = ((lzham_symbol_codec*)codec)->m_arith_value;
																																																		num9 = ((lzham_symbol_codec*)codec)->m_arith_length;
																																																		num10 = ((lzham_symbol_codec*)codec)->m_bit_buf;
																																																		num11 = ((lzham_symbol_codec*)codec)->m_bit_count;
																																																		ptr3 = ((lzham_symbol_codec*)codec)->m_pDecode_buf_next;
																																																		ptr4 = ((lzham_symbol_codec*)codec)->m_pSaved_huff_model;
																																																		pDecode_tables = ((lzham_raw_quasi_adaptive_huffman_data_model*)ptr4)->m_pDecode_tables;
																																																		goto IL_99c0;
																																																	}
																																																	decode_set_input_buffer.Invoke(&((lzham_lzham_decompressor*)ptr)->m_codec, eof_flag: (((lzham_lzham_decompressor*)ptr)->m_no_more_input_bytes_flag & 1) == 1, pBuf_next: ((lzham_lzham_decompressor*)ptr)->m_pIn_buf, buf_size: *(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size, pBuf: ((lzham_lzham_decompressor*)ptr)->m_pIn_buf);
																																																	if ((((lzham_lzham_decompressor*)ptr)->m_codec.m_decode_buf_eof & 1) != 1 && ((lzham_lzham_decompressor*)ptr)->m_codec.m_decode_buf_size == 0L)
																																																	{
																																																		goto IL_94e9;
																																																	}
																																																	num12 = ((lzham_lzham_decompressor*)ptr)->m_match_len;
																																																	num13 = ((lzham_lzham_decompressor*)ptr)->m_match_slot;
																																																	num15 = ((lzham_lzham_decompressor*)ptr)->m_num_extra_bits;
																																																	num2 = ((lzham_lzham_decompressor*)ptr)->m_match_hist0;
																																																	num3 = ((lzham_lzham_decompressor*)ptr)->m_match_hist1;
																																																	num4 = ((lzham_lzham_decompressor*)ptr)->m_match_hist2;
																																																	num5 = ((lzham_lzham_decompressor*)ptr)->m_match_hist3;
																																																	num6 = ((lzham_lzham_decompressor*)ptr)->m_cur_state;
																																																	num7 = ((lzham_lzham_decompressor*)ptr)->m_dst_ofs;
																																																	num8 = ((lzham_symbol_codec*)codec)->m_arith_value;
																																																	num9 = ((lzham_symbol_codec*)codec)->m_arith_length;
																																																	num10 = ((lzham_symbol_codec*)codec)->m_bit_buf;
																																																	num11 = ((lzham_symbol_codec*)codec)->m_bit_count;
																																																	ptr3 = ((lzham_symbol_codec*)codec)->m_pDecode_buf_next;
																																																	goto IL_962d;
																																																}
																																																decode_set_input_buffer.Invoke(&((lzham_lzham_decompressor*)ptr)->m_codec, eof_flag: (((lzham_lzham_decompressor*)ptr)->m_no_more_input_bytes_flag & 1) == 1, pBuf_next: ((lzham_lzham_decompressor*)ptr)->m_pIn_buf, buf_size: *(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size, pBuf: ((lzham_lzham_decompressor*)ptr)->m_pIn_buf);
																																																if ((((lzham_lzham_decompressor*)ptr)->m_codec.m_decode_buf_eof & 1) != 1 && ((lzham_lzham_decompressor*)ptr)->m_codec.m_decode_buf_size == 0L)
																																																{
																																																	goto IL_91a9;
																																																}
																																																num12 = ((lzham_lzham_decompressor*)ptr)->m_match_len;
																																																num13 = ((lzham_lzham_decompressor*)ptr)->m_match_slot;
																																																num15 = ((lzham_lzham_decompressor*)ptr)->m_num_extra_bits;
																																																num2 = ((lzham_lzham_decompressor*)ptr)->m_match_hist0;
																																																num3 = ((lzham_lzham_decompressor*)ptr)->m_match_hist1;
																																																num4 = ((lzham_lzham_decompressor*)ptr)->m_match_hist2;
																																																num5 = ((lzham_lzham_decompressor*)ptr)->m_match_hist3;
																																																num6 = ((lzham_lzham_decompressor*)ptr)->m_cur_state;
																																																num7 = ((lzham_lzham_decompressor*)ptr)->m_dst_ofs;
																																																num8 = ((lzham_symbol_codec*)codec)->m_arith_value;
																																																num9 = ((lzham_symbol_codec*)codec)->m_arith_length;
																																																num10 = ((lzham_symbol_codec*)codec)->m_bit_buf;
																																																num11 = ((lzham_symbol_codec*)codec)->m_bit_count;
																																																ptr3 = ((lzham_symbol_codec*)codec)->m_pDecode_buf_next;
																																																goto IL_92ed;
																																															}
																																															decode_set_input_buffer.Invoke(&((lzham_lzham_decompressor*)ptr)->m_codec, eof_flag: (((lzham_lzham_decompressor*)ptr)->m_no_more_input_bytes_flag & 1) == 1, pBuf_next: ((lzham_lzham_decompressor*)ptr)->m_pIn_buf, buf_size: *(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size, pBuf: ((lzham_lzham_decompressor*)ptr)->m_pIn_buf);
																																															if ((((lzham_lzham_decompressor*)ptr)->m_codec.m_decode_buf_eof & 1) != 1 && ((lzham_lzham_decompressor*)ptr)->m_codec.m_decode_buf_size == 0L)
																																															{
																																																goto IL_8def;
																																															}
																																															num12 = ((lzham_lzham_decompressor*)ptr)->m_match_len;
																																															num13 = ((lzham_lzham_decompressor*)ptr)->m_match_slot;
																																															num2 = ((lzham_lzham_decompressor*)ptr)->m_match_hist0;
																																															num3 = ((lzham_lzham_decompressor*)ptr)->m_match_hist1;
																																															num4 = ((lzham_lzham_decompressor*)ptr)->m_match_hist2;
																																															num5 = ((lzham_lzham_decompressor*)ptr)->m_match_hist3;
																																															num6 = ((lzham_lzham_decompressor*)ptr)->m_cur_state;
																																															num7 = ((lzham_lzham_decompressor*)ptr)->m_dst_ofs;
																																															num8 = ((lzham_symbol_codec*)codec)->m_arith_value;
																																															num9 = ((lzham_symbol_codec*)codec)->m_arith_length;
																																															num10 = ((lzham_symbol_codec*)codec)->m_bit_buf;
																																															num11 = ((lzham_symbol_codec*)codec)->m_bit_count;
																																															ptr3 = ((lzham_symbol_codec*)codec)->m_pDecode_buf_next;
																																															goto IL_8f2a;
																																														}
																																														decode_set_input_buffer.Invoke(&((lzham_lzham_decompressor*)ptr)->m_codec, eof_flag: (((lzham_lzham_decompressor*)ptr)->m_no_more_input_bytes_flag & 1) == 1, pBuf_next: ((lzham_lzham_decompressor*)ptr)->m_pIn_buf, buf_size: *(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size, pBuf: ((lzham_lzham_decompressor*)ptr)->m_pIn_buf);
																																														if ((((lzham_lzham_decompressor*)ptr)->m_codec.m_decode_buf_eof & 1) != 1 && ((lzham_lzham_decompressor*)ptr)->m_codec.m_decode_buf_size == 0L)
																																														{
																																															goto IL_8ad4;
																																														}
																																														num12 = ((lzham_lzham_decompressor*)ptr)->m_match_len;
																																														num13 = ((lzham_lzham_decompressor*)ptr)->m_match_slot;
																																														num2 = ((lzham_lzham_decompressor*)ptr)->m_match_hist0;
																																														num3 = ((lzham_lzham_decompressor*)ptr)->m_match_hist1;
																																														num4 = ((lzham_lzham_decompressor*)ptr)->m_match_hist2;
																																														num5 = ((lzham_lzham_decompressor*)ptr)->m_match_hist3;
																																														num6 = ((lzham_lzham_decompressor*)ptr)->m_cur_state;
																																														num7 = ((lzham_lzham_decompressor*)ptr)->m_dst_ofs;
																																														num8 = ((lzham_symbol_codec*)codec)->m_arith_value;
																																														num9 = ((lzham_symbol_codec*)codec)->m_arith_length;
																																														num10 = ((lzham_symbol_codec*)codec)->m_bit_buf;
																																														num11 = ((lzham_symbol_codec*)codec)->m_bit_count;
																																														ptr3 = ((lzham_symbol_codec*)codec)->m_pDecode_buf_next;
																																														goto IL_8c0f;
																																													}
																																													decode_set_input_buffer.Invoke(&((lzham_lzham_decompressor*)ptr)->m_codec, eof_flag: (((lzham_lzham_decompressor*)ptr)->m_no_more_input_bytes_flag & 1) == 1, pBuf_next: ((lzham_lzham_decompressor*)ptr)->m_pIn_buf, buf_size: *(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size, pBuf: ((lzham_lzham_decompressor*)ptr)->m_pIn_buf);
																																													if ((((lzham_lzham_decompressor*)ptr)->m_codec.m_decode_buf_eof & 1) != 1 && ((lzham_lzham_decompressor*)ptr)->m_codec.m_decode_buf_size == 0L)
																																													{
																																														goto IL_860a;
																																													}
																																													num12 = ((lzham_lzham_decompressor*)ptr)->m_match_len;
																																													num13 = ((lzham_lzham_decompressor*)ptr)->m_match_slot;
																																													num2 = ((lzham_lzham_decompressor*)ptr)->m_match_hist0;
																																													num3 = ((lzham_lzham_decompressor*)ptr)->m_match_hist1;
																																													num4 = ((lzham_lzham_decompressor*)ptr)->m_match_hist2;
																																													num5 = ((lzham_lzham_decompressor*)ptr)->m_match_hist3;
																																													num6 = ((lzham_lzham_decompressor*)ptr)->m_cur_state;
																																													num7 = ((lzham_lzham_decompressor*)ptr)->m_dst_ofs;
																																													num8 = ((lzham_symbol_codec*)codec)->m_arith_value;
																																													num9 = ((lzham_symbol_codec*)codec)->m_arith_length;
																																													num10 = ((lzham_symbol_codec*)codec)->m_bit_buf;
																																													num11 = ((lzham_symbol_codec*)codec)->m_bit_count;
																																													ptr3 = ((lzham_symbol_codec*)codec)->m_pDecode_buf_next;
																																													ptr5 = ((lzham_symbol_codec*)codec)->m_pSaved_huff_model;
																																													pDecode_tables2 = ((lzham_raw_quasi_adaptive_huffman_data_model*)ptr5)->m_pDecode_tables;
																																													goto IL_8757;
																																												}
																																												decode_set_input_buffer.Invoke(&((lzham_lzham_decompressor*)ptr)->m_codec, eof_flag: (((lzham_lzham_decompressor*)ptr)->m_no_more_input_bytes_flag & 1) == 1, pBuf_next: ((lzham_lzham_decompressor*)ptr)->m_pIn_buf, buf_size: *(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size, pBuf: ((lzham_lzham_decompressor*)ptr)->m_pIn_buf);
																																												if ((((lzham_lzham_decompressor*)ptr)->m_codec.m_decode_buf_eof & 1) != 1 && ((lzham_lzham_decompressor*)ptr)->m_codec.m_decode_buf_size == 0L)
																																												{
																																													goto IL_80b2;
																																												}
																																												num12 = ((lzham_lzham_decompressor*)ptr)->m_match_len;
																																												num2 = ((lzham_lzham_decompressor*)ptr)->m_match_hist0;
																																												num3 = ((lzham_lzham_decompressor*)ptr)->m_match_hist1;
																																												num4 = ((lzham_lzham_decompressor*)ptr)->m_match_hist2;
																																												num5 = ((lzham_lzham_decompressor*)ptr)->m_match_hist3;
																																												num6 = ((lzham_lzham_decompressor*)ptr)->m_cur_state;
																																												num7 = ((lzham_lzham_decompressor*)ptr)->m_dst_ofs;
																																												num8 = ((lzham_symbol_codec*)codec)->m_arith_value;
																																												num9 = ((lzham_symbol_codec*)codec)->m_arith_length;
																																												num10 = ((lzham_symbol_codec*)codec)->m_bit_buf;
																																												num11 = ((lzham_symbol_codec*)codec)->m_bit_count;
																																												ptr3 = ((lzham_symbol_codec*)codec)->m_pDecode_buf_next;
																																												ptr6 = ((lzham_symbol_codec*)codec)->m_pSaved_huff_model;
																																												pDecode_tables3 = ((lzham_raw_quasi_adaptive_huffman_data_model*)ptr6)->m_pDecode_tables;
																																												goto IL_81f6;
																																											}
																																											decode_set_input_buffer.Invoke(&((lzham_lzham_decompressor*)ptr)->m_codec, eof_flag: (((lzham_lzham_decompressor*)ptr)->m_no_more_input_bytes_flag & 1) == 1, pBuf_next: ((lzham_lzham_decompressor*)ptr)->m_pIn_buf, buf_size: *(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size, pBuf: ((lzham_lzham_decompressor*)ptr)->m_pIn_buf);
																																											if ((((lzham_lzham_decompressor*)ptr)->m_codec.m_decode_buf_eof & 1) != 1 && ((lzham_lzham_decompressor*)ptr)->m_codec.m_decode_buf_size == 0L)
																																											{
																																												goto IL_7c64;
																																											}
																																											num12 = ((lzham_lzham_decompressor*)ptr)->m_match_len;
																																											num2 = ((lzham_lzham_decompressor*)ptr)->m_match_hist0;
																																											num3 = ((lzham_lzham_decompressor*)ptr)->m_match_hist1;
																																											num4 = ((lzham_lzham_decompressor*)ptr)->m_match_hist2;
																																											num5 = ((lzham_lzham_decompressor*)ptr)->m_match_hist3;
																																											num6 = ((lzham_lzham_decompressor*)ptr)->m_cur_state;
																																											num7 = ((lzham_lzham_decompressor*)ptr)->m_dst_ofs;
																																											num8 = ((lzham_symbol_codec*)codec)->m_arith_value;
																																											num9 = ((lzham_symbol_codec*)codec)->m_arith_length;
																																											num10 = ((lzham_symbol_codec*)codec)->m_bit_buf;
																																											num11 = ((lzham_symbol_codec*)codec)->m_bit_count;
																																											ptr3 = ((lzham_symbol_codec*)codec)->m_pDecode_buf_next;
																																											goto IL_7d96;
																																										}
																																										decode_set_input_buffer.Invoke(&((lzham_lzham_decompressor*)ptr)->m_codec, eof_flag: (((lzham_lzham_decompressor*)ptr)->m_no_more_input_bytes_flag & 1) == 1, pBuf_next: ((lzham_lzham_decompressor*)ptr)->m_pIn_buf, buf_size: *(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size, pBuf: ((lzham_lzham_decompressor*)ptr)->m_pIn_buf);
																																										if ((((lzham_lzham_decompressor*)ptr)->m_codec.m_decode_buf_eof & 1) != 1 && ((lzham_lzham_decompressor*)ptr)->m_codec.m_decode_buf_size == 0L)
																																										{
																																											goto IL_7862;
																																										}
																																										num12 = ((lzham_lzham_decompressor*)ptr)->m_match_len;
																																										num2 = ((lzham_lzham_decompressor*)ptr)->m_match_hist0;
																																										num3 = ((lzham_lzham_decompressor*)ptr)->m_match_hist1;
																																										num4 = ((lzham_lzham_decompressor*)ptr)->m_match_hist2;
																																										num5 = ((lzham_lzham_decompressor*)ptr)->m_match_hist3;
																																										num6 = ((lzham_lzham_decompressor*)ptr)->m_cur_state;
																																										num7 = ((lzham_lzham_decompressor*)ptr)->m_dst_ofs;
																																										num8 = ((lzham_symbol_codec*)codec)->m_arith_value;
																																										num9 = ((lzham_symbol_codec*)codec)->m_arith_length;
																																										num10 = ((lzham_symbol_codec*)codec)->m_bit_buf;
																																										num11 = ((lzham_symbol_codec*)codec)->m_bit_count;
																																										ptr3 = ((lzham_symbol_codec*)codec)->m_pDecode_buf_next;
																																										goto IL_7994;
																																									}
																																									decode_set_input_buffer.Invoke(&((lzham_lzham_decompressor*)ptr)->m_codec, eof_flag: (((lzham_lzham_decompressor*)ptr)->m_no_more_input_bytes_flag & 1) == 1, pBuf_next: ((lzham_lzham_decompressor*)ptr)->m_pIn_buf, buf_size: *(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size, pBuf: ((lzham_lzham_decompressor*)ptr)->m_pIn_buf);
																																									if ((((lzham_lzham_decompressor*)ptr)->m_codec.m_decode_buf_eof & 1) != 1 && ((lzham_lzham_decompressor*)ptr)->m_codec.m_decode_buf_size == 0L)
																																									{
																																										goto IL_74c9;
																																									}
																																									num12 = ((lzham_lzham_decompressor*)ptr)->m_match_len;
																																									num2 = ((lzham_lzham_decompressor*)ptr)->m_match_hist0;
																																									num3 = ((lzham_lzham_decompressor*)ptr)->m_match_hist1;
																																									num4 = ((lzham_lzham_decompressor*)ptr)->m_match_hist2;
																																									num5 = ((lzham_lzham_decompressor*)ptr)->m_match_hist3;
																																									num6 = ((lzham_lzham_decompressor*)ptr)->m_cur_state;
																																									num7 = ((lzham_lzham_decompressor*)ptr)->m_dst_ofs;
																																									num8 = ((lzham_symbol_codec*)codec)->m_arith_value;
																																									num9 = ((lzham_symbol_codec*)codec)->m_arith_length;
																																									num10 = ((lzham_symbol_codec*)codec)->m_bit_buf;
																																									num11 = ((lzham_symbol_codec*)codec)->m_bit_count;
																																									ptr3 = ((lzham_symbol_codec*)codec)->m_pDecode_buf_next;
																																									goto IL_75fb;
																																								}
																																								decode_set_input_buffer.Invoke(&((lzham_lzham_decompressor*)ptr)->m_codec, eof_flag: (((lzham_lzham_decompressor*)ptr)->m_no_more_input_bytes_flag & 1) == 1, pBuf_next: ((lzham_lzham_decompressor*)ptr)->m_pIn_buf, buf_size: *(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size, pBuf: ((lzham_lzham_decompressor*)ptr)->m_pIn_buf);
																																								if ((((lzham_lzham_decompressor*)ptr)->m_codec.m_decode_buf_eof & 1) != 1 && ((lzham_lzham_decompressor*)ptr)->m_codec.m_decode_buf_size == 0L)
																																								{
																																									goto IL_71c8;
																																								}
																																								num12 = ((lzham_lzham_decompressor*)ptr)->m_match_len;
																																								num2 = ((lzham_lzham_decompressor*)ptr)->m_match_hist0;
																																								num3 = ((lzham_lzham_decompressor*)ptr)->m_match_hist1;
																																								num4 = ((lzham_lzham_decompressor*)ptr)->m_match_hist2;
																																								num5 = ((lzham_lzham_decompressor*)ptr)->m_match_hist3;
																																								num6 = ((lzham_lzham_decompressor*)ptr)->m_cur_state;
																																								num7 = ((lzham_lzham_decompressor*)ptr)->m_dst_ofs;
																																								num8 = ((lzham_symbol_codec*)codec)->m_arith_value;
																																								num9 = ((lzham_symbol_codec*)codec)->m_arith_length;
																																								num10 = ((lzham_symbol_codec*)codec)->m_bit_buf;
																																								num11 = ((lzham_symbol_codec*)codec)->m_bit_count;
																																								ptr3 = ((lzham_symbol_codec*)codec)->m_pDecode_buf_next;
																																								goto IL_72fa;
																																							}
																																							decode_set_input_buffer.Invoke(&((lzham_lzham_decompressor*)ptr)->m_codec, eof_flag: (((lzham_lzham_decompressor*)ptr)->m_no_more_input_bytes_flag & 1) == 1, pBuf_next: ((lzham_lzham_decompressor*)ptr)->m_pIn_buf, buf_size: *(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size, pBuf: ((lzham_lzham_decompressor*)ptr)->m_pIn_buf);
																																							if ((((lzham_lzham_decompressor*)ptr)->m_codec.m_decode_buf_eof & 1) != 1 && ((lzham_lzham_decompressor*)ptr)->m_codec.m_decode_buf_size == 0L)
																																							{
																																								goto IL_6d21;
																																							}
																																							num12 = ((lzham_lzham_decompressor*)ptr)->m_match_len;
																																							num2 = ((lzham_lzham_decompressor*)ptr)->m_match_hist0;
																																							num3 = ((lzham_lzham_decompressor*)ptr)->m_match_hist1;
																																							num4 = ((lzham_lzham_decompressor*)ptr)->m_match_hist2;
																																							num5 = ((lzham_lzham_decompressor*)ptr)->m_match_hist3;
																																							num6 = ((lzham_lzham_decompressor*)ptr)->m_cur_state;
																																							num7 = ((lzham_lzham_decompressor*)ptr)->m_dst_ofs;
																																							num8 = ((lzham_symbol_codec*)codec)->m_arith_value;
																																							num9 = ((lzham_symbol_codec*)codec)->m_arith_length;
																																							num10 = ((lzham_symbol_codec*)codec)->m_bit_buf;
																																							num11 = ((lzham_symbol_codec*)codec)->m_bit_count;
																																							ptr3 = ((lzham_symbol_codec*)codec)->m_pDecode_buf_next;
																																							ptr7 = ((lzham_symbol_codec*)codec)->m_pSaved_huff_model;
																																							pDecode_tables4 = ((lzham_raw_quasi_adaptive_huffman_data_model*)ptr7)->m_pDecode_tables;
																																							goto IL_6e65;
																																						}
																																						decode_set_input_buffer.Invoke(&((lzham_lzham_decompressor*)ptr)->m_codec, eof_flag: (((lzham_lzham_decompressor*)ptr)->m_no_more_input_bytes_flag & 1) == 1, pBuf_next: ((lzham_lzham_decompressor*)ptr)->m_pIn_buf, buf_size: *(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size, pBuf: ((lzham_lzham_decompressor*)ptr)->m_pIn_buf);
																																						if ((((lzham_lzham_decompressor*)ptr)->m_codec.m_decode_buf_eof & 1) != 1 && ((lzham_lzham_decompressor*)ptr)->m_codec.m_decode_buf_size == 0L)
																																						{
																																							goto IL_6931;
																																						}
																																						num12 = ((lzham_lzham_decompressor*)ptr)->m_match_len;
																																						num2 = ((lzham_lzham_decompressor*)ptr)->m_match_hist0;
																																						num3 = ((lzham_lzham_decompressor*)ptr)->m_match_hist1;
																																						num4 = ((lzham_lzham_decompressor*)ptr)->m_match_hist2;
																																						num5 = ((lzham_lzham_decompressor*)ptr)->m_match_hist3;
																																						num6 = ((lzham_lzham_decompressor*)ptr)->m_cur_state;
																																						num7 = ((lzham_lzham_decompressor*)ptr)->m_dst_ofs;
																																						num8 = ((lzham_symbol_codec*)codec)->m_arith_value;
																																						num9 = ((lzham_symbol_codec*)codec)->m_arith_length;
																																						num10 = ((lzham_symbol_codec*)codec)->m_bit_buf;
																																						num11 = ((lzham_symbol_codec*)codec)->m_bit_count;
																																						ptr3 = ((lzham_symbol_codec*)codec)->m_pDecode_buf_next;
																																						goto IL_6a63;
																																					}
																																					decode_set_input_buffer.Invoke(&((lzham_lzham_decompressor*)ptr)->m_codec, eof_flag: (((lzham_lzham_decompressor*)ptr)->m_no_more_input_bytes_flag & 1) == 1, pBuf_next: ((lzham_lzham_decompressor*)ptr)->m_pIn_buf, buf_size: *(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size, pBuf: ((lzham_lzham_decompressor*)ptr)->m_pIn_buf);
																																					if ((((lzham_lzham_decompressor*)ptr)->m_codec.m_decode_buf_eof & 1) != 1 && ((lzham_lzham_decompressor*)ptr)->m_codec.m_decode_buf_size == 0L)
																																					{
																																						goto IL_6630;
																																					}
																																					num12 = ((lzham_lzham_decompressor*)ptr)->m_match_len;
																																					num2 = ((lzham_lzham_decompressor*)ptr)->m_match_hist0;
																																					num3 = ((lzham_lzham_decompressor*)ptr)->m_match_hist1;
																																					num4 = ((lzham_lzham_decompressor*)ptr)->m_match_hist2;
																																					num5 = ((lzham_lzham_decompressor*)ptr)->m_match_hist3;
																																					num6 = ((lzham_lzham_decompressor*)ptr)->m_cur_state;
																																					num7 = ((lzham_lzham_decompressor*)ptr)->m_dst_ofs;
																																					num8 = ((lzham_symbol_codec*)codec)->m_arith_value;
																																					num9 = ((lzham_symbol_codec*)codec)->m_arith_length;
																																					num10 = ((lzham_symbol_codec*)codec)->m_bit_buf;
																																					num11 = ((lzham_symbol_codec*)codec)->m_bit_count;
																																					ptr3 = ((lzham_symbol_codec*)codec)->m_pDecode_buf_next;
																																					goto IL_6762;
																																				}
																																				decode_set_input_buffer.Invoke(&((lzham_lzham_decompressor*)ptr)->m_codec, eof_flag: (((lzham_lzham_decompressor*)ptr)->m_no_more_input_bytes_flag & 1) == 1, pBuf_next: ((lzham_lzham_decompressor*)ptr)->m_pIn_buf, buf_size: *(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size, pBuf: ((lzham_lzham_decompressor*)ptr)->m_pIn_buf);
																																				if ((((lzham_lzham_decompressor*)ptr)->m_codec.m_decode_buf_eof & 1) != 1 && ((lzham_lzham_decompressor*)ptr)->m_codec.m_decode_buf_size == 0L)
																																				{
																																					goto IL_6189;
																																				}
																																				num12 = ((lzham_lzham_decompressor*)ptr)->m_match_len;
																																				num2 = ((lzham_lzham_decompressor*)ptr)->m_match_hist0;
																																				num3 = ((lzham_lzham_decompressor*)ptr)->m_match_hist1;
																																				num4 = ((lzham_lzham_decompressor*)ptr)->m_match_hist2;
																																				num5 = ((lzham_lzham_decompressor*)ptr)->m_match_hist3;
																																				num6 = ((lzham_lzham_decompressor*)ptr)->m_cur_state;
																																				num7 = ((lzham_lzham_decompressor*)ptr)->m_dst_ofs;
																																				num8 = ((lzham_symbol_codec*)codec)->m_arith_value;
																																				num9 = ((lzham_symbol_codec*)codec)->m_arith_length;
																																				num10 = ((lzham_symbol_codec*)codec)->m_bit_buf;
																																				num11 = ((lzham_symbol_codec*)codec)->m_bit_count;
																																				ptr3 = ((lzham_symbol_codec*)codec)->m_pDecode_buf_next;
																																				ptr8 = ((lzham_symbol_codec*)codec)->m_pSaved_huff_model;
																																				pDecode_tables5 = ((lzham_raw_quasi_adaptive_huffman_data_model*)ptr8)->m_pDecode_tables;
																																				goto IL_62cd;
																																			}
																																			decode_set_input_buffer.Invoke(&((lzham_lzham_decompressor*)ptr)->m_codec, eof_flag: (((lzham_lzham_decompressor*)ptr)->m_no_more_input_bytes_flag & 1) == 1, pBuf_next: ((lzham_lzham_decompressor*)ptr)->m_pIn_buf, buf_size: *(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size, pBuf: ((lzham_lzham_decompressor*)ptr)->m_pIn_buf);
																																			if ((((lzham_lzham_decompressor*)ptr)->m_codec.m_decode_buf_eof & 1) != 1 && ((lzham_lzham_decompressor*)ptr)->m_codec.m_decode_buf_size == 0L)
																																			{
																																				goto IL_5d42;
																																			}
																																			num12 = ((lzham_lzham_decompressor*)ptr)->m_match_len;
																																			num2 = ((lzham_lzham_decompressor*)ptr)->m_match_hist0;
																																			num3 = ((lzham_lzham_decompressor*)ptr)->m_match_hist1;
																																			num4 = ((lzham_lzham_decompressor*)ptr)->m_match_hist2;
																																			num5 = ((lzham_lzham_decompressor*)ptr)->m_match_hist3;
																																			num6 = ((lzham_lzham_decompressor*)ptr)->m_cur_state;
																																			num7 = ((lzham_lzham_decompressor*)ptr)->m_dst_ofs;
																																			num8 = ((lzham_symbol_codec*)codec)->m_arith_value;
																																			num9 = ((lzham_symbol_codec*)codec)->m_arith_length;
																																			num10 = ((lzham_symbol_codec*)codec)->m_bit_buf;
																																			num11 = ((lzham_symbol_codec*)codec)->m_bit_count;
																																			ptr3 = ((lzham_symbol_codec*)codec)->m_pDecode_buf_next;
																																			goto IL_5e74;
																																		}
																																		decode_set_input_buffer.Invoke(&((lzham_lzham_decompressor*)ptr)->m_codec, eof_flag: (((lzham_lzham_decompressor*)ptr)->m_no_more_input_bytes_flag & 1) == 1, pBuf_next: ((lzham_lzham_decompressor*)ptr)->m_pIn_buf, buf_size: *(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size, pBuf: ((lzham_lzham_decompressor*)ptr)->m_pIn_buf);
																																		if ((((lzham_lzham_decompressor*)ptr)->m_codec.m_decode_buf_eof & 1) != 1 && ((lzham_lzham_decompressor*)ptr)->m_codec.m_decode_buf_size == 0L)
																																		{
																																			goto IL_594e;
																																		}
																																		num12 = ((lzham_lzham_decompressor*)ptr)->m_match_len;
																																		num2 = ((lzham_lzham_decompressor*)ptr)->m_match_hist0;
																																		num3 = ((lzham_lzham_decompressor*)ptr)->m_match_hist1;
																																		num4 = ((lzham_lzham_decompressor*)ptr)->m_match_hist2;
																																		num5 = ((lzham_lzham_decompressor*)ptr)->m_match_hist3;
																																		num6 = ((lzham_lzham_decompressor*)ptr)->m_cur_state;
																																		num7 = ((lzham_lzham_decompressor*)ptr)->m_dst_ofs;
																																		num8 = ((lzham_symbol_codec*)codec)->m_arith_value;
																																		num9 = ((lzham_symbol_codec*)codec)->m_arith_length;
																																		num10 = ((lzham_symbol_codec*)codec)->m_bit_buf;
																																		num11 = ((lzham_symbol_codec*)codec)->m_bit_count;
																																		ptr3 = ((lzham_symbol_codec*)codec)->m_pDecode_buf_next;
																																		goto IL_5a80;
																																	}
																																	decode_set_input_buffer.Invoke(&((lzham_lzham_decompressor*)ptr)->m_codec, eof_flag: (((lzham_lzham_decompressor*)ptr)->m_no_more_input_bytes_flag & 1) == 1, pBuf_next: ((lzham_lzham_decompressor*)ptr)->m_pIn_buf, buf_size: *(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size, pBuf: ((lzham_lzham_decompressor*)ptr)->m_pIn_buf);
																																	if ((((lzham_lzham_decompressor*)ptr)->m_codec.m_decode_buf_eof & 1) != 1 && ((lzham_lzham_decompressor*)ptr)->m_codec.m_decode_buf_size == 0L)
																																	{
																																		goto IL_555a;
																																	}
																																	num12 = ((lzham_lzham_decompressor*)ptr)->m_match_len;
																																	num2 = ((lzham_lzham_decompressor*)ptr)->m_match_hist0;
																																	num3 = ((lzham_lzham_decompressor*)ptr)->m_match_hist1;
																																	num4 = ((lzham_lzham_decompressor*)ptr)->m_match_hist2;
																																	num5 = ((lzham_lzham_decompressor*)ptr)->m_match_hist3;
																																	num6 = ((lzham_lzham_decompressor*)ptr)->m_cur_state;
																																	num7 = ((lzham_lzham_decompressor*)ptr)->m_dst_ofs;
																																	num8 = ((lzham_symbol_codec*)codec)->m_arith_value;
																																	num9 = ((lzham_symbol_codec*)codec)->m_arith_length;
																																	num10 = ((lzham_symbol_codec*)codec)->m_bit_buf;
																																	num11 = ((lzham_symbol_codec*)codec)->m_bit_count;
																																	ptr3 = ((lzham_symbol_codec*)codec)->m_pDecode_buf_next;
																																	goto IL_568c;
																																}
																																decode_set_input_buffer.Invoke(&((lzham_lzham_decompressor*)ptr)->m_codec, eof_flag: (((lzham_lzham_decompressor*)ptr)->m_no_more_input_bytes_flag & 1) == 1, pBuf_next: ((lzham_lzham_decompressor*)ptr)->m_pIn_buf, buf_size: *(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size, pBuf: ((lzham_lzham_decompressor*)ptr)->m_pIn_buf);
																																long flush_n5 = ((lzham_lzham_decompressor*)ptr)->m_flush_n;
																																void** pFlush_src3 = &((lzham_lzham_decompressor*)ptr)->m_pFlush_src;
																																*pFlush_src3 = (byte*)(*pFlush_src3) + flush_n5;
																																long flush_n6 = ((lzham_lzham_decompressor*)ptr)->m_flush_n;
																																((lzham_lzham_decompressor*)ptr)->m_flush_num_bytes_remaining -= flush_n6;
																																goto IL_514a;
																															}
																															decode_set_input_buffer.Invoke(&((lzham_lzham_decompressor*)ptr)->m_codec, eof_flag: (((lzham_lzham_decompressor*)ptr)->m_no_more_input_bytes_flag & 1) == 1, pBuf_next: ((lzham_lzham_decompressor*)ptr)->m_pIn_buf, buf_size: *(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size, pBuf: ((lzham_lzham_decompressor*)ptr)->m_pIn_buf);
																															if ((((lzham_lzham_decompressor*)ptr)->m_codec.m_decode_buf_eof & 1) != 1 && ((lzham_lzham_decompressor*)ptr)->m_codec.m_decode_buf_size == 0L)
																															{
																																goto IL_4c41;
																															}
																															num16 = ((lzham_lzham_decompressor*)ptr)->m_rep_lit0;
																															num2 = ((lzham_lzham_decompressor*)ptr)->m_match_hist0;
																															num3 = ((lzham_lzham_decompressor*)ptr)->m_match_hist1;
																															num4 = ((lzham_lzham_decompressor*)ptr)->m_match_hist2;
																															num5 = ((lzham_lzham_decompressor*)ptr)->m_match_hist3;
																															num6 = ((lzham_lzham_decompressor*)ptr)->m_cur_state;
																															num7 = ((lzham_lzham_decompressor*)ptr)->m_dst_ofs;
																															num8 = ((lzham_symbol_codec*)codec)->m_arith_value;
																															num9 = ((lzham_symbol_codec*)codec)->m_arith_length;
																															num10 = ((lzham_symbol_codec*)codec)->m_bit_buf;
																															num11 = ((lzham_symbol_codec*)codec)->m_bit_count;
																															ptr3 = ((lzham_symbol_codec*)codec)->m_pDecode_buf_next;
																															ptr9 = ((lzham_symbol_codec*)codec)->m_pSaved_huff_model;
																															pDecode_tables6 = ((lzham_raw_quasi_adaptive_huffman_data_model*)ptr9)->m_pDecode_tables;
																															goto IL_4d85;
																														}
																														decode_set_input_buffer.Invoke(&((lzham_lzham_decompressor*)ptr)->m_codec, eof_flag: (((lzham_lzham_decompressor*)ptr)->m_no_more_input_bytes_flag & 1) == 1, pBuf_next: ((lzham_lzham_decompressor*)ptr)->m_pIn_buf, buf_size: *(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size, pBuf: ((lzham_lzham_decompressor*)ptr)->m_pIn_buf);
																														if ((((lzham_lzham_decompressor*)ptr)->m_codec.m_decode_buf_eof & 1) != 1 && ((lzham_lzham_decompressor*)ptr)->m_codec.m_decode_buf_size == 0L)
																														{
																															goto IL_4747;
																														}
																														num2 = ((lzham_lzham_decompressor*)ptr)->m_match_hist0;
																														num3 = ((lzham_lzham_decompressor*)ptr)->m_match_hist1;
																														num4 = ((lzham_lzham_decompressor*)ptr)->m_match_hist2;
																														num5 = ((lzham_lzham_decompressor*)ptr)->m_match_hist3;
																														num6 = ((lzham_lzham_decompressor*)ptr)->m_cur_state;
																														num7 = ((lzham_lzham_decompressor*)ptr)->m_dst_ofs;
																														num8 = ((lzham_symbol_codec*)codec)->m_arith_value;
																														num9 = ((lzham_symbol_codec*)codec)->m_arith_length;
																														num10 = ((lzham_symbol_codec*)codec)->m_bit_buf;
																														num11 = ((lzham_symbol_codec*)codec)->m_bit_count;
																														ptr3 = ((lzham_symbol_codec*)codec)->m_pDecode_buf_next;
																														ptr10 = ((lzham_symbol_codec*)codec)->m_pSaved_huff_model;
																														pDecode_tables7 = ((lzham_raw_quasi_adaptive_huffman_data_model*)ptr10)->m_pDecode_tables;
																														goto IL_4882;
																													}
																													goto IL_45ec;
																												}
																												decode_set_input_buffer.Invoke(&((lzham_lzham_decompressor*)ptr)->m_codec, eof_flag: (((lzham_lzham_decompressor*)ptr)->m_no_more_input_bytes_flag & 1) == 1, pBuf_next: ((lzham_lzham_decompressor*)ptr)->m_pIn_buf, buf_size: *(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size, pBuf: ((lzham_lzham_decompressor*)ptr)->m_pIn_buf);
																												if ((((lzham_lzham_decompressor*)ptr)->m_codec.m_decode_buf_eof & 1) != 1 && ((lzham_lzham_decompressor*)ptr)->m_codec.m_decode_buf_size == 0L)
																												{
																													goto IL_42a8;
																												}
																												num2 = ((lzham_lzham_decompressor*)ptr)->m_match_hist0;
																												num3 = ((lzham_lzham_decompressor*)ptr)->m_match_hist1;
																												num4 = ((lzham_lzham_decompressor*)ptr)->m_match_hist2;
																												num5 = ((lzham_lzham_decompressor*)ptr)->m_match_hist3;
																												num6 = ((lzham_lzham_decompressor*)ptr)->m_cur_state;
																												num7 = ((lzham_lzham_decompressor*)ptr)->m_dst_ofs;
																												num8 = ((lzham_symbol_codec*)codec)->m_arith_value;
																												num9 = ((lzham_symbol_codec*)codec)->m_arith_length;
																												num10 = ((lzham_symbol_codec*)codec)->m_bit_buf;
																												num11 = ((lzham_symbol_codec*)codec)->m_bit_count;
																												ptr3 = ((lzham_symbol_codec*)codec)->m_pDecode_buf_next;
																												goto IL_43d1;
																											}
																											decode_set_input_buffer.Invoke(&((lzham_lzham_decompressor*)ptr)->m_codec, eof_flag: (((lzham_lzham_decompressor*)ptr)->m_no_more_input_bytes_flag & 1) == 1, pBuf_next: ((lzham_lzham_decompressor*)ptr)->m_pIn_buf, buf_size: *(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size, pBuf: ((lzham_lzham_decompressor*)ptr)->m_pIn_buf);
																											if ((((lzham_lzham_decompressor*)ptr)->m_codec.m_decode_buf_eof & 1) != 1 && ((lzham_lzham_decompressor*)ptr)->m_codec.m_decode_buf_size == 0L)
																											{
																												goto IL_3f89;
																											}
																											num2 = ((lzham_lzham_decompressor*)ptr)->m_match_hist0;
																											num3 = ((lzham_lzham_decompressor*)ptr)->m_match_hist1;
																											num4 = ((lzham_lzham_decompressor*)ptr)->m_match_hist2;
																											num5 = ((lzham_lzham_decompressor*)ptr)->m_match_hist3;
																											num6 = ((lzham_lzham_decompressor*)ptr)->m_cur_state;
																											num7 = ((lzham_lzham_decompressor*)ptr)->m_dst_ofs;
																											num8 = ((lzham_symbol_codec*)codec)->m_arith_value;
																											num9 = ((lzham_symbol_codec*)codec)->m_arith_length;
																											num10 = ((lzham_symbol_codec*)codec)->m_bit_buf;
																											num11 = ((lzham_symbol_codec*)codec)->m_bit_count;
																											ptr3 = ((lzham_symbol_codec*)codec)->m_pDecode_buf_next;
																											goto IL_40b2;
																										}
																										decode_set_input_buffer.Invoke(&((lzham_lzham_decompressor*)ptr)->m_codec, eof_flag: (((lzham_lzham_decompressor*)ptr)->m_no_more_input_bytes_flag & 1) == 1, pBuf_next: ((lzham_lzham_decompressor*)ptr)->m_pIn_buf, buf_size: *(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size, pBuf: ((lzham_lzham_decompressor*)ptr)->m_pIn_buf);
																										if ((((lzham_lzham_decompressor*)ptr)->m_codec.m_decode_buf_eof & 1) != 1 && ((lzham_lzham_decompressor*)ptr)->m_codec.m_decode_buf_size == 0L)
																										{
																											goto IL_3ca0;
																										}
																										num2 = ((lzham_lzham_decompressor*)ptr)->m_match_hist0;
																										num3 = ((lzham_lzham_decompressor*)ptr)->m_match_hist1;
																										num4 = ((lzham_lzham_decompressor*)ptr)->m_match_hist2;
																										num5 = ((lzham_lzham_decompressor*)ptr)->m_match_hist3;
																										num6 = ((lzham_lzham_decompressor*)ptr)->m_cur_state;
																										num7 = ((lzham_lzham_decompressor*)ptr)->m_dst_ofs;
																										num8 = ((lzham_symbol_codec*)codec)->m_arith_value;
																										num9 = ((lzham_symbol_codec*)codec)->m_arith_length;
																										num10 = ((lzham_symbol_codec*)codec)->m_bit_buf;
																										num11 = ((lzham_symbol_codec*)codec)->m_bit_count;
																										ptr3 = ((lzham_symbol_codec*)codec)->m_pDecode_buf_next;
																										goto IL_3dc9;
																									}
																									decode_set_input_buffer.Invoke(&((lzham_lzham_decompressor*)ptr)->m_codec, eof_flag: (((lzham_lzham_decompressor*)ptr)->m_no_more_input_bytes_flag & 1) == 1, pBuf_next: ((lzham_lzham_decompressor*)ptr)->m_pIn_buf, buf_size: *(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size, pBuf: ((lzham_lzham_decompressor*)ptr)->m_pIn_buf);
																									long flush_n7 = ((lzham_lzham_decompressor*)ptr)->m_flush_n;
																									void** pFlush_src4 = &((lzham_lzham_decompressor*)ptr)->m_pFlush_src;
																									*pFlush_src4 = (byte*)(*pFlush_src4) + flush_n7;
																									long flush_n8 = ((lzham_lzham_decompressor*)ptr)->m_flush_n;
																									((lzham_lzham_decompressor*)ptr)->m_flush_num_bytes_remaining -= flush_n8;
																									goto IL_38aa;
																								}
																								goto IL_370b;
																							}
																							num17 = ((lzham_lzham_decompressor*)ptr)->m_num_raw_bytes_remaining;
																							num2 = ((lzham_lzham_decompressor*)ptr)->m_match_hist0;
																							num3 = ((lzham_lzham_decompressor*)ptr)->m_match_hist1;
																							num4 = ((lzham_lzham_decompressor*)ptr)->m_match_hist2;
																							num5 = ((lzham_lzham_decompressor*)ptr)->m_match_hist3;
																							num6 = ((lzham_lzham_decompressor*)ptr)->m_cur_state;
																							num7 = ((lzham_lzham_decompressor*)ptr)->m_dst_ofs;
																							decode_set_input_buffer.Invoke(&((lzham_lzham_decompressor*)ptr)->m_codec, eof_flag: (((lzham_lzham_decompressor*)ptr)->m_no_more_input_bytes_flag & 1) == 1, pBuf_next: ((lzham_lzham_decompressor*)ptr)->m_pIn_buf, buf_size: *(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size, pBuf: ((lzham_lzham_decompressor*)ptr)->m_pIn_buf);
																							num18 = 0L;
																							num19 = *(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size;
																							goto IL_3528;
																						}
																						goto IL_3578;
																					}
																					decode_set_input_buffer.Invoke(&((lzham_lzham_decompressor*)ptr)->m_codec, eof_flag: (((lzham_lzham_decompressor*)ptr)->m_no_more_input_bytes_flag & 1) == 1, pBuf_next: ((lzham_lzham_decompressor*)ptr)->m_pIn_buf, buf_size: *(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size, pBuf: ((lzham_lzham_decompressor*)ptr)->m_pIn_buf);
																					long flush_n9 = ((lzham_lzham_decompressor*)ptr)->m_flush_n;
																					void** pFlush_src5 = &((lzham_lzham_decompressor*)ptr)->m_pFlush_src;
																					*pFlush_src5 = (byte*)(*pFlush_src5) + flush_n9;
																					long flush_n10 = ((lzham_lzham_decompressor*)ptr)->m_flush_n;
																					((lzham_lzham_decompressor*)ptr)->m_flush_num_bytes_remaining -= flush_n10;
																					goto IL_31bc;
																				}
																				goto IL_3035;
																			}
																			decode_set_input_buffer.Invoke(&((lzham_lzham_decompressor*)ptr)->m_codec, eof_flag: (((lzham_lzham_decompressor*)ptr)->m_no_more_input_bytes_flag & 1) == 1, pBuf_next: ((lzham_lzham_decompressor*)ptr)->m_pIn_buf, buf_size: *(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size, pBuf: ((lzham_lzham_decompressor*)ptr)->m_pIn_buf);
																			if ((((lzham_lzham_decompressor*)ptr)->m_codec.m_decode_buf_eof & 1) != 1 && ((lzham_lzham_decompressor*)ptr)->m_codec.m_decode_buf_size == 0L)
																			{
																				goto IL_2d61;
																			}
																			num17 = ((lzham_lzham_decompressor*)ptr)->m_num_raw_bytes_remaining;
																			num2 = ((lzham_lzham_decompressor*)ptr)->m_match_hist0;
																			num3 = ((lzham_lzham_decompressor*)ptr)->m_match_hist1;
																			num4 = ((lzham_lzham_decompressor*)ptr)->m_match_hist2;
																			num5 = ((lzham_lzham_decompressor*)ptr)->m_match_hist3;
																			num6 = ((lzham_lzham_decompressor*)ptr)->m_cur_state;
																			num7 = ((lzham_lzham_decompressor*)ptr)->m_dst_ofs;
																			num8 = ((lzham_symbol_codec*)codec)->m_arith_value;
																			num9 = ((lzham_symbol_codec*)codec)->m_arith_length;
																			num10 = ((lzham_symbol_codec*)codec)->m_bit_buf;
																			num11 = ((lzham_symbol_codec*)codec)->m_bit_count;
																			ptr3 = ((lzham_symbol_codec*)codec)->m_pDecode_buf_next;
																			goto IL_2e93;
																		}
																		goto IL_2c2e;
																	}
																	decode_set_input_buffer.Invoke(&((lzham_lzham_decompressor*)ptr)->m_codec, eof_flag: (((lzham_lzham_decompressor*)ptr)->m_no_more_input_bytes_flag & 1) == 1, pBuf_next: ((lzham_lzham_decompressor*)ptr)->m_pIn_buf, buf_size: *(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size, pBuf: ((lzham_lzham_decompressor*)ptr)->m_pIn_buf);
																	if ((((lzham_lzham_decompressor*)ptr)->m_codec.m_decode_buf_eof & 1) != 1 && ((lzham_lzham_decompressor*)ptr)->m_codec.m_decode_buf_size == 0L)
																	{
																		goto IL_29ab;
																	}
																	num17 = ((lzham_lzham_decompressor*)ptr)->m_num_raw_bytes_remaining;
																	num2 = ((lzham_lzham_decompressor*)ptr)->m_match_hist0;
																	num3 = ((lzham_lzham_decompressor*)ptr)->m_match_hist1;
																	num4 = ((lzham_lzham_decompressor*)ptr)->m_match_hist2;
																	num5 = ((lzham_lzham_decompressor*)ptr)->m_match_hist3;
																	num6 = ((lzham_lzham_decompressor*)ptr)->m_cur_state;
																	num7 = ((lzham_lzham_decompressor*)ptr)->m_dst_ofs;
																	num8 = ((lzham_symbol_codec*)codec)->m_arith_value;
																	num9 = ((lzham_symbol_codec*)codec)->m_arith_length;
																	num10 = ((lzham_symbol_codec*)codec)->m_bit_buf;
																	num11 = ((lzham_symbol_codec*)codec)->m_bit_count;
																	ptr3 = ((lzham_symbol_codec*)codec)->m_pDecode_buf_next;
																	goto IL_2add;
																}
																decode_set_input_buffer.Invoke(&((lzham_lzham_decompressor*)ptr)->m_codec, eof_flag: (((lzham_lzham_decompressor*)ptr)->m_no_more_input_bytes_flag & 1) == 1, pBuf_next: ((lzham_lzham_decompressor*)ptr)->m_pIn_buf, buf_size: *(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size, pBuf: ((lzham_lzham_decompressor*)ptr)->m_pIn_buf);
																if ((((lzham_lzham_decompressor*)ptr)->m_codec.m_decode_buf_eof & 1) != 1 && ((lzham_lzham_decompressor*)ptr)->m_codec.m_decode_buf_size == 0L)
																{
																	goto IL_26e0;
																}
																num17 = ((lzham_lzham_decompressor*)ptr)->m_num_raw_bytes_remaining;
																num2 = ((lzham_lzham_decompressor*)ptr)->m_match_hist0;
																num3 = ((lzham_lzham_decompressor*)ptr)->m_match_hist1;
																num4 = ((lzham_lzham_decompressor*)ptr)->m_match_hist2;
																num5 = ((lzham_lzham_decompressor*)ptr)->m_match_hist3;
																num6 = ((lzham_lzham_decompressor*)ptr)->m_cur_state;
																num7 = ((lzham_lzham_decompressor*)ptr)->m_dst_ofs;
																num8 = ((lzham_symbol_codec*)codec)->m_arith_value;
																num9 = ((lzham_symbol_codec*)codec)->m_arith_length;
																num10 = ((lzham_symbol_codec*)codec)->m_bit_buf;
																num11 = ((lzham_symbol_codec*)codec)->m_bit_count;
																ptr3 = ((lzham_symbol_codec*)codec)->m_pDecode_buf_next;
																goto IL_2812;
															}
															num2 = ((lzham_lzham_decompressor*)ptr)->m_match_hist0;
															num3 = ((lzham_lzham_decompressor*)ptr)->m_match_hist1;
															num4 = ((lzham_lzham_decompressor*)ptr)->m_match_hist2;
															num5 = ((lzham_lzham_decompressor*)ptr)->m_match_hist3;
															num6 = ((lzham_lzham_decompressor*)ptr)->m_cur_state;
															num7 = ((lzham_lzham_decompressor*)ptr)->m_dst_ofs;
															decode_set_input_buffer.Invoke(&((lzham_lzham_decompressor*)ptr)->m_codec, eof_flag: (((lzham_lzham_decompressor*)ptr)->m_no_more_input_bytes_flag & 1) == 1, pBuf_next: ((lzham_lzham_decompressor*)ptr)->m_pIn_buf, buf_size: *(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size, pBuf: ((lzham_lzham_decompressor*)ptr)->m_pIn_buf);
															goto IL_2596;
														}
														decode_set_input_buffer.Invoke(&((lzham_lzham_decompressor*)ptr)->m_codec, eof_flag: (((lzham_lzham_decompressor*)ptr)->m_no_more_input_bytes_flag & 1) == 1, pBuf_next: ((lzham_lzham_decompressor*)ptr)->m_pIn_buf, buf_size: *(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size, pBuf: ((lzham_lzham_decompressor*)ptr)->m_pIn_buf);
														long flush_n11 = ((lzham_lzham_decompressor*)ptr)->m_flush_n;
														void** pFlush_src6 = &((lzham_lzham_decompressor*)ptr)->m_pFlush_src;
														*pFlush_src6 = (byte*)(*pFlush_src6) + flush_n11;
														long flush_n12 = ((lzham_lzham_decompressor*)ptr)->m_flush_n;
														((lzham_lzham_decompressor*)ptr)->m_flush_num_bytes_remaining -= flush_n12;
														goto IL_21b6;
													}
													goto IL_2041;
												}
												decode_set_input_buffer.Invoke(&((lzham_lzham_decompressor*)ptr)->m_codec, eof_flag: (((lzham_lzham_decompressor*)ptr)->m_no_more_input_bytes_flag & 1) == 1, pBuf_next: ((lzham_lzham_decompressor*)ptr)->m_pIn_buf, buf_size: *(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size, pBuf: ((lzham_lzham_decompressor*)ptr)->m_pIn_buf);
												if ((((lzham_lzham_decompressor*)ptr)->m_codec.m_decode_buf_eof & 1) != 1 && ((lzham_lzham_decompressor*)ptr)->m_codec.m_decode_buf_size == 0L)
												{
													goto IL_1dec;
												}
												num2 = ((lzham_lzham_decompressor*)ptr)->m_match_hist0;
												num3 = ((lzham_lzham_decompressor*)ptr)->m_match_hist1;
												num4 = ((lzham_lzham_decompressor*)ptr)->m_match_hist2;
												num5 = ((lzham_lzham_decompressor*)ptr)->m_match_hist3;
												num6 = ((lzham_lzham_decompressor*)ptr)->m_cur_state;
												num7 = ((lzham_lzham_decompressor*)ptr)->m_dst_ofs;
												num8 = ((lzham_symbol_codec*)codec)->m_arith_value;
												num9 = ((lzham_symbol_codec*)codec)->m_arith_length;
												num10 = ((lzham_symbol_codec*)codec)->m_bit_buf;
												num11 = ((lzham_symbol_codec*)codec)->m_bit_count;
												ptr3 = ((lzham_symbol_codec*)codec)->m_pDecode_buf_next;
												goto IL_1f15;
											}
											goto IL_1ce3;
										}
										decode_set_input_buffer.Invoke(&((lzham_lzham_decompressor*)ptr)->m_codec, eof_flag: (((lzham_lzham_decompressor*)ptr)->m_no_more_input_bytes_flag & 1) == 1, pBuf_next: ((lzham_lzham_decompressor*)ptr)->m_pIn_buf, buf_size: *(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size, pBuf: ((lzham_lzham_decompressor*)ptr)->m_pIn_buf);
										if ((((lzham_lzham_decompressor*)ptr)->m_codec.m_decode_buf_eof & 1) != 1 && ((lzham_lzham_decompressor*)ptr)->m_codec.m_decode_buf_size == 0L)
										{
											goto IL_1a92;
										}
										num2 = ((lzham_lzham_decompressor*)ptr)->m_match_hist0;
										num3 = ((lzham_lzham_decompressor*)ptr)->m_match_hist1;
										num4 = ((lzham_lzham_decompressor*)ptr)->m_match_hist2;
										num5 = ((lzham_lzham_decompressor*)ptr)->m_match_hist3;
										num6 = ((lzham_lzham_decompressor*)ptr)->m_cur_state;
										num7 = ((lzham_lzham_decompressor*)ptr)->m_dst_ofs;
										num8 = ((lzham_symbol_codec*)codec)->m_arith_value;
										num9 = ((lzham_symbol_codec*)codec)->m_arith_length;
										num10 = ((lzham_symbol_codec*)codec)->m_bit_buf;
										num11 = ((lzham_symbol_codec*)codec)->m_bit_count;
										ptr3 = ((lzham_symbol_codec*)codec)->m_pDecode_buf_next;
										goto IL_1bbb;
									}
									decode_set_input_buffer.Invoke(&((lzham_lzham_decompressor*)ptr)->m_codec, eof_flag: (((lzham_lzham_decompressor*)ptr)->m_no_more_input_bytes_flag & 1) == 1, pBuf_next: ((lzham_lzham_decompressor*)ptr)->m_pIn_buf, buf_size: *(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size, pBuf: ((lzham_lzham_decompressor*)ptr)->m_pIn_buf);
									if ((((lzham_lzham_decompressor*)ptr)->m_codec.m_decode_buf_eof & 1) != 1 && ((lzham_lzham_decompressor*)ptr)->m_codec.m_decode_buf_size == 0L)
									{
										goto IL_17ad;
									}
									num2 = ((lzham_lzham_decompressor*)ptr)->m_match_hist0;
									num3 = ((lzham_lzham_decompressor*)ptr)->m_match_hist1;
									num4 = ((lzham_lzham_decompressor*)ptr)->m_match_hist2;
									num5 = ((lzham_lzham_decompressor*)ptr)->m_match_hist3;
									num6 = ((lzham_lzham_decompressor*)ptr)->m_cur_state;
									num7 = ((lzham_lzham_decompressor*)ptr)->m_dst_ofs;
									num8 = ((lzham_symbol_codec*)codec)->m_arith_value;
									num9 = ((lzham_symbol_codec*)codec)->m_arith_length;
									num10 = ((lzham_symbol_codec*)codec)->m_bit_buf;
									num11 = ((lzham_symbol_codec*)codec)->m_bit_count;
									ptr3 = ((lzham_symbol_codec*)codec)->m_pDecode_buf_next;
									goto IL_18d6;
								}
								decode_set_input_buffer.Invoke(&((lzham_lzham_decompressor*)ptr)->m_codec, eof_flag: (((lzham_lzham_decompressor*)ptr)->m_no_more_input_bytes_flag & 1) == 1, pBuf_next: ((lzham_lzham_decompressor*)ptr)->m_pIn_buf, buf_size: *(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size, pBuf: ((lzham_lzham_decompressor*)ptr)->m_pIn_buf);
								if ((((lzham_lzham_decompressor*)ptr)->m_codec.m_decode_buf_eof & 1) != 1 && ((lzham_lzham_decompressor*)ptr)->m_codec.m_decode_buf_size == 0L)
								{
									goto IL_14a2;
								}
								num2 = ((lzham_lzham_decompressor*)ptr)->m_match_hist0;
								num3 = ((lzham_lzham_decompressor*)ptr)->m_match_hist1;
								num4 = ((lzham_lzham_decompressor*)ptr)->m_match_hist2;
								num5 = ((lzham_lzham_decompressor*)ptr)->m_match_hist3;
								num6 = ((lzham_lzham_decompressor*)ptr)->m_cur_state;
								num7 = ((lzham_lzham_decompressor*)ptr)->m_dst_ofs;
								num8 = ((lzham_symbol_codec*)codec)->m_arith_value;
								num9 = ((lzham_symbol_codec*)codec)->m_arith_length;
								num10 = ((lzham_symbol_codec*)codec)->m_bit_buf;
								num11 = ((lzham_symbol_codec*)codec)->m_bit_count;
								ptr3 = ((lzham_symbol_codec*)codec)->m_pDecode_buf_next;
								goto IL_15cb;
							}
							decode_set_input_buffer.Invoke(&((lzham_lzham_decompressor*)ptr)->m_codec, eof_flag: (((lzham_lzham_decompressor*)ptr)->m_no_more_input_bytes_flag & 1) == 1, pBuf_next: ((lzham_lzham_decompressor*)ptr)->m_pIn_buf, buf_size: *(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size, pBuf: ((lzham_lzham_decompressor*)ptr)->m_pIn_buf);
							if ((((lzham_lzham_decompressor*)ptr)->m_codec.m_decode_buf_eof & 1) != 1 && ((lzham_lzham_decompressor*)ptr)->m_codec.m_decode_buf_size == 0L)
							{
								goto IL_11d4;
							}
							num2 = ((lzham_lzham_decompressor*)ptr)->m_match_hist0;
							num3 = ((lzham_lzham_decompressor*)ptr)->m_match_hist1;
							num4 = ((lzham_lzham_decompressor*)ptr)->m_match_hist2;
							num5 = ((lzham_lzham_decompressor*)ptr)->m_match_hist3;
							num6 = ((lzham_lzham_decompressor*)ptr)->m_cur_state;
							num7 = ((lzham_lzham_decompressor*)ptr)->m_dst_ofs;
							num8 = ((lzham_symbol_codec*)codec)->m_arith_value;
							num9 = ((lzham_symbol_codec*)codec)->m_arith_length;
							num10 = ((lzham_symbol_codec*)codec)->m_bit_buf;
							num11 = ((lzham_symbol_codec*)codec)->m_bit_count;
							ptr3 = ((lzham_symbol_codec*)codec)->m_pDecode_buf_next;
							goto IL_12fd;
						}
						decode_set_input_buffer.Invoke(&((lzham_lzham_decompressor*)ptr)->m_codec, eof_flag: (((lzham_lzham_decompressor*)ptr)->m_no_more_input_bytes_flag & 1) == 1, pBuf_next: ((lzham_lzham_decompressor*)ptr)->m_pIn_buf, buf_size: *(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size, pBuf: ((lzham_lzham_decompressor*)ptr)->m_pIn_buf);
						if ((((lzham_lzham_decompressor*)ptr)->m_codec.m_decode_buf_eof & 1) != 1 && ((lzham_lzham_decompressor*)ptr)->m_codec.m_decode_buf_size == 0L)
						{
							goto IL_0bed;
						}
						num2 = ((lzham_lzham_decompressor*)ptr)->m_match_hist0;
						num3 = ((lzham_lzham_decompressor*)ptr)->m_match_hist1;
						num4 = ((lzham_lzham_decompressor*)ptr)->m_match_hist2;
						num5 = ((lzham_lzham_decompressor*)ptr)->m_match_hist3;
						num6 = ((lzham_lzham_decompressor*)ptr)->m_cur_state;
						num7 = ((lzham_lzham_decompressor*)ptr)->m_dst_ofs;
						num8 = ((lzham_symbol_codec*)codec)->m_arith_value;
						num9 = ((lzham_symbol_codec*)codec)->m_arith_length;
						num10 = ((lzham_symbol_codec*)codec)->m_bit_buf;
						num11 = ((lzham_symbol_codec*)codec)->m_bit_count;
						ptr3 = ((lzham_symbol_codec*)codec)->m_pDecode_buf_next;
						goto IL_0d06;
					}
					decode_set_input_buffer.Invoke(&((lzham_lzham_decompressor*)ptr)->m_codec, eof_flag: (((lzham_lzham_decompressor*)ptr)->m_no_more_input_bytes_flag & 1) == 1, pBuf_next: ((lzham_lzham_decompressor*)ptr)->m_pIn_buf, buf_size: *(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size, pBuf: ((lzham_lzham_decompressor*)ptr)->m_pIn_buf);
					if ((((lzham_lzham_decompressor*)ptr)->m_codec.m_decode_buf_eof & 1) != 1 && ((lzham_lzham_decompressor*)ptr)->m_codec.m_decode_buf_size == 0L)
					{
						goto IL_08ed;
					}
					num2 = ((lzham_lzham_decompressor*)ptr)->m_match_hist0;
					num3 = ((lzham_lzham_decompressor*)ptr)->m_match_hist1;
					num4 = ((lzham_lzham_decompressor*)ptr)->m_match_hist2;
					num5 = ((lzham_lzham_decompressor*)ptr)->m_match_hist3;
					num6 = ((lzham_lzham_decompressor*)ptr)->m_cur_state;
					num7 = ((lzham_lzham_decompressor*)ptr)->m_dst_ofs;
					num8 = ((lzham_symbol_codec*)codec)->m_arith_value;
					num9 = ((lzham_symbol_codec*)codec)->m_arith_length;
					num10 = ((lzham_symbol_codec*)codec)->m_bit_buf;
					num11 = ((lzham_symbol_codec*)codec)->m_bit_count;
					ptr3 = ((lzham_symbol_codec*)codec)->m_pDecode_buf_next;
					goto IL_0a06;
				}
				decode_set_input_buffer.Invoke(&((lzham_lzham_decompressor*)ptr)->m_codec, eof_flag: (((lzham_lzham_decompressor*)ptr)->m_no_more_input_bytes_flag & 1) == 1, pBuf_next: ((lzham_lzham_decompressor*)ptr)->m_pIn_buf, buf_size: *(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size, pBuf: ((lzham_lzham_decompressor*)ptr)->m_pIn_buf);
				if ((((lzham_lzham_decompressor*)ptr)->m_codec.m_decode_buf_eof & 1) != 1 && ((lzham_lzham_decompressor*)ptr)->m_codec.m_decode_buf_size == 0L)
				{
					goto IL_0688;
				}
				num2 = ((lzham_lzham_decompressor*)ptr)->m_match_hist0;
				num3 = ((lzham_lzham_decompressor*)ptr)->m_match_hist1;
				num4 = ((lzham_lzham_decompressor*)ptr)->m_match_hist2;
				num5 = ((lzham_lzham_decompressor*)ptr)->m_match_hist3;
				num6 = ((lzham_lzham_decompressor*)ptr)->m_cur_state;
				num7 = ((lzham_lzham_decompressor*)ptr)->m_dst_ofs;
				num8 = ((lzham_symbol_codec*)codec)->m_arith_value;
				num9 = ((lzham_symbol_codec*)codec)->m_arith_length;
				num10 = ((lzham_symbol_codec*)codec)->m_bit_buf;
				num11 = ((lzham_symbol_codec*)codec)->m_bit_count;
				ptr3 = ((lzham_symbol_codec*)codec)->m_pDecode_buf_next;
				goto IL_07a1;
			}
			if (!start_decoding.Invoke(&((lzham_lzham_decompressor*)ptr)->m_codec, eof_flag: (((lzham_lzham_decompressor*)ptr)->m_no_more_input_bytes_flag & 1) == 1, buf_size: *(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size, pBuf: ((lzham_lzham_decompressor*)ptr)->m_pIn_buf, pNeed_bytes_func: null, pPrivate_data: null))
			{
				return 4;
			}
			num8 = ((lzham_symbol_codec*)codec)->m_arith_value;
			num9 = ((lzham_symbol_codec*)codec)->m_arith_length;
			num10 = ((lzham_symbol_codec*)codec)->m_bit_buf;
			num11 = ((lzham_symbol_codec*)codec)->m_bit_count;
			ptr3 = ((lzham_symbol_codec*)codec)->m_pDecode_buf_next;
			if ((((lzham_lzham_decompressor*)ptr)->m_params.m_decompress_flags & 4) == 0)
			{
				goto IL_0dfc;
			}
			goto IL_05c6;
		}
		IL_568c:
		int num20 = 0;
		unchecked
		{
			if (ptr3 < ((lzham_symbol_codec*)codec)->m_pDecode_buf_end)
			{
				void* ptr11 = ptr3;
				ptr3 = (byte*)ptr11 + 1;
				num20 = (byte)(*(sbyte*)ptr11);
			}
			goto IL_56d4;
		}
		IL_ae54:
		unchecked
		{
			long num21 = decode_get_bytes_consumed.Invoke(&((lzham_lzham_decompressor*)ptr)->m_codec);
			*(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size = num21;
			*(long*)((lzham_lzham_decompressor*)ptr)->m_pOut_buf_size = 0L;
			((lzham_lzham_decompressor*)ptr)->m_state = 1082;
			return 2;
		}
		IL_2edb:
		num11 += 8;
		int num22;
		unchecked
		{
			num10 |= (long)((ulong)(uint)num22 << (int)(uint)checked(64 - num11));
			goto IL_2c5f;
		}
		IL_10e6:
		int num23;
		unchecked
		{
			if (num11 < 2)
			{
				if (ptr3 == ((lzham_symbol_codec*)codec)->m_pDecode_buf_end)
				{
					if ((((lzham_symbol_codec*)codec)->m_decode_buf_eof & 1) != 1)
					{
						((lzham_symbol_codec*)codec)->m_arith_value = num8;
						((lzham_symbol_codec*)codec)->m_arith_length = num9;
						((lzham_symbol_codec*)codec)->m_bit_buf = num10;
						((lzham_symbol_codec*)codec)->m_bit_count = num11;
						((lzham_symbol_codec*)codec)->m_pDecode_buf_next = ptr3;
						((lzham_lzham_decompressor*)ptr)->m_match_hist0 = num2;
						((lzham_lzham_decompressor*)ptr)->m_match_hist1 = num3;
						((lzham_lzham_decompressor*)ptr)->m_match_hist2 = num4;
						((lzham_lzham_decompressor*)ptr)->m_match_hist3 = num5;
						((lzham_lzham_decompressor*)ptr)->m_cur_state = num6;
						((lzham_lzham_decompressor*)ptr)->m_dst_ofs = num7;
						goto IL_11d4;
					}
					goto IL_12fd;
				}
				void* ptr12 = ptr3;
				ptr3 = (byte*)ptr12 + 1;
				num23 = (byte)(*(sbyte*)ptr12);
				goto IL_1345;
			}
			((lzham_lzham_decompressor*)ptr)->m_block_type = (int)(num10 >>> 62);
			num10 <<= 2;
			num11 = checked(num11 - 2);
			if (((lzham_lzham_decompressor*)ptr)->m_block_type == 0)
			{
				goto IL_13b4;
			}
			if (((lzham_lzham_decompressor*)ptr)->m_block_type == 2)
			{
				num17 = 0;
				goto IL_25e0;
			}
			if (((lzham_lzham_decompressor*)ptr)->m_block_type == 1)
			{
				num8 = 0;
				num9 = 0;
				goto IL_3ba4;
			}
			if (((lzham_lzham_decompressor*)ptr)->m_block_type == 3)
			{
				((lzham_lzham_decompressor*)ptr)->m_status = 3;
			}
			else
			{
				((lzham_lzham_decompressor*)ptr)->m_status = 7;
			}
			goto IL_a61f;
		}
		IL_a61f:
		unchecked
		{
			((lzham_lzham_decompressor*)ptr)->m_block_index++;
			if (((lzham_lzham_decompressor*)ptr)->m_status == 0)
			{
				goto IL_10e6;
			}
			if (uint.MaxValue != 0 || num7 == 0)
			{
				goto IL_aa5a;
			}
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
			int match_hist;
			((lzham_lzham_decompressor*)ptr)->m_match_hist0 = match_hist;
			int match_hist2;
			((lzham_lzham_decompressor*)ptr)->m_match_hist1 = match_hist2;
			int match_hist3;
			((lzham_lzham_decompressor*)ptr)->m_match_hist2 = match_hist3;
			int match_hist4;
			((lzham_lzham_decompressor*)ptr)->m_match_hist3 = match_hist4;
			int cur_state;
			((lzham_lzham_decompressor*)ptr)->m_cur_state = cur_state;
			int dst_ofs;
			((lzham_lzham_decompressor*)ptr)->m_dst_ofs = dst_ofs;
			_ = (byte*)((lzham_lzham_decompressor*)ptr)->m_pDecomp_buf + (uint)((lzham_lzham_decompressor*)ptr)->m_seed_bytes_to_ignore_when_flushing + (uint)((lzham_lzham_decompressor*)ptr)->m_dst_highwater_ofs;
			sbyte* pFlush_src7;
			((lzham_lzham_decompressor*)ptr)->m_pFlush_src = pFlush_src7;
			_ = (uint)(num7 - ((lzham_lzham_decompressor*)ptr)->m_seed_bytes_to_ignore_when_flushing - ((lzham_lzham_decompressor*)ptr)->m_dst_highwater_ofs);
			long flush_num_bytes_remaining;
			((lzham_lzham_decompressor*)ptr)->m_flush_num_bytes_remaining = flush_num_bytes_remaining;
			((lzham_lzham_decompressor*)ptr)->m_seed_bytes_to_ignore_when_flushing = 0;
			int dst_highwater_ofs;
			((lzham_lzham_decompressor*)ptr)->m_dst_highwater_ofs = dst_highwater_ofs;
			goto IL_a78f;
		}
		IL_9d59:
		void* ptr14;
		void* ptr13 = ptr14;
		int src_ofs;
		unchecked
		{
			ptr14 = (byte*)ptr13 + 1;
			sbyte b = *(sbyte*)ptr13;
			((sbyte*)pOut_buf)[(uint)num7++] = b;
			if (ptr14 == ptr2)
			{
				ptr14 = pOut_buf;
			}
			if ((uint)num7 <= uint.MaxValue)
			{
				goto IL_a1ed;
			}
			((lzham_symbol_codec*)codec)->m_arith_value = num8;
			((lzham_symbol_codec*)codec)->m_arith_length = num9;
			((lzham_symbol_codec*)codec)->m_bit_buf = num10;
			((lzham_symbol_codec*)codec)->m_bit_count = num11;
			((lzham_symbol_codec*)codec)->m_pDecode_buf_next = ptr3;
			((lzham_lzham_decompressor*)ptr)->m_match_len = num12;
			((lzham_lzham_decompressor*)ptr)->m_src_ofs = src_ofs;
			((lzham_lzham_decompressor*)ptr)->m_pCopy_src = ptr14;
			((lzham_lzham_decompressor*)ptr)->m_match_hist0 = num2;
			((lzham_lzham_decompressor*)ptr)->m_match_hist1 = num3;
			((lzham_lzham_decompressor*)ptr)->m_match_hist2 = num4;
			((lzham_lzham_decompressor*)ptr)->m_match_hist3 = num5;
			((lzham_lzham_decompressor*)ptr)->m_cur_state = num6;
			((lzham_lzham_decompressor*)ptr)->m_dst_ofs = num7;
			((lzham_lzham_decompressor*)ptr)->m_pFlush_src = (byte*)((lzham_lzham_decompressor*)ptr)->m_pDecomp_buf + (uint)((lzham_lzham_decompressor*)ptr)->m_seed_bytes_to_ignore_when_flushing + (uint)((lzham_lzham_decompressor*)ptr)->m_dst_highwater_ofs;
			((lzham_lzham_decompressor*)ptr)->m_flush_num_bytes_remaining = (uint)(num - ((lzham_lzham_decompressor*)ptr)->m_seed_bytes_to_ignore_when_flushing - ((lzham_lzham_decompressor*)ptr)->m_dst_highwater_ofs);
			((lzham_lzham_decompressor*)ptr)->m_seed_bytes_to_ignore_when_flushing = 0;
			((lzham_lzham_decompressor*)ptr)->m_dst_highwater_ofs = num & -1;
			goto IL_9f04;
		}
		IL_2d61:
		unchecked
		{
			long num24 = decode_get_bytes_consumed.Invoke(&((lzham_lzham_decompressor*)ptr)->m_codec);
			*(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size = num24;
			*(long*)((lzham_lzham_decompressor*)ptr)->m_pOut_buf_size = 0L;
			((lzham_lzham_decompressor*)ptr)->m_state = 536;
			return 2;
		}
		IL_07a1:
		int num25 = 0;
		unchecked
		{
			if (ptr3 < ((lzham_symbol_codec*)codec)->m_pDecode_buf_end)
			{
				void* ptr15 = ptr3;
				ptr3 = (byte*)ptr15 + 1;
				num25 = (byte)(*(sbyte*)ptr15);
			}
			goto IL_07da;
		}
		IL_5ac8:
		num11 += 8;
		int num26;
		unchecked
		{
			num10 |= (long)((ulong)(uint)num26 << (int)(uint)checked(64 - num11));
			goto IL_584f;
		}
		IL_07da:
		num11 += 8;
		unchecked
		{
			num10 |= (long)((ulong)(uint)num25 << (int)(uint)checked(64 - num11));
			goto IL_05c6;
		}
		IL_05c6:
		unchecked
		{
			if (num11 < 8)
			{
				if (ptr3 == ((lzham_symbol_codec*)codec)->m_pDecode_buf_end)
				{
					if ((((lzham_symbol_codec*)codec)->m_decode_buf_eof & 1) != 1)
					{
						((lzham_symbol_codec*)codec)->m_arith_value = num8;
						((lzham_symbol_codec*)codec)->m_arith_length = num9;
						((lzham_symbol_codec*)codec)->m_bit_buf = num10;
						((lzham_symbol_codec*)codec)->m_bit_count = num11;
						((lzham_symbol_codec*)codec)->m_pDecode_buf_next = ptr3;
						((lzham_lzham_decompressor*)ptr)->m_match_hist0 = num2;
						((lzham_lzham_decompressor*)ptr)->m_match_hist1 = num3;
						((lzham_lzham_decompressor*)ptr)->m_match_hist2 = num4;
						((lzham_lzham_decompressor*)ptr)->m_match_hist3 = num5;
						((lzham_lzham_decompressor*)ptr)->m_cur_state = num6;
						((lzham_lzham_decompressor*)ptr)->m_dst_ofs = num7;
						goto IL_0688;
					}
					goto IL_07a1;
				}
				void* ptr16 = ptr3;
				ptr3 = (byte*)ptr16 + 1;
				num25 = (byte)(*(sbyte*)ptr16);
				goto IL_07da;
			}
			((lzham_lzham_decompressor*)ptr)->m_z_cmf = (int)(num10 >>> 56);
			num10 <<= 8;
		}
		num11 -= 8;
		goto IL_082b;
		IL_8f2a:
		int num27 = 0;
		unchecked
		{
			if (ptr3 < ((lzham_symbol_codec*)codec)->m_pDecode_buf_end)
			{
				void* ptr17 = ptr3;
				ptr3 = (byte*)ptr17 + 1;
				num27 = (byte)(*(sbyte*)ptr17);
			}
			goto IL_8f72;
		}
		IL_9f04:
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
					long num29;
					for (long num28 = 0L; (ulong)num28 < (ulong)((lzham_lzham_decompressor*)ptr)->m_flush_n; num28 += num29)
					{
						num29 = (((ulong)(((lzham_lzham_decompressor*)ptr)->m_flush_n - num28) >= 8192uL) ? 8192L : (((lzham_lzham_decompressor*)ptr)->m_flush_n - num28));
						llvm_memcpy_p0_p0_i64.Invoke((byte*)((lzham_lzham_decompressor*)ptr)->m_pOut_buf + num28, (byte*)((lzham_lzham_decompressor*)ptr)->m_pFlush_src + num28, num29, isVolatile: false);
						((lzham_lzham_decompressor*)ptr)->m_decomp_adler32 = adler32.Invoke(adler32: ((lzham_lzham_decompressor*)ptr)->m_decomp_adler32, pBuf: (byte*)((lzham_lzham_decompressor*)ptr)->m_pFlush_src + num28, buflen: num29);
					}
				}
				long num30 = decode_get_bytes_consumed.Invoke(&((lzham_lzham_decompressor*)ptr)->m_codec);
				*(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size = num30;
				long flush_n13 = ((lzham_lzham_decompressor*)ptr)->m_flush_n;
				*(long*)((lzham_lzham_decompressor*)ptr)->m_pOut_buf_size = flush_n13;
				((lzham_lzham_decompressor*)ptr)->m_state = 1002;
				return InstructionHelper.Select(((lzham_lzham_decompressor*)ptr)->m_flush_n != 0L, 0, 1);
			}
			num12 = ((lzham_lzham_decompressor*)ptr)->m_match_len;
			src_ofs = ((lzham_lzham_decompressor*)ptr)->m_src_ofs;
			ptr14 = ((lzham_lzham_decompressor*)ptr)->m_pCopy_src;
			num2 = ((lzham_lzham_decompressor*)ptr)->m_match_hist0;
			num3 = ((lzham_lzham_decompressor*)ptr)->m_match_hist1;
			num4 = ((lzham_lzham_decompressor*)ptr)->m_match_hist2;
			num5 = ((lzham_lzham_decompressor*)ptr)->m_match_hist3;
			num6 = ((lzham_lzham_decompressor*)ptr)->m_cur_state;
			_ = ((lzham_lzham_decompressor*)ptr)->m_dst_ofs;
			num8 = ((lzham_symbol_codec*)codec)->m_arith_value;
			num9 = ((lzham_symbol_codec*)codec)->m_arith_length;
			num10 = ((lzham_symbol_codec*)codec)->m_bit_buf;
			num11 = ((lzham_symbol_codec*)codec)->m_bit_count;
			ptr3 = ((lzham_symbol_codec*)codec)->m_pDecode_buf_next;
			num7 = 0;
			goto IL_a1ed;
		}
		IL_70c9:
		int num32;
		unchecked
		{
			while (num11 >= 1)
			{
				int num31 = (int)(num10 >>> 63);
				num10 <<= 1;
				num11 = checked(num11 - 1);
				if (num31 != 0)
				{
					num12++;
					if ((uint)num12 < 3u)
					{
						continue;
					}
				}
				goto IL_73b5;
			}
			if (ptr3 == ((lzham_symbol_codec*)codec)->m_pDecode_buf_end)
			{
				if ((((lzham_symbol_codec*)codec)->m_decode_buf_eof & 1) != 1)
				{
					((lzham_symbol_codec*)codec)->m_arith_value = num8;
					((lzham_symbol_codec*)codec)->m_arith_length = num9;
					((lzham_symbol_codec*)codec)->m_bit_buf = num10;
					((lzham_symbol_codec*)codec)->m_bit_count = num11;
					((lzham_symbol_codec*)codec)->m_pDecode_buf_next = ptr3;
					((lzham_lzham_decompressor*)ptr)->m_match_len = num12;
					((lzham_lzham_decompressor*)ptr)->m_match_hist0 = num2;
					((lzham_lzham_decompressor*)ptr)->m_match_hist1 = num3;
					((lzham_lzham_decompressor*)ptr)->m_match_hist2 = num4;
					((lzham_lzham_decompressor*)ptr)->m_match_hist3 = num5;
					((lzham_lzham_decompressor*)ptr)->m_cur_state = num6;
					((lzham_lzham_decompressor*)ptr)->m_dst_ofs = num7;
					goto IL_71c8;
				}
				goto IL_72fa;
			}
			void* ptr18 = ptr3;
			ptr3 = (byte*)ptr18 + 1;
			num32 = (byte)(*(sbyte*)ptr18);
			goto IL_7342;
		}
		IL_2f60:
		int num33 = -1;
		if (num11 >= 8)
		{
			num33 = unchecked((int)(num10 >>> 56));
			num10 <<= 8;
			num11 -= 8;
		}
		if (num33 < 0)
		{
			goto IL_34aa;
		}
		unchecked
		{
			if ((ulong)(uint)num7 >= (ulong)pOut_buf_size)
			{
				((lzham_symbol_codec*)codec)->m_arith_value = num8;
				((lzham_symbol_codec*)codec)->m_arith_length = num9;
				((lzham_symbol_codec*)codec)->m_bit_buf = num10;
				((lzham_symbol_codec*)codec)->m_bit_count = num11;
				((lzham_symbol_codec*)codec)->m_pDecode_buf_next = ptr3;
				long num34 = decode_get_bytes_consumed.Invoke(codec);
				*(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size = num34;
				*(long*)((lzham_lzham_decompressor*)ptr)->m_pOut_buf_size = 0L;
				goto IL_3035;
			}
			((sbyte*)pOut_buf)[(uint)num7++] = (sbyte)num33;
			if (uint.MaxValue != 0 || (uint)num7 <= uint.MaxValue)
			{
				goto IL_3493;
			}
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
			int num_raw_bytes_remaining;
			((lzham_lzham_decompressor*)ptr)->m_num_raw_bytes_remaining = num_raw_bytes_remaining;
			int match_hist5;
			((lzham_lzham_decompressor*)ptr)->m_match_hist0 = match_hist5;
			int match_hist6;
			((lzham_lzham_decompressor*)ptr)->m_match_hist1 = match_hist6;
			int match_hist7;
			((lzham_lzham_decompressor*)ptr)->m_match_hist2 = match_hist7;
			int match_hist8;
			((lzham_lzham_decompressor*)ptr)->m_match_hist3 = match_hist8;
			int cur_state2;
			((lzham_lzham_decompressor*)ptr)->m_cur_state = cur_state2;
			int dst_ofs2;
			((lzham_lzham_decompressor*)ptr)->m_dst_ofs = dst_ofs2;
			_ = (byte*)((lzham_lzham_decompressor*)ptr)->m_pDecomp_buf + (uint)((lzham_lzham_decompressor*)ptr)->m_seed_bytes_to_ignore_when_flushing + (uint)((lzham_lzham_decompressor*)ptr)->m_dst_highwater_ofs;
			sbyte* pFlush_src8;
			((lzham_lzham_decompressor*)ptr)->m_pFlush_src = pFlush_src8;
			_ = (uint)(num - ((lzham_lzham_decompressor*)ptr)->m_seed_bytes_to_ignore_when_flushing - ((lzham_lzham_decompressor*)ptr)->m_dst_highwater_ofs);
			long flush_num_bytes_remaining2;
			((lzham_lzham_decompressor*)ptr)->m_flush_num_bytes_remaining = flush_num_bytes_remaining2;
			((lzham_lzham_decompressor*)ptr)->m_seed_bytes_to_ignore_when_flushing = 0;
			int dst_highwater_ofs2;
			((lzham_lzham_decompressor*)ptr)->m_dst_highwater_ofs = dst_highwater_ofs2;
			goto IL_31bc;
		}
		IL_6a63:
		int num35 = 0;
		unchecked
		{
			if (ptr3 < ((lzham_symbol_codec*)codec)->m_pDecode_buf_end)
			{
				void* ptr19 = ptr3;
				ptr3 = (byte*)ptr19 + 1;
				num35 = (byte)(*(sbyte*)ptr19);
			}
			goto IL_6aab;
		}
		IL_0688:
		unchecked
		{
			long num36 = decode_get_bytes_consumed.Invoke(&((lzham_lzham_decompressor*)ptr)->m_codec);
			*(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size = num36;
			*(long*)((lzham_lzham_decompressor*)ptr)->m_pOut_buf_size = 0L;
			((lzham_lzham_decompressor*)ptr)->m_state = 369;
			return 2;
		}
		IL_5ebc:
		num11 += 8;
		int num37;
		unchecked
		{
			num10 |= (long)((ulong)(uint)num37 << (int)(uint)checked(64 - num11));
			goto IL_5c43;
		}
		IL_96ff:
		int num38;
		unchecked
		{
			ptr4 = &((lzham_lzham_decompressor*)ptr)->m_dist_lsb_table;
			pDecode_tables = ((lzham_raw_quasi_adaptive_huffman_data_model*)(&((lzham_lzham_decompressor*)ptr)->m_dist_lsb_table))->m_pDecode_tables;
			if (num11 < 24)
			{
				ptr3 = (byte*)ptr3 + 4;
				if (ptr3 >= ((lzham_symbol_codec*)codec)->m_pDecode_buf_end)
				{
					ptr3 = (byte*)ptr3 + -4;
					goto IL_9749;
				}
				num38 = ((byte)((sbyte*)ptr3)[-4] << 24) | (((byte*)ptr3 + -4)[1] << 16) | (((byte*)ptr3 + -4)[2] << 8) | ((byte*)ptr3 + -4)[3];
				num11 = checked(num11 + 32);
				num10 |= (long)((ulong)(uint)num38 << (int)(uint)checked(64 - num11));
			}
			goto IL_9a80;
		}
		IL_9087:
		int num39;
		unchecked
		{
			if (num11 < num15)
			{
				if (ptr3 == ((lzham_symbol_codec*)codec)->m_pDecode_buf_end)
				{
					if ((((lzham_symbol_codec*)codec)->m_decode_buf_eof & 1) != 1)
					{
						((lzham_symbol_codec*)codec)->m_arith_value = num8;
						((lzham_symbol_codec*)codec)->m_arith_length = num9;
						((lzham_symbol_codec*)codec)->m_bit_buf = num10;
						((lzham_symbol_codec*)codec)->m_bit_count = num11;
						((lzham_symbol_codec*)codec)->m_pDecode_buf_next = ptr3;
						((lzham_lzham_decompressor*)ptr)->m_match_len = num12;
						((lzham_lzham_decompressor*)ptr)->m_match_slot = num13;
						((lzham_lzham_decompressor*)ptr)->m_num_extra_bits = num15;
						((lzham_lzham_decompressor*)ptr)->m_match_hist0 = num2;
						((lzham_lzham_decompressor*)ptr)->m_match_hist1 = num3;
						((lzham_lzham_decompressor*)ptr)->m_match_hist2 = num4;
						((lzham_lzham_decompressor*)ptr)->m_match_hist3 = num5;
						((lzham_lzham_decompressor*)ptr)->m_cur_state = num6;
						((lzham_lzham_decompressor*)ptr)->m_dst_ofs = num7;
						goto IL_91a9;
					}
					goto IL_92ed;
				}
				void* ptr20 = ptr3;
				ptr3 = (byte*)ptr20 + 1;
				num39 = (byte)(*(sbyte*)ptr20);
				goto IL_9335;
			}
			num14 = (int)((num15 != 0) ? (num10 >>> (int)(uint)(64 - num15)) : 0);
			num10 <<= (int)(uint)num15;
			num11 -= num15;
			goto IL_9c18;
		}
		IL_9749:
		if (num11 >= 24)
		{
			goto IL_9a80;
		}
		unchecked
		{
			if ((((lzham_symbol_codec*)codec)->m_decode_buf_eof & 1) != 1)
			{
				((lzham_symbol_codec*)codec)->m_pSaved_huff_model = ptr4;
				((lzham_symbol_codec*)codec)->m_arith_value = num8;
				((lzham_symbol_codec*)codec)->m_arith_length = num9;
				((lzham_symbol_codec*)codec)->m_bit_buf = num10;
				((lzham_symbol_codec*)codec)->m_bit_count = num11;
				((lzham_symbol_codec*)codec)->m_pDecode_buf_next = ptr3;
				((lzham_lzham_decompressor*)ptr)->m_match_len = num12;
				((lzham_lzham_decompressor*)ptr)->m_match_slot = num13;
				((lzham_lzham_decompressor*)ptr)->m_extra_bits = num14;
				((lzham_lzham_decompressor*)ptr)->m_match_hist0 = num2;
				((lzham_lzham_decompressor*)ptr)->m_match_hist1 = num3;
				((lzham_lzham_decompressor*)ptr)->m_match_hist2 = num4;
				((lzham_lzham_decompressor*)ptr)->m_match_hist3 = num5;
				((lzham_lzham_decompressor*)ptr)->m_cur_state = num6;
				((lzham_lzham_decompressor*)ptr)->m_dst_ofs = num7;
				goto IL_986a;
			}
			goto IL_99c0;
		}
		IL_0a06:
		int num40 = 0;
		unchecked
		{
			if (ptr3 < ((lzham_symbol_codec*)codec)->m_pDecode_buf_end)
			{
				void* ptr21 = ptr3;
				ptr3 = (byte*)ptr21 + 1;
				num40 = (byte)(*(sbyte*)ptr21);
			}
			goto IL_0a3f;
		}
		IL_582c:
		void* ptr22;
		void* ptr23;
		int num45;
		unchecked
		{
			if ((uint)num9 < 16777216u)
			{
				((lzham_symbol_codec*)codec)->m_pSaved_model = ptr22;
				goto IL_584f;
			}
			int num41 = (ushort)((lzham_adaptive_bit_model*)ptr22)->m_bit_0_prob * (num9 >>> 11);
			int num42 = (((uint)num8 >= (uint)num41) ? 1 : 0);
			if (num42 == 0)
			{
				int num43 = 2048 - (ushort)((lzham_adaptive_bit_model*)ptr22)->m_bit_0_prob >>> 5;
				short* bit_0_prob = &((lzham_adaptive_bit_model*)ptr22)->m_bit_0_prob;
				*bit_0_prob = (short)((ushort)(*bit_0_prob) + num43);
				num9 = num41;
			}
			else
			{
				int num44 = (ushort)((lzham_adaptive_bit_model*)ptr22)->m_bit_0_prob >> 5;
				short* bit_0_prob2 = &((lzham_adaptive_bit_model*)ptr22)->m_bit_0_prob;
				*bit_0_prob2 = (short)checked(unchecked((ushort)(*bit_0_prob2)) - num44);
				num8 -= num41;
				num9 -= num41;
			}
			if (num42 != 0)
			{
				ptr23 = (byte*)(&((lzham_lzham_decompressor*)ptr)->m_is_rep0_single_byte_model) + (nint)(uint)num6 * (nint)sizeof(lzham_adaptive_bit_model);
				goto IL_5c20;
			}
			ptr7 = (byte*)(&((lzham_lzham_decompressor*)ptr)->m_rep_len_table) + (((uint)num6 >= 7u) ? ((nint)1) : ((nint)0)) * (nint)sizeof(lzham_quasi_adaptive_huffman_data_model);
			pDecode_tables4 = ((lzham_raw_quasi_adaptive_huffman_data_model*)((byte*)(&((lzham_lzham_decompressor*)ptr)->m_rep_len_table) + (((uint)num6 >= 7u) ? ((nint)1) : ((nint)0)) * (nint)sizeof(lzham_quasi_adaptive_huffman_data_model)))->m_pDecode_tables;
			if (num11 < 24)
			{
				ptr3 = (byte*)ptr3 + 4;
				if (ptr3 >= ((lzham_symbol_codec*)codec)->m_pDecode_buf_end)
				{
					ptr3 = (byte*)ptr3 + -4;
					goto IL_6c22;
				}
				num45 = ((byte)((sbyte*)ptr3)[-4] << 24) | (((byte*)ptr3 + -4)[1] << 16) | (((byte*)ptr3 + -4)[2] << 8) | ((byte*)ptr3 + -4)[3];
				num11 = checked(num11 + 32);
				num10 |= (long)((ulong)(uint)num45 << (int)(uint)checked(64 - num11));
			}
			goto IL_6f25;
		}
		IL_0a3f:
		num11 += 8;
		unchecked
		{
			num10 |= (long)((ulong)(uint)num40 << (int)(uint)checked(64 - num11));
			goto IL_082b;
		}
		IL_082b:
		unchecked
		{
			if (num11 < 8)
			{
				if (ptr3 == ((lzham_symbol_codec*)codec)->m_pDecode_buf_end)
				{
					if ((((lzham_symbol_codec*)codec)->m_decode_buf_eof & 1) != 1)
					{
						((lzham_symbol_codec*)codec)->m_arith_value = num8;
						((lzham_symbol_codec*)codec)->m_arith_length = num9;
						((lzham_symbol_codec*)codec)->m_bit_buf = num10;
						((lzham_symbol_codec*)codec)->m_bit_count = num11;
						((lzham_symbol_codec*)codec)->m_pDecode_buf_next = ptr3;
						((lzham_lzham_decompressor*)ptr)->m_match_hist0 = num2;
						((lzham_lzham_decompressor*)ptr)->m_match_hist1 = num3;
						((lzham_lzham_decompressor*)ptr)->m_match_hist2 = num4;
						((lzham_lzham_decompressor*)ptr)->m_match_hist3 = num5;
						((lzham_lzham_decompressor*)ptr)->m_cur_state = num6;
						((lzham_lzham_decompressor*)ptr)->m_dst_ofs = num7;
						goto IL_08ed;
					}
					goto IL_0a06;
				}
				void* ptr24 = ptr3;
				ptr3 = (byte*)ptr24 + 1;
				num40 = (byte)(*(sbyte*)ptr24);
				goto IL_0a3f;
			}
			((lzham_lzham_decompressor*)ptr)->m_z_flg = (int)(num10 >>> 56);
			num10 <<= 8;
			num11 = checked(num11 - 8);
			if ((uint)((((lzham_lzham_decompressor*)ptr)->m_z_cmf << 8) + ((lzham_lzham_decompressor*)ptr)->m_z_flg) % 31u != 0 || (((lzham_lzham_decompressor*)ptr)->m_z_cmf & 0xF) != 14)
			{
				return 11;
			}
			if ((((lzham_lzham_decompressor*)ptr)->m_z_flg & 0x20) == 0)
			{
				goto IL_0dfc;
			}
			if (((lzham_lzham_decompressor*)ptr)->m_params.m_pSeed_bytes == null || uint.MaxValue != 0)
			{
				return 12;
			}
			((lzham_lzham_decompressor*)ptr)->m_z_dict_adler32 = 0;
			((lzham_lzham_decompressor*)ptr)->m_tmp = 0;
			goto IL_0b18;
		}
		IL_91a9:
		unchecked
		{
			long num46 = decode_get_bytes_consumed.Invoke(&((lzham_lzham_decompressor*)ptr)->m_codec);
			*(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size = num46;
			*(long*)((lzham_lzham_decompressor*)ptr)->m_pOut_buf_size = 0L;
			((lzham_lzham_decompressor*)ptr)->m_state = 929;
			return 2;
		}
		IL_962d:
		int num47 = 0;
		unchecked
		{
			if (ptr3 < ((lzham_symbol_codec*)codec)->m_pDecode_buf_end)
			{
				void* ptr25 = ptr3;
				ptr3 = (byte*)ptr25 + 1;
				num47 = (byte)(*(sbyte*)ptr25);
			}
			goto IL_9675;
		}
		IL_92ed:
		num39 = 0;
		unchecked
		{
			if (ptr3 < ((lzham_symbol_codec*)codec)->m_pDecode_buf_end)
			{
				void* ptr26 = ptr3;
				ptr3 = (byte*)ptr26 + 1;
				num39 = (byte)(*(sbyte*)ptr26);
			}
			goto IL_9335;
		}
		IL_4b42:
		if (num11 >= 24)
		{
			goto IL_4e45;
		}
		unchecked
		{
			if ((((lzham_symbol_codec*)codec)->m_decode_buf_eof & 1) != 1)
			{
				((lzham_symbol_codec*)codec)->m_pSaved_huff_model = ptr9;
				((lzham_symbol_codec*)codec)->m_arith_value = num8;
				((lzham_symbol_codec*)codec)->m_arith_length = num9;
				((lzham_symbol_codec*)codec)->m_bit_buf = num10;
				((lzham_symbol_codec*)codec)->m_bit_count = num11;
				((lzham_symbol_codec*)codec)->m_pDecode_buf_next = ptr3;
				((lzham_lzham_decompressor*)ptr)->m_rep_lit0 = num16;
				((lzham_lzham_decompressor*)ptr)->m_match_hist0 = num2;
				((lzham_lzham_decompressor*)ptr)->m_match_hist1 = num3;
				((lzham_lzham_decompressor*)ptr)->m_match_hist2 = num4;
				((lzham_lzham_decompressor*)ptr)->m_match_hist3 = num5;
				((lzham_lzham_decompressor*)ptr)->m_cur_state = num6;
				((lzham_lzham_decompressor*)ptr)->m_dst_ofs = num7;
				goto IL_4c41;
			}
			goto IL_4d85;
		}
		IL_7f45:
		num6 = InstructionHelper.Select(unchecked((uint)num6) < 7u, 8, 11);
		goto IL_9c66;
		IL_5e74:
		num37 = 0;
		unchecked
		{
			if (ptr3 < ((lzham_symbol_codec*)codec)->m_pDecode_buf_end)
			{
				void* ptr27 = ptr3;
				ptr3 = (byte*)ptr27 + 1;
				num37 = (byte)(*(sbyte*)ptr27);
			}
			goto IL_5ebc;
		}
		IL_3035:
		unchecked((lzham_lzham_decompressor*)ptr)->m_state = 551;
		return 5;
		IL_93c5:
		unchecked
		{
			if (num11 < num15 - 4)
			{
				if (ptr3 == ((lzham_symbol_codec*)codec)->m_pDecode_buf_end)
				{
					if ((((lzham_symbol_codec*)codec)->m_decode_buf_eof & 1) != 1)
					{
						((lzham_symbol_codec*)codec)->m_arith_value = num8;
						((lzham_symbol_codec*)codec)->m_arith_length = num9;
						((lzham_symbol_codec*)codec)->m_bit_buf = num10;
						((lzham_symbol_codec*)codec)->m_bit_count = num11;
						((lzham_symbol_codec*)codec)->m_pDecode_buf_next = ptr3;
						((lzham_lzham_decompressor*)ptr)->m_match_len = num12;
						((lzham_lzham_decompressor*)ptr)->m_match_slot = num13;
						((lzham_lzham_decompressor*)ptr)->m_num_extra_bits = num15;
						((lzham_lzham_decompressor*)ptr)->m_match_hist0 = num2;
						((lzham_lzham_decompressor*)ptr)->m_match_hist1 = num3;
						((lzham_lzham_decompressor*)ptr)->m_match_hist2 = num4;
						((lzham_lzham_decompressor*)ptr)->m_match_hist3 = num5;
						((lzham_lzham_decompressor*)ptr)->m_cur_state = num6;
						((lzham_lzham_decompressor*)ptr)->m_dst_ofs = num7;
						goto IL_94e9;
					}
					goto IL_962d;
				}
				void* ptr28 = ptr3;
				ptr3 = (byte*)ptr28 + 1;
				num47 = (byte)(*(sbyte*)ptr28);
				goto IL_9675;
			}
			num14 = (int)((num15 - 4 != 0) ? (num10 >>> (int)(uint)(64 - (num15 - 4))) : 0);
			num10 <<= (int)(uint)(num15 - 4);
			num11 -= num15 - 4;
			num14 <<= 4;
			goto IL_96ff;
		}
		IL_79dc:
		num11 += 8;
		int num48;
		unchecked
		{
			num10 |= (long)((ulong)(uint)num48 << (int)(uint)checked(64 - num11));
			goto IL_7763;
		}
		IL_81f6:
		int num49 = 0;
		unchecked
		{
			if (ptr3 < ((lzham_symbol_codec*)codec)->m_pDecode_buf_end)
			{
				void* ptr29 = ptr3;
				ptr3 = (byte*)ptr29 + 1;
				num49 = (byte)(*(sbyte*)ptr29);
			}
			num11 = checked(num11 + 8);
			num10 |= (long)((ulong)(uint)num49 << (int)(uint)checked(64 - num11));
			goto IL_7fb3;
		}
		IL_b23c:
		int num50 = 0;
		unchecked
		{
			if (ptr3 < ((lzham_symbol_codec*)codec)->m_pDecode_buf_end)
			{
				void* ptr30 = ptr3;
				ptr3 = (byte*)ptr30 + 1;
				num50 = (byte)(*(sbyte*)ptr30);
			}
			goto IL_b284;
		}
		IL_31bc:
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
					long num52;
					for (long num51 = 0L; (ulong)num51 < (ulong)((lzham_lzham_decompressor*)ptr)->m_flush_n; num51 += num52)
					{
						num52 = (((ulong)(((lzham_lzham_decompressor*)ptr)->m_flush_n - num51) >= 8192uL) ? 8192L : (((lzham_lzham_decompressor*)ptr)->m_flush_n - num51));
						llvm_memcpy_p0_p0_i64.Invoke((byte*)((lzham_lzham_decompressor*)ptr)->m_pOut_buf + num51, (byte*)((lzham_lzham_decompressor*)ptr)->m_pFlush_src + num51, num52, isVolatile: false);
						((lzham_lzham_decompressor*)ptr)->m_decomp_adler32 = adler32.Invoke(adler32: ((lzham_lzham_decompressor*)ptr)->m_decomp_adler32, pBuf: (byte*)((lzham_lzham_decompressor*)ptr)->m_pFlush_src + num51, buflen: num52);
					}
				}
				long num53 = decode_get_bytes_consumed.Invoke(&((lzham_lzham_decompressor*)ptr)->m_codec);
				*(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size = num53;
				long flush_n14 = ((lzham_lzham_decompressor*)ptr)->m_flush_n;
				*(long*)((lzham_lzham_decompressor*)ptr)->m_pOut_buf_size = flush_n14;
				((lzham_lzham_decompressor*)ptr)->m_state = 559;
				return InstructionHelper.Select(((lzham_lzham_decompressor*)ptr)->m_flush_n != 0L, 0, 1);
			}
			num17 = ((lzham_lzham_decompressor*)ptr)->m_num_raw_bytes_remaining;
			num2 = ((lzham_lzham_decompressor*)ptr)->m_match_hist0;
			num3 = ((lzham_lzham_decompressor*)ptr)->m_match_hist1;
			num4 = ((lzham_lzham_decompressor*)ptr)->m_match_hist2;
			num5 = ((lzham_lzham_decompressor*)ptr)->m_match_hist3;
			num6 = ((lzham_lzham_decompressor*)ptr)->m_cur_state;
			_ = ((lzham_lzham_decompressor*)ptr)->m_dst_ofs;
			num8 = ((lzham_symbol_codec*)codec)->m_arith_value;
			num9 = ((lzham_symbol_codec*)codec)->m_arith_length;
			num10 = ((lzham_symbol_codec*)codec)->m_bit_buf;
			num11 = ((lzham_symbol_codec*)codec)->m_bit_count;
			ptr3 = ((lzham_symbol_codec*)codec)->m_pDecode_buf_next;
			num7 = 0;
			goto IL_3493;
		}
		IL_08ed:
		unchecked
		{
			long num54 = decode_get_bytes_consumed.Invoke(&((lzham_lzham_decompressor*)ptr)->m_codec);
			*(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size = num54;
			*(long*)((lzham_lzham_decompressor*)ptr)->m_pOut_buf_size = 0L;
			((lzham_lzham_decompressor*)ptr)->m_state = 370;
			return 2;
		}
		IL_40fa:
		num11 += 8;
		int num55;
		unchecked
		{
			num10 |= (long)((ulong)(uint)num55 << (int)(uint)checked(64 - num11));
			goto IL_3e9b;
		}
		IL_3dc9:
		int num56 = 0;
		unchecked
		{
			if (ptr3 < ((lzham_symbol_codec*)codec)->m_pDecode_buf_end)
			{
				void* ptr31 = ptr3;
				ptr3 = (byte*)ptr31 + 1;
				num56 = (byte)(*(sbyte*)ptr31);
			}
			goto IL_3e11;
		}
		IL_2e93:
		num22 = 0;
		unchecked
		{
			if (ptr3 < ((lzham_symbol_codec*)codec)->m_pDecode_buf_end)
			{
				void* ptr32 = ptr3;
				ptr3 = (byte*)ptr32 + 1;
				num22 = (byte)(*(sbyte*)ptr32);
			}
			goto IL_2edb;
		}
		IL_5d42:
		unchecked
		{
			long num57 = decode_get_bytes_consumed.Invoke(&((lzham_lzham_decompressor*)ptr)->m_codec);
			*(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size = num57;
			*(long*)((lzham_lzham_decompressor*)ptr)->m_pOut_buf_size = 0L;
			((lzham_lzham_decompressor*)ptr)->m_state = 780;
			return 2;
		}
		IL_0d06:
		int num58 = 0;
		unchecked
		{
			if (ptr3 < ((lzham_symbol_codec*)codec)->m_pDecode_buf_end)
			{
				void* ptr33 = ptr3;
				ptr3 = (byte*)ptr33 + 1;
				num58 = (byte)(*(sbyte*)ptr33);
			}
			goto IL_0d42;
		}
		IL_aa7e:
		int num59;
		unchecked
		{
			if (num11 < (num11 & 7))
			{
				if (ptr3 == ((lzham_symbol_codec*)codec)->m_pDecode_buf_end)
				{
					if ((((lzham_symbol_codec*)codec)->m_decode_buf_eof & 1) != 1)
					{
						((lzham_symbol_codec*)codec)->m_arith_value = num8;
						((lzham_symbol_codec*)codec)->m_arith_length = num9;
						((lzham_symbol_codec*)codec)->m_bit_buf = num10;
						((lzham_symbol_codec*)codec)->m_bit_count = num11;
						((lzham_symbol_codec*)codec)->m_pDecode_buf_next = ptr3;
						((lzham_lzham_decompressor*)ptr)->m_match_hist0 = num2;
						((lzham_lzham_decompressor*)ptr)->m_match_hist1 = num3;
						((lzham_lzham_decompressor*)ptr)->m_match_hist2 = num4;
						((lzham_lzham_decompressor*)ptr)->m_match_hist3 = num5;
						((lzham_lzham_decompressor*)ptr)->m_cur_state = num6;
						((lzham_lzham_decompressor*)ptr)->m_dst_ofs = num7;
						goto IL_ab6f;
					}
					goto IL_ac98;
				}
				void* ptr34 = ptr3;
				ptr3 = (byte*)ptr34 + 1;
				num59 = (byte)(*(sbyte*)ptr34);
				goto IL_ace0;
			}
			if ((num11 & 7) != 0)
			{
				_ = num10 >>> (int)(uint)checked(64 - (num11 & 7));
			}
			num10 <<= (int)(uint)(num11 & 7);
		}
		num11 -= num11 & 7;
		goto IL_ad65;
		IL_0d42:
		num11 += 8;
		unchecked
		{
			num10 |= (long)((ulong)(uint)num58 << (int)(uint)checked(64 - num11));
			goto IL_0b2b;
		}
		IL_0b2b:
		unchecked
		{
			if (num11 < 8)
			{
				if (ptr3 == ((lzham_symbol_codec*)codec)->m_pDecode_buf_end)
				{
					if ((((lzham_symbol_codec*)codec)->m_decode_buf_eof & 1) != 1)
					{
						((lzham_symbol_codec*)codec)->m_arith_value = num8;
						((lzham_symbol_codec*)codec)->m_arith_length = num9;
						((lzham_symbol_codec*)codec)->m_bit_buf = num10;
						((lzham_symbol_codec*)codec)->m_bit_count = num11;
						((lzham_symbol_codec*)codec)->m_pDecode_buf_next = ptr3;
						((lzham_lzham_decompressor*)ptr)->m_match_hist0 = num2;
						((lzham_lzham_decompressor*)ptr)->m_match_hist1 = num3;
						((lzham_lzham_decompressor*)ptr)->m_match_hist2 = num4;
						((lzham_lzham_decompressor*)ptr)->m_match_hist3 = num5;
						((lzham_lzham_decompressor*)ptr)->m_cur_state = num6;
						((lzham_lzham_decompressor*)ptr)->m_dst_ofs = num7;
						goto IL_0bed;
					}
					goto IL_0d06;
				}
				void* ptr35 = ptr3;
				ptr3 = (byte*)ptr35 + 1;
				num58 = (byte)(*(sbyte*)ptr35);
				goto IL_0d42;
			}
			int num60 = (int)(num10 >>> 56);
			num10 <<= 8;
			num11 = checked(num11 - 8);
			((lzham_lzham_decompressor*)ptr)->m_z_dict_adler32 = (((lzham_lzham_decompressor*)ptr)->m_z_dict_adler32 << 8) | num60;
			((lzham_lzham_decompressor*)ptr)->m_tmp++;
			goto IL_0b18;
		}
		IL_1a92:
		unchecked
		{
			long num61 = decode_get_bytes_consumed.Invoke(&((lzham_lzham_decompressor*)ptr)->m_codec);
			*(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size = num61;
			*(long*)((lzham_lzham_decompressor*)ptr)->m_pOut_buf_size = 0L;
			((lzham_lzham_decompressor*)ptr)->m_state = 447;
			return 2;
		}
		IL_74c9:
		unchecked
		{
			long num62 = decode_get_bytes_consumed.Invoke(&((lzham_lzham_decompressor*)ptr)->m_codec);
			*(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size = num62;
			*(long*)((lzham_lzham_decompressor*)ptr)->m_pOut_buf_size = 0L;
			((lzham_lzham_decompressor*)ptr)->m_state = 824;
			return 2;
		}
		IL_ace0:
		num11 += 8;
		unchecked
		{
			num10 |= (long)((ulong)(uint)num59 << (int)(uint)checked(64 - num11));
			goto IL_aa7e;
		}
		IL_ac98:
		num59 = 0;
		unchecked
		{
			if (ptr3 < ((lzham_symbol_codec*)codec)->m_pDecode_buf_end)
			{
				void* ptr36 = ptr3;
				ptr3 = (byte*)ptr36 + 1;
				num59 = (byte)(*(sbyte*)ptr36);
			}
			goto IL_ace0;
		}
		IL_42a8:
		unchecked
		{
			long num63 = decode_get_bytes_consumed.Invoke(&((lzham_lzham_decompressor*)ptr)->m_codec);
			*(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size = num63;
			*(long*)((lzham_lzham_decompressor*)ptr)->m_pOut_buf_size = 0L;
			((lzham_lzham_decompressor*)ptr)->m_state = 682;
			return 2;
		}
		IL_0b18:
		unchecked
		{
			if ((uint)((lzham_lzham_decompressor*)ptr)->m_tmp < 4u)
			{
				goto IL_0b2b;
			}
			if (adler32.Invoke(buflen: (uint)((lzham_lzham_decompressor*)ptr)->m_params.m_num_seed_bytes, pBuf: ((lzham_lzham_decompressor*)ptr)->m_params.m_pSeed_bytes, adler32: 1) == ((lzham_lzham_decompressor*)ptr)->m_z_dict_adler32)
			{
				goto IL_0dfc;
			}
			return 13;
		}
		IL_9335:
		num11 += 8;
		unchecked
		{
			num10 |= (long)((ulong)(uint)num39 << (int)(uint)checked(64 - num11));
			goto IL_9087;
		}
		IL_a1ed:
		num12 = unchecked(num12 + -1);
		if (num12 == 0)
		{
			goto IL_417b;
		}
		goto IL_9d59;
		IL_0dfc:
		unchecked
		{
			int num64 = ((lzham_lzham_decompressor*)ptr)->m_params.m_table_max_update_interval;
			int num65 = ((lzham_lzham_decompressor*)ptr)->m_params.m_table_update_interval_slow_rate;
			if (num64 == 0 && num65 == 0)
			{
				int num66 = ((lzham_lzham_decompressor*)ptr)->m_params.m_table_update_rate;
				if (num66 == 0)
				{
					num66 = 8;
				}
				num66 = clamp.Invoke(num66, 1, 20) - 1;
				num64 = (ushort)((lzham_table_update_settings*)g_table_update_settings.Pointer)[(uint)num66].m_max_update_interval;
				num65 = (ushort)((lzham_table_update_settings*)g_table_update_settings.Pointer)[(uint)num66].m_slow_rate;
			}
			bool flag = init2.Invoke(&((lzham_lzham_decompressor*)ptr)->m_lit_table, encoding: false, 256, num64, num65, null);
			if (ExceptionInfo.Current != null)
			{
				return 0;
			}
			int num67;
			if (((flag ? 1u : 0u) & 1u) != 1)
			{
				num67 = 0;
			}
			else
			{
				bool flag2 = assign_7mvy2m.Invoke(&((lzham_lzham_decompressor*)ptr)->m_delta_lit_table, &((lzham_lzham_decompressor*)ptr)->m_lit_table);
				if (ExceptionInfo.Current != null)
				{
					return 0;
				}
				num67 = (flag2 ? 1 : 0);
			}
			int num68;
			if (((byte)num67 & 1) != 1)
			{
				num68 = 0;
			}
			else
			{
				bool flag3 = init2.Invoke(&((lzham_lzham_decompressor*)ptr)->m_main_table, encoding: false, 2 + (((lzham_lzham_decompressor*)ptr)->m_lzBase.m_match_hist - 1) * 8, num64, num65, null);
				if (ExceptionInfo.Current != null)
				{
					return 0;
				}
				num68 = (flag3 ? 1 : 0);
			}
			int num69;
			if (((byte)num68 & 1) != 1)
			{
				num69 = 0;
			}
			else
			{
				bool flag4 = init2.Invoke(&((lzham_lzham_decompressor*)ptr)->m_rep_len_table, encoding: false, 257, num64, num65, null);
				if (ExceptionInfo.Current != null)
				{
					return 0;
				}
				num69 = (flag4 ? 1 : 0);
			}
			int num70;
			if (((byte)num69 & 1) != 1)
			{
				num70 = 0;
			}
			else
			{
				bool flag5 = assign_7mvy2m.Invoke((byte*)(&((lzham_lzham_decompressor*)ptr)->m_rep_len_table) + sizeof(lzham_quasi_adaptive_huffman_data_model), &((lzham_lzham_decompressor*)ptr)->m_rep_len_table);
				if (ExceptionInfo.Current != null)
				{
					return 0;
				}
				num70 = (flag5 ? 1 : 0);
			}
			int num71;
			if (((byte)num70 & 1) != 1)
			{
				num71 = 0;
			}
			else
			{
				bool flag6 = init2.Invoke(&((lzham_lzham_decompressor*)ptr)->m_large_len_table, encoding: false, 250, num64, num65, null);
				if (ExceptionInfo.Current != null)
				{
					return 0;
				}
				num71 = (flag6 ? 1 : 0);
			}
			int num72;
			if (((byte)num71 & 1) != 1)
			{
				num72 = 0;
			}
			else
			{
				bool flag7 = assign_7mvy2m.Invoke((byte*)(&((lzham_lzham_decompressor*)ptr)->m_large_len_table) + sizeof(lzham_quasi_adaptive_huffman_data_model), &((lzham_lzham_decompressor*)ptr)->m_large_len_table);
				if (ExceptionInfo.Current != null)
				{
					return 0;
				}
				num72 = (flag7 ? 1 : 0);
			}
			int num73;
			if (((byte)num72 & 1) != 1)
			{
				num73 = 0;
			}
			else
			{
				bool flag8 = init2.Invoke(&((lzham_lzham_decompressor*)ptr)->m_dist_lsb_table, encoding: false, 16, num64, num65, null);
				if (ExceptionInfo.Current != null)
				{
					return 0;
				}
				num73 = (flag8 ? 1 : 0);
			}
			if (((byte)num73 & 1) != 1)
			{
				return 4;
			}
			goto IL_10e6;
		}
		IL_b024:
		unchecked
		{
			if (num11 < 16)
			{
				if (ptr3 == ((lzham_symbol_codec*)codec)->m_pDecode_buf_end)
				{
					if ((((lzham_symbol_codec*)codec)->m_decode_buf_eof & 1) != 1)
					{
						((lzham_symbol_codec*)codec)->m_arith_value = num8;
						((lzham_symbol_codec*)codec)->m_arith_length = num9;
						((lzham_symbol_codec*)codec)->m_bit_buf = num10;
						((lzham_symbol_codec*)codec)->m_bit_count = num11;
						((lzham_symbol_codec*)codec)->m_pDecode_buf_next = ptr3;
						((lzham_lzham_decompressor*)ptr)->m_match_hist0 = num2;
						((lzham_lzham_decompressor*)ptr)->m_match_hist1 = num3;
						((lzham_lzham_decompressor*)ptr)->m_match_hist2 = num4;
						((lzham_lzham_decompressor*)ptr)->m_match_hist3 = num5;
						((lzham_lzham_decompressor*)ptr)->m_cur_state = num6;
						((lzham_lzham_decompressor*)ptr)->m_dst_ofs = num7;
						goto IL_b113;
					}
					goto IL_b23c;
				}
				void* ptr37 = ptr3;
				ptr3 = (byte*)ptr37 + 1;
				num50 = (byte)(*(sbyte*)ptr37);
				goto IL_b284;
			}
			int num74 = (int)(num10 >>> 48);
			num10 <<= 16;
			num11 = checked(num11 - 16);
			((lzham_lzham_decompressor*)ptr)->m_file_src_file_adler32 = (((lzham_lzham_decompressor*)ptr)->m_file_src_file_adler32 << 16) | num74;
			if ((((lzham_lzham_decompressor*)ptr)->m_params.m_decompress_flags & 2) != 0)
			{
				((lzham_lzham_decompressor*)ptr)->m_decomp_adler32 = adler32.Invoke(pOut_buf, (uint)num7, 1);
				if (((lzham_lzham_decompressor*)ptr)->m_file_src_file_adler32 != ((lzham_lzham_decompressor*)ptr)->m_decomp_adler32)
				{
					((lzham_lzham_decompressor*)ptr)->m_status = 8;
				}
			}
			else
			{
				((lzham_lzham_decompressor*)ptr)->m_decomp_adler32 = ((lzham_lzham_decompressor*)ptr)->m_file_src_file_adler32;
			}
			goto IL_b368;
		}
		IL_7643:
		num11 += 8;
		int num75;
		unchecked
		{
			num10 |= (long)((ulong)(uint)num75 << (int)(uint)checked(64 - num11));
			goto IL_73b5;
		}
		IL_1bbb:
		int num76 = 0;
		unchecked
		{
			if (ptr3 < ((lzham_symbol_codec*)codec)->m_pDecode_buf_end)
			{
				void* ptr38 = ptr3;
				ptr3 = (byte*)ptr38 + 1;
				num76 = (byte)(*(sbyte*)ptr38);
			}
			goto IL_1c03;
		}
		IL_b284:
		num11 += 8;
		unchecked
		{
			num10 |= (long)((ulong)(uint)num50 << (int)(uint)checked(64 - num11));
			goto IL_b024;
		}
		IL_6531:
		int num78;
		unchecked
		{
			while (num11 >= 1)
			{
				int num77 = (int)(num10 >>> 63);
				num10 <<= 1;
				num11 = checked(num11 - 1);
				if (num77 != 0)
				{
					num12++;
					if ((uint)num12 < 3u)
					{
						continue;
					}
				}
				goto IL_681d;
			}
			if (ptr3 == ((lzham_symbol_codec*)codec)->m_pDecode_buf_end)
			{
				if ((((lzham_symbol_codec*)codec)->m_decode_buf_eof & 1) != 1)
				{
					((lzham_symbol_codec*)codec)->m_arith_value = num8;
					((lzham_symbol_codec*)codec)->m_arith_length = num9;
					((lzham_symbol_codec*)codec)->m_bit_buf = num10;
					((lzham_symbol_codec*)codec)->m_bit_count = num11;
					((lzham_symbol_codec*)codec)->m_pDecode_buf_next = ptr3;
					((lzham_lzham_decompressor*)ptr)->m_match_len = num12;
					((lzham_lzham_decompressor*)ptr)->m_match_hist0 = num2;
					((lzham_lzham_decompressor*)ptr)->m_match_hist1 = num3;
					((lzham_lzham_decompressor*)ptr)->m_match_hist2 = num4;
					((lzham_lzham_decompressor*)ptr)->m_match_hist3 = num5;
					((lzham_lzham_decompressor*)ptr)->m_cur_state = num6;
					((lzham_lzham_decompressor*)ptr)->m_dst_ofs = num7;
					goto IL_6630;
				}
				goto IL_6762;
			}
			void* ptr39 = ptr3;
			ptr3 = (byte*)ptr39 + 1;
			num78 = (byte)(*(sbyte*)ptr39);
			goto IL_67aa;
		}
		IL_3493:
		num17 = unchecked(num17 + -1);
		if (num17 != 0)
		{
			goto IL_2f60;
		}
		goto IL_34aa;
		IL_8c0f:
		int num79 = 0;
		unchecked
		{
			if (ptr3 < ((lzham_symbol_codec*)codec)->m_pDecode_buf_end)
			{
				void* ptr40 = ptr3;
				ptr3 = (byte*)ptr40 + 1;
				num79 = (byte)(*(sbyte*)ptr40);
			}
			goto IL_8c57;
		}
		IL_9059:
		unchecked
		{
			_ = &((lzham_lzham_decompressor*)ptr)->m_lzBase;
			num15 = (byte)((sbyte*)m_lzx_position_extra_bits.Pointer)[(uint)num13];
			if ((uint)num15 < 3u)
			{
				goto IL_9087;
			}
			num14 = 0;
			if ((uint)num15 <= 4u)
			{
				goto IL_96ff;
			}
			goto IL_93c5;
		}
		IL_3528:
		unchecked
		{
			if ((((num19 != 0L) ? 1u : 0u) ^ 0xFFFFFFFFu) != 0)
			{
				*(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size = num18;
				*(long*)((lzham_lzham_decompressor*)ptr)->m_pOut_buf_size = 0L;
				if ((((lzham_lzham_decompressor*)ptr)->m_no_more_input_bytes_flag & 1) == 1)
				{
					goto IL_3578;
				}
				((lzham_lzham_decompressor*)ptr)->m_num_raw_bytes_remaining = num17;
				((lzham_lzham_decompressor*)ptr)->m_match_hist0 = num2;
				((lzham_lzham_decompressor*)ptr)->m_match_hist1 = num3;
				((lzham_lzham_decompressor*)ptr)->m_match_hist2 = num4;
				((lzham_lzham_decompressor*)ptr)->m_match_hist3 = num5;
				((lzham_lzham_decompressor*)ptr)->m_cur_state = num6;
				((lzham_lzham_decompressor*)ptr)->m_dst_ofs = num7;
				((lzham_lzham_decompressor*)ptr)->m_state = 588;
				return 2;
			}
			int num80 = (int)(((ulong)(uint)num17 >= (ulong)num19) ? num19 : ((uint)num17));
			if ((ulong)(uint)(num7 + num80) > (ulong)pOut_buf_size)
			{
				*(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size = num18;
				*(long*)((lzham_lzham_decompressor*)ptr)->m_pOut_buf_size = 0L;
				goto IL_370b;
			}
			llvm_memcpy_p0_p0_i64.Invoke((byte*)pOut_buf + (uint)num7, (byte*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf + num18, (uint)num80, isVolatile: false);
			num18 += (uint)num80;
			num17 -= num80;
			decode_set_input_buffer.Invoke(codec, eof_flag: (((lzham_lzham_decompressor*)ptr)->m_no_more_input_bytes_flag & 1) == 1, pBuf_next: (byte*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf + num18, buf_size: *(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size, pBuf: ((lzham_lzham_decompressor*)ptr)->m_pIn_buf);
			num7 += num80;
			if (uint.MaxValue != 0 || (uint)num7 <= uint.MaxValue)
			{
				goto IL_3501;
			}
			int num_raw_bytes_remaining2;
			((lzham_lzham_decompressor*)ptr)->m_num_raw_bytes_remaining = num_raw_bytes_remaining2;
			int match_hist9;
			((lzham_lzham_decompressor*)ptr)->m_match_hist0 = match_hist9;
			int match_hist10;
			((lzham_lzham_decompressor*)ptr)->m_match_hist1 = match_hist10;
			int match_hist11;
			((lzham_lzham_decompressor*)ptr)->m_match_hist2 = match_hist11;
			int match_hist12;
			((lzham_lzham_decompressor*)ptr)->m_match_hist3 = match_hist12;
			int cur_state3;
			((lzham_lzham_decompressor*)ptr)->m_cur_state = cur_state3;
			int dst_ofs3;
			((lzham_lzham_decompressor*)ptr)->m_dst_ofs = dst_ofs3;
			_ = (byte*)((lzham_lzham_decompressor*)ptr)->m_pDecomp_buf + (uint)((lzham_lzham_decompressor*)ptr)->m_seed_bytes_to_ignore_when_flushing + (uint)((lzham_lzham_decompressor*)ptr)->m_dst_highwater_ofs;
			sbyte* pFlush_src9;
			((lzham_lzham_decompressor*)ptr)->m_pFlush_src = pFlush_src9;
			_ = (uint)(num - ((lzham_lzham_decompressor*)ptr)->m_seed_bytes_to_ignore_when_flushing - ((lzham_lzham_decompressor*)ptr)->m_dst_highwater_ofs);
			long flush_num_bytes_remaining3;
			((lzham_lzham_decompressor*)ptr)->m_flush_num_bytes_remaining = flush_num_bytes_remaining3;
			((lzham_lzham_decompressor*)ptr)->m_seed_bytes_to_ignore_when_flushing = 0;
			int dst_highwater_ofs3;
			((lzham_lzham_decompressor*)ptr)->m_dst_highwater_ofs = dst_highwater_ofs3;
			goto IL_38aa;
		}
		IL_3501:
		unchecked
		{
			if (num17 != 0)
			{
				num18 = decode_get_bytes_consumed.Invoke(codec);
				num19 = *(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size - num18;
				goto IL_3528;
			}
			num8 = ((lzham_symbol_codec*)codec)->m_arith_value;
			num9 = ((lzham_symbol_codec*)codec)->m_arith_length;
			num10 = ((lzham_symbol_codec*)codec)->m_bit_buf;
			num11 = ((lzham_symbol_codec*)codec)->m_bit_count;
			ptr3 = ((lzham_symbol_codec*)codec)->m_pDecode_buf_next;
			goto IL_a61f;
		}
		IL_34aa:
		unchecked
		{
			((lzham_symbol_codec*)codec)->m_arith_value = num8;
			((lzham_symbol_codec*)codec)->m_arith_length = num9;
			((lzham_symbol_codec*)codec)->m_bit_buf = num10;
			((lzham_symbol_codec*)codec)->m_bit_count = num11;
			((lzham_symbol_codec*)codec)->m_pDecode_buf_next = ptr3;
			goto IL_3501;
		}
		IL_af7d:
		int num81 = 0;
		unchecked
		{
			if (ptr3 < ((lzham_symbol_codec*)codec)->m_pDecode_buf_end)
			{
				void* ptr41 = ptr3;
				ptr3 = (byte*)ptr41 + 1;
				num81 = (byte)(*(sbyte*)ptr41);
			}
			goto IL_afc5;
		}
		IL_a401:
		unchecked
		{
			long num82 = decode_get_bytes_consumed.Invoke(&((lzham_lzham_decompressor*)ptr)->m_codec);
			*(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size = num82;
			*(long*)((lzham_lzham_decompressor*)ptr)->m_pOut_buf_size = 0L;
			((lzham_lzham_decompressor*)ptr)->m_state = 1054;
			return 2;
		}
		IL_8def:
		unchecked
		{
			long num83 = decode_get_bytes_consumed.Invoke(&((lzham_lzham_decompressor*)ptr)->m_codec);
			*(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size = num83;
			*(long*)((lzham_lzham_decompressor*)ptr)->m_pOut_buf_size = 0L;
			((lzham_lzham_decompressor*)ptr)->m_state = 912;
			return 2;
		}
		IL_8757:
		int num84 = 0;
		unchecked
		{
			if (ptr3 < ((lzham_symbol_codec*)codec)->m_pDecode_buf_end)
			{
				void* ptr42 = ptr3;
				ptr3 = (byte*)ptr42 + 1;
				num84 = (byte)(*(sbyte*)ptr42);
			}
			num11 = checked(num11 + 8);
			num10 |= (long)((ulong)(uint)num84 << (int)(uint)checked(64 - num11));
			goto IL_84fa;
		}
		IL_3578:
		unchecked((lzham_lzham_decompressor*)ptr)->m_state = 584;
		return 6;
		IL_370b:
		unchecked((lzham_lzham_decompressor*)ptr)->m_state = 608;
		return 5;
		IL_681d:
		int num85;
		unchecked
		{
			if (num11 < (byte)((sbyte*)s_huge_match_code_len.Pointer)[(uint)num12])
			{
				if (ptr3 == ((lzham_symbol_codec*)codec)->m_pDecode_buf_end)
				{
					if ((((lzham_symbol_codec*)codec)->m_decode_buf_eof & 1) != 1)
					{
						((lzham_symbol_codec*)codec)->m_arith_value = num8;
						((lzham_symbol_codec*)codec)->m_arith_length = num9;
						((lzham_symbol_codec*)codec)->m_bit_buf = num10;
						((lzham_symbol_codec*)codec)->m_bit_count = num11;
						((lzham_symbol_codec*)codec)->m_pDecode_buf_next = ptr3;
						((lzham_lzham_decompressor*)ptr)->m_match_len = num12;
						((lzham_lzham_decompressor*)ptr)->m_match_hist0 = num2;
						((lzham_lzham_decompressor*)ptr)->m_match_hist1 = num3;
						((lzham_lzham_decompressor*)ptr)->m_match_hist2 = num4;
						((lzham_lzham_decompressor*)ptr)->m_match_hist3 = num5;
						((lzham_lzham_decompressor*)ptr)->m_cur_state = num6;
						((lzham_lzham_decompressor*)ptr)->m_dst_ofs = num7;
						goto IL_6931;
					}
					goto IL_6a63;
				}
				void* ptr43 = ptr3;
				ptr3 = (byte*)ptr43 + 1;
				num35 = (byte)(*(sbyte*)ptr43);
				goto IL_6aab;
			}
			num85 = (int)(((bool*)s_huge_match_code_len.Pointer)[(uint)num12] ? (num10 >>> (int)(uint)checked(64 - unchecked((byte)((sbyte*)s_huge_match_code_len.Pointer)[(uint)num12]))) : 0);
			num10 <<= (int)(byte)((sbyte*)s_huge_match_code_len.Pointer)[(uint)num12];
		}
		num11 -= unchecked((byte)((sbyte*)s_huge_match_code_len.Pointer)[(uint)num12]);
		num12 = unchecked(((int*)s_huge_match_base_len.Pointer)[(uint)num12] + num85);
		goto IL_6b90;
		IL_67aa:
		num11 += 8;
		unchecked
		{
			num10 |= (long)((ulong)(uint)num78 << (int)(uint)checked(64 - num11));
			goto IL_6531;
		}
		IL_8f72:
		num11 += 8;
		unchecked
		{
			num10 |= (long)((ulong)(uint)num27 << (int)(uint)checked(64 - num11));
			goto IL_8cca;
		}
		IL_6762:
		num78 = 0;
		unchecked
		{
			if (ptr3 < ((lzham_symbol_codec*)codec)->m_pDecode_buf_end)
			{
				void* ptr44 = ptr3;
				ptr3 = (byte*)ptr44 + 1;
				num78 = (byte)(*(sbyte*)ptr44);
			}
			goto IL_67aa;
		}
		IL_ad65:
		unchecked
		{
			if (num11 < 16)
			{
				if (ptr3 == ((lzham_symbol_codec*)codec)->m_pDecode_buf_end)
				{
					if ((((lzham_symbol_codec*)codec)->m_decode_buf_eof & 1) != 1)
					{
						((lzham_symbol_codec*)codec)->m_arith_value = num8;
						((lzham_symbol_codec*)codec)->m_arith_length = num9;
						((lzham_symbol_codec*)codec)->m_bit_buf = num10;
						((lzham_symbol_codec*)codec)->m_bit_count = num11;
						((lzham_symbol_codec*)codec)->m_pDecode_buf_next = ptr3;
						((lzham_lzham_decompressor*)ptr)->m_match_hist0 = num2;
						((lzham_lzham_decompressor*)ptr)->m_match_hist1 = num3;
						((lzham_lzham_decompressor*)ptr)->m_match_hist2 = num4;
						((lzham_lzham_decompressor*)ptr)->m_match_hist3 = num5;
						((lzham_lzham_decompressor*)ptr)->m_cur_state = num6;
						((lzham_lzham_decompressor*)ptr)->m_dst_ofs = num7;
						goto IL_ae54;
					}
					goto IL_af7d;
				}
				void* ptr45 = ptr3;
				ptr3 = (byte*)ptr45 + 1;
				num81 = (byte)(*(sbyte*)ptr45);
				goto IL_afc5;
			}
			((lzham_lzham_decompressor*)ptr)->m_file_src_file_adler32 = (int)(num10 >>> 48);
			num10 <<= 16;
		}
		num11 -= 16;
		goto IL_b024;
		IL_4197:
		void* ptr46;
		void* ptr47;
		int num92;
		int num91;
		unchecked
		{
			if ((uint)num9 < 16777216u)
			{
				((lzham_symbol_codec*)codec)->m_pSaved_model = ptr46;
				goto IL_41ba;
			}
			int num86 = (ushort)((lzham_adaptive_bit_model*)ptr46)->m_bit_0_prob * (num9 >>> 11);
			int num87 = (((uint)num8 >= (uint)num86) ? 1 : 0);
			if (num87 == 0)
			{
				int num88 = 2048 - (ushort)((lzham_adaptive_bit_model*)ptr46)->m_bit_0_prob >>> 5;
				short* bit_0_prob3 = &((lzham_adaptive_bit_model*)ptr46)->m_bit_0_prob;
				*bit_0_prob3 = (short)((ushort)(*bit_0_prob3) + num88);
				num9 = num86;
			}
			else
			{
				int num89 = (ushort)((lzham_adaptive_bit_model*)ptr46)->m_bit_0_prob >> 5;
				short* bit_0_prob4 = &((lzham_adaptive_bit_model*)ptr46)->m_bit_0_prob;
				*bit_0_prob4 = (short)checked(unchecked((ushort)(*bit_0_prob4)) - num89);
				num8 -= num86;
				num9 -= num86;
			}
			if (num87 == 0)
			{
				if ((ulong)(uint)num7 >= (ulong)pOut_buf_size)
				{
					((lzham_symbol_codec*)codec)->m_arith_value = num8;
					((lzham_symbol_codec*)codec)->m_arith_length = num9;
					((lzham_symbol_codec*)codec)->m_bit_buf = num10;
					((lzham_symbol_codec*)codec)->m_bit_count = num11;
					((lzham_symbol_codec*)codec)->m_pDecode_buf_next = ptr3;
					long num90 = decode_get_bytes_consumed.Invoke(codec);
					*(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size = num90;
					*(long*)((lzham_lzham_decompressor*)ptr)->m_pOut_buf_size = 0L;
					goto IL_45ec;
				}
				if ((uint)num6 < 7u)
				{
					ptr10 = &((lzham_lzham_decompressor*)ptr)->m_lit_table;
					pDecode_tables7 = ((lzham_raw_quasi_adaptive_huffman_data_model*)(&((lzham_lzham_decompressor*)ptr)->m_lit_table))->m_pDecode_tables;
					if (num11 < 24)
					{
						ptr3 = (byte*)ptr3 + 4;
						if (ptr3 >= ((lzham_symbol_codec*)codec)->m_pDecode_buf_end)
						{
							ptr3 = (byte*)ptr3 + -4;
							goto IL_4659;
						}
						num91 = ((byte)((sbyte*)ptr3)[-4] << 24) | (((byte*)ptr3 + -4)[1] << 16) | (((byte*)ptr3 + -4)[2] << 8) | ((byte*)ptr3 + -4)[3];
						num11 = checked(num11 + 32);
						num10 |= (long)((ulong)(uint)num91 << (int)(uint)checked(64 - num11));
					}
					goto IL_4942;
				}
				num16 = (byte)((sbyte*)pOut_buf)[(uint)((num7 - num2) & -1)];
				ptr9 = &((lzham_lzham_decompressor*)ptr)->m_delta_lit_table;
				pDecode_tables6 = ((lzham_raw_quasi_adaptive_huffman_data_model*)(&((lzham_lzham_decompressor*)ptr)->m_delta_lit_table))->m_pDecode_tables;
				if (num11 < 24)
				{
					ptr3 = (byte*)ptr3 + 4;
					if (ptr3 >= ((lzham_symbol_codec*)codec)->m_pDecode_buf_end)
					{
						ptr3 = (byte*)ptr3 + -4;
						goto IL_4b42;
					}
					num92 = ((byte)((sbyte*)ptr3)[-4] << 24) | (((byte*)ptr3 + -4)[1] << 16) | (((byte*)ptr3 + -4)[2] << 8) | ((byte*)ptr3 + -4)[3];
					num11 = checked(num11 + 32);
					num10 |= (long)((ulong)(uint)num92 << (int)(uint)checked(64 - num11));
				}
				goto IL_4e45;
			}
			num12 = 1;
			ptr47 = (byte*)(&((lzham_lzham_decompressor*)ptr)->m_is_rep_model) + (nint)(uint)num6 * (nint)sizeof(lzham_adaptive_bit_model);
			goto IL_5438;
		}
		IL_7740:
		void* ptr48;
		void* ptr49;
		unchecked
		{
			if ((uint)num9 < 16777216u)
			{
				((lzham_symbol_codec*)codec)->m_pSaved_model = ptr48;
				goto IL_7763;
			}
			int num93 = (ushort)((lzham_adaptive_bit_model*)ptr48)->m_bit_0_prob * (num9 >>> 11);
			int num94 = (((uint)num8 >= (uint)num93) ? 1 : 0);
			if (num94 == 0)
			{
				int num95 = 2048 - (ushort)((lzham_adaptive_bit_model*)ptr48)->m_bit_0_prob >>> 5;
				short* bit_0_prob5 = &((lzham_adaptive_bit_model*)ptr48)->m_bit_0_prob;
				*bit_0_prob5 = (short)((ushort)(*bit_0_prob5) + num95);
				num9 = num93;
			}
			else
			{
				int num96 = (ushort)((lzham_adaptive_bit_model*)ptr48)->m_bit_0_prob >> 5;
				short* bit_0_prob6 = &((lzham_adaptive_bit_model*)ptr48)->m_bit_0_prob;
				*bit_0_prob6 = (short)checked(unchecked((ushort)(*bit_0_prob6)) - num96);
				num8 -= num93;
				num9 -= num93;
			}
			if (num94 != 0)
			{
				int num97 = num3;
				num3 = num2;
				num2 = num97;
				goto IL_7f45;
			}
			ptr49 = (byte*)(&((lzham_lzham_decompressor*)ptr)->m_is_rep2_model) + (nint)(uint)num6 * (nint)sizeof(lzham_adaptive_bit_model);
			goto IL_7b42;
		}
		IL_38aa:
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
					long num99;
					for (long num98 = 0L; (ulong)num98 < (ulong)((lzham_lzham_decompressor*)ptr)->m_flush_n; num98 += num99)
					{
						num99 = (((ulong)(((lzham_lzham_decompressor*)ptr)->m_flush_n - num98) >= 8192uL) ? 8192L : (((lzham_lzham_decompressor*)ptr)->m_flush_n - num98));
						llvm_memcpy_p0_p0_i64.Invoke((byte*)((lzham_lzham_decompressor*)ptr)->m_pOut_buf + num98, (byte*)((lzham_lzham_decompressor*)ptr)->m_pFlush_src + num98, num99, isVolatile: false);
						((lzham_lzham_decompressor*)ptr)->m_decomp_adler32 = adler32.Invoke(adler32: ((lzham_lzham_decompressor*)ptr)->m_decomp_adler32, pBuf: (byte*)((lzham_lzham_decompressor*)ptr)->m_pFlush_src + num98, buflen: num99);
					}
				}
				long num100 = decode_get_bytes_consumed.Invoke(&((lzham_lzham_decompressor*)ptr)->m_codec);
				*(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size = num100;
				long flush_n15 = ((lzham_lzham_decompressor*)ptr)->m_flush_n;
				*(long*)((lzham_lzham_decompressor*)ptr)->m_pOut_buf_size = flush_n15;
				((lzham_lzham_decompressor*)ptr)->m_state = 625;
				return InstructionHelper.Select(((lzham_lzham_decompressor*)ptr)->m_flush_n != 0L, 0, 1);
			}
			num17 = ((lzham_lzham_decompressor*)ptr)->m_num_raw_bytes_remaining;
			num2 = ((lzham_lzham_decompressor*)ptr)->m_match_hist0;
			num3 = ((lzham_lzham_decompressor*)ptr)->m_match_hist1;
			num4 = ((lzham_lzham_decompressor*)ptr)->m_match_hist2;
			num5 = ((lzham_lzham_decompressor*)ptr)->m_match_hist3;
			num6 = ((lzham_lzham_decompressor*)ptr)->m_cur_state;
			_ = ((lzham_lzham_decompressor*)ptr)->m_dst_ofs;
			num7 = 0;
			goto IL_3501;
		}
		IL_584f:
		unchecked
		{
			if (num11 < 8)
			{
				if (ptr3 == ((lzham_symbol_codec*)codec)->m_pDecode_buf_end)
				{
					if ((((lzham_symbol_codec*)codec)->m_decode_buf_eof & 1) != 1)
					{
						((lzham_symbol_codec*)codec)->m_arith_value = num8;
						((lzham_symbol_codec*)codec)->m_arith_length = num9;
						((lzham_symbol_codec*)codec)->m_bit_buf = num10;
						((lzham_symbol_codec*)codec)->m_bit_count = num11;
						((lzham_symbol_codec*)codec)->m_pDecode_buf_next = ptr3;
						((lzham_lzham_decompressor*)ptr)->m_match_len = num12;
						((lzham_lzham_decompressor*)ptr)->m_match_hist0 = num2;
						((lzham_lzham_decompressor*)ptr)->m_match_hist1 = num3;
						((lzham_lzham_decompressor*)ptr)->m_match_hist2 = num4;
						((lzham_lzham_decompressor*)ptr)->m_match_hist3 = num5;
						((lzham_lzham_decompressor*)ptr)->m_cur_state = num6;
						((lzham_lzham_decompressor*)ptr)->m_dst_ofs = num7;
						goto IL_594e;
					}
					goto IL_5a80;
				}
				void* ptr50 = ptr3;
				ptr3 = (byte*)ptr50 + 1;
				num26 = (byte)(*(sbyte*)ptr50);
				goto IL_5ac8;
			}
			int num101 = (int)(num10 >>> 56);
			num10 <<= 8;
			num11 = checked(num11 - 8);
			ptr22 = ((lzham_symbol_codec*)codec)->m_pSaved_model;
			num8 = (num8 << 8) | num101;
			num9 <<= 8;
			goto IL_582c;
		}
		IL_41ba:
		int num102;
		unchecked
		{
			if (num11 < 8)
			{
				if (ptr3 == ((lzham_symbol_codec*)codec)->m_pDecode_buf_end)
				{
					if ((((lzham_symbol_codec*)codec)->m_decode_buf_eof & 1) != 1)
					{
						((lzham_symbol_codec*)codec)->m_arith_value = num8;
						((lzham_symbol_codec*)codec)->m_arith_length = num9;
						((lzham_symbol_codec*)codec)->m_bit_buf = num10;
						((lzham_symbol_codec*)codec)->m_bit_count = num11;
						((lzham_symbol_codec*)codec)->m_pDecode_buf_next = ptr3;
						((lzham_lzham_decompressor*)ptr)->m_match_hist0 = num2;
						((lzham_lzham_decompressor*)ptr)->m_match_hist1 = num3;
						((lzham_lzham_decompressor*)ptr)->m_match_hist2 = num4;
						((lzham_lzham_decompressor*)ptr)->m_match_hist3 = num5;
						((lzham_lzham_decompressor*)ptr)->m_cur_state = num6;
						((lzham_lzham_decompressor*)ptr)->m_dst_ofs = num7;
						goto IL_42a8;
					}
					goto IL_43d1;
				}
				void* ptr51 = ptr3;
				ptr3 = (byte*)ptr51 + 1;
				num102 = (byte)(*(sbyte*)ptr51);
				goto IL_4419;
			}
			int num103 = (int)(num10 >>> 56);
			num10 <<= 8;
			num11 = checked(num11 - 8);
			ptr46 = ((lzham_symbol_codec*)codec)->m_pSaved_model;
			num8 = (num8 << 8) | num103;
			num9 <<= 8;
			goto IL_4197;
		}
		IL_ab6f:
		unchecked
		{
			long num104 = decode_get_bytes_consumed.Invoke(&((lzham_lzham_decompressor*)ptr)->m_codec);
			*(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size = num104;
			*(long*)((lzham_lzham_decompressor*)ptr)->m_pOut_buf_size = 0L;
			((lzham_lzham_decompressor*)ptr)->m_state = 1080;
			return 2;
		}
		IL_99c0:
		num38 = 0;
		unchecked
		{
			if (ptr3 < ((lzham_symbol_codec*)codec)->m_pDecode_buf_end)
			{
				void* ptr52 = ptr3;
				ptr3 = (byte*)ptr52 + 1;
				num38 = (byte)(*(sbyte*)ptr52);
			}
			num11 = checked(num11 + 8);
			num10 |= (long)((ulong)(uint)num38 << (int)(uint)checked(64 - num11));
			goto IL_9749;
		}
		IL_43d1:
		num102 = 0;
		unchecked
		{
			if (ptr3 < ((lzham_symbol_codec*)codec)->m_pDecode_buf_end)
			{
				void* ptr53 = ptr3;
				ptr3 = (byte*)ptr53 + 1;
				num102 = (byte)(*(sbyte*)ptr53);
			}
			goto IL_4419;
		}
		IL_aa5a:
		if (unchecked((lzham_lzham_decompressor*)ptr)->m_status != 3)
		{
			goto IL_b368;
		}
		if ((num11 & 7) == 0)
		{
			goto IL_ad65;
		}
		goto IL_aa7e;
		IL_19a3:
		unchecked
		{
			if (num11 < 16)
			{
				if (ptr3 == ((lzham_symbol_codec*)codec)->m_pDecode_buf_end)
				{
					if ((((lzham_symbol_codec*)codec)->m_decode_buf_eof & 1) != 1)
					{
						((lzham_symbol_codec*)codec)->m_arith_value = num8;
						((lzham_symbol_codec*)codec)->m_arith_length = num9;
						((lzham_symbol_codec*)codec)->m_bit_buf = num10;
						((lzham_symbol_codec*)codec)->m_bit_count = num11;
						((lzham_symbol_codec*)codec)->m_pDecode_buf_next = ptr3;
						((lzham_lzham_decompressor*)ptr)->m_match_hist0 = num2;
						((lzham_lzham_decompressor*)ptr)->m_match_hist1 = num3;
						((lzham_lzham_decompressor*)ptr)->m_match_hist2 = num4;
						((lzham_lzham_decompressor*)ptr)->m_match_hist3 = num5;
						((lzham_lzham_decompressor*)ptr)->m_cur_state = num6;
						((lzham_lzham_decompressor*)ptr)->m_dst_ofs = num7;
						goto IL_1a92;
					}
					goto IL_1bbb;
				}
				void* ptr54 = ptr3;
				ptr3 = (byte*)ptr54 + 1;
				num76 = (byte)(*(sbyte*)ptr54);
				goto IL_1c03;
			}
			int num105 = (int)(num10 >>> 48);
			num10 <<= 16;
			num11 = checked(num11 - 16);
			if (num105 == 0)
			{
				goto IL_1cfd;
			}
			((lzham_symbol_codec*)codec)->m_arith_value = num8;
			((lzham_symbol_codec*)codec)->m_arith_length = num9;
			((lzham_symbol_codec*)codec)->m_bit_buf = num10;
			((lzham_symbol_codec*)codec)->m_bit_count = num11;
			((lzham_symbol_codec*)codec)->m_pDecode_buf_next = ptr3;
			long num106 = decode_get_bytes_consumed.Invoke(codec);
			*(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size = num106;
			*(long*)((lzham_lzham_decompressor*)ptr)->m_pOut_buf_size = 0L;
			goto IL_1ce3;
		}
		IL_6630:
		unchecked
		{
			long num107 = decode_get_bytes_consumed.Invoke(&((lzham_lzham_decompressor*)ptr)->m_codec);
			*(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size = num107;
			*(long*)((lzham_lzham_decompressor*)ptr)->m_pOut_buf_size = 0L;
			((lzham_lzham_decompressor*)ptr)->m_state = 796;
			return 2;
		}
		IL_45ec:
		unchecked((lzham_lzham_decompressor*)ptr)->m_state = 705;
		return 5;
		IL_986a:
		unchecked
		{
			long num108 = decode_get_bytes_consumed.Invoke(&((lzham_lzham_decompressor*)ptr)->m_codec);
			*(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size = num108;
			*(long*)((lzham_lzham_decompressor*)ptr)->m_pOut_buf_size = 0L;
			((lzham_lzham_decompressor*)ptr)->m_state = 945;
			return 2;
		}
		IL_82b6:
		unchecked
		{
			int num109 = (int)((num10 >>> 48) + 1L);
			int i;
			int num111;
			if ((uint)num109 <= (uint)((lzham_prefix_coding_decoder_tables*)pDecode_tables3)->m_table_max_code)
			{
				int num110 = ((int*)((lzham_prefix_coding_decoder_tables*)pDecode_tables3)->m_lookup)[num10 >>> (int)(uint)(64 - ((lzham_prefix_coding_decoder_tables*)pDecode_tables3)->m_table_bits)];
				num111 = num110 & 0xFFFF;
				i = num110 >>> 16;
			}
			else
			{
				for (i = ((lzham_prefix_coding_decoder_tables*)pDecode_tables3)->m_decode_start_code_size; (uint)num109 > (uint)((int*)(&((lzham_prefix_coding_decoder_tables*)pDecode_tables3)->m_max_codes))[(uint)(i - 1)]; i++)
				{
				}
				int num112;
				checked
				{
					num112 = unchecked(((int*)(&((lzham_prefix_coding_decoder_tables*)pDecode_tables3)->m_val_ptrs))[(uint)(i - 1)]) + unchecked((int)(num10 >>> (int)(uint)(64 - i)));
				}
				if ((uint)num112 >= (uint)((lzham_raw_quasi_adaptive_huffman_data_model*)ptr6)->m_total_syms)
				{
					num112 = 0;
				}
				num111 = (ushort)((short*)((lzham_prefix_coding_decoder_tables*)pDecode_tables3)->m_sorted_symbol_order)[num112];
			}
			num10 <<= (int)(uint)i;
			num11 -= i;
			int num113 = (ushort)(*(short*)vector_unsigned_short_Operator.Invoke(&((lzham_raw_quasi_adaptive_huffman_data_model*)ptr6)->m_sym_freq, num111));
			*(short*)vector_unsigned_short_Operator.Invoke(&((lzham_raw_quasi_adaptive_huffman_data_model*)ptr6)->m_sym_freq, num111) = (short)(num113 + 1);
			if ((((lzham_raw_quasi_adaptive_huffman_data_model*)ptr6)->m_symbols_until_update += -1) == 0)
			{
				update_tables.Invoke(ptr6, -1, sym_freq_all_ones: false);
				if (ExceptionInfo.Current != null)
				{
					return 0;
				}
			}
			num111 -= 2;
			if (num111 < 0)
			{
				if (num111 != -2)
				{
					num2 = 1;
					num3 = 1;
					num4 = 1;
					num5 = 1;
					num6 = 0;
					goto IL_417b;
				}
				if ((num11 & 7) == 0)
				{
					goto IL_a61f;
				}
				goto IL_a310;
			}
			num12 = (num111 & 7) + 2;
			num13 = (num111 >>> 3) + 1;
			if (num12 != 9)
			{
				goto IL_9059;
			}
			ptr5 = (byte*)(&((lzham_lzham_decompressor*)ptr)->m_large_len_table) + (((uint)num6 >= 7u) ? ((nint)1) : ((nint)0)) * (nint)sizeof(lzham_quasi_adaptive_huffman_data_model);
			pDecode_tables2 = ((lzham_raw_quasi_adaptive_huffman_data_model*)((byte*)(&((lzham_lzham_decompressor*)ptr)->m_large_len_table) + (((uint)num6 >= 7u) ? ((nint)1) : ((nint)0)) * (nint)sizeof(lzham_quasi_adaptive_huffman_data_model)))->m_pDecode_tables;
			if (num11 < 24)
			{
				ptr3 = (byte*)ptr3 + 4;
				if (ptr3 >= ((lzham_symbol_codec*)codec)->m_pDecode_buf_end)
				{
					ptr3 = (byte*)ptr3 + -4;
					goto IL_84fa;
				}
				num84 = ((byte)((sbyte*)ptr3)[-4] << 24) | (((byte*)ptr3 + -4)[1] << 16) | (((byte*)ptr3 + -4)[2] << 8) | ((byte*)ptr3 + -4)[3];
				num11 = checked(num11 + 32);
				num10 |= (long)((ulong)(uint)num84 << (int)(uint)checked(64 - num11));
			}
			goto IL_8817;
		}
		IL_3e11:
		num11 += 8;
		unchecked
		{
			num10 |= (long)((ulong)(uint)num56 << (int)(uint)checked(64 - num11));
			goto IL_3bb2;
		}
		IL_3bb2:
		unchecked
		{
			if (num11 < 8)
			{
				if (ptr3 == ((lzham_symbol_codec*)codec)->m_pDecode_buf_end)
				{
					if ((((lzham_symbol_codec*)codec)->m_decode_buf_eof & 1) != 1)
					{
						((lzham_symbol_codec*)codec)->m_arith_value = num8;
						((lzham_symbol_codec*)codec)->m_arith_length = num9;
						((lzham_symbol_codec*)codec)->m_bit_buf = num10;
						((lzham_symbol_codec*)codec)->m_bit_count = num11;
						((lzham_symbol_codec*)codec)->m_pDecode_buf_next = ptr3;
						((lzham_lzham_decompressor*)ptr)->m_match_hist0 = num2;
						((lzham_lzham_decompressor*)ptr)->m_match_hist1 = num3;
						((lzham_lzham_decompressor*)ptr)->m_match_hist2 = num4;
						((lzham_lzham_decompressor*)ptr)->m_match_hist3 = num5;
						((lzham_lzham_decompressor*)ptr)->m_cur_state = num6;
						((lzham_lzham_decompressor*)ptr)->m_dst_ofs = num7;
						goto IL_3ca0;
					}
					goto IL_3dc9;
				}
				void* ptr55 = ptr3;
				ptr3 = (byte*)ptr55 + 1;
				num56 = (byte)(*(sbyte*)ptr55);
				goto IL_3e11;
			}
			int num114 = (int)(num10 >>> 56);
			num10 <<= 8;
			num11 = checked(num11 - 8);
			num8 = (num8 << 8) | num114;
			num9++;
			goto IL_3ba4;
		}
		IL_3ba4:
		unchecked
		{
			if ((uint)num9 < 4u)
			{
				goto IL_3bb2;
			}
			num9 = -1;
			num2 = 1;
			num3 = 1;
			num4 = 1;
			num5 = 1;
			num6 = 0;
			((lzham_lzham_decompressor*)ptr)->m_start_block_dst_ofs = num7;
			goto IL_3e9b;
		}
		IL_62cd:
		int num115 = 0;
		unchecked
		{
			if (ptr3 < ((lzham_symbol_codec*)codec)->m_pDecode_buf_end)
			{
				void* ptr56 = ptr3;
				ptr3 = (byte*)ptr56 + 1;
				num115 = (byte)(*(sbyte*)ptr56);
			}
			num11 = checked(num11 + 8);
			num10 |= (long)((ulong)(uint)num115 << (int)(uint)checked(64 - num11));
			goto IL_608a;
		}
		IL_8cca:
		int num116;
		unchecked
		{
			if (num11 < (byte)((sbyte*)s_huge_match_code_len.Pointer)[(uint)num12])
			{
				if (ptr3 == ((lzham_symbol_codec*)codec)->m_pDecode_buf_end)
				{
					if ((((lzham_symbol_codec*)codec)->m_decode_buf_eof & 1) != 1)
					{
						((lzham_symbol_codec*)codec)->m_arith_value = num8;
						((lzham_symbol_codec*)codec)->m_arith_length = num9;
						((lzham_symbol_codec*)codec)->m_bit_buf = num10;
						((lzham_symbol_codec*)codec)->m_bit_count = num11;
						((lzham_symbol_codec*)codec)->m_pDecode_buf_next = ptr3;
						((lzham_lzham_decompressor*)ptr)->m_match_len = num12;
						((lzham_lzham_decompressor*)ptr)->m_match_slot = num13;
						((lzham_lzham_decompressor*)ptr)->m_match_hist0 = num2;
						((lzham_lzham_decompressor*)ptr)->m_match_hist1 = num3;
						((lzham_lzham_decompressor*)ptr)->m_match_hist2 = num4;
						((lzham_lzham_decompressor*)ptr)->m_match_hist3 = num5;
						((lzham_lzham_decompressor*)ptr)->m_cur_state = num6;
						((lzham_lzham_decompressor*)ptr)->m_dst_ofs = num7;
						goto IL_8def;
					}
					goto IL_8f2a;
				}
				void* ptr57 = ptr3;
				ptr3 = (byte*)ptr57 + 1;
				num27 = (byte)(*(sbyte*)ptr57);
				goto IL_8f72;
			}
			num116 = (int)(((bool*)s_huge_match_code_len.Pointer)[(uint)num12] ? (num10 >>> (int)(uint)checked(64 - unchecked((byte)((sbyte*)s_huge_match_code_len.Pointer)[(uint)num12]))) : 0);
			num10 <<= (int)(byte)((sbyte*)s_huge_match_code_len.Pointer)[(uint)num12];
		}
		num11 -= unchecked((byte)((sbyte*)s_huge_match_code_len.Pointer)[(uint)num12]);
		num12 = unchecked(((int*)s_huge_match_base_len.Pointer)[(uint)num12] + num116);
		goto IL_9059;
		IL_9a80:
		unchecked
		{
			int num117 = (int)((num10 >>> 48) + 1L);
			int num119;
			int j;
			if ((uint)num117 <= (uint)((lzham_prefix_coding_decoder_tables*)pDecode_tables)->m_table_max_code)
			{
				int num118 = ((int*)((lzham_prefix_coding_decoder_tables*)pDecode_tables)->m_lookup)[num10 >>> (int)(uint)(64 - ((lzham_prefix_coding_decoder_tables*)pDecode_tables)->m_table_bits)];
				num119 = num118 & 0xFFFF;
				j = num118 >>> 16;
			}
			else
			{
				for (j = ((lzham_prefix_coding_decoder_tables*)pDecode_tables)->m_decode_start_code_size; (uint)num117 > (uint)((int*)(&((lzham_prefix_coding_decoder_tables*)pDecode_tables)->m_max_codes))[(uint)(j - 1)]; j++)
				{
				}
				int num120;
				checked
				{
					num120 = unchecked(((int*)(&((lzham_prefix_coding_decoder_tables*)pDecode_tables)->m_val_ptrs))[(uint)(j - 1)]) + unchecked((int)(num10 >>> (int)(uint)(64 - j)));
				}
				if ((uint)num120 >= (uint)((lzham_raw_quasi_adaptive_huffman_data_model*)ptr4)->m_total_syms)
				{
					num120 = 0;
				}
				num119 = (ushort)((short*)((lzham_prefix_coding_decoder_tables*)pDecode_tables)->m_sorted_symbol_order)[num120];
			}
			num10 <<= (int)(uint)j;
			num11 -= j;
			int num121 = (ushort)(*(short*)vector_unsigned_short_Operator.Invoke(&((lzham_raw_quasi_adaptive_huffman_data_model*)ptr4)->m_sym_freq, num119));
			*(short*)vector_unsigned_short_Operator.Invoke(&((lzham_raw_quasi_adaptive_huffman_data_model*)ptr4)->m_sym_freq, num119) = (short)(num121 + 1);
			if ((((lzham_raw_quasi_adaptive_huffman_data_model*)ptr4)->m_symbols_until_update += -1) == 0)
			{
				update_tables.Invoke(ptr4, -1, sym_freq_all_ones: false);
				if (ExceptionInfo.Current != null)
				{
					return 0;
				}
			}
			num14 += num119;
			goto IL_9c18;
		}
		IL_7862:
		unchecked
		{
			long num122 = decode_get_bytes_consumed.Invoke(&((lzham_lzham_decompressor*)ptr)->m_codec);
			*(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size = num122;
			*(long*)((lzham_lzham_decompressor*)ptr)->m_pOut_buf_size = 0L;
			((lzham_lzham_decompressor*)ptr)->m_state = 828;
			return 2;
		}
		IL_0bed:
		unchecked
		{
			long num123 = decode_get_bytes_consumed.Invoke(&((lzham_lzham_decompressor*)ptr)->m_codec);
			*(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size = num123;
			*(long*)((lzham_lzham_decompressor*)ptr)->m_pOut_buf_size = 0L;
			((lzham_lzham_decompressor*)ptr)->m_state = 381;
			return 2;
		}
		IL_9675:
		num11 += 8;
		unchecked
		{
			num10 |= (long)((ulong)(uint)num47 << (int)(uint)checked(64 - num11));
			goto IL_93c5;
		}
		IL_21b6:
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
					long num125;
					for (long num124 = 0L; (ulong)num124 < (ulong)((lzham_lzham_decompressor*)ptr)->m_flush_n; num124 += num125)
					{
						num125 = (((ulong)(((lzham_lzham_decompressor*)ptr)->m_flush_n - num124) >= 8192uL) ? 8192L : (((lzham_lzham_decompressor*)ptr)->m_flush_n - num124));
						llvm_memcpy_p0_p0_i64.Invoke((byte*)((lzham_lzham_decompressor*)ptr)->m_pOut_buf + num124, (byte*)((lzham_lzham_decompressor*)ptr)->m_pFlush_src + num124, num125, isVolatile: false);
						((lzham_lzham_decompressor*)ptr)->m_decomp_adler32 = adler32.Invoke(adler32: ((lzham_lzham_decompressor*)ptr)->m_decomp_adler32, pBuf: (byte*)((lzham_lzham_decompressor*)ptr)->m_pFlush_src + num124, buflen: num125);
					}
				}
				long num126 = decode_get_bytes_consumed.Invoke(&((lzham_lzham_decompressor*)ptr)->m_codec);
				*(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size = num126;
				long flush_n16 = ((lzham_lzham_decompressor*)ptr)->m_flush_n;
				*(long*)((lzham_lzham_decompressor*)ptr)->m_pOut_buf_size = flush_n16;
				((lzham_lzham_decompressor*)ptr)->m_state = 473;
				return InstructionHelper.Select(((lzham_lzham_decompressor*)ptr)->m_flush_n != 0L, 0, 1);
			}
			num2 = ((lzham_lzham_decompressor*)ptr)->m_match_hist0;
			num3 = ((lzham_lzham_decompressor*)ptr)->m_match_hist1;
			num4 = ((lzham_lzham_decompressor*)ptr)->m_match_hist2;
			num5 = ((lzham_lzham_decompressor*)ptr)->m_match_hist3;
			num6 = ((lzham_lzham_decompressor*)ptr)->m_cur_state;
			num7 = ((lzham_lzham_decompressor*)ptr)->m_dst_ofs;
			goto IL_2596;
		}
		IL_72fa:
		num32 = 0;
		unchecked
		{
			if (ptr3 < ((lzham_symbol_codec*)codec)->m_pDecode_buf_end)
			{
				void* ptr58 = ptr3;
				ptr3 = (byte*)ptr58 + 1;
				num32 = (byte)(*(sbyte*)ptr58);
			}
			goto IL_7342;
		}
		IL_2c5f:
		unchecked
		{
			if (num11 < (num11 & 7))
			{
				if (ptr3 == ((lzham_symbol_codec*)codec)->m_pDecode_buf_end)
				{
					if ((((lzham_symbol_codec*)codec)->m_decode_buf_eof & 1) != 1)
					{
						((lzham_symbol_codec*)codec)->m_arith_value = num8;
						((lzham_symbol_codec*)codec)->m_arith_length = num9;
						((lzham_symbol_codec*)codec)->m_bit_buf = num10;
						((lzham_symbol_codec*)codec)->m_bit_count = num11;
						((lzham_symbol_codec*)codec)->m_pDecode_buf_next = ptr3;
						((lzham_lzham_decompressor*)ptr)->m_num_raw_bytes_remaining = num17;
						((lzham_lzham_decompressor*)ptr)->m_match_hist0 = num2;
						((lzham_lzham_decompressor*)ptr)->m_match_hist1 = num3;
						((lzham_lzham_decompressor*)ptr)->m_match_hist2 = num4;
						((lzham_lzham_decompressor*)ptr)->m_match_hist3 = num5;
						((lzham_lzham_decompressor*)ptr)->m_cur_state = num6;
						((lzham_lzham_decompressor*)ptr)->m_dst_ofs = num7;
						goto IL_2d61;
					}
					goto IL_2e93;
				}
				void* ptr59 = ptr3;
				ptr3 = (byte*)ptr59 + 1;
				num22 = (byte)(*(sbyte*)ptr59);
				goto IL_2edb;
			}
			if ((num11 & 7) != 0)
			{
				_ = num10 >>> (int)(uint)checked(64 - (num11 & 7));
			}
			num10 <<= (int)(uint)(num11 & 7);
		}
		num11 -= num11 & 7;
		goto IL_2f60;
		IL_17ad:
		unchecked
		{
			long num127 = decode_get_bytes_consumed.Invoke(&((lzham_lzham_decompressor*)ptr)->m_codec);
			*(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size = num127;
			*(long*)((lzham_lzham_decompressor*)ptr)->m_pOut_buf_size = 0L;
			((lzham_lzham_decompressor*)ptr)->m_state = 445;
			return 2;
		}
		IL_12fd:
		num23 = 0;
		unchecked
		{
			if (ptr3 < ((lzham_symbol_codec*)codec)->m_pDecode_buf_end)
			{
				void* ptr60 = ptr3;
				ptr3 = (byte*)ptr60 + 1;
				num23 = (byte)(*(sbyte*)ptr60);
			}
			goto IL_1345;
		}
		IL_9c66:
		unchecked
		{
			if ((ulong)num2 > (ulong)(uint)num7 || (ulong)(uint)(num7 + num12) > (ulong)pOut_buf_size)
			{
				((lzham_symbol_codec*)codec)->m_arith_value = num8;
				((lzham_symbol_codec*)codec)->m_arith_length = num9;
				((lzham_symbol_codec*)codec)->m_bit_buf = num10;
				((lzham_symbol_codec*)codec)->m_bit_count = num11;
				((lzham_symbol_codec*)codec)->m_pDecode_buf_next = ptr3;
				long num128 = decode_get_bytes_consumed.Invoke(codec);
				*(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size = num128;
				*(long*)((lzham_lzham_decompressor*)ptr)->m_pOut_buf_size = 0L;
				goto IL_9d06;
			}
			ptr14 = (byte*)pOut_buf + (uint)((num7 - num2) & -1);
			if (-1 == 0 && (uint)((((uint)src_ofs >= (uint)num7) ? src_ofs : num7) + num12) > uint.MaxValue)
			{
				goto IL_9d59;
			}
			void* ptr61 = (byte*)pOut_buf + (uint)num7;
			if (num2 == 1)
			{
				sbyte b2 = *(sbyte*)ptr14;
				if ((uint)num12 < 8u)
				{
					for (int k = num12; k > 0; k = checked(k + -1))
					{
						sbyte b3 = b2;
						void* ptr62 = ptr61;
						ptr61 = (byte*)ptr62 + 1;
						*(sbyte*)ptr62 = b3;
					}
				}
				else
				{
					llvm_memset_p0_i64.Invoke(ptr61, (sbyte)(byte)b2, (uint)num12, isVolatile: false);
				}
			}
			else if ((uint)num12 < 8u || num12 > num2)
			{
				for (int l = num12; l > 0; l = checked(l + -1))
				{
					void* ptr63 = ptr14;
					ptr14 = (byte*)ptr63 + 1;
					sbyte b4 = *(sbyte*)ptr63;
					void* ptr64 = ptr61;
					ptr61 = (byte*)ptr64 + 1;
					*(sbyte*)ptr64 = b4;
				}
			}
			else
			{
				llvm_memcpy_p0_p0_i64.Invoke(ptr61, ptr14, (uint)num12, isVolatile: false);
			}
			num7 += num12;
			goto IL_417b;
		}
		IL_2c2e:
		unchecked((lzham_lzham_decompressor*)ptr)->m_state = 530;
		return 9;
		IL_7d96:
		int num129 = 0;
		unchecked
		{
			if (ptr3 < ((lzham_symbol_codec*)codec)->m_pDecode_buf_end)
			{
				void* ptr65 = ptr3;
				ptr3 = (byte*)ptr65 + 1;
				num129 = (byte)(*(sbyte*)ptr65);
			}
			goto IL_7dde;
		}
		IL_94e9:
		unchecked
		{
			long num130 = decode_get_bytes_consumed.Invoke(&((lzham_lzham_decompressor*)ptr)->m_codec);
			*(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size = num130;
			*(long*)((lzham_lzham_decompressor*)ptr)->m_pOut_buf_size = 0L;
			((lzham_lzham_decompressor*)ptr)->m_state = 936;
			return 2;
		}
		IL_afc5:
		num11 += 8;
		unchecked
		{
			num10 |= (long)((ulong)(uint)num81 << (int)(uint)checked(64 - num11));
			goto IL_ad65;
		}
		IL_6f25:
		unchecked
		{
			int num131 = (int)((num10 >>> 48) + 1L);
			int m;
			if ((uint)num131 <= (uint)((lzham_prefix_coding_decoder_tables*)pDecode_tables4)->m_table_max_code)
			{
				int num132 = ((int*)((lzham_prefix_coding_decoder_tables*)pDecode_tables4)->m_lookup)[num10 >>> (int)(uint)(64 - ((lzham_prefix_coding_decoder_tables*)pDecode_tables4)->m_table_bits)];
				num12 = num132 & 0xFFFF;
				m = num132 >>> 16;
			}
			else
			{
				for (m = ((lzham_prefix_coding_decoder_tables*)pDecode_tables4)->m_decode_start_code_size; (uint)num131 > (uint)((int*)(&((lzham_prefix_coding_decoder_tables*)pDecode_tables4)->m_max_codes))[(uint)(m - 1)]; m++)
				{
				}
				int num133;
				checked
				{
					num133 = unchecked(((int*)(&((lzham_prefix_coding_decoder_tables*)pDecode_tables4)->m_val_ptrs))[(uint)(m - 1)]) + unchecked((int)(num10 >>> (int)(uint)(64 - m)));
				}
				if ((uint)num133 >= (uint)((lzham_raw_quasi_adaptive_huffman_data_model*)ptr7)->m_total_syms)
				{
					num133 = 0;
				}
				num12 = (ushort)((short*)((lzham_prefix_coding_decoder_tables*)pDecode_tables4)->m_sorted_symbol_order)[num133];
			}
			num10 <<= (int)(uint)m;
			num11 -= m;
			int num134 = (ushort)(*(short*)vector_unsigned_short_Operator.Invoke(&((lzham_raw_quasi_adaptive_huffman_data_model*)ptr7)->m_sym_freq, num12));
			*(short*)vector_unsigned_short_Operator.Invoke(&((lzham_raw_quasi_adaptive_huffman_data_model*)ptr7)->m_sym_freq, num12) = (short)(num134 + 1);
			if ((((lzham_raw_quasi_adaptive_huffman_data_model*)ptr7)->m_symbols_until_update += -1) == 0)
			{
				update_tables.Invoke(ptr7, -1, sym_freq_all_ones: false);
				if (ExceptionInfo.Current != null)
				{
					return 0;
				}
			}
			num12 += 2;
			if (num12 != 258)
			{
				goto IL_7728;
			}
			num12 = 0;
			goto IL_70c9;
		}
		IL_11d4:
		unchecked
		{
			long num135 = decode_get_bytes_consumed.Invoke(&((lzham_lzham_decompressor*)ptr)->m_codec);
			*(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size = num135;
			*(long*)((lzham_lzham_decompressor*)ptr)->m_pOut_buf_size = 0L;
			((lzham_lzham_decompressor*)ptr)->m_state = 431;
			return 2;
		}
		IL_3f89:
		unchecked
		{
			long num136 = decode_get_bytes_consumed.Invoke(&((lzham_lzham_decompressor*)ptr)->m_codec);
			*(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size = num136;
			*(long*)((lzham_lzham_decompressor*)ptr)->m_pOut_buf_size = 0L;
			((lzham_lzham_decompressor*)ptr)->m_state = 651;
			return 2;
		}
		IL_2b25:
		num11 += 8;
		int num137;
		unchecked
		{
			num10 |= (long)((ulong)(uint)num137 << (int)(uint)checked(64 - num11));
			goto IL_28ac;
		}
		IL_8c57:
		num11 += 8;
		unchecked
		{
			num10 |= (long)((ulong)(uint)num79 << (int)(uint)checked(64 - num11));
			goto IL_89c4;
		}
		IL_4c41:
		unchecked
		{
			long num138 = decode_get_bytes_consumed.Invoke(&((lzham_lzham_decompressor*)ptr)->m_codec);
			*(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size = num138;
			*(long*)((lzham_lzham_decompressor*)ptr)->m_pOut_buf_size = 0L;
			((lzham_lzham_decompressor*)ptr)->m_state = 737;
			return 2;
		}
		IL_1345:
		num11 += 8;
		unchecked
		{
			num10 |= (long)((ulong)(uint)num23 << (int)(uint)checked(64 - num11));
			goto IL_10e6;
		}
		IL_6931:
		unchecked
		{
			long num139 = decode_get_bytes_consumed.Invoke(&((lzham_lzham_decompressor*)ptr)->m_codec);
			*(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size = num139;
			*(long*)((lzham_lzham_decompressor*)ptr)->m_pOut_buf_size = 0L;
			((lzham_lzham_decompressor*)ptr)->m_state = 801;
			return 2;
		}
		IL_29ab:
		unchecked
		{
			long num140 = decode_get_bytes_consumed.Invoke(&((lzham_lzham_decompressor*)ptr)->m_codec);
			*(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size = num140;
			*(long*)((lzham_lzham_decompressor*)ptr)->m_pOut_buf_size = 0L;
			((lzham_lzham_decompressor*)ptr)->m_state = 520;
			return 2;
		}
		IL_5c43:
		unchecked
		{
			if (num11 < 8)
			{
				if (ptr3 == ((lzham_symbol_codec*)codec)->m_pDecode_buf_end)
				{
					if ((((lzham_symbol_codec*)codec)->m_decode_buf_eof & 1) != 1)
					{
						((lzham_symbol_codec*)codec)->m_arith_value = num8;
						((lzham_symbol_codec*)codec)->m_arith_length = num9;
						((lzham_symbol_codec*)codec)->m_bit_buf = num10;
						((lzham_symbol_codec*)codec)->m_bit_count = num11;
						((lzham_symbol_codec*)codec)->m_pDecode_buf_next = ptr3;
						((lzham_lzham_decompressor*)ptr)->m_match_len = num12;
						((lzham_lzham_decompressor*)ptr)->m_match_hist0 = num2;
						((lzham_lzham_decompressor*)ptr)->m_match_hist1 = num3;
						((lzham_lzham_decompressor*)ptr)->m_match_hist2 = num4;
						((lzham_lzham_decompressor*)ptr)->m_match_hist3 = num5;
						((lzham_lzham_decompressor*)ptr)->m_cur_state = num6;
						((lzham_lzham_decompressor*)ptr)->m_dst_ofs = num7;
						goto IL_5d42;
					}
					goto IL_5e74;
				}
				void* ptr66 = ptr3;
				ptr3 = (byte*)ptr66 + 1;
				num37 = (byte)(*(sbyte*)ptr66);
				goto IL_5ebc;
			}
			int num141 = (int)(num10 >>> 56);
			num10 <<= 8;
			num11 = checked(num11 - 8);
			ptr23 = ((lzham_symbol_codec*)codec)->m_pSaved_model;
			num8 = (num8 << 8) | num141;
			num9 <<= 8;
			goto IL_5c20;
		}
		IL_8ad4:
		unchecked
		{
			long num142 = decode_get_bytes_consumed.Invoke(&((lzham_lzham_decompressor*)ptr)->m_codec);
			*(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size = num142;
			*(long*)((lzham_lzham_decompressor*)ptr)->m_pOut_buf_size = 0L;
			((lzham_lzham_decompressor*)ptr)->m_state = 907;
			return 2;
		}
		IL_3e9b:
		int num143;
		unchecked
		{
			if (num11 < 2)
			{
				if (ptr3 == ((lzham_symbol_codec*)codec)->m_pDecode_buf_end)
				{
					if ((((lzham_symbol_codec*)codec)->m_decode_buf_eof & 1) != 1)
					{
						((lzham_symbol_codec*)codec)->m_arith_value = num8;
						((lzham_symbol_codec*)codec)->m_arith_length = num9;
						((lzham_symbol_codec*)codec)->m_bit_buf = num10;
						((lzham_symbol_codec*)codec)->m_bit_count = num11;
						((lzham_symbol_codec*)codec)->m_pDecode_buf_next = ptr3;
						((lzham_lzham_decompressor*)ptr)->m_match_hist0 = num2;
						((lzham_lzham_decompressor*)ptr)->m_match_hist1 = num3;
						((lzham_lzham_decompressor*)ptr)->m_match_hist2 = num4;
						((lzham_lzham_decompressor*)ptr)->m_match_hist3 = num5;
						((lzham_lzham_decompressor*)ptr)->m_cur_state = num6;
						((lzham_lzham_decompressor*)ptr)->m_dst_ofs = num7;
						goto IL_3f89;
					}
					goto IL_40b2;
				}
				void* ptr67 = ptr3;
				ptr3 = (byte*)ptr67 + 1;
				num55 = (byte)(*(sbyte*)ptr67);
				goto IL_40fa;
			}
			num143 = (int)(num10 >>> 62);
			num10 <<= 2;
		}
		num11 -= 2;
		switch (num143)
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
		goto IL_417b;
		IL_2041:
		unchecked((lzham_lzham_decompressor*)ptr)->m_state = 462;
		return 14;
		IL_13b4:
		int num144;
		unchecked
		{
			if (num11 < 2)
			{
				if (ptr3 == ((lzham_symbol_codec*)codec)->m_pDecode_buf_end)
				{
					if ((((lzham_symbol_codec*)codec)->m_decode_buf_eof & 1) != 1)
					{
						((lzham_symbol_codec*)codec)->m_arith_value = num8;
						((lzham_symbol_codec*)codec)->m_arith_length = num9;
						((lzham_symbol_codec*)codec)->m_bit_buf = num10;
						((lzham_symbol_codec*)codec)->m_bit_count = num11;
						((lzham_symbol_codec*)codec)->m_pDecode_buf_next = ptr3;
						((lzham_lzham_decompressor*)ptr)->m_match_hist0 = num2;
						((lzham_lzham_decompressor*)ptr)->m_match_hist1 = num3;
						((lzham_lzham_decompressor*)ptr)->m_match_hist2 = num4;
						((lzham_lzham_decompressor*)ptr)->m_match_hist3 = num5;
						((lzham_lzham_decompressor*)ptr)->m_cur_state = num6;
						((lzham_lzham_decompressor*)ptr)->m_dst_ofs = num7;
						goto IL_14a2;
					}
					goto IL_15cb;
				}
				void* ptr68 = ptr3;
				ptr3 = (byte*)ptr68 + 1;
				num144 = (byte)(*(sbyte*)ptr68);
				goto IL_1613;
			}
			((lzham_lzham_decompressor*)ptr)->m_tmp = (int)(num10 >>> 62);
			num10 <<= 2;
			num11 = checked(num11 - 2);
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
			if ((num11 & 7) == 0)
			{
				goto IL_19a3;
			}
			goto IL_16bc;
		}
		IL_6e65:
		num45 = 0;
		unchecked
		{
			if (ptr3 < ((lzham_symbol_codec*)codec)->m_pDecode_buf_end)
			{
				void* ptr69 = ptr3;
				ptr3 = (byte*)ptr69 + 1;
				num45 = (byte)(*(sbyte*)ptr69);
			}
			num11 = checked(num11 + 8);
			num10 |= (long)((ulong)(uint)num45 << (int)(uint)checked(64 - num11));
			goto IL_6c22;
		}
		IL_417b:
		ptr46 = unchecked((byte*)(&((lzham_lzham_decompressor*)ptr)->m_is_match_model) + (nint)(uint)num6 * (nint)sizeof(lzham_adaptive_bit_model));
		goto IL_4197;
		IL_4d85:
		num92 = 0;
		unchecked
		{
			if (ptr3 < ((lzham_symbol_codec*)codec)->m_pDecode_buf_end)
			{
				void* ptr70 = ptr3;
				ptr3 = (byte*)ptr70 + 1;
				num92 = (byte)(*(sbyte*)ptr70);
			}
			num11 = checked(num11 + 8);
			num10 |= (long)((ulong)(uint)num92 << (int)(uint)checked(64 - num11));
			goto IL_4b42;
		}
		IL_4659:
		if (num11 >= 24)
		{
			goto IL_4942;
		}
		unchecked
		{
			if ((((lzham_symbol_codec*)codec)->m_decode_buf_eof & 1) != 1)
			{
				((lzham_symbol_codec*)codec)->m_pSaved_huff_model = ptr10;
				((lzham_symbol_codec*)codec)->m_arith_value = num8;
				((lzham_symbol_codec*)codec)->m_arith_length = num9;
				((lzham_symbol_codec*)codec)->m_bit_buf = num10;
				((lzham_symbol_codec*)codec)->m_bit_count = num11;
				((lzham_symbol_codec*)codec)->m_pDecode_buf_next = ptr3;
				((lzham_lzham_decompressor*)ptr)->m_match_hist0 = num2;
				((lzham_lzham_decompressor*)ptr)->m_match_hist1 = num3;
				((lzham_lzham_decompressor*)ptr)->m_match_hist2 = num4;
				((lzham_lzham_decompressor*)ptr)->m_match_hist3 = num5;
				((lzham_lzham_decompressor*)ptr)->m_cur_state = num6;
				((lzham_lzham_decompressor*)ptr)->m_dst_ofs = num7;
				goto IL_4747;
			}
			goto IL_4882;
		}
		IL_2add:
		num137 = 0;
		unchecked
		{
			if (ptr3 < ((lzham_symbol_codec*)codec)->m_pDecode_buf_end)
			{
				void* ptr71 = ptr3;
				ptr3 = (byte*)ptr71 + 1;
				num137 = (byte)(*(sbyte*)ptr71);
			}
			goto IL_2b25;
		}
		IL_5c20:
		unchecked
		{
			if ((uint)num9 < 16777216u)
			{
				((lzham_symbol_codec*)codec)->m_pSaved_model = ptr23;
				goto IL_5c43;
			}
			int num145 = (ushort)((lzham_adaptive_bit_model*)ptr23)->m_bit_0_prob * (num9 >>> 11);
			int num146 = (((uint)num8 >= (uint)num145) ? 1 : 0);
			if (num146 == 0)
			{
				int num147 = 2048 - (ushort)((lzham_adaptive_bit_model*)ptr23)->m_bit_0_prob >>> 5;
				short* bit_0_prob7 = &((lzham_adaptive_bit_model*)ptr23)->m_bit_0_prob;
				*bit_0_prob7 = (short)((ushort)(*bit_0_prob7) + num147);
				num9 = num145;
			}
			else
			{
				int num148 = (ushort)((lzham_adaptive_bit_model*)ptr23)->m_bit_0_prob >> 5;
				short* bit_0_prob8 = &((lzham_adaptive_bit_model*)ptr23)->m_bit_0_prob;
				*bit_0_prob8 = (short)checked(unchecked((ushort)(*bit_0_prob8)) - num148);
				num8 -= num145;
				num9 -= num145;
			}
			if (num146 != 0)
			{
				num6 = InstructionHelper.Select((uint)num6 < 7u, 9, 11);
				goto IL_9c66;
			}
			ptr8 = (byte*)(&((lzham_lzham_decompressor*)ptr)->m_rep_len_table) + (((uint)num6 >= 7u) ? ((nint)1) : ((nint)0)) * (nint)sizeof(lzham_quasi_adaptive_huffman_data_model);
			pDecode_tables5 = ((lzham_raw_quasi_adaptive_huffman_data_model*)((byte*)(&((lzham_lzham_decompressor*)ptr)->m_rep_len_table) + (((uint)num6 >= 7u) ? ((nint)1) : ((nint)0)) * (nint)sizeof(lzham_quasi_adaptive_huffman_data_model)))->m_pDecode_tables;
			if (num11 < 24)
			{
				ptr3 = (byte*)ptr3 + 4;
				if (ptr3 >= ((lzham_symbol_codec*)codec)->m_pDecode_buf_end)
				{
					ptr3 = (byte*)ptr3 + -4;
					goto IL_608a;
				}
				num115 = ((byte)((sbyte*)ptr3)[-4] << 24) | (((byte*)ptr3 + -4)[1] << 16) | (((byte*)ptr3 + -4)[2] << 8) | ((byte*)ptr3 + -4)[3];
				num11 = checked(num11 + 32);
				num10 |= (long)((ulong)(uint)num115 << (int)(uint)checked(64 - num11));
			}
			goto IL_638d;
		}
		IL_638d:
		unchecked
		{
			int num149 = (int)((num10 >>> 48) + 1L);
			int n;
			if ((uint)num149 <= (uint)((lzham_prefix_coding_decoder_tables*)pDecode_tables5)->m_table_max_code)
			{
				int num150 = ((int*)((lzham_prefix_coding_decoder_tables*)pDecode_tables5)->m_lookup)[num10 >>> (int)(uint)(64 - ((lzham_prefix_coding_decoder_tables*)pDecode_tables5)->m_table_bits)];
				num12 = num150 & 0xFFFF;
				n = num150 >>> 16;
			}
			else
			{
				for (n = ((lzham_prefix_coding_decoder_tables*)pDecode_tables5)->m_decode_start_code_size; (uint)num149 > (uint)((int*)(&((lzham_prefix_coding_decoder_tables*)pDecode_tables5)->m_max_codes))[(uint)(n - 1)]; n++)
				{
				}
				int num151;
				checked
				{
					num151 = unchecked(((int*)(&((lzham_prefix_coding_decoder_tables*)pDecode_tables5)->m_val_ptrs))[(uint)(n - 1)]) + unchecked((int)(num10 >>> (int)(uint)(64 - n)));
				}
				if ((uint)num151 >= (uint)((lzham_raw_quasi_adaptive_huffman_data_model*)ptr8)->m_total_syms)
				{
					num151 = 0;
				}
				num12 = (ushort)((short*)((lzham_prefix_coding_decoder_tables*)pDecode_tables5)->m_sorted_symbol_order)[num151];
			}
			num10 <<= (int)(uint)n;
			num11 -= n;
			int num152 = (ushort)(*(short*)vector_unsigned_short_Operator.Invoke(&((lzham_raw_quasi_adaptive_huffman_data_model*)ptr8)->m_sym_freq, num12));
			*(short*)vector_unsigned_short_Operator.Invoke(&((lzham_raw_quasi_adaptive_huffman_data_model*)ptr8)->m_sym_freq, num12) = (short)(num152 + 1);
			if ((((lzham_raw_quasi_adaptive_huffman_data_model*)ptr8)->m_symbols_until_update += -1) == 0)
			{
				update_tables.Invoke(ptr8, -1, sym_freq_all_ones: false);
				if (ExceptionInfo.Current != null)
				{
					return 0;
				}
			}
			num12 += 2;
			if (num12 != 258)
			{
				goto IL_6b90;
			}
			num12 = 0;
			goto IL_6531;
		}
		IL_9d06:
		unchecked((lzham_lzham_decompressor*)ptr)->m_state = 976;
		return 7;
		IL_9c18:
		num5 = num4;
		num4 = num3;
		num3 = num2;
		unchecked
		{
			_ = &((lzham_lzham_decompressor*)ptr)->m_lzBase;
			num2 = ((int*)m_lzx_position_base.Pointer)[(uint)num13] + num14;
			num6 = InstructionHelper.Select((uint)num6 < 7u, 7, 10);
			goto IL_9c66;
		}
		IL_1f5d:
		num11 += 8;
		int num153;
		unchecked
		{
			num10 |= (long)((ulong)(uint)num153 << (int)(uint)checked(64 - num11));
			goto IL_1cfd;
		}
		IL_18d6:
		int num154 = 0;
		unchecked
		{
			if (ptr3 < ((lzham_symbol_codec*)codec)->m_pDecode_buf_end)
			{
				void* ptr72 = ptr3;
				ptr3 = (byte*)ptr72 + 1;
				num154 = (byte)(*(sbyte*)ptr72);
			}
			goto IL_191e;
		}
		IL_1dec:
		unchecked
		{
			long num155 = decode_get_bytes_consumed.Invoke(&((lzham_lzham_decompressor*)ptr)->m_codec);
			*(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size = num155;
			*(long*)((lzham_lzham_decompressor*)ptr)->m_pOut_buf_size = 0L;
			((lzham_lzham_decompressor*)ptr)->m_state = 456;
			return 2;
		}
		IL_28ac:
		unchecked
		{
			if (num11 < 8)
			{
				if (ptr3 == ((lzham_symbol_codec*)codec)->m_pDecode_buf_end)
				{
					if ((((lzham_symbol_codec*)codec)->m_decode_buf_eof & 1) != 1)
					{
						((lzham_symbol_codec*)codec)->m_arith_value = num8;
						((lzham_symbol_codec*)codec)->m_arith_length = num9;
						((lzham_symbol_codec*)codec)->m_bit_buf = num10;
						((lzham_symbol_codec*)codec)->m_bit_count = num11;
						((lzham_symbol_codec*)codec)->m_pDecode_buf_next = ptr3;
						((lzham_lzham_decompressor*)ptr)->m_num_raw_bytes_remaining = num17;
						((lzham_lzham_decompressor*)ptr)->m_match_hist0 = num2;
						((lzham_lzham_decompressor*)ptr)->m_match_hist1 = num3;
						((lzham_lzham_decompressor*)ptr)->m_match_hist2 = num4;
						((lzham_lzham_decompressor*)ptr)->m_match_hist3 = num5;
						((lzham_lzham_decompressor*)ptr)->m_cur_state = num6;
						((lzham_lzham_decompressor*)ptr)->m_dst_ofs = num7;
						goto IL_29ab;
					}
					goto IL_2add;
				}
				void* ptr73 = ptr3;
				ptr3 = (byte*)ptr73 + 1;
				num137 = (byte)(*(sbyte*)ptr73);
				goto IL_2b25;
			}
			int num156 = (int)(num10 >>> 56);
			num10 <<= 8;
			num11 = checked(num11 - 8);
			if (num156 != ((num17 & 0xFF) ^ ((num17 >>> 8) & 0xFF) ^ ((num17 >>> 16) & 0xFF)))
			{
				((lzham_symbol_codec*)codec)->m_arith_value = num8;
				((lzham_symbol_codec*)codec)->m_arith_length = num9;
				((lzham_symbol_codec*)codec)->m_bit_buf = num10;
				((lzham_symbol_codec*)codec)->m_bit_count = num11;
				((lzham_symbol_codec*)codec)->m_pDecode_buf_next = ptr3;
				long num157 = decode_get_bytes_consumed.Invoke(codec);
				*(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size = num157;
				*(long*)((lzham_lzham_decompressor*)ptr)->m_pOut_buf_size = 0L;
				goto IL_2c2e;
			}
			num17++;
			if ((num11 & 7) == 0)
			{
				goto IL_2f60;
			}
			goto IL_2c5f;
		}
		IL_7728:
		ptr48 = unchecked((byte*)(&((lzham_lzham_decompressor*)ptr)->m_is_rep1_model) + (nint)(uint)num6 * (nint)sizeof(lzham_adaptive_bit_model));
		goto IL_7740;
		IL_5438:
		unchecked
		{
			if ((uint)num9 < 16777216u)
			{
				((lzham_symbol_codec*)codec)->m_pSaved_model = ptr47;
				goto IL_545b;
			}
			int num158 = (ushort)((lzham_adaptive_bit_model*)ptr47)->m_bit_0_prob * (num9 >>> 11);
			int num159 = (((uint)num8 >= (uint)num158) ? 1 : 0);
			if (num159 == 0)
			{
				int num160 = 2048 - (ushort)((lzham_adaptive_bit_model*)ptr47)->m_bit_0_prob >>> 5;
				short* bit_0_prob9 = &((lzham_adaptive_bit_model*)ptr47)->m_bit_0_prob;
				*bit_0_prob9 = (short)((ushort)(*bit_0_prob9) + num160);
				num9 = num158;
			}
			else
			{
				int num161 = (ushort)((lzham_adaptive_bit_model*)ptr47)->m_bit_0_prob >> 5;
				short* bit_0_prob10 = &((lzham_adaptive_bit_model*)ptr47)->m_bit_0_prob;
				*bit_0_prob10 = (short)checked(unchecked((ushort)(*bit_0_prob10)) - num161);
				num8 -= num158;
				num9 -= num158;
			}
			if (num159 != 0)
			{
				ptr22 = (byte*)(&((lzham_lzham_decompressor*)ptr)->m_is_rep0_model) + (nint)(uint)num6 * (nint)sizeof(lzham_adaptive_bit_model);
				goto IL_582c;
			}
			ptr6 = &((lzham_lzham_decompressor*)ptr)->m_main_table;
			pDecode_tables3 = ((lzham_raw_quasi_adaptive_huffman_data_model*)(&((lzham_lzham_decompressor*)ptr)->m_main_table))->m_pDecode_tables;
			if (num11 < 24)
			{
				ptr3 = (byte*)ptr3 + 4;
				if (ptr3 >= ((lzham_symbol_codec*)codec)->m_pDecode_buf_end)
				{
					ptr3 = (byte*)ptr3 + -4;
					goto IL_7fb3;
				}
				num49 = ((byte)((sbyte*)ptr3)[-4] << 24) | (((byte*)ptr3 + -4)[1] << 16) | (((byte*)ptr3 + -4)[2] << 8) | ((byte*)ptr3 + -4)[3];
				num11 = checked(num11 + 32);
				num10 |= (long)((ulong)(uint)num49 << (int)(uint)checked(64 - num11));
			}
			goto IL_82b6;
		}
		IL_15cb:
		num144 = 0;
		unchecked
		{
			if (ptr3 < ((lzham_symbol_codec*)codec)->m_pDecode_buf_end)
			{
				void* ptr74 = ptr3;
				ptr3 = (byte*)ptr74 + 1;
				num144 = (byte)(*(sbyte*)ptr74);
			}
			goto IL_1613;
		}
		IL_860a:
		unchecked
		{
			long num162 = decode_get_bytes_consumed.Invoke(&((lzham_lzham_decompressor*)ptr)->m_codec);
			*(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size = num162;
			*(long*)((lzham_lzham_decompressor*)ptr)->m_pOut_buf_size = 0L;
			((lzham_lzham_decompressor*)ptr)->m_state = 898;
			return 2;
		}
		IL_14a2:
		unchecked
		{
			long num163 = decode_get_bytes_consumed.Invoke(&((lzham_lzham_decompressor*)ptr)->m_codec);
			*(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size = num163;
			*(long*)((lzham_lzham_decompressor*)ptr)->m_pOut_buf_size = 0L;
			((lzham_lzham_decompressor*)ptr)->m_state = 437;
			return 2;
		}
		IL_594e:
		unchecked
		{
			long num164 = decode_get_bytes_consumed.Invoke(&((lzham_lzham_decompressor*)ptr)->m_codec);
			*(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size = num164;
			*(long*)((lzham_lzham_decompressor*)ptr)->m_pOut_buf_size = 0L;
			((lzham_lzham_decompressor*)ptr)->m_state = 777;
			return 2;
		}
		IL_1613:
		num11 += 8;
		unchecked
		{
			num10 |= (long)((ulong)(uint)num144 << (int)(uint)checked(64 - num11));
			goto IL_13b4;
		}
		IL_8817:
		unchecked
		{
			int num165 = (int)((num10 >>> 48) + 1L);
			int num167;
			int num168;
			if ((uint)num165 <= (uint)((lzham_prefix_coding_decoder_tables*)pDecode_tables2)->m_table_max_code)
			{
				int num166 = ((int*)((lzham_prefix_coding_decoder_tables*)pDecode_tables2)->m_lookup)[num10 >>> (int)(uint)(64 - ((lzham_prefix_coding_decoder_tables*)pDecode_tables2)->m_table_bits)];
				num167 = num166 & 0xFFFF;
				num168 = num166 >>> 16;
			}
			else
			{
				for (num168 = ((lzham_prefix_coding_decoder_tables*)pDecode_tables2)->m_decode_start_code_size; (uint)num165 > (uint)((int*)(&((lzham_prefix_coding_decoder_tables*)pDecode_tables2)->m_max_codes))[(uint)(num168 - 1)]; num168++)
				{
				}
				int num169;
				checked
				{
					num169 = unchecked(((int*)(&((lzham_prefix_coding_decoder_tables*)pDecode_tables2)->m_val_ptrs))[(uint)(num168 - 1)]) + unchecked((int)(num10 >>> (int)(uint)(64 - num168)));
				}
				if ((uint)num169 >= (uint)((lzham_raw_quasi_adaptive_huffman_data_model*)ptr5)->m_total_syms)
				{
					num169 = 0;
				}
				num167 = (ushort)((short*)((lzham_prefix_coding_decoder_tables*)pDecode_tables2)->m_sorted_symbol_order)[num169];
			}
			num10 <<= (int)(uint)num168;
			num11 -= num168;
			int num170 = (ushort)(*(short*)vector_unsigned_short_Operator.Invoke(&((lzham_raw_quasi_adaptive_huffman_data_model*)ptr5)->m_sym_freq, num167));
			*(short*)vector_unsigned_short_Operator.Invoke(&((lzham_raw_quasi_adaptive_huffman_data_model*)ptr5)->m_sym_freq, num167) = (short)(num170 + 1);
			if ((((lzham_raw_quasi_adaptive_huffman_data_model*)ptr5)->m_symbols_until_update += -1) == 0)
			{
				update_tables.Invoke(ptr5, -1, sym_freq_all_ones: false);
				if (ExceptionInfo.Current != null)
				{
					return 0;
				}
			}
			num12 += num167;
			if (num12 != 258)
			{
				goto IL_9059;
			}
			num12 = 0;
			goto IL_89c4;
		}
		IL_1f15:
		num153 = 0;
		unchecked
		{
			if (ptr3 < ((lzham_symbol_codec*)codec)->m_pDecode_buf_end)
			{
				void* ptr75 = ptr3;
				ptr3 = (byte*)ptr75 + 1;
				num153 = (byte)(*(sbyte*)ptr75);
			}
			goto IL_1f5d;
		}
		IL_7b42:
		unchecked
		{
			if ((uint)num9 < 16777216u)
			{
				((lzham_symbol_codec*)codec)->m_pSaved_model = ptr49;
				goto IL_7b65;
			}
			int num171 = (ushort)((lzham_adaptive_bit_model*)ptr49)->m_bit_0_prob * (num9 >>> 11);
			int num172 = (((uint)num8 >= (uint)num171) ? 1 : 0);
			if (num172 == 0)
			{
				int num173 = 2048 - (ushort)((lzham_adaptive_bit_model*)ptr49)->m_bit_0_prob >>> 5;
				short* bit_0_prob11 = &((lzham_adaptive_bit_model*)ptr49)->m_bit_0_prob;
				*bit_0_prob11 = (short)((ushort)(*bit_0_prob11) + num173);
				num9 = num171;
			}
			else
			{
				int num174 = (ushort)((lzham_adaptive_bit_model*)ptr49)->m_bit_0_prob >> 5;
				short* bit_0_prob12 = &((lzham_adaptive_bit_model*)ptr49)->m_bit_0_prob;
				*bit_0_prob12 = (short)checked(unchecked((ushort)(*bit_0_prob12)) - num174);
				num8 -= num171;
				num9 -= num171;
			}
			if (num172 != 0)
			{
				int num175 = num4;
				num4 = num3;
				num3 = num2;
				num2 = num175;
			}
			else
			{
				int num176 = num5;
				num5 = num4;
				num4 = num3;
				num3 = num2;
				num2 = num176;
			}
			goto IL_7f45;
		}
		IL_608a:
		if (num11 >= 24)
		{
			goto IL_638d;
		}
		unchecked
		{
			if ((((lzham_symbol_codec*)codec)->m_decode_buf_eof & 1) != 1)
			{
				((lzham_symbol_codec*)codec)->m_pSaved_huff_model = ptr8;
				((lzham_symbol_codec*)codec)->m_arith_value = num8;
				((lzham_symbol_codec*)codec)->m_arith_length = num9;
				((lzham_symbol_codec*)codec)->m_bit_buf = num10;
				((lzham_symbol_codec*)codec)->m_bit_count = num11;
				((lzham_symbol_codec*)codec)->m_pDecode_buf_next = ptr3;
				((lzham_lzham_decompressor*)ptr)->m_match_len = num12;
				((lzham_lzham_decompressor*)ptr)->m_match_hist0 = num2;
				((lzham_lzham_decompressor*)ptr)->m_match_hist1 = num3;
				((lzham_lzham_decompressor*)ptr)->m_match_hist2 = num4;
				((lzham_lzham_decompressor*)ptr)->m_match_hist3 = num5;
				((lzham_lzham_decompressor*)ptr)->m_cur_state = num6;
				((lzham_lzham_decompressor*)ptr)->m_dst_ofs = num7;
				goto IL_6189;
			}
			goto IL_62cd;
		}
		IL_555a:
		unchecked
		{
			long num177 = decode_get_bytes_consumed.Invoke(&((lzham_lzham_decompressor*)ptr)->m_codec);
			*(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size = num177;
			*(long*)((lzham_lzham_decompressor*)ptr)->m_pOut_buf_size = 0L;
			((lzham_lzham_decompressor*)ptr)->m_state = 774;
			return 2;
		}
		IL_285a:
		num11 += 8;
		int num178;
		unchecked
		{
			num10 |= (long)((ulong)(uint)num178 << (int)(uint)checked(64 - num11));
			goto IL_25e0;
		}
		IL_7dde:
		num11 += 8;
		unchecked
		{
			num10 |= (long)((ulong)(uint)num129 << (int)(uint)checked(64 - num11));
			goto IL_7b65;
		}
		IL_4747:
		unchecked
		{
			long num179 = decode_get_bytes_consumed.Invoke(&((lzham_lzham_decompressor*)ptr)->m_codec);
			*(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size = num179;
			*(long*)((lzham_lzham_decompressor*)ptr)->m_pOut_buf_size = 0L;
			((lzham_lzham_decompressor*)ptr)->m_state = 711;
			return 2;
		}
		IL_4882:
		num91 = 0;
		unchecked
		{
			if (ptr3 < ((lzham_symbol_codec*)codec)->m_pDecode_buf_end)
			{
				void* ptr76 = ptr3;
				ptr3 = (byte*)ptr76 + 1;
				num91 = (byte)(*(sbyte*)ptr76);
			}
			num11 = checked(num11 + 8);
			num10 |= (long)((ulong)(uint)num91 << (int)(uint)checked(64 - num11));
			goto IL_4659;
		}
		IL_26e0:
		unchecked
		{
			long num180 = decode_get_bytes_consumed.Invoke(&((lzham_lzham_decompressor*)ptr)->m_codec);
			*(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size = num180;
			*(long*)((lzham_lzham_decompressor*)ptr)->m_pOut_buf_size = 0L;
			((lzham_lzham_decompressor*)ptr)->m_state = 517;
			return 2;
		}
		IL_84fa:
		if (num11 >= 24)
		{
			goto IL_8817;
		}
		unchecked
		{
			if ((((lzham_symbol_codec*)codec)->m_decode_buf_eof & 1) != 1)
			{
				((lzham_symbol_codec*)codec)->m_pSaved_huff_model = ptr5;
				((lzham_symbol_codec*)codec)->m_arith_value = num8;
				((lzham_symbol_codec*)codec)->m_arith_length = num9;
				((lzham_symbol_codec*)codec)->m_bit_buf = num10;
				((lzham_symbol_codec*)codec)->m_bit_count = num11;
				((lzham_symbol_codec*)codec)->m_pDecode_buf_next = ptr3;
				((lzham_lzham_decompressor*)ptr)->m_match_len = num12;
				((lzham_lzham_decompressor*)ptr)->m_match_slot = num13;
				((lzham_lzham_decompressor*)ptr)->m_match_hist0 = num2;
				((lzham_lzham_decompressor*)ptr)->m_match_hist1 = num3;
				((lzham_lzham_decompressor*)ptr)->m_match_hist2 = num4;
				((lzham_lzham_decompressor*)ptr)->m_match_hist3 = num5;
				((lzham_lzham_decompressor*)ptr)->m_cur_state = num6;
				((lzham_lzham_decompressor*)ptr)->m_dst_ofs = num7;
				goto IL_860a;
			}
			goto IL_8757;
		}
		IL_1cfd:
		unchecked
		{
			if (num11 < 16)
			{
				if (ptr3 == ((lzham_symbol_codec*)codec)->m_pDecode_buf_end)
				{
					if ((((lzham_symbol_codec*)codec)->m_decode_buf_eof & 1) != 1)
					{
						((lzham_symbol_codec*)codec)->m_arith_value = num8;
						((lzham_symbol_codec*)codec)->m_arith_length = num9;
						((lzham_symbol_codec*)codec)->m_bit_buf = num10;
						((lzham_symbol_codec*)codec)->m_bit_count = num11;
						((lzham_symbol_codec*)codec)->m_pDecode_buf_next = ptr3;
						((lzham_lzham_decompressor*)ptr)->m_match_hist0 = num2;
						((lzham_lzham_decompressor*)ptr)->m_match_hist1 = num3;
						((lzham_lzham_decompressor*)ptr)->m_match_hist2 = num4;
						((lzham_lzham_decompressor*)ptr)->m_match_hist3 = num5;
						((lzham_lzham_decompressor*)ptr)->m_cur_state = num6;
						((lzham_lzham_decompressor*)ptr)->m_dst_ofs = num7;
						goto IL_1dec;
					}
					goto IL_1f15;
				}
				void* ptr77 = ptr3;
				ptr3 = (byte*)ptr77 + 1;
				num153 = (byte)(*(sbyte*)ptr77);
				goto IL_1f5d;
			}
			int num105 = (int)(num10 >>> 48);
			num10 <<= 16;
			num11 = checked(num11 - 16);
			if (num105 != 65535)
			{
				((lzham_symbol_codec*)codec)->m_arith_value = num8;
				((lzham_symbol_codec*)codec)->m_arith_length = num9;
				((lzham_symbol_codec*)codec)->m_bit_buf = num10;
				((lzham_symbol_codec*)codec)->m_bit_count = num11;
				((lzham_symbol_codec*)codec)->m_pDecode_buf_next = ptr3;
				long num181 = decode_get_bytes_consumed.Invoke(codec);
				*(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size = num181;
				*(long*)((lzham_lzham_decompressor*)ptr)->m_pOut_buf_size = 0L;
				goto IL_2041;
			}
			if (((lzham_lzham_decompressor*)ptr)->m_tmp != 2 && ((lzham_lzham_decompressor*)ptr)->m_tmp != 3)
			{
				goto IL_a61f;
			}
			((lzham_symbol_codec*)codec)->m_arith_value = num8;
			((lzham_symbol_codec*)codec)->m_arith_length = num9;
			((lzham_symbol_codec*)codec)->m_bit_buf = num10;
			((lzham_symbol_codec*)codec)->m_bit_count = num11;
			((lzham_symbol_codec*)codec)->m_pDecode_buf_next = ptr3;
			if (-1 == 0 && num7 != 0)
			{
				int match_hist13;
				((lzham_lzham_decompressor*)ptr)->m_match_hist0 = match_hist13;
				int match_hist14;
				((lzham_lzham_decompressor*)ptr)->m_match_hist1 = match_hist14;
				int match_hist15;
				((lzham_lzham_decompressor*)ptr)->m_match_hist2 = match_hist15;
				int match_hist16;
				((lzham_lzham_decompressor*)ptr)->m_match_hist3 = match_hist16;
				int cur_state4;
				((lzham_lzham_decompressor*)ptr)->m_cur_state = cur_state4;
				int dst_ofs4;
				((lzham_lzham_decompressor*)ptr)->m_dst_ofs = dst_ofs4;
				_ = (byte*)((lzham_lzham_decompressor*)ptr)->m_pDecomp_buf + (uint)((lzham_lzham_decompressor*)ptr)->m_seed_bytes_to_ignore_when_flushing + (uint)((lzham_lzham_decompressor*)ptr)->m_dst_highwater_ofs;
				sbyte* pFlush_src10;
				((lzham_lzham_decompressor*)ptr)->m_pFlush_src = pFlush_src10;
				_ = (uint)(num7 - ((lzham_lzham_decompressor*)ptr)->m_seed_bytes_to_ignore_when_flushing - ((lzham_lzham_decompressor*)ptr)->m_dst_highwater_ofs);
				long flush_num_bytes_remaining4;
				((lzham_lzham_decompressor*)ptr)->m_flush_num_bytes_remaining = flush_num_bytes_remaining4;
				((lzham_lzham_decompressor*)ptr)->m_seed_bytes_to_ignore_when_flushing = 0;
				int dst_highwater_ofs4;
				((lzham_lzham_decompressor*)ptr)->m_dst_highwater_ofs = dst_highwater_ofs4;
				goto IL_21b6;
			}
			long num182 = decode_get_bytes_consumed.Invoke(codec);
			*(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size = num182;
			long num183 = (uint)(num7 - ((lzham_lzham_decompressor*)ptr)->m_dst_highwater_ofs);
			*(long*)((lzham_lzham_decompressor*)ptr)->m_pOut_buf_size = num183;
			((lzham_lzham_decompressor*)ptr)->m_dst_highwater_ofs = num7;
			((lzham_lzham_decompressor*)ptr)->m_match_hist0 = num2;
			((lzham_lzham_decompressor*)ptr)->m_match_hist1 = num3;
			((lzham_lzham_decompressor*)ptr)->m_match_hist2 = num4;
			((lzham_lzham_decompressor*)ptr)->m_match_hist3 = num5;
			((lzham_lzham_decompressor*)ptr)->m_cur_state = num6;
			((lzham_lzham_decompressor*)ptr)->m_dst_ofs = num7;
			((lzham_lzham_decompressor*)ptr)->m_state = 496;
			return 0;
		}
		IL_1ce3:
		unchecked((lzham_lzham_decompressor*)ptr)->m_state = 453;
		return 14;
		IL_6aab:
		num11 += 8;
		unchecked
		{
			num10 |= (long)((ulong)(uint)num35 << (int)(uint)checked(64 - num11));
			goto IL_681d;
		}
		IL_2812:
		num178 = 0;
		unchecked
		{
			if (ptr3 < ((lzham_symbol_codec*)codec)->m_pDecode_buf_end)
			{
				void* ptr78 = ptr3;
				ptr3 = (byte*)ptr78 + 1;
				num178 = (byte)(*(sbyte*)ptr78);
			}
			goto IL_285a;
		}
		IL_4419:
		num11 += 8;
		unchecked
		{
			num10 |= (long)((ulong)(uint)num102 << (int)(uint)checked(64 - num11));
			goto IL_41ba;
		}
		IL_6c22:
		if (num11 >= 24)
		{
			goto IL_6f25;
		}
		unchecked
		{
			if ((((lzham_symbol_codec*)codec)->m_decode_buf_eof & 1) != 1)
			{
				((lzham_symbol_codec*)codec)->m_pSaved_huff_model = ptr7;
				((lzham_symbol_codec*)codec)->m_arith_value = num8;
				((lzham_symbol_codec*)codec)->m_arith_length = num9;
				((lzham_symbol_codec*)codec)->m_bit_buf = num10;
				((lzham_symbol_codec*)codec)->m_bit_count = num11;
				((lzham_symbol_codec*)codec)->m_pDecode_buf_next = ptr3;
				((lzham_lzham_decompressor*)ptr)->m_match_len = num12;
				((lzham_lzham_decompressor*)ptr)->m_match_hist0 = num2;
				((lzham_lzham_decompressor*)ptr)->m_match_hist1 = num3;
				((lzham_lzham_decompressor*)ptr)->m_match_hist2 = num4;
				((lzham_lzham_decompressor*)ptr)->m_match_hist3 = num5;
				((lzham_lzham_decompressor*)ptr)->m_cur_state = num6;
				((lzham_lzham_decompressor*)ptr)->m_dst_ofs = num7;
				goto IL_6d21;
			}
			goto IL_6e65;
		}
		IL_4942:
		unchecked
		{
			int num184 = (int)((num10 >>> 48) + 1L);
			int num186;
			int num187;
			if ((uint)num184 <= (uint)((lzham_prefix_coding_decoder_tables*)pDecode_tables7)->m_table_max_code)
			{
				int num185 = ((int*)((lzham_prefix_coding_decoder_tables*)pDecode_tables7)->m_lookup)[num10 >>> (int)(uint)(64 - ((lzham_prefix_coding_decoder_tables*)pDecode_tables7)->m_table_bits)];
				num186 = num185 & 0xFFFF;
				num187 = num185 >>> 16;
			}
			else
			{
				for (num187 = ((lzham_prefix_coding_decoder_tables*)pDecode_tables7)->m_decode_start_code_size; (uint)num184 > (uint)((int*)(&((lzham_prefix_coding_decoder_tables*)pDecode_tables7)->m_max_codes))[(uint)(num187 - 1)]; num187++)
				{
				}
				int num188;
				checked
				{
					num188 = unchecked(((int*)(&((lzham_prefix_coding_decoder_tables*)pDecode_tables7)->m_val_ptrs))[(uint)(num187 - 1)]) + unchecked((int)(num10 >>> (int)(uint)(64 - num187)));
				}
				if ((uint)num188 >= (uint)((lzham_raw_quasi_adaptive_huffman_data_model*)ptr10)->m_total_syms)
				{
					num188 = 0;
				}
				num186 = (ushort)((short*)((lzham_prefix_coding_decoder_tables*)pDecode_tables7)->m_sorted_symbol_order)[num188];
			}
			num10 <<= (int)(uint)num187;
			num11 -= num187;
			int num189 = (ushort)(*(short*)vector_unsigned_short_Operator.Invoke(&((lzham_raw_quasi_adaptive_huffman_data_model*)ptr10)->m_sym_freq, num186));
			*(short*)vector_unsigned_short_Operator.Invoke(&((lzham_raw_quasi_adaptive_huffman_data_model*)ptr10)->m_sym_freq, num186) = (short)(num189 + 1);
			if ((((lzham_raw_quasi_adaptive_huffman_data_model*)ptr10)->m_symbols_until_update += -1) == 0)
			{
				update_tables.Invoke(ptr10, -1, sym_freq_all_ones: false);
				if (ExceptionInfo.Current != null)
				{
					return 0;
				}
			}
			((sbyte*)pOut_buf)[(uint)num7] = (sbyte)num186;
			goto IL_4ff1;
		}
		IL_7994:
		num48 = 0;
		unchecked
		{
			if (ptr3 < ((lzham_symbol_codec*)codec)->m_pDecode_buf_end)
			{
				void* ptr79 = ptr3;
				ptr3 = (byte*)ptr79 + 1;
				num48 = (byte)(*(sbyte*)ptr79);
			}
			goto IL_79dc;
		}
		IL_6d21:
		unchecked
		{
			long num190 = decode_get_bytes_consumed.Invoke(&((lzham_lzham_decompressor*)ptr)->m_codec);
			*(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size = num190;
			*(long*)((lzham_lzham_decompressor*)ptr)->m_pOut_buf_size = 0L;
			((lzham_lzham_decompressor*)ptr)->m_state = 810;
			return 2;
		}
		IL_56d4:
		num11 += 8;
		unchecked
		{
			num10 |= (long)((ulong)(uint)num20 << (int)(uint)checked(64 - num11));
			goto IL_545b;
		}
		IL_80b2:
		unchecked
		{
			long num191 = decode_get_bytes_consumed.Invoke(&((lzham_lzham_decompressor*)ptr)->m_codec);
			*(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size = num191;
			*(long*)((lzham_lzham_decompressor*)ptr)->m_pOut_buf_size = 0L;
			((lzham_lzham_decompressor*)ptr)->m_state = 864;
			return 2;
		}
		IL_25e0:
		unchecked
		{
			if (num11 < 24)
			{
				if (ptr3 == ((lzham_symbol_codec*)codec)->m_pDecode_buf_end)
				{
					if ((((lzham_symbol_codec*)codec)->m_decode_buf_eof & 1) != 1)
					{
						((lzham_symbol_codec*)codec)->m_arith_value = num8;
						((lzham_symbol_codec*)codec)->m_arith_length = num9;
						((lzham_symbol_codec*)codec)->m_bit_buf = num10;
						((lzham_symbol_codec*)codec)->m_bit_count = num11;
						((lzham_symbol_codec*)codec)->m_pDecode_buf_next = ptr3;
						((lzham_lzham_decompressor*)ptr)->m_num_raw_bytes_remaining = num17;
						((lzham_lzham_decompressor*)ptr)->m_match_hist0 = num2;
						((lzham_lzham_decompressor*)ptr)->m_match_hist1 = num3;
						((lzham_lzham_decompressor*)ptr)->m_match_hist2 = num4;
						((lzham_lzham_decompressor*)ptr)->m_match_hist3 = num5;
						((lzham_lzham_decompressor*)ptr)->m_cur_state = num6;
						((lzham_lzham_decompressor*)ptr)->m_dst_ofs = num7;
						goto IL_26e0;
					}
					goto IL_2812;
				}
				void* ptr80 = ptr3;
				ptr3 = (byte*)ptr80 + 1;
				num178 = (byte)(*(sbyte*)ptr80);
				goto IL_285a;
			}
			num17 = (int)(num10 >>> 40);
			num10 <<= 24;
		}
		num11 -= 24;
		goto IL_28ac;
		IL_3ca0:
		unchecked
		{
			long num192 = decode_get_bytes_consumed.Invoke(&((lzham_lzham_decompressor*)ptr)->m_codec);
			*(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size = num192;
			*(long*)((lzham_lzham_decompressor*)ptr)->m_pOut_buf_size = 0L;
			((lzham_lzham_decompressor*)ptr)->m_state = 640;
			return 2;
		}
		IL_16bc:
		unchecked
		{
			if (num11 < (num11 & 7))
			{
				if (ptr3 == ((lzham_symbol_codec*)codec)->m_pDecode_buf_end)
				{
					if ((((lzham_symbol_codec*)codec)->m_decode_buf_eof & 1) != 1)
					{
						((lzham_symbol_codec*)codec)->m_arith_value = num8;
						((lzham_symbol_codec*)codec)->m_arith_length = num9;
						((lzham_symbol_codec*)codec)->m_bit_buf = num10;
						((lzham_symbol_codec*)codec)->m_bit_count = num11;
						((lzham_symbol_codec*)codec)->m_pDecode_buf_next = ptr3;
						((lzham_lzham_decompressor*)ptr)->m_match_hist0 = num2;
						((lzham_lzham_decompressor*)ptr)->m_match_hist1 = num3;
						((lzham_lzham_decompressor*)ptr)->m_match_hist2 = num4;
						((lzham_lzham_decompressor*)ptr)->m_match_hist3 = num5;
						((lzham_lzham_decompressor*)ptr)->m_cur_state = num6;
						((lzham_lzham_decompressor*)ptr)->m_dst_ofs = num7;
						goto IL_17ad;
					}
					goto IL_18d6;
				}
				void* ptr81 = ptr3;
				ptr3 = (byte*)ptr81 + 1;
				num154 = (byte)(*(sbyte*)ptr81);
				goto IL_191e;
			}
			if ((num11 & 7) != 0)
			{
				_ = num10 >>> (int)(uint)checked(64 - (num11 & 7));
			}
			num10 <<= (int)(uint)(num11 & 7);
		}
		num11 -= num11 & 7;
		goto IL_19a3;
		IL_40b2:
		num55 = 0;
		unchecked
		{
			if (ptr3 < ((lzham_symbol_codec*)codec)->m_pDecode_buf_end)
			{
				void* ptr82 = ptr3;
				ptr3 = (byte*)ptr82 + 1;
				num55 = (byte)(*(sbyte*)ptr82);
			}
			goto IL_40fa;
		}
		IL_6b90:
		num6 = InstructionHelper.Select(unchecked((uint)num6) < 7u, 8, 11);
		goto IL_9c66;
		IL_a52a:
		int num193 = 0;
		unchecked
		{
			if (ptr3 < ((lzham_symbol_codec*)codec)->m_pDecode_buf_end)
			{
				void* ptr83 = ptr3;
				ptr3 = (byte*)ptr83 + 1;
				num193 = (byte)(*(sbyte*)ptr83);
			}
			goto IL_a572;
		}
		IL_7763:
		unchecked
		{
			if (num11 < 8)
			{
				if (ptr3 == ((lzham_symbol_codec*)codec)->m_pDecode_buf_end)
				{
					if ((((lzham_symbol_codec*)codec)->m_decode_buf_eof & 1) != 1)
					{
						((lzham_symbol_codec*)codec)->m_arith_value = num8;
						((lzham_symbol_codec*)codec)->m_arith_length = num9;
						((lzham_symbol_codec*)codec)->m_bit_buf = num10;
						((lzham_symbol_codec*)codec)->m_bit_count = num11;
						((lzham_symbol_codec*)codec)->m_pDecode_buf_next = ptr3;
						((lzham_lzham_decompressor*)ptr)->m_match_len = num12;
						((lzham_lzham_decompressor*)ptr)->m_match_hist0 = num2;
						((lzham_lzham_decompressor*)ptr)->m_match_hist1 = num3;
						((lzham_lzham_decompressor*)ptr)->m_match_hist2 = num4;
						((lzham_lzham_decompressor*)ptr)->m_match_hist3 = num5;
						((lzham_lzham_decompressor*)ptr)->m_cur_state = num6;
						((lzham_lzham_decompressor*)ptr)->m_dst_ofs = num7;
						goto IL_7862;
					}
					goto IL_7994;
				}
				void* ptr84 = ptr3;
				ptr3 = (byte*)ptr84 + 1;
				num48 = (byte)(*(sbyte*)ptr84);
				goto IL_79dc;
			}
			int num194 = (int)(num10 >>> 56);
			num10 <<= 8;
			num11 = checked(num11 - 8);
			ptr48 = ((lzham_symbol_codec*)codec)->m_pSaved_model;
			num8 = (num8 << 8) | num194;
			num9 <<= 8;
			goto IL_7740;
		}
		IL_4e45:
		unchecked
		{
			int num195 = (int)((num10 >>> 48) + 1L);
			int num197;
			int num198;
			if ((uint)num195 <= (uint)((lzham_prefix_coding_decoder_tables*)pDecode_tables6)->m_table_max_code)
			{
				int num196 = ((int*)((lzham_prefix_coding_decoder_tables*)pDecode_tables6)->m_lookup)[num10 >>> (int)(uint)(64 - ((lzham_prefix_coding_decoder_tables*)pDecode_tables6)->m_table_bits)];
				num197 = num196 & 0xFFFF;
				num198 = num196 >>> 16;
			}
			else
			{
				for (num198 = ((lzham_prefix_coding_decoder_tables*)pDecode_tables6)->m_decode_start_code_size; (uint)num195 > (uint)((int*)(&((lzham_prefix_coding_decoder_tables*)pDecode_tables6)->m_max_codes))[(uint)(num198 - 1)]; num198++)
				{
				}
				int num199;
				checked
				{
					num199 = unchecked(((int*)(&((lzham_prefix_coding_decoder_tables*)pDecode_tables6)->m_val_ptrs))[(uint)(num198 - 1)]) + unchecked((int)(num10 >>> (int)(uint)(64 - num198)));
				}
				if ((uint)num199 >= (uint)((lzham_raw_quasi_adaptive_huffman_data_model*)ptr9)->m_total_syms)
				{
					num199 = 0;
				}
				num197 = (ushort)((short*)((lzham_prefix_coding_decoder_tables*)pDecode_tables6)->m_sorted_symbol_order)[num199];
			}
			num10 <<= (int)(uint)num198;
			num11 -= num198;
			int num200 = (ushort)(*(short*)vector_unsigned_short_Operator.Invoke(&((lzham_raw_quasi_adaptive_huffman_data_model*)ptr9)->m_sym_freq, num197));
			*(short*)vector_unsigned_short_Operator.Invoke(&((lzham_raw_quasi_adaptive_huffman_data_model*)ptr9)->m_sym_freq, num197) = (short)(num200 + 1);
			if ((((lzham_raw_quasi_adaptive_huffman_data_model*)ptr9)->m_symbols_until_update += -1) == 0)
			{
				update_tables.Invoke(ptr9, -1, sym_freq_all_ones: false);
				if (ExceptionInfo.Current != null)
				{
					return 0;
				}
			}
			((sbyte*)pOut_buf)[(uint)num7] = (sbyte)(num197 ^ num16);
			goto IL_4ff1;
		}
		IL_1c03:
		num11 += 8;
		unchecked
		{
			num10 |= (long)((ulong)(uint)num76 << (int)(uint)checked(64 - num11));
			goto IL_19a3;
		}
		IL_a572:
		num11 += 8;
		unchecked
		{
			num10 |= (long)((ulong)(uint)num193 << (int)(uint)checked(64 - num11));
			goto IL_a310;
		}
		IL_2596:
		unchecked
		{
			num8 = ((lzham_symbol_codec*)codec)->m_arith_value;
			num9 = ((lzham_symbol_codec*)codec)->m_arith_length;
			num10 = ((lzham_symbol_codec*)codec)->m_bit_buf;
			num11 = ((lzham_symbol_codec*)codec)->m_bit_count;
			ptr3 = ((lzham_symbol_codec*)codec)->m_pDecode_buf_next;
			goto IL_a61f;
		}
		IL_545b:
		unchecked
		{
			if (num11 < 8)
			{
				if (ptr3 == ((lzham_symbol_codec*)codec)->m_pDecode_buf_end)
				{
					if ((((lzham_symbol_codec*)codec)->m_decode_buf_eof & 1) != 1)
					{
						((lzham_symbol_codec*)codec)->m_arith_value = num8;
						((lzham_symbol_codec*)codec)->m_arith_length = num9;
						((lzham_symbol_codec*)codec)->m_bit_buf = num10;
						((lzham_symbol_codec*)codec)->m_bit_count = num11;
						((lzham_symbol_codec*)codec)->m_pDecode_buf_next = ptr3;
						((lzham_lzham_decompressor*)ptr)->m_match_len = num12;
						((lzham_lzham_decompressor*)ptr)->m_match_hist0 = num2;
						((lzham_lzham_decompressor*)ptr)->m_match_hist1 = num3;
						((lzham_lzham_decompressor*)ptr)->m_match_hist2 = num4;
						((lzham_lzham_decompressor*)ptr)->m_match_hist3 = num5;
						((lzham_lzham_decompressor*)ptr)->m_cur_state = num6;
						((lzham_lzham_decompressor*)ptr)->m_dst_ofs = num7;
						goto IL_555a;
					}
					goto IL_568c;
				}
				void* ptr85 = ptr3;
				ptr3 = (byte*)ptr85 + 1;
				num20 = (byte)(*(sbyte*)ptr85);
				goto IL_56d4;
			}
			int num201 = (int)(num10 >>> 56);
			num10 <<= 8;
			num11 = checked(num11 - 8);
			ptr47 = ((lzham_symbol_codec*)codec)->m_pSaved_model;
			num8 = (num8 << 8) | num201;
			num9 <<= 8;
			goto IL_5438;
		}
		IL_75fb:
		num75 = 0;
		unchecked
		{
			if (ptr3 < ((lzham_symbol_codec*)codec)->m_pDecode_buf_end)
			{
				void* ptr86 = ptr3;
				ptr3 = (byte*)ptr86 + 1;
				num75 = (byte)(*(sbyte*)ptr86);
			}
			goto IL_7643;
		}
		IL_7fb3:
		if (num11 >= 24)
		{
			goto IL_82b6;
		}
		unchecked
		{
			if ((((lzham_symbol_codec*)codec)->m_decode_buf_eof & 1) != 1)
			{
				((lzham_symbol_codec*)codec)->m_pSaved_huff_model = ptr6;
				((lzham_symbol_codec*)codec)->m_arith_value = num8;
				((lzham_symbol_codec*)codec)->m_arith_length = num9;
				((lzham_symbol_codec*)codec)->m_bit_buf = num10;
				((lzham_symbol_codec*)codec)->m_bit_count = num11;
				((lzham_symbol_codec*)codec)->m_pDecode_buf_next = ptr3;
				((lzham_lzham_decompressor*)ptr)->m_match_len = num12;
				((lzham_lzham_decompressor*)ptr)->m_match_hist0 = num2;
				((lzham_lzham_decompressor*)ptr)->m_match_hist1 = num3;
				((lzham_lzham_decompressor*)ptr)->m_match_hist2 = num4;
				((lzham_lzham_decompressor*)ptr)->m_match_hist3 = num5;
				((lzham_lzham_decompressor*)ptr)->m_cur_state = num6;
				((lzham_lzham_decompressor*)ptr)->m_dst_ofs = num7;
				goto IL_80b2;
			}
			goto IL_81f6;
		}
		IL_4ff1:
		unchecked
		{
			num6 = (byte)((sbyte*)s_literal_next_state.Pointer)[(uint)num6];
			num7++;
			if (uint.MaxValue != 0 || (uint)num7 <= uint.MaxValue)
			{
				goto IL_417b;
			}
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
			int match_hist17;
			((lzham_lzham_decompressor*)ptr)->m_match_hist0 = match_hist17;
			int match_hist18;
			((lzham_lzham_decompressor*)ptr)->m_match_hist1 = match_hist18;
			int match_hist19;
			((lzham_lzham_decompressor*)ptr)->m_match_hist2 = match_hist19;
			int match_hist20;
			((lzham_lzham_decompressor*)ptr)->m_match_hist3 = match_hist20;
			int cur_state5;
			((lzham_lzham_decompressor*)ptr)->m_cur_state = cur_state5;
			int dst_ofs5;
			((lzham_lzham_decompressor*)ptr)->m_dst_ofs = dst_ofs5;
			_ = (byte*)((lzham_lzham_decompressor*)ptr)->m_pDecomp_buf + (uint)((lzham_lzham_decompressor*)ptr)->m_seed_bytes_to_ignore_when_flushing + (uint)((lzham_lzham_decompressor*)ptr)->m_dst_highwater_ofs;
			sbyte* pFlush_src11;
			((lzham_lzham_decompressor*)ptr)->m_pFlush_src = pFlush_src11;
			_ = (uint)(num - ((lzham_lzham_decompressor*)ptr)->m_seed_bytes_to_ignore_when_flushing - ((lzham_lzham_decompressor*)ptr)->m_dst_highwater_ofs);
			long flush_num_bytes_remaining5;
			((lzham_lzham_decompressor*)ptr)->m_flush_num_bytes_remaining = flush_num_bytes_remaining5;
			((lzham_lzham_decompressor*)ptr)->m_seed_bytes_to_ignore_when_flushing = 0;
			int dst_highwater_ofs5;
			((lzham_lzham_decompressor*)ptr)->m_dst_highwater_ofs = dst_highwater_ofs5;
			goto IL_514a;
		}
		IL_191e:
		num11 += 8;
		unchecked
		{
			num10 |= (long)((ulong)(uint)num154 << (int)(uint)checked(64 - num11));
			goto IL_16bc;
		}
		IL_a310:
		unchecked
		{
			if (num11 < (num11 & 7))
			{
				if (ptr3 == ((lzham_symbol_codec*)codec)->m_pDecode_buf_end)
				{
					if ((((lzham_symbol_codec*)codec)->m_decode_buf_eof & 1) != 1)
					{
						((lzham_symbol_codec*)codec)->m_arith_value = num8;
						((lzham_symbol_codec*)codec)->m_arith_length = num9;
						((lzham_symbol_codec*)codec)->m_bit_buf = num10;
						((lzham_symbol_codec*)codec)->m_bit_count = num11;
						((lzham_symbol_codec*)codec)->m_pDecode_buf_next = ptr3;
						((lzham_lzham_decompressor*)ptr)->m_match_hist0 = num2;
						((lzham_lzham_decompressor*)ptr)->m_match_hist1 = num3;
						((lzham_lzham_decompressor*)ptr)->m_match_hist2 = num4;
						((lzham_lzham_decompressor*)ptr)->m_match_hist3 = num5;
						((lzham_lzham_decompressor*)ptr)->m_cur_state = num6;
						((lzham_lzham_decompressor*)ptr)->m_dst_ofs = num7;
						goto IL_a401;
					}
					goto IL_a52a;
				}
				void* ptr87 = ptr3;
				ptr3 = (byte*)ptr87 + 1;
				num193 = (byte)(*(sbyte*)ptr87);
				goto IL_a572;
			}
			if ((num11 & 7) != 0)
			{
				_ = num10 >>> (int)(uint)checked(64 - (num11 & 7));
			}
			num10 <<= (int)(uint)(num11 & 7);
		}
		num11 -= num11 & 7;
		goto IL_a61f;
		IL_7b65:
		unchecked
		{
			if (num11 < 8)
			{
				if (ptr3 == ((lzham_symbol_codec*)codec)->m_pDecode_buf_end)
				{
					if ((((lzham_symbol_codec*)codec)->m_decode_buf_eof & 1) != 1)
					{
						((lzham_symbol_codec*)codec)->m_arith_value = num8;
						((lzham_symbol_codec*)codec)->m_arith_length = num9;
						((lzham_symbol_codec*)codec)->m_bit_buf = num10;
						((lzham_symbol_codec*)codec)->m_bit_count = num11;
						((lzham_symbol_codec*)codec)->m_pDecode_buf_next = ptr3;
						((lzham_lzham_decompressor*)ptr)->m_match_len = num12;
						((lzham_lzham_decompressor*)ptr)->m_match_hist0 = num2;
						((lzham_lzham_decompressor*)ptr)->m_match_hist1 = num3;
						((lzham_lzham_decompressor*)ptr)->m_match_hist2 = num4;
						((lzham_lzham_decompressor*)ptr)->m_match_hist3 = num5;
						((lzham_lzham_decompressor*)ptr)->m_cur_state = num6;
						((lzham_lzham_decompressor*)ptr)->m_dst_ofs = num7;
						goto IL_7c64;
					}
					goto IL_7d96;
				}
				void* ptr88 = ptr3;
				ptr3 = (byte*)ptr88 + 1;
				num129 = (byte)(*(sbyte*)ptr88);
				goto IL_7dde;
			}
			int num202 = (int)(num10 >>> 56);
			num10 <<= 8;
			num11 = checked(num11 - 8);
			ptr49 = ((lzham_symbol_codec*)codec)->m_pSaved_model;
			num8 = (num8 << 8) | num202;
			num9 <<= 8;
			goto IL_7b42;
		}
		IL_b368:
		unchecked
		{
			((lzham_symbol_codec*)codec)->m_arith_value = num8;
			((lzham_symbol_codec*)codec)->m_arith_length = num9;
			((lzham_symbol_codec*)codec)->m_bit_buf = num10;
			((lzham_symbol_codec*)codec)->m_bit_count = num11;
			((lzham_symbol_codec*)codec)->m_pDecode_buf_next = ptr3;
			long num203 = stop_decoding.Invoke(codec);
			*(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size = num203;
			long num204 = (uint)(num7 - ((lzham_lzham_decompressor*)ptr)->m_dst_highwater_ofs);
			*(long*)((lzham_lzham_decompressor*)ptr)->m_pOut_buf_size = num204;
			((lzham_lzham_decompressor*)ptr)->m_dst_highwater_ofs = num7;
			((lzham_lzham_decompressor*)ptr)->m_state = 1110;
			return ((lzham_lzham_decompressor*)ptr)->m_status;
		}
		IL_7c64:
		unchecked
		{
			long num205 = decode_get_bytes_consumed.Invoke(&((lzham_lzham_decompressor*)ptr)->m_codec);
			*(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size = num205;
			*(long*)((lzham_lzham_decompressor*)ptr)->m_pOut_buf_size = 0L;
			((lzham_lzham_decompressor*)ptr)->m_state = 837;
			return 2;
		}
		IL_73b5:
		int num206;
		unchecked
		{
			if (num11 < (byte)((sbyte*)s_huge_match_code_len.Pointer)[(uint)num12])
			{
				if (ptr3 == ((lzham_symbol_codec*)codec)->m_pDecode_buf_end)
				{
					if ((((lzham_symbol_codec*)codec)->m_decode_buf_eof & 1) != 1)
					{
						((lzham_symbol_codec*)codec)->m_arith_value = num8;
						((lzham_symbol_codec*)codec)->m_arith_length = num9;
						((lzham_symbol_codec*)codec)->m_bit_buf = num10;
						((lzham_symbol_codec*)codec)->m_bit_count = num11;
						((lzham_symbol_codec*)codec)->m_pDecode_buf_next = ptr3;
						((lzham_lzham_decompressor*)ptr)->m_match_len = num12;
						((lzham_lzham_decompressor*)ptr)->m_match_hist0 = num2;
						((lzham_lzham_decompressor*)ptr)->m_match_hist1 = num3;
						((lzham_lzham_decompressor*)ptr)->m_match_hist2 = num4;
						((lzham_lzham_decompressor*)ptr)->m_match_hist3 = num5;
						((lzham_lzham_decompressor*)ptr)->m_cur_state = num6;
						((lzham_lzham_decompressor*)ptr)->m_dst_ofs = num7;
						goto IL_74c9;
					}
					goto IL_75fb;
				}
				void* ptr89 = ptr3;
				ptr3 = (byte*)ptr89 + 1;
				num75 = (byte)(*(sbyte*)ptr89);
				goto IL_7643;
			}
			num206 = (int)(((bool*)s_huge_match_code_len.Pointer)[(uint)num12] ? (num10 >>> (int)(uint)checked(64 - unchecked((byte)((sbyte*)s_huge_match_code_len.Pointer)[(uint)num12]))) : 0);
			num10 <<= (int)(byte)((sbyte*)s_huge_match_code_len.Pointer)[(uint)num12];
		}
		num11 -= unchecked((byte)((sbyte*)s_huge_match_code_len.Pointer)[(uint)num12]);
		num12 = unchecked(((int*)s_huge_match_base_len.Pointer)[(uint)num12] + num206);
		goto IL_7728;
		IL_71c8:
		unchecked
		{
			long num207 = decode_get_bytes_consumed.Invoke(&((lzham_lzham_decompressor*)ptr)->m_codec);
			*(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size = num207;
			*(long*)((lzham_lzham_decompressor*)ptr)->m_pOut_buf_size = 0L;
			((lzham_lzham_decompressor*)ptr)->m_state = 819;
			return 2;
		}
		IL_b113:
		unchecked
		{
			long num208 = decode_get_bytes_consumed.Invoke(&((lzham_lzham_decompressor*)ptr)->m_codec);
			*(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size = num208;
			*(long*)((lzham_lzham_decompressor*)ptr)->m_pOut_buf_size = 0L;
			((lzham_lzham_decompressor*)ptr)->m_state = 1083;
			return 2;
		}
		IL_514a:
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
					long num210;
					for (long num209 = 0L; (ulong)num209 < (ulong)((lzham_lzham_decompressor*)ptr)->m_flush_n; num209 += num210)
					{
						num210 = (((ulong)(((lzham_lzham_decompressor*)ptr)->m_flush_n - num209) >= 8192uL) ? 8192L : (((lzham_lzham_decompressor*)ptr)->m_flush_n - num209));
						llvm_memcpy_p0_p0_i64.Invoke((byte*)((lzham_lzham_decompressor*)ptr)->m_pOut_buf + num209, (byte*)((lzham_lzham_decompressor*)ptr)->m_pFlush_src + num209, num210, isVolatile: false);
						((lzham_lzham_decompressor*)ptr)->m_decomp_adler32 = adler32.Invoke(adler32: ((lzham_lzham_decompressor*)ptr)->m_decomp_adler32, pBuf: (byte*)((lzham_lzham_decompressor*)ptr)->m_pFlush_src + num209, buflen: num210);
					}
				}
				long num211 = decode_get_bytes_consumed.Invoke(&((lzham_lzham_decompressor*)ptr)->m_codec);
				*(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size = num211;
				long flush_n17 = ((lzham_lzham_decompressor*)ptr)->m_flush_n;
				*(long*)((lzham_lzham_decompressor*)ptr)->m_pOut_buf_size = flush_n17;
				((lzham_lzham_decompressor*)ptr)->m_state = 757;
				return InstructionHelper.Select(((lzham_lzham_decompressor*)ptr)->m_flush_n != 0L, 0, 1);
			}
			num2 = ((lzham_lzham_decompressor*)ptr)->m_match_hist0;
			num3 = ((lzham_lzham_decompressor*)ptr)->m_match_hist1;
			num4 = ((lzham_lzham_decompressor*)ptr)->m_match_hist2;
			num5 = ((lzham_lzham_decompressor*)ptr)->m_match_hist3;
			num6 = ((lzham_lzham_decompressor*)ptr)->m_cur_state;
			_ = ((lzham_lzham_decompressor*)ptr)->m_dst_ofs;
			num8 = ((lzham_symbol_codec*)codec)->m_arith_value;
			num9 = ((lzham_symbol_codec*)codec)->m_arith_length;
			num10 = ((lzham_symbol_codec*)codec)->m_bit_buf;
			num11 = ((lzham_symbol_codec*)codec)->m_bit_count;
			ptr3 = ((lzham_symbol_codec*)codec)->m_pDecode_buf_next;
			num7 = 0;
			goto IL_417b;
		}
		IL_a78f:
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
					long num213;
					for (long num212 = 0L; (ulong)num212 < (ulong)((lzham_lzham_decompressor*)ptr)->m_flush_n; num212 += num213)
					{
						num213 = (((ulong)(((lzham_lzham_decompressor*)ptr)->m_flush_n - num212) >= 8192uL) ? 8192L : (((lzham_lzham_decompressor*)ptr)->m_flush_n - num212));
						llvm_memcpy_p0_p0_i64.Invoke((byte*)((lzham_lzham_decompressor*)ptr)->m_pOut_buf + num212, (byte*)((lzham_lzham_decompressor*)ptr)->m_pFlush_src + num212, num213, isVolatile: false);
						((lzham_lzham_decompressor*)ptr)->m_decomp_adler32 = adler32.Invoke(adler32: ((lzham_lzham_decompressor*)ptr)->m_decomp_adler32, pBuf: (byte*)((lzham_lzham_decompressor*)ptr)->m_pFlush_src + num212, buflen: num213);
					}
				}
				long num214 = decode_get_bytes_consumed.Invoke(&((lzham_lzham_decompressor*)ptr)->m_codec);
				*(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size = num214;
				long flush_n18 = ((lzham_lzham_decompressor*)ptr)->m_flush_n;
				*(long*)((lzham_lzham_decompressor*)ptr)->m_pOut_buf_size = flush_n18;
				((lzham_lzham_decompressor*)ptr)->m_state = 1074;
				return InstructionHelper.Select(((lzham_lzham_decompressor*)ptr)->m_flush_n != 0L, 0, 1);
			}
			num2 = ((lzham_lzham_decompressor*)ptr)->m_match_hist0;
			num3 = ((lzham_lzham_decompressor*)ptr)->m_match_hist1;
			num4 = ((lzham_lzham_decompressor*)ptr)->m_match_hist2;
			num5 = ((lzham_lzham_decompressor*)ptr)->m_match_hist3;
			num6 = ((lzham_lzham_decompressor*)ptr)->m_cur_state;
			num7 = ((lzham_lzham_decompressor*)ptr)->m_dst_ofs;
			num8 = ((lzham_symbol_codec*)codec)->m_arith_value;
			num9 = ((lzham_symbol_codec*)codec)->m_arith_length;
			num10 = ((lzham_symbol_codec*)codec)->m_bit_buf;
			num11 = ((lzham_symbol_codec*)codec)->m_bit_count;
			ptr3 = ((lzham_symbol_codec*)codec)->m_pDecode_buf_next;
			goto IL_aa5a;
		}
		IL_7342:
		num11 += 8;
		unchecked
		{
			num10 |= (long)((ulong)(uint)num32 << (int)(uint)checked(64 - num11));
			goto IL_70c9;
		}
		IL_89c4:
		unchecked
		{
			while (num11 >= 1)
			{
				int num215 = (int)(num10 >>> 63);
				num10 <<= 1;
				num11 = checked(num11 - 1);
				if (num215 != 0)
				{
					num12++;
					if ((uint)num12 < 3u)
					{
						continue;
					}
				}
				goto IL_8cca;
			}
			if (ptr3 == ((lzham_symbol_codec*)codec)->m_pDecode_buf_end)
			{
				if ((((lzham_symbol_codec*)codec)->m_decode_buf_eof & 1) != 1)
				{
					((lzham_symbol_codec*)codec)->m_arith_value = num8;
					((lzham_symbol_codec*)codec)->m_arith_length = num9;
					((lzham_symbol_codec*)codec)->m_bit_buf = num10;
					((lzham_symbol_codec*)codec)->m_bit_count = num11;
					((lzham_symbol_codec*)codec)->m_pDecode_buf_next = ptr3;
					((lzham_lzham_decompressor*)ptr)->m_match_len = num12;
					((lzham_lzham_decompressor*)ptr)->m_match_slot = num13;
					((lzham_lzham_decompressor*)ptr)->m_match_hist0 = num2;
					((lzham_lzham_decompressor*)ptr)->m_match_hist1 = num3;
					((lzham_lzham_decompressor*)ptr)->m_match_hist2 = num4;
					((lzham_lzham_decompressor*)ptr)->m_match_hist3 = num5;
					((lzham_lzham_decompressor*)ptr)->m_cur_state = num6;
					((lzham_lzham_decompressor*)ptr)->m_dst_ofs = num7;
					goto IL_8ad4;
				}
				goto IL_8c0f;
			}
			void* ptr90 = ptr3;
			ptr3 = (byte*)ptr90 + 1;
			num79 = (byte)(*(sbyte*)ptr90);
			goto IL_8c57;
		}
		IL_5a80:
		num26 = 0;
		unchecked
		{
			if (ptr3 < ((lzham_symbol_codec*)codec)->m_pDecode_buf_end)
			{
				void* ptr91 = ptr3;
				ptr3 = (byte*)ptr91 + 1;
				num26 = (byte)(*(sbyte*)ptr91);
			}
			goto IL_5ac8;
		}
		IL_6189:
		unchecked
		{
			long num216 = decode_get_bytes_consumed.Invoke(&((lzham_lzham_decompressor*)ptr)->m_codec);
			*(long*)((lzham_lzham_decompressor*)ptr)->m_pIn_buf_size = num216;
			*(long*)((lzham_lzham_decompressor*)ptr)->m_pOut_buf_size = 0L;
			((lzham_lzham_decompressor*)ptr)->m_state = 787;
			return 2;
		}
	}
}
