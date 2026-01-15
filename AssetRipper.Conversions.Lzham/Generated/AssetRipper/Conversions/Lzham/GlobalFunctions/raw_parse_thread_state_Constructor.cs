using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("??0raw_parse_thread_state@lzcompressor@lzham@@QEAA@XZ")]
[DemangledName("public: __cdecl lzham::lzcompressor::raw_parse_thread_state::raw_parse_thread_state(void)")]
internal static partial class raw_parse_thread_state_Constructor
{
	public unsafe static void* Invoke(void* @this)
	{
		unchecked
		{
			lzham_lzcompressor_state* initial_state = &((lzham_lzcompressor_raw_parse_thread_state*)@this)->m_initial_state;
			state_Constructor.Invoke(initial_state);
			if (ExceptionInfo.Current != null)
			{
				return null;
			}
			lzham_lzcompressor_node* nodes = (lzham_lzcompressor_node*)(&((lzham_lzcompressor_raw_parse_thread_state*)@this)->m_nodes);
			lzham_lzcompressor_node* ptr = nodes + 3073L;
			lzham_lzcompressor_node* intPtr = nodes;
			while (true)
			{
				void* ptr2 = intPtr;
				node_Constructor.Invoke(ptr2);
				if (ExceptionInfo.Current != null)
				{
					break;
				}
				lzham_lzcompressor_node* ptr3 = (lzham_lzcompressor_node*)ptr2 + 1;
				if (ptr3 != ptr)
				{
					intPtr = ptr3;
					continue;
				}
				lzham_vector* best_decisions = &((lzham_lzcompressor_raw_parse_thread_state*)@this)->m_best_decisions;
				vector_struct_lzham_lzcompressor_lzdecision_Constructor.Invoke(best_decisions);
				if (ExceptionInfo.Current != null)
				{
					break;
				}
				vector_struct_lzham_lzcompressor_lzpriced_decision_Constructor.Invoke(&((lzham_lzcompressor_raw_parse_thread_state*)@this)->m_temp_decisions);
				if (ExceptionInfo.Current == null)
				{
					return @this;
				}
				ExceptionInfo current = ExceptionInfo.Current;
				ExceptionInfo.Current = null;
				vector_struct_lzham_lzcompressor_lzdecision_Destructor.Invoke(best_decisions);
				if (ExceptionInfo.Current != null)
				{
					return null;
				}
				ExceptionInfo.Current = current;
				break;
			}
			ExceptionInfo current2 = ExceptionInfo.Current;
			ExceptionInfo.Current = null;
			state_Destructor.Invoke(initial_state);
			if (ExceptionInfo.Current != null)
			{
				return null;
			}
			ExceptionInfo.Current = current2;
			return null;
		}
	}
}
