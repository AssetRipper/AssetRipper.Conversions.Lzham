using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.InlineArrays;
using AssetRipper.Conversions.Lzham.Intrinsics.Implemented;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?update_tables@raw_quasi_adaptive_huffman_data_model@lzham@@QEAA_NH_N@Z")]
[DemangledName("public: bool __cdecl lzham::raw_quasi_adaptive_huffman_data_model::update_tables(int, bool)")]
internal static partial class update_tables
{
	private partial struct LocalVariables
	{
		public int field_0;

		public int field_1;

		public InlineArray0_SByte field_2;
	}

	[return: NativeType("bool")]
	public unsafe static bool Invoke(void* @this, [NativeType("int")] int force_update_cycle, [NativeType("bool")] bool sym_freq_all_ones)
	{
		StackFrame startFrame = StackFrameList.Current.New<LocalVariables>();
		LocalVariables* localsPointer = startFrame.GetLocalsPointer<LocalVariables>();
		localsPointer->field_0 = 0;
		localsPointer->field_1 = 0;
		sbyte b = (sym_freq_all_ones ? ((sbyte)1) : ((sbyte)0));
		bool flag;
		unchecked
		{
			int update_cycle = ((lzham_raw_quasi_adaptive_huffman_data_model*)@this)->m_update_cycle;
			((lzham_raw_quasi_adaptive_huffman_data_model*)@this)->m_total_count += update_cycle;
			while ((uint)((lzham_raw_quasi_adaptive_huffman_data_model*)@this)->m_total_count >= 32768u)
			{
				rescale.Invoke(@this);
			}
			localsPointer->field_0 = 0;
			if ((b & 1) == 1 && (uint)((lzham_raw_quasi_adaptive_huffman_data_model*)@this)->m_total_syms >= 2u)
			{
				int num = floor_log2i.Invoke(((lzham_raw_quasi_adaptive_huffman_data_model*)@this)->m_total_syms);
				int num2 = (((lzham_raw_quasi_adaptive_huffman_data_model*)@this)->m_total_syms - (1 << num)) * 2;
				if ((uint)num2 > (uint)((lzham_raw_quasi_adaptive_huffman_data_model*)@this)->m_total_syms)
				{
					num2 = ((lzham_raw_quasi_adaptive_huffman_data_model*)@this)->m_total_syms;
				}
				llvm_memset_p0_i64.Invoke(vector_unsigned_char_Operator_apxfsu.Invoke(&((lzham_raw_quasi_adaptive_huffman_data_model*)@this)->m_code_sizes, 0), (sbyte)(num + 1), (uint)num2, isVolatile: false);
				llvm_memset_p0_i64.Invoke(vector_unsigned_char_Operator_apxfsu.Invoke(&((lzham_raw_quasi_adaptive_huffman_data_model*)@this)->m_code_sizes, num2), (sbyte)num, (uint)(((lzham_raw_quasi_adaptive_huffman_data_model*)@this)->m_total_syms - num2), isVolatile: false);
				localsPointer->field_0 = num + InstructionHelper.Select(num2 != 0, 1, 0);
			}
			if (localsPointer->field_0 != 0)
			{
				goto IL_0246;
			}
			Get_generate_huffman_codes_table_size.Invoke();
			localsPointer->field_2 = default(InlineArray0_SByte);
			void* pContext = &localsPointer->field_2;
			localsPointer->field_1 = 0;
			if (((generate_huffman_codes.Invoke(pCodesizes: vector_unsigned_char_Operator_apxfsu.Invoke(&((lzham_raw_quasi_adaptive_huffman_data_model*)@this)->m_code_sizes, 0), pFreq: vector_unsigned_short_Operator.Invoke(&((lzham_raw_quasi_adaptive_huffman_data_model*)@this)->m_sym_freq, 0), pContext: pContext, num_syms: ((lzham_raw_quasi_adaptive_huffman_data_model*)@this)->m_total_syms, max_code_size: &localsPointer->field_0, total_freq_ret: &localsPointer->field_1) ? 1u : 0u) & 1u) != 1 || localsPointer->field_1 != ((lzham_raw_quasi_adaptive_huffman_data_model*)@this)->m_total_count)
			{
				flag = false;
			}
			else
			{
				if ((uint)localsPointer->field_0 <= 16u || ((limit_max_code_size.Invoke(pCodesizes: vector_unsigned_char_Operator_apxfsu.Invoke(&((lzham_raw_quasi_adaptive_huffman_data_model*)@this)->m_code_sizes, 0), num_syms: ((lzham_raw_quasi_adaptive_huffman_data_model*)@this)->m_total_syms, max_code_size: 16) ? 1u : 0u) & 1u) == 1)
				{
					goto IL_0246;
				}
				flag = false;
			}
			goto IL_03f9;
		}
		IL_0246:
		unchecked
		{
			if (force_update_cycle >= 0)
			{
				((lzham_raw_quasi_adaptive_huffman_data_model*)@this)->m_symbols_until_update = (((lzham_raw_quasi_adaptive_huffman_data_model*)@this)->m_update_cycle = force_update_cycle);
			}
			else
			{
				((lzham_raw_quasi_adaptive_huffman_data_model*)@this)->m_update_cycle = 31 + ((lzham_raw_quasi_adaptive_huffman_data_model*)@this)->m_update_cycle * ((32u >= (uint)((((lzham_raw_quasi_adaptive_huffman_data_model*)@this)->m_adapt_rate == 0) ? 64 : ((ushort)((lzham_raw_quasi_adaptive_huffman_data_model*)@this)->m_adapt_rate))) ? 32 : ((((lzham_raw_quasi_adaptive_huffman_data_model*)@this)->m_adapt_rate == 0) ? 64 : ((ushort)((lzham_raw_quasi_adaptive_huffman_data_model*)@this)->m_adapt_rate))) >>> 5;
				if ((uint)((lzham_raw_quasi_adaptive_huffman_data_model*)@this)->m_update_cycle > (uint)((lzham_raw_quasi_adaptive_huffman_data_model*)@this)->m_max_cycle)
				{
					((lzham_raw_quasi_adaptive_huffman_data_model*)@this)->m_update_cycle = ((lzham_raw_quasi_adaptive_huffman_data_model*)@this)->m_max_cycle;
				}
				((lzham_raw_quasi_adaptive_huffman_data_model*)@this)->m_symbols_until_update = ((lzham_raw_quasi_adaptive_huffman_data_model*)@this)->m_update_cycle;
			}
			sbyte b2;
			if ((((lzham_raw_quasi_adaptive_huffman_data_model*)@this)->m_encoding & 1) == 1)
			{
				b2 = (generate_codes.Invoke(pCodes: vector_unsigned_short_Operator.Invoke(&((lzham_raw_quasi_adaptive_huffman_data_model*)@this)->m_codes, 0), pCodesizes: vector_unsigned_char_Operator_apxfsu.Invoke(&((lzham_raw_quasi_adaptive_huffman_data_model*)@this)->m_code_sizes, 0), num_syms: ((lzham_raw_quasi_adaptive_huffman_data_model*)@this)->m_total_syms) ? ((sbyte)1) : ((sbyte)0));
			}
			else
			{
				int num3 = (byte)((lzham_raw_quasi_adaptive_huffman_data_model*)@this)->m_decoder_table_bits;
				int num4 = checked((1 << num3) + 64);
				if ((uint)(((lzham_raw_quasi_adaptive_huffman_data_model*)@this)->m_symbols_until_update * floor_log2i.Invoke(((lzham_raw_quasi_adaptive_huffman_data_model*)@this)->m_total_syms)) <= (uint)num4)
				{
					num3 = 0;
				}
				bool flag2 = generate_decoder_tables.Invoke(table_bits: num3, pTables: ((lzham_raw_quasi_adaptive_huffman_data_model*)@this)->m_pDecode_tables, pCodesizes: vector_unsigned_char_Operator_apxfsu.Invoke(&((lzham_raw_quasi_adaptive_huffman_data_model*)@this)->m_code_sizes, 0), num_syms: ((lzham_raw_quasi_adaptive_huffman_data_model*)@this)->m_total_syms);
				if (ExceptionInfo.Current != null)
				{
					return false;
				}
				b2 = (flag2 ? ((sbyte)1) : ((sbyte)0));
			}
			flag = (((b2 & 1) == 1) ? true : false);
			goto IL_03f9;
		}
		IL_03f9:
		bool result = flag;
		StackFrameList.Current.Clear(startFrame);
		return result;
	}
}
