using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.InlineArrays;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("??0state@lzcompressor@lzham@@QEAA@XZ")]
[DemangledName("public: __cdecl lzham::lzcompressor::state::state(void)")]
internal static partial class state_Constructor
{
	public unsafe static void* Invoke(void* @this)
	{
		unchecked
		{
			lzham_adaptive_bit_model* field_ = (lzham_adaptive_bit_model*)(&((lzham_lzcompressor_state*)@this)->field_2);
			lzham_adaptive_bit_model* ptr = field_ + 12L;
			lzham_adaptive_bit_model* intPtr = field_;
			while (true)
			{
				void* ptr2 = intPtr;
				adaptive_bit_model_Constructor_8cwvp7.Invoke(ptr2);
				lzham_adaptive_bit_model* ptr3 = (lzham_adaptive_bit_model*)ptr2 + 1;
				if (ptr3 == ptr)
				{
					break;
				}
				intPtr = ptr3;
			}
			lzham_adaptive_bit_model* field_2 = (lzham_adaptive_bit_model*)(&((lzham_lzcompressor_state*)@this)->field_3);
			lzham_adaptive_bit_model* ptr4 = field_2 + 12L;
			lzham_adaptive_bit_model* intPtr2 = field_2;
			while (true)
			{
				void* ptr5 = intPtr2;
				adaptive_bit_model_Constructor_8cwvp7.Invoke(ptr5);
				lzham_adaptive_bit_model* ptr6 = (lzham_adaptive_bit_model*)ptr5 + 1;
				if (ptr6 == ptr4)
				{
					break;
				}
				intPtr2 = ptr6;
			}
			lzham_adaptive_bit_model* field_3 = (lzham_adaptive_bit_model*)(&((lzham_lzcompressor_state*)@this)->field_4);
			lzham_adaptive_bit_model* ptr7 = field_3 + 12L;
			lzham_adaptive_bit_model* intPtr3 = field_3;
			while (true)
			{
				void* ptr8 = intPtr3;
				adaptive_bit_model_Constructor_8cwvp7.Invoke(ptr8);
				lzham_adaptive_bit_model* ptr9 = (lzham_adaptive_bit_model*)ptr8 + 1;
				if (ptr9 == ptr7)
				{
					break;
				}
				intPtr3 = ptr9;
			}
			lzham_adaptive_bit_model* field_4 = (lzham_adaptive_bit_model*)(&((lzham_lzcompressor_state*)@this)->field_5);
			lzham_adaptive_bit_model* ptr10 = field_4 + 12L;
			lzham_adaptive_bit_model* intPtr4 = field_4;
			while (true)
			{
				void* ptr11 = intPtr4;
				adaptive_bit_model_Constructor_8cwvp7.Invoke(ptr11);
				lzham_adaptive_bit_model* ptr12 = (lzham_adaptive_bit_model*)ptr11 + 1;
				if (ptr12 == ptr10)
				{
					break;
				}
				intPtr4 = ptr12;
			}
			lzham_adaptive_bit_model* field_5 = (lzham_adaptive_bit_model*)(&((lzham_lzcompressor_state*)@this)->field_6);
			lzham_adaptive_bit_model* ptr13 = field_5 + 12L;
			lzham_adaptive_bit_model* intPtr5 = field_5;
			while (true)
			{
				void* ptr14 = intPtr5;
				adaptive_bit_model_Constructor_8cwvp7.Invoke(ptr14);
				lzham_adaptive_bit_model* ptr15 = (lzham_adaptive_bit_model*)ptr14 + 1;
				if (ptr15 == ptr13)
				{
					break;
				}
				intPtr5 = ptr15;
			}
			lzham_adaptive_bit_model* field_6 = (lzham_adaptive_bit_model*)(&((lzham_lzcompressor_state*)@this)->field_7);
			lzham_adaptive_bit_model* ptr16 = field_6 + 12L;
			lzham_adaptive_bit_model* intPtr6 = field_6;
			while (true)
			{
				void* ptr17 = intPtr6;
				adaptive_bit_model_Constructor_8cwvp7.Invoke(ptr17);
				lzham_adaptive_bit_model* ptr18 = (lzham_adaptive_bit_model*)ptr17 + 1;
				if (ptr18 == ptr16)
				{
					break;
				}
				intPtr6 = ptr18;
			}
			lzham_quasi_adaptive_huffman_data_model* field_7 = &((lzham_lzcompressor_state*)@this)->field_8;
			quasi_adaptive_huffman_data_model_Constructor.Invoke(field_7);
			if (ExceptionInfo.Current != null)
			{
				return null;
			}
			lzham_quasi_adaptive_huffman_data_model* field_8 = &((lzham_lzcompressor_state*)@this)->field_9;
			quasi_adaptive_huffman_data_model_Constructor.Invoke(field_8);
			if (ExceptionInfo.Current == null)
			{
				lzham_quasi_adaptive_huffman_data_model* field_9 = &((lzham_lzcompressor_state*)@this)->field_10;
				quasi_adaptive_huffman_data_model_Constructor.Invoke(field_9);
				if (ExceptionInfo.Current == null)
				{
					InlineArray2_lzham_quasi_adaptive_huffman_data_model* field_10 = &((lzham_lzcompressor_state*)@this)->field_11;
					lzham_quasi_adaptive_huffman_data_model* ptr19 = (lzham_quasi_adaptive_huffman_data_model*)field_10;
					lzham_quasi_adaptive_huffman_data_model* ptr20 = ptr19 + 2L;
					lzham_quasi_adaptive_huffman_data_model* intPtr7 = ptr19;
					while (true)
					{
						void* ptr21 = intPtr7;
						quasi_adaptive_huffman_data_model_Constructor.Invoke(ptr21);
						if (ExceptionInfo.Current == null)
						{
							lzham_quasi_adaptive_huffman_data_model* ptr22 = (lzham_quasi_adaptive_huffman_data_model*)ptr21 + 1;
							if (ptr22 != ptr20)
							{
								intPtr7 = ptr22;
								continue;
							}
							InlineArray2_lzham_quasi_adaptive_huffman_data_model* field_11 = &((lzham_lzcompressor_state*)@this)->field_12;
							lzham_quasi_adaptive_huffman_data_model* ptr23 = (lzham_quasi_adaptive_huffman_data_model*)field_11;
							lzham_quasi_adaptive_huffman_data_model* ptr24 = ptr23 + 2L;
							lzham_quasi_adaptive_huffman_data_model* intPtr8 = ptr23;
							while (true)
							{
								void* ptr25 = intPtr8;
								quasi_adaptive_huffman_data_model_Constructor.Invoke(ptr25);
								if (ExceptionInfo.Current == null)
								{
									lzham_quasi_adaptive_huffman_data_model* ptr26 = (lzham_quasi_adaptive_huffman_data_model*)ptr25 + 1;
									if (ptr26 != ptr24)
									{
										intPtr8 = ptr26;
										continue;
									}
									quasi_adaptive_huffman_data_model_Constructor.Invoke(&((lzham_lzcompressor_state*)@this)->field_13);
									if (ExceptionInfo.Current == null)
									{
										((lzham_lzcompressor_state_base*)@this)->m_cur_ofs = 0;
										((lzham_lzcompressor_state_base*)@this)->m_cur_state = 0;
										((lzham_lzcompressor_state*)@this)->field_1 = 0;
										*(int*)(&((lzham_lzcompressor_state_base*)@this)->m_match_hist) = 1;
										((int*)(&((lzham_lzcompressor_state_base*)@this)->m_match_hist))[1] = 1;
										((int*)(&((lzham_lzcompressor_state_base*)@this)->m_match_hist))[2] = 1;
										((int*)(&((lzham_lzcompressor_state_base*)@this)->m_match_hist))[3] = 1;
										return @this;
									}
									ExceptionInfo current = ExceptionInfo.Current;
									ExceptionInfo.Current = null;
									lzham_quasi_adaptive_huffman_data_model* ptr27 = (lzham_quasi_adaptive_huffman_data_model*)field_11;
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
									ExceptionInfo.Current = current;
									break;
								}
								ExceptionInfo current2 = ExceptionInfo.Current;
								ExceptionInfo.Current = null;
								if (ptr23 != ptr25)
								{
									nint num2 = (nint)ptr25;
									while (true)
									{
										lzham_quasi_adaptive_huffman_data_model* ptr29 = (lzham_quasi_adaptive_huffman_data_model*)(num2 + (nint)(-1) * sizeof(lzham_quasi_adaptive_huffman_data_model));
										quasi_adaptive_huffman_data_model_Destructor.Invoke(ptr29);
										if (ExceptionInfo.Current != null)
										{
											return null;
										}
										if (ptr29 == ptr23)
										{
											break;
										}
										num2 = (nint)ptr29;
									}
								}
								ExceptionInfo.Current = current2;
								break;
							}
							ExceptionInfo current3 = ExceptionInfo.Current;
							ExceptionInfo.Current = null;
							lzham_quasi_adaptive_huffman_data_model* ptr30 = (lzham_quasi_adaptive_huffman_data_model*)field_10;
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
							ExceptionInfo.Current = current3;
							break;
						}
						ExceptionInfo current4 = ExceptionInfo.Current;
						ExceptionInfo.Current = null;
						if (ptr19 != ptr21)
						{
							nint num4 = (nint)ptr21;
							while (true)
							{
								lzham_quasi_adaptive_huffman_data_model* ptr32 = (lzham_quasi_adaptive_huffman_data_model*)(num4 + (nint)(-1) * sizeof(lzham_quasi_adaptive_huffman_data_model));
								quasi_adaptive_huffman_data_model_Destructor.Invoke(ptr32);
								if (ExceptionInfo.Current != null)
								{
									return null;
								}
								if (ptr32 == ptr19)
								{
									break;
								}
								num4 = (nint)ptr32;
							}
						}
						ExceptionInfo.Current = current4;
						break;
					}
					ExceptionInfo current5 = ExceptionInfo.Current;
					ExceptionInfo.Current = null;
					quasi_adaptive_huffman_data_model_Destructor.Invoke(field_9);
					if (ExceptionInfo.Current != null)
					{
						return null;
					}
					ExceptionInfo.Current = current5;
				}
				ExceptionInfo current6 = ExceptionInfo.Current;
				ExceptionInfo.Current = null;
				quasi_adaptive_huffman_data_model_Destructor.Invoke(field_8);
				if (ExceptionInfo.Current != null)
				{
					return null;
				}
				ExceptionInfo.Current = current6;
			}
			ExceptionInfo current7 = ExceptionInfo.Current;
			ExceptionInfo.Current = null;
			quasi_adaptive_huffman_data_model_Destructor.Invoke(field_7);
			if (ExceptionInfo.Current != null)
			{
				return null;
			}
			ExceptionInfo.Current = current7;
			return null;
		}
	}
}
