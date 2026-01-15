using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?clear@node@lzcompressor@lzham@@QEAAXXZ")]
[DemangledName("public: void __cdecl lzham::lzcompressor::node::clear(void)")]
[CleanName("clear")]
internal static partial class clear_xf8fic
{
	[return: NativeType("void")]
	public unsafe static void Invoke(void* @this)
	{
		unchecked((lzham_lzcompressor_node*)@this)->m_num_node_states = 0;
	}
}
