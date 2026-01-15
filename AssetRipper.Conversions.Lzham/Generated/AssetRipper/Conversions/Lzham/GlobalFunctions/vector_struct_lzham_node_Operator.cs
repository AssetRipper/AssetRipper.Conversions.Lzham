using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("??A?$vector@Unode@lzham@@@lzham@@QEAAAEAUnode@1@I@Z")]
[DemangledName("public: struct lzham::node & __cdecl lzham::vector<struct lzham::node>::operator[](unsigned int)")]
internal static partial class vector_struct_lzham_node_Operator
{
	[return: NativeType("struct lzham::node &")]
	public unsafe static void* Invoke(void* @this, [NativeType("unsigned int")] int i)
	{
		return unchecked((byte*)((lzham_vector*)@this)->m_p + (nint)(uint)i * (nint)sizeof(lzham_node));
	}
}
