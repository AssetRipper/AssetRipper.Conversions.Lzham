using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("??A?$vector@J@lzham@@QEAAAEAJI@Z")]
[DemangledName("public: long & __cdecl lzham::vector<long>::operator[](unsigned int)")]
internal static partial class vector_long_Operator
{
	[return: NativeType("long &")]
	public unsafe static void* Invoke(void* @this, [NativeType("unsigned int")] int i)
	{
		return unchecked((byte*)((lzham_vector*)@this)->m_p + (nint)(uint)i * (nint)4);
	}
}
