using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Intrinsics.Implemented;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?add_state@node@lzcompressor@lzham@@QEAAXHHAEBUlzdecision@23@AEAVstate@23@_KI@Z")]
[DemangledName("public: void __cdecl lzham::lzcompressor::node::add_state(int, int, struct lzham::lzcompressor::lzdecision const &, class lzham::lzcompressor::state &, unsigned __int64, unsigned int)")]
internal static partial class add_state
{
	[return: NativeType("void")]
	public unsafe static void Invoke(void* @this, [NativeType("int")] int parent_index, [NativeType("int")] int parent_state_index, [NativeType("struct lzham::lzcompressor::lzdecision const &")] void* lzdec, [NativeType("class lzham::lzcompressor::state &")] void* parent_state, [NativeType("unsigned __int64")] long total_cost, [NativeType("unsigned int")] int total_complexity)
	{
		lzham_lzcompressor_state_base lzham_lzcompressor_state_base2 = default(lzham_lzcompressor_state_base);
		save_partial_state.Invoke(parent_state, &lzham_lzcompressor_state_base2);
		partial_advance.Invoke(&lzham_lzcompressor_state_base2, lzdec);
		unchecked
		{
			for (int i = ((lzham_lzcompressor_node*)@this)->m_num_node_states - 1; i >= 0; i = checked(i + -1))
			{
				void* ptr = (byte*)(&((lzham_lzcompressor_node*)@this)->m_node_states) + (nint)i * (nint)sizeof(lzham_lzcompressor_node_state);
				if (!state_base_Equals.Invoke(&((lzham_lzcompressor_node_state*)ptr)->m_saved_state, &lzham_lzcompressor_state_base2))
				{
					continue;
				}
				if ((ulong)total_cost < (ulong)((lzham_lzcompressor_node_state*)ptr)->m_total_cost || (total_cost == ((lzham_lzcompressor_node_state*)ptr)->m_total_cost && (uint)total_complexity < (uint)((lzham_lzcompressor_node_state*)ptr)->m_total_complexity))
				{
					((lzham_lzcompressor_node_state*)ptr)->m_parent_index = (short)parent_index;
					((lzham_lzcompressor_node_state*)ptr)->m_parent_state_index = (sbyte)parent_state_index;
					llvm_memcpy_p0_p0_i64.Invoke(&((lzham_lzcompressor_node_state*)ptr)->m_lzdec, lzdec, 12L, isVolatile: false);
					((lzham_lzcompressor_node_state*)ptr)->m_total_cost = total_cost;
					((lzham_lzcompressor_node_state*)ptr)->m_total_complexity = total_complexity;
					for (; i > 0 && ((ulong)((lzham_lzcompressor_node_state*)(&((lzham_lzcompressor_node*)@this)->m_node_states))[i].m_total_cost < (ulong)((lzham_lzcompressor_node_state*)(&((lzham_lzcompressor_node*)@this)->m_node_states))[checked(i - 1)].m_total_cost || (((lzham_lzcompressor_node_state*)(&((lzham_lzcompressor_node*)@this)->m_node_states))[i].m_total_cost == ((lzham_lzcompressor_node_state*)(&((lzham_lzcompressor_node*)@this)->m_node_states))[checked(i - 1)].m_total_cost && (uint)((lzham_lzcompressor_node_state*)(&((lzham_lzcompressor_node*)@this)->m_node_states))[i].m_total_complexity < (uint)((lzham_lzcompressor_node_state*)(&((lzham_lzcompressor_node*)@this)->m_node_states))[checked(i - 1)].m_total_complexity)); i = checked(i + -1))
					{
						swap_bdix5g.Invoke(Right: (byte*)(&((lzham_lzcompressor_node*)@this)->m_node_states) + (nint)checked(i - 1) * (nint)sizeof(lzham_lzcompressor_node_state), Left: (byte*)(&((lzham_lzcompressor_node*)@this)->m_node_states) + (nint)i * (nint)sizeof(lzham_lzcompressor_node_state));
					}
				}
				return;
			}
			int j;
			for (j = ((lzham_lzcompressor_node*)@this)->m_num_node_states; j > 0; j = checked(j + -1))
			{
				void* ptr2 = (byte*)(&((lzham_lzcompressor_node*)@this)->m_node_states) + (nint)checked(j - 1) * (nint)sizeof(lzham_lzcompressor_node_state);
				if ((ulong)total_cost > (ulong)((lzham_lzcompressor_node_state*)ptr2)->m_total_cost || (total_cost == ((lzham_lzcompressor_node_state*)ptr2)->m_total_cost && (uint)total_complexity >= (uint)((lzham_lzcompressor_node_state*)ptr2)->m_total_complexity))
				{
					break;
				}
			}
			if (j != 4)
			{
				int num = ((lzham_lzcompressor_node*)@this)->m_num_node_states - j;
				int num2 = (((uint)((lzham_lzcompressor_node*)@this)->m_num_node_states >= 4u) ? (num - 1) : num);
				if (num2 != 0)
				{
					llvm_memmove_p0_p0_i64.Invoke((byte*)(&((lzham_lzcompressor_node*)@this)->m_node_states) + (nint)checked(j + 1) * (nint)sizeof(lzham_lzcompressor_node_state), (byte*)(&((lzham_lzcompressor_node*)@this)->m_node_states) + (nint)j * (nint)sizeof(lzham_lzcompressor_node_state), 56L * (long)(uint)num2, isVolatile: false);
				}
				void* ptr3 = (byte*)(&((lzham_lzcompressor_node*)@this)->m_node_states) + (nint)j * (nint)sizeof(lzham_lzcompressor_node_state);
				((lzham_lzcompressor_node_state*)ptr3)->m_parent_index = (short)parent_index;
				((lzham_lzcompressor_node_state*)ptr3)->m_parent_state_index = (sbyte)parent_state_index;
				llvm_memcpy_p0_p0_i64.Invoke(&((lzham_lzcompressor_node_state*)ptr3)->m_lzdec, lzdec, 12L, isVolatile: false);
				((lzham_lzcompressor_node_state*)ptr3)->m_total_cost = total_cost;
				((lzham_lzcompressor_node_state*)ptr3)->m_total_complexity = total_complexity;
				llvm_memcpy_p0_p0_i64.Invoke(&((lzham_lzcompressor_node_state*)ptr3)->m_saved_state, &lzham_lzcompressor_state_base2, 24L, isVolatile: false);
				((lzham_lzcompressor_node*)@this)->m_num_node_states = (((uint)(((lzham_lzcompressor_node*)@this)->m_num_node_states + 1) >= 4u) ? 4 : (((lzham_lzcompressor_node*)@this)->m_num_node_states + 1));
			}
		}
	}
}
