using System.Runtime.CompilerServices;
using AssetRipper.Conversions.Lzham.GlobalVariables;
using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.InlineArrays;
using AssetRipper.Conversions.Lzham.Intrinsics.Implemented;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?find_all_matches_callback@search_accelerator@lzham@@QEAAX_KPEAX@Z")]
[DemangledName("public: void __cdecl lzham::search_accelerator::find_all_matches_callback(unsigned __int64, void *)")]
internal static partial class find_all_matches_callback
{
	public unsafe static readonly void* __pointer = PointerIndices.Register((delegate*<void*, long, void*, void>)(&Invoke));

	[return: NativeType("void")]
	public unsafe static void Invoke(void* @this, [NativeType("unsigned __int64")] long data, [NativeType("void *")] void* pData_ptr)
	{
		lzham_scoped_perf_section lzham_scoped_perf_section2 = default(lzham_scoped_perf_section);
		InlineArray256_lzham_dict_match inlineArray256_lzham_dict_match = default(InlineArray256_lzham_dict_match);
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		int num4 = 0;
		scoped_perf_section_Constructor.Invoke(&lzham_scoped_perf_section2, String_d9apgb.Pointer);
		unchecked
		{
			int num5 = (int)data;
			int num6 = ((lzham_search_accelerator*)@this)->m_fill_lookahead_pos;
			int num7 = ((lzham_search_accelerator*)@this)->m_fill_dict_size;
			int num8 = ((lzham_search_accelerator*)@this)->m_fill_lookahead_size;
			int c = 0;
			int num9 = 0;
			if ((uint)num8 >= 2u)
			{
				c = (byte)(*(sbyte*)vector_unsigned_char_Operator_apxfsu.Invoke(&((lzham_search_accelerator*)@this)->m_dict, num6 & ((lzham_search_accelerator*)@this)->m_max_dict_size_mask));
				num9 = (byte)(*(sbyte*)vector_unsigned_char_Operator_apxfsu.Invoke(&((lzham_search_accelerator*)@this)->m_dict, (num6 & ((lzham_search_accelerator*)@this)->m_max_dict_size_mask) + 1));
			}
			void* ptr = Get_ptr_cpjzjc.Invoke(&((lzham_search_accelerator*)@this)->m_dict);
			while ((uint)num8 >= 3u)
			{
				int num10 = num6 & ((lzham_search_accelerator*)@this)->m_max_dict_size_mask;
				int num11 = (byte)((sbyte*)ptr)[(uint)(num10 + 2)];
				int i = hash3_to_16.Invoke(c, num9, num11);
				c = num9;
				num9 = num11;
				if (size_s5xcpk.Invoke(&((lzham_search_accelerator*)@this)->m_hash_thread_index) != 0 && (byte)(*(sbyte*)vector_unsigned_char_Operator_apxfsu.Invoke(&((lzham_search_accelerator*)@this)->m_hash_thread_index, i)) != num5)
				{
					num6++;
					num8 += -1;
					num7++;
					continue;
				}
				void* ptr2 = &inlineArray256_lzham_dict_match;
				int num12 = *(int*)vector_unsigned_int_Operator.Invoke(&((lzham_search_accelerator*)@this)->m_hash, i);
				*(int*)vector_unsigned_int_Operator.Invoke(&((lzham_search_accelerator*)@this)->m_hash, i) = num6;
				void* ptr3 = &((lzham_node*)vector_struct_lzham_node_Operator.Invoke(&((lzham_search_accelerator*)@this)->m_nodes, num10))->m_left;
				void* ptr4 = &((lzham_node*)vector_struct_lzham_node_Operator.Invoke(&((lzham_search_accelerator*)@this)->m_nodes, num10))->m_right;
				int num13 = ((257u >= (uint)num8) ? num8 : 257);
				int num14 = 2;
				void* ptr5 = (byte*)ptr + (uint)num10;
				int num15 = ((lzham_search_accelerator*)@this)->m_max_probes;
				while (true)
				{
					int num16 = num6 - num12;
					int num17 = num15;
					num15 = num17 + -1;
					if (num17 == 0 || num16 == 0 || (uint)num16 >= (uint)num7)
					{
						*(int*)ptr3 = 0;
						*(int*)ptr4 = 0;
						break;
					}
					int num18 = num12 & ((lzham_search_accelerator*)@this)->m_max_dict_size_mask;
					void* ptr6 = vector_struct_lzham_node_Operator.Invoke(&((lzham_search_accelerator*)@this)->m_nodes, num18);
					int j = 0;
					void* ptr7;
					for (ptr7 = (byte*)ptr + (uint)num18; (uint)j < (uint)num13 && (byte)((sbyte*)ptr7)[(uint)j] == (byte)((sbyte*)ptr5)[(uint)j]; j++)
					{
					}
					if ((uint)j > (uint)num14)
					{
						((lzham_dict_match*)ptr2)->m_len = (short)(j - 2);
						((lzham_dict_match*)ptr2)->m_dist = num16;
						ptr2 = (byte*)ptr2 + sizeof(lzham_dict_match);
						num14 = j;
						if (j == num13)
						{
							*(int*)ptr3 = ((lzham_node*)ptr6)->m_left;
							*(int*)ptr4 = ((lzham_node*)ptr6)->m_right;
							break;
						}
					}
					else if ((((lzham_search_accelerator*)@this)->m_all_matches & 1) == 1)
					{
						((lzham_dict_match*)ptr2)->m_len = (short)(j - 2);
						((lzham_dict_match*)ptr2)->m_dist = num16;
						ptr2 = (byte*)ptr2 + sizeof(lzham_dict_match);
					}
					else if ((uint)num14 > 2u && num14 == j)
					{
						int dist = ((lzham_dict_match*)ptr2)[-1L].m_dist;
						int dist2 = num16;
						compute_lzx_position_slot.Invoke(((lzham_search_accelerator*)@this)->m_pLZBase, dist, &num, &num2);
						compute_lzx_position_slot.Invoke(((lzham_search_accelerator*)@this)->m_pLZBase, dist2, &num3, &num4);
						if ((uint)num3 < (uint)num || ((uint)num3 >= 8u && num3 == num && (uint)(num4 & 0xF) < (uint)(num2 & 0xF)))
						{
							((lzham_dict_match*)ptr2)[-1L].m_dist = num16;
						}
						else if ((uint)j < (uint)num13 && (uint)num3 <= (uint)num)
						{
							int num19 = (byte)((sbyte*)ptr5)[(uint)j];
							int num20 = (byte)((sbyte*)ptr)[(uint)((num10 - dist + j) & ((lzham_search_accelerator*)@this)->m_max_dict_size_mask)];
							int num21 = (byte)((sbyte*)g_hamming_dist.Pointer)[(uint)(num20 ^ num19)];
							int num22 = (byte)((sbyte*)ptr7)[(uint)j];
							if ((uint)(byte)((sbyte*)g_hamming_dist.Pointer)[(uint)(num22 ^ num19)] < (uint)num21)
							{
								((lzham_dict_match*)ptr2)[-1L].m_dist = num16;
							}
						}
					}
					int num23;
					if ((byte)((sbyte*)ptr7)[(uint)j] < (byte)((sbyte*)ptr5)[(uint)j])
					{
						*(int*)ptr3 = num12;
						ptr3 = &((lzham_node*)ptr6)->m_right;
						num23 = ((lzham_node*)ptr6)->m_right;
					}
					else
					{
						*(int*)ptr4 = num12;
						ptr4 = &((lzham_node*)ptr6)->m_left;
						num23 = ((lzham_node*)ptr6)->m_left;
					}
					if (num23 == num12)
					{
						break;
					}
					num12 = num23;
				}
				int num24 = (int)(((long)ptr2 - (long)(&inlineArray256_lzham_dict_match)) / 6L);
				if (num24 != 0)
				{
					((lzham_dict_match*)ptr2)[-1L].m_dist |= int.MinValue;
					int num25 = (((uint)num24 >= (uint)((lzham_search_accelerator*)@this)->m_max_matches) ? ((lzham_search_accelerator*)@this)->m_max_matches : num24);
					int num26 = atomic_exchange_add.Invoke(&((lzham_search_accelerator*)@this)->m_next_match_ref, num25);
					llvm_memcpy_p0_p0_i64.Invoke(vector_struct_lzham_dict_match_Operator.Invoke(&((lzham_search_accelerator*)@this)->m_matches, num26), Unsafe.AsPointer(ref Unsafe.AddByteOffset(ref inlineArray256_lzham_dict_match, (nint)(uint)(num24 - num25) * (nint)sizeof(lzham_dict_match))), 6L * (long)(uint)num25, isVolatile: false);
					atomic_exchange32.Invoke(vector_long_Operator.Invoke(&((lzham_search_accelerator*)@this)->m_match_refs, num6 - ((lzham_search_accelerator*)@this)->m_fill_lookahead_pos), num26);
				}
				else
				{
					atomic_exchange32.Invoke(vector_long_Operator.Invoke(&((lzham_search_accelerator*)@this)->m_match_refs, num6 - ((lzham_search_accelerator*)@this)->m_fill_lookahead_pos), -2);
				}
				num6++;
				num8 += -1;
				num7++;
			}
			while (num8 != 0)
			{
				int i2 = num6 & ((lzham_search_accelerator*)@this)->m_max_dict_size_mask;
				((lzham_node*)vector_struct_lzham_node_Operator.Invoke(&((lzham_search_accelerator*)@this)->m_nodes, i2))->m_left = 0;
				((lzham_node*)vector_struct_lzham_node_Operator.Invoke(&((lzham_search_accelerator*)@this)->m_nodes, i2))->m_right = 0;
				atomic_exchange32.Invoke(vector_long_Operator.Invoke(&((lzham_search_accelerator*)@this)->m_match_refs, num6 - ((lzham_search_accelerator*)@this)->m_fill_lookahead_pos), -2);
				num6++;
				num8 += -1;
				num7++;
			}
			atomic_increment32.Invoke(&((lzham_search_accelerator*)@this)->m_num_completed_helper_threads);
		}
	}
}
