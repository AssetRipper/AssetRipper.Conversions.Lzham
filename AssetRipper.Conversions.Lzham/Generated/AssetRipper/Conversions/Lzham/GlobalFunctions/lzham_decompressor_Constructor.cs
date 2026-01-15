using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.InlineArrays;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("??0lzham_decompressor@lzham@@QEAA@XZ")]
[DemangledName("public: __cdecl lzham::lzham_decompressor::lzham_decompressor(void)")]
internal static partial class lzham_decompressor_Constructor
{
	public unsafe static void* Invoke(void* @this)
	{
		unchecked
		{
			_ = &((lzham_lzham_decompressor*)@this)->m_lzBase;
			lzham_symbol_codec* codec = &((lzham_lzham_decompressor*)@this)->m_codec;
			symbol_codec_Constructor.Invoke(codec);
			if (ExceptionInfo.Current != null)
			{
				return null;
			}
			_ = &((lzham_lzham_decompressor*)@this)->m_params;
			lzham_quasi_adaptive_huffman_data_model* lit_table = &((lzham_lzham_decompressor*)@this)->m_lit_table;
			quasi_adaptive_huffman_data_model_Constructor.Invoke(lit_table);
			if (ExceptionInfo.Current == null)
			{
				lzham_quasi_adaptive_huffman_data_model* delta_lit_table = &((lzham_lzham_decompressor*)@this)->m_delta_lit_table;
				quasi_adaptive_huffman_data_model_Constructor.Invoke(delta_lit_table);
				if (ExceptionInfo.Current == null)
				{
					lzham_quasi_adaptive_huffman_data_model* main_table = &((lzham_lzham_decompressor*)@this)->m_main_table;
					quasi_adaptive_huffman_data_model_Constructor.Invoke(main_table);
					if (ExceptionInfo.Current == null)
					{
						InlineArray2_lzham_quasi_adaptive_huffman_data_model* rep_len_table = &((lzham_lzham_decompressor*)@this)->m_rep_len_table;
						lzham_quasi_adaptive_huffman_data_model* ptr = (lzham_quasi_adaptive_huffman_data_model*)rep_len_table;
						lzham_quasi_adaptive_huffman_data_model* ptr2 = ptr + 2L;
						lzham_quasi_adaptive_huffman_data_model* intPtr = ptr;
						while (true)
						{
							void* ptr3 = intPtr;
							quasi_adaptive_huffman_data_model_Constructor.Invoke(ptr3);
							if (ExceptionInfo.Current == null)
							{
								lzham_quasi_adaptive_huffman_data_model* ptr4 = (lzham_quasi_adaptive_huffman_data_model*)ptr3 + 1;
								if (ptr4 != ptr2)
								{
									intPtr = ptr4;
									continue;
								}
								InlineArray2_lzham_quasi_adaptive_huffman_data_model* large_len_table = &((lzham_lzham_decompressor*)@this)->m_large_len_table;
								lzham_quasi_adaptive_huffman_data_model* ptr5 = (lzham_quasi_adaptive_huffman_data_model*)large_len_table;
								lzham_quasi_adaptive_huffman_data_model* ptr6 = ptr5 + 2L;
								lzham_quasi_adaptive_huffman_data_model* intPtr2 = ptr5;
								while (true)
								{
									void* ptr7 = intPtr2;
									quasi_adaptive_huffman_data_model_Constructor.Invoke(ptr7);
									if (ExceptionInfo.Current == null)
									{
										lzham_quasi_adaptive_huffman_data_model* ptr8 = (lzham_quasi_adaptive_huffman_data_model*)ptr7 + 1;
										if (ptr8 != ptr6)
										{
											intPtr2 = ptr8;
											continue;
										}
										lzham_quasi_adaptive_huffman_data_model* dist_lsb_table = &((lzham_lzham_decompressor*)@this)->m_dist_lsb_table;
										quasi_adaptive_huffman_data_model_Constructor.Invoke(dist_lsb_table);
										if (ExceptionInfo.Current == null)
										{
											lzham_adaptive_bit_model* is_match_model = (lzham_adaptive_bit_model*)(&((lzham_lzham_decompressor*)@this)->m_is_match_model);
											lzham_adaptive_bit_model* ptr9 = is_match_model + 12L;
											lzham_adaptive_bit_model* intPtr3 = is_match_model;
											while (true)
											{
												void* ptr10 = intPtr3;
												adaptive_bit_model_Constructor_8cwvp7.Invoke(ptr10);
												if (ExceptionInfo.Current != null)
												{
													break;
												}
												lzham_adaptive_bit_model* ptr11 = (lzham_adaptive_bit_model*)ptr10 + 1;
												if (ptr11 != ptr9)
												{
													intPtr3 = ptr11;
													continue;
												}
												lzham_adaptive_bit_model* is_rep_model = (lzham_adaptive_bit_model*)(&((lzham_lzham_decompressor*)@this)->m_is_rep_model);
												lzham_adaptive_bit_model* ptr12 = is_rep_model + 12L;
												lzham_adaptive_bit_model* intPtr4 = is_rep_model;
												while (true)
												{
													void* ptr13 = intPtr4;
													adaptive_bit_model_Constructor_8cwvp7.Invoke(ptr13);
													if (ExceptionInfo.Current != null)
													{
														break;
													}
													lzham_adaptive_bit_model* ptr14 = (lzham_adaptive_bit_model*)ptr13 + 1;
													if (ptr14 != ptr12)
													{
														intPtr4 = ptr14;
														continue;
													}
													lzham_adaptive_bit_model* is_rep0_model = (lzham_adaptive_bit_model*)(&((lzham_lzham_decompressor*)@this)->m_is_rep0_model);
													lzham_adaptive_bit_model* ptr15 = is_rep0_model + 12L;
													lzham_adaptive_bit_model* intPtr5 = is_rep0_model;
													while (true)
													{
														void* ptr16 = intPtr5;
														adaptive_bit_model_Constructor_8cwvp7.Invoke(ptr16);
														if (ExceptionInfo.Current != null)
														{
															break;
														}
														lzham_adaptive_bit_model* ptr17 = (lzham_adaptive_bit_model*)ptr16 + 1;
														if (ptr17 != ptr15)
														{
															intPtr5 = ptr17;
															continue;
														}
														lzham_adaptive_bit_model* is_rep0_single_byte_model = (lzham_adaptive_bit_model*)(&((lzham_lzham_decompressor*)@this)->m_is_rep0_single_byte_model);
														lzham_adaptive_bit_model* ptr18 = is_rep0_single_byte_model + 12L;
														lzham_adaptive_bit_model* intPtr6 = is_rep0_single_byte_model;
														while (true)
														{
															void* ptr19 = intPtr6;
															adaptive_bit_model_Constructor_8cwvp7.Invoke(ptr19);
															if (ExceptionInfo.Current != null)
															{
																break;
															}
															lzham_adaptive_bit_model* ptr20 = (lzham_adaptive_bit_model*)ptr19 + 1;
															if (ptr20 != ptr18)
															{
																intPtr6 = ptr20;
																continue;
															}
															lzham_adaptive_bit_model* is_rep1_model = (lzham_adaptive_bit_model*)(&((lzham_lzham_decompressor*)@this)->m_is_rep1_model);
															lzham_adaptive_bit_model* ptr21 = is_rep1_model + 12L;
															lzham_adaptive_bit_model* intPtr7 = is_rep1_model;
															while (true)
															{
																void* ptr22 = intPtr7;
																adaptive_bit_model_Constructor_8cwvp7.Invoke(ptr22);
																if (ExceptionInfo.Current != null)
																{
																	break;
																}
																lzham_adaptive_bit_model* ptr23 = (lzham_adaptive_bit_model*)ptr22 + 1;
																if (ptr23 != ptr21)
																{
																	intPtr7 = ptr23;
																	continue;
																}
																lzham_adaptive_bit_model* is_rep2_model = (lzham_adaptive_bit_model*)(&((lzham_lzham_decompressor*)@this)->m_is_rep2_model);
																lzham_adaptive_bit_model* ptr24 = is_rep2_model + 12L;
																lzham_adaptive_bit_model* intPtr8 = is_rep2_model;
																while (true)
																{
																	void* ptr25 = intPtr8;
																	adaptive_bit_model_Constructor_8cwvp7.Invoke(ptr25);
																	if (ExceptionInfo.Current != null)
																	{
																		break;
																	}
																	lzham_adaptive_bit_model* ptr26 = (lzham_adaptive_bit_model*)ptr25 + 1;
																	if (ptr26 != ptr24)
																	{
																		intPtr8 = ptr26;
																		continue;
																	}
																	return @this;
																}
																break;
															}
															break;
														}
														break;
													}
													break;
												}
												break;
											}
											ExceptionInfo current = ExceptionInfo.Current;
											ExceptionInfo.Current = null;
											quasi_adaptive_huffman_data_model_Destructor.Invoke(dist_lsb_table);
											if (ExceptionInfo.Current != null)
											{
												return null;
											}
											ExceptionInfo.Current = current;
										}
										ExceptionInfo current2 = ExceptionInfo.Current;
										ExceptionInfo.Current = null;
										lzham_quasi_adaptive_huffman_data_model* ptr27 = (lzham_quasi_adaptive_huffman_data_model*)large_len_table;
										nint num = (nint)(ptr27 + 2L);
										while (true)
										{
											lzham_quasi_adaptive_huffman_data_model* ptr28 = (lzham_quasi_adaptive_huffman_data_model*)(num + (nint)(-1) * sizeof(lzham_quasi_adaptive_huffman_data_model));
											quasi_adaptive_huffman_data_model_Destructor.Invoke(ptr28);
											if (ExceptionInfo.Current != null)
											{
												return null;
											}
											if (ptr28 == ptr27)
											{
												break;
											}
											num = (nint)ptr28;
										}
										ExceptionInfo.Current = current2;
										break;
									}
									ExceptionInfo current3 = ExceptionInfo.Current;
									ExceptionInfo.Current = null;
									if (ptr5 != ptr7)
									{
										nint num2 = (nint)ptr7;
										while (true)
										{
											lzham_quasi_adaptive_huffman_data_model* ptr29 = (lzham_quasi_adaptive_huffman_data_model*)(num2 + (nint)(-1) * sizeof(lzham_quasi_adaptive_huffman_data_model));
											quasi_adaptive_huffman_data_model_Destructor.Invoke(ptr29);
											if (ExceptionInfo.Current != null)
											{
												return null;
											}
											if (ptr29 == ptr5)
											{
												break;
											}
											num2 = (nint)ptr29;
										}
									}
									ExceptionInfo.Current = current3;
									break;
								}
								ExceptionInfo current4 = ExceptionInfo.Current;
								ExceptionInfo.Current = null;
								lzham_quasi_adaptive_huffman_data_model* ptr30 = (lzham_quasi_adaptive_huffman_data_model*)rep_len_table;
								nint num3 = (nint)(ptr30 + 2L);
								while (true)
								{
									lzham_quasi_adaptive_huffman_data_model* ptr31 = (lzham_quasi_adaptive_huffman_data_model*)(num3 + (nint)(-1) * sizeof(lzham_quasi_adaptive_huffman_data_model));
									quasi_adaptive_huffman_data_model_Destructor.Invoke(ptr31);
									if (ExceptionInfo.Current != null)
									{
										return null;
									}
									if (ptr31 == ptr30)
									{
										break;
									}
									num3 = (nint)ptr31;
								}
								ExceptionInfo.Current = current4;
								break;
							}
							ExceptionInfo current5 = ExceptionInfo.Current;
							ExceptionInfo.Current = null;
							if (ptr != ptr3)
							{
								nint num4 = (nint)ptr3;
								while (true)
								{
									lzham_quasi_adaptive_huffman_data_model* ptr32 = (lzham_quasi_adaptive_huffman_data_model*)(num4 + (nint)(-1) * sizeof(lzham_quasi_adaptive_huffman_data_model));
									quasi_adaptive_huffman_data_model_Destructor.Invoke(ptr32);
									if (ExceptionInfo.Current != null)
									{
										return null;
									}
									if (ptr32 == ptr)
									{
										break;
									}
									num4 = (nint)ptr32;
								}
							}
							ExceptionInfo.Current = current5;
							break;
						}
						ExceptionInfo current6 = ExceptionInfo.Current;
						ExceptionInfo.Current = null;
						quasi_adaptive_huffman_data_model_Destructor.Invoke(main_table);
						if (ExceptionInfo.Current != null)
						{
							return null;
						}
						ExceptionInfo.Current = current6;
					}
					ExceptionInfo current7 = ExceptionInfo.Current;
					ExceptionInfo.Current = null;
					quasi_adaptive_huffman_data_model_Destructor.Invoke(delta_lit_table);
					if (ExceptionInfo.Current != null)
					{
						return null;
					}
					ExceptionInfo.Current = current7;
				}
				ExceptionInfo current8 = ExceptionInfo.Current;
				ExceptionInfo.Current = null;
				quasi_adaptive_huffman_data_model_Destructor.Invoke(lit_table);
				if (ExceptionInfo.Current != null)
				{
					return null;
				}
				ExceptionInfo.Current = current8;
			}
			ExceptionInfo current9 = ExceptionInfo.Current;
			ExceptionInfo.Current = null;
			symbol_codec_Destructor.Invoke(codec);
			if (ExceptionInfo.Current != null)
			{
				return null;
			}
			ExceptionInfo.Current = current9;
			return null;
		}
	}
}
