using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("??0node@lzcompressor@lzham@@QEAA@XZ")]
[DemangledName("public: __cdecl lzham::lzcompressor::node::node(void)")]
internal static partial class node_Constructor
{
	public unsafe static void* Invoke(void* @this)
	{
		unchecked
		{
			lzham_lzcompressor_node_state* node_states = (lzham_lzcompressor_node_state*)(&((lzham_lzcompressor_node*)@this)->m_node_states);
			lzham_lzcompressor_node_state* ptr = node_states + 4L;
			lzham_lzcompressor_node_state* intPtr = node_states;
			while (true)
			{
				void* ptr2 = intPtr;
				node_state_Constructor.Invoke(ptr2);
				lzham_lzcompressor_node_state* ptr3 = (lzham_lzcompressor_node_state*)ptr2 + 1;
				if (ptr3 == ptr)
				{
					break;
				}
				intPtr = ptr3;
			}
			return @this;
		}
	}
}
