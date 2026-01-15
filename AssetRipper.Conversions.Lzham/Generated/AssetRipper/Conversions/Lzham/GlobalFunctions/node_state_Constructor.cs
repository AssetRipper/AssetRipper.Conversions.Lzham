using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("??0node_state@lzcompressor@lzham@@QEAA@XZ")]
[DemangledName("public: __cdecl lzham::lzcompressor::node_state::node_state(void)")]
internal static partial class node_state_Constructor
{
	public unsafe static void* Invoke(void* @this)
	{
		unchecked
		{
			lzdecision_Constructor_y4m6um.Invoke(&((lzham_lzcompressor_node_state*)@this)->m_lzdec);
			_ = &((lzham_lzcompressor_node_state*)@this)->m_saved_state;
			return @this;
		}
	}
}
