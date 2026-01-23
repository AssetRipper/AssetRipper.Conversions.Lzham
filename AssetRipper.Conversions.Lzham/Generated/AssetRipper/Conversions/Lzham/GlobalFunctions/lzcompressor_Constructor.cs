using AssetRipper.Conversions.Lzham.GlobalVariables;
using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.InlineArrays;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("??0lzcompressor@lzham@@QEAA@XZ")]
[DemangledName("public: __cdecl lzham::lzcompressor::lzcompressor(void)")]
internal static partial class lzcompressor_Constructor
{
	public unsafe static void* Invoke(void* @this)
	{
		unchecked
		{
			init_params_Constructor.Invoke(&((lzham_lzcompressor*)@this)->field_1);
			_ = &((lzham_lzcompressor*)@this)->field_2;
			((lzham_lzcompressor*)@this)->field_3 = -1L;
			((lzham_lzcompressor*)@this)->field_4 = 0;
			lzham_search_accelerator* field_ = &((lzham_lzcompressor*)@this)->field_5;
			search_accelerator_Constructor.Invoke(field_);
			if (ExceptionInfo.Current != null)
			{
				return null;
			}
			lzham_symbol_codec* field_2 = &((lzham_lzcompressor*)@this)->field_6;
			symbol_codec_Constructor.Invoke(field_2);
			if (ExceptionInfo.Current == null)
			{
				coding_stats_Constructor.Invoke(&((lzham_lzcompressor*)@this)->field_7);
				if (ExceptionInfo.Current == null)
				{
					lzham_vector* field_3 = &((lzham_lzcompressor*)@this)->field_8;
					vector_unsigned_char_Constructor.Invoke(field_3);
					if (ExceptionInfo.Current == null)
					{
						lzham_vector* field_4 = &((lzham_lzcompressor*)@this)->field_9;
						vector_unsigned_char_Constructor.Invoke(field_4);
						if (ExceptionInfo.Current == null)
						{
							((lzham_lzcompressor*)@this)->field_10 = 0;
							((lzham_lzcompressor*)@this)->field_11 = 0;
							((lzham_lzcompressor*)@this)->field_12 = 0;
							((lzham_lzcompressor*)@this)->field_13 = 0;
							lzham_lzcompressor_state* field_5 = &((lzham_lzcompressor*)@this)->field_15;
							state_Constructor.Invoke(field_5);
							if (ExceptionInfo.Current == null)
							{
								lzham_lzcompressor_state* field_6 = &((lzham_lzcompressor*)@this)->field_16;
								state_Constructor.Invoke(field_6);
								if (ExceptionInfo.Current == null)
								{
									((lzham_lzcompressor*)@this)->field_17 = 0;
									InlineArray9_lzham_lzcompressor_parse_thread_state* field_7 = &((lzham_lzcompressor*)@this)->field_18;
									lzham_lzcompressor_parse_thread_state* ptr = (lzham_lzcompressor_parse_thread_state*)field_7;
									lzham_lzcompressor_parse_thread_state* ptr2 = ptr + 9L;
									lzham_lzcompressor_parse_thread_state* intPtr = ptr;
									while (true)
									{
										void* ptr3 = intPtr;
										parse_thread_state_Constructor.Invoke(ptr3);
										if (ExceptionInfo.Current == null)
										{
											lzham_lzcompressor_parse_thread_state* ptr4 = (lzham_lzcompressor_parse_thread_state*)ptr3 + 1;
											if (ptr4 != ptr2)
											{
												intPtr = ptr4;
												continue;
											}
											((lzham_lzcompressor*)@this)->field_19 = 0;
											sbyte* ptr5 = (sbyte*)@this + 6444396;
											semaphore_Constructor.Invoke(ptr5, 0, 1, null);
											if (ExceptionInfo.Current == null)
											{
												_ = &((lzham_lzcompressor*)@this)->field_21;
												((lzham_lzcompressor*)@this)->field_22 = 0;
												((lzham_lzcompressor*)@this)->field_23 = 0;
												if (((ulong)@this & 7uL) != 0L)
												{
													lzham_assert.Invoke(String_eyp45t.Pointer, String_uf3mm8.Pointer, 77);
													if (ExceptionInfo.Current != null)
													{
														ExceptionInfo? current = ExceptionInfo.Current;
														ExceptionInfo.Current = null;
														semaphore_Destructor.Invoke(ptr5);
														ExceptionInfo.Current = current;
														goto IL_0245;
													}
												}
												return @this;
											}
											goto IL_0245;
										}
										ExceptionInfo current2 = ExceptionInfo.Current;
										ExceptionInfo.Current = null;
										if (ptr != ptr3)
										{
											nint num = (nint)ptr3;
											while (true)
											{
												lzham_lzcompressor_parse_thread_state* ptr6 = (lzham_lzcompressor_parse_thread_state*)(num + (nint)(-1) * sizeof(lzham_lzcompressor_parse_thread_state));
												parse_thread_state_Destructor.Invoke(ptr6);
												if (ExceptionInfo.Current != null)
												{
													return null;
												}
												if (ptr6 == ptr)
												{
													break;
												}
												num = (nint)ptr6;
											}
										}
										ExceptionInfo.Current = current2;
										break;
										IL_0245:
										ExceptionInfo current3 = ExceptionInfo.Current;
										ExceptionInfo.Current = null;
										lzham_lzcompressor_parse_thread_state* ptr7 = (lzham_lzcompressor_parse_thread_state*)field_7;
										nint num2 = (nint)(ptr7 + 9L);
										while (true)
										{
											lzham_lzcompressor_parse_thread_state* ptr8 = (lzham_lzcompressor_parse_thread_state*)(num2 + (nint)(-1) * sizeof(lzham_lzcompressor_parse_thread_state));
											parse_thread_state_Destructor.Invoke(ptr8);
											if (ExceptionInfo.Current != null)
											{
												return null;
											}
											if (ptr8 == ptr7)
											{
												break;
											}
											num2 = (nint)ptr8;
										}
										ExceptionInfo.Current = current3;
										break;
									}
									ExceptionInfo current4 = ExceptionInfo.Current;
									ExceptionInfo.Current = null;
									state_Destructor.Invoke(field_6);
									if (ExceptionInfo.Current != null)
									{
										return null;
									}
									ExceptionInfo.Current = current4;
								}
								ExceptionInfo current5 = ExceptionInfo.Current;
								ExceptionInfo.Current = null;
								state_Destructor.Invoke(field_5);
								if (ExceptionInfo.Current != null)
								{
									return null;
								}
								ExceptionInfo.Current = current5;
							}
							ExceptionInfo current6 = ExceptionInfo.Current;
							ExceptionInfo.Current = null;
							vector_unsigned_char_Destructor.Invoke(field_4);
							if (ExceptionInfo.Current != null)
							{
								return null;
							}
							ExceptionInfo.Current = current6;
						}
						ExceptionInfo current7 = ExceptionInfo.Current;
						ExceptionInfo.Current = null;
						vector_unsigned_char_Destructor.Invoke(field_3);
						if (ExceptionInfo.Current != null)
						{
							return null;
						}
						ExceptionInfo.Current = current7;
					}
				}
				ExceptionInfo current8 = ExceptionInfo.Current;
				ExceptionInfo.Current = null;
				symbol_codec_Destructor.Invoke(field_2);
				if (ExceptionInfo.Current != null)
				{
					return null;
				}
				ExceptionInfo.Current = current8;
			}
			ExceptionInfo current9 = ExceptionInfo.Current;
			ExceptionInfo.Current = null;
			search_accelerator_Destructor.Invoke(field_);
			if (ExceptionInfo.Current != null)
			{
				return null;
			}
			ExceptionInfo.Current = current9;
			return null;
		}
	}
}
