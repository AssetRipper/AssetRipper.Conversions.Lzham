using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("??A?$vector@Udict_match@lzham@@@lzham@@QEAAAEAUdict_match@1@I@Z")]
[DemangledName("public: struct lzham::dict_match & __cdecl lzham::vector<struct lzham::dict_match>::operator[](unsigned int)")]
internal static partial class vector_struct_lzham_dict_match_Operator
{
	[return: NativeType("struct lzham::dict_match &")]
	public unsafe static void* Invoke(void* @this, [NativeType("unsigned int")] int i)
	{
		return unchecked((byte*)((lzham_vector*)@this)->m_p + (nint)(uint)i * (nint)sizeof(lzham_dict_match));
	}
}
