using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.InlineArrays;
using AssetRipper.Conversions.Lzham.Intrinsics.Implemented;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?generate_decoder_tables@prefix_coding@lzham@@YA_NIPEBEPEAVdecoder_tables@12@I@Z")]
[DemangledName("bool __cdecl lzham::prefix_coding::generate_decoder_tables(unsigned int, unsigned char const *, class lzham::prefix_coding::decoder_tables *, unsigned int)")]
internal static partial class generate_decoder_tables
{
	private partial struct LocalVariables
	{
		public InlineArray16_Int32 field_0;

		public InlineArray17_Int32 field_1;

		public InlineArray17_Int32 field_2;
	}

	[return: NativeType("bool")]
	public unsafe static bool Invoke([NativeType("unsigned int")] int num_syms, [NativeType("unsigned char const *")] void* pCodesizes, [NativeType("class lzham::prefix_coding::decoder_tables *")] void* pTables, [NativeType("unsigned int")] int table_bits)
	{
		StackFrame startFrame = StackFrameList.Current.New<LocalVariables>();
		LocalVariables* localsPointer = startFrame.GetLocalsPointer<LocalVariables>();
		localsPointer->field_0 = default(InlineArray16_Int32);
		localsPointer->field_1 = default(InlineArray17_Int32);
		localsPointer->field_2 = default(InlineArray17_Int32);
		int num = table_bits;
		bool flag;
		unchecked
		{
			if (num_syms == 0 || (uint)num > 11u)
			{
				flag = false;
			}
			else
			{
				((lzham_prefix_coding_decoder_tables*)pTables)->m_num_syms = num_syms;
				zero_object_nua2vr.Invoke(&localsPointer->field_1);
				for (int i = 0; (uint)i < (uint)num_syms; i++)
				{
					int num2 = (byte)((sbyte*)pCodesizes)[(uint)i];
					((int*)(&localsPointer->field_1))[(uint)num2]++;
				}
				int num3 = 0;
				int num4 = 0;
				int num5 = 0;
				int num6 = -1;
				for (int j = 1; (uint)j <= 16u; j++)
				{
					int num7 = ((int*)(&localsPointer->field_1))[(uint)j];
					if (num7 == 0)
					{
						((int*)(&((lzham_prefix_coding_decoder_tables*)pTables)->m_max_codes))[(uint)(j - 1)] = 0;
					}
					else
					{
						num6 = minimum_c94n3m.Invoke(num6, j);
						num5 = maximum_95ffuu.Invoke(num5, j);
						((int*)(&localsPointer->field_0))[(uint)(j - 1)] = num3;
						((int*)(&((lzham_prefix_coding_decoder_tables*)pTables)->m_max_codes))[(uint)(j - 1)] = num3 + num7 - 1;
						int num8 = (((int*)(&((lzham_prefix_coding_decoder_tables*)pTables)->m_max_codes))[(uint)(j - 1)] << 16 - j) | checked((1 << unchecked(16 - j)) - 1);
						((int*)(&((lzham_prefix_coding_decoder_tables*)pTables)->m_max_codes))[(uint)(j - 1)] = 1 + num8;
						((int*)(&((lzham_prefix_coding_decoder_tables*)pTables)->m_val_ptrs))[(uint)(j - 1)] = num4;
						((int*)(&localsPointer->field_2))[(uint)j] = num4;
						num3 += num7;
						num4 += num7;
					}
					num3 <<= 1;
				}
				((lzham_prefix_coding_decoder_tables*)pTables)->m_total_used_syms = num4;
				if ((uint)num4 > (uint)((lzham_prefix_coding_decoder_tables*)pTables)->m_cur_sorted_symbol_order_size)
				{
					((lzham_prefix_coding_decoder_tables*)pTables)->m_cur_sorted_symbol_order_size = num4;
					if (!is_power_of_2_igmcwk.Invoke(num4))
					{
						((lzham_prefix_coding_decoder_tables*)pTables)->m_cur_sorted_symbol_order_size = minimum_c94n3m.Invoke(num_syms, next_pow2_sz9rvk.Invoke(num4));
					}
					if (((lzham_prefix_coding_decoder_tables*)pTables)->m_sorted_symbol_order != null)
					{
						lzham_delete_array_i9xite.Invoke(((lzham_prefix_coding_decoder_tables*)pTables)->m_sorted_symbol_order);
						if (ExceptionInfo.Current != null)
						{
							return false;
						}
						((lzham_prefix_coding_decoder_tables*)pTables)->m_sorted_symbol_order = null;
					}
					void* sorted_symbol_order = lzham_new_array_sb2tu4.Invoke(((lzham_prefix_coding_decoder_tables*)pTables)->m_cur_sorted_symbol_order_size);
					if (ExceptionInfo.Current != null)
					{
						return false;
					}
					((lzham_prefix_coding_decoder_tables*)pTables)->m_sorted_symbol_order = sorted_symbol_order;
					if (((lzham_prefix_coding_decoder_tables*)pTables)->m_sorted_symbol_order == null)
					{
						flag = false;
						goto IL_0715;
					}
				}
				((lzham_prefix_coding_decoder_tables*)pTables)->m_min_code_size = (sbyte)num6;
				((lzham_prefix_coding_decoder_tables*)pTables)->m_max_code_size = (sbyte)num5;
				for (int k = 0; (uint)k < (uint)num_syms; k++)
				{
					int num9 = (byte)((sbyte*)pCodesizes)[(uint)k];
					if (num9 != 0)
					{
						int num10 = ((int*)(&localsPointer->field_2))[(uint)num9]++;
						((short*)((lzham_prefix_coding_decoder_tables*)pTables)->m_sorted_symbol_order)[(uint)num10] = (short)k;
					}
				}
				if ((uint)num <= (uint)(byte)((lzham_prefix_coding_decoder_tables*)pTables)->m_min_code_size)
				{
					num = 0;
				}
				((lzham_prefix_coding_decoder_tables*)pTables)->m_table_bits = num;
				if (num != 0)
				{
					int num11 = 1 << num;
					if ((uint)num11 > (uint)((lzham_prefix_coding_decoder_tables*)pTables)->m_cur_lookup_size)
					{
						((lzham_prefix_coding_decoder_tables*)pTables)->m_cur_lookup_size = num11;
						if (((lzham_prefix_coding_decoder_tables*)pTables)->m_lookup != null)
						{
							lzham_delete_array_g5z2nn.Invoke(((lzham_prefix_coding_decoder_tables*)pTables)->m_lookup);
							if (ExceptionInfo.Current != null)
							{
								return false;
							}
							((lzham_prefix_coding_decoder_tables*)pTables)->m_lookup = null;
						}
						void* lookup = lzham_new_array_qrkyp9.Invoke(num11);
						if (ExceptionInfo.Current != null)
						{
							return false;
						}
						((lzham_prefix_coding_decoder_tables*)pTables)->m_lookup = lookup;
						if (((lzham_prefix_coding_decoder_tables*)pTables)->m_lookup == null)
						{
							flag = false;
							goto IL_0715;
						}
					}
					llvm_memset_p0_i64.Invoke(((lzham_prefix_coding_decoder_tables*)pTables)->m_lookup, -1, (uint)(4 * (1 << num)), isVolatile: false);
					for (int l = 1; (uint)l <= (uint)num; l++)
					{
						if (((int*)(&localsPointer->field_1))[(uint)l] == 0)
						{
							continue;
						}
						int num12 = num - l;
						int num13 = 1 << num12;
						int num14 = ((int*)(&localsPointer->field_0))[(uint)(l - 1)];
						int num15 = Get_unshifted_max_code.Invoke(pTables, l);
						int num16 = ((int*)(&((lzham_prefix_coding_decoder_tables*)pTables)->m_val_ptrs))[(uint)(l - 1)];
						for (int m = num14; (uint)m <= (uint)num15; m++)
						{
							int num17 = (ushort)((short*)((lzham_prefix_coding_decoder_tables*)pTables)->m_sorted_symbol_order)[(uint)(num16 + m - num14)];
							for (int n = 0; (uint)n < (uint)num13; n++)
							{
								((int*)((lzham_prefix_coding_decoder_tables*)pTables)->m_lookup)[(uint)(n + (m << num12))] = num17 | (l << 16);
							}
						}
					}
				}
				for (int num18 = 0; (uint)num18 < 16u; num18++)
				{
					int num19 = ((int*)(&localsPointer->field_0))[(uint)num18];
					((int*)(&((lzham_prefix_coding_decoder_tables*)pTables)->m_val_ptrs))[(uint)num18] -= num19;
				}
				((lzham_prefix_coding_decoder_tables*)pTables)->m_table_max_code = 0;
				((lzham_prefix_coding_decoder_tables*)pTables)->m_decode_start_code_size = (byte)((lzham_prefix_coding_decoder_tables*)pTables)->m_min_code_size;
				if (num != 0)
				{
					int num20;
					for (num20 = num; (uint)num20 >= 1u; num20 += -1)
					{
						if (((int*)(&localsPointer->field_1))[(uint)num20] != 0)
						{
							((lzham_prefix_coding_decoder_tables*)pTables)->m_table_max_code = ((int*)(&((lzham_prefix_coding_decoder_tables*)pTables)->m_max_codes))[(uint)(num20 - 1)];
							break;
						}
					}
					if ((uint)num20 >= 1u)
					{
						((lzham_prefix_coding_decoder_tables*)pTables)->m_decode_start_code_size = num + 1;
						for (num20 = num + 1; (uint)num20 <= (uint)num5; num20++)
						{
							if (((int*)(&localsPointer->field_1))[(uint)num20] != 0)
							{
								((lzham_prefix_coding_decoder_tables*)pTables)->m_decode_start_code_size = num20;
								break;
							}
						}
					}
				}
				((int*)(&((lzham_prefix_coding_decoder_tables*)pTables)->m_max_codes))[16] = -1;
				((int*)(&((lzham_prefix_coding_decoder_tables*)pTables)->m_val_ptrs))[16] = 1048575;
				((lzham_prefix_coding_decoder_tables*)pTables)->m_table_shift = 32 - ((lzham_prefix_coding_decoder_tables*)pTables)->m_table_bits;
				flag = true;
			}
			goto IL_0715;
		}
		IL_0715:
		bool result = flag;
		StackFrameList.Current.Clear(startFrame);
		return result;
	}
}
