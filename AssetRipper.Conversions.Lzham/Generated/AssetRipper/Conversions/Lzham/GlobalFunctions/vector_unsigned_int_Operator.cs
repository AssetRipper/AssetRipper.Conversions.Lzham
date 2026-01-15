using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("??A?$vector@I@lzham@@QEAAAEAII@Z")]
[DemangledName("public: unsigned int & __cdecl lzham::vector<unsigned int>::operator[](unsigned int)")]
internal static partial class vector_unsigned_int_Operator
{
	[return: NativeType("unsigned int &")]
	public unsafe static void* Invoke(void* @this, [NativeType("unsigned int")] int i)
	{
		return unchecked((byte*)((lzham_vector*)@this)->m_p + (nint)(uint)i * (nint)4);
	}
}
